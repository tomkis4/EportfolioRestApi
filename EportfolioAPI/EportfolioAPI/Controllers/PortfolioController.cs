using EportfolioAPI.Data;
using EportfolioAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EportfolioAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PortfolioController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public PortfolioController(ApplicationDbContext context)
        {
            _context = context;
        }

        // Pobierz wszystkie elementy portfolio
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PortfolioItem>>> GetPortfolioItems()
        {
            try
            {
                return await _context.PortfolioItems.ToListAsync();
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "Internal server error", error = ex.Message });
            }
        }

        // Pobierz pojedynczy element portfolio na podstawie ID
        [HttpGet("{id}")]
        public async Task<ActionResult<PortfolioItem>> GetPortfolioItem(int id)
        {
            try
            {
                var portfolioItem = await _context.PortfolioItems.FindAsync(id);

                if (portfolioItem == null)
                {
                    return NotFound(new { message = "Item not found" });
                }

                return portfolioItem;
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "Internal server error", error = ex.Message });
            }
        }
    }
}
