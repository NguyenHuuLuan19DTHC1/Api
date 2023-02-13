using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyAPINetCore6.Data;

namespace MyAPINetCore6.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ThongTinCCCNsController : ControllerBase
    {
        private readonly ThongTinCCCNContext _context;

        public ThongTinCCCNsController(ThongTinCCCNContext context)
        {
            _context = context;
        }

        // GET: api/ThongTinCCCNs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ThongTinCCCN>>> GetThongTinCCCNs()
        {
            return await _context.ThongTinCCCNs!.ToListAsync();
        }

        // GET: api/ThongTinCCCNs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ThongTinCCCN>> GetThongTinCCCN(int id)
        {
            var thongTinCCCN = await _context.ThongTinCCCNs!.FindAsync(id);

            if (thongTinCCCN == null)
            {
                return NotFound();
            }

            return thongTinCCCN;
        }

        // PUT: api/ThongTinCCCNs/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutThongTinCCCN(int id, ThongTinCCCN thongTinCCCN)
        {
            if (id != thongTinCCCN.Id)
            {
                return BadRequest();
            }

            _context.Entry(thongTinCCCN).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ThongTinCCCNExists(id))
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

        // POST: api/ThongTinCCCNs
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ThongTinCCCN>> PostThongTinCCCN(ThongTinCCCN thongTinCCCN)
        {
            _context.ThongTinCCCNs!.Add(thongTinCCCN);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetThongTinCCCN", new { id = thongTinCCCN.Id }, thongTinCCCN);
        }

        // DELETE: api/ThongTinCCCNs/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteThongTinCCCN(int id)
        {
            var thongTinCCCN = await _context.ThongTinCCCNs!.FindAsync(id);
            if (thongTinCCCN == null)
            {
                return NotFound();
            }

            _context.ThongTinCCCNs.Remove(thongTinCCCN);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ThongTinCCCNExists(int id)
        {
            return _context.ThongTinCCCNs!.Any(e => e.Id == id);
        }
    }
}
