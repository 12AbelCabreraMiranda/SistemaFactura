using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sistema_Factura.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema_Factura.Areas.CrearFactura.Controllers
{
    public class CrearFacturaController : Controller
    {
        private readonly Sistema_FacturaContext _context;
        public CrearFacturaController(Sistema_FacturaContext context) => _context = context;


        [Area("CrearFactura")]
        public IActionResult CrearFactura()
        {
            return View();
        }


        //******CONTROLADOR FUNCIONA DATATABLE CON AJAX************+
        [HttpGet]
        public async Task<IActionResult> DataTable()
        {
            var produc = await _context.Producto.Where(x => x.EstadoProducto == 1).ToListAsync();
            //var productoAjax = (from p in _context.Producto

            //                    select new
            //                    {         
            //                        p.ProductoId,
            //                        p.CodigoProducto,
            //                        p.NombreProducto, 
            //                        p.PrecioProductoCompra
            //                    }).ToListAsync();


            return Json(new { data = produc });
        }
    }
}
