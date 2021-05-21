using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema_Factura.Areas.CrearFactura.Controllers
{
    public class CrearFacturaController : Controller
    {
        [Area("CrearFactura")]
        public IActionResult CrearFactura()
        {
            return View();
        }
    }
}
