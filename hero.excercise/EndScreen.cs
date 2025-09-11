using FireFIghter_1;
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
            Typewriter_Method.SlowType($"\nYou played {Player.Progress}0% of the game\n");
            Typewriter_Method.SlowType("Thank you for playing Firefighter 1\n");
        }
    }
}
