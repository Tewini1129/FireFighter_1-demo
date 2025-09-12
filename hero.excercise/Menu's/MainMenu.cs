using FireFIghter_1;
using FireFIghter_1.Menu_s;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace FireFighter_1
{
    public class MenuOptions
    {
        //variables
        public static int creditCard;

        public static void Menu(Player user, Enemy enemy)
        {

            Console.Clear();
            Console.WriteLine("\n---------------------------\n");

            Typewriter_Method.SlowType("\n\n\tMenu\n");
            Typewriter_Method.SlowType("\t1.Adventure\n");
            Typewriter_Method.SlowType("\t2.See stats\n");
            Typewriter_Method.SlowType("\t3.Go to Store\n");
            Typewriter_Method.SlowType("\t4.Rest up your Hp\n");
            Typewriter_Method.SlowType("\t5.Train\n");
            Typewriter_Method.SlowType("\t6.End game\n\n\n");

            Console.WriteLine("\n---------------------------\n\n");


            Typewriter_Method.SlowType("Enter the number of the option you wish to choose:\n\n");


            Introduction.Continue = false;
            while ((Introduction.Continue == false)&&(user.Hp > 0))
            {
                string? menuChoice = Console.ReadLine();

                switch (menuChoice!.ToLower())
                {
                    case "1":
                        AdventureMethod.Adventure(user, enemy);
                        Introduction.Continue = true;
                        Introduction.EndGame = true;
                        break;

                    case "2":
                        PrintStats.Stats(user, enemy);
                        Introduction.Continue = true;
                        Introduction.EndGame = true;

                        break;

                    case "3":
                        StoreMethod.Store(user, enemy);
                        Introduction.Continue = true;
                        Introduction.EndGame = true;

                        break;

                    case "4":
                        RestMethod.Rest(user, enemy);
                        Introduction.Continue = true;
                        Introduction.EndGame = true;

                        break;

                    case "5":
                        TrainMethod.Train(user, enemy);
                        Introduction.Continue = true;
                        Introduction.EndGame = true;

                        break;

                    case "6":
                        EndScreen.End(user);
                        Introduction.Continue = true;
                        Introduction.EndGame = true;

                        break;

                    default:
                        Console.WriteLine($"{menuChoice} is not a option, try something else\n");
                        Introduction.Continue = false;

                        break;
                }
            }

        }


       

        
       



        



       
        
        
    }
}
