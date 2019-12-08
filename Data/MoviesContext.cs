using Microsoft.EntityFrameworkCore;

namespace MovieShopApp.Data
{
    public class MoviesContext : DbContext
    {
        public MoviesContext(DbContextOptions<MoviesContext> options): base(options) {}
        public DbSet<Models.Movie> Movies { get; set; }
    }
}

