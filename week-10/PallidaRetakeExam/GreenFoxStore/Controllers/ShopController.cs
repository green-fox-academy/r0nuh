using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
            return View(warehouseRepository.Warehouse());
        }
    }
}
