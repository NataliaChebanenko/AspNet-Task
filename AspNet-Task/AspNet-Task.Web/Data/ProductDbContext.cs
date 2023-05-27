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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed categories
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "New" },
                new Category { Id = 2, Name = "Popular" },
                new Category { Id = 3, Name = "Featured" }
            );

            // Seed products and assign categories
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Name = "Silly Smartphone",
                    Description = "The phone that tells you jokes",
                    ImageUrl = "https://example.com/sillyphone.jpg",
                    SKU = "SKUSM001",
                    Color = "Yellow",
                    Price = 99.99m,
                    CategoryId = 1
                },
                new Product
                {
                    Id = 2,
                    Name = "Funky Fedora",
                    Description = "A stylish hat for the trendsetters",
                    ImageUrl = "https://example.com/funkyfedora.jpg",
                    SKU = "SKUFF001",
                    Color = "Purple",
                    Price = 49.99m,
                    CategoryId = 2
                },
                new Product
                {
                    Id = 3,
                    Name = "Whimsical Wall Clock",
                    Description = "A clock that dances on your wall",
                    ImageUrl = "https://example.com/whimsicalclock.jpg",
                    SKU = "SKUWC001",
                    Color = "Green",
                    Price = 29.99m,
                    CategoryId = 3
                },
                new Product
                {
                    Id = 4,
                    Name = "Goofy Goo",
                    Description = "Stretch it, squish it, have endless fun",
                    ImageUrl = "https://example.com/goofygoo.jpg",
                    SKU = "SKUGG001",
                    Color = "Multi-color",
                    Price = 9.99m,
                    CategoryId = 1
                },
                new Product
                {
                    Id = 5,
                    Name = "Zany Zebra Roller Skates",
                    Description = "Skate in style with zebra stripes",
                    ImageUrl = "https://example.com/zebraskates.jpg",
                    SKU = "SKUZS001",
                    Color = "Black/White",
                    Price = 79.99m,
                    CategoryId = 2
                }
            );
        }
    }
}
