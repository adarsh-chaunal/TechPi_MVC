using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TechPiProductsRazor_Temp.Data;
using TechPiProductsRazor_Temp.Model;

namespace TechPiProductsRazor_Temp.Pages.Products
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        public List<Product> ProductList { get; set; }
        public IndexModel(ApplicationDbContext db)
        {
            _db = db;
        }
        public void OnGet()
        {
            ProductList = _db.Products.ToList();
            // We donot need to return anything as the return type is void and the variables are easily accessible in our views as we have imported the model in the view
        }
    }
}
