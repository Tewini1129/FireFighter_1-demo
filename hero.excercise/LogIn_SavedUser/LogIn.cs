using FireFighter_1.Menu_s;
using FireFighter_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace FireFighter_1
{
    public class LogIn
    {
        public static Player currentUser = new();
        public static bool HasAccount = false; 

        public static Player LogInOrCreate(List<Player> users)
        {
            string Prompt = "==== Welcome to FireFighter 1====\n";
            string[] Options = { "Sign in", "Create account" };
            FunMenu SignInMenu = new FunMenu(Prompt, Options);
            SignInMenu.Run();

            switch(SignInMenu.SelectedIndex)
            {
                case 0:
                    if (users.Count > 0)
                    {
                        if (users == null)
                        {
                            Typewriter_Method.SlowType("No previouse saved players");
                            Typewriter_Method.SlowType("\n-----------------", 90);

                        }
                        else
                        {
                            return SignIn(Program.users);

                        }
                    }
                    else
                    {
                        Console.WriteLine("There are no previouse users saved");
                        Typewriter_Method.SlowType("\n-----------------\n", 90);
                        return LogInOrCreate(users);
                    }

                    break;

                case 1:
                    Player? createdUser = Introduction.Introduce(users);
                    if(createdUser != null)
                    {
                        LogIn.currentUser = createdUser;
                        HasAccount = true;
                        return createdUser;
                    }
;                    break;

                
            }
            return new Player();

        }

        public static Player SignIn(List<Player> users)
        {
            Console.Clear();
            Console.WriteLine("==== Sign in ====");
            Console.Write("Enter username: ");
            string userName = Console.ReadLine();

            Console.Write("Enter Password: ");
            string idCode = Console.ReadLine();

            Player? foundUser = SaveInfo.FindUser(userName, idCode, users);
            if(foundUser != null)
            {
                HasAccount = true;
                currentUser = foundUser;
                RestMethod.Rest(currentUser);
                Introduction.EndGame = false;
                Console.WriteLine($"==== Welcome {currentUser.Name} ====");
                PrintStats.Stats(currentUser);
                Typewriter_Method.SlowType("\n-----------------\n", 90);
                return currentUser;

            }
            else
            {
                Console.WriteLine("Incorrect username or password...");
                Typewriter_Method.SlowType("\n-----------------\n", 90);
                string Prompt = "Do you wish to try again?";
                string[] Options = { "Yes", "Create Account"};
                FunMenu TryAgain = new FunMenu(Prompt, Options);
                TryAgain.Run();
                if(TryAgain.SelectedIndex == 0)
                {
                    return SignIn(users);
                }
                else
                {
                    Player? createdUser = Introduction.Introduce(users);
                    if (createdUser != null)
                    {
                        LogIn.currentUser = createdUser;
                        HasAccount = true;
                        return createdUser;
                    }
                    return new Player();
                }
            }
        }
    }
}
