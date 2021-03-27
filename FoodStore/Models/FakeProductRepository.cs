using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodStore.Models
{
    public class FakeProductRepository 
    {
        public IQueryable<Product> Products => new List<Product> {
             new Product { Name = "Round steak", Price = 17 },
             new Product { Name = "Sirloin steak", Price = 22 },
             new Product { Name = "Prime rib roast", Price = 33 }
        }.AsQueryable<Product>();
    }
}
