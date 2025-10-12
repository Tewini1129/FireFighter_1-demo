using System;
using FireFighter_1.Store_Product;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireFighter_1
{
    public class InventoryItems
    {
        public List<Products> Items { get; set; } = new();
        public int Amount { get; set; } = 0;
    }
}
