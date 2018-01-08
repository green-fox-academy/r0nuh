﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.Controllers
{
    [Route("api")]
    public class RESTController : Controller
    {
        private static int idCounter = 0;

        [Route("greeting")]
        public IActionResult Greeting(string name)
        {
            ++idCounter;
            var greet = new Greeting()
            {
                Id = idCounter,
                Content = name
            };
            return new JsonResult(greet);
        }
    }
}
