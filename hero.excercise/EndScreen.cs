using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireFighter_1
{
    public static class EndScreen
    {
        public static void End()
        {
            Console.WriteLine($"\nYou played {Player.Progress}0% of the game");
            Console.WriteLine("Thank you for playing Firefighter 1");
        }
    }
}
