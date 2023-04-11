using Microsoft.EntityFrameworkCore;
using WholeSale_Web.Models;

namespace WholeSale_Web.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id=1, Name="Cutlery", DisplayOrder=1 },
                new Category { Id=2, Name="Clothing", DisplayOrder=2 },
                new Category { Id=3, Name="Stationary", DisplayOrder=3 }
                );
        }
    }
}
