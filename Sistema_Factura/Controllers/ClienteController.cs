using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sistema_Factura.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema_Factura.Controllers
{
    public class ClienteController : Controller
    {
        private readonly Sistema_FacturaContext _context;
        public ClienteController(Sistema_FacturaContext context) => _context = context;


        public async Task<IActionResult> Cliente()
        {
            return View(await _context.Cliente.ToListAsync());
        }
    }
}
