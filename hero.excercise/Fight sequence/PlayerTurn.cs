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
            Typewriter_Method.SlowType($"\t{Player.Name} current stats \n\t\t{Player.Hp}/{Player.MaxHp}\n");
            Typewriter_Method.SlowType($"\t\t{Player.EnergyLevel}/{Player.MaxEnergyLevel}");
            Typewriter_Method.SlowType($"\n\n\t{enemy.Name} current stats \n\t\t{enemy.Hp}/{enemy.MaxHp}\n");
            Typewriter_Method.SlowType($"\t\t{enemy.EnergyLevel}/{enemy.MaxEnergyLevel}\n");
            Typewriter_Method.SlowType("\n\n\tChose your next actions\n");
            Typewriter_Method.SlowType("\n\t1.Use \"Heal\"\n");
            Typewriter_Method.SlowType("\t2.Use \"Redbull\"\n");
            Typewriter_Method.SlowType("\t3.Use \"Parry to gain Energy\"\n");
            Typewriter_Method.SlowType("\t4.Use \"Regular Attack\"\n");

            //Skill 1
            if (Player.Progress != 0)
            {
                Typewriter_Method.SlowType("\t5.Use \"Skill 1\"(-3 energy)\n");
            }


            //Skill 2
            if (Player.Progress >= 2)
            {
                Typewriter_Method.SlowType("\t6.Use \"Skill 2\" (-5 energy)\n");
            }


            //SKill 3
            if (Player.Progress >= 3)
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
                        if (Player.inventory.Contains("Healing potion"))
                        {


                            Player.Hp = Player.MaxHp;
                            Player.EnergyLevel = Player.MaxEnergyLevel;

                            Typewriter_Method.SlowType($"\n\n{Player.Name}'s Hp and Energy is fully restored\n\t{Player.Name} Hp: {Player.Hp} Energy Level: {Player.EnergyLevel}\n");
                            Player.inventory.Remove("Healing potion");
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
                        if (Player.inventory.Contains("Redbull"))
                        {


                            Player.Shield = Player.MaxShield;
                            Typewriter_Method.SlowType($"\n{Player.Name} cracks a ice cold redbull...{Player.Name} gets wings\n");

                            Typewriter_Method.SlowType($"\n\n{Player.Name}'s Shield is fully restored\n\t{Player.Name} Shield: {Player.Shield}\n");
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
                        Typewriter_Method.SlowType($"\n\n{Player.Name} prepares to parry {enemy.Name}'s attack\n");
                        Player.EnergyLevel++;
                        Typewriter_Method.SlowType($"{Player.Name} gains +1 Energy\n{Player.Name}'s Energy level is now {Player.EnergyLevel}\n\n");
                        Introduction.Continue = true;
                        Typewriter_Method.SlowType("\n---------------------------\n", 90);
                        break;

                    case "4":
                        PlayerSkills.RegulareAttack();
                        enemy.Hp -= Player.RegulareDamage;
                        Introduction.Continue = true;
                        break;

                    case "5":
                        if (Player.EnergyLevel >= 3)
                        {
                            PlayerSkills.Skill1();
                            enemy.Hp -= PlayerSkills.skill1Damage;
                            Player.EnergyLevel -= 3;
                            Introduction.Continue = true;
                        }

                        else
                        {
                            Typewriter_Method.SlowType("*Not enough Energy*\nChoose another action:\n");
                            Typewriter_Method.SlowType("\n---------------------------\n", 90);

                        }
                        break;

                    case "6":
                        if ((Player.Progress >= 2) && (Player.EnergyLevel >= 5))
                        {
                            PlayerSkills.Skill2();
                            enemy.Hp -= PlayerSkills.skill2Damage;
                            Player.EnergyLevel -= 5;
                            Introduction.Continue = true;
                        }
                        else if (Player.Progress < 2)
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
                        if ((Player.Progress >= 3) && (Player.EnergyLevel >= 7))
                        {
                            PlayerSkills.Skill3();
                            enemy.Hp -= PlayerSkills.skill3Damage;
                            Player.EnergyLevel -= 7;
                            Introduction.Continue = true;
                        }
                        else if (Player.Progress < 3)
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
            if ((Fight.win == false)&&(Player.Hp <= 0))
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
