using AspNet_Task.Web.Data;
using AspNet_Task.Web.Data.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AspNet_Task.Web.Areas.Identity.Pages
{
    public class ProductsModel : PageModel
    {
        private readonly ProductDbContext _productDbContext;

        public ProductsModel(ProductDbContext productDbContext)
        {
            _productDbContext = productDbContext;
        }

        public List<Product> Products { get; set; }

        public IActionResult OnGet()
        {
            Products = _productDbContext.Products.ToList();
            return Page();
        }
    }
}
