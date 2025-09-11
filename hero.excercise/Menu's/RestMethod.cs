using FireFighter_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireFIghter_1.Menu_s
{
    internal class RestMethod
    {
        //Rest method
        public static void Rest(Player user, Enemy enemy)
        {
            Introduction.Continue = false;
            Console.WriteLine("\n---------------------------\n");
            Typewriter_Method.SlowType("Zz Zzz\n\n");
            Typewriter_Method.SlowType("Zzz Zz Zzz\n\n\n");
            Typewriter_Method.SlowType("Zz Zzz\n\n");
            Typewriter_Method.SlowType("Zzz Zz Zzz\n\n\n");
            Typewriter_Method.SlowType("Zz Zzz\n\n");
            Typewriter_Method.SlowType("Zzz Zz Zzz\n\n\n");
            Typewriter_Method.SlowType("Press \"Enter\" to wake up and continue\n");

            Console.ReadKey();
            Console.WriteLine("---------------------------\n");

            Typewriter_Method.SlowType("You have now rested\n");
            Typewriter_Method.SlowType("Your Hp, Shield and energy level is fully restored\n");
            Typewriter_Method.SlowType("\n---------------------------\n", 80);

            Player.Hp = Player.MaxHp;
            Player.Shield = Player.MaxShield;
            Player.EnergyLevel = Player.MaxEnergyLevel;
            MenuOptions.Menu(user, enemy);

        }
    }
}
