using Microsoft.AspNetCore.Mvc;
using TechXpress.Models;

namespace TechXpress.Web.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            var products = new List<Product>
        {
        new Product { ProductId = 1, Name = "Wireless Mouse", Price = 24.99m },
        new Product { ProductId = 2, Name = "Mechanical Keyboard", Price = 89.99m },
        new Product { ProductId = 3, Name = "Noise-Canceling Headphones", Price = 199.99m }
        };

            return View(products); 
        }
    }
}
