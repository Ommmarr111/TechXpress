using Microsoft.AspNetCore.Mvc;
using TechXpress.Models;

namespace TechXpress.Web.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
