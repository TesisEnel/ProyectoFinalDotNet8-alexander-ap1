using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProyectoFinalDotNet8.Migrations
{
    /// <inheritdoc />
    public partial class Agregandoimagenamenu : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "Imagen",
                table: "Menus",
                type: "BLOB",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Imagen",
                table: "Menus");
        }
    }
}
