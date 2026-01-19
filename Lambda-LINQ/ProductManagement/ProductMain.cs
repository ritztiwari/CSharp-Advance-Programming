using System;

namespace CSharp_Advance_Programming.Lambda_LINQ.ProductManagement
{
    internal class ProductMain
    {
        internal static void Execute()
        {
                List<Product> products = new List<Product>
        {
            new Product { Name = "Laptop", Category = "Electronics", Price = 60000 },
            new Product { Name = "Mobile", Category = "Electronics", Price = 30000 },
            new Product { Name = "TV", Category = "Electronics", Price = 40000 },

            new Product { Name = "Shirt", Category = "Clothing", Price = 1500 },
            new Product { Name = "Jeans", Category = "Clothing", Price = 2500 },
            new Product { Name = "Jacket", Category = "Clothing", Price = 3500 },

            new Product { Name = "Table", Category = "Furniture", Price = 8000 },
            new Product { Name = "Chair", Category = "Furniture", Price = 3000 }
        };

            // LINQ query: Grouping + Aggregation + Projection
            var result = products
                .GroupBy(p => p.Category)
                .Select(g => new
                {
                    Category = g.Key,
                    AveragePrice = g.Average(p => p.Price)
                });

            // Display result
            Console.WriteLine("Category-wise Average Price:\n");

            foreach (var item in result)
            {
                Console.WriteLine($"{item.Category} : ₹{item.AveragePrice}");
            }
        }
    }
}