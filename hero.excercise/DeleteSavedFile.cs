using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireFighter_1
{
    public class DeleteSavedFile
    {
        public static void DeleteFile()
        {
            string filePath = "players.json";

            if (File.Exists(filePath))
            {
                File.Delete(filePath);
                Console.WriteLine("Save file deleted successfully.");
            }
            else
            {
                Console.WriteLine("No save file found to delete.");
            }
        }
    }
}
