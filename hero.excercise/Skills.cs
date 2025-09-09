using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace FireFighter_1
{

    public class Skills
    {
        public static int skill1Damage = Player.RegulareDamage * 2;
        public static int skill2Damage = Player.RegulareDamage * 3;
        public static int skill3Damage = Player.RegulareDamage * 10;




        //First generation skills
        public static void RegulareAttack()
        {
            if (Player.PowerClass == 1)
            {

                Console.WriteLine($"{Player.Name} shoots small balls into the enemy");
            }
            else if (Player.PowerClass == 2)
            {

                Console.WriteLine($"{Player.Name} takes out a lighter and fires small arrow like flames at the enemy");
            }
            else if (Player.PowerClass == 3)
            {

                Console.WriteLine($"{Player.Name} creates waves of fire");
            }
        }




        public static void Skill1()
        {
            if (Player.PowerClass == 1)
            {
                
                Console.WriteLine($"{Player.Name} shoots a giant fireball into the enemy");
            }
            else if(Player.PowerClass == 2)
            {
                
                Console.WriteLine($"{Player.Name} creates two fireballs from the fires of the enemy and blasts them");
            }
            else if(Player.PowerClass == 3)
            {
               
                Console.WriteLine($"{Player.Name} shoots 2 fireballs, making them larger every second until impact");
            }
            
        }


        public static void Skill2()
        {
            if (Player.PowerClass == 1)
            {
               
                Console.WriteLine($"{Player.Name} shoots a giant fireball into the enemy");
            }
            else if (Player.PowerClass == 2)
            {
                
                Console.WriteLine($"{Player.Name} creates two fireballs from the fires of the enemy and blasts them");
            }
            else if (Player.PowerClass == 3)
            {
               
                Console.WriteLine($"{Player.Name} shoots 2 fireballs, making them larger every second until impact");
            }

        }

        
        public static void Skill3()
        {
            if (Player.PowerClass == 1)
            {
                
                Console.WriteLine($"{Player.Name} fires a missil of increadible power into the chest of the enemy ");
            }
            else if (Player.PowerClass == 2)
            {
                
                Console.WriteLine($"{Player.Name} manipulates the air molecules inside the enemy to make create a large explosive inside of them");
            }
            else if (Player.PowerClass == 3)
            {
                ;
                Console.WriteLine($"{Player.Name} gathers all fires within a 100 mile radius into a nuke honed on the enemy");
            }
        }
    }
}
