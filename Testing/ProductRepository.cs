﻿using System.Collections.Generic;
using Dapper;
using System.Data;
using Testing.Models;
using System.Data;

namespace Testing
{
    public class ProductRepository : IProductsRepository
    {
        private readonly IDbConnection _conn;

        public ProductRepository(IDbConnection conn)
        {
            _conn = conn;
        }
        public IEnumerable<Product> GetAllProducts()
        {
            return _conn.Query<Product>("SELECT * FROM PRODUCTS;");
        }
    }
}
