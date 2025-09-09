using FireFighter_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireFighter_1
{
    internal class Start_Create
    {

        //Introduction Variables
        public static bool Continue = false;
        public static bool EndGame = false;
        public static string? userChoice = "";


        //Create variables
        public static string? name;
        public static int powerClass;
        public static string? Confirm;
        public static Random randomGenerated = new Random();
        public static int randomNumber;



        public static void Introduction()
        {

            //Title & Story
            Console.WriteLine("\tWelcome to Firefighter 1");
            
            Console.WriteLine("\n \"The world is plagued by a mystical force making random people, at random times, go up in flames.\"");
            Console.WriteLine("\"These are Infernals\"");
            Console.WriteLine("\"As their body burns they do not die. They do not collapse. But instead they destroy.\"");
            Console.WriteLine("\"As they continue do burn so does everything around them.\"");
            Console.WriteLine("\"These random combustions spread fear and chaos everywhere. No place is safe\"\n");
            Console.WriteLine("\"However, in this world of chaos people also recieve random powers.\"");
            Console.WriteLine("\"Powers of different kinds but all connected to fire.\"");
            Console.WriteLine("\"One group of people have made it their purpose in life to use their powers to fight these infernals.\"");
            Console.WriteLine("\"They are the Firefighters\"\n");
            Console.WriteLine("In this game you will be playing as someone who has just completed their basic training as a firefighter");

            //How to win
            Console.WriteLine("Fight through the monsters and discover the clues to understand what really is behind these spontaneous Combustions");
            Console.WriteLine("\nPress \"Enter\" to start creating your FireFighter!");
            Console.WriteLine("Enter \"Stop\" if you already wish to end the game");



            //Continue to create or stop
            while (Continue == false)
            {
                userChoice = Console.ReadLine();

                if (userChoice == "")
                {
                    Continue = true;

                }
                else if (userChoice!.ToLower() == "stop")
                {
                    Continue = true;
                    EndGame = true;
                    
                }
                else
                {
                    
                    Console.WriteLine($"{userChoice} is not a valid answer, try again");
                }
            }
            Console.WriteLine("---------------------------\n");

        }
        public static void Create()
        {
            //Name - choosing name
            Console.WriteLine("Captain - \"First off, we are gonna need a name!\"\nCaptain - \"Who are you?\"\n");
            name = Console.ReadLine()!;
            Console.WriteLine("---------------------------");
            Player.Name = name;
            Console.WriteLine($"\nCaptain - \"Huh, Feels familiar i might have heard of you...\"\nCaptain - \"Anyways Nice to meet you {name}!\"");



            
                //Power
                Console.WriteLine($"\nCaptain - \"Now to the interesting part, what generation are you?\"");

                //Power - First generation - explanation
                Console.WriteLine("\n\t1. First generation \n\t- Blast fire from both your hands and feet");

                //Power - Second generation - explanation
                Console.WriteLine("\n\t2. Second generation\n\t- Control a pre existing fire & manipulate a specific source of heat");

                //Power - Third generation - explanation
                Console.WriteLine("\n\t3. Third generation\n\tWARNING!\n\t-Choose at risk. 50% chance of getting First generation. 40% chance of getting Second generation.");
                Console.WriteLine("\t-BUT there is also a 10% chance of getting both");

                Console.WriteLine("\nEnter your choice: \"1\",\"2\" or \"3\"");

                //Power - Choice
                Continue = false;
                while (Continue == false)
                {
                    int powerClass = int.Parse(Console.ReadLine()!);

                    if ((powerClass == 1) || (powerClass == 2) || (powerClass == 3))
                    {
                        Console.WriteLine($"\nConfirm choice: Yes/No");
                        Confirm = Console.ReadLine()!;
                        Console.WriteLine("---------------------------");

                        if (Confirm.ToLower() == "yes")
                        {
                            if (powerClass == 3)
                            {
                                randomNumber = randomGenerated.Next(1, 11);
                                if (randomNumber <= 5)
                                {

                                    powerClass = 1;
                                    Player.PowerClass = 1;
                                    Console.WriteLine($"\n{Player.Name} got {Player.PowerClass}");
                                    Console.WriteLine("First generation, great! we needed just that!");
                                }
                                else if ((randomNumber > 5) || (randomNumber <= 9))
                                {
                                    powerClass = 2;
                                    Player.PowerClass = 2;
                                    Console.WriteLine($"\n{name} got {powerClass}");
                                    Console.WriteLine("Second generation, that's perfect, very useful in the right hands!");
                                }
                                else if (randomNumber == 10)
                                {
                                    powerClass = 3;
                                    Player.PowerClass = 3;
                                    Console.WriteLine($"\n{Player.Name} got {Player.PowerClass}");
                                    Console.WriteLine("Oh wow, that's incredible, not many of those around!");
                                }

                            }
                            else if (powerClass == 2)
                            {
                                powerClass = 2;
                                Player.PowerClass = 2;
                                Console.WriteLine($"\n{Player.Name} is now {Player.PowerClass}");
                                Console.WriteLine("Second generation! That's perfect, very useful in the right hands!");
                            }
                            else if (powerClass == 1)
                            {
                                powerClass = 1;
                                Player.PowerClass = 1;
                                Console.WriteLine($"\n{Player.Name} is now {Player.PowerClass}");
                                Console.WriteLine("First generation, great! We needed just that!");
                            }

                            //Your Player is now created
                            Continue = true;
                        }
                        else if (Confirm.ToLower() == "no")
                        {
                            Continue = false;
                        }
                    }
                    else
                    {
                        Continue = false;
                    }
                }
            



        }

    }
}

