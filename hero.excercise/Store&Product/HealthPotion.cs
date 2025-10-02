using System;
using FireFighter_1;
using FireFighter_1.Menu_s;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireFighter_1.Store_Product
{
    public class HealthPotion : Products
    {
        public static string Name { get; set; }
        public static int HealthPotionQuantity { get; private set; }
        public static int Price;

        private static bool inStock = true;
        public static bool InStock
        {
            get { return inStock; }
            set { inStock = value; }
        }
        public HealthPotion()
        {
            Name = $"Health Potion  ";
            Price = 3;
            HealthPotionQuantity++;
        }

        public static void Use(Player user)
        {
            user.Hp = user.MaxHp;
            user.EnergyLevel = user.MaxEnergyLevel;

            Typewriter_Method.SlowType($"\n\n{user.Name}'s Hp and Energy is fully restored\n\t{user.Name} Hp: {user.Hp} Energy Level: {user.EnergyLevel}\n");

            user.inventory["Health Potion"] -= 1;
            Introduction.Continue = true;
            Typewriter_Method.SlowType("\n---------------------------\n", 90);
        }
        
        
        public override int InventoryChecker()
        {
           if(HealthPotionQuantity > 1)
           {
                HealthPotionQuantity--;
                AllProducts--;
                return HealthPotionQuantity;
           }
           else
           {
                InStock = false;
                return 0;
            }
        }

    }
}
