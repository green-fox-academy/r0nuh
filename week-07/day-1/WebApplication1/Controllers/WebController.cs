using Microsoft.AspNetCore.Mvc;
using SayHello.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SayHello.Controllers
{
    [Route("web")]
    public class WebController : Controller
    {
        private static int idCounter = 0;

        [Route("greeting")]
        public IActionResult Greeting(string name)
        {
            ++idCounter;
            var greeting = new Greeting()
            {
                Id = idCounter,
                Content = name
            };

            return View(greeting);
        }

    }
}
