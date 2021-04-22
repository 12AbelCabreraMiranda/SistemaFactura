using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Sistema_Factura.DataContext;
using Sistema_Factura.Models;
using Sistema_Factura.ViewModels;
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

        //METODO QUE OBTIENE EL VALOR TOTAL EN LOS PRODUCTOS AGREGADOS
        [HttpPost]
        public JsonResult BuscarTempProducto()
        {                                
            var _totalFactura = (from s in _context.TempProducto
                                 select s.SubTotal_temp).Sum();

            return Json(_totalFactura);
        }
        //METODO QUE OBTIENE NOMBRE DEL CLIENTE, BUSCANDO POR SU NIT
        [HttpPost]
        public JsonResult BuscarNit(string nit)
        {
            var _cliente = (from s in _context.Cliente
                            where s.Nit==nit
                            select s.NombreCliente).FirstOrDefault();
           
            return Json(_cliente);                        
        }
       
        public IActionResult Index()
        {            
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
