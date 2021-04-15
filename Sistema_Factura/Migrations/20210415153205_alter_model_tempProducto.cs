using Microsoft.EntityFrameworkCore.Migrations;

namespace Sistema_Factura.Migrations
{
    public partial class alter_model_tempProducto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "NitCliente_temp",
                table: "TempProducto",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NitCliente_temp",
                table: "TempProducto");
        }
    }
}
