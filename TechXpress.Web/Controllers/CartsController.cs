using Microsoft.AspNetCore.Mvc;

namespace TechXpress.Web.Controllers
{
    public class CartsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
