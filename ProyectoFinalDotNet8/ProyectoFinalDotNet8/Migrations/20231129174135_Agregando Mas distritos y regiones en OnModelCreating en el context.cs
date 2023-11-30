using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProyectoFinalDotNet8.Migrations
{
    /// <inheritdoc />
    public partial class AgregandoMasdistritosyregionesenOnModelCreatingenelcontext : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Distritos",
                columns: new[] { "DistritoId", "CodigoDistrito", "CodigoRegional", "NombreDistrital" },
                values: new object[,]
                {
                    { 5, "03", "08", "Santiago Sur-Este" },
                    { 6, "04", "08", "Santiago Noroeste" },
                    { 7, "05", "08", "Santiago Centro-Oeste" },
                    { 8, "05", "10", "Boca Chica" },
                    { 9, "06", "10", "Mendoza" },
                    { 10, "07", "10", "San Antonio De Guerra" },
                    { 11, "01", "11", "Sosua" },
                    { 12, "02", "11", "Puerto Plata" },
                    { 13, "01", "12", "Higuey" },
                    { 14, "01", "14", "Nagua" },
                    { 15, "01", "16", "Cotui" },
                    { 16, "04", "16", "Bonao Suroeste" },
                    { 17, "03", "01", "Barahona" },
                    { 18, "05", "02", "San Juan Este" },
                    { 19, "01", "03", "Azua" },
                    { 20, "03", "03", "San Jose De Ocoa" },
                    { 21, "05", "03", "Nizao" },
                    { 22, "04", "04", "Villa Altagracia" },
                    { 23, "06", "04", "Haina" },
                    { 24, "07", "04", "San Gregorio De Nigua" },
                    { 25, "03", "05", "La Romana" },
                    { 26, "04", "05", "Hato Mayor" },
                    { 27, "06", "05", "Consuelo" },
                    { 28, "10", "05", "Guaymate" }
                });

            migrationBuilder.InsertData(
                table: "Regiones",
                columns: new[] { "RegionId", "CodigoRegional", "NombreRegion" },
                values: new object[,]
                {
                    { 3, "08", "Santiago" },
                    { 4, "10", "Santo Domingo" },
                    { 5, "11", "Puerto Plata" },
                    { 6, "12", "Higuey" },
                    { 7, "14", "Nagua" },
                    { 8, "16", "Cotui" },
                    { 9, "01", "Barahona" },
                    { 10, "02", "San Juan De La Maguana" },
                    { 11, "03", "Azua" },
                    { 12, "04", "San Cristobal" },
                    { 13, "05", "San Pedro De Macoris" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Distritos",
                keyColumn: "DistritoId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Distritos",
                keyColumn: "DistritoId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Distritos",
                keyColumn: "DistritoId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Distritos",
                keyColumn: "DistritoId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Distritos",
                keyColumn: "DistritoId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Distritos",
                keyColumn: "DistritoId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Distritos",
                keyColumn: "DistritoId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Distritos",
                keyColumn: "DistritoId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Distritos",
                keyColumn: "DistritoId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Distritos",
                keyColumn: "DistritoId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Distritos",
                keyColumn: "DistritoId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Distritos",
                keyColumn: "DistritoId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Distritos",
                keyColumn: "DistritoId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Distritos",
                keyColumn: "DistritoId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Distritos",
                keyColumn: "DistritoId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Distritos",
                keyColumn: "DistritoId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Distritos",
                keyColumn: "DistritoId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Distritos",
                keyColumn: "DistritoId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Distritos",
                keyColumn: "DistritoId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Distritos",
                keyColumn: "DistritoId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Distritos",
                keyColumn: "DistritoId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Distritos",
                keyColumn: "DistritoId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Distritos",
                keyColumn: "DistritoId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Distritos",
                keyColumn: "DistritoId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Regiones",
                keyColumn: "RegionId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Regiones",
                keyColumn: "RegionId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Regiones",
                keyColumn: "RegionId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Regiones",
                keyColumn: "RegionId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Regiones",
                keyColumn: "RegionId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Regiones",
                keyColumn: "RegionId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Regiones",
                keyColumn: "RegionId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Regiones",
                keyColumn: "RegionId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Regiones",
                keyColumn: "RegionId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Regiones",
                keyColumn: "RegionId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Regiones",
                keyColumn: "RegionId",
                keyValue: 13);
        }
    }
}
