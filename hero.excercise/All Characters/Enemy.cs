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
        public string Name = "";
        public int MaxHp;
        public int Hp;
        public int MaxEnergyLevel;
        public int EnergyLevel;
        public int Damage;
        public int ultimate;
        public int Reward;


        public Enemy(Player user, int randomNumber)
        {
            if(Adventures.randomNumber == 0)
            {
                Name = $"Infernal .{user.Progress}";
                MaxHp = user.Progress * user.MaxHp;
                Hp = user.Progress * user.MaxHp;
                    EnergyLevel = 0;
                    MaxEnergyLevel = 5;
                Damage = user.RegulareDamage / 2;
                ultimate = user.RegulareDamage * 2;
                Reward = 2;
            }
            else if (Adventures.randomNumber == 1)
            {
                Level = user.Progress;
                Name = $"Demon Lv.{user.Progress}";
                MaxHp = (user.Progress + 1) * user.MaxHp;
                Hp = user.MaxHp;
                    MaxEnergyLevel = 5;
                    EnergyLevel = 0;
                Damage = user.RegulareDamage + 1 * user.Progress;
                ultimate = user.RegulareDamage * 3;
                Reward = 3;
            }
            else if(Adventures.randomNumber == 2)
            {
                Level = user.Progress;
                    if (user.Progress >= 2)
                    {
                    Name = $"White Clad Lv.{user.Progress}";


                    }
                    else
                    {
                    Name = "Boss:White Clad";
                    }
                MaxHp = user.Progress * user.MaxHp + 100;
                Hp = user.Progress * user.MaxHp + 100;
                    MaxEnergyLevel = 5;
                    EnergyLevel = 0;
                Damage = (user.RegulareDamage + 2) * user.Progress;
                ultimate = user.RegulareDamage * 10;
                Reward = 6;
                }
        }
    }
}
