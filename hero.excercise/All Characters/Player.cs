using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireFighter_1
{

    public class Player
    {


        //Stats
        public static int Clues;
        public static string? Name;
        public static int PowerClass;
        public static int MaxHp;
        public static int Hp;
        public static int Shield;
        public static int MaxShield;
        public static int MaxEnergyLevel;
        public static int EnergyLevel;
        public static int RegulareDamage;
        public static int Gold;
        public static int Progress;
        public static List<string> inventory = new List<string>();



        //Constructor
        public Player()
        {

            Name = Introduction.name;
            
             
            
            if (PowerClass == 1)
            {
                //Stats
                Progress = 1;
                PowerClass = 1;
                MaxHp = 120; 
                Hp = 120;
                MaxShield = (Player.MaxHp / 2);
                Shield = (Player.MaxHp / 2);
                MaxEnergyLevel = 10;
                EnergyLevel = 10;
                RegulareDamage = 30;
                Gold = 2;






            }

            else if (PowerClass == 2)
            {
                //Stats
                Progress = 1;
                PowerClass = 2;
                MaxHp = 130;
                Hp = 130;
                Shield = (Player.MaxHp / 2);
                MaxEnergyLevel = 6;
                EnergyLevel = 6;
                RegulareDamage = 40;
                Gold = 4;
                
                
            }
            else if (PowerClass == 3)
            {
                Progress = 1;
                PowerClass = 3;
                MaxHp = 120;
                Hp = 120;
                Shield = (Player.MaxHp / 2);
                MaxEnergyLevel = 10;
                EnergyLevel = 10;
                RegulareDamage = 50;
                Gold = 1;
                
                


            }

        }

        
        
        

    }


}





       

        
    





