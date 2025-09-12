
using FireFIghter_1;
using FireFIghter_1.Menu_s;
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
            Introduction.Introduce();
            Player user = new Player();

            while (Introduction.EndGame == false)
            {
                CreatePlayer.Create(user);
                
                
                Enemy enemy1 = new Enemy(user, Adventures.randomNumber);
                
                MenuOptions.Menu(user, enemy1);

            }
            
                EndScreen.End(user);
            

        }

    }
}
    





   






