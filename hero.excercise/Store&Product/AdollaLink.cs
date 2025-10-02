using System;
using FireFighter_1;
using FireFighter_1.Menu_s;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireFighter_1.Store_Product
{
    public class AdollaLink : Products
    {
        public static string Name { get; set; }
        public static int AdollaLinkQuantity { get; set; }
        public static double Price;

        private static bool inStock = true;
        public static bool InStock
        {
            get { return inStock; }
            set { inStock = value; }
        }
        public AdollaLink()
        {
            Name = $"Adolla Link  ";
            Price = 5;
            AdollaLinkQuantity++;
        }
        public static void Use(Player user)
        {

            user.Shield = user.MaxShield;
            Typewriter_Method.SlowType($"\n{user.Name} concentrates as hard as he can and connects with the adolla Link ");
            user.inventory["Adolla Link"] -= 1;
            user.Hp = user.MaxHp;
            Typewriter_Method.SlowType($"\n\n{user.Name}'s Shield is fully restored\n\t{user.Name} Shield: {user.Shield}\n");
            Typewriter_Method.SlowType($"\n\n{user.Name}'s Hp and Energy is fully restored\n\t{user.Name} Hp: {user.Hp} Energy Level: {user.EnergyLevel}\n");
            Typewriter_Method.SlowType("");
            Introduction.Continue = true;


            Typewriter_Method.SlowType("\n---------------------------\n", 90);
        }
        public override int InventoryChecker()
        {
            if (AdollaLinkQuantity > 1)
            {
                AdollaLinkQuantity--;
                AllProducts--;
                return AdollaLinkQuantity;
            }
            else
            {
                InStock = false;
                return 0;
            }
        }

    }
}
