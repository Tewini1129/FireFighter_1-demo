using System;
using FireFighter_1;
using FireFighter_1.Menu_s;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FireFighter_1.Fight_sequence;

namespace FireFighter_1.Store_Product
{
    public class Redbull: Products, IUseProduct
    {
        public static int RedbullQuantity { get; set; } 


        public static bool InStock { get; private set; }



        public Redbull()
        {
            Name = $"Redbull 500ml  ";
            Price = 2;
            RedbullQuantity++;
        }

        public override void Use(Player user)
        {
            user.Shield = user.MaxShield;
            user.inventory["Redbull 500ml  "].Amount -= 1;
            user.inventory["Redbull 500ml  "].Items.RemoveAt(0);
            Typewriter_Method.SlowType($"\n{user.Name} cracks a ice cold redbull...{user.Name} gets wings\n");

            Typewriter_Method.SlowType($"\n\n{user.Name}'s Shield is fully restored\n\t{user.Name} Shield: {user.Shield}\n");

            Introduction.Continue = true;


            Typewriter_Method.SlowType("\n---------------------------\n", 90);
        }

        

        public override bool InventoryChecker()
        {
            if(RedbullQuantity > 2)
            {
                RedbullQuantity--;
                AllProducts--;
                return true;
            }
            else
            {
                InStock = false;
                return false;
            }
        }

        public override void RemoveFromStoreList()
        {
            StoreMethod.redbulls.RemoveAt(0);
        }
    }
}
