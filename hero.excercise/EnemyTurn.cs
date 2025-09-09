using FireFighter_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireFIghter_1
{
    internal class EnemyTurn
    {
        public static void FightEnemyturn(string userChoice, Player user, Enemy enemy)
        {
            //Infernal attack
            if (enemy.Hp >= 0)
            {
                if (enemy.EnergyLevel == enemy.MaxEnergyLevel)
                {
                    if (userChoice != "2")
                    {
                        Console.WriteLine($"{enemy.Name} uses his charged up energy to Produce a devastating blow of {enemy.Damage} damage");
                        Console.WriteLine("");
                        Player.Hp -= enemy.ultimate;
                        enemy.EnergyLevel = 0;
                    }
                    else
                    {
                        Console.WriteLine($"{enemy.Name} uses his charged up energy to Produce a devastating blow of {enemy.Damage} damage");

                        Console.WriteLine($"{Player.Name} tries to parry {enemy.Name} ultimate but still takes {enemy.Damage} damage ");
                        Player.Hp -= enemy.Damage;
                        enemy.EnergyLevel++;
                    }
                }
                else
                {
                    if (userChoice != "2")
                    {
                        Console.WriteLine($"{enemy.Name} throws a burning car at you, you tear through it but still take damage");
                        Console.WriteLine($"{Player.Name} takes {enemy.Damage}");
                        Player.Hp -= enemy.Damage;
                        enemy.EnergyLevel++;
                    }
                    else
                    {
                        enemy.EnergyLevel++;
                        Player.Hp -= 50;
                    }
                }
            }
        }

    }
}
