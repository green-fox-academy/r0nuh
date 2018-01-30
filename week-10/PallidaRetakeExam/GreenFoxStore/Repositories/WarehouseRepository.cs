using GreenFoxStore.Entities;
using GreenFoxStore.Models;
using System.Collections.Generic;
using System.Linq;

namespace GreenFoxStore.Repositories
{
    public class WarehouseRepository
    {
        private WarehouseContext warehouseContext;

        public WarehouseRepository(WarehouseContext warehouseContext)
        {
            this.warehouseContext = warehouseContext;
        }

        public List<Item> Warehouse()
        {
            return warehouseContext.Items.ToList();
        }
    }
}
