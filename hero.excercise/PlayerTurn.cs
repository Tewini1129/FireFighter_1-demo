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
            Console.WriteLine($"\t{Player.Name} current stats \n\t\t{Player.Hp}/{Player.MaxHp}");
            Console.WriteLine($"\t\t{Player.EnergyLevel}/{Player.MaxEnergyLevel}");
            Console.WriteLine($"\n\n\t{enemy.Name}current stats \n\t\t{enemy.Hp}/{enemy.MaxHp}");
            Console.WriteLine($"\t\t{enemy.EnergyLevel}/{enemy.MaxEnergyLevel}");
            Console.WriteLine("\n\n\tChose your next actions");
            Console.WriteLine("\t1.Use \"Heal\"");
            Console.WriteLine("\t2.Use \"Redbull\"");
            Console.WriteLine("\t3.Use \"Parry to gain Energy\"");
            Console.WriteLine("\t4.Use \"Regular Attack\"");

            //Skill 1
            if (Player.Progress != 0)
            {
                Console.WriteLine("\t5.Use \"Skill 1\"");
            }


            //Skill 2
            if (Player.Progress >= 2)
            {
                Console.WriteLine("\t6.Use \"Skill 2\" (-5 energy)");
            }


            //SKill 3
            if (Player.Progress >= 3)
            {
                Console.WriteLine("\t7.Use \"Skill 3\" (-7 energy)");
            }

            while (Start_Create.Continue == false)
            {
                userChoice = Console.ReadLine()!;
                Console.WriteLine("\n---------------------------\n\n");

                switch (userChoice)
                {
                    case "1":
                        if (Player.inventory.Contains("Healing potion"))
                        {


                            Player.Hp = Player.MaxHp;
                            Console.WriteLine($"\n\n{Player.Name}'s Hp is fully restored\n\t{Player.Name} Hp: {Player.Hp}");
                            Start_Create.Continue = true;
                        }
                        else
                        {
                            Console.WriteLine("\n\nYou are out of Healing potions...\n");
                        }
                        break;

                    case "2":
                        if (Player.inventory.Contains("Redbull"))
                        {


                            Player.EnergyLevel = Player.MaxEnergyLevel;
                            Console.WriteLine($"\n\n{Player.Name}'s Energy is fully restored\n\t{Player.Name} Energy Level: {Player.EnergyLevel}");
                            Start_Create.Continue = true;
                        }
                        else
                        {
                            Console.WriteLine("\n\nYou are out of Redbull...\n");
                        }

                        break;

                    case "3":

                        if (enemy.EnergyLevel != enemy.MaxEnergyLevel)
                        {
                            Console.WriteLine($"\n\n{Player.Name} prepares to parry the {enemy.Name}");
                            Console.WriteLine($"{Player.Name} gains +1 Energy\n {Player.Name}'s Energy level is now {Player.EnergyLevel}");
                            Player.Hp = enemy.Damage / 2;
                        }
                        else
                        {
                            Console.WriteLine($"\n{Player.Name} prepares to parry the {enemy.Name}");
                            Console.WriteLine($"{Player.Name} gains +1 Energy\n {Player.Name}'s Energy level is now {Player.EnergyLevel}");

                        }
                        Start_Create.Continue = true;
                        break;

                    case "4":
                        Skills.RegulareAttack();
                        enemy.Hp -= Player.RegulareDamage;
                        Console.WriteLine($"{Player.Name} has ");
                        Start_Create.Continue = true;
                        break;

                    case "5":
                        if (Player.EnergyLevel >= 3)
                        {
                            Skills.Skill1();
                            enemy.Hp -= Skills.skill1Damage;
                            Start_Create.Continue = true;
                        }

                        else
                        {
                            Console.WriteLine("Not enough Energy*");
                        }
                        break;

                    case "6":
                        if ((Player.Progress >= 2) && (Player.EnergyLevel >= 5))
                        {
                            Skills.Skill2();
                            enemy.Hp -= Skills.skill2Damage;
                            Start_Create.Continue = true;
                        }
                        else if (Player.Progress < 2)
                        {
                            Console.WriteLine("*Level to low*");
                        }
                        else
                        {
                            Console.WriteLine("Not enough Energy*");
                        }
                        break;

                    case "7":
                        if ((Player.Progress >= 3) && (Player.EnergyLevel >= 7))
                        {
                            Skills.Skill3();
                            enemy.Hp -= Skills.skill3Damage;
                            Start_Create.Continue = true;
                        }
                        else if (Player.Progress < 3)
                        {
                            Console.WriteLine("*Level to low*");
                        }
                        else
                        {
                            Console.WriteLine("Not enough Energy*");
                        }
                        break;

                    default:
                        Console.WriteLine($"{userChoice} is not a valid option, try Something else");
                        break;
                }

            }
            Start_Create.Continue = false;
        }
    }
}
