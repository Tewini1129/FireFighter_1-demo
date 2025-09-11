using FireFighter_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireFIghter_1.Menu_s
{
    public class StoreMethod
    {
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

            Console.Clear();
            Console.WriteLine("\n---------------------------");
            Typewriter_Method.SlowType("\n\nStore manager - \"Welcome to store\"\n\n");

            //Items
            Typewriter_Method.SlowType("Store Manager - \"Here is a list of our current items in Stock\"\n\n");
            Typewriter_Method.SlowType($"\t1.Redbull 500ml - {itemCost[0]} gold");

            Typewriter_Method.SlowType($"\t2.Healing Potion 250ml - {itemCost[1]} gold\n");


            //Current amount of gold
            Typewriter_Method.SlowType($"\nYour currently have {Player.Gold} gold coins");
            Typewriter_Method.SlowType("\n\nEnter the number of the item you wish to purchase or \"Leave\" to go back to menu:\n\n");
            Introduction.Continue = false;
            while (Introduction.Continue == false)
            {

                string? wantedItem = Console.ReadLine();
                if (wantedItem == "1")
                {
                    if (Player.Gold >= itemCost[0])
                    {
                        //Adding Item to inventory and paying
                        MenuOptions.creditCard = Player.Gold;
                        Player.inventory.Add("Redbull");
                        MenuOptions.creditCard = Player.Gold - 2;
                        Player.Gold = MenuOptions.creditCard;

                        Console.WriteLine("\n---------------------------\n");
                        Typewriter_Method.SlowType("-2 Gold \n+1 Redbull\n");
                        Typewriter_Method.SlowType("\n---------------------------\n", 50);

                        Introduction.Continue = true;
                        StoreMethod.Store(user, enemy);
                    }
                    else
                    {
                        Typewriter_Method.SlowType("\n\nYou do not have enough gold for this item...\n");
                        Typewriter_Method.SlowType("Enter \"Leave\" to go back to menu\n");

                    }
                }
                else if (wantedItem == "2")
                {
                    if (Player.Gold >= itemCost[1])
                    {
                        //Adding Item to inventory and paying
                        Player.inventory.Add("Healing potion");
                        MenuOptions.creditCard = Player.Gold - 2;
                        Player.Gold = MenuOptions.creditCard;

                        Console.WriteLine("\n---------------------------\n");
                        Typewriter_Method.SlowType("-2 Gold \n+1 Healing Potion\n");
                        Typewriter_Method.SlowType("\n---------------------------\n", 50);

                        Introduction.Continue = true;
                        StoreMethod.Store(user, enemy);
                    }
                    else
                    {
                        Typewriter_Method.SlowType("\n\nYou do not have enough gold for this item...\n");
                        Typewriter_Method.SlowType("\nEnter \"Leave\" to go back to menu\n\n");
                    }
                }
                else if (wantedItem!.ToLower() == "leave")
                {

                    MenuOptions.Menu(user, enemy);
                    Introduction.Continue = true;
                }
                else
                {
                    Typewriter_Method.SlowType("\nNot a valid input\nTry something else:\n\n");

                }

            }

        }
    }
}
