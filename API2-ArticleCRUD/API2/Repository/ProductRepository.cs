using API2.model;
using System.Collections.Generic;

namespace API2.Repository
{
    public class ProductRepository : IProductRepository
    {

        public IEnumerable<Product> getProducts()
        {

                var p = new Product();
                p.Id = 1;
                p.Name = "Laptop ";
                p.Price = 1600;

                var p2 = new Product()
                {
                    Id = 2,
                    Name = "Phone",
                    Price = 1229.99f
                };

                return new List<Product> { p, p2 };
        }
        public Product getProduct(int id)
        {
            foreach (var p in getProducts())
            {
                if (p.Id == id)
                    return p;
            }

            return null;
        }
}
}
