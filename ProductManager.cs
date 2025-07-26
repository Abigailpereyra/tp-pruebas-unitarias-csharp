using System;
using System.Collections.Generic;
using System.Linq;

namespace PFO2
{
    public class ProductManager
    {
        private List<Product> products = new List<Product>();

        public void AddProduct(Product product)
        {
            products.Add(product);
        }

        public decimal CalculateTotalPrice(Product product)
        {
            decimal taxRate = product.Category == "Electrónica" ? 0.10m : 0.05m;
            return product.Price * (1 + taxRate);
        }

        public Product? FindProductByName(string name)
        {
            return products.FirstOrDefault(p => p.Name == name);
     }
        public List<Product> GetAllProducts()
        {
            return products;
        }
    }
}
