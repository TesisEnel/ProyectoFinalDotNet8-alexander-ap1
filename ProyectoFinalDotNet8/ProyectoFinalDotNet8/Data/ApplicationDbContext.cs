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
                new Regiones() {RegionId = 2, NombreRegion = "San Francisco de Macorís", CodigoRegional  ="07", } 
            });

            modelBuilder.Entity<Distritos>().HasData(new List<Distritos>()
            {
               new Distritos {DistritoId =1, NombreDistrital = "José Contreras", CodigoDistrito = "01",CodigoRegional = "06"},
               new Distritos {DistritoId =2, NombreDistrital = "Constanza", CodigoDistrito = "02",CodigoRegional = "06"},
               new Distritos {DistritoId =3, NombreDistrital = "Villa Riva", CodigoDistrito = "03",CodigoRegional = "07"},
               new Distritos {DistritoId =4, NombreDistrital = "Tenares", CodigoDistrito = "04",CodigoRegional = "07"}
            });
        }
    }
}
