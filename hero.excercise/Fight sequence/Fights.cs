using FireFighter_1;
using FireFIghter_1;
using FireFIghter_1.Menu_s;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireFighter_1
{
    public class Fight
    {
        //public int user.regulareAttack;
        public int unknown;
        public static bool win = false;
        public static string userChoice = "";



        public static void EnemyFight(Enemy enemy1, Player user)
        {
            
            Introduction.Continue = false;
            while (Introduction.Continue == false)
            {
                Console.Clear();
                
                Typewriter_Method.SlowType($"You ran into a {enemy1.Name}\n");
                Typewriter_Method.SlowType("Choose your action\n");
                Typewriter_Method.SlowType("\tFight\n");
                string[] Options = { "Fight", "" };
                string Prompt = $"You ran into a {enemy1.Name}\nChoose your action";
                if ((enemy1.Name == $"White Clad Lv.{user.Progress}")||(enemy1.Name == "Boss:White Clad"))
                {
                    Typewriter_Method.SlowType("\tYou cannot flee from White clad\n");
                    Options[1] = "You cannot flee from White clad";

                }
                else
                {
                    Typewriter_Method.SlowType("\tFlee\n");
                    Options[1] = "Flee";
                }
                FunMenu FightOrFlight = new FunMenu(Prompt, Options);
                FightOrFlight.Run();


                if (FightOrFlight.SelectedIndex == 0)
                {
                    Console.WriteLine("\n---------------------------\n");

                    Typewriter_Method.SlowType($"You are now fighting {enemy1.Name}\n");
                    Typewriter_Method.SlowType($"{enemy1.Name} Hp: {enemy1.Hp}/{enemy1.MaxHp}\n");
                    Typewriter_Method.SlowType($"{enemy1.Name} Energy level: {enemy1.EnergyLevel}/{enemy1.MaxEnergyLevel}\n");

                    Typewriter_Method.SlowType("\n---------------------------\n", 60);

                    while ((user.Hp > 0) && (enemy1.Hp > 0))
                    {
                        win = false;
                        PlayerTurn.FightPlayerTurn(userChoice, user, enemy1);
                        EnemyTurn.FightEnemyturn(userChoice, user, enemy1);


                        if ((enemy1.Hp <= 0) && (user.Hp > 0))
                        {
                            Console.WriteLine("\n---------------------------\n\n");

                            Typewriter_Method.SlowType($"You won against {enemy1.Name}\n");
                            if ((enemy1.Name == $"White clad{user.Progress}") || (enemy1.Name == "Boss:White Clad"))
                            {


                                user.Gold += enemy1.Reward;
                                Typewriter_Method.SlowType($"Reward: +{enemy1.Reward} gold\n");
                                Typewriter_Method.SlowType("\n---------------------------\n", 90);



                                win = true;
                            }
                           
                              
                        }
                        else if ((enemy1.Hp > 0) && (user.Hp <= 0))
                        {
                            win = false;
                        }
                    }
                    if (win == false)
                    {
                        Console.WriteLine("\n---------------------------\n\n");

                        Introduction.EndGame = true;
                        Typewriter_Method.SlowType("Game over!\n");
                        
                    }
                }
                else if (FightOrFlight.SelectedIndex == 1)
                {
                    if((enemy1.Name == $"White clad{user.Progress}")|| (enemy1.Name == "Boss:White Clad"))
                    {
                        Typewriter_Method.SlowType("As you turn around to try and flee, the White clad sends a barrage of missiles in your back killing you instantly\n");
                        Introduction.EndGame = true;
                        Introduction.Continue = true;
                        Typewriter_Method.SlowType("\n---------------------------\n", 100);

                    }
                    else
                    {
                        Console.WriteLine("\n---------------------------\n\n");

                        Typewriter_Method.SlowType($"You successfully ran from {enemy1.Name}\n");
                        Introduction.Continue = true;
                        Typewriter_Method.SlowType("\n---------------------------\n", 60);

                    }
                }
                else
                {
                    Typewriter_Method.SlowType($"{userChoice} is not a valid option \n");
                }
            }
        }
    }
}





