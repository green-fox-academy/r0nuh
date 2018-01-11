using GreetSomeone.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GreetSomeone.Controllers
{
    [Route("")]
    public class HomeController : Controller
    {
        private User user;

        public HomeController(User name)
        {
            this.user = name;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("")]
        public IActionResult Submit(string name)
        {
            user.Name = name;
            return RedirectToAction("Greet");
        }

        [HttpGet("greet")]
        public IActionResult Greet()
        {
            return View(user);
        }
    }
}
