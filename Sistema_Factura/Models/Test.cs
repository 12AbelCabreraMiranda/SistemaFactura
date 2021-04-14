using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema_Factura.Models
{
    [Table("Test")]
    public class Test
    {
        [Key]
        public int TestId { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioVenta { get; set; }

        public int ProductoId { get; set; }
    }
}
