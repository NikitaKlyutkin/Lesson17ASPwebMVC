using Lesson17ASPwebMVC.Models.Domain;
using Lesson17ASPwebMVC.Models;
using System.Collections.Generic;
using System.Linq;

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

        public void DelProduct(string name)
        {
            var IndexOf = _inventory.products.FindIndex(x => x._name == name);
            _inventory.products.RemoveAt(IndexOf);
        }


        public List<Product> GetAllProducts()
        {
            return _inventory.products;
        }

        public Product GetProductByName(string name)
        {
           return _inventory.products.Single(x => x._name == name);
        }

        public void ReplaceProduct(Product product)
        {
            var idProduct = _inventory.products.FindIndex(x => x._name == product._name);
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
