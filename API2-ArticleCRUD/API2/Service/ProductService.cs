using API2.model;
using API2.Repository;
using System.Collections.Generic;

namespace API2.Service
{
    public class ProductService
    {
        private IProductRepository repository;

        public ProductService(IProductRepository repository)
        {
            this.repository = repository;
        }

      public  IEnumerable<Product> getProducts()
        {
            return repository.getProducts();
        }
      public  Product getProduct(int id)
        {
            return repository.getProduct(id);
        }

    }
}
