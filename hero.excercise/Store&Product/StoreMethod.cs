using FireFighter_1;
using FireFighter_1.Store_Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireFighter_1.Menu_s
{
    public class StoreMethod
    {
        public static bool KeepShopping = true;

        //Cost
        public static double userWalletIn = 0;
        public static string currency { get; private set; }


        public static List<Products> redbulls = new List<Products>()
            {
                new Redbull(),
                new Redbull(),
                new Redbull()
            };


        public static List<Products> healthPotions = new List<Products>()
            {
                new HealthPotion(),
                new HealthPotion(),
                new HealthPotion()
            };



        public static List<Products> adollaLink = new List<Products>()
            {
                new AdollaLink(),
                new AdollaLink(),
                new AdollaLink()
            };


        

        public static int CurrencyMultiplyer;
        public static void ChooseCurrency()
        {
            
            string Prompt = "==== Choose Your Currency ====";
            string[] Options = [ "Gold", "Silver", "Bronze" ];
            FunMenu CurrencyMenu = new(Prompt, Options);
            CurrencyMenu.Run();

            switch(CurrencyMenu.SelectedIndex)
            {
                case 0:
                    currency = "Gold";
                    CurrencyMultiplyer = 1;
                    break;

                case 1:
                    currency = "Silver";
                    CurrencyMultiplyer = 2;
                    break;

                default:
                    currency = "Bronze";
                    CurrencyMultiplyer = 3;
                    break;
            }
        }
        //Store method
        public static void Store(Player user, Enemy enemy)
        {
            
            ChooseCurrency();

            Console.Clear();
            Console.WriteLine("\n---------------------------");
            Typewriter_Method.SlowType("\n\nStore manager - \"Welcome to store\"\n\n");

            //Items
            Typewriter_Method.SlowType("Store Manager - \"Here is a list of our current items in Stock\"\n\n");
            Typewriter_Method.SlowType($"\t1.Redbull 500ml");
            Typewriter_Method.SlowType($"\n\t2.Healing Potion 250ml");
            Typewriter_Method.SlowType($"\n\t3.Adolla Link");
            Typewriter_Method.SlowType($"\n\nShopping Cart Total: {Math.Round(user.UserCustomer.Cart.Total * CurrencyMultiplyer)} {currency} coins    {user.UserCustomer.Cart.nrItemsInCart}x Items");
            Typewriter_Method.SlowType($"\nYour currently have {Math.Round(user.Wallet[currency])} {currency} coins");
            userWalletIn = user.Wallet[currency];
            Introduction.Continue = false;

            do
            {
                user.UserCustomer.Cart.nrItemsInCart = user.UserCustomer.Cart.itemsInCart.Values.Sum();

                //Menu
                string Prompt = (
                        $"\n---------------------------\n\nStore manager - \"Welcome to store\"" +
                        $"\n\nStore Manager - \"Here is a list of our current items in Stock\"" +
                        $"\n\n\t1.Redbull 500ml (Max Shield)" +
                        $"\n\t2.Healing Potion 250ml (Max Health and Energy)" +
                        $"\n\t3.Adolla Link (Max All)" +
                        $"\n\nShopping Cart Total-Cost: {Math.Round(user.UserCustomer.Cart.Total * CurrencyMultiplyer)} {currency} coins    {user.UserCustomer.Cart.nrItemsInCart}x Items" +
                        $"\n\nYour currently have {user.Wallet[currency]} {currency} coins"
                    );

                string[] StoreItems = { 
                    $"Redbull 500ml - {user.MemberCard.MembersPrice(ShoppingCart.r1.Price * CurrencyMultiplyer)} {currency}", 
                    $"Healing Potion 250ml - {user.MemberCard.MembersPrice(ShoppingCart.h1.Price * CurrencyMultiplyer)} {currency}", 
                    $"Adolla Link - {user.MemberCard.MembersPrice(ShoppingCart.a1.Price * CurrencyMultiplyer)} {currency}", 
                    "See Cart",
                    "Exchange Bronze",
                    "Upgrade MemberShip",
                    "Leave Store" 
                    };
                FunMenu StoreMenu = new FunMenu(Prompt, StoreItems);
                StoreMenu.Run();


                
                switch (StoreMenu.SelectedIndex)
                {
                    case 0:

                        redbulls[0].AddToCart(user);
                        break;
                    case 1:
                        healthPotions[0].AddToCart(user);
                        break;

                    case 2:
                        adollaLink[0].AddToCart(user);
                        break;

                    case 3:
                        user.UserCustomer.Cart.ShoppingCartMenu(user, enemy, user.UserCustomer.Cart);
                        break;

                    case 4:
                        ExchangeBronze.Exchange(user);
                        break;

                    case 5:
                        user.MemberCard.UpgradeMemberShip(user.UserCustomer, user);
                        break;

                    case 6:
                        MenuOptions.Menu(user, enemy);
                        KeepShopping = false;
                        break;
                }
            } while (KeepShopping == true);
        }
    }
}
