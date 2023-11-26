using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProyectoFinalDotNet8.Data;
using Shared.Models;

namespace ProyectoFinalDotNet8.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ComidasController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ComidasController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Comidas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Comidas>>> GetComidas()
        {
            return await _context.Comidas.ToListAsync();
        }

        // GET: api/Comidas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Comidas>> GetComidas(int id)
        {
            var comidas = await _context.Comidas.FindAsync(id);

            if (comidas == null)
            {
                return NotFound();
            }

            return comidas;
        }

        // PUT: api/Comidas/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutComidas(int id, Comidas comidas)
        {
            if (id != comidas.ComidaId)
            {
                return BadRequest();
            }

            _context.Entry(comidas).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ComidasExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Comidas
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Comidas>> PostComidas(Comidas comidas)
        {
            _context.Comidas.Add(comidas);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetComidas", new { id = comidas.ComidaId }, comidas);
        }

        // DELETE: api/Comidas/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteComidas(int id)
        {
            var comidas = await _context.Comidas.FindAsync(id);
            if (comidas == null)
            {
                return NotFound();
            }

            _context.Comidas.Remove(comidas);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ComidasExists(int id)
        {
            return _context.Comidas.Any(e => e.ComidaId == id);
        }
    }
}
