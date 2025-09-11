using FireFighter_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireFIghter_1.Menu_s
{
    internal class AdventureMethod
    {
        //Go on adventure method
        public static void Adventure(Player user, Enemy enemy)
        {


            Introduction.Continue = false;
            while (Introduction.Continue == false)
            {
                string? userChoice = "";
                Adventures.AdventureMenu();

                if ((userChoice != "1") || (userChoice != "2") || (userChoice != "3") || (userChoice != "4"))
                {
                    Introduction.Continue = true;

                    userChoice = Console.ReadLine();

                    switch (userChoice)
                    {
                        case "1":
                            if (Player.Progress >= 1)
                            {
                                Adventures.TrialBurningBuilding(user, enemy);
                                
                            }
                            else
                            {
                                Typewriter_Method.SlowType("\n\nYour level is to low to enter the Burning Building...\n");
                                Typewriter_Method.SlowType("Press any key to continue and try a different adventure\n");
                                Console.ReadKey();
                                Adventure(user, enemy);
                                
                                


                            }
                            break;

                        case "2":
                            if (Player.Progress >= 2)
                            {
                                Adventures.Research(user, enemy);
                                if (Fight.win == true)
                                {
                                    Typewriter_Method.SlowType("You leveled up");
                                    Player.Progress++;
                                    Player.Hp = Player.Hp * Player.Progress;
                                    Player.MaxHp = Player.MaxHp * Player.Progress;
                                    Player.EnergyLevel += Player.Progress;
                                    Player.MaxEnergyLevel += Player.Progress;
                                    Player.RegulareDamage = Player.RegulareDamage * Player.Progress;
                                    Typewriter_Method.SlowType("\n---------------------------\n", 120);

                                    MenuOptions.Menu(user, enemy);
                                }
                            }
                            else
                            {
                                Typewriter_Method.SlowType("\n\nYour level is to low to enter the Training camp...\n");
                                Typewriter_Method.SlowType("Press any key to continue and try a different adventure\n");
                                Console.ReadKey();
                                Adventure(user, enemy);



                            }
                            break;

                        case "3":
                            if (Player.Progress >= 3)
                            {
                                Adventures.TheNether(user, enemy);
                                if (Fight.win == true)
                                {
                                    Typewriter_Method.SlowType("You leveled up");
                                    Player.Progress++;
                                    Player.Hp = Player.Hp * Player.Progress;
                                    Player.MaxHp = Player.MaxHp * Player.Progress;
                                    Player.EnergyLevel += Player.Progress;
                                    Player.MaxEnergyLevel += Player.Progress;
                                    Player.RegulareDamage = Player.RegulareDamage * Player.Progress;
                                    Typewriter_Method.SlowType("\n---------------------------\n", 120);

                                    MenuOptions.Menu(user, enemy);
                                }
                            }
                            else
                            {
                                Typewriter_Method.SlowType("\n\nYour level is to low to enter the Training camp...\n");
                                Typewriter_Method.SlowType("Press any key to continue and try a different adventure\n");
                                Console.ReadKey();
                                Adventure(user, enemy);
                            }

                            break;

                        case "4":
                            if (Player.Progress >= 4)
                            {
                                Adventures.WhiteCladAttack(user, enemy);
                                if (Fight.win == true)
                                {
                                    Typewriter_Method.SlowType("You leveled up");
                                    Player.Progress++;
                                    Player.Hp = Player.Hp * Player.Progress;
                                    Player.MaxHp = Player.MaxHp * Player.Progress;
                                    Player.EnergyLevel += Player.Progress;
                                    Player.MaxEnergyLevel += Player.Progress;
                                    Player.RegulareDamage = Player.RegulareDamage * Player.Progress;
                                    Typewriter_Method.SlowType("\n---------------------------\n", 120);

                                    Console.WriteLine("Congratulations, you beat the game!");
                                }
                            }
                            else
                            {
                                Typewriter_Method.SlowType("\n\nYour level is to low to enter the Training camp...\n");
                                Typewriter_Method.SlowType("Press any key to continue and try a different adventure\n");
                                Console.ReadKey();
                                Adventure(user, enemy);
                            }
                            break;

                        default:
                            Typewriter_Method.SlowType($"\n{userChoice} is not a valid option\n");
                            Typewriter_Method.SlowType("Press any key to continue and try a different adventure\n");
                            Console.ReadKey();
                            Introduction.Continue = false;
                            break;

                    }
                }
                else
                {
                    Typewriter_Method.SlowType($"\n{userChoice} is not a option\n");
                    Typewriter_Method.SlowType("Press any key to continue and try a different adventure\n");
                    Console.ReadKey();
                    Introduction.Continue = false;

                }
            }
        }
    }
}
