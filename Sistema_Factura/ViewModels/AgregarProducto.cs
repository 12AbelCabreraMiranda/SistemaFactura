using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema_Factura.ViewModels
{
    public class AgregarProducto
    {
        public int ProductoId { get; set; }
        public int CodigoProducto { get; set; }
        public string NombreProducto { get; set; }
        public decimal PrecioProductoCompra { get; set; }
        public int Cantidad { get; set; }
    }
}
