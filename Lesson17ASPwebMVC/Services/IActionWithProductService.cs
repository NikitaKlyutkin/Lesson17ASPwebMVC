using Lesson17ASPwebMVC.Models.Domain;
using System.Collections.Generic;

namespace Lesson17ASPwebMVC.Services
{
    public interface IActionWithProductService
    {
        public void AddProduct(Product product);

        public void DelProduct(string name);

        public List<Product> GetAllProducts();
        public Product GetProductByName(string name);

        public void ReplaceProduct(Product product);
        public decimal SummAllProducts();
    }
}
