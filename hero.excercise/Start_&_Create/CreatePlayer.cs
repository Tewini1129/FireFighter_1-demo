using FireFighter_1;
using FireFighter_1.Menu_s;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FireFighter_1
{
    internal class CreatePlayer
    {
        public static Player Create()
        {
           
            Console.Clear();
            //Name - choosing name
            Typewriter_Method.SlowType("Captain - \"First off, we are gonna need a name and a Id code!\"\nCaptain - \"Who are you?\"\n");
            while ((Introduction.name == "")||(Introduction.idCode == ""))
            {
                Console.WriteLine("What is your name");
                Introduction.name = Console.ReadLine()!;
                if (Introduction.name == "")
                {
                    Console.WriteLine("You need to enter in a name before we continue\n");
                }
                else
                {
                    Console.WriteLine("What is your id-code");
                    Introduction.idCode = Console.ReadLine()!;
                    if (Introduction.idCode == "")
                    {
                        Console.WriteLine("You need to enter in a Id code before we continue\n");
                    }

                }

            }
            Player user = new Player();

            Console.Clear();
            Console.WriteLine("---------------------------");
            user.Name = Introduction.name;
            Introduction.name = "";
            user.IdCode = Introduction.idCode;
            Introduction.idCode = "";

            Typewriter_Method.SlowType($"\nCaptain - \"{user.Name} huh, Feels familiar, i might have heard of you...\"\nCaptain - \"Anyways Nice to meet you {Introduction.name}!\"");
            Typewriter_Method.SlowType("\n\n\t1. First generation \n\t- More power! Blast fire from both your hands and feet\n");
            Typewriter_Method.SlowType("\n\t2. Second generation\n\t- Better control! Control a pre existing fire & manipulate a specific source of heat\n");
            Typewriter_Method.SlowType("\n\t3. Third generation\n\tWARNING!\n\t-Choose at risk. 40% chance of getting First generation. 40% chance of getting Second generation.\n\t-BUT there is also a 20% chance of getting both\n");


            //Power


            string Prompt = $"\nCaptain - \"{user.Name} huh, Feels familiar, i might have heard of you...\"\nCaptain - \"Anyways Nice to meet you {Introduction.name}!\"\n\n\t1. First generation \n\t- More power! Blast fire from both your hands and feet\n\n\t2. Second generation\n\t- Better control! Control a pre existing fire & manipulate a specific source of heat\n\n\t3. Third generation\n\tWARNING!\n\t-Choose at risk. 40% chance of getting First generation. 40% chance of getting Second generation.\n\t-BUT there is also a 20% chance of getting both\n";
            string[] PowerChoices = { "First Generation", "Second Generation", "Third generation" };

            FunMenu PowerChoice = new FunMenu(Prompt, PowerChoices);
            PowerChoice.Run();


            //Power - Choice
            Introduction.Continue = false;
            

                
                    

                
                    Console.WriteLine("---------------------------");


                    if (PowerChoice.SelectedIndex == 2)
                    {
                        Introduction.randomNumber = Introduction.randomGenerated.Next(1, 11);
                        if (Introduction.randomNumber <= 4)
                        {

                            Introduction.powerClass = 1;
                            user.PowerClass = 1;
                            user.Progress = 1;
                            user.PowerClass = 1;
                            user.OriginalHp = 120;
                            user.MaxHp = 120;
                            user.Hp = 120;
                            user.MaxShield = user.MaxHp / 2;
                            user.Shield = user.MaxHp / 2;
                            user.MaxEnergyLevel = 10;
                            user.EnergyLevel = 10;
                            user.OriginalDamage = 30;
                            user.RegulareDamage = 30;
                            user.Wallet["Gold"] = 2; 
                            user.Wallet["Silver"] = 4;
                            user.Wallet["Bronze"] = 6;
                            Typewriter_Method.SlowType($"\n{user.Name} got {user.PowerClass}\n");
                            Typewriter_Method.SlowType("First generation, great! We needed just that!\n");
                            Typewriter_Method.SlowType("\n---------------------------\n", 60);
                        }
                        else if ((Introduction.randomNumber > 4) && (Introduction.randomNumber <= 8))
                        {
                            Introduction.powerClass = 2;
                            user.PowerClass = 2;
                            user.Progress = 1;
                            user.PowerClass = 2;
                            user.OriginalHp = 130;
                            user.MaxHp = 130;
                            user.Hp = 130;
                            user.MaxShield = user.MaxHp / 2;
                            user.Shield = user.MaxHp / 2;
                            user.MaxEnergyLevel = 6;
                            user.EnergyLevel = 6;
                            user.OriginalDamage = 40;   
                            user.RegulareDamage = 40;
                            user.Wallet["Gold"] = 4;
                            user.Wallet["Silver"] = 8;
                            user.Wallet["Bronze"] = 12;
                            Typewriter_Method.SlowType($"\n{user.Name} got {Introduction.powerClass}\n");
                            Typewriter_Method.SlowType("Second generation, that's perfect! Very useful in the right hands!\n");
                            Typewriter_Method.SlowType("\n---------------------------\n", 60);
                        }
                        else if (Introduction.randomNumber >= 9)
                        {
                            Introduction.powerClass = 3;
                            user.PowerClass = 3;
                            user.Progress = 1;
                            user.PowerClass = 3;
                            user.OriginalHp = 120;
                            user.MaxHp = 120;
                            user.Hp = 120;
                            user.MaxShield = user.MaxHp;
                            user.Shield = user.MaxHp;
                            user.MaxEnergyLevel = 10;
                            user.EnergyLevel = 10;
                            user.OriginalDamage = 50;
                            user.RegulareDamage = 50;
                            user.Wallet["Gold"] = 1;
                            user.Wallet["Silver"] = 2;
                            user.Wallet["Bronze"] = 3;    
                            Typewriter_Method.SlowType($"\n{user.Name} got {user.PowerClass}\n");
                            Typewriter_Method.SlowType("Oh wow, that's incredible, not many of those around!\n");
                            Typewriter_Method.SlowType("\n---------------------------\n", 60);
                        }

                    }
                    else if (PowerChoice.SelectedIndex == 1)
                    {
                        Introduction.powerClass = 2;
                        user.PowerClass = 2;
                        user.Progress = 1;
                        user.PowerClass = 2;
                        user.OriginalHp = 130;
                        user.MaxHp = 130;
                        user.Hp = 130;
                        user.MaxShield = user.MaxHp / 2;
                        user.Shield = user.MaxHp / 2;
                        user.MaxEnergyLevel = 6;
                        user.EnergyLevel = 6;
                        user.OriginalDamage = 40;
                        user.RegulareDamage = 40;
                        user.Wallet["Gold"] = 4;
                        user.Wallet["Silver"] = 8;
                        user.Wallet["Bronze"] = 12;
                        Typewriter_Method.SlowType($"\n{user.Name} got {Introduction.powerClass}\n");
                        Typewriter_Method.SlowType("Second generation, that's perfect! Very useful in the right hands!\n");
                        Typewriter_Method.SlowType("\n---------------------------\n", 60);

                    }
                    else if (PowerChoice.SelectedIndex == 0)
                    {
                        Introduction.powerClass = 1;
                        user.PowerClass = 1;
                        user.Progress = 1;
                        user.PowerClass = 1;
                        user.OriginalHp = 120;
                        user.MaxHp = 120;
                        user.Hp = 120;
                        user.MaxShield = user.MaxHp / 2;
                        user.Shield = user.MaxHp / 2;
                        user.MaxEnergyLevel = 10;
                        user.EnergyLevel = 10;
                        user.OriginalDamage = 30;
                        user.RegulareDamage = 30;
                        user.Wallet["Gold"] = 2;
                        user.Wallet["Silver"] = 4;
                        user.Wallet["Bronze"] = 6;
                        Typewriter_Method.SlowType($"\n{user.Name} is now {user.PowerClass}\n");
                        Typewriter_Method.SlowType("First generation, great! We needed just that!\n");
                        Typewriter_Method.SlowType("\n---------------------------\n", 60);

                    }

            //Your Player is now created
            Program.users.Add(user);
            SaveInfo.SavePlayers(Program.users);
            LogIn.HasAccount = true;
            Introduction.Continue = true;
            return user;
                
                
                
            

            
        }
    }
}
