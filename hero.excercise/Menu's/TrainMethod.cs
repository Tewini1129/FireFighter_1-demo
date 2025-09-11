using FireFighter_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireFIghter_1.Menu_s
{
    public class TrainMethod
    {
        public static void Train(Player user, Enemy enemy)
        {
            Console.Clear();
            Player.RegulareDamage += 5;
            Player.Shield += 2;
            Typewriter_Method.SlowType("\nYou go to the gym and practice your skills\n");
            Typewriter_Method.SlowType("\n+2 Shield\n");
            Typewriter_Method.SlowType("\n+5 Damage\n");
            Typewriter_Method.SlowType("\n---------------------\n", 90);
            MenuOptions.Menu(user, enemy);


        }
    }
}
