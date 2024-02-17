using Microsoft.EntityFrameworkCore;

namespace Mission06_Olsen.Models
{
    public class MovieAdditionContext : DbContext
    {
        public MovieAdditionContext(DbContextOptions<MovieAdditionContext> options) : base(options)
        {

        }

        public DbSet<MovieAddition> MovieAddition { get; set; }
    }
}
