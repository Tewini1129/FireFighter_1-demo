using FireFighter_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace FireFIghter_1
{
    internal class Adventures

    {
        public static Random random = new Random();
        public static int randomNumber;
        //First Adventure
        public static void BurningBuilding(Player user, Enemy enemy)
        {
            Start_Create.Continue = false;
            

            string[] enemies = { "Infernal", "Demon", "Whiteclad" };
            
            Console.WriteLine("\n---------------------------\n\n");

            Console.WriteLine("\nCaptain tells you, you need to do a trial before becoming official firefighter");
            Console.WriteLine("Try out your skills and fight until you find the boss of this camp, beat him if you can");
            Console.WriteLine("\n\nPress enter any key to continue");
            while (Start_Create.Continue == false)
            {
                Console.ReadKey();

                
                

                do
                {
                        randomNumber = random.Next(0, 3);
                        Enemy enemy = new Enemy(user, randomNumber);
                        
                            
                            Console.WriteLine("\n---------------------------\n\n");

                           
                            Fight.EnemyFight(enemy, user);
                        
                        
                        
                } while (randomNumber != 2);
                
            }

        }




        //Second Adventure
        public static void Research(Player user, Enemy enemy)
        {
            Start_Create.Continue = false;

            string[] enemies = { "Infernal", "Demon", "Whiteclad" };
            randomNumber = random.Next(0, 3);
            Console.WriteLine("\n---------------------------\n\n");

            Console.WriteLine("\nThe captain gets has gotten suspicious of the big tech company called Haijima industries providing all your tools.");
            Console.WriteLine("He sends you and member of your station to find a genius engineer that would eliminate the need for Haijimas tools");
            Console.WriteLine("You enter a garbage yard where you meet a man, as you try to talk him into joining you, the White clad attacks once more");
            Console.WriteLine("Find the White clad member and kill him.");
            Console.WriteLine("\n\nPress enter \"Enter\" to continue");
            while (Start_Create.Continue == false)
            {
                string? userChoice = Console.ReadLine();

                if (userChoice == "")
                {

                    do
                    {
                        if (enemies[randomNumber] == "Infernal")
                        {
                            Console.WriteLine("\n---------------------------\n\n");

                            Console.WriteLine("\nYou found a infernal");
                            Fight.EnemyFight(enemy, user);
                        }
                        else if (enemies[randomNumber] == "Demon")
                        {
                            Console.WriteLine("\nYou found a demon");
                            Fight.EnemyFight(enemy, user);
                        }
                        else
                        {
                            Console.WriteLine("\nYou found a white Clad member!");
                            Fight.EnemyFight(enemy, user);
                            Console.WriteLine("\nThe member managed to get away but not without our tracker on him");
                            Console.WriteLine("You find out the tracker places him in the nether, a closed of underground world");
                        }
                        Start_Create.Continue = true;
                    } while (enemies[randomNumber] == "Whiteclad");
                }
                else
                {
                    Console.WriteLine("Error");
                }

            }

        }




        //Third Adventure
        public static void TheNether(Player user, Enemy enemy)
        {
            Start_Create.Continue = false;

            string[] enemies = { "Infernal", "Demon", "Whiteclad" };
            randomNumber = random.Next(0, 3);
            Console.WriteLine("\n---------------------------\n\n");

            Console.WriteLine("\nou and the team enter the underground nether and find the mysterious lab");
            Console.WriteLine("Find the WHite clad member to get a clue");
            Console.WriteLine("\n\nPress enter \"Enter\" to continue");
            while (Start_Create.Continue == false)
            {
                string? userChoice = Console.ReadLine();

                if (userChoice == "")
                {

                    do
                    {
                        if (enemies[randomNumber] == "Infernal")
                        {
                            Console.WriteLine("\n---------------------------\n\n");

                            Console.WriteLine("\nYou found a infernal");
                            Fight.EnemyFight(enemy, user);
                        }
                        else if (enemies[randomNumber] == "Demon")
                        {
                            Console.WriteLine("\nYou found a demon");
                            Fight.EnemyFight(enemy, user);
                        }
                        else
                        {
                            Console.WriteLine("\nYou found a white Clad member");
                            Fight.EnemyFight(enemy, user);
                            if (Fight.win == true)
                            {
                                Console.WriteLine("\nYou escape before the White clads self destruct sequens explode");
                                Console.WriteLine("In the lab you foundout that lab created insects are what creates infernals and demons");
                                Console.WriteLine("No one believes you since it sounds crazy, and all the evidence got incinerated int the explosion. \nbut the White clad cant let anybody know...");
                            }
                            Start_Create.Continue = true;

                        }
                    } while (enemies[randomNumber] == "Whiteclad");
                }
                else
                {
                    Console.WriteLine("Error");
                }
            }

        }



        //Fourth and Final Adventure
        public static void WhiteCladAttack(Player user, Enemy enemy)
        {
            Start_Create.Continue = false;
            

            string[] enemies = { "Infernal", "Demon", "Whiteclad" };
            randomNumber = random.Next(0, 3);
            Console.WriteLine("\n---------------------------\n\n");

            Console.WriteLine("A member of the Group known as Whiteclad attack your fire station with their helpers trying to kill you ");
            Console.WriteLine("Find and kill him in order to get the final clue");
            Console.WriteLine("\n\nPress enter \"Enter\" to continue");

            while (Start_Create.Continue == false)
            {
                string? userChoice = Console.ReadLine();
                

                if (userChoice == "")
                {
                    do
                    {
                        if (enemies[randomNumber] == "Infernal")
                        {
                            Console.WriteLine("\n---------------------------\n\n");
                            Console.WriteLine("\nYou found a infernal");
                            Fight.EnemyFight(enemy, user);
                        }
                        else if (enemies[randomNumber] == "Demon")
                        {
                            Console.WriteLine("\nYou found a demon");
                            Fight.EnemyFight(enemy, user);
                        }
                        else
                        {
                            Console.WriteLine("\nYou found a white Clad member");
                            Fight.EnemyFight(enemy, user);
                        }

                        if (Fight.win == true)
                        {
                            Console.WriteLine("You found and killed him. His dying breath told you the adola bursts have finally gathered");
                            EndScreen.End();

                        }
                        Start_Create.Continue = true;

                    } while (enemies[randomNumber] != "Whiteclad");
                }
                else
                {
                    Console.WriteLine("Error");
                }

            }

        }
    }
}
