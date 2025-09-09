
using System;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using static System.Net.Mime.MediaTypeNames;

namespace FireFighter_1
{
    class Program
    {

        public static void Main(string[] args)
        {

            
            //Titel screen

            Start_Create.Introduction();
            while (Start_Create.EndGame == false)
            {
                
                Start_Create.Create();
                Player user = new Player();
                Enemy enemy = new Enemy(user);
                
                MenuOptions.Menu(user, enemy);

            }
            
                EndScreen.End();
            

        }

    }
}
    





   






