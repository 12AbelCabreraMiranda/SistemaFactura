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
