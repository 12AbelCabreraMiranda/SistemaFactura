using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema_Factura.ViewModels
{
    public class AgregarProducto
    {
        public int ProductoId { get; set; }
        public int CodigoProducto { get; set; }
        public string NombreProducto { get; set; }

        [Display(Name = "Precio de Venta")]
        public decimal PrecioProductoCompra { get; set; }
        public int Cantidad { get; set; }
        public string NitCliente_temp { get; set; }
    }
}
