using System;
using FireFighter_1;
using FireFighter_1.Menu_s;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireFighter_1.Store_Product
{
    public class Redbull: Products
    {
        public static string Name = $"Redbull 500ml  ";
        public static int RedbullQuantity { get; set; }
        public static double Price;

        private static bool inStock = true;
        public static bool InStock
        {
            get { return inStock; }
            set { inStock = value; }
        }

        public Redbull()
        {
            
            Price = 2;
            RedbullQuantity++;
        }

        public static void Use(Player user)
        {
            user.Shield = user.MaxShield;
            user.inventory["Redbull"] -= 1;
            Typewriter_Method.SlowType($"\n{user.Name} cracks a ice cold redbull...{user.Name} gets wings\n");

            Typewriter_Method.SlowType($"\n\n{user.Name}'s Shield is fully restored\n\t{user.Name} Shield: {user.Shield}\n");

            Introduction.Continue = true;


            Typewriter_Method.SlowType("\n---------------------------\n", 90);
        }

        

        public override int InventoryChecker()
        {
            if(RedbullQuantity > 1)
            {
                RedbullQuantity--;
                AllProducts--;
                return RedbullQuantity;
            }
            else
            {
                InStock = false;
                return 0;
            }
        }

        
    }
}
