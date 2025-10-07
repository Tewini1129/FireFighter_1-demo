
using FireFighter_1;
using System;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using static System.Net.Mime.MediaTypeNames;

namespace FireFighter_1
{
    class Program
    {
        public static List<Player> users = SaveInfo.LoadAllUsers();
        public static void Main(string[] args)
        {
            Player? user = null;
            

            while (Introduction.EndGame == false)
            {
                user = LogIn.LogInOrCreate(users);
                user = LogIn.currentUser;
                Enemy enemy1 = new Enemy(user ?? new Player(), Adventures.randomNumber);
                if(LogIn.HasAccount == true)
                { 
                    MenuOptions.Menu(user, enemy1);
                
                }
            }
            
            
            EndScreen.End(user);
        }
    }
}
    





   






