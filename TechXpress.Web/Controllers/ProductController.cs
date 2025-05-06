using Microsoft.AspNetCore.Mvc;
using TechXpress.DAL.Data;

namespace TechXpress.Web.Controllers
{
    public class ProductController : Controller
    {
        private readonly ApplicationContext context;
        public ProductController(ApplicationContext _context)
        {
            context = _context;
        }

        public IActionResult Index()
        {
            var products = context.Products.ToList();
            return View(products);
        }
    }
}
