using FireFighter_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace FireFighter_1
{

    public class PlayerSkills
    {
        
        public static void RegularAttack(Player user, Enemy enemy)
        {
            if (user.PowerClass == 1)
            {
                enemy.Hp -= user.RegulareDamage;
                Typewriter_Method.SlowType($"{user.Name} shoots small balls of fire into the enemy\n");
                Typewriter_Method.SlowType("\n---------------------------\n", 50);
                Typewriter_Method.SlowType($"{user.Name} deals {user.RegulareDamage}\n");

            }
            else if (user.PowerClass == 2)
            {
                enemy.Hp -= user.RegulareDamage;
                Typewriter_Method.SlowType($"{user.Name} takes out a lighter and fires small arrow like flames at the enemy\n");
                Typewriter_Method.SlowType("\n---------------------------\n", 50);
                Typewriter_Method.SlowType($"{user.Name} deals {user.RegulareDamage}\n");

            }
            else if (user.PowerClass == 3)
            {
                enemy.Hp -= user.RegulareDamage;
                Typewriter_Method.SlowType($"{user.Name} creates waves of fire\n");
                Typewriter_Method.SlowType($"{user.Name} deals {user.RegulareDamage}\n");

                Typewriter_Method.SlowType("\n---------------------------\n", 50);
            }
        }




        public static void Skill1(Player user, Enemy enemy)
        {
            if (user.PowerClass == 1)
            {

                Typewriter_Method.SlowType($"{user.Name} shoots a giant fireball into the enemy\n");
                Typewriter_Method.SlowType($"{user.Name} deals {user.RegulareDamage * 2}\n");
                enemy.Hp -= (user.RegulareDamage * 2);
                user.EnergyLevel -= 3;

                Typewriter_Method.SlowType("\n---------------------------\n", 50);
            }
            else if(user.PowerClass == 2)
            {

                Typewriter_Method.SlowType($"{user.Name} creates two fireballs from the fires of the enemy and blasts them\n");
                Typewriter_Method.SlowType($"{user.Name} deals {user.RegulareDamage * 2}\n");
                enemy.Hp -= (user.RegulareDamage * 2);
                user.EnergyLevel -= 3;
                Typewriter_Method.SlowType("\n---------------------------\n", 50);
            }
            else if(user.PowerClass == 3)
            {

                Typewriter_Method.SlowType($"{user.Name} shoots 2 fireballs, making them larger every second until impact\n");
                Typewriter_Method.SlowType($"{user.Name} deals {user.RegulareDamage * 2}\n");
                enemy.Hp -= (user.RegulareDamage * 2);
                user.EnergyLevel -= 3;
                Typewriter_Method.SlowType("\n---------------------------\n", 50);
            }
            
        }


        public static void Skill2(Player user, Enemy enemy)
        {
            if (user.PowerClass == 1)
            {

                Typewriter_Method.SlowType($"{user.Name} shoots a giant fireball into the enemy\n");
                Typewriter_Method.SlowType($"{user.Name} deals {user.RegulareDamage * 3}\n");
                enemy.Hp -= (user.RegulareDamage * 3);
                user.EnergyLevel -= 5;
                Typewriter_Method.SlowType("\n---------------------------\n", 50);
            }
            else if (user.PowerClass == 2)
            {

                Typewriter_Method.SlowType($"{user.Name} creates two fireballs from the fires of the enemy and blasts them\n");
                Typewriter_Method.SlowType($"{user.Name} deals {user.RegulareDamage * 3}\n");
                enemy.Hp -= (user.RegulareDamage * 3);
                user.EnergyLevel -= 5;
                Typewriter_Method.SlowType("\n---------------------------\n", 50);
            }
            else if (user.PowerClass == 3)
            {

                Typewriter_Method.SlowType($"{user.Name} creates fires away tiny seeds of sparks behind himself \n");
                Typewriter_Method.SlowType($"The spiral around eachother in pairs creating 4 huge Pillars of fire \n");
                Typewriter_Method.SlowType($"{user.Name} bends the pillars all in the dirrection of {enemy.Name} and blast him with extreme heat\n");

                Typewriter_Method.SlowType($"{user.Name} deals {user.RegulareDamage * 3}\n");
                enemy.Hp -= (user.RegulareDamage * 3);
                user.EnergyLevel -= 5; Typewriter_Method.SlowType("\n---------------------------\n", 150);
            }

        }

        
        public static void Skill3(Player user, Enemy enemy)
        {
            if (user.PowerClass == 1)
            {

                Typewriter_Method.SlowType($"{user.Name} fires a missile of incredible power into the chest of the enemy \n");
                Typewriter_Method.SlowType($"{user.Name} deals {user.RegulareDamage * 10}\n");
                enemy.Hp -= (user.RegulareDamage * 10);
                user.EnergyLevel -= 7;
                Typewriter_Method.SlowType("\n---------------------------\n", 50);
            }
            else if (user.PowerClass == 2)
            {

                Typewriter_Method.SlowType($"{user.Name} manipulates the air molecules inside the enemy to make create a large explosive inside of them\n");
                Typewriter_Method.SlowType($"{user.Name} deals {user.RegulareDamage * 10}\n");
                enemy.Hp -= (user.RegulareDamage * 10);
                user.EnergyLevel -= 7;
                Typewriter_Method.SlowType("\n---------------------------\n", 50);
            }
            else if (user.PowerClass == 3)
            {
                
                Typewriter_Method.SlowType($"{user.Name} gathers all fires within a 100 mile radius into a nuke honed on the enemy\n");
                Typewriter_Method.SlowType($"{user.Name} deals {user.RegulareDamage * 10}\n");
                enemy.Hp -= (user.RegulareDamage * 10);
                user.EnergyLevel -= 7;
                Typewriter_Method.SlowType("\n---------------------------\n", 50);
            }
        }
    }
}
