﻿using Microsoft.AspNetCore.Mvc;
using Sistema_Factura.Models;
using Sistema_Factura.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema_Factura.Areas.Clientes.Controllers
{
    [Area("Clientes")]
    public class ClienteController : Controller
    {
        private readonly IClienteRepository _clRepo;
        public ClienteController(IClienteRepository clRepo) => _clRepo = clRepo;

        //INICIALIZA LA VISTA, LISTANDO LOS DATOS TRAIDOS POR EL METODO  GETCLIENTES A TRAVES DE AJAX
        public IActionResult Index()
        {
            return View();
        }

        //METODO: OBTIENE LA LISTA DE TODOS LOS CLIENTES
        public async Task<JsonResult> GetClientes()
        {
            return Json(await _clRepo.GetClientes());
        }

        //METODO CREAR CLIENTE
        [HttpPost]
        public async Task<bool> CrearClientes(Cliente clienteModel ) 
        {
            bool createdCliente = false;
            
            if(await _clRepo.ExisteCliente(clienteModel.Nit))
            {
                return createdCliente;
            }
            else
            {
                var cliente = new Cliente()
                {
                    NombreCliente = clienteModel.NombreCliente,
                    Nit = clienteModel.Nit,
                    Estado=1
                };
                await _clRepo.CrearCliente(cliente);
                createdCliente = true;
            }            
            return createdCliente;
        }
    }
}
