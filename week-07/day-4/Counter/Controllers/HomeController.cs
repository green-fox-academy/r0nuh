using Counter.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Counter.Controllers
{
    [Route("")]
    public class HomeController : Controller
    {
        private Number number;

        public HomeController(Number number)
        {
            this.number = number;
        }
            
        [HttpGet("")]
        public IActionResult Index()
        {
            return View(number);
        }

        [HttpPost("add")]
        public IActionResult Increment()
        {
            number.ToBeIncremented += 3;
            return RedirectToAction("Index");
        }
    }
}
