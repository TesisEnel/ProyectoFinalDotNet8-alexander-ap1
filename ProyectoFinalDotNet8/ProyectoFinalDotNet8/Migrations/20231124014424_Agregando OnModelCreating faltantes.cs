using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProyectoFinalDotNet8.Migrations
{
    /// <inheritdoc />
    public partial class AgregandoOnModelCreatingfaltantes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Distritos",
                columns: new[] { "DistritoId", "CodigoDistrito", "CodigoRegional", "NombreDistrital" },
                values: new object[,]
                {
                    { 1, "01", "06", "José Contreras" },
                    { 2, "02", "06", "Constanza" },
                    { 3, "03", "07", "Villa Riva" },
                    { 4, "04", "07", "Tenares" }
                });

            migrationBuilder.InsertData(
                table: "Regiones",
                columns: new[] { "RegionId", "CodigoRegional", "NombreRegion" },
                values: new object[,]
                {
                    { 1, "06", "La Vega" },
                    { 2, "07", "San Francisco de Macorís" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Distritos",
                keyColumn: "DistritoId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Distritos",
                keyColumn: "DistritoId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Distritos",
                keyColumn: "DistritoId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Distritos",
                keyColumn: "DistritoId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Regiones",
                keyColumn: "RegionId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Regiones",
                keyColumn: "RegionId",
                keyValue: 2);
        }
    }
}
