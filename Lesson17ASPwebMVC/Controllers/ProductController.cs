using System;
using Lesson17ASPwebMVC.CustomFilter;
using Lesson17ASPwebMVC.Models.Domain;
using Lesson17ASPwebMVC.Services;
using Microsoft.AspNetCore.Mvc;

namespace Lesson17ASPwebMVC.Controllers
{
    [Controller]
    
    [Route("[controller]/[action]")]
    [CustomExceptionFilter]
    public class ProductController : Controller
    {
        IActionWithProductService action;
        public ProductController(IActionWithProductService action)
        {
            this.action = action;
        }

        [HttpGet]
        public IActionResult GetAllProduct()
        {
            var list = action.GetAllProducts();
            return View(list);
        }

        [HttpGet]
        public IActionResult SummAllProduct()
        {
            return View(action.SummAllProducts());
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Product product)
        {
            action.AddProduct(product);
            if (product._quantity > 15)
            {
	            throw new ArgumentOutOfRangeException();
            }
            
            return RedirectToAction("GetAllProduct");
        }

        public IActionResult Edit(Guid id)
        {
            var modelToUpdate= action.GetProductByName(id);
            return View(modelToUpdate);
        }
        [HttpPost]
        public IActionResult Edit(Product product)
        {
            action.ReplaceProduct(product);
            return RedirectToAction("GetAllProduct");
        }

        public IActionResult Delete(string id)
        {
            action.DelProduct(id);
            return RedirectToAction("GetAllProduct");
        }

        public IActionResult Details(Guid id)
        {
	        var modelToUpdate = action.GetProductByName(id);
	        return View(modelToUpdate);
        }
    }
}
