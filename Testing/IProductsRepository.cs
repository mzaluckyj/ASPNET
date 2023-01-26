using System.Collections.Generic;
using System.Data;
using Testing.Models;

namespace Testing
{
    public interface IProductsRepository
    {

        public IEnumerable<Product> GetAllProducts();
        public Product GetProduct(int id);

        public void UpdateProduct(Product product);

        public void InsertProduct(Product productToInsert);
        public IEnumerable<Category> GetCategories();

        public Product AssignCategory();

        public void DeleteProduct(Product product);

    }
}
