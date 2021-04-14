using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema_Factura.Models
{
    [Table("DetalleFactura")]
    public class DetalleFactura
    {
        [Key]
        public int DetalleFacturaId { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioVenta { get; set; }

        //Relación con Modelo: Factura
        public int FacturaId { get; set; }
        public Factura Factura { get; set; }

        //Relacion con Modelo: Producto
        public int ProductoId { get; set; }
        public Producto Producto { get; set; }

    }
}
