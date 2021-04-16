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
    public class ArticleController : ControllerBase
    {
        private readonly PCM_KS_BOContext _context;

        public ArticleController(PCM_KS_BOContext context)
        {
            _context = context;
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<IEnumerable<Article>>> GetArticle(string id)
        {
            var art = await _context.Articles.Where(clt => clt.CodeArt == id).ToListAsync();

            if (art == null)
            {
                return NotFound();
            }

            return art;
        }



    }
}
