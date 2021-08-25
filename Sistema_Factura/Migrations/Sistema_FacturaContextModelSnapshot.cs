﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Sistema_Factura.DataContext;

namespace Sistema_Factura.Migrations
{
    [DbContext(typeof(Sistema_FacturaContext))]
    partial class Sistema_FacturaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Sistema_Factura.Models.Cliente", b =>
                {
                    b.Property<int>("ClienteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Estado")
                        .HasColumnType("int");

                    b.Property<string>("FechaRegistrado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HoraRegistrado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nit")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NombreCliente")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ClienteId");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("Sistema_Factura.Models.DetalleFactura", b =>
                {
                    b.Property<int>("DetalleFacturaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Cantidad")
                        .HasColumnType("int");

                    b.Property<int>("FacturaId")
                        .HasColumnType("int");

                    b.Property<decimal>("PrecioVenta")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("ProductoId")
                        .HasColumnType("int");

                    b.Property<decimal>("SubTotal")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("DetalleFacturaId");

                    b.HasIndex("FacturaId");

                    b.HasIndex("ProductoId");

                    b.ToTable("DetalleFactura");
                });

            modelBuilder.Entity("Sistema_Factura.Models.Factura", b =>
                {
                    b.Property<int>("FacturaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClienteId")
                        .HasColumnType("int");

                    b.Property<int>("EstadoFactura")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaFactura")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("TotalPrecio")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("FacturaId");

                    b.HasIndex("ClienteId");

                    b.ToTable("Factura");
                });

            modelBuilder.Entity("Sistema_Factura.Models.Producto", b =>
                {
                    b.Property<int>("ProductoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CodigoProducto")
                        .HasColumnType("int");

                    b.Property<int>("EstadoProducto")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaIngreso")
                        .HasColumnType("datetime2");

                    b.Property<string>("NombreProducto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("PrecioProductoCompra")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ProductoId");

                    b.ToTable("Producto");
                });

            modelBuilder.Entity("Sistema_Factura.Models.TempProducto", b =>
                {
                    b.Property<int>("TempProductoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Cantidad_temp")
                        .HasColumnType("int");

                    b.Property<decimal>("PrecioVenta_temp")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("ProductoId")
                        .HasColumnType("int");

                    b.Property<decimal>("SubTotal_temp")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("TempProductoId");

                    b.HasIndex("ProductoId");

                    b.ToTable("TempProducto");
                });

            modelBuilder.Entity("Sistema_Factura.Models.DetalleFactura", b =>
                {
                    b.HasOne("Sistema_Factura.Models.Factura", "Factura")
                        .WithMany("DetalleFactura")
                        .HasForeignKey("FacturaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Sistema_Factura.Models.Producto", "Producto")
                        .WithMany("DetalleFactura")
                        .HasForeignKey("ProductoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Factura");

                    b.Navigation("Producto");
                });

            modelBuilder.Entity("Sistema_Factura.Models.Factura", b =>
                {
                    b.HasOne("Sistema_Factura.Models.Cliente", "Cliente")
                        .WithMany("Factura")
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");
                });

            modelBuilder.Entity("Sistema_Factura.Models.TempProducto", b =>
                {
                    b.HasOne("Sistema_Factura.Models.Producto", "Producto")
                        .WithMany("TempProducto")
                        .HasForeignKey("ProductoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Producto");
                });

            modelBuilder.Entity("Sistema_Factura.Models.Cliente", b =>
                {
                    b.Navigation("Factura");
                });

            modelBuilder.Entity("Sistema_Factura.Models.Factura", b =>
                {
                    b.Navigation("DetalleFactura");
                });

            modelBuilder.Entity("Sistema_Factura.Models.Producto", b =>
                {
                    b.Navigation("DetalleFactura");

                    b.Navigation("TempProducto");
                });
#pragma warning restore 612, 618
        }
    }
}
