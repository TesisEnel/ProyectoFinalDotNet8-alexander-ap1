using Microsoft.AspNetCore.Identity;
using System.Diagnostics.Contracts;

namespace ProyectoFinalDotNet8.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        public string? Role { get; set; }
        public string? Nombre { get; set; }
        public string? Apellidos { get; set; }
    }

}
