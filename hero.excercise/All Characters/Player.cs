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
        public int Clues;
        public string? Name;
        public int PowerClass;
        public int MaxHp;
        public int Hp;
        public int Shield;
        public int MaxShield;
        public int MaxEnergyLevel;
        public int EnergyLevel;
        public int RegulareDamage;
        public int Gold;
        public int Progress;
        public List<string> inventory = new List<string>();



        //Constructor
        public Player()
        {
            Name = Introduction.name;
        }
    }
}





       

        
    





