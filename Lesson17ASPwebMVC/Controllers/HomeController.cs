using Lesson17ASPwebMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;
using Lesson17ASPwebMVC.CustomFilter;
using Controller = Microsoft.AspNetCore.Mvc.Controller;


namespace Lesson17ASPwebMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly Inventorycs _inventory;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, Inventorycs inventory)
        {
            _logger = logger;
            _inventory = inventory;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        
        [CustomExceptionFilter]
        public void QuantityTest()
        {
            foreach (var product in _inventory.products)
            {
                if (product._quantity > 15)
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
        }
    }
}
