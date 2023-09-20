using TechPi.Models;
using Microsoft.EntityFrameworkCore;

namespace TechPi.DataAccess.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {
            
        }
        public DbSet<Product> Products { get; set; }
		public DbSet<Part> Parts { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product { 
                    Id = 1, 
                    ProductName = "Product1", 
                    ProductCode = "12345", 
                    Price = 100.00m, 
                    DisplayOrder = 1, 
                    ProductDescription = "First Product", 
                    Created = new DateTime(2023, 8, 27, 8, 30, 39, 999), 
                    InStock=true
                },
                new Product
                {
                    Id = 2,
                    ProductName = "Product2",
                    ProductCode = "12346",
                    Price = 200.00m,
                    DisplayOrder = 2,
                    ProductDescription = "Second Product",
                    Created = new DateTime(2023, 8, 28, 10, 41, 03, 101),
                    InStock = false
                }
            );
            modelBuilder.Entity<Part>().HasData(
                new Part
                {
                    Id = 1,
                    PartName = "Part 1",
                    PartCode = "1234567",
                    Price = 100,
                    Price50 = 4000,
                    Price100 = 7000,
                    Product = "Product 1",
                    InStock = true
                }
            );

		}
    }
}
