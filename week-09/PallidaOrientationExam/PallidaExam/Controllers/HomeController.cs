using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PallidaExam.Repositories;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PallidaExam.Controllers
{
    [Route("")]
    public class HomeController : Controller
    {
        private CarRepository carRepository;

        public HomeController(CarRepository carRepository)
        {
            this.carRepository = carRepository;
        }

        [HttpGet("search")]
        public IActionResult Index([FromQuery]string platenumber)
        {
            if (platenumber == null)
                return View(carRepository.GetCar());
            else
                return View(carRepository.FilterPlates(platenumber));
        }
    }
}
