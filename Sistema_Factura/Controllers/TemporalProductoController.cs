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
        //INYECCION DEL CONTEXT
        private readonly Sistema_FacturaContext _context;
       
        public TemporalProductoController(Sistema_FacturaContext context) => _context = context;
       
        public IActionResult Index()
        {            
            return View();
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

        //ANULAR LOS PRODUCTOS TEMPORALES
        public IActionResult AnularFactura()
        {                     
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
        
        //ANULA TODO LOS PRODUCTOS AGREGADOS EN: DATATABBLE    
        public async Task<IActionResult> AnularProducto(int Id)
        {
            var _tempProducto = await _context.TempProducto.FindAsync(Id);
            _context.TempProducto.Remove(_tempProducto);
            _context.SaveChanges();

            return RedirectToAction(nameof(BuscarProducto));
        }

        //AGREGAR PRODUCTO TEMPORAL
        [HttpPost]        
        public IActionResult AgregarProductoTemporal(AgregarProducto agregarProductoModel)
        {
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
                    //PROCEDIMEINTO PARA AGREGAR PRODUCTO A FACTURA
                    var _consultaCodigo = _context.Producto.Where(p => p.CodigoProducto.Equals(agregarProductoModel.CodigoProducto)).FirstOrDefault(); //Consulta producto
                    //Consulta Model TempProducto
                    var _consultaTempProducto = _context.TempProducto.Where(t=>t.ProductoId.Equals(_consultaCodigo.ProductoId)).FirstOrDefault();
                    //CONSULTA PARA ELEGIR EL TEMPPRODUCTOID Y ACTUALIZARLO
                    var _listaTempProducto=_context.TempProducto.Where(t=>t.ProductoId.Equals(_consultaCodigo.ProductoId)).ToList();

                    if (!_listaTempProducto.Count.Equals(0))
                    {
                        var _updateCantidad = agregarProductoModel.Cantidad + _consultaTempProducto.Cantidad_temp;//Suma el dato del servidor y del viewModel
                        var _updateSubTotal = _consultaTempProducto.PrecioVenta_temp * _updateCantidad;//multiplica con la nueva cantidad

                        //ACTUALIZA CUANDO SE AGREGA PRODUCTOS QUE YA HA SIDO AGREGADO
                        var add_tempProductoUpdate = _context.TempProducto.Find(_consultaTempProducto.TempProductoId);                        
                        add_tempProductoUpdate.Cantidad_temp = _updateCantidad;
                        add_tempProductoUpdate.SubTotal_temp = _updateSubTotal;

                        _context.TempProducto.Update(add_tempProductoUpdate);
                        _context.SaveChanges();
                        TempData["messageProductoAgregado"] = "Producto Agregado";
                    }
                    else
                    {
                        //CREA UNA FILA CON EL PRODUCTO DIFERENTE EN DATATABLE
                        var add_tempProducto = new TempProducto()
                        {
                            Cantidad_temp = agregarProductoModel.Cantidad,
                            PrecioVenta_temp = agregarProductoModel.PrecioProductoCompra,
                            ProductoId = agregarProductoModel.ProductoId,
                            SubTotal_temp = _subTotal                            
                        };
                        _context.TempProducto.Add(add_tempProducto);
                        _context.SaveChanges();
                        TempData["messageProductoAgregado"] = "Producto Agregado";
                    }

                }
            }
            return RedirectToAction(nameof(BuscarProducto));
        }
        
        //GUARDAR FACTURA VERSION
        [HttpPost]
        public IActionResult GuardarFactura(AgregarProducto agregarProducto)
        {
            //Consulta de los registros en el Modelo: TempProducto
            var tempPro = (from p in _context.TempProducto
                           select p).ToList();
            
            //CONSULTA NIT Y EXTRA EL ID DEL CLIENTE
            var _idNit = _context.Cliente.Where(c=>c.Nit.Equals(agregarProducto.NitCliente_temp)).FirstOrDefault();

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
                    ClienteId = _idNit.ClienteId,
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
                        TempData["messageFacturaSave"] = "Factura creado";
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
    }
}