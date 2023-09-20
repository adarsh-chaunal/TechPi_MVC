using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TechPiProductsRazor_Temp.Data;
using TechPiProductsRazor_Temp.Model;

namespace TechPiProductsRazor_Temp.Pages.Products
{
	[BindProperties]
    public class DeleteModel : PageModel
    {
		private readonly ApplicationDbContext _db;
		//[BindProperty] 
		public Product Product { get; set; }
		public DeleteModel(ApplicationDbContext db)
		{
			_db = db;
		}
		public void OnGet(long? id)
		{
			if (id != null && id != 0)
			{
				Product = _db.Products.Find(id);
			}
		}
		public IActionResult OnPost()
		{
			Product? obj = _db.Products.Find(Product.Id);
			if (obj == null)
			{
				return NotFound();
			}
			_db.Products.Remove(obj);
			_db.SaveChanges();
			return RedirectToPage("Index");
		}
	}
}
