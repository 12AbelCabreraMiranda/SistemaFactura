using ClosedXML.Excel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using Sistema_Factura.DataContext;
using Sistema_Factura.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema_Factura.Controllers
{
    public class FacturasController : Controller
    {
        private readonly Sistema_FacturaContext _context;
        public FacturasController(Sistema_FacturaContext context) => _context = context;

        //METODO LISTAR TODAS LAS FACTURAS CON ESTADO ==1
        public async Task<IActionResult> Facturas(string buscarNit, string fechaInicio, string fechaFin)
        {
            //Search Cliente por su Nit +++++++++++++++++++++++++++++++++++++++++++++++++++++           
            var _nitFactura = from f in _context.Factura
                              join c in _context.Cliente
                              on f.ClienteId equals c.ClienteId
                              where f.EstadoFactura == 1
                              select f;
            //BUSCA POR NIT DEL CLIENTE
            if (!String.IsNullOrEmpty(buscarNit))
            {
                _nitFactura = _nitFactura.Where(d => d.Cliente.Nit.Contains(buscarNit));

                return View(await _nitFactura.Include(c => c.Cliente).ToListAsync());
            }
            //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

            //BUSCA RANGO DE FECHAS DE FACTURAS********************************************
            var startDate = fechaInicio;
            var endDate = fechaFin;

            DateTime dtStart = Convert.ToDateTime(startDate);
            DateTime dtEndDate = Convert.ToDateTime(endDate).AddDays(1);

            var _rangoFecha_Factura = from r in _context.Factura
                                      where r.EstadoFactura == 1
                                      select r;

            if (!String.IsNullOrEmpty(fechaInicio) && !String.IsNullOrEmpty(fechaFin))
            {
                _rangoFecha_Factura = _rangoFecha_Factura.Where(s => s.FechaFactura >= dtStart && s.FechaFactura < dtEndDate);
                return View(await _rangoFecha_Factura.Include(d => d.Cliente).ToListAsync());
            }
            //*******************************************************************************

            return View(await _nitFactura.Include(c => c.Cliente).ToListAsync());
        }


        //METODO PARA CAMBIAR ESTADO DE FACTURA
        public IActionResult EliminarFactura(int id)
        {           
            var _facturaStatu = _context.Factura.Find(id);
            _facturaStatu.EstadoFactura = 0;

            _context.Update(_facturaStatu);
            _context.SaveChanges();

            return RedirectToAction(nameof(Facturas));
        }

        //METODO DETALLE FACTURA
        public async Task<IActionResult> DetalleFactura(int id)
        {
            var _detalleFactura = from d in _context.DetalleFactura
                                  join f in _context.Factura on d.FacturaId equals f.FacturaId
                                  join p in _context.Producto on d.ProductoId equals p.ProductoId

                                  select d;

            _detalleFactura = _detalleFactura.Where(d => d.FacturaId.Equals(id));

            return View(await _detalleFactura.Include(c => c.Factura).Include(p => p.Producto).ToListAsync());            
        }

        //METODO OBTIENE FECHA DE FACTURA DEL CLIENTE
        [HttpPost]
        public JsonResult FechaFactura(int FacturaHide)
        {

            var _numeroFactura = (from f in _context.Factura
                                  where f.FacturaId == FacturaHide
                                  select f.FechaFactura.ToString("dd-MM-yyyy")).FirstOrDefault();//OBTIENE SOLO LA FECHA SIN LA HORA

            return Json(_numeroFactura);
        }

        //METODO OBTIENE NUMERO DE FACTURA DEL CLIENTE
        [HttpPost]
        public JsonResult NumeroFactura(int FacturaHide)
        {
            var _numeroFactura = (from f in _context.Factura

                                  where f.FacturaId == FacturaHide
                                  select f.FacturaId).FirstOrDefault();

            return Json(_numeroFactura);
        }

        //METODO OBTIENE NOMBRE DEL CLIENTE
        [HttpPost]
        public JsonResult NombreClienteFactura(int FacturaHide)
        {
            var _NombreClienteF = (from f in _context.Factura
                                   join c in _context.Cliente
                                   on f.ClienteId equals c.ClienteId

                                   where f.FacturaId == FacturaHide
                                   select c.NombreCliente).FirstOrDefault();

            return Json(_NombreClienteF);
        }

        //METODO OBTINE NIT DEL CLIENTE
        [HttpPost]
        public JsonResult NitClienteFactura(int FacturaHide)
        {
            var _nitClienteFactura = (from f in _context.Factura
                                      join c in _context.Cliente
                                      on f.ClienteId equals c.ClienteId

                                      where f.FacturaId == FacturaHide
                                      select c.Nit).FirstOrDefault();

            return Json(_nitClienteFactura);
        }

        //METODO OBTIENE VALOR TOTAL DE LA FACTURA DEL CLIENTE VENDIDO
        [HttpPost]
        public JsonResult TotalFactura(int FacturaHide)
        {
            var _totalFactura = (from f in _context.Factura
                                 join c in _context.Cliente
                                 on f.ClienteId equals c.ClienteId

                                 where f.FacturaId == FacturaHide
                                 select f.TotalPrecio).FirstOrDefault();

            return Json(_totalFactura);
        }

    }
}
