using FireFighter_1;
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
        public double Reward;


        public Enemy(Player user, int randomNumber)
        {
            if(Adventures.randomNumber == 0)
            {
                Name = $"Infernal .{user.Progress}";
                MaxHp = user.Progress * user.OriginalHp;
                Hp = user.Progress * user.OriginalHp;
                EnergyLevel = 0;
                MaxEnergyLevel = 5;
                Damage = user.RegulareDamage / 2;
                ultimate = user.RegulareDamage * 2;
                Reward = 6;
            }
            else if (Adventures.randomNumber == 1)
            {
                Level = user.Progress;
                Name = $"Demon Lv.{user.Progress}";
                MaxHp = user.OriginalHp;
                Hp = user.OriginalHp;
                MaxEnergyLevel = 5;
                EnergyLevel = 0;
                Damage = user.OriginalDamage + 1 * user.Progress;
                ultimate = user.OriginalDamage * 3;
                Reward = 9;
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
                MaxHp = ((user.Progress * user.OriginalHp) + 150);
                Hp = ((user.Progress * user.OriginalHp) + 150);
                MaxEnergyLevel = 5;
                EnergyLevel = 0;
                Damage = (user.OriginalDamage + 50) * user.Progress;
                ultimate = user.RegulareDamage * 10;
                Reward = 18;
                }
        }
    }
}
