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
            string Prompt = "\tMenu";
            string[] MainMenuOptions = { "Adventure", "See Stats", "Go to Store", "Rest up your Hp", "Train", "End Game" };
            FunMenu MainMenu = new FunMenu(Prompt, MainMenuOptions);
            MainMenu.Run();


            Introduction.Continue = false;
            while ((Introduction.Continue == false)&&(user.Hp > 0))
            {
                


                switch (MainMenu.SelectedIndex+1)
                {
                    case 1:
                        AdventureMethod.Adventure(user, enemy);
                        Introduction.Continue = true;
                        Introduction.EndGame = true;
                        break;

                    case 2:
                        PrintStats.Stats(user, enemy);
                        Introduction.Continue = true;
                        Introduction.EndGame = true;

                        break;

                    case 3:
                        StoreMethod.Store(user, enemy);
                        Introduction.Continue = true;
                        Introduction.EndGame = true;

                        break;

                    case 4:
                        RestMethod.Rest(user, enemy);
                        Introduction.Continue = true;
                        Introduction.EndGame = true;

                        break;

                    case 5:
                        TrainMethod.Train(user, enemy);
                        Introduction.Continue = true;
                        Introduction.EndGame = true;

                        break;

                    case 6:
                        
                        Introduction.Continue = true;
                        Introduction.EndGame = true;

                        break;

                    default:
                        Console.WriteLine($"{MainMenu.SelectedIndex} is not a option, try something else\n");
                        Introduction.Continue = false;

                        break;
                }
            }

        }


       

        
       



        



       
        
        
    }
}
