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
        public async Task<IActionResult> IndexAsync()
        {
            


            var tempP = from t in _context.TempProducto                              
                              select t;
            
            return View(await tempP.Include(p=>p.Producto).ToListAsync());
        }
        public IActionResult BuscarProducto()
        {
            return View();
        }

        [HttpPost]
        //Metodo buscar producto para agregar a la Factura
        public IActionResult BuscarProducto(int CodigoProd)
        {            
            //Buscar codigo producto
            var BuscarProducto = (from p in _context.Producto
                                  where p.CodigoProducto == CodigoProd

                                  select new AgregarProducto
                                  {
                                      ProductoId = p.ProductoId,
                                      NombreProducto = p.NombreProducto,
                                      CodigoProducto = p.CodigoProducto,
                                      PrecioProductoCompra = p.PrecioProductoCompra
                                  }).ToList();

            //Consulta para la propiedad PrecioProductoCompra
            var _precioCompraProducto = _context.Producto.Where(r=>r.CodigoProducto.Equals(CodigoProd)).FirstOrDefault();

            //Procedimiento para Ganarle un porsentaje del 10% a las ventas por los productos registrados(comprados)
            var precioVentaP = _precioCompraProducto.PrecioProductoCompra + (_precioCompraProducto.PrecioProductoCompra*10)/100;

            AgregarProducto ProductoModel = new AgregarProducto
            {
                ProductoId = BuscarProducto[0].ProductoId,
                NombreProducto = BuscarProducto[0].NombreProducto,
                CodigoProducto = BuscarProducto[0].CodigoProducto,
                PrecioProductoCompra = precioVentaP
            };            

            return View(ProductoModel);
        }
        [HttpPost]
        public IActionResult AgregarProducto( AgregarProducto agregarProductoModel)
        {
            //Calculo de total factura
            //var sumarPrecio = (from s in _context.TempProducto
            //                   select s.PrecioVenta_temp).Sum();

            //calcular total factura   
            //totalFact = sumarPrecio + agregarProductoModel.PrecioProductoCompra;
            //ViewBag.totalF = totalFact;

            //Guardar producto temporal para la factura
            var add_tempProducto  = new TempProducto()
            {
                Cantidad_temp = agregarProductoModel.Cantidad,
                PrecioVenta_temp = agregarProductoModel.PrecioProductoCompra,
                ProductoId=agregarProductoModel.ProductoId
            };

            _context.TempProducto.Add(add_tempProducto);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

        //Se crea la factura con los productos vendidos
        public IActionResult GuardarFactura()
        {
            //Consulta de los registros en el Modelo: TempProducto
            var tempPro = (from p in _context.TempProducto
                           select p).ToList();
            
            //Obtener suma Total de los productos a vender de la factura
            var _totalPrecio = (from s in _context.TempProducto
                               select s.PrecioVenta_temp).Sum();

            //Fecha del sistema
            DateTime FechaSistema = System.DateTime.Now;

            //Guardar en Modelo Factura
            var _factura = new Factura
            {                
                TotalPrecio = _totalPrecio,
                EstadoFactura = 1,
                ClienteId = 2,
                FechaFactura=FechaSistema
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
                        FacturaId=_factura.FacturaId,// El ID, Lo he tomado como el numero de factura
                        ProductoId = item.ProductoId
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
    }
}
