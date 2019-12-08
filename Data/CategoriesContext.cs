using Microsoft.EntityFrameworkCore;

namespace MovieShopApp.Data
{
    public abstract class CategoriesContext: DbContext
    {
        protected CategoriesContext(DbContextOptions<CategoriesContext> options): base(options) {}
        public DbSet<Models.Category> Categories { get; set; }
    }
}