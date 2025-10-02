using System;
using FireFighter_1.Menu_s;
using FireFighter_1;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireFighter_1.Store_Product
{
    public abstract class Products
    {
        
        

        private static int allProducts;
        public static int AllProducts 
        {
            get { return allProducts; }
            set { allProducts = value; }
        }
        

        public Products()
        {
            AllProducts++;
        }


        public abstract int InventoryChecker();
    }
}
