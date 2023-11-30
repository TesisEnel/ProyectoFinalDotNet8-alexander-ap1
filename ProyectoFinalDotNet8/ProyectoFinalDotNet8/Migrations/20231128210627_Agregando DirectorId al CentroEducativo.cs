using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProyectoFinalDotNet8.Migrations
{
    /// <inheritdoc />
    public partial class AgregandoDirectorIdalCentroEducativo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Tipo",
                table: "TiposComidas",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AddColumn<string>(
                name: "DirectorId",
                table: "CentrosEducativos",
                type: "TEXT",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DirectorId",
                table: "CentrosEducativos");

            migrationBuilder.AlterColumn<string>(
                name: "Tipo",
                table: "TiposComidas",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);
        }
    }
}
