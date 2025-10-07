using FireFighter_1;
using FireFighter_1.Store_Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireFighter_1.Menu_s
{
    public class PrintStats
    {
        //See stats method
        public static void Stats(Player user)
        {
            Introduction.Continue = false;
            Console.Clear();
            Console.WriteLine($"----<=====)( {user.Name} Stats )(=====>----");
            Typewriter_Method.SlowType($"\n\nUsername:\t\t\t{user.Name}\n");
            Console.WriteLine("----------------------------------");

            Typewriter_Method.SlowType($"Generation:\t\t\t{user.PowerClass}\n");
            Console.WriteLine("----------------------------------");

            Typewriter_Method.SlowType($"Hp/Max Hp:\t\t\t{user.Hp}/{user.MaxHp}\n");
            Console.WriteLine("----------------------------------");

            Typewriter_Method.SlowType($"Shield/Max Shield:\t\t{user.Shield}/{user.MaxShield}\n");
            Console.WriteLine("----------------------------------");

            Typewriter_Method.SlowType($"Energy level/Max energy level:\t{user.EnergyLevel}/{user.MaxEnergyLevel}\n");
            Console.WriteLine("----------------------------------");

            Typewriter_Method.SlowType($"Damage:\t\t\t\t{user.RegulareDamage}\n");
            Console.WriteLine("----------------------------------");

            
            foreach(var currency in user.Wallet)
            {
                Typewriter_Method.SlowType($"{currency.Key}:\t\t\t\t{Math.Round(user.Wallet[currency.Key])}\n");
                Console.WriteLine("----------------------------------");
            }

            Typewriter_Method.SlowType($"Progress:\t\t\t{user.Progress}\n");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("\n  >>>------<============>------<<<\n\n");



            Typewriter_Method.SlowType("\n\n\n ----<====)( Inventory )(====>----\n");

            string Items = "";
            int Empty = 0;


            foreach (var item in user.inventory)
            {
                if (item.Value > 0)
                {
                    Items += $"{item.Value}x {item.Key}\n";
                }
                else 
                {
                    Empty++;
                }
            }
            if(Empty == user.inventory.Count)
            {
                Items = "Empty...";
            }
            Typewriter_Method.SlowType(Items);

            Console.WriteLine("\n  >>>------<============>------<<<\n\n");
            


            Console.WriteLine(user.UserCustomer.ToString());

            Typewriter_Method.SlowType("\n\n\nPress any key to continue to menu\n");

            Console.ReadKey();

            


        }
    }
}
