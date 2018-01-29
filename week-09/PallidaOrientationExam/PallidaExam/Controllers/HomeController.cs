using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PallidaExam.Repositories;
using PallidaExam.Models;

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
        public IActionResult Index([FromQuery]string platenumber, string police, string diplomat)
        {
            if(platenumber != null && police == null && diplomat == null)
                return View(carRepository.FilterPlates(platenumber));
            //else if (platenumber == null && police == null && diplomat == null)
            //    return View(carRepository.GetCar());
            else if(police != null && platenumber == null && diplomat == null)
                return View(carRepository.GetPolice());
            else if (diplomat != null && platenumber == null && police == null)
                return View(carRepository.GetDiplomat());
            else
                return View(carRepository.GetCar());
                
        }

        [HttpGet("search/{brand}")]
        public IActionResult FilterBrand([FromRoute]string brand)
        {
            return View("Index", carRepository.GetBrand(brand));
        }
    }
}
