//using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProyectoFinalDotNet8.Client;
using ProyectoFinalDotNet8.Data;
using Shared.Models;

namespace ProyectoFinalDotNet8.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuersController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public UsuersController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/User
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ApplicationUser>>> GetUser()
        {
            return await _context.Users.ToListAsync();
        }

        [HttpGet("RolesDirector")]
        public async Task<ActionResult<IEnumerable<String>>> GetRole()
        {
            var Director = (await _context.Roles
                .FirstOrDefaultAsync(r => r.Name == "Director"))!.Id;
            var roleUser = await _context.UserRoles
                .Where(r => r.RoleId == Director)
                .ToListAsync();
            var Directores = roleUser.Select(r => r.UserId).ToList();
           
            return Directores!;
        }
        // GET: api/User/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ApplicationUser>> GetUser(string id)
        {
            var user = await _context.Users.FirstOrDefaultAsync(u => u.Email == id);

            if (user == null)
            {
                return NotFound();
            }

            return user;
        }


    }
}
