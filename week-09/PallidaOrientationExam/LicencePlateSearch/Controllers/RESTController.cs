using Microsoft.AspNetCore.Mvc;
using PallidaExam.Repositories;
using System.Linq;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LicencePlateSearch.Controllers
{
    [Route("api")]
    public class RESTController : Controller
    {
        private CarRepository carRepository;

        public RESTController(CarRepository carRepository)
        {
            this.carRepository = carRepository;
        }

        [HttpGet("search/{brand}")]
        public IActionResult FilterBrand([FromRoute]string brand)
        {
            return Json( new { result = "ok", data = carRepository.GetBrand(brand).Select(x => new { x.LicencePlate, x.Brand, x.Model, x.Year, x.Color})});
        }
    }
}
