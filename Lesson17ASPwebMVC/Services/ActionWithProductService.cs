using System;
using Lesson17ASPwebMVC.Models.Domain;
using Lesson17ASPwebMVC.Models;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Numerics;
using MessagePack.Formatters;

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
            product.Id = Guid.NewGuid();
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

        public Product GetProductByName(Guid id)
        {
           return _inventory.products.Single(x => x.Id == id);
        }

        public void ReplaceProduct(Product product)
        {
            int idProduct = _inventory.products.FindIndex(x => x.Id == product.Id);
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
