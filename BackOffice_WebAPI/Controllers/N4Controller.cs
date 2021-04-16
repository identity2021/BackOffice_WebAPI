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
    public class N4Controller : ControllerBase
    {
        private readonly PCM_KS_BOContext _context;

        public N4Controller(PCM_KS_BOContext context)
        {
            _context = context;
        }

        // GET: api/N4
        // recuperer les articles pour les afficher d'une facon distincte au niveau du catalogue
        [HttpGet]
        public async Task<ActionResult<IEnumerable<N4>>> GetArticles()
        {
            return await _context.N4s.ToListAsync();
        }
    }
}
