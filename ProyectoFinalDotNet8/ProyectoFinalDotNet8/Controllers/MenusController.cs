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
    public class MenusController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public MenusController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Menus
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Menu>>> GetMenus()
        {
            if (_context.Menus == null)
            {
                return NotFound();
            }
            return await _context.Menus.Include(m => m.MenuDetalles).Include(m => m.ComenentarioDetalle).ToListAsync();
        }

        // GET: api/Menus/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Menu>> GetMenu(int id)
        {
            if (_context.Menus == null)
            {
                return NotFound();
            }
            var menu = await _context.Menus.Include(m => m.MenuDetalles).Include(m => m.ComenentarioDetalle)
                .Where(m => m.MenuId == id)
                .FirstOrDefaultAsync();

            if (menu == null)
            {
                return NotFound();
            }

            return menu;
        }

        // PUT: api/Menus/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMenu(int id, Menu menu)
        {
            if (id != menu.MenuId)
            {
                return BadRequest();
            }

            _context.Entry(menu).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MenuExists(id))
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

        // POST: api/Menus
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Menu>> PostMenu(Menu menu)
        {
            if (!MenuExists(menu.MenuId))
                _context.Menus.Add(menu);
            else
                _context.Menus.Update(menu);

            await _context.SaveChangesAsync();

            return Ok(menu);
        }

        [HttpPost("Comentarios")]
        public async Task<ActionResult<Menu>> PostComentarios(Comentarios comentarios)
        {
            if (!ComentarioExists(comentarios.ComentarioId))
                _context.Comentarios.Add(comentarios);
            else
                _context.Comentarios.Update(comentarios);

            await _context.SaveChangesAsync();

            return Ok(comentarios);
        }

        // DELETE: api/Menus/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMenu(int id)
        {
            var menu = await _context.Menus.FindAsync(id);
            if (menu == null)
            {
                return NotFound();
            }

            _context.Menus.Remove(menu);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool MenuExists(int id)
        {
            return _context.Menus.Any(e => e.MenuId == id);
        }
        private bool ComentarioExists(int id)
        {
            return _context.Comentarios.Any(e => e.ComentarioId == id);
        }
        [HttpGet("Comentarios")]
        public async Task<ActionResult<IEnumerable<Comentarios>>> GetComentarios()
        {
            if (_context.Comentarios == null)
            {
                return NotFound();
            }
            return await _context.Comentarios.ToListAsync();
        }
    }

}
