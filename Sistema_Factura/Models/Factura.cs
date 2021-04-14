using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema_Factura.Models
{
    [Table("Factura")]
    public class Factura
    {
        [Key]
        public int FacturaId { get; set; }
        public int NumeroFactura { get; set; }
        public decimal TotalPrecio { get; set; }
        public int EstadoFactura { get; set; }

        //Relación con Modelo: 
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }

        //Relacion con Modelo: DetalleFactura
        public List<DetalleFactura> DetalleFactura { get; set; }
    }
}
