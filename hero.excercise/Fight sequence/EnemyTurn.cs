using FireFighter_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FireFighter_1
{
    internal class EnemyTurn
    {
        public static void FightEnemyturn(string userChoice, Player user, Enemy enemy)
        {
            
            
            
            if (enemy.Hp > 0)
            {
                if (enemy.EnergyLevel == enemy.MaxEnergyLevel)
                {
                    if (PlayerTurn.Choice != 3)
                    {
                        if ((enemy.Name == "Boss:White Clad") || (enemy.Name == $"White Clad Lv.{user.Progress}"))
                        {
                            Typewriter_Method.SlowType($"\n{enemy.Name} releases the pent up energy and blasts with a horrifying {enemy.ultimate} damage\n");
                            Console.WriteLine("");
                        }
                        else if (enemy.Name == $"Demon Lv.{user.Progress}")
                        {
                            Typewriter_Method.SlowType($"\n{enemy.Name} opens up his mouth breathing heavy fire out {enemy.ultimate} damage\n");
                            Console.WriteLine("");
                        }
                        else if (enemy.Name == $"Infernal .{user.Progress}")
                        {
                            Typewriter_Method.SlowType($"\n{enemy.Name} uses his charged up energy to Produce a devastating blow of {enemy.ultimate} damage\n");
                            Console.WriteLine("");
                        }
                        if (user.Shield <= 0)
                        {
                            user.Hp -= enemy.ultimate;
            
                        }
                        else if (user.Shield < enemy.ultimate)
                        {
                            int damageOverflow = enemy.ultimate - user.Shield;
                            user.Shield = 0;
                            user.Hp -= damageOverflow;
            
                        }
                        else
                        {
                            user.Shield -= enemy.ultimate;
                        }
            
                        enemy.EnergyLevel = 0;
                        Typewriter_Method.SlowType("\n---------------------------\n", 110);
                    }
                    else
                    {
                    if ((enemy.Name == "Boss:White Clad") || (enemy.Name == $"White Clad Lv.{user.Progress}"))
                    {
                        Typewriter_Method.SlowType($"\n{enemy.Name} releases the pent up energy and blasts with a horrifying big nuke like attack\n");
            
                        Typewriter_Method.SlowType($"{user.Name} tries to parry {enemy.Name} ultimate but still takes {enemy.Damage} damage \n");
                    }
                    else if (enemy.Name == $"Demon Lv.{user.Progress}")
                    {
                        Typewriter_Method.SlowType($"\n{enemy.Name} opens up his mouth breathing heavy fire out {enemy.Damage} damage\n");
            
                        Typewriter_Method.SlowType($"{user.Name} tries to parry {enemy.Name} ultimate but it still burns up his arms {enemy.Damage} damage \n");
            
                    }
                    else if (enemy.Name == $"Infernal .{user.Progress}")
                    {
                        Typewriter_Method.SlowType($"\n{enemy.Name} uses his charged up energy to Produce a devastating blow of {enemy.Damage} damage\n");
            
                        Typewriter_Method.SlowType($"{user.Name} tries to parry {enemy.Name} ultimate but still takes {enemy.Damage} damage \n");
            
                    }
            
                    if (user.Shield <= 0)
                    {
                        user.Hp -= enemy.Damage;
            
                    }
                    else if (user.Shield < enemy.Damage)
                    {
                        int damageOverflow = enemy.Damage - user.Shield;
                        user.Shield = 0;
                        user.Hp -= damageOverflow;
            
                    }
                    else
                    {
                        user.Shield -= enemy.Damage;
                    }
            
                        enemy.EnergyLevel = 0;
            
                        Typewriter_Method.SlowType("\n---------------------------\n", 120);
                    }
                }
                else
                {
                    if((PlayerTurn.Choice == 0)||(PlayerTurn.Choice == 1)||(PlayerTurn.Choice == 2))
                    {
                    
                        Typewriter_Method.SlowType($"As soon as you finnish the bottle {enemy.Name} runs up and gets a clean hook right into your ribs\n");
                        Typewriter_Method.SlowType($"{user.Name} takes {enemy.Damage}\n");
                    
                    
            
                        if (user.Shield <= 0)
                        {
                            user.Hp -= enemy.Damage;
            
                        }
                        else if (user.Shield < enemy.Damage)
                        {
                            int damageOverflow = enemy.Damage - user.Shield;
                            user.Shield = 0;
                            user.Hp -= damageOverflow;
            
                        }
                        else
                        {
                            user.Shield -= enemy.Damage;
                        }
            
                        enemy.EnergyLevel++;
                        Typewriter_Method.SlowType("\n---------------------------\n", 120);
                    }
                    else if (PlayerTurn.Choice != 3)
                    {
                        if ((enemy.Name == "Boss:White Clad") || (enemy.Name == $"White Clad Lv.{user.Progress}"))
                        {
                            Typewriter_Method.SlowType($"{enemy.Name} Absorbed your fiery blasts and returns them even more powerfull all in one punch\n");
                            Typewriter_Method.SlowType($"{user.Name} takes {enemy.Damage}\n");
                        }
                        else if (enemy.Name == $"Demon Lv.{user.Progress}")
                        {
                            Typewriter_Method.SlowType($"{enemy.Name} appears next to you sending his fot into you face -{enemy.Damage} damage\n");
                            Typewriter_Method.SlowType($"{user.Name} takes {enemy.Damage}\n");
            
                        }
                        else if (enemy.Name == $"Infernal .{user.Progress}")
                        {
                        Typewriter_Method.SlowType($"{enemy.Name} throws a burning car at you, you tear through it but still take some damage\n");
                        Typewriter_Method.SlowType($"{user.Name} takes {enemy.Damage}\n");
            
                        }
                        if (user.Shield < enemy.Damage)
                        {
                            int damageOverflow = enemy.Damage - user.Shield;
                            user.Shield = 0;
                            user.Hp -= damageOverflow;
            
                        }
                        else
                        {
                            user.Shield -= enemy.Damage;
                        }
                        enemy.EnergyLevel++;
                        Typewriter_Method.SlowType("\n---------------------------\n", 100);
                    }
                    else
                    {
                        Typewriter_Method.SlowType($"{enemy.Name} hits you with a barrage of punches while you put up your guard\nAs his punches slow,you manage slip away with only -{enemy.Damage/2} damage ");
                    if ((enemy.Name == "Boss:White Clad") || (enemy.Name == $"White Clad Lv.{user.Progress}"))
                    {
                        Typewriter_Method.SlowType($"{enemy.Name} hits you with a barrage of punches while you put up your guard\nAs his punches slow,you manage slip away with only -{enemy.Damage / 2} damage ");
                    }
                    else if (enemy.Name == $"Demon Lv.{user.Progress}")
                    {
                        Typewriter_Method.SlowType($"{enemy.Name} shoots a stream of fire\n You dodged but it still grazed you taking -{enemy.Damage / 2}");
            
                    }
                    else if (enemy.Name == $"Infernal .{user.Progress}")
                    {
                        Typewriter_Method.SlowType($"{enemy.Name} throws a burning car at you, you tear through it but still take some damage\n");
                        Typewriter_Method.SlowType($"{user.Name} jumps away but it stills grazes him {enemy.Damage / 2}\n");
            
                    }
            
            
                    enemy.EnergyLevel++;
                    
                    
                        if(user.Shield <= 0)
                        {
                            user.Hp -= enemy.Damage / 2;
            
                        }
                        
                        
                        else if(user.Shield < enemy.Damage)
                        {
                            int damageOverflow = (enemy.Damage/2) - user.Shield; 
                            user.Shield = 0;
                            user.Hp -= damageOverflow;
            
                        }
                        else
                        {
                            user.Shield -= enemy.Damage / 2;
                        }
                               
            
                        
                        Typewriter_Method.SlowType("\n---------------------------\n", 100);
                    }
                }
            }
        }
    }
}
