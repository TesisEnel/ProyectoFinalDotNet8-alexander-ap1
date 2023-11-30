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
    public class CentrosEducativosController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public CentrosEducativosController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/CentrosEducativos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CentrosEducativos>>> GetCentrosEducativos()
        {
            return await _context.CentrosEducativos.ToListAsync();
        }

        // GET: api/CentrosEducativos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CentrosEducativos>> GetCentrosEducativos(int id)
        {
            var centrosEducativos = await _context.CentrosEducativos.FindAsync(id);

            if (centrosEducativos == null)
            {
                return NotFound();
            }

            //_context.Users.ToList();

            return centrosEducativos;
        }



        // PUT: api/CentrosEducativos/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCentrosEducativos(int id, CentrosEducativos centrosEducativos)
        {
            if (id != centrosEducativos.CentroEducativoId)
            {
                return BadRequest();
            }

            _context.Entry(centrosEducativos).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CentrosEducativosExists(id))
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

        // POST: api/CentrosEducativos
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<CentrosEducativos>> PostCentrosEducativos(CentrosEducativos centrosEducativos)
        {
            if (!CentrosEducativosExists(centrosEducativos.CentroEducativoId))
                _context.CentrosEducativos.Add(centrosEducativos);
            else
                _context.CentrosEducativos.Update(centrosEducativos);

            await _context.SaveChangesAsync();

            return Ok(centrosEducativos);
        }

        // DELETE: api/CentrosEducativos/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCentrosEducativos(int id)
        {
            var centrosEducativos = await _context.CentrosEducativos.FindAsync(id);
            if (centrosEducativos == null)
            {
                return NotFound();
            }

            _context.CentrosEducativos.Remove(centrosEducativos);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CentrosEducativosExists(int id)
        {
            return _context.CentrosEducativos.Any(e => e.CentroEducativoId == id);
        }
    }
}
