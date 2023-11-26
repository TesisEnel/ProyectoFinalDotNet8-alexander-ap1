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
    public class TiposComidasController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public TiposComidasController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/TiposComidas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TiposComidas>>> GetTiposComidas()
        {
            return await _context.TiposComidas.ToListAsync();
        }

        // GET: api/TiposComidas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TiposComidas>> GetTiposComidas(int id)
        {
            var tiposComidas = await _context.TiposComidas.FindAsync(id);

            if (tiposComidas == null)
            {
                return NotFound();
            }

            return tiposComidas;
        }

        // PUT: api/TiposComidas/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTiposComidas(int id, TiposComidas tiposComidas)
        {
            if (id != tiposComidas.TipoComidaId)
            {
                return BadRequest();
            }

            _context.Entry(tiposComidas).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TiposComidasExists(id))
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

        // POST: api/TiposComidas
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<TiposComidas>> PostTiposComidas(TiposComidas tiposComidas)
        {
            _context.TiposComidas.Add(tiposComidas);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTiposComidas", new { id = tiposComidas.TipoComidaId }, tiposComidas);
        }

        // DELETE: api/TiposComidas/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTiposComidas(int id)
        {
            var tiposComidas = await _context.TiposComidas.FindAsync(id);
            if (tiposComidas == null)
            {
                return NotFound();
            }

            _context.TiposComidas.Remove(tiposComidas);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TiposComidasExists(int id)
        {
            return _context.TiposComidas.Any(e => e.TipoComidaId == id);
        }
    }
}
