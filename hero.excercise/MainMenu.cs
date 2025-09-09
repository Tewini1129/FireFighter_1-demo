using FireFIghter_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace FireFighter_1
{
    public class MenuOptions
    {
        //variables
        public static int creditCard = Player.Gold;

        public static void Menu(Player user, Enemy enemy)
        {
            Console.WriteLine("\n\n\tMenu\n");
            Console.WriteLine("\t1.Adventure");
            Console.WriteLine("\t2.See stats");
            Console.WriteLine("\t3.Go to Store");
            Console.WriteLine("\t4.Rest up your Hp");
            Console.WriteLine("\t5.End game\n\n");

            Console.WriteLine("Enter the number of the option you wish to choose:\n");


            Start_Create.Continue = false;
            while (Start_Create.Continue == false)
            {
                string? menuChoice = Console.ReadLine();

                switch (menuChoice!.ToLower())
                {
                    case "1":
                        Adventure(user, enemy);
                        Start_Create.Continue = true;
                        break;

                    case "2":
                        Stats(user, enemy);
                        Start_Create.Continue = true;
                        break;

                    case "3":
                        Store(user, enemy);
                        Start_Create.Continue = true;
                        break;

                    case "4":
                        Rest(user, enemy);
                        Start_Create.Continue = true;
                        break;

                    case "5":
                        EndScreen.End();
                        Start_Create.Continue = true;
                        break;

                    default:
                        Start_Create.Continue = false;
                        break;
                }
            }

        }


        //Go on adventure method
        public static void Adventure(Player user, Enemy enemy)
        {
            string? userChoice = "";
            Console.WriteLine("\n---------------------------\n\n");

            Console.WriteLine("\tChoose your adventure:\n");
            Console.WriteLine("\t1. Burning building");
            Console.WriteLine("\t2. Training camp");
            Console.WriteLine("\t3. The Nether");
            Console.WriteLine("\t4. The White clad attack");
            Console.WriteLine("\n\nEnter the number of the option you wish to choose:\n");

            while ((userChoice != "1") || (userChoice != "2") || (userChoice != "3") || (userChoice != "4"))
            {

                userChoice = Console.ReadLine();

                switch (userChoice)
                {
                    case "1":
                        if (Player.Progress >= 1)
                        {
                            Adventures.BurningBuilding(user, enemy);
                        }
                        else
                        {
                            Console.WriteLine("Your level is to low to enter the Burning Building...");

                        }
                        break;

                    case "2":
                        if (Player.Progress >= 1)
                        {
                            Adventures.Research(user, enemy);
                        }
                        else
                        {
                            Console.WriteLine("Your level is to low to enter the Training camp...");
                        }
                        break;

                    case "3":
                        if (Player.Progress >= 1)
                        {
                            Adventures.TheNether(user, enemy);
                        }
                        else
                        {
                            Console.WriteLine("Your level is to low to enter the Training camp...");
                        }

                        break;

                    case "4":
                        if (Player.Progress >= 1)
                        {
                            Adventures.WhiteCladAttack(user, enemy);
                        }
                        else
                        {
                            Console.WriteLine("Your level is to low to enter the Training camp...");
                        }
                        break;

                    default:
                        Console.WriteLine($"{userChoice} is not a valid option");
                        break;

                }
            }
        }

        
        //See stats method
        public static void Stats(Player user, Enemy enemy )
        {
            Start_Create.Continue = false;
            Console.WriteLine("---------------------------");
            Console.WriteLine($"\n\nUsername:\t\t\t{Player.Name}");
            Console.WriteLine($"Generation:\t\t\t{Player.PowerClass}");
            Console.WriteLine($"Hp/Max Hp:\t\t\t{Player.Hp}/{Player.MaxHp}");
            Console.WriteLine($"Energy level/Max energy level:\t{Player.EnergyLevel}/{Player.MaxEnergyLevel}");
            Console.WriteLine($"Damage:\t\t\t\t{Player.RegulareDamage}");
            Console.WriteLine($"Gold:\t\t\t\t{Player.Gold}");
            Console.WriteLine($"Progress:\t\t\t{Player.Progress}");

            if (Player.inventory.Count() == 0)
            {
                Console.WriteLine($"Inventory: Empty");
            }
            else if (Player.inventory.Count() > 0)
            {
                Console.Write("Inventory:");
                foreach (string item in Player.inventory)
                {
                    Console.Write($" {item}");
                }

            }
            Console.WriteLine("\n\n\nPress \"Enter\" to continue to menu");
            while(Start_Create.Continue == false)
            {
                string? userChoice = Console.ReadLine();
                if (userChoice == "")
                {
                    Start_Create.Continue = true;
                    Menu(user, enemy);
                }
                else
                {
                    Console.WriteLine($"{userChoice} is not a valid option, try again!");
                }
            }
        }



        //Store method
        public static void Store(Player user, Enemy enemy)
        {
            

            //Cost
            List<int> itemCost = new List<int>();

            //Items
            List<String> items = new List<string>();
            items.Add("Redbull");
            itemCost.Add(2);
            items.Add("Healing Potion");
            itemCost.Add(2);

            Console.WriteLine("\n---------------------------");
            Console.WriteLine("\n\nStore manager - \"Welcome to store\"\n");

            //Items
            Console.WriteLine("Store Manager - \"Here is a list of our current items in Stock\"\n");
            Console.WriteLine($"\t1.Redbull 500ml - {itemCost[0]} gold");
            
            Console.WriteLine($"\t2.Healing Potion 250ml - {itemCost[1]} gold\n");
            

            //Current amount of gold
            Console.WriteLine($"\nYour currently have {Player.Gold} gold coins");
            Console.WriteLine("Enter the number of the item you wish to purchase or \"Leave\" to back to menu:");
            Start_Create.Continue = false;
            while (Start_Create.Continue == false)
            {
                
                string? wantedItem = Console.ReadLine();
                if (wantedItem == "1")
                {
                    if (Player.Gold >= itemCost[0])
                    {
                        //Adding Item to inventory and paying
                        creditCard = Player.Gold;
                        Player.inventory.Add("Redbull");
                        creditCard = Player.Gold - 2;
                        Player.Gold = creditCard;

                        Console.WriteLine("\n---------------------------\n");
                        Console.WriteLine("-2 Gold \n+1 Redbull");
                        Console.WriteLine("\n---------------------------\n");

                        Start_Create.Continue = true;
                        Menu(user, enemy);
                    }
                    else
                    {
                        Console.WriteLine("\n\nYou do not have enough gold for this item...");
                        Console.WriteLine("Enter \"Leave\" to go back to menu");

                    }
                }
                else if (wantedItem == "2")
                {
                    if (Player.Gold >= itemCost[1])
                    {
                        //Adding Item to inventory and paying
                        Player.inventory.Add("Healing potion");
                        creditCard = Player.Gold - 2;
                        Player.Gold = creditCard;

                        Console.WriteLine("\n---------------------------\n");
                        Console.WriteLine("-2 Gold \n+1 Healing Potion");
                        Console.WriteLine("\n---------------------------\n");

                        Start_Create.Continue = true;
                        Menu(user, enemy);
                    }
                    else
                    {
                        Console.WriteLine("\n\nYou do not have enough gold for this item...");
                        Console.WriteLine("Enter \"Leave\" to go back to menu");
                    }
                }
                else if (wantedItem!.ToLower() == "leave")
                {

                    Menu(user, enemy);
                    Start_Create.Continue = true;
                }
                else
                {
                    Console.WriteLine("Not a valid input");
                    Console.WriteLine("\n---------------------------\n");

                }

            }
            
        }



        //Rest method
        public static void Rest(Player user, Enemy enemy)
        {
            Start_Create.Continue = false;
            Console.WriteLine("\n---------------------------\n");
            Console.WriteLine("Zz Zzz\n");
            Console.WriteLine("Zzz Zz Zzz\n\n");
            Console.WriteLine("Zz Zzz\n");
            Console.WriteLine("Zzz Zz Zzz\n\n");
            Console.WriteLine("Zz Zzz\n");
            Console.WriteLine("Zzz Zz Zzz\n\n");
            Console.WriteLine("Press \"Enter\" to wake up and continue");
            
            while (Start_Create.Continue == false)
            {
                Start_Create.userChoice = Console.ReadLine();

                if (Start_Create.userChoice == "")
                {
                    Start_Create.Continue = true;

                }
                
                else
                {

                    Console.WriteLine($"{Start_Create.userChoice} is not a valid option, try again");
                }
            }
            Console.WriteLine("---------------------------\n");

            Console.WriteLine("You have now rested");
            Console.WriteLine("Your Hp and energy level is fully restored");
            Player.Hp = Player.MaxHp;
            Player.EnergyLevel = Player.MaxEnergyLevel;
            Menu(user, enemy);

        }
        
        
    }
}
