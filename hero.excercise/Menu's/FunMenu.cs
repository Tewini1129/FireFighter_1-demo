using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireFIghter_1.Menu_s
{
    public class FunMenu
    {
        public int SelectedIndex;
        public string[] Options;
        public string Prompt = $"";


        public FunMenu(string prompt, string[] options)
        {
            SelectedIndex = 0;
            Options = options;
            Prompt = prompt;
        }

        private void DisplayOptions()
        {
            Console.WriteLine($"{Prompt}\n");
            for (int i = 0; i < Options.Length; i++)
            {
                string currentOption = Options[i];
                string prefix;
                if (i == SelectedIndex)
                {
                    prefix = " * ";
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.White;

                }
                else
                {
                    prefix = "   ";
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Black;
                }


                Console.WriteLine($"{prefix}<< {currentOption} >>{prefix}");
            }
            Console.ResetColor();

        }
        public int Run()
        {
            ConsoleKey keyPressed;
            do
            {
                Console.Clear();
                DisplayOptions();

                ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                keyPressed = keyInfo.Key;
                switch (keyPressed)
                {
                    case ConsoleKey.DownArrow:
                        if(SelectedIndex < (Options.Length-1))
                        {
                        SelectedIndex += 1;

                        }
                        break;

                    case ConsoleKey.UpArrow:
                        if(SelectedIndex > 0)
                        {
                            SelectedIndex -= 1;
                            
                        }
                        
                        break;

                    case ConsoleKey.Enter:

                        break;

                    default:
                        break;
                }


            } while (keyPressed != ConsoleKey.Enter);


            return SelectedIndex;
        }

    }
}

