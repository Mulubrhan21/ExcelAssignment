using API2.model;
using System.Collections.Generic;

namespace API2.Repository
{
    public interface IProductRepository
    {
        IEnumerable<Product> getProducts();
        Product? getProduct(int id);
    }
}
