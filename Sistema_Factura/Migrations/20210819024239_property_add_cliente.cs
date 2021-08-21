using Microsoft.EntityFrameworkCore.Migrations;

namespace Sistema_Factura.Migrations
{
    public partial class property_add_cliente : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte>(
                name: "Estado",
                table: "Cliente",
                type: "tinyint",
                nullable: false,
                defaultValue: (byte)0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Estado",
                table: "Cliente");
        }
    }
}
