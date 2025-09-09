using FireFighter_1;
using FireFIghter_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireFighter_1
{
    public class Fight(Player user, Enemy enemy)
    {
        public int regulareAttack;
        public int unknown;
        public static bool win = false;




        public static void EnemyFight(Enemy enemy, Player user)
        {
            Start_Create.Continue = false;
            Console.WriteLine($"You ran into a {enemy.Name}");
            Console.WriteLine("Choose your action");
            Console.WriteLine("1. Fight");
            Console.WriteLine("2. Flee");

            string userChoice = "";
            while (Start_Create.Continue == false)
            {
                userChoice = Console.ReadLine()!;
                if (userChoice == "1")
                {
                    Console.WriteLine("\n---------------------------\n");

                    Console.WriteLine($"You are now fighting {enemy.Name}");
                    Console.WriteLine($"{enemy.Name} Hp: {enemy.Hp}/{enemy.MaxHp}");
                    Console.WriteLine($"{enemy.Name} Energylevel: {enemy.EnergyLevel}/{enemy.MaxEnergyLevel}");

                    Console.WriteLine("\n---------------------------\n");
                    while ((Player.Hp > 0) && (enemy.Hp > 0))
                    {

                        PlayerTurn.FightPlayerTurn(userChoice, user, enemy);
                        EnemyTurn.FightEnemyturn(userChoice, user, enemy);

                       

                        
                        
                       
                        if ((enemy.Hp <= 0) && (Player.Hp > 0))
                        {
                            Console.WriteLine($"You won against {enemy.Name}");
                            Player.Gold += 3;
                            Console.WriteLine("Reward: +3 gold");
                            
                            win = true;
                        }
                        else if ((enemy.Hp > 0) && (Player.Hp <= 0))
                        {
                            win = false;
                        }
                    }
                    if (win == false)
                    {
                        Start_Create.EndGame = true;
                        Console.WriteLine("Game over!");
                        
                    }






                }
                else if (userChoice == "2")
                {
                    Console.WriteLine($"You successfully ran from {enemy.Name}");
                    Start_Create.Continue = true;
                }
                else
                {
                    Console.WriteLine($"{userChoice} ");
                }
            }
            
        }

        

        }

       


    }





