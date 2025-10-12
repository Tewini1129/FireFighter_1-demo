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
    public class AdollaLink : Products, IUseProduct
    {
        public static int AdollaLinkQuantity { get; set; }

        public static bool InStock { get; private set; }
        



        public AdollaLink()
        {
            Name = $"Adolla Link  ";
            Price = 5;
            AdollaLinkQuantity++;
        }
        public override void Use(Player user)
        {

            user.Shield = user.MaxShield;
            Typewriter_Method.SlowType($"\n{user.Name} concentrates as hard as he can and connects with the adolla Link ");
            user.inventory["Adolla Link  "].Amount -= 1;
            user.inventory["Adolla Link  "].Items.RemoveAt(0);
            user.Hp = user.MaxHp;
            Typewriter_Method.SlowType($"\n\n{user.Name}'s Shield is fully restored\n\t{user.Name} Shield: {user.Shield}\n");
            Typewriter_Method.SlowType($"\n\n{user.Name}'s Hp is fully restored\n\t{user.Name} Hp: {user.Hp}\n");
            Typewriter_Method.SlowType($"\n\n{user.Name}'s Energy is fully restored\n\tEnergy Level: {user.EnergyLevel}\n");
            Typewriter_Method.SlowType("");
            Introduction.Continue = true;


            Typewriter_Method.SlowType("\n---------------------------\n", 90);
        }
        public override bool InventoryChecker()
        {
            if (AdollaLinkQuantity > 2)
            {
                AdollaLinkQuantity--;
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
            StoreMethod.adollaLink.RemoveAt(0);
        }

    }
}
