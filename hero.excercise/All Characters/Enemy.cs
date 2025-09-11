using FireFIghter_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace FireFighter_1
{

    

    public class Enemy
    {
        
        //name, level, hp, damage,
        public int Level;
        public string Name;
        public int MaxHp;
        public int Hp;
        public int MaxEnergyLevel;
        public int EnergyLevel;
        public int Damage;
        public int ultimate;




        public Enemy(Player user, int randomNumber)
        {
            if(Adventures.randomNumber == 0)
            {
                    Name = $"Infernal .{Player.Progress}";
                    MaxHp = Player.Progress * Player.MaxHp;
                    Hp = Player.Progress * Player.MaxHp;
                    EnergyLevel = 0;
                    MaxEnergyLevel = 5;
                    Damage = Player.RegulareDamage / 2;
                    ultimate = Player.RegulareDamage * 2;
            }
            else if (Adventures.randomNumber == 1)
            {
                    Level = Player.Progress;
                    Name = $"Demon Lv.{Player.Progress}";
                    MaxHp = (Player.Progress + 1) * Player.MaxHp;
                    Hp = Player.MaxHp;
                    MaxEnergyLevel = 5;
                    EnergyLevel = 0;
                    Damage = Player.RegulareDamage + 1 * Player.Progress;
                    ultimate = Player.RegulareDamage * 3;
            }
            else if(Adventures.randomNumber == 2)
            {
                    Level = Player.Progress;
                    if (Player.Progress >= 2)
                    {
                        Name = $"White Clad Lv.{Player.Progress}";


                    }
                    else
                    {
                        Name = "Boss:White Clad";
                    }
                    MaxHp = Player.Progress * Player.MaxHp + 100;
                    Hp = Player.Progress * Player.MaxHp + 100;
                    MaxEnergyLevel = 5;
                    EnergyLevel = 0;
                    Damage = (Player.RegulareDamage + 2) * Player.Progress;
                    ultimate = Player.RegulareDamage * 10;
                }
        }



        

    }
    
    



        
}
