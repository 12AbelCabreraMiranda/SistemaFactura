using Microsoft.AspNetCore.Mvc;
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

        //Método para Obtener el Valor total de la Factura a Vender
        [HttpPost]
        public JsonResult BuscarTempProducto()
        {                                
            var _totalFactura = (from s in _context.TempProducto
                                 select s.SubTotal_temp).Sum();

            return Json(_totalFactura);
        }
        //Método para obtener el Nit del Cliente
        [HttpPost]
        public JsonResult BuscarNit(string nit)
        {
            var _cliente = (from s in _context.Cliente
                            where s.Nit==nit
                            select s.NombreCliente).FirstOrDefault();

            return Json(_cliente);
        }
        
        //Método para obtener el nombre del nit
        [HttpPost]
        public JsonResult MostrarNombreCliente()
        {
            var _clienteId = (from t in _context.TempProducto    
                              join c in _context.Cliente
                              on t.IdCliente_temp equals c.ClienteId
                              
                            select c.NombreCliente).FirstOrDefault();

            return Json(_clienteId);
        }

        //Método para obtener el nit
        [HttpPost]
        public JsonResult MostrarNit()
        {
            var _clienteId = (from t in _context.TempProducto
                              join c in _context.Cliente
                              on t.IdCliente_temp equals c.ClienteId

                              select c.Nit).FirstOrDefault();

            return Json(_clienteId);
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
