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
    public class HealthPotion : Products, IUseProduct
    {
        public static int HealthPotionQuantity { get; private set; }


        public static bool InStock { get; private set; }




        public HealthPotion()
        {
            Name = "Health Potion  ";
            Price = 3;
            HealthPotionQuantity++;
        }

        public override void Use(Player user)
        {
            user.Hp = user.MaxHp;
            user.EnergyLevel = user.MaxEnergyLevel;

            Typewriter_Method.SlowType($"\n\n{user.Name}'s Hp and Energy is fully restored\n\t{user.Name} Hp: {user.Hp} Energy Level: {user.EnergyLevel}\n");

            user.inventory["Health Potion  "].Amount -= 1;
            user.inventory["Health Potion  "].Items.RemoveAt(0);

            Introduction.Continue = true;
            Typewriter_Method.SlowType("\n---------------------------\n", 90);
        }
        
        
        public override bool InventoryChecker()
        {
           if(HealthPotionQuantity > 2)
           {
                HealthPotionQuantity--;
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
            StoreMethod.healthPotions.RemoveAt(0);
        }

    }
}
