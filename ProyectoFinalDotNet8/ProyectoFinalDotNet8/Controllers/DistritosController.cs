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
    public class DistritosController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public DistritosController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Distritos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Distritos>>> GetDistritos()
        {
            return await _context.Distritos.ToListAsync();
        }

        // GET: api/Distritos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Distritos>> GetDistritos(int id)
        {
            var distritos = await _context.Distritos.FindAsync(id);

            if (distritos == null)
            {
                return NotFound();
            }

            return distritos;
        }

        // PUT: api/Distritos/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDistritos(int id, Distritos distritos)
        {
            if (id != distritos.DistritoId)
            {
                return BadRequest();
            }

            _context.Entry(distritos).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DistritosExists(id))
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

        // POST: api/Distritos
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Distritos>> PostDistritos(Distritos distritos)
        {
            _context.Distritos.Add(distritos);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDistritos", new { id = distritos.DistritoId }, distritos);
        }

        // DELETE: api/Distritos/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDistritos(int id)
        {
            var distritos = await _context.Distritos.FindAsync(id);
            if (distritos == null)
            {
                return NotFound();
            }

            _context.Distritos.Remove(distritos);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool DistritosExists(int id)
        {
            return _context.Distritos.Any(e => e.DistritoId == id);
        }
    }
}
