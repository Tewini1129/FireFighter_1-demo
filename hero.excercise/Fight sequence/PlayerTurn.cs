using FireFighter_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireFIghter_1
{
    public  class PlayerTurn
    {
        
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
            Typewriter_Method.SlowType("\n\n\tChose your next actions\n");
            Typewriter_Method.SlowType("\n\t1.Use \"Heal\"\n");
            Typewriter_Method.SlowType("\t2.Use \"Redbull\"\n");
            Typewriter_Method.SlowType("\t3.Use \"Parry to gain Energy\"\n");
            Typewriter_Method.SlowType("\t4.Use \"Regular Attack\"\n");

            //Skill 1
            if (user.Progress != 0)
            {
                Typewriter_Method.SlowType("\t5.Use \"Skill 1\"(-3 energy)\n");
            }


            //Skill 2
            if (user.Progress >= 2)
            {
                Typewriter_Method.SlowType("\t6.Use \"Skill 2\" (-5 energy)\n");
            }


            //SKill 3
            if (user.Progress >= 3)
            {
                Typewriter_Method.SlowType("\t7.Use \"Skill 3\" (-7 energy)\n");
            }

            Introduction.Continue = false;
            while (Introduction.Continue == false)
            {
                Fight.userChoice = Console.ReadLine()!;
                Console.WriteLine("\n---------------------------\n\n");

                switch (Fight.userChoice)
                {
                    case "1":
                        if (user.inventory.Contains("Healing potion"))
                        {


                            user.Hp = user.MaxHp;
                            user.EnergyLevel = user.MaxEnergyLevel;

                            Typewriter_Method.SlowType($"\n\n{user.Name}'s Hp and Energy is fully restored\n\t{user.Name} Hp: {user.Hp} Energy Level: {user.EnergyLevel}\n");
                            user.inventory.Remove("Healing potion");
                            Introduction.Continue = true;
                            Typewriter_Method.SlowType("\n---------------------------\n", 90);
                        }
                        else
                        {
                            Typewriter_Method.SlowType("\n\nYou are out of Healing potions...\n\n");
                            Typewriter_Method.SlowType("Choose another action:\n");
                            Typewriter_Method.SlowType("\n---------------------------\n", 90);

                        }
                        break;

                    case "2":
                        if (user.inventory.Contains("Redbull"))
                        {


                            user.Shield = user.MaxShield;
                            Typewriter_Method.SlowType($"\n{user.Name} cracks a ice cold redbull...{user.Name} gets wings\n");

                            Typewriter_Method.SlowType($"\n\n{user.Name}'s Shield is fully restored\n\t{user.Name} Shield: {user.Shield}\n");
                            Introduction.Continue = true;


                            Typewriter_Method.SlowType("\n---------------------------\n", 90);
                        }
                        else
                        {
                            Console.WriteLine("\n\nYou are out of Redbull...\n\n");
                            Typewriter_Method.SlowType("Choose another action:\n");
                            Typewriter_Method.SlowType("\n---------------------------\n", 90);

                        }

                        break;

                    case "3":
                        Typewriter_Method.SlowType($"\n\n{user.Name} prepares to parry {enemy.Name}'s attack\n");
                        user.EnergyLevel++;
                        Typewriter_Method.SlowType($"{user.Name} gains +1 Energy\n{user.Name}'s Energy level is now {user.EnergyLevel}\n\n");
                        Introduction.Continue = true;
                        Typewriter_Method.SlowType("\n---------------------------\n", 90);
                        break;

                    case "4":
                        PlayerSkills.RegulareAttack(user);
                        enemy.Hp -= user.RegulareDamage;
                        Introduction.Continue = true;
                        break;

                    case "5":
                        if (user.EnergyLevel >= 3)
                        {
                            PlayerSkills.Skill1(user);
                            enemy.Hp -= (user.RegulareDamage * 2);
                            
                            user.EnergyLevel -= 3;
                            Introduction.Continue = true;
                        }

                        else
                        {
                            Typewriter_Method.SlowType("*Not enough Energy*\nChoose another action:\n");
                            Typewriter_Method.SlowType("\n---------------------------\n", 90);

                        }
                        break;

                    case "6":
                        if ((user.Progress >= 2) && (user.EnergyLevel >= 5))
                        {
                            PlayerSkills.Skill2(user);
                            enemy.Hp -= (user.RegulareDamage * 3);
                            user.EnergyLevel -= 5;
                            Introduction.Continue = true;
                        }
                        else if (user.Progress < 2)
                        {
                            Console.WriteLine("*Level to low*\n");
                        }
                        else
                        {
                            Typewriter_Method.SlowType("Not enough Energy*\nChoose another action:\n");
                            Typewriter_Method.SlowType("\n---------------------------\n", 90);


                        }
                        break;

                    case "7":
                        if ((user.Progress >= 3) && (user.EnergyLevel >= 7))
                        {
                            PlayerSkills.Skill3(user);
                            enemy.Hp -= (user.RegulareDamage * 10);
                            user.EnergyLevel -= 7;
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
                        Typewriter_Method.SlowType($"{Fight.userChoice} is not a valid option, try Something else\n");
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
