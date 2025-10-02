using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace FireFighter_1
{
    public static class Typewriter_Method
    {
        

        //Gives a typewriter feeling when printing text
        public static void SlowType(string Text)
        {

            int delay = 1;
            
                
                foreach (char c in Text)
                {
                    Console.Write(c);
                    Thread.Sleep(delay);
                }
            

                

               
        }

        public static void SlowType(string Text, int delay)
        {

            


            foreach (char c in Text)
            {
                Console.Write(c);
                Thread.Sleep(delay);
            }





        }
    }
}
