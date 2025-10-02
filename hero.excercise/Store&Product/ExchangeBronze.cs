using System;
using FireFighter_1;
using FireFighter_1.Menu_s;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireFighter_1.Store_Product
{
    public class ExchangeBronze
    {
        public static void Exchange(Player user)
        {
            double bronzeToGold = user.Bronze / 3;
            double bronzeToSilver = user.Bronze / 2;
            Console.Clear();
            Console.WriteLine("----==== Exchange Bronze ====----");
            string Prompt = $"Current Bronze: {user.Bronze}\nWhat would you like to exchange your bronze for?";
            string[] Options = { $"{Math.Round(bronzeToGold)} Gold pieces", $"{Math.Round(bronzeToSilver)} Silver pieces", "Go back" };
            FunMenu ExchangeMenu = new FunMenu(Prompt, Options);
            ExchangeMenu.Run();

            switch (ExchangeMenu.SelectedIndex)
            {
                case 0:
                    user.Gold += (user.Bronze/3);
                    user.Bronze = 0;
                    if (StoreMethod.currency == "Bronze")
                    {
                        StoreMethod.userWalletIn = 0;

                    }
                    break;

                case 1:
                    user.Silver += (user.Bronze / 2);
                    user.Bronze = 0;
                    if(StoreMethod.currency == "Bronze")
                    {
                        StoreMethod.userWalletIn = 0;

                    }
                    break;

                default:
                    Console.WriteLine("Going back to store");
                    Typewriter_Method.SlowType("--------------------", 90);
                    break;
            }
        }
    }
}
