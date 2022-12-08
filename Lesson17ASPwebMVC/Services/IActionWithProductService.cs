using Lesson17ASPwebMVC.Models.Domain;
using System.Collections.Generic;

namespace Lesson17ASPwebMVC.Services
{
    public interface IActionWithProductService
    {
        public void AddProduct(Product product);

        public List<Product> GetAllProducts();

        public void ReplaceProduct(int idProduct, Product product);
        public decimal SummAllProducts();
    }
}
