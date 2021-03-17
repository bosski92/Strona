using Microsoft.EntityFrameworkCore;
using Strona.Models;


namespace Strona.Data
{
    public class MvcMovieContext : DbContext
    {
        public MvcMovieContext(DbContextOptions<MvcMovieContext> options)
: base(options)
        {
        }
        public DbSet<Movie> Movie { get; set; }

    }
}
