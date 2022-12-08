using Lesson17ASPwebMVC.Models.Domain;
using Lesson17ASPwebMVC.Models;
using System.Collections.Generic;

namespace Lesson17ASPwebMVC.Services
{
    public class ActionWithProductService : IActionWithProductService
    {
        private readonly Inventorycs _inventory;
        public ActionWithProductService(Inventorycs inventory)
        {
            _inventory = inventory;
        }


        public void AddProduct(Product product)
        {
            _inventory.products.Add(product);
        }


        public List<Product> GetAllProducts()
        {
            return _inventory.products;
        }

        public void ReplaceProduct(int idProduct, Product product)
        {
            _inventory.products[idProduct] = product;
        }

        public decimal SummAllProducts()
        {
            decimal result = 0;
            foreach (Product product in _inventory.products)
            {
                result += product._price;
            }

            return result;
        }
    }
}
