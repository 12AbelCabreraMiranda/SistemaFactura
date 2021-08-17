using Microsoft.AspNetCore.Mvc;
using Sistema_Factura.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema_Factura.Areas.Cliente.Controllers
{
    [Area("Cliente")]
    public class ClienteController : Controller
    {
        private readonly IClienteRepository _clRepo;
        public ClienteController(IClienteRepository clRepo) => _clRepo = clRepo;

        //INICIALIZA LA VISTA, LISTANDO LOS DATOS TRAIDOS POR EL METODO  GETCLIENTES A TRAVES DE AJAX
        public IActionResult Index()
        {
            return View();
        }

        //METODO QUE TRAE TODO LOS DATOS EN LA TABLA DE LA DB CLIENTE
        public async Task<JsonResult> GetClientesAsync()
        {
            return Json(await _clRepo.GetClientes());
        }
    }
}
