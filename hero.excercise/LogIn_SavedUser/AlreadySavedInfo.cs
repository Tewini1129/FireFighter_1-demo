using System;
using FireFIghter_1;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireFighter_1
{
    public class AlreadySavedInfo
    {
        public static void DeletePlayerDataFile()
        {
            string filePath = "Playerdata.json";
            if(File.Exists(filePath))
            {
                File.Delete(filePath);
                Console.WriteLine("playerdata.json deleted");
            }
            else
            {
                Console.WriteLine("playerdata.json does not exist");
            }
        }
    }
}
