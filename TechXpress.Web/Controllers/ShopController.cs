using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TechXpress.DAL.Data;
using TechXpress.Models;

namespace TechXpress.Web.Controllers
{
    public class ShopController : Controller
    {
        private readonly ApplicationContext context;
        public ShopController(ApplicationContext _context)
        {
            context = _context;
        }

        public IActionResult Index()
        {
            var products = context.Products.ToList();
            return View(products);
        }

        //public IActionResult FilterByCategory(Category category)
        //{
        //    var SpecificCategory;
        //}
    }

}
