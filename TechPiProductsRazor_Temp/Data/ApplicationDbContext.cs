using Microsoft.EntityFrameworkCore;
using TechPiProductsRazor_Temp.Model;

namespace TechPiProductsRazor_Temp.Data
{
	public class ApplicationDbContext : DbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
		{

		}
		public DbSet<Product> Products { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Product>().HasData(
				new Product
				{
					Id = 1,
					ProductName = "Product1",
					ProductCode = "12345",
					Price = 100.00m,
					DisplayOrder = 1,
					ProductDescription = "First Product",
					Created = new DateTime(2023, 8, 27, 8, 30, 39, 999),
					InStock = true
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
		}
	}
}
