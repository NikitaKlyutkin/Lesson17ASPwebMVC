using Lesson17ASPwebMVC.Models.Domain;
using Lesson17ASPwebMVC.Services;
using Microsoft.AspNetCore.Mvc;

namespace Lesson17ASPwebMVC.Controllers
{
	[ApiController]
	[Route("[controller]/[action]")]
	public class ProductApiController : Controller
	{
		IActionWithProductService action;
		public ProductApiController(IActionWithProductService action)
		{
			this.action = action;
		}
		[HttpPost]
		public IActionResult AddProduct(Product product)
		{
			action.AddProduct(product);
			return Created($"Name {product._name}", product);
		}
		[HttpPut]
		public IActionResult ReplaceProduct(Product product)
		{
			action.ReplaceProduct(product);
			return Created($"Replace {product._name}", product);
		}
	}
}
