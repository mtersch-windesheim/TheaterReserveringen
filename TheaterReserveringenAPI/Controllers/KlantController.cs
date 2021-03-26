using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TheaterReserveringenAPI.Data;
using TheaterReserveringenAPI.Models;

namespace TheaterReserveringenAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KlantController : ControllerBase
    {
        private readonly TheaterReserveringenAPIContext _context;

        public KlantController(TheaterReserveringenAPIContext context)
        {
            _context = context;
        }

        // GET: api/Klanten
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Klant>>> GetKlant()
        {
            return await _context.Klanten.ToListAsync();
        }

        // GET: api/Klanten/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Klant>> GetKlant(int id)
        {
            var klant = await _context.Klanten.FindAsync(id);

            if (klant == null)
            {
                return NotFound();
            }

            return klant;
        }

        // PUT: api/Klanten/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutKlant(int id, Klant klant)
        {
            if (id != klant.KlantId)
            {
                return BadRequest();
            }

            _context.Entry(klant).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!KlantExists(id))
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

        // POST: api/Klanten
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Klant>> PostKlant(Klant klant)
        {
            _context.Klanten.Add(klant);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetKlant", new { id = klant.KlantId }, klant);
        }

        // DELETE: api/Klanten/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Klant>> DeleteKlant(int id)
        {
            var klant = await _context.Klanten.FindAsync(id);
            if (klant == null)
            {
                return NotFound();
            }

            _context.Klanten.Remove(klant);
            await _context.SaveChangesAsync();

            return klant;
        }

        private bool KlantExists(int id)
        {
            return _context.Klanten.Any(e => e.KlantId == id);
        }
    }
}
