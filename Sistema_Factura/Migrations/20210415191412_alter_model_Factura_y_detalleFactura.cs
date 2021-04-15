using Microsoft.EntityFrameworkCore.Migrations;

namespace Sistema_Factura.Migrations
{
    public partial class alter_model_Factura_y_detalleFactura : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EstadoFactura",
                table: "Factura");

            migrationBuilder.AddColumn<int>(
                name: "EstadoFactura",
                table: "DetalleFactura",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EstadoFactura",
                table: "DetalleFactura");

            migrationBuilder.AddColumn<int>(
                name: "EstadoFactura",
                table: "Factura",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
