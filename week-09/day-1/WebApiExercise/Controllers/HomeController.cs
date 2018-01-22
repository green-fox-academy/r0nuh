using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApiExercise.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApiExercise.Controllers
{
    [Route("")]
    public class HomeController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return File("index.html", "text/html");
        }

        [HttpGet("doubling")]
        public IActionResult Doubling([FromQuery]int? input)
        {
            if (input == null)
            {
                return Json( new { error = "Please provide an input!" });
            }
            return Json(new { received = input, result = input * 2 });
        }

        [HttpGet("greeter")]
        public IActionResult Greeting([FromQuery]string name, [FromQuery]string title)
        {
            if (name == null)
            {
                return Json(new { error = "Please provide a name!" });
            }
            else if (title == null)
            {
                return Json(new { error = "Please provide a title!" });
            }
   
            return Json(new { welcome_message = $"Oh, hi there {name}, my dear {title}!"});
        }

        [HttpGet("appenda/{appendable}")]
        public IActionResult AppendA([FromRoute]string appendable)
        {
            if (appendable == null)
            {
                return NotFound();
            }
            return Json(new { appended = $"{appendable}a" });
        }

        [HttpPost("dountil/{what}")]
        public IActionResult DoUntil([FromRoute] string what, [FromBody]Number number)
        {
            if (number == null)
            {
                return Json(new { error = "Please provide a number!" });
            }

            if (what.Equals("sum"))
            {
                int sum = 0;
                for (int i = number.Until; i > 0; i--)
                {
                    sum = sum + i;
                }
                return Json(new { result = sum  });
            }
            else if (what.Equals("factor"))
            {
                int factor = 1;
                for (int i = number.Until; i > 0; i--)
                {
                    factor = factor * i;
                }
                return Json(new { result = factor });
            }

            return NotFound();
        }
    }
}
