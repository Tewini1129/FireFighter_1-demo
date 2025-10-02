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



        Redbull r1 = new Redbull();
        Redbull r2 = new Redbull();
        Redbull r3 = new Redbull();

        public static List<Redbull> redbulls = new List<Redbull>()
            {
                new Redbull(),
                new Redbull(),
                new Redbull()
            };





        HealthPotion h1 = new HealthPotion();
        HealthPotion h2 = new HealthPotion();
        HealthPotion h3 = new HealthPotion();

        public static List<HealthPotion> healthPotions = new List<HealthPotion>()
            {
                new HealthPotion(),
                new HealthPotion(),
                new HealthPotion()
            };



        AdollaLink a1 = new AdollaLink();
        AdollaLink a2 = new AdollaLink();
        AdollaLink a3 = new AdollaLink();

        public static List<AdollaLink> adollaLink = new List<AdollaLink>()
            {
                new AdollaLink(),
                new AdollaLink(),
                new AdollaLink()
            };




        public static int CurrencyMultiplyer;
        public static void ChooseCurrency()
        {
            
            string Prompt = "==== Choose Your Currency ====";
            string[] Options = { "Gold", "Silver", "Bronze" };
            FunMenu CurrencyMenu = new FunMenu(Prompt, Options);
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
            Typewriter_Method.SlowType($"\n\nShopping Cart Total: {user.UserCustomer.Cart.Total * CurrencyMultiplyer} {currency} coins");




            
            //Current amount of gold
            if (currency == "Gold")
            {
                
                Typewriter_Method.SlowType($"\nYour currently have {user.Gold} {currency} coins");
                userWalletIn = user.Gold;
            }
            else if (currency == "Silver")
            {
                Typewriter_Method.SlowType($"\n\nYour currently have {user.Silver} {currency} coins");
                userWalletIn = user.Silver;
            }
            else if (currency == "Bronze")
            {
                Typewriter_Method.SlowType($"\n\nYour currently have {user.Bronze} {currency} coins");
                userWalletIn = user.Bronze;
            }
            Introduction.Continue = false;

            do
            { 
                
                //Menu
                string Prompt = (
                        $"\n---------------------------\n\nStore manager - \"Welcome to store\"" +
                        $"\n\nStore Manager - \"Here is a list of our current items in Stock\"" +
                        $"\n\n\t1.Redbull 500ml (Max Shield)" +
                        $"\n\t2.Healing Potion 250ml (Max Health and Energy)" +
                        $"\n\t3.Adolla Link (Max All)" +
                        $"\n\nShopping Cart Total: {user.UserCustomer.Cart.Total * CurrencyMultiplyer} {currency} coins" +
                        $"\n\nYour currently have {userWalletIn} {currency} coins"
                    );

                string[] StoreItems = { 
                    $"Redbull 500ml - {user.MemberCard.MembersPrice(Redbull.Price * CurrencyMultiplyer)} {currency}", 
                    $"Healing Potion 250ml - {user.MemberCard.MembersPrice(HealthPotion.Price * CurrencyMultiplyer)} {currency}", 
                    $"Adolla Link - {user.MemberCard.MembersPrice(AdollaLink.Price * CurrencyMultiplyer)} {currency}", 
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

                        if (Redbull.InStock == false)
                        {
                            Console.WriteLine("We are out of Redbull, sorry");
                            Typewriter_Method.SlowType("-----------------", 90);
                        }
                        else
                        {

                            user.UserCustomer.Cart.itemsInCart[ShoppingCart.redbullLabel] += 1;
                            user.UserCustomer.Cart.redbullInCart += 1;
                            redbulls[0].InventoryChecker();
                            redbulls.RemoveAt(0);
                            user.UserCustomer.Cart.Total += (user.MemberCard.MembersPrice(Redbull.Price));
                            
                        }
                        break;
                    case 1:
                        if (HealthPotion.InStock == false)
                        {
                            Console.WriteLine("We are out of Health Potion's, sorry");
                            Typewriter_Method.SlowType("-----------------", 90);

                        }
                        else
                        {
                            user.UserCustomer.Cart.itemsInCart[ShoppingCart.healthPotionLabel] += 1;
                            user.UserCustomer.Cart.healthPotionInCart += 1;
                            healthPotions[0].InventoryChecker();
                            healthPotions.RemoveAt(0);
                            user.UserCustomer.Cart.Total += (user.MemberCard.MembersPrice(HealthPotion.Price));
                        }
                        break;

                    case 2:
                        if (AdollaLink.InStock == false)
                        {
                            Console.WriteLine("We are out of Adolla Links, sorry");
                            Typewriter_Method.SlowType("-----------------", 90);

                        }
                        else
                        {
                            user.UserCustomer.Cart.itemsInCart[ShoppingCart.adollaLinkLabel] += 1;
                            user.UserCustomer.Cart.adollaLinkInCart += 1;
                            adollaLink[0].InventoryChecker();
                            adollaLink.RemoveAt(0);
                            user.UserCustomer.Cart.Total += (user.MemberCard.MembersPrice(AdollaLink.Price));
                        }
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
