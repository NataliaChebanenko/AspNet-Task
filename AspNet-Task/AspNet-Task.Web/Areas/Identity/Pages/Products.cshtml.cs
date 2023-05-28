using AspNet_Task.Web.Data;
using AspNet_Task.Web.Data.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

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

        public IActionResult OnGet(string category)
        {
            Products = _productDbContext.Products.Include(p => p.Category).ToList();

            return Page();
        }

        public IActionResult OnPostSetCategory(string category)
        {
            if (category == "all")
            {
                Products = _productDbContext.Products.Include(p => p.Category).ToList();
                return Page();
            }

            Products = _productDbContext.Products.Where(x => x.Category.Name == category).ToList();

            return Page();
        }
    }
}
