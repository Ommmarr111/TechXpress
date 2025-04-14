using Microsoft.AspNetCore.Mvc;

namespace TechXpress.Web.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
