using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Shared.Models;

namespace ProyectoFinalDotNet8.Data
{

    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public DbSet<Comidas> Comidas { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<MenuDetalles> MenuDetalles { get; set; }
        public DbSet<CentrosEducativos> CentrosEducativos { get; set; }
        public DbSet<Despacho> Despachos { get; set; }
        public DbSet<TiposComidas> TiposComidas { get; set; }
        public DbSet<DespachoDetalle> DespachoDetalles { get; set; }
        public DbSet<Regiones> Regiones { get; set; }
        public DbSet<Comentarios> Comentarios { get; set; }
        public DbSet<Distritos> Distritos { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<TiposComidas>().HasData(new List<TiposComidas>()
            {
                new TiposComidas() {TipoComidaId = 1, Tipo = "Carbohidratos"},
                new TiposComidas() {TipoComidaId = 2, Tipo = "Proteinas"},
                new TiposComidas() {TipoComidaId = 3, Tipo = "Grasas"},
                new TiposComidas() {TipoComidaId = 4, Tipo = "Fibras"},
                new TiposComidas() {TipoComidaId = 5, Tipo = "Minerales"},
                new TiposComidas() {TipoComidaId = 6, Tipo = "Vitaminas"}
            });

            modelBuilder.Entity<Regiones>().HasData(new List<Regiones>()
            {
                new Regiones() {RegionId = 1, NombreRegion = "La Vega", CodigoRegional  ="06"},
                new Regiones() {RegionId = 2, NombreRegion = "San Francisco de Macorís", CodigoRegional  ="07", },
                new Regiones() {RegionId = 3, NombreRegion = "Santiago", CodigoRegional  ="08", },
                new Regiones() {RegionId = 4, NombreRegion = "Santo Domingo", CodigoRegional  ="10", },
                new Regiones() {RegionId = 5, NombreRegion = "Puerto Plata", CodigoRegional  ="11", },
                new Regiones() {RegionId = 6, NombreRegion = "Higuey", CodigoRegional  ="12", },
                new Regiones() {RegionId = 7, NombreRegion = "Nagua", CodigoRegional  ="14", },
                new Regiones() {RegionId = 8, NombreRegion = "Cotui", CodigoRegional  ="16", },
                new Regiones() {RegionId = 9, NombreRegion = "Barahona", CodigoRegional  ="01", },
                new Regiones() {RegionId = 10, NombreRegion = "San Juan De La Maguana", CodigoRegional  ="02", },
                new Regiones() {RegionId = 11, NombreRegion = "Azua", CodigoRegional  ="03", },
                new Regiones() {RegionId = 12, NombreRegion = "San Cristobal", CodigoRegional  ="04", },
                new Regiones() {RegionId = 13, NombreRegion = "San Pedro De Macoris", CodigoRegional  ="05", },

            });

            modelBuilder.Entity<Distritos>().HasData(new List<Distritos>()
            {
               new Distritos {DistritoId =1, NombreDistrital = "José Contreras", CodigoDistrito = "01",CodigoRegional = "06"},
               new Distritos {DistritoId =2, NombreDistrital = "Constanza", CodigoDistrito = "02",CodigoRegional = "06"},
               new Distritos {DistritoId =3, NombreDistrital = "Villa Riva", CodigoDistrito = "03",CodigoRegional = "07"},
               new Distritos {DistritoId =4, NombreDistrital = "Tenares", CodigoDistrito = "04",CodigoRegional = "07"},
               new Distritos {DistritoId =5, NombreDistrital = "Santiago Sur-Este", CodigoDistrito = "03",CodigoRegional = "08"},
               new Distritos {DistritoId =6, NombreDistrital = "Santiago Noroeste", CodigoDistrito = "04",CodigoRegional = "08"},
               new Distritos {DistritoId =7, NombreDistrital = "Santiago Centro-Oeste", CodigoDistrito = "05",CodigoRegional = "08"},
               new Distritos {DistritoId =8, NombreDistrital = "Boca Chica", CodigoDistrito = "05",CodigoRegional = "10"},
               new Distritos {DistritoId =9, NombreDistrital = "Mendoza", CodigoDistrito = "06",CodigoRegional = "10"},
               new Distritos {DistritoId =10, NombreDistrital = "San Antonio De Guerra", CodigoDistrito = "07",CodigoRegional = "10"},
               new Distritos {DistritoId =11, NombreDistrital = "Sosua", CodigoDistrito = "01",CodigoRegional = "11"},
               new Distritos {DistritoId =12, NombreDistrital = "Puerto Plata", CodigoDistrito = "02",CodigoRegional = "11"},
               new Distritos {DistritoId =13, NombreDistrital = "Higuey", CodigoDistrito = "01",CodigoRegional = "12"},
               new Distritos {DistritoId =14, NombreDistrital = "Nagua", CodigoDistrito = "01",CodigoRegional = "14"},
               new Distritos {DistritoId =15, NombreDistrital = "Cotui", CodigoDistrito = "01",CodigoRegional = "16"},
               new Distritos {DistritoId =16, NombreDistrital = "Bonao Suroeste", CodigoDistrito = "04",CodigoRegional = "16"},
               new Distritos {DistritoId =17, NombreDistrital = "Barahona", CodigoDistrito = "03",CodigoRegional = "01"},
               new Distritos {DistritoId =18, NombreDistrital = "San Juan Este", CodigoDistrito = "05",CodigoRegional = "02"},
               new Distritos {DistritoId =19, NombreDistrital = "Azua", CodigoDistrito = "01",CodigoRegional = "03"},
               new Distritos {DistritoId =20, NombreDistrital = "San Jose De Ocoa", CodigoDistrito = "03",CodigoRegional = "03"},
               new Distritos {DistritoId =21, NombreDistrital = "Nizao", CodigoDistrito = "05",CodigoRegional = "03"},
               new Distritos {DistritoId =22, NombreDistrital = "Villa Altagracia", CodigoDistrito = "04",CodigoRegional = "04"},
               new Distritos {DistritoId =23, NombreDistrital = "Haina", CodigoDistrito = "06",CodigoRegional = "04"},
               new Distritos {DistritoId =24, NombreDistrital = "San Gregorio De Nigua", CodigoDistrito = "07",CodigoRegional = "04"},
               new Distritos {DistritoId =25, NombreDistrital = "La Romana", CodigoDistrito = "03",CodigoRegional = "05"},
               new Distritos {DistritoId =26, NombreDistrital = "Hato Mayor", CodigoDistrito = "04",CodigoRegional = "05"},
               new Distritos {DistritoId =27, NombreDistrital = "Consuelo", CodigoDistrito = "06",CodigoRegional = "05"},
               new Distritos {DistritoId =28, NombreDistrital = "Guaymate", CodigoDistrito = "10",CodigoRegional = "05"},
            });
        }
    }
}
