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
    public class ProductoController : Controller
    {
        //Inyeccion del contexto
        private readonly Sistema_FacturaContext _context;
        public ProductoController(Sistema_FacturaContext context) => _context = context;

        public IActionResult Index()
        {
            return View();
        }
        public async Task<ActionResult> ProductosRegistrados()
        {
            //Muestra todo los productos registrados con estados ==1
            var produc = await _context.Producto.Where(x => x.EstadoProducto == 1).ToListAsync();
            return View(produc);
        }

        public IActionResult NuevoProducto()
        {
            return View();
        }
        [HttpPost]
        //[ValidateAntiForgeryToken]
        //Registrar Productos Nuevos.       
        public async Task<IActionResult> NuevoProducto(Producto productoModel)
        {
            if (ModelState.IsValid)
            {
                //Fecha del sistema
                DateTime FechaSistema = System.DateTime.Now;

                //Consultando si el producto existe
                var ValidarProducto = _context.Producto.Where(p => p.CodigoProducto.Equals(productoModel.CodigoProducto)).ToList();

                if (ValidarProducto.Count.Equals(0))
                {
                    //Modelo Producto
                    try
                    {
                        var oProducto = new Producto()
                        {
                            CodigoProducto = productoModel.CodigoProducto,
                            NombreProducto = productoModel.NombreProducto,
                            EstadoProducto=1,
                            FechaIngreso= FechaSistema,
                            PrecioProductoCompra=productoModel.PrecioProductoCompra
                        };                        

                        _context.Producto.Add(oProducto);
                        await _context.SaveChangesAsync();

                        TempData["mensajeProductoRegistrado"] = "Producto Registrado Exitosamente";

                        return RedirectToAction(nameof(ProductosRegistrados));
                    }
                    catch (Exception ex)
                    {
                        throw new Exception(ex.Message);
                    }
                }
                else
                {
                    TempData["mensajeProductoExiste"] = "El código de producto ya existe.!";
                    return View();
                }

            }
            return View(productoModel);
        }
    }
}
