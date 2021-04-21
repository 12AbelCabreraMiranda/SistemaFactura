using Microsoft.EntityFrameworkCore;
using Sistema_Factura.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema_Factura.DataContext
{
    public class Sistema_FacturaContext: DbContext
    {
        public Sistema_FacturaContext(DbContextOptions<Sistema_FacturaContext> options) : base(options) { }
       
        //My Data Models
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Factura> Factura { get; set; }
        public DbSet<DetalleFactura> DetalleFactura { get; set; }
        public DbSet<Producto> Producto { get; set; }
        public DbSet<TempProducto> TempProducto { get; set; }        

    }
}
