using Microsoft.AspNetCore.Mvc;
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

        public IActionResult _ProductosAddTem()
        {
            //PERMITE MOSTRAR LOS DATOS DE LOS USUARIOS CON ESTADO=1 EN TABLA
            var ProductoTemporalAgregado = _context.TempProducto.ToList();
            return View(ProductoTemporalAgregado);
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

                                  select new AgregarProducto { 
                                    ProductoId=p.ProductoId,
                                    NombreProducto=p.NombreProducto,
                                    CodigoProducto=p.CodigoProducto,
                                    PrecioProductoCompra=p.PrecioProductoCompra
                                        
                                  }).ToList();

            AgregarProducto ProductoModel = new AgregarProducto
            {
                ProductoId=BuscarProducto[0].ProductoId,
                NombreProducto = BuscarProducto[0].NombreProducto,
                CodigoProducto= BuscarProducto[0].CodigoProducto,
                PrecioProductoCompra=BuscarProducto[0].PrecioProductoCompra
            };
            
            return View(ProductoModel);
        }
        [HttpPost]
        public IActionResult AgregarProducto( AgregarProducto agregarProductoModel)
        {
            var add_tempProducto  = new TempProducto()
            {
                Cantidad_temp = agregarProductoModel.Cantidad,
                PrecioVenta_temp = agregarProductoModel.PrecioProductoCompra,
                ProductoId=agregarProductoModel.ProductoId
            };

            _context.TempProducto.Add(add_tempProducto);
            _context.SaveChanges();

            return RedirectToAction(nameof(BuscarProducto));
        }
    }
}
