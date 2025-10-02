using FireFighter_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireFighter_1.Menu_s
{
    internal class AdventureMethod
    {
        //Go on adventure method
        public static void Adventure(Player user, Enemy enemy)
        {
            Adventures.AdventureMenu();

            string Prompt = "---------------------------\n\n\nChoose your adventure:\n\n\n";
            string[] AdventureOptions = { "\tBurning building (Level 1 required)", "\tResearch (Level 2 required)", "\tThe Nether (Level 3 required)", "\tThe White clad attack (Level 4 required)" };
            FunMenu AdventuresChoice = new FunMenu(Prompt,AdventureOptions);
            AdventuresChoice.Run();


                    switch (AdventuresChoice.SelectedIndex)
                    {
                        case 0:
                            if (user.Progress >= 1)
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

                        case 1:
                            if (user.Progress >= 2)
                            {
                                Adventures.Research(user, enemy);
                                
                            }
                            else
                            {
                                Typewriter_Method.SlowType("\n\nYour level is to low to enter the Training camp...\n");
                                Typewriter_Method.SlowType("Press any key to continue and try a different adventure\n");
                                Console.ReadKey();
                                Adventure(user, enemy);



                            }
                            break;

                        case 2:
                            if (user.Progress >= 3)
                            {
                                Adventures.TheNether(user, enemy);
                                
                                
                            }
                            else
                            {
                                Typewriter_Method.SlowType("\n\nYour level is to low to enter the Training camp...\n");
                                Typewriter_Method.SlowType("Press any key to continue and try a different adventure\n");
                                Console.ReadKey();
                                Adventure(user, enemy);
                            }

                            break;

                        case 3:
                            if (user.Progress >= 4)
                            {
                                Adventures.WhiteCladAttack(user, enemy);
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
                            Typewriter_Method.SlowType($"\n{AdventuresChoice.SelectedIndex} is not a valid option\n");
                            Typewriter_Method.SlowType("Press any key to continue and try a different adventure\n");
                            Console.ReadKey();
                            Introduction.Continue = false;
                            break;

                    }
                
            
        }
    }
}
