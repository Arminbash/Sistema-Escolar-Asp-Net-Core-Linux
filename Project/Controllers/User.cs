using Microsoft.AspNetCore.Mvc;

namespace Project.Controllers
{
    public class User : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }
    }
}