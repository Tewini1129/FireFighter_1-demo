using FireFIghter_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace FireFighter_1
{

    public class PlayerSkills(Player user)
    {
        




        //First generation skills
        public static void RegulareAttack(Player user)
        {
            if (user.PowerClass == 1)
            {

                Typewriter_Method.SlowType($"{user.Name} shoots small balls into the enemy\n");
                Typewriter_Method.SlowType("\n---------------------------\n", 50);
            }
            else if (user.PowerClass == 2)
            {

                Typewriter_Method.SlowType($"{user.Name} takes out a lighter and fires small arrow like flames at the enemy\n");
                Typewriter_Method.SlowType("\n---------------------------\n", 50);
            }
            else if (user.PowerClass == 3)
            {

                Typewriter_Method.SlowType($"{user.Name} creates waves of fire\n");
                Typewriter_Method.SlowType("\n---------------------------\n", 50);
            }
        }




        public static void Skill1(Player user)
        {
            if (user.PowerClass == 1)
            {

                Typewriter_Method.SlowType($"{user.Name} shoots a giant fireball into the enemy\n");
                Typewriter_Method.SlowType("\n---------------------------\n", 50);
            }
            else if(user.PowerClass == 2)
            {

                Typewriter_Method.SlowType($"{user.Name} creates two fireballs from the fires of the enemy and blasts them\n");
                Typewriter_Method.SlowType("\n---------------------------\n", 50);
            }
            else if(user.PowerClass == 3)
            {

                Typewriter_Method.SlowType($"{user.Name} shoots 2 fireballs, making them larger every second until impact\n");
                Typewriter_Method.SlowType("\n---------------------------\n", 50);
            }
            
        }


        public static void Skill2(Player user)
        {
            if (user.PowerClass == 1)
            {

                Typewriter_Method.SlowType($"{user.Name} shoots a giant fireball into the enemy\n");
                Typewriter_Method.SlowType("\n---------------------------\n", 50);
            }
            else if (user.PowerClass == 2)
            {

                Typewriter_Method.SlowType($"{user.Name} creates two fireballs from the fires of the enemy and blasts them\n");
                Typewriter_Method.SlowType("\n---------------------------\n", 50);
            }
            else if (user.PowerClass == 3)
            {

                Typewriter_Method.SlowType($"{user.Name} shoots 2 fireballs, making them larger every second until impact\n");
                Typewriter_Method.SlowType("\n---------------------------\n", 50);
            }

        }

        
        public static void Skill3(Player user)
        {
            if (user.PowerClass == 1)
            {

                Typewriter_Method.SlowType($"{user.Name} fires a missil of increadible power into the chest of the enemy \n");
                Typewriter_Method.SlowType("\n---------------------------\n", 50);
            }
            else if (user.PowerClass == 2)
            {

                Typewriter_Method.SlowType($"{user.Name} manipulates the air molecules inside the enemy to make create a large explosive inside of them\n");
                Typewriter_Method.SlowType("\n---------------------------\n", 50);
            }
            else if (user.PowerClass == 3)
            {
                
                Typewriter_Method.SlowType($"{user.Name} gathers all fires within a 100 mile radius into a nuke honed on the enemy\n");
                Typewriter_Method.SlowType("\n---------------------------\n", 50);
            }
        }
    }
}
