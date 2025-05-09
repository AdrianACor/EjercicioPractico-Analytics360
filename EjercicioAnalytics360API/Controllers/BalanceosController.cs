using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EjercicioAnalytics360API.Models;

namespace EjercicioAnalytics360API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BalanceosController : Controller
    {
        private readonly MiDbContext _context;

        public BalanceosController(MiDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] Balanceo balanceo)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            _context.Add(balanceo);
            await _context.SaveChangesAsync();
            return Ok(balanceo);
        }

    }
}
