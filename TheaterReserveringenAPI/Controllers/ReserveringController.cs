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
    public class ReserveringController : ControllerBase
    {
        private readonly TheaterReserveringenAPIContext _context;

        public ReserveringController(TheaterReserveringenAPIContext context)
        {
            _context = context;
        }

        // GET: api/Reservering
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Reservering>>> GetReserveringen()
        {
            return await _context.Reserveringen.ToListAsync();
        }

        // GET: api/Reservering/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Reservering>> GetReservering(int id)
        {
            var reservering = await _context.Reserveringen.FindAsync(id);

            if (reservering == null)
            {
                return NotFound();
            }

            return reservering;
        }

        // PUT: api/Reservering/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutReservering(int id, Reservering reservering)
        {
            if (id != reservering.ReserveringId)
            {
                return BadRequest();
            }

            _context.Entry(reservering).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ReserveringExists(id))
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

        // POST: api/Reservering
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Reservering>> PostReservering(Reservering reservering)
        {
            _context.Reserveringen.Add(reservering);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetReservering", new { id = reservering.ReserveringId }, reservering);
        }

        // DELETE: api/Reservering/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Reservering>> DeleteReservering(int id)
        {
            var reservering = await _context.Reserveringen.FindAsync(id);
            if (reservering == null)
            {
                return NotFound();
            }

            _context.Reserveringen.Remove(reservering);
            await _context.SaveChangesAsync();

            return reservering;
        }

        private bool ReserveringExists(int id)
        {
            return _context.Reserveringen.Any(e => e.ReserveringId == id);
        }
    }
}
