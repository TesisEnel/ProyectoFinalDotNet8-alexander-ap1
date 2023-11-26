using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProyectoFinalDotNet8.Migrations
{
    /// <inheritdoc />
    public partial class AgregandoOnModelCreatingparaTipoComidas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CentrosEducativos",
                columns: table => new
                {
                    CentroEducativoId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(type: "TEXT", nullable: false),
                    CantidadMatricula = table.Column<int>(type: "INTEGER", nullable: false),
                    CodigoDistrital = table.Column<string>(type: "TEXT", nullable: true),
                    CodigoRegional = table.Column<string>(type: "TEXT", nullable: true),
                    Direccion = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CentrosEducativos", x => x.CentroEducativoId);
                });

            migrationBuilder.CreateTable(
                name: "Despachos",
                columns: table => new
                {
                    DespachoId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Fecha = table.Column<DateTime>(type: "TEXT", nullable: false),
                    CentroEducativoId = table.Column<int>(type: "INTEGER", nullable: false),
                    MenuId = table.Column<int>(type: "INTEGER", nullable: false),
                    ConfirmacionEntrega = table.Column<bool>(type: "INTEGER", nullable: false),
                    RecibidoPor = table.Column<string>(type: "TEXT", nullable: true),
                    FechaRecepcion = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Despachos", x => x.DespachoId);
                });

            migrationBuilder.CreateTable(
                name: "Distritos",
                columns: table => new
                {
                    DistritoId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CodigoRegional = table.Column<string>(type: "TEXT", nullable: false),
                    NombreDistrital = table.Column<string>(type: "TEXT", nullable: true),
                    CodigoDistrito = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Distritos", x => x.DistritoId);
                });

            migrationBuilder.CreateTable(
                name: "Menus",
                columns: table => new
                {
                    MenuId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Descripcion = table.Column<string>(type: "TEXT", nullable: false),
                    DiaSemana = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menus", x => x.MenuId);
                });

            migrationBuilder.CreateTable(
                name: "Regiones",
                columns: table => new
                {
                    RegionId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    NombreRegion = table.Column<string>(type: "TEXT", nullable: false),
                    CodigoRegional = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Regiones", x => x.RegionId);
                });

            migrationBuilder.CreateTable(
                name: "TiposComidas",
                columns: table => new
                {
                    TipoComidaId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Tipo = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposComidas", x => x.TipoComidaId);
                });

            migrationBuilder.CreateTable(
                name: "DespachoDetalles",
                columns: table => new
                {
                    DetalleId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DespachoId = table.Column<int>(type: "INTEGER", nullable: false),
                    ComidaId = table.Column<int>(type: "INTEGER", nullable: false),
                    CantidadDecomida = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DespachoDetalles", x => x.DetalleId);
                    table.ForeignKey(
                        name: "FK_DespachoDetalles_Despachos_DespachoId",
                        column: x => x.DespachoId,
                        principalTable: "Despachos",
                        principalColumn: "DespachoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MenuDetalles",
                columns: table => new
                {
                    DetalleId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    MenuId = table.Column<int>(type: "INTEGER", nullable: false),
                    ComidaId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuDetalles", x => x.DetalleId);
                    table.ForeignKey(
                        name: "FK_MenuDetalles_Menus_MenuId",
                        column: x => x.MenuId,
                        principalTable: "Menus",
                        principalColumn: "MenuId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "TiposComidas",
                columns: new[] { "TipoComidaId", "Tipo" },
                values: new object[,]
                {
                    { 1, "Carbohidratos" },
                    { 2, "Proteinas" },
                    { 3, "Grasas" },
                    { 4, "Fibras" },
                    { 5, "Minerales" },
                    { 6, "Vitaminas" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_DespachoDetalles_DespachoId",
                table: "DespachoDetalles",
                column: "DespachoId");

            migrationBuilder.CreateIndex(
                name: "IX_MenuDetalles_MenuId",
                table: "MenuDetalles",
                column: "MenuId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CentrosEducativos");

            migrationBuilder.DropTable(
                name: "DespachoDetalles");

            migrationBuilder.DropTable(
                name: "Distritos");

            migrationBuilder.DropTable(
                name: "MenuDetalles");

            migrationBuilder.DropTable(
                name: "Regiones");

            migrationBuilder.DropTable(
                name: "TiposComidas");

            migrationBuilder.DropTable(
                name: "Despachos");

            migrationBuilder.DropTable(
                name: "Menus");
        }
    }
}
