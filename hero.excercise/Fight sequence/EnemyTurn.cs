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
            if ( enemy.Name == $"Infernal .{Player.Progress}")
            {
                //Enemy attack
                if (enemy.Hp > 0)
                {
                    if (enemy.EnergyLevel == enemy.MaxEnergyLevel)
                    {
                        if (Fight.userChoice != "3")
                        {
                            Typewriter_Method.SlowType($"\n{enemy.Name} uses his charged up energy to Produce a devastating blow of {enemy.ultimate} damage\n");
                            Console.WriteLine("");
                            Player.Hp -= enemy.ultimate;
                            enemy.EnergyLevel = 0;
                            Typewriter_Method.SlowType("\n---------------------------\n", 110);
                        }
                        else
                        {
                            Typewriter_Method.SlowType($"\n{enemy.Name} uses his charged up energy to Produce a devastating blow of {enemy.Damage} damage\n");

                            Typewriter_Method.SlowType($"{Player.Name} tries to parry {enemy.Name} ultimate but still takes {enemy.Damage} damage \n");
                            Player.Hp -= enemy.Damage;
                            enemy.EnergyLevel++;
                            Typewriter_Method.SlowType("\n---------------------------\n", 110);
                        }
                    }
                    else
                    {
                        if (userChoice != "3")
                        {
                            Typewriter_Method.SlowType($"{enemy.Name} throws a burning car at you, you tear through it but still take some damage\n");
                            Typewriter_Method.SlowType($"{Player.Name} takes {enemy.Damage}\n");
                            Player.Hp -= enemy.Damage;
                            enemy.EnergyLevel++;
                            Typewriter_Method.SlowType("\n---------------------------\n", 100);
                        }
                        else
                        {
                            Typewriter_Method.SlowType($"{enemy.Name} throws a burning car at you, you tear through it but still take some damage\n");
                            Typewriter_Method.SlowType($"{Player.Name} jumps away but it stills grazes him {enemy.Damage/2}\n");
                            enemy.EnergyLevel++;
                            Player.Hp -= enemy.Damage / 2;
                        }
                    }
                }
            }
            if (enemy.Name == $"Demon Lv.{Player.Progress}")
            {
                //Enemy attack
                if (enemy.Hp > 0)
                {
                    if (enemy.EnergyLevel == enemy.MaxEnergyLevel)
                    {
                        if (Fight.userChoice != "3")
                        {
                            Typewriter_Method.SlowType($"\n{enemy.Name}opens up his mouth breathing heavy fire out {enemy.Damage} damage\n");
                            Console.WriteLine("");
                            Player.Hp -= enemy.ultimate;
                            enemy.EnergyLevel = 0;
                            Typewriter_Method.SlowType("\n---------------------------\n", 110);
                        }
                        else
                        {
                            Typewriter_Method.SlowType($"\n{enemy.Name} opens up his mouth breathing heavy fire out {enemy.Damage} damage\n");

                            Typewriter_Method.SlowType($"{Player.Name} tries to parry {enemy.Name} ultimate but it still burns up his arms {enemy.Damage} damage \n");
                            Player.Hp -= enemy.Damage;
                            enemy.EnergyLevel++;
                            Typewriter_Method.SlowType("\n---------------------------\n", 120);
                        }
                    }
                    else
                    {
                        if (userChoice != "3")
                        {
                            Typewriter_Method.SlowType($"{enemy.Name} appears next to you sending his fot into you face -{enemy.Damage} damage\n");
                            Typewriter_Method.SlowType($"{Player.Name} takes {enemy.Damage}\n");
                            Player.Hp -= enemy.Damage;
                            enemy.EnergyLevel++;
                            Typewriter_Method.SlowType("\n---------------------------\n", 100);
                        }
                        else
                        {
                            Typewriter_Method.SlowType($"{enemy.Name} shoots a stream of fire\n You dodged but it still grazed you taking -{enemy.Damage/2}");
                            enemy.EnergyLevel++;
                            Player.Hp -= enemy.Damage / 2;
                        }
                    }
                }
            }
            if ((enemy.Name == "Boss:White Clad")||(enemy.Name == $"White Clad Lv.{Player.Progress}"))
            {
                //Enemy attack
                if (enemy.Hp > 0)
                {
                    if (enemy.EnergyLevel == enemy.MaxEnergyLevel)
                    {
                        if (Fight.userChoice != "3")
                        {
                            Typewriter_Method.SlowType($"\n{enemy.Name} releases the pent up energy and blasts with a horrifying {enemy.ultimate} damage\n");
                            Console.WriteLine("");
                            if (Player.Shield >= 0)
                            {
                                Player.Hp -= enemy.ultimate;

                            }
                            else
                            {
                                Player.Shield -= enemy.ultimate;

                            }
                            enemy.EnergyLevel = 0;
                            Typewriter_Method.SlowType("\n---------------------------\n", 110);
                        }
                        else
                        {
                            Typewriter_Method.SlowType($"\n{enemy.Name} releases the pent up energy and blasts with a horrifying big nuke like attack\n");

                            Typewriter_Method.SlowType($"{Player.Name} tries to parry {enemy.Name} ultimate but still takes {enemy.Damage} damage \n");
                            if (Player.Shield >= 0)
                            {
                                Player.Hp -= enemy.Damage;

                            }
                            else
                            {
                                Player.Shield -= enemy.Damage;

                            }
                            enemy.EnergyLevel = 0;
                            
                            Typewriter_Method.SlowType("\n---------------------------\n", 120);
                        }
                    }
                    else
                    {
                        if((userChoice == "1")||(userChoice == "2"))
                        {
                            Typewriter_Method.SlowType($"As soon as you finnish the bottle {enemy.Name} runs up and gets a clean hook right into your ribs\n");
                            Typewriter_Method.SlowType($"{Player.Name} takes {enemy.Damage}\n");
                            if (Player.Shield >= 0)
                            {
                                Player.Hp -= enemy.Damage;

                            }
                            else
                            {
                                Player.Shield -= enemy.Damage;

                            }
                            enemy.EnergyLevel++;
                            Typewriter_Method.SlowType("\n---------------------------\n", 120);
                        }
                        else if (userChoice != "3")
                        {
                            Typewriter_Method.SlowType($"{enemy.Name} Absorbed the your fiery blasts and returns them even more powerfull all in one punch\n");
                            Typewriter_Method.SlowType($"{Player.Name} takes {enemy.Damage}\n");
                            Player.Hp -= enemy.Damage;
                            enemy.EnergyLevel++;
                            Typewriter_Method.SlowType("\n---------------------------\n", 100);
                        }
                        else
                        {
                            Typewriter_Method.SlowType($"{enemy.Name} hits you with a barrage of punches while you put up your guard\nAs his punches slow,you manage slip away with only -{enemy.Damage/2} damage ");
                            enemy.EnergyLevel++;
                            if(Player.Shield >= 0)
                            {
                                Player.Hp -= enemy.Damage / 2;

                            }
                            else
                            {
                                Player.Shield -= enemy.Damage / 2;

                            }
                            Typewriter_Method.SlowType("\n---------------------------\n", 100);
                        }
                    }
                }
            }
            }

    }
}
