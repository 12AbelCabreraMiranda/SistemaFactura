using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema_Factura.Models
{
    [Table("Cliente")]
    public class Cliente
    {
        [Key]
        public int ClienteId { get; set; }
        public string NombreCliente { get; set; }
        public int Nit { get; set; }

        //Relacion con Modelo: Factura
        public List<Factura> Factura { get; set; }
    }
}
