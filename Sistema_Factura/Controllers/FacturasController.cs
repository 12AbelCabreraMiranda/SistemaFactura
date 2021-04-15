using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sistema_Factura.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema_Factura.Controllers
{
    public class FacturasController : Controller
    {
        private readonly Sistema_FacturaContext _context;
        public FacturasController(Sistema_FacturaContext context) => _context = context;

        public async Task<IActionResult> Facturas( string buscarNit, string fechaInicio, string fechaFin)
        {
            //Relacion de 3 Modelos de datos
            //return View(await _context.DetalleFactura.Include(f => f.Factura).Include(p=>p.Producto).ToListAsync());

            //Search Cliente por su Nit +++++++++++++++++++++++++++++++++++++++++++++++++++++           
            var _nitFactura = from f in _context.Factura
                              join c in _context.Cliente
                              on f.ClienteId equals c.ClienteId
                              select f;
            //Search Cliente
            if (!String.IsNullOrEmpty(buscarNit))
            {
                _nitFactura = _nitFactura.Where(d=> d.Cliente.Nit.Contains(buscarNit));

                return View(await _nitFactura.Include(c => c.Cliente).ToListAsync());
            }
            //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

            //Buscar Facturas por rango de fechas********************************************
            var startDate = fechaInicio;
            var endDate = fechaFin;

            DateTime dtStart = Convert.ToDateTime(startDate);
            DateTime dtEndDate = Convert.ToDateTime(endDate).AddDays(1);

            var _rangoFecha_Factura = from r in _context.Factura                                      
                                      select r;

            if (!String.IsNullOrEmpty(fechaInicio) && !String.IsNullOrEmpty(fechaFin))
            {
                _rangoFecha_Factura = _rangoFecha_Factura.Where(s => s.FechaFactura >= dtStart && s.FechaFactura < dtEndDate);
                return View(await _rangoFecha_Factura.Include(d => d.Cliente).ToListAsync());
            }
            //*******************************************************************************



            return View(await _nitFactura.Include(c =>c.Cliente).ToListAsync());
        }
    }
}
