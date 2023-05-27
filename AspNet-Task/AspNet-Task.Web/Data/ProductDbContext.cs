using AspNet_Task.Web.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace AspNet_Task.Web.Data
{
    public class ProductDbContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        public ProductDbContext(DbContextOptions<ProductDbContext> options)
            : base(options)
        {
        }
