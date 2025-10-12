using FireFighter_1;
using FireFighter_1.Menu_s;
using FireFighter_1.Store_Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireFighter_1
{
    public  class PlayerTurn
    {

        public static int Choice { get; private set; }
        
        public static void FightPlayerTurn(string userChoice, Player user, Enemy enemy)
        {
            //Player turn
            Console.Clear();
            Console.WriteLine("\n---------------------------\n\n");
            Typewriter_Method.SlowType($"\t{user.Name} current stats \n\t\t{user.Hp}/{user.MaxHp}\n");
            Typewriter_Method.SlowType($"\t\t{user.Shield}/{user.MaxShield}\n");
            Typewriter_Method.SlowType($"\t\t{user.EnergyLevel}/{user.MaxEnergyLevel}\n");
            Typewriter_Method.SlowType($"\n\t{enemy.Name} current stats \n\t\t{enemy.Hp}/{enemy.MaxHp}\n");
            Typewriter_Method.SlowType($"\t\t{enemy.EnergyLevel}/{enemy.MaxEnergyLevel}\n");
            Typewriter_Method.SlowType("\n\n    Chose your next actions\n\n");
           
            string Prompt = 
                (
                    $"\n-----< =========== >----\n\n\t{user.Name} current stats \n" +
                    $"\t\t{user.Hp}/{user.MaxHp}\n" +
                    $"\t\t{user.Shield}/{user.MaxShield}\n" +
                    $"\t\t{user.EnergyLevel}/{user.MaxEnergyLevel}\n\n" +
                    $"\t{enemy.Name} current stats \n" +
                    $"\t\t{enemy.Hp}/{enemy.MaxHp}\n" +
                    $"\t\t{enemy.EnergyLevel}/{enemy.MaxEnergyLevel}\n\n\n  " +
                    $"Chose your next actions\n"
                );

            string[] Options = 
                { 
                    "Use \"Heal\"",
                    "Use \"Redbull\"",
                    "Use \"Adolla Link\"",
                    "Use \"Parry to gain Energy\"",
                    "Use \"Regular Attack\"",
                    "",
                    "",
                    ""
                };
            //Skill 1
            if (user.Progress != 0)
            {
                Typewriter_Method.SlowType("\tUse \"Skill 1\"(-3 energy)\n");
                Options[5] = "Use \"Skill 1\"(-3 energy)";
            }


            //Skill 2
            if (user.Progress >= 2)
            {
                Typewriter_Method.SlowType("\tUse \"Skill 2\" (-5 energy)\n");
                Options[6] = "Use \"Skill 2\" (-5 energy)";
            }


            //SKill 3
            if (user.Progress >= 3)
            {
                Typewriter_Method.SlowType("\tUse \"Skill 3\" (-7 energy)\n");
                Options[7] = "7.Use \"Skill 3\" (-7 energy)";
            }


            Introduction.Continue = false;
            while (Introduction.Continue == false)
            {

                Console.WriteLine("\n---------------------------\n\n");

                //Menu
                FunMenu FightOptions = new FunMenu(Prompt, Options);
                FightOptions.Run();
                Choice = FightOptions.SelectedIndex;
                switch (FightOptions.SelectedIndex)
                {
                    case 0:
                        if (user.inventory["Health Potion  "].Amount > 0)
                        {
                            user.inventory["Health Potion  "].Items[0].Use(user);
                        }
                        else
                        {
                            Typewriter_Method.SlowType("\n\nYou are out of Healing potions...\n\n");
                            Typewriter_Method.SlowType("Choose another action:\n");
                            Typewriter_Method.SlowType("\n---------------------------\n", 90);

                        }
                        break;

                    case 1:
                        if (user.inventory["Redbull 500ml  "].Amount > 0)
                        {
                            user.inventory["Redbull 500ml  "].Items[0].Use(user);
                        }
                        else
                        {
                            Console.WriteLine("\n\nYou are out of Redbull...\n\n");
                            Typewriter_Method.SlowType("Choose another action:\n");
                            Typewriter_Method.SlowType("\n---------------------------\n", 90);

                        }

                        break;

                    case 2:
                        if (user.inventory["Adolla Link  "].Amount > 0)
                        {
                            user.inventory["Adolla Link  "].Items[0].Use(user);
                        }
                        else
                        {
                            Console.WriteLine("\n\nYou do not have a Adolla Link...\n\n");
                            Typewriter_Method.SlowType("Choose another action:\n");
                            Typewriter_Method.SlowType("\n---------------------------\n", 90);

                        }
                        break;

                    case 3:
                        Typewriter_Method.SlowType($"\n\n{user.Name} prepares to parry {enemy.Name}'s attack\n");
                        if(user.EnergyLevel == user.MaxEnergyLevel)
                        {
                            Typewriter_Method.SlowType($"{user.Name}'s Energy level is already at max\n\n");
                            Introduction.Continue = true;
                            Typewriter_Method.SlowType("\n---------------------------\n", 90);
                        }
                        else
                        {
                            user.EnergyLevel++;
                            Typewriter_Method.SlowType($"{user.Name} gains +1 Energy\n{user.Name}'s Energy level is now {user.EnergyLevel}\n\n");
                            Introduction.Continue = true;
                            Typewriter_Method.SlowType("\n---------------------------\n", 90);

                        }
                            break;

                    case 4:
                        PlayerSkills.RegularAttack(user, enemy);
                        
                        Introduction.Continue = true;
                        break;

                    case 5:
                        if (user.EnergyLevel >= 3)
                        {
                            PlayerSkills.Skill1(user, enemy);
                            
                            
                            
                            Introduction.Continue = true;
                        }

                        else
                        {
                            Typewriter_Method.SlowType("*Not enough Energy*\nChoose another action:\n");
                            Typewriter_Method.SlowType("\n---------------------------\n", 90);

                        }
                        break;

                    case 6:
                        if ((user.Progress >= 2) && (user.EnergyLevel >= 5))
                        {
                            PlayerSkills.Skill2(user, enemy);
                            
                            Introduction.Continue = true;
                        }
                        else if (user.Progress < 2)
                        {
                            Console.WriteLine("*Level to low*\n");
                            Typewriter_Method.SlowType("\n---------------------------\n", 90);

                        }
                        else
                        {
                            Typewriter_Method.SlowType("Not enough Energy*\nChoose another action:\n");
                            Typewriter_Method.SlowType("\n---------------------------\n", 90);


                        }
                        break;

                    case 7:
                        if ((user.Progress >= 3) && (user.EnergyLevel >= 7))
                        {
                            PlayerSkills.Skill3(user, enemy);
                            Introduction.Continue = true;
                        }
                        else if (user.Progress < 3)
                        {
                            Console.WriteLine("*Level to low*");
                            Typewriter_Method.SlowType("\n---------------------------\n", 90);
                        }
                        else
                        {
                            Typewriter_Method.SlowType("Not enough Energy*\nChoose another action:");
                            Typewriter_Method.SlowType("\n---------------------------\n", 90);


                        }
                        break;

                    default:
                        Typewriter_Method.SlowType($"{FightOptions.SelectedIndex} is not a valid option, try Something else\n");
                        Typewriter_Method.SlowType("\n---------------------------\n", 90);
                        break;
                }

            }
            if ((Fight.win == false)&&(user.Hp <= 0))
            {
                Introduction.Continue = false;
            }
            else
            {
                Introduction.Continue = true;
            }
        }
    }
}
