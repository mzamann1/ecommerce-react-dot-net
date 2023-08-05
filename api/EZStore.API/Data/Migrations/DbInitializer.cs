using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EZStore.API.Models;

namespace EZStore.API.Data.Migrations
{
    public static class DbInitializer
    {
        public static void Initialize(StoreContext context)
        {
            context.Database.EnsureCreated();

            if (context.Products.Any()) return;

            var products = new List<Product>{
                new Product{Name = "Purple Boots", Description="DESC", Brand="Nike", Price=1500, QuantityInStock=100, Type="Shoes"},
                new Product{Name = "Gloves", Description="DESC", Brand="Gucci", Price=1200, QuantityInStock=100, Type="Shoes"}
            };

            context.Products.AddRange(products);
            context.SaveChanges();
        }
    }
}