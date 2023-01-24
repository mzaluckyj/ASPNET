using System.Collections.Generic;
using System.Data;
using Testing.Models;

namespace Testing
{
    public interface IProductsRepository
    {

        public IEnumerable<Product> GetAllProducts();
    }
}
