using FireFighter_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static FireFighter_1.Enemy;

namespace FireFIghter_1
{
    internal class comments
    {
        //public static void DemonFight(Demon demon, Player user)
        //{

        //    Start_Create.Continue = false;
        //    Console.WriteLine($"You ran into a {demon.Name}");
        //    Console.WriteLine("Choose your action");
        //    Console.WriteLine("1. Fight");
        //    Console.WriteLine("2. Flee");

        //    string userChoice = "";
        //    while (Start_Create.Continue == false)
        //    {
        //        userChoice = Console.ReadLine()!;
        //        if (userChoice == "1")
        //        {
        //            Console.WriteLine("\n---------------------------\n");

        //            Console.WriteLine($"You are now fighting {demon.Name}");
        //            Console.WriteLine($"Demon Hp: {demon.Hp}/{demon.MaxHp}");
        //            Console.WriteLine($"Demon Energylevel: {demon.EnergyLevel}/{demon.MaxEnergyLevel}");

        //            Console.WriteLine("\n---------------------------\n");
        //            while ((Player.Hp > 0) && (demon.Hp > 0))
        //            {
        //                //Player turn
        //                Console.WriteLine($"\t{Player.Name} current stats\n\t\tHp: {Player.Hp}/{Player.MaxHp}");
        //                Console.WriteLine($"\t\tEnergy: {Player.EnergyLevel}/{Player.MaxEnergyLevel}");
        //                Console.WriteLine($"\n\n\t{demon.Name} current stats\n \t\tHp: {demon.Hp}/{demon.MaxHp}");
        //                Console.WriteLine($"\t\tEnergy: {demon.EnergyLevel}/{demon.MaxEnergyLevel}");
        //                Console.WriteLine("\tChose your next actions");
        //                Console.WriteLine("\t1.Use \"Heal\"");
        //                Console.WriteLine("\t2.Use \"Redbull\"");
        //                Console.WriteLine("\t3.Use \"Parry to gain Energy\"");
        //                Console.WriteLine("\t4.Use \"Regular Attack\"");

        //                //Skill 1
        //                if (Player.Progress != 0)
        //                {
        //                    Console.WriteLine("\t5.Use \"Skill 1\" (-3 energy)");
        //                }


        //                //Skill 2
        //                if (Player.Progress >= 2)
        //                {
        //                    Console.WriteLine("\t6.Use \"Skill 2\" (-5 energy)");
        //                }


        //                //SKill 3
        //                if (Player.Progress >= 3)
        //                {
        //                    Console.WriteLine("\t7.Use \"Skill 3\" (-7 energy)");
        //                }





        //                while (Start_Create.Continue == false)
        //                {
        //                    userChoice = Console.ReadLine()!;
        //                    Console.WriteLine("\n---------------------------\n\n");

        //                    switch (userChoice)
        //                    {

        //                        case "1":
        //                            if (Player.inventory.Contains("Healing potion"))
        //                            {


        //                                Player.Hp = Player.MaxHp;
        //                                Console.WriteLine($"\n\n{Player.Name}'s Hp is fully restored\n\t{Player.Name} Hp: {Player.Hp}");
        //                                Start_Create.Continue = true;
        //                            }
        //                            else
        //                            {
        //                                Console.WriteLine("\n\nYou are out of Healing potions...\n");
        //                            }
        //                            break;

        //                        case "2":
        //                            if (Player.inventory.Contains("Redbull"))
        //                            {


        //                                Player.EnergyLevel = Player.MaxEnergyLevel;
        //                                Console.WriteLine($"\n\n{Player.Name}'s Energy is fully restored\n\t{Player.Name} Energy Level: {Player.EnergyLevel}");
        //                                Start_Create.Continue = true;
        //                            }
        //                            else
        //                            {
        //                                Console.WriteLine("\n\nYou are out of Redbull...\n");
        //                            }

        //                            break;

        //                        case "3":

        //                            if (demon.EnergyLevel != demon.MaxEnergyLevel)
        //                            {
        //                                Console.WriteLine($"\n\n{Player.Name} prepares to parry the {demon.Name}");
        //                                Console.WriteLine($"{Player.Name} gains +1 Energy\n {Player.Name}'s Energy level is now {Player.EnergyLevel}");
        //                                Player.Hp = demon.Damage / 2;
        //                            }
        //                            else
        //                            {
        //                                Console.WriteLine($"\n{Player.Name} prepares to parry the {demon.Name}");
        //                                Console.WriteLine($"{Player.Name} gains +1 Energy\n {Player.Name}'s Energy level is now {Player.EnergyLevel}");

        //                            }
        //                            Start_Create.Continue = true;
        //                            break;

        //                        case "4":
        //                            Skills.RegulareAttack();
        //                            demon.Hp -= Player.RegulareDamage;
        //                            Console.WriteLine($"{Player.Name} has ");
        //                            Start_Create.Continue = true;
        //                            break;

        //                        case "5":
        //                            if (Player.EnergyLevel >= 3)
        //                            {
        //                                Skills.Skill1();
        //                                demon.Hp -= Skills.skill1Damage;
        //                                Start_Create.Continue = true;
        //                            }

        //                            else
        //                            {
        //                                Console.WriteLine("Not enough Energy*");
        //                            }
        //                            break;

        //                        case "6":
        //                            if ((Player.Progress >= 2) && (Player.EnergyLevel >= 5))
        //                            {
        //                                Skills.Skill2();
        //                                demon.Hp -= Skills.skill2Damage;
        //                                Start_Create.Continue = true;
        //                            }
        //                            else if (Player.Progress < 2)
        //                            {
        //                                Console.WriteLine("*Level to low*");
        //                            }
        //                            else
        //                            {
        //                                Console.WriteLine("Not enough Energy*");
        //                            }
        //                            break;

        //                        case "7":
        //                            if ((Player.Progress >= 3) && (Player.EnergyLevel >= 7))
        //                            {
        //                                Skills.Skill3();
        //                                demon.Hp -= Skills.skill3Damage;
        //                                Start_Create.Continue = true;
        //                            }
        //                            else if (Player.Progress < 3)
        //                            {
        //                                Console.WriteLine("*Level to low*");
        //                            }
        //                            else
        //                            {
        //                                Console.WriteLine("Not enough Energy*");
        //                            }
        //                            break;

        //                        default:
        //                            Console.WriteLine($"{userChoice} is not a valid option, try Something else");
        //                            break;
        //                    }

        //                }
        //                Start_Create.Continue = false;
        //                //Demon attack
        //                if (demon.Hp >= 0)
        //                {
        //                    if (demon.EnergyLevel == demon.MaxEnergyLevel)
        //                    {
        //                        if (userChoice != "2")
        //                        {
        //                            Console.WriteLine($"{demon.Name} uses his charged up energy to make the ground below you explode causing a detremental {demon.Damage} damage");
        //                            Console.WriteLine("");
        //                            Player.Hp -= demon.ultimate;
        //                            demon.EnergyLevel = 0;
        //                        }
        //                        else
        //                        {
        //                            Console.WriteLine($"{demon.Name} uses his charged up energy to make the ground below you explode causing a detremental {demon.Damage} damage");

        //                            Console.WriteLine($"{Player.Name} tries to parry {demon.Name} ultimate but still takes {demon.Damage} damage ");
        //                            Player.Hp -= demon.Damage;
        //                            demon.EnergyLevel++;
        //                        }
        //                    }
        //                    else
        //                    {
        //                        if (userChoice != "2")
        //                        {
        //                            Console.WriteLine($"{demon.Name} takes out a MP5 and shoot you, you manage to almost dodge but it hits your foot ");
        //                            Console.WriteLine($"{Player.Name} takes {demon.Damage} damage");
        //                            Player.Hp -= demon.Damage;
        //                            demon.EnergyLevel++;
        //                        }
        //                        else
        //                        {
        //                            Player.Hp -= 100;
        //                            demon.EnergyLevel++;
        //                        }
        //                    }
        //                }
        //                if ((demon.Hp <= 0) && (Player.Hp > 0))
        //                {
        //                    Player.Gold += 5;
        //                    Console.WriteLine("Reward: +5 Gold");

        //                    win = true;
        //                }
        //                else if ((demon.Hp > 0) && (Player.Hp <= 0))
        //                {
        //                    win = false;
        //                }
        //            }
        //            if (win == false)
        //            {
        //                Console.WriteLine("Game over!");
        //                EndScreen.End();
        //            }






        //        }
        //        else if (userChoice == "2")
        //        {
        //            Console.WriteLine($"You successfully ran from {demon.Name}");
        //            Start_Create.Continue = true;
        //        }
        //        else
        //        {
        //            Console.WriteLine($"{userChoice} ");
        //        }
        //    }

        //}

        //public static void WhiteCladFight(WhiteClad whiteClad, Player user)
        //{

        //    Start_Create.Continue = false;
        //    Console.WriteLine("\n---------------------------\n\n");

        //    Console.WriteLine($"You ran into a {whiteClad.Name}");
        //    Console.WriteLine("Choose your action");
        //    Console.WriteLine("1. Fight");
        //    Console.WriteLine("2. Flee");

        //    string userChoice = "";
        //    while (Start_Create.Continue == false)
        //    {
        //        userChoice = Console.ReadLine()!;
        //        if (userChoice == "1")
        //        {
        //            Console.WriteLine("\n---------------------------\n");

        //            Console.WriteLine($"You are now fighting {whiteClad.Name}");
        //            Console.WriteLine($"Whiteclad Hp: {whiteClad.Hp}/{whiteClad.MaxHp}");
        //            Console.WriteLine($"Whiteclad Energylevel: {whiteClad.EnergyLevel}/{whiteClad.MaxEnergyLevel}");

        //            Console.WriteLine("\n---------------------------\n");
        //            while ((Player.Hp != 0) || (whiteClad.Hp != 0))
        //            {
        //                //Player turn
        //                Console.WriteLine($"\t{Player.Name} current stats\n\t\t{Player.Hp}/{Player.MaxHp}");
        //                Console.WriteLine($"\t\t{Player.EnergyLevel}/{Player.MaxEnergyLevel}");
        //                Console.WriteLine($"\n\n\t{whiteClad.Name} current stats\n\t\t{whiteClad.Hp}/{whiteClad.MaxHp}");
        //                Console.WriteLine($"\t\t{whiteClad.EnergyLevel}/{whiteClad.MaxEnergyLevel}");
        //                Console.WriteLine("\tChose your next actions");
        //                Console.WriteLine("\t1.Use \"Heal\"");
        //                Console.WriteLine("\t2.Use \"Redbull\"");
        //                Console.WriteLine("\t3.Use \"Parry to gain Energy\"");
        //                Console.WriteLine("\t4.Use \"Regular Attack\"");

        //                //Skill 1
        //                if (Player.Progress != 0)
        //                {
        //                    Console.WriteLine("\t5.Use \"Skill 1\" (-3 energy)");
        //                }


        //                //Skill 2
        //                if (Player.Progress >= 2)
        //                {
        //                    Console.WriteLine("\t6.Use \"Skill 2\" (-5 energy)");
        //                }


        //                //SKill 3
        //                if (Player.Progress >= 3)
        //                {
        //                    Console.WriteLine("\t7.Use \"Skill 3\" (-7 energy)");
        //                }




        //                while (Start_Create.Continue == false)
        //                {
        //                    userChoice = Console.ReadLine()!;
        //                    Console.WriteLine("\n---------------------------\n\n");


        //                    switch (userChoice)
        //                    {
        //                        case "1":
        //                            if (Player.inventory.Contains("Healing potion"))
        //                            {


        //                                Player.Hp = Player.MaxHp;
        //                                Console.WriteLine($"\n\n{Player.Name}'s Hp is fully restored\n\t{Player.Name} Hp: {Player.Hp}");
        //                                Start_Create.Continue = true;
        //                            }
        //                            else
        //                            {
        //                                Console.WriteLine("\n\nYou are out of Healing potions...\n");
        //                            }
        //                            break;

        //                        case "2":
        //                            if (Player.inventory.Contains("Redbull"))
        //                            {


        //                                Player.EnergyLevel = Player.MaxEnergyLevel;
        //                                Console.WriteLine($"\n\n{Player.Name}'s Energy is fully restored\n\t{Player.Name} Energy Level: {Player.EnergyLevel}");
        //                                Start_Create.Continue = true;
        //                            }
        //                            else
        //                            {
        //                                Console.WriteLine("\n\nYou are out of Redbull...\n");
        //                            }

        //                            break;

        //                        case "3":

        //                            if (whiteClad.EnergyLevel != whiteClad.MaxEnergyLevel)
        //                            {
        //                                Console.WriteLine($"\n\n{Player.Name} prepares to parry the {whiteClad.Name}");
        //                                Console.WriteLine($"{Player.Name} gains +1 Energy\n {Player.Name}'s Energy level is now {Player.EnergyLevel}");
        //                                Player.Hp = whiteClad.Damage / 2;
        //                            }
        //                            else
        //                            {
        //                                Console.WriteLine($"\n{Player.Name} prepares to parry the {whiteClad.Name}");
        //                                Console.WriteLine($"{Player.Name} gains +1 Energy\n {Player.Name}'s Energy level is now {Player.EnergyLevel}");

        //                            }
        //                            Start_Create.Continue = true;
        //                            break;

        //                        case "4":
        //                            Skills.RegulareAttack();
        //                            whiteClad.Hp -= Player.RegulareDamage;
        //                            Console.WriteLine($"{Player.Name} has ");
        //                            Start_Create.Continue = true;
        //                            break;

        //                        case "5":
        //                            Skills.Skill1();
        //                            whiteClad.Hp -= Skills.skill1Damage;
        //                            Start_Create.Continue = true;
        //                            break;

        //                        case "6":
        //                            if ((Player.Progress >= 2) && (Player.EnergyLevel >= 4))
        //                            {
        //                                Skills.Skill2();
        //                                whiteClad.Hp -= Skills.skill2Damage;
        //                                Start_Create.Continue = true;
        //                            }
        //                            else if (Player.Progress < 3)
        //                            {
        //                                Console.WriteLine("*Level to low*");
        //                            }
        //                            else
        //                            {
        //                                Console.WriteLine("Not enough Energy*");
        //                            }
        //                            break;

        //                        case "7":
        //                            if ((Player.Progress >= 3) && (Player.EnergyLevel >= 7))
        //                            {
        //                                Skills.Skill3();
        //                                whiteClad.Hp -= Skills.skill3Damage;
        //                                Start_Create.Continue = true;
        //                            }
        //                            else if (Player.Progress < 3)
        //                            {
        //                                Console.WriteLine("*Level to low*");
        //                            }
        //                            else
        //                            {
        //                                Console.WriteLine("Not enough Energy*");
        //                            }
        //                            break;

        //                        default:
        //                            Console.WriteLine($"{userChoice} is not a valid option, try Something else");
        //                            break;
        //                    }

        //                }
        //                Start_Create.Continue = false;
        //                //WhiteClad attack
        //                if (whiteClad.Hp >= 0)
        //                {
        //                    if (whiteClad.EnergyLevel == whiteClad.MaxEnergyLevel)
        //                    {
        //                        if (userChoice != "2")
        //                        {
        //                            Console.WriteLine($"{whiteClad.Name} uses his charged up energy to make the ground below you explode causing a detremental {whiteClad.Damage} damage");
        //                            Console.WriteLine("");
        //                            Player.Hp -= whiteClad.ultimate;
        //                            whiteClad.EnergyLevel = 0;
        //                        }
        //                        else
        //                        {
        //                            Console.WriteLine($"{whiteClad.Name} uses his charged up energy to make the ground below you explode causing a detremental {whiteClad.Damage} damage");

        //                            Console.WriteLine($"{Player.Name} tries to parry {whiteClad.Name} ultimate but still takes {whiteClad.Damage} damage ");
        //                            Player.Hp -= whiteClad.Damage;
        //                            whiteClad.EnergyLevel++;
        //                        }
        //                    }
        //                    else
        //                    {
        //                        if (userChoice != "2")
        //                        {
        //                            Console.WriteLine($"{whiteClad.Name} hits you in your gut with fiery first");
        //                            Console.WriteLine($"{Player.Name} takes {whiteClad.Damage}");
        //                            Player.Hp -= whiteClad.Damage;
        //                            whiteClad.EnergyLevel++;
        //                        }
        //                        else
        //                        {
        //                            Player.Hp -= 200;
        //                            whiteClad.EnergyLevel++;
        //                        }
        //                    }
        //                }
        //                if ((whiteClad.Hp <= 0) && (Player.Hp > 0))
        //                {
        //                    Player.Gold += 7;
        //                    Player.Progress += 1;
        //                    Console.WriteLine("Reward: +7 Gold & 1 Clue");

        //                    win = true;
        //                }
        //                else if ((whiteClad.Hp > 0) && (Player.Hp <= 0))
        //                {
        //                    win = false;
        //                }

        //            }
        //            if (win == false)
        //            {
        //                Console.WriteLine("Game over!");
        //                EndScreen.End();
        //            }






        //        }
        //        else if (userChoice == "2")
        //        {
        //            Console.WriteLine($"You successfully ran from {whiteClad.Name}");
        //            Start_Create.Continue = true;
        //        }
        //        else
        //        {
        //            Console.WriteLine($"{userChoice} ");
        //        }
        //    }
        //}
    }
}
