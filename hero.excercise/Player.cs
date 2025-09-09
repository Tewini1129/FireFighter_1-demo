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
        public static int MaxEnergyLevel;
        public static int EnergyLevel;
        public static int RegulareDamage;
        public static int Gold;
        public static int Progress;
        public static List<string> inventory = new List<string>();



        //Constructor
        public Player()
        {

            Name = Start_Create.name;
            
             
            
            if (PowerClass == 1)
            {
                //Stats
                PowerClass = 1;
                MaxHp = 100; 
                Hp = 100;
                MaxEnergyLevel = 10;
                EnergyLevel = 10;
                RegulareDamage = 35;
                Gold = 2;
                Progress = 1;
                

                

                

            }

            else if (PowerClass == 2)
            {
                //Stats
                PowerClass = 2;
                MaxHp = 100;
                Hp = 100;
                MaxEnergyLevel = 5;
                EnergyLevel = 5;
                RegulareDamage = 25;
                Gold = 4;
                Progress = 1;
                
            }
            else if (PowerClass == 3)
            {
                PowerClass = 3;
                MaxHp = 100;
                Hp = 100;
                MaxEnergyLevel = 10;
                EnergyLevel = 10;
                RegulareDamage = 45;
                Gold = 1;
                Progress = 1;
                


            }

        }

        
        
        

    }


}





       

        
    





