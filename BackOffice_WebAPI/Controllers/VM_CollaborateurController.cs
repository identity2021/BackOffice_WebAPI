using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BackOffice_WebAPI;
using BackOffice_WebAPI.Models;

namespace BackOffice_WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VM_CollaborateurController : ControllerBase
    {
        private readonly PCM_KS_BOContext _context;

        public VM_CollaborateurController(PCM_KS_BOContext context)
        {
            _context = context;
        }

        // GET: api/VM_Collaborateur
        [HttpGet]
        public async Task<ActionResult<IEnumerable<VM_Collaborateur>>> GetVM_Collaborateurs()
        {
            return await _context.VM_Collaborateurs.ToListAsync();
        }

        // GET: api/VM_Collaborateur/5
        [HttpGet("{id}")]
        public async Task<ActionResult<VM_Collaborateur>> GetVM_Collaborateur(int id)
        {
            var vM_Collaborateur = await _context.VM_Collaborateurs.FindAsync(id);

            if (vM_Collaborateur == null)
            {
                return NotFound();
            }

            return vM_Collaborateur;
        }

        // PUT: api/VM_Collaborateur/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutVM_Collaborateur(int id, VM_Collaborateur vM_Collaborateur)
        {
            if (id != vM_Collaborateur.id)
            {
                return BadRequest();
            }

            _context.Entry(vM_Collaborateur).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VM_CollaborateurExists(id))
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

        // POST: api/VM_Collaborateur
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<VM_Collaborateur>> PostVM_Collaborateur(VM_Collaborateur vM_Collaborateur)
        {
            _context.VM_Collaborateurs.Add(vM_Collaborateur);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetVM_Collaborateur", new { id = vM_Collaborateur.id }, vM_Collaborateur);
        }

        // DELETE: api/VM_Collaborateur/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteVM_Collaborateur(int id)
        {
            var vM_Collaborateur = await _context.VM_Collaborateurs.FindAsync(id);
            if (vM_Collaborateur == null)
            {
                return NotFound();
            }

            _context.VM_Collaborateurs.Remove(vM_Collaborateur);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool VM_CollaborateurExists(int id)
        {
            return _context.VM_Collaborateurs.Any(e => e.id == id);
        }
    }
}
