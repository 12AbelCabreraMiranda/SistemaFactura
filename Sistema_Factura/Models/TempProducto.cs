using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema_Factura.Models
{
    [Table("TempProducto")]
    public class TempProducto
    {
        [Key]
        public int TempProductoId { get; set; }
        public int Cantidad_temp { get; set; }
        public decimal PrecioVenta_temp { get; set; }
        public decimal SubTotal_temp { get; set; }
        public int IdCliente_temp { get; set; }

        //Relacion con Modelo: Producto
        public int ProductoId { get; set; }
        public Producto Producto { get; set; }

    }
}
