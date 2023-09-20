using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TechPiProductsRazor_Temp.Data;
using TechPiProductsRazor_Temp.Model;

namespace TechPiProductsRazor_Temp.Pages.Products
{
	[BindProperties]
	public class CreateModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        //[BindProperty] 
        public Product Product{ get; set; }
        public CreateModel(ApplicationDbContext db)
        {
            _db = db;
        }
        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            Product.Created = DateTime.Now;
            _db.Products.Add(Product);
            _db.SaveChanges();
            return RedirectToPage("Index");
        }
    }
}
