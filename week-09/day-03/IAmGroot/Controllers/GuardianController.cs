using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace IAmGroot.Controllers
{
    [Route("")]
    public class ValuesController : Controller
    {
        
        [HttpGet("groot")]
        public IActionResult IAmGroot([FromQuery]string message)
        {
            if(message == null || message == String.Empty)
                return StatusCode(400, new { error = "I am Groot!" });

            return Json(new { received = message, translated = "I am Groot!" });
        }

        [HttpGet("yondu")]
        public IActionResult IAmYondu([FromQuery]double distance, [FromQuery]double time)
        {
            return Json(new { distance = distance, time = time, speed = distance / time });
        }
    }
}
