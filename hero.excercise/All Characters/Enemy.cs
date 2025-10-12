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
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private int maxHp;
        public int MaxHp
        {
            get { return maxHp; }
            set { maxHp = value; }
        }

        private int hp;
        public int Hp
        {
            get { return hp; }
            set { hp = value; }
        }

        private int maxEnergyLevel;
        public int MaxEnergyLevel
        {
            get { return maxEnergyLevel; }
            set { maxEnergyLevel = value; }
        }

        private int energyLevel;
        public int EnergyLevel
        {
            get { return energyLevel; }
            set { energyLevel = value; }
        }

        private int damage;
        public int Damage
        {
            get { return damage; }
            set { damage = value; }
        }

        private int ultimate;
        public int Ultimate
        {
            get { return ultimate; }
            set { ultimate = value; }
        }
        private double reward;
        public double Reward
        {
            get { return reward; }
            set { reward = value; }
        }



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
                
                Name = $"Demon Lv.{user.Progress}";
                MaxHp = user.MaxHp;
                Hp = user.Hp;
                MaxEnergyLevel = 5;
                EnergyLevel = 0;
                Damage = (user.OriginalDamage + 1 * user.Progress);
                ultimate = user.OriginalDamage * 3;
                Reward = 9;
            }
            else if(Adventures.randomNumber == 2)
            {
                
                    if (user.Progress >= 2)
                    {
                        Name = $"White Clad Lv.{user.Progress}";
                    }
                    else
                    {
                        Name = "Boss:White Clad";
                    }
                MaxHp = (user.Progress * (user.OriginalHp + 150));
                Hp = (user.Progress * (user.OriginalHp + 150));
                MaxEnergyLevel = 5;
                EnergyLevel = 0;
                Damage = (user.OriginalDamage + 150) * user.Progress;
                ultimate = user.RegulareDamage * 10;
                Reward = 18;
                }
        }
    }
}
