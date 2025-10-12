using FireFighter_1;
using FireFighter_1;
using FireFighter_1.Menu_s;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireFighter_1
{
    public class Introduction
    {

        //Introduction Variables
        public static bool Continue = false;
        public static bool EndGame = false;


        //Create variables
        private static string? name = ""; 
        public static string? Name
        {
            get { return name; }
            set { name = value; }
        }

        private static string idCode = "";
        public static string IdCode
        {
            get { return idCode; }
            set { idCode = value; }
        }
        private static int powerClass;
        public static int PowerClass
        {
            get { return powerClass; }
            set { powerClass = value; }
        }
        public static Random randomGenerated = new Random();
        private static int randomNumber;
        public static int RandomNumber
        {
            get { return randomNumber; }
            set { randomNumber = value; }
        }




        public static Player Introduce(List<Player> users)
        {

            string Prompt = (
                    "==== Welcome to Firefighter 1 ====\n" +
                    "\n\"The world is plagued by a mystical force making random people, at random times, go up in flames.\"" +
                    "\n\"These are Infernals\"" +
                    "\n\"As their body burns they do not die. They do not collapse. But instead they destroy.\"" +
                    "\n\"As they continue do burn so does everything around them.\"" +
                    "\n\"These random combustions spread fear and chaos everywhere. No place is safe\"\n" +
                    "\n\"However, in this world of chaos people also recieve random powers.\"" +
                    "\n\"Powers of different kinds but all connected to fire.\"" +
                    "\n\"One group of people have made it their purpose in life to use their powers to fight these infernals.\"" +
                    "\n\"They are the Firefighters\"\nIn this game you will be playing as someone who has just completed their basic training as a firefighter" +
                    "\nFight through the monsters and discover the clues to understand what really is behind these spontaneous Combustions\n\n"
                );


            
            string[] Options = { "Create your Character", "Go back" };

            FunMenu StartGame = new FunMenu(Prompt, Options);
            StartGame.Run();

            //Continue to create or stop
            
                

                if (StartGame.SelectedIndex == 0)
                {
                    Player newUser = CreatePlayer.Create();
                    users.Add(newUser);

                    SaveInfo.SavePlayers(users);

                    Console.Clear();
                    Console.WriteLine("------------------\n");
                    return newUser;
                }
                else if (StartGame.SelectedIndex == 1)
                {
                    
                    return null;
                }
            Console.Clear();
            Console.WriteLine("---------------------------\n");
            return null;
            
            

        }
        
            



        

    }
}

