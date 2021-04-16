using BackOffice_WebAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackOffice_WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {

        private readonly PCM_KS_BOContext _context;

        public ClientController(PCM_KS_BOContext context)
        {
            _context = context;
        }

        // GET: api/Client
        [HttpGet]
        public async Task<ActionResult<IEnumerable<N1Clt>>> GetArticles()
        {
            return await _context.N1Clts.ToListAsync();
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<N1Clt>> GetClient(string id)
        {
            var N1clt = await _context.N1Clts.FirstOrDefaultAsync(clt => clt.Id_Client == id);

            if (N1clt == null)
            {
                return NotFound();
            }

            return N1clt;
        }



    }
}
