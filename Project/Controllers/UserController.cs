using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Project.Dto;
using Project.Models;

namespace Project.Controllers
{
    public class UserController : Controller
    {
            // GET
            public IActionResult Index()
            {
                return View();
            }

            [HttpPost]
            public IActionResult Index(UserDto userDto)
            {
                if (ModelState.IsValid)
                {
                
                    return Redirect("/home");
                }
                return View(userDto);
            }
        
            [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
            public IActionResult Error()
            {
                return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
            }
        }
}