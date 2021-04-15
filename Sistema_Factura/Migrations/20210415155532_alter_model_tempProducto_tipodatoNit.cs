using Microsoft.EntityFrameworkCore.Migrations;

namespace Sistema_Factura.Migrations
{
    public partial class alter_model_tempProducto_tipodatoNit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NitCliente_temp",
                table: "TempProducto");

            migrationBuilder.AddColumn<int>(
                name: "IdCliente_temp",
                table: "TempProducto",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdCliente_temp",
                table: "TempProducto");

            migrationBuilder.AddColumn<string>(
                name: "NitCliente_temp",
                table: "TempProducto",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
