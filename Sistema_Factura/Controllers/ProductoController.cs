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
        //INYECCION DEL CONTEXT
        private readonly Sistema_FacturaContext _context;
        public ProductoController(Sistema_FacturaContext context) => _context = context;

        public IActionResult Index()
        {
            return View();
        }
        //METODO QUE LISTA LOS PRODUCTOS CON ESTADO==1
        //public async Task<ActionResult> ProductosRegistrados()
        //{            
        //    //UNA MANERA DE TRAER EL LISTADO DE PRODUCTOS
        //    var produc = await _context.Producto.Where(x => x.EstadoProducto == 1).ToListAsync();
        //    return View(produc);            

        //}
        public async Task<List<Producto>> ProductosRegistrados()
        {
            //SEGUNDA MANERA DE TRAER EL LISTADO DE PRODUCTOS
            var ListaProducto = new List<Producto>();
            ListaProducto = await _context.Producto.Where(x => x.EstadoProducto == 1).ToListAsync();

            return ListaProducto;
        }

        public IActionResult NuevoProducto()
        {
            return View();
        }

        //METODO PARA REGISTRAR PRODUCTOS EN EL SISTEMA
        [HttpPost]            
        public async Task<IActionResult> NuevoProducto(Producto productoModel)
        {
            if (ModelState.IsValid)
            {
                //OBTIENE FECHA DEL SISTEMA
                DateTime FechaSistema = System.DateTime.Now;

                //CONSULTA PARA VER SI EXISTE EL CODIGO DEL PRODUCTO A REGISTRAR
                var ValidarProducto = _context.Producto.Where(p => p.CodigoProducto.Equals(productoModel.CodigoProducto)).ToList();

                if (ValidarProducto.Count.Equals(0))
                {                    
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
