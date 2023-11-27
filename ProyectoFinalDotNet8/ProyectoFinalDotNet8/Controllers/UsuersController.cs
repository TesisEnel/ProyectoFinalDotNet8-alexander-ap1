//using Microsoft.AspNetCore.Http;
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
