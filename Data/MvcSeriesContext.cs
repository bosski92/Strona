using Microsoft.EntityFrameworkCore;
using Strona.Models;

namespace Strona.Data
{
    public class MvcSeriesContext : DbContext
    {
        public MvcSeriesContext(DbContextOptions<MvcSeriesContext> options)
        : base(options)
        {
        }
        public DbSet<Series> Series { get; set; }

    }
}
