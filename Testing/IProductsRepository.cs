using System.Collections.Generic;
using System.Data;
using Testing.Models;

namespace Testing
{
    public interface IProductsRepository
    {

        public IEnumerable<Product> GetAllProducts();
        public Product GetProduct(int id);

        public Product UpdateProduct(Product product);
    }
}
