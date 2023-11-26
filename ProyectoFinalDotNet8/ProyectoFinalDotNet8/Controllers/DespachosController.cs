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
    public class DespachosController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public DespachosController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Despachos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Despacho>>> GetDespachos()
        {
            return await _context.Despachos.ToListAsync();
        }

        // GET: api/Despachos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Despacho>> GetDespacho(int id)
        {
            var despacho = await _context.Despachos.FindAsync(id);

            if (despacho == null)
            {
                return NotFound();
            }

            return despacho;
        }

        // PUT: api/Despachos/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDespacho(int id, Despacho despacho)
        {
            if (id != despacho.DespachoId)
            {
                return BadRequest();
            }

            _context.Entry(despacho).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DespachoExists(id))
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

        // POST: api/Despachos
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Despacho>> PostDespacho(Despacho despacho)
        {
            _context.Despachos.Add(despacho);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDespacho", new { id = despacho.DespachoId }, despacho);
        }

        // DELETE: api/Despachos/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDespacho(int id)
        {
            var despacho = await _context.Despachos.FindAsync(id);
            if (despacho == null)
            {
                return NotFound();
            }

            _context.Despachos.Remove(despacho);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool DespachoExists(int id)
        {
            return _context.Despachos.Any(e => e.DespachoId == id);
        }
    }
}
