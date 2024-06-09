using EportfolioAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace EportfolioAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<PortfolioItem> PortfolioItems { get; set; }
    }

}
