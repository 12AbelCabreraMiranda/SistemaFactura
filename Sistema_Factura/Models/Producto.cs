using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema_Factura.Models
{
    [Table("Producto")]
    public class Producto
    {
        [Key]
        public int ProductoId { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public int CodigoProducto { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string NombreProducto { get; set; }
        public int EstadoProducto { get; set; }

        public DateTime FechaIngreso { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public decimal PrecioProductoCompra { get; set; }

        //Relación con Modelo: DetalleFactura
        public List<DetalleFactura> DetalleFactura { get; set; }

        //Relación con Modelo: TempProducto
        public List<TempProducto> TempProducto { get; set; }

    }
}
