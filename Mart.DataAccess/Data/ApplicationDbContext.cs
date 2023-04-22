using Mart.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Mart.DataAccess
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(
                new Category { Id=1, Name="Cutlery", DisplayOrder=1 },
                new Category { Id=2, Name="Clothing", DisplayOrder=2 },
                new Category { Id=3, Name="Stationary", DisplayOrder=3 }
                );

                modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    ProductName = "Spoon",
                    Description = "Set of 6 stainless steel spoons in Lowest Price",
                    ProductNumber = 1234,
                    VedorName = "Harsh",
                    OriginalPrice = 600,
                    Price = 550,
                    Price10 = 500,
                    Price25 = 450,
                    CategoryId = 1,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 2,
                    ProductName = "Caps",
                    Description = "Set of 12 Caps in Lowest Price",
                    ProductNumber = 5678,
                    VedorName = "Vicky",
                    OriginalPrice = 1200,
                    Price = 1100,
                    Price10 = 950,
                    Price25 = 850,
                    CategoryId = 2,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 3,
                    ProductName = "Socks",
                    Description = "Set of 12 Socks in Lowest Price",
                    ProductNumber = 5679,
                    VedorName = "Vicky",
                    OriginalPrice = 1000,
                    Price = 900,
                    Price10 = 850,
                    Price25 = 800,
                    CategoryId = 2,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 4,
                    ProductName = "Paper Plates",
                    Description = "Set of 50 disposable Paper plates",
                    ProductNumber = 1236,
                    VedorName = "Nandit",
                    OriginalPrice = 100,
                    Price = 80,
                    Price10 = 75,
                    Price25 = 70,
                    CategoryId = 6,
                    ImageUrl = ""
                }
                );
        }
    }
}
