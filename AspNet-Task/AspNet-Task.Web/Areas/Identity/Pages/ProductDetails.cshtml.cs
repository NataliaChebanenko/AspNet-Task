using AspNet_Task.Web.Data;
using AspNet_Task.Web.Data.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace AspNet_Task.Web.Areas.Identity.Pages
{
    public class ProductDetailsModel : PageModel
    {
        private readonly ProductDbContext _dbContext;

        public Product Product { get; set; }

        public ProductDetailsModel(ProductDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult OnGet(int id)
        {
            Product = _dbContext.Products
                .Include(p => p.Category)
                .FirstOrDefault(p => p.Id == id);

            if (Product == null)
            {
                return NotFound();
            }

            return Page();
        }

    }
}
