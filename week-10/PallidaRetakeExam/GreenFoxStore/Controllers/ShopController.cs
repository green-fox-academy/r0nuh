using GreenFoxStore.Repositories;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GreenFoxStore.Controllers
{
    [Route("")]
    public class ShopController : Controller
    {
        private WarehouseRepository warehouseRepository;

        public ShopController(WarehouseRepository warehouseRepository)
        {
            this.warehouseRepository = warehouseRepository;
        }

        [HttpGet("warehouse")]
        public IActionResult Index()
        {
            ViewBag.GarmentList = warehouseRepository.ListGarment();
            ViewBag.SizeList = warehouseRepository.ListSize();

            return View(warehouseRepository.Warehouse());
        }

        [HttpPost("warehouse/summary")]
        public IActionResult Summary([FromForm]string itemName, [FromForm]string size, [FromForm]int quantity)
        {
            ViewBag.Quantity = quantity;
            ViewBag.TotalPrice = quantity * warehouseRepository.GetItem(itemName, size).UnitPrice;
            return View(warehouseRepository.GetItem(itemName, size));
        }

        [HttpGet("warehouse/query")]
        public IActionResult Query([FromQuery]int? price, [FromQuery]string type)
        {
            if (price == null || type == null)
                return Json(new { error = "price/type is missing [type=lower/higher/equal]" });
            else
                return Json(new { result = "ok", clothes = warehouseRepository.FilteredList(price, type) });
        }
    }
}
