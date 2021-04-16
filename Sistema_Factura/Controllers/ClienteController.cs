using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sistema_Factura.DataContext;
using Sistema_Factura.Models;
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

        public IActionResult RegistrarCliente()
        {
            return View();
        }
        [HttpPost]
        public IActionResult RegistrarCliente(Cliente clienteModel)
        {
            
            if (ModelState.IsValid)
            {               
                //Consultando si el producto existe
                var ValidarNit = _context.Cliente.Where(p => p.Nit.Equals(clienteModel.Nit)).ToList();

                if (ValidarNit.Count.Equals(0))
                {
                    //Modelo Producto
                    try
                    {
                        var _cliente = new Cliente
                        {
                            NombreCliente = clienteModel.NombreCliente,
                            Nit = clienteModel.Nit
                        };
                        _context.Cliente.Add(_cliente);
                        _context.SaveChanges();

                        TempData["mensajeClienteRegistrado"] = "Cliente Registrado Exitosamente";

                        return RedirectToAction(nameof(Cliente));
                    }
                    catch (Exception ex)
                    {
                        throw new Exception(ex.Message);
                    }
                }
                else
                {
                    TempData["mensajeClienteExiste"] = "El Nit ya existe en nuestro sistema.!";
                    return View();/*mantiene los datos*/
                }

            }
            return View(clienteModel);
        }
    }
}
