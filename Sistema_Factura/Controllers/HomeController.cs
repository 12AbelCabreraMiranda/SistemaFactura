using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Sistema_Factura.DataContext;
using Sistema_Factura.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema_Factura.Controllers
{
    public class HomeController : Controller
    {
        private readonly Sistema_FacturaContext _context;
        public HomeController(Sistema_FacturaContext context) => _context = context;       



        public IActionResult Index()
        {
            var tempPro = (from p in _context.TempProducto
                           //orderby p.ProductoId ascending
                          select p).ToList();

            if (!tempPro.Count.Equals(0))
            {
                foreach (var item in tempPro)
                {
                    //var prConsulta = _context.TempProducto.Where(u => u.TempProductoId.Equals(item.TempProductoId)).ToList().Last();
                    var guardarFactura = new Test
                    {                        
                        Cantidad = item.Cantidad_temp,
                        PrecioVenta = item.PrecioVenta_temp,
                        ProductoId = item.ProductoId
                    };
                    //Guarda en Modelo Factura y detalle
                    _context.Test.AddRange(guardarFactura);
                     _context.SaveChanges();

                    
                }
                
            }
            //Elimina los registros del modelo Temporal            
            var x = (from y in _context.TempProducto
                     select y).ToList();
            _context.TempProducto.RemoveRange(x);
            _context.SaveChanges();

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
