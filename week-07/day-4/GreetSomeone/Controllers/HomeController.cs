using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GreetSomeone.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GreetSomeone.Controllers
{
    [Route("")]
    public class HomeController : Controller
    {
        private User name;

        public HomeController(User name)
        {
            this.name = name;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("")]
        public IActionResult Submit()
        {
            return RedirectToAction("Greet");
        }

        [HttpGet("greet")]
        public IActionResult Greet()
        {
            return Ok();
        }
    }
}
