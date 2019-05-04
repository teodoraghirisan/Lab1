using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab1.Models
//jdhfjdhj
{
    public class ProductsDbSeeder
    {
        public static void Initialize(ProductsDbContext context)
        {
            context.Database.EnsureCreated();

            // Look for any products.
            if (context.Products.Any())
            {
                return;   // DB has been seeded
            }

            context.Products.AddRange(
                new Product
                {
                    Name = "Milka",
                    Description = "Cookies",
                    Category = "Sweets",
                    Price = 2.00,
                },
                new Product
                {
                    Name = "Kinder Bueno",
                    Description = "Chocolate",
                    Category = "Sweets",
                    Price = 2.00,
                }
            );
            context.SaveChanges();
        }
    }
}

