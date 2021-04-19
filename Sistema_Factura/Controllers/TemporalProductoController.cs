using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sistema_Factura.DataContext;
using Sistema_Factura.Models;
using Sistema_Factura.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema_Factura.Controllers
{
    public class TemporalProductoController : Controller
    {
        //Inyección del contexto
        private readonly Sistema_FacturaContext _context;
        public TemporalProductoController(Sistema_FacturaContext context) => _context = context;

        //public static decimal totalFact=0;
        public async Task<IActionResult> Index()
        {
            var tempP = from t in _context.TempProducto
                        select t;

            return View(await tempP.Include(p => p.Producto).ToListAsync());
        }
        public IActionResult BuscarProducto()
        {
            return View();
        }

        [HttpPost]
        //BUSCA CODIGO DE PRODUCTO
        public IActionResult BuscarProducto(int CodigoProd)
        {
            if (ModelState.IsValid)
            {
                //Buscar codigo producto
                var _buscarProducto = (from p in _context.Producto
                                       where p.CodigoProducto == CodigoProd

                                       select new AgregarProducto
                                       {
                                           ProductoId = p.ProductoId,
                                           NombreProducto = p.NombreProducto,
                                           CodigoProducto = p.CodigoProducto,
                                           PrecioProductoCompra = p.PrecioProductoCompra
                                       }).ToList();

                //Consultar producto si existe
                var _buscarCodigoProducto = _context.Producto.Where(c => c.CodigoProducto.Equals(CodigoProd)).FirstOrDefault();

                if (!_buscarProducto.Count.Equals(0))
                {
                    //Consulta para la propiedad PrecioProductoCompra
                    var _precioCompraProducto = _context.Producto.Where(r => r.CodigoProducto.Equals(CodigoProd)).FirstOrDefault();

                    //Procedimiento para Ganarle un porsentaje del 10% a las ventas por los productos registrados(comprados)
                    var precioVentaP = _precioCompraProducto.PrecioProductoCompra + (_precioCompraProducto.PrecioProductoCompra * 10) / 100;

                    AgregarProducto ProductoModel = new AgregarProducto
                    {
                        ProductoId = _buscarProducto[0].ProductoId,
                        NombreProducto = _buscarProducto[0].NombreProducto,
                        CodigoProducto = _buscarProducto[0].CodigoProducto,
                        PrecioProductoCompra = precioVentaP
                    };
                    return View(ProductoModel);
                }
                else
                {
                    TempData["messageNoCodigoProducto"] = "No hay producto registrado con el código ingresado";
                }
            }
            return View();
        }
        [HttpPost]
        //AGREGA PRODUCTOS A DATATABLE TEMPORAL
        public IActionResult AgregarProducto(AgregarProducto agregarProductoModel)
        {
            //Query para obtener Id del nitCliente.
            var _nitCliente_temp = _context.Cliente.Where(n => n.Nit.Equals(agregarProductoModel.NitCliente_temp)).FirstOrDefault();
            

            //Procedimiento para los subtotales de los productos
            var _subTotal = agregarProductoModel.PrecioProductoCompra * agregarProductoModel.Cantidad;

            if (agregarProductoModel.Cantidad <= 0)
            {
                TempData["messageCantidad"] = "La cantidad debe ser mayor a cero";
                return RedirectToAction(nameof(BuscarProducto));
            }
            else
            {
                if (agregarProductoModel.PrecioProductoCompra == 0)
                {
                    TempData["messageSinRegistros"] = "Debe agregar registro de un producto";

                    return RedirectToAction(nameof(BuscarProducto));
                }
                else
                {
                    //Consulta Model TempProducto
                    var validarNit = _context.TempProducto.FirstOrDefault();

                    //Validación si existe registros
                    if (validarNit == null)
                    {
                        var _validar_nit = _context.Cliente.Where(c=>c.Nit.Equals(agregarProductoModel.NitCliente_temp)).ToList();
                        
                        if (_validar_nit.Count.Equals(0))
                        {
                            TempData["messageNitInvalido"] = "El nit no existe en nuestro sistema";
                            return RedirectToAction(nameof(BuscarProducto));
                        }
                        else
                        {

                            var add_tempProducto = new TempProducto()
                            {
                                Cantidad_temp = agregarProductoModel.Cantidad,
                                PrecioVenta_temp = agregarProductoModel.PrecioProductoCompra,
                                ProductoId = agregarProductoModel.ProductoId,
                                SubTotal_temp = _subTotal,
                                IdCliente_temp = _nitCliente_temp.ClienteId
                            };
                            _context.TempProducto.Add(add_tempProducto);
                            _context.SaveChanges();
                        }
                    }
                    else
                    {
                        //Comparar Id de los clientes, de acuerdo al Numero de Nit Consultado
                        if (validarNit.IdCliente_temp.Equals(_nitCliente_temp.ClienteId))
                        {
                            //Guardar producto temporal para la factura
                            var add_tempProducto = new TempProducto()
                            {
                                Cantidad_temp = agregarProductoModel.Cantidad,
                                PrecioVenta_temp = agregarProductoModel.PrecioProductoCompra,
                                ProductoId = agregarProductoModel.ProductoId,
                                SubTotal_temp = _subTotal,
                                IdCliente_temp = _nitCliente_temp.ClienteId
                            };
                            _context.TempProducto.Add(add_tempProducto);
                            _context.SaveChanges();
                        }
                        else
                        {
                            TempData["messageNitDiferente"] = "Hay una factura Pendiente. Vender la Factura pendiente para poder" +
                                " crear una nueva Factura.";

                            return RedirectToAction(nameof(BuscarProducto));
                        }
                    }
                }
            }
            return RedirectToAction(nameof(BuscarProducto));

        }

        //CREA LA FACTURA
        public IActionResult GuardarFactura()
        {
            //Consulta de los registros en el Modelo: TempProducto
            var tempPro = (from p in _context.TempProducto
                           select p).ToList();
            //Consulta Nit en Modelo TempProducto
            var _nitTemPro = _context.TempProducto.FirstOrDefault();

            //Obtener suma Total de los productos a vender de la factura
            var _totalFactura = (from s in _context.TempProducto
                                 select s.SubTotal_temp).Sum();

            //Fecha del sistema
            DateTime FechaSistema = System.DateTime.Now;

            if (!tempPro.Count.Equals(0))
            {
                //Guardar en Modelo Factura
                var _factura = new Factura
                {
                    TotalPrecio = _totalFactura,
                    ClienteId = _nitTemPro.IdCliente_temp,
                    FechaFactura = FechaSistema,
                    EstadoFactura = 1
                };
                _context.Factura.Add(_factura);
                _context.SaveChanges();

                //Guardar Rango de registros en Modelo: DetalleFactura
                if (!tempPro.Count.Equals(0))
                {
                    foreach (var item in tempPro)
                    {
                        //Guarda en Modelo Detalle Factura
                        var _detalleFactura = new DetalleFactura
                        {
                            Cantidad = item.Cantidad_temp,
                            PrecioVenta = item.PrecioVenta_temp,
                            FacturaId = _factura.FacturaId,// El ID, Lo he tomado como el numero de factura
                            ProductoId = item.ProductoId,
                            SubTotal = item.SubTotal_temp
                        };
                        _context.DetalleFactura.AddRange(_detalleFactura);
                        _context.SaveChanges();
                    }
                }
                //Elimina los registros del modelo: TempProducto            
                var x = (from y in _context.TempProducto
                         select y).ToList();
                _context.TempProducto.RemoveRange(x);
                _context.SaveChanges();

                return RedirectToAction(nameof(BuscarProducto));
            }
            else
            {
                TempData["messageNoFactura"] = "No se puede crear Factura sin registros";

                return RedirectToAction(nameof(BuscarProducto));
            }
        }

        //ANULAR LOS PRODUCTOS TEMPORALES
        public IActionResult AnularFactura()
        {
            //Elimina los registros del modelo: TempProducto            
            var x = (from y in _context.TempProducto
                     select y).ToList();
            _context.TempProducto.RemoveRange(x);
            _context.SaveChanges();

            return RedirectToAction(nameof(BuscarProducto));
        }

        //MUESTRA LOS PRODUCTOS AGREGADOS EN: DATATABLE
        public PartialViewResult ProductosAgregados()
        {
            var temp = _context.TempProducto.Include(p => p.Producto).ToList();
            return PartialView("_TempProducto", temp);
        }
    }
}
