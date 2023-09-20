using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TechPiProductsRazor_Temp.Data;
using TechPiProductsRazor_Temp.Model;

namespace TechPiProductsRazor_Temp.Pages.Products
{
	[BindProperties]
    public class EditModel : PageModel
    {
		private readonly ApplicationDbContext _db;
		//[BindProperty] 
		public Product Product { get; set; }
		public EditModel(ApplicationDbContext db)
		{
			_db = db;
		}
		public void OnGet(long? id)
		{
			if(id != null && id != 0) 
			{
				Product = _db.Products.Find(id);
			}
		}
		public IActionResult OnPost()
		{
			if (ModelState.IsValid)
			{
				_db.Products.Update(Product);
				_db.SaveChanges();
				return RedirectToPage("Index");
			}
			return Page();
		}


	}
	}
