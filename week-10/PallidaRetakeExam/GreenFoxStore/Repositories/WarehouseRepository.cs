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

        public List<Item> ListGarment()
        {
            var garmentList = Warehouse()
                .GroupBy(x => x.ItemName)
                .Select(y => y.First())
                .ToList();

            return garmentList;
        }

        public List<Item> ListSize()
        {
            var sizeList = Warehouse()
                .GroupBy(x => x.Size)
                .Select(y => y.First())
                .ToList();

            return sizeList;
        }

        public Item GetItem(string itemName, string size)
        {
            return warehouseContext.Items.FirstOrDefault(x => x.ItemName.Equals(itemName) && x.Size.Equals(size));
        }
    }
}
