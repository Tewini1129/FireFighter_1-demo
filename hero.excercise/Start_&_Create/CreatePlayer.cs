using FireFighter_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FireFIghter_1
{
    internal class CreatePlayer
    {
        public static void Create()
        {
            //Name - choosing name
            Typewriter_Method.SlowType("Captain - \"First off, we are gonna need a name!\"\nCaptain - \"Who are you?\"\n");
            while (Introduction.name == "")
            {

                Introduction.name = Console.ReadLine()!;
                if (Introduction.name == "")
                {
                    Console.WriteLine("You need to enter in a name before we continue\n");
                }
            }
            Console.Clear();
            Console.WriteLine("---------------------------");
            Player.Name = Introduction.name;
            Typewriter_Method.SlowType($"\nCaptain - \"{Introduction.name} huh, Feels familiar, i might have heard of you...\"\nCaptain - \"Anyways Nice to meet you {Introduction.name}!\"");




            //Power
            Typewriter_Method.SlowType($"\n\nCaptain - \"Now to the interesting part, what generation are you?\"");

            //Power - First generation - explanation
            Typewriter_Method.SlowType("\n\n\t1. First generation \n\t- More power! Blast fire from both your hands and feet");

            //Power - Second generation - explanation
            Typewriter_Method.SlowType("\n\n\t2. Second generation\n\t- Better control! Control a pre existing fire & manipulate a specific source of heat");

            //Power - Third generation - explanation
            Typewriter_Method.SlowType("\n\n\t3. Third generation\n\tWARNING!\n\t-Choose at risk. 40% chance of getting First generation. 40% chance of getting Second generation.\n");
            Typewriter_Method.SlowType("\t-BUT there is also a 20% chance of getting both\n");

            Typewriter_Method.SlowType("\nEnter your choice: \"1\",\"2\" or \"3\"\n");

            //Power - Choice
            Introduction.Continue = false;
            while (Introduction.Continue == false)
            {
                string powerClassInput = Console.ReadLine()!;
                Typewriter_Method.SlowType($"\nConfirm choice: Yes/No\n");
                Introduction.Confirm = Console.ReadLine()!;

                if ((powerClassInput == "1") || (powerClassInput == "2") || (powerClassInput == "3") || (powerClassInput == "4"))
                {

                    if (Introduction.Confirm.ToLower() == "yes")
                    {

                        if ((powerClassInput == "1") || (powerClassInput == "2") || (powerClassInput == "3"))
                        {
                            Console.WriteLine("---------------------------");


                            if (powerClassInput == "3")
                            {
                                Introduction.randomNumber = Introduction.randomGenerated.Next(1, 11);
                                if (Introduction.randomNumber <= 4)
                                {

                                    Introduction.powerClass = 1;
                                    Player.PowerClass = 1;
                                    Typewriter_Method.SlowType($"\n{Player.Name} got {Player.PowerClass}\n");
                                    Typewriter_Method.SlowType("First generation, great! we needed just that!\n");
                                    Typewriter_Method.SlowType("\n---------------------------\n", 60);
                                }
                                else if ((Introduction.randomNumber > 4) || (Introduction.randomNumber <= 8))
                                {
                                    Introduction.powerClass = 2;
                                    Player.PowerClass = 2;
                                    Typewriter_Method.SlowType($"\n{Introduction.name} got {Introduction.powerClass}\n");
                                    Typewriter_Method.SlowType("Second generation, that's perfect, very useful in the right hands!\n");
                                    Typewriter_Method.SlowType("\n---------------------------\n", 60);
                                }
                                else if (Introduction.randomNumber >= 9)
                                {
                                    Introduction.powerClass = 3;
                                    Player.PowerClass = 3;
                                    Typewriter_Method.SlowType($"\n{Player.Name} got {Player.PowerClass}\n");
                                    Typewriter_Method.SlowType("Oh wow, that's incredible, not many of those around!\n");
                                    Typewriter_Method.SlowType("\n---------------------------\n", 60);
                                }

                            }
                            else if (powerClassInput == "2")
                            {
                                Introduction.powerClass = 2;
                                Player.PowerClass = 2;
                                Typewriter_Method.SlowType($"\n{Player.Name} is now {Player.PowerClass}\n");
                                Typewriter_Method.SlowType("Second generation! That's perfect, very useful in the right hands!\n");
                                Typewriter_Method.SlowType("\n---------------------------\n", 60);

                            }
                            else if (powerClassInput == "1")
                            {
                                Introduction.powerClass = 1;
                                Player.PowerClass = 1;
                                Typewriter_Method.SlowType($"\n{Player.Name} is now {Player.PowerClass}\n");
                                Typewriter_Method.SlowType("First generation, great! We needed just that!\n");
                                Typewriter_Method.SlowType("\n---------------------------\n", 60);

                            }

                            //Your Player is now created
                            Introduction.Continue = true;
                        }
                        else
                        {
                            Typewriter_Method.SlowType($"{powerClassInput} is not a option, try something else\n");
                            Typewriter_Method.SlowType("\n---------------------------\n", 60);

                            Introduction.Continue = false;
                        }

                    }
                    else if (Introduction.Confirm.ToLower() == "no")
                    {
                        Typewriter_Method.SlowType($"\n\nEnter your new choice: \n");
                        Introduction.Continue = false;
                    }
                    else
                    {
                        Typewriter_Method.SlowType($"{Introduction.Confirm} is not a valid option");
                        Typewriter_Method.SlowType($"\n\nEnter your new choice: \n");
                        Introduction.Continue = false;
                    }
                }
                else
                {
                    Typewriter_Method.SlowType($"{Introduction.Confirm} is not a valid option");
                    Typewriter_Method.SlowType($"\n\nEnter your new choice: \n");
                    Introduction.Continue = false;
                }

            }
        }
    }
}
