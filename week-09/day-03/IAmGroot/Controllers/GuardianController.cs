using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IAmGroot.Models;
using Microsoft.AspNetCore.Mvc;

namespace IAmGroot.Controllers
{
    [Route("")]
    public class ValuesController : Controller
    {
        public static Ship ship = new Ship();

        [HttpGet("groot")]
        public IActionResult IAmGroot([FromQuery]string message)
        {
            if(message == null || message == String.Empty)
                return StatusCode(400, new { error = "I am Groot!" });

            return Json(new { received = message, translated = "I am Groot!" });
        }

        [HttpGet("yondu")]
        public IActionResult IAmYondu([FromQuery]double? distance, [FromQuery]double? time)
        {
            if (distance == null || time == null || distance == 0)
                return StatusCode(400, new { error = "I am Groot!" });

            return Json(new { distance = distance, time = time, speed = distance / time });
        }

        [HttpGet("rocket")]
        public IActionResult ActualCargo()
        {
            return Json(new
            {
                caliber25 = ship.Caliber25,
                caliber30 = ship.Caliber30,
                caliber50 = ship.Caliber50,
                shipstatus = ship.Shipstatus,
                ready = ship.Ready
            });
        }

        [HttpGet("rocket/fill")]
        public IActionResult Fill([FromQuery]string caliber, [FromQuery]double amount)
        {
            ship.Caliber25 = caliber.Equals(".25") ? (int)amount : 0;
            ship.Caliber30 = caliber.Equals(".30") ? (int)amount : 0;
            ship.Caliber50 = caliber.Equals(".50") ? (int)amount : 0;
            double percentage = (amount / 12500);
            ship.Shipstatus = percentage == 1 ? "full" : percentage < 1 && percentage > 0 ? percentage.ToString("0%") : "empty";
            ship.Ready = ship.Shipstatus.Equals("full") ? true : ship.Ready;

            return Json(new
            {
                received = caliber,
                amount = amount,
                shipstatus = ship.Shipstatus,
                ready = ship.Ready 
            });
        }
    }
}
