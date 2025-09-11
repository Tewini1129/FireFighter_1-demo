using FireFighter_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireFIghter_1.Menu_s
{
    public class PrintStats
    {
        //See stats method
        public static void Stats(Player user, Enemy enemy)
        {
            Introduction.Continue = false;
            Console.Clear();
            Console.WriteLine("---------------------------");
            Typewriter_Method.SlowType($"\n\nUsername:\t\t\t{Player.Name}\n");
            Typewriter_Method.SlowType($"Generation:\t\t\t{Player.PowerClass}\n");
            Typewriter_Method.SlowType($"Hp/Max Hp:\t\t\t{Player.Hp}/{Player.MaxHp}\n");
            Typewriter_Method.SlowType($"Energy level/Max energy level:\t{Player.EnergyLevel}/{Player.MaxEnergyLevel}\n");
            Typewriter_Method.SlowType($"Damage:\t\t\t\t{Player.RegulareDamage}\n");
            Typewriter_Method.SlowType($"Gold:\t\t\t\t{Player.Gold}\n");
            Typewriter_Method.SlowType($"Progress:\t\t\t{Player.Progress}\n");

            if (Player.inventory.Count() == 0)
            {
                Typewriter_Method.SlowType($"Inventory: Empty\n");
            }
            else if (Player.inventory.Count() > 0)
            {
                Typewriter_Method.SlowType("Inventory:");
                foreach (string item in Player.inventory)
                {
                    Console.Write($" || {item} ||");
                }

            }
            Typewriter_Method.SlowType("\n\n\nPress any key to continue to menu\n");

            Console.ReadKey();
            Console.WriteLine("\n---------------------------");

            MenuOptions.Menu(user, enemy);


        }
    }
}
