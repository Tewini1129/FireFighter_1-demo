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

        public static void AdventureMenu()
        {
            Console.Clear();
            Console.WriteLine("\n---------------------------\n\n");

            Typewriter_Method.SlowType("Choose your adventure:\n\n");
            Typewriter_Method.SlowType("\n\tBurning building (Level 1 required)\n");
            Typewriter_Method.SlowType("\tResearch (Level 2 required)\n");
            Typewriter_Method.SlowType("\tThe Nether (Level 3 required)\n");
            Typewriter_Method.SlowType("\tThe White clad attack (Level 4 required)\n");
        }

        //First Adventure

        public static void TrialBurningBuilding(Player user, Enemy enemy)
        {
            Introduction.Continue = false;
            

            string[] enemies = { "Infernal", "Demon", "Whiteclad" };
            Console.Clear();
            Console.WriteLine("\n---------------------------\n\n");

            Typewriter_Method.SlowType("\nCaptain - \"Before we fully accept you here at the eighth station, we need to test your abilities ourself's\"\n\n");
            Typewriter_Method.SlowType("The captain sends you over to do a trial run\nA large industrial building covered in fire with not just one infernal inside\n");
            Typewriter_Method.SlowType("Try out your skills and fight until you find the boss of this camp, beat him if you can");
            Typewriter_Method.SlowType("\n\nPress enter any key to continue");
            while (Introduction.Continue == false)
            {
                Console.ReadKey();

                
                

                do
                {

                     randomNumber = random.Next(0, 3);
                     Enemy enemy1 = new Enemy(user, randomNumber);
                        
                     
                     Console.WriteLine("\n---------------------------\n\n"); 
                     Fight.EnemyFight(enemy1, user);
                        
                        
                        
                } while (randomNumber != 2);
                if ((Fight.win == true)&&(user.Progress <2))
                {
                    Typewriter_Method.SlowType("You leveled up");
                    user.Progress++;
                    user.Hp = user.Hp * user.Progress;
                    user.MaxHp = user.MaxHp * user.Progress;
                    user.EnergyLevel += user.Progress;
                    user.MaxEnergyLevel += user.Progress;
                    user.RegulareDamage = user.RegulareDamage * user.Progress;
                    Typewriter_Method.SlowType("\n---------------------------\n", 120);

                    MenuOptions.Menu(user, enemy);
                }

            }

        }




        //Second Adventure
        //hoppar över fight när trycker på flee
        public static void Research(Player user, Enemy enemy)
        {
            Introduction.Continue = false;

            string[] enemies = { "Infernal", "Demon", "Whiteclad" };
            randomNumber = random.Next(0, 3);
            Console.WriteLine("\n---------------------------\n\n");

            Typewriter_Method.SlowType("\nCaptain - \"I have reason to be suspicious of the big tech company called Haijima industries providing all our tools.\"\n");
            Typewriter_Method.SlowType("Captain - \"That's why im sending you and your teammate to find a genius engineer that would eliminate the need for Haijimas tools\"\n");
            Typewriter_Method.SlowType("\nYou enter a garbage yard where you meet a man, as you try to talk him into joining you, the White clad attacks once more\n");
            Typewriter_Method.SlowType("Find the White clad member and kill him.\n");
            Typewriter_Method.SlowType("\n\nPress enter \"Enter\" to continue\n");
            
                Console.ReadKey();

                

                    do
                    {
                        randomNumber = random.Next(0, 3);
                        Enemy enemy1 = new Enemy(user, randomNumber);

                        Console.WriteLine("\n---------------------------\n\n");
                        Fight.EnemyFight(enemy1, user);

                    } while (randomNumber != 2);
                    if (Fight.win == true)
                    {
                        Typewriter_Method.SlowType("\nThe member managed to get away but not without our tracker on him\n");
                        Typewriter_Method.SlowType("You find out the tracker places him in the nether, a closed of underground world\n");
                        Introduction.Continue = true;
                        Typewriter_Method.SlowType("\n---------------------------\n", 120);

                        if ((Fight.win == true)&&(user.Progress < 2))
                        {
                    Typewriter_Method.SlowType("You leveled up");
                    user.Progress++;
                    user.Hp = user.Hp * user.Progress;
                    user.MaxHp = user.MaxHp * user.Progress;
                    user.EnergyLevel += user.Progress;
                    user.MaxEnergyLevel += user.Progress;
                    user.RegulareDamage = user.RegulareDamage * user.Progress;
                    user.MaxShield = user.MaxShield * user.Progress;
                    user.Shield = user.Shield * user.Progress;


                    Typewriter_Method.SlowType("\n---------------------------\n", 120);
                    Typewriter_Method.SlowType("\nThe member managed to get away but not without our tracker on him\n");

                    MenuOptions.Menu(user, enemy);
                        }
                        else if(Fight.win == true)
                        {
                    Typewriter_Method.SlowType("\nThe member managed to get away but not without our tracker on him\n");

                    MenuOptions.Menu(user, enemy);

                        }
                    }
                        Introduction.Continue = true;
                    
                

            

        }


        

        //Third Adventure
        public static void TheNether(Player user, Enemy enemy)
        {
            Introduction.Continue = false;

            string[] enemies = { "Infernal", "Demon", "Whiteclad" };
            randomNumber = random.Next(0, 3);
            Console.WriteLine("\n---------------------------\n\n");

            Typewriter_Method.SlowType("\nYou and the team enter the underground nether and find the mysterious lab\n");
            Typewriter_Method.SlowType("Find the White clad member to get a clue\n");
            Typewriter_Method.SlowType("\n\nPress any key to continue\n");
            while (Introduction.Continue == false)
            {
                Console.ReadKey();

                
                

                    do
                    {
                    
                        randomNumber = random.Next(0, 3);
                        Enemy enemy1 = new Enemy(user, randomNumber);

                        Console.WriteLine("\n---------------------------\n\n");
                        Fight.EnemyFight(enemy1, user);

                    if (Fight.win == true)
                    {


                        Typewriter_Method.SlowType("\nYou escape before the White clads self destruct sequence explode\n");
                        Typewriter_Method.SlowType("In the lab you found out that lab created insects are what creates infernal's and demons\n");
                        Typewriter_Method.SlowType("No one believes you since it sounds crazy, and all the evidence got incinerated int the explosion. \nbut the White clad cant let anybody know...\n");

                        Introduction.Continue = true;
                        Typewriter_Method.SlowType("\n---------------------------\n", 120);

                        if ((Fight.win == true) && (user.Progress < 3))
                        {
                            Typewriter_Method.SlowType("You leveled up");
                            user.Progress++;
                            user.Hp = user.Hp * user.Progress;
                            user.MaxHp = user.MaxHp * user.Progress;
                            user.EnergyLevel += user.Progress;
                            user.MaxEnergyLevel += user.Progress;
                            user.RegulareDamage = user.RegulareDamage * user.Progress;
                            Typewriter_Method.SlowType("\n---------------------------\n", 120);

                            MenuOptions.Menu(user, enemy);
                        }
                        else if (Fight.win == true)
                        {
                            MenuOptions.Menu(user, enemy);

                        }
                    }


                        Introduction.Continue = true;

                        
                    } while (enemies[randomNumber] != "Whiteclad");
                if (Fight.win == true)
                {
                    Typewriter_Method.SlowType("You leveled up");
                    user.Progress++;
                    user.Hp = user.Hp * user.Progress;
                    user.MaxHp = user.MaxHp * user.Progress;
                    user.EnergyLevel += user.Progress;
                    user.MaxEnergyLevel += user.Progress;
                    user.RegulareDamage = user.RegulareDamage * user.Progress;
                    Typewriter_Method.SlowType("\n---------------------------\n", 120);

                    MenuOptions.Menu(user, enemy);
                }

            }

        }



        //Fourth and Final Adventure
        public static void WhiteCladAttack(Player user, Enemy enemy)
        {
            Introduction.Continue = false;
            

            string[] enemies = { "Infernal", "Demon", "Whiteclad" };
            randomNumber = random.Next(0, 3);
            Console.WriteLine("\n---------------------------\n\n");

            Typewriter_Method.SlowType("A member of the White clad attack your fire station with their helpers trying to kill you \n");
            Typewriter_Method.SlowType("Find and kill him in order to get the final clue\n");
            Typewriter_Method.SlowType("\n\nPress enter \"Enter\" to continue\n");
           

            while (Introduction.Continue == false)
            {

                Console.ReadKey();



                do
                {
                        
                            Console.Clear();
                            Console.WriteLine("\n---------------------------\n\n");
                            Typewriter_Method.SlowType($"\nYou found a {enemy.Name}\n");
                            Fight.EnemyFight(enemy, user);
                        

                            if (Fight.win == true)
                            {
                                Console.Clear();
                                Typewriter_Method.SlowType("You found and killed him. His dying breath told you the 8 pillars have finally gathered\n");
                                Introduction.EndGame = true;
                                EndScreen.End(user);

                            }
                        Introduction.Continue = true;

                } while (randomNumber != 2);
                

            }

        }
    }
}
