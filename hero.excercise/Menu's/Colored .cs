using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireFIghter_1.Menu_s
{
    public class ColoredText
    {
        public static void Green(string text)
        {
            
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(text);
            
            Console.ResetColor();
        }
    }
}
