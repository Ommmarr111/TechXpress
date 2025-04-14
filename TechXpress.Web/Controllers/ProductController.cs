using Microsoft.AspNetCore.Mvc;
using TechXpress.Models;

namespace TechXpress.Web.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
