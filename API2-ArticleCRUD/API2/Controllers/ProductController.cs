using API2.model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace API2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {

        [HttpGet]
        //api/product
        public IList<Product> GetProducts()
        {
            return null; // Product.GetProducts();
        }
        //api/product/{id}

        [HttpGet("{id}")]
        public Product GetProduct(int id)
        {
          

            return null;
        }

        [HttpPost]
        public Product AddProduct(Product product)
        {
            Product product1 = new Product()
            {
                Id = product.Id,
                Name = product.Name
            };
            return product1;
        }

        [HttpDelete("{id}")]
        public Boolean DeleteProduct(int id)
        {
            Product producttoDelete;//= new Product();

            IList<Product> products = GetProducts();

            foreach (var p in GetProducts())
            {
                if (p.Id == id)
                {
                    producttoDelete = p;

                    Console.WriteLine(producttoDelete);

                    return products.Remove(producttoDelete);

                }

            }

            return false;
        }

        /*
        //api/product/{id}
        [HttpPut("{id}")]
        public Product UpdateProduct(int id, string ProductName)
        {
            Product product = GetProduct(id);
            product.Name = ProductName;

            return product;
        }
*/
        //api/product/{id}
        [HttpPut("{id}")]
        public Product UpdateProductBody(int id, [FromBody] string ProductName)
        {
            Product product = GetProduct(id);
            product.Name = ProductName;

            return product;
        }

    }
}
