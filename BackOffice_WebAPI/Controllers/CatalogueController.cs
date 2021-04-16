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
    public class CatalogueController : ControllerBase
    {
        private readonly PCM_KS_BOContext _context;

        public CatalogueController(PCM_KS_BOContext context)
        {
            _context = context;
        }

        // GET: api/Catalogue
        // recuperer les articles pour les afficher d'une facon distincte au niveau du catalogue
        [HttpGet]
        public async Task<ActionResult<IEnumerable<F_CATALOGUEV>>> GetArticles()
        {
            return await _context.F_CATALOGUEVs.ToListAsync();
        }
        

    }
}
