using FireFighter_1;
using FireFighter_1.Menu_s;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace FireFighter_1.Store_Product
{
    public class ShoppingCart
    {
        public double Total;
        public int redbullInCart = 0;
        public int healthPotionInCart = 0;
        public int adollaLinkInCart = 0;
        public double currentPrice;
        public Dictionary<string, int> itemsInCart;


        public static string redbullLabel = $"{Redbull.Name}";
        
        public static string healthPotionLabel = $"{HealthPotion.Name}";
        
        public static string adollaLinkLabel = $"{AdollaLink.Name}";





        public ShoppingCart()
        {
            itemsInCart = new Dictionary<string, int>()
            {
                { ("Redbull 500ml  "), 0 },
                { "Health Potion  ", 0 },
                { "Adolla Link  ", 0 }
            };
        }


        public void ShoppingCartMenu(Player user, Enemy enemy, ShoppingCart Cart)
        {
            int CartOptions = 0;
            foreach(var item in Cart.itemsInCart)
            {
                if (item.Value > 0)
                {
                    CartOptions++;
                }
            }
           
            string[] Options = new string[CartOptions + 2];


                //sets the options to items in cart
                
            int nrOfOption = 2;
            foreach (var item in itemsInCart)
            {

                if (item.Value > 0)
                {
                    Options[nrOfOption] = ($"{item.Value}x {item.Key}");
                    nrOfOption++;
                }

            }


            bool leave = false;
            while (leave == false)
            {



                

                int PositionOfRedbull = Array.FindIndex(Options, s => s != null && s.Contains($"{redbullInCart}x {Redbull.Name}"));
                if (PositionOfRedbull > 0)
                {
                    Options[PositionOfRedbull] = $"{redbullInCart}x {redbullLabel} {user.MemberCard.MembersPrice(Redbull.Price * StoreMethod.CurrencyMultiplyer)} {StoreMethod.currency}";
                }





                int PositionOfHealthPotion = Array.FindIndex(Options, s => s != null && s.Contains($"{healthPotionInCart}x {HealthPotion.Name}"));

                if (PositionOfHealthPotion > 0)
                {
                    Options[PositionOfHealthPotion] = $"{healthPotionInCart}x {healthPotionLabel} {user.MemberCard.MembersPrice(HealthPotion.Price * StoreMethod.CurrencyMultiplyer)} {StoreMethod.currency}";
                }





                int PositionOfAdollaLink = Array.FindIndex(Options, s => s != null && s.Contains($"{adollaLinkInCart}x {AdollaLink.Name}"));

                if (PositionOfAdollaLink > 0)
                {
                    Options[PositionOfAdollaLink] = $"{adollaLinkInCart}x {adollaLinkLabel} {user.MemberCard.MembersPrice(AdollaLink.Price * StoreMethod.CurrencyMultiplyer)} {StoreMethod.currency}";
                }




                if (!Options.Contains("Continue shopping"))
                {
                    Options[0] = ("Continue shopping");
                    Options[1] = ($"Checkout Total: {user.MemberCard.MembersPrice(Cart.Total * StoreMethod.CurrencyMultiplyer)} {StoreMethod.currency}");
                }


                Console.Clear();
                string Prompt = $"\n\t----<====== Shopping Cart ======>----\n\nChoose a item to remove from your ShoppingCart\n";

                FunMenu CartMenu = new FunMenu(Prompt, Options);
                CartMenu.Run();

                //Player removes item in cart
                if (CartMenu.SelectedIndex > 1)
                {
                    if (CartMenu.Options[CartMenu.SelectedIndex].Contains($"{redbullInCart}x {Redbull.Name} {user.MemberCard.MembersPrice(Redbull.Price * StoreMethod.CurrencyMultiplyer)} {StoreMethod.currency}"))
                    {
                        StoreMethod.redbulls.Add(new Redbull());
                        redbullInCart -= 1;
                        Cart.Total -= user.MemberCard.MembersPrice(Redbull.Price);
                        Cart.itemsInCart["Redbull 500ml -"] -= 1;
                        leave = true;
                        ShoppingCartMenu(user, enemy, Cart);
                    }
                    else if (CartMenu.Options[CartMenu.SelectedIndex].Contains($"{healthPotionInCart}x {HealthPotion.Name} {user.MemberCard.MembersPrice(HealthPotion.Price * StoreMethod.CurrencyMultiplyer)} {StoreMethod.currency}"))
                    {
                        StoreMethod.healthPotions.Add(new HealthPotion());
                        healthPotionInCart -= 1;
                        Cart.Total -= user.MemberCard.MembersPrice(HealthPotion.Price);
                        Cart.itemsInCart["Health Potion -"] -= 1;
                        leave = true;
                        ShoppingCartMenu(user, enemy, Cart);
                    }
                    else if (CartMenu.Options[CartMenu.SelectedIndex].Contains($"{adollaLinkInCart}x {AdollaLink.Name} {user.MemberCard.MembersPrice(AdollaLink.Price * StoreMethod.CurrencyMultiplyer)} {StoreMethod.currency}"))
                    {
                        StoreMethod.adollaLink.Add(new AdollaLink());
                        adollaLinkInCart -= 1;
                        Cart.Total -= user.MemberCard.MembersPrice(AdollaLink.Price);
                        Cart.itemsInCart["Adolla Link -"] -= 1;
                        leave = true;
                        ShoppingCartMenu(user, enemy, Cart);
                    }
                }

                //Player chose Checkout
                else if (CartMenu.SelectedIndex == 1)
                {
                    switch (StoreMethod.currency)
                    {
                        case "Gold":
                            if ((Cart.Total * StoreMethod.CurrencyMultiplyer) <= user.Gold)
                            {
                                user.Gold -= (Cart.Total * StoreMethod.CurrencyMultiplyer);
                                Typewriter_Method.SlowType($"-{Cart.Total} gold\n");
                                Cart.Total = 0;

                                for (int i = 0; i < redbullInCart; i++)
                                {
                                    user.inventory["Redbull"]++;

                                }

                                for (int i = 0; i < healthPotionInCart; i++)
                                {
                                    user.inventory["Health Potion"]++;
                                }

                                for (int i = 0; i < adollaLinkInCart; i++)
                                {
                                    user.inventory["Adolla Link"]++;
                                }


                                Cart.itemsInCart[redbullLabel] = 0;
                                Cart.itemsInCart[healthPotionLabel] = 0;
                                Cart.itemsInCart[adollaLinkLabel] = 0;

                                StoreMethod.userWalletIn = 0;

                                Typewriter_Method.SlowType("You chose to checkout");
                                Typewriter_Method.SlowType("\n---------------------------\n", 90);
                                leave = true;

                            }
                            else
                            {
                                Console.WriteLine($"You do not have enough {StoreMethod.currency}...\nRemove items to checkout");
                                Typewriter_Method.SlowType("\n---------------------------\n", 90);


                            }
                            break;

                        case "Silver":
                            if ((Cart.Total * StoreMethod.CurrencyMultiplyer) <= user.Silver)
                            {
                                user.Silver -= (Cart.Total * StoreMethod.CurrencyMultiplyer);
                                Typewriter_Method.SlowType($"-{Cart.Total * StoreMethod.CurrencyMultiplyer} Silver\n");
                                Cart.Total = 0;



                                for (int i = 0; i < redbullInCart; i++)
                                {
                                    user.inventory["Redbull"]++;
                                }

                                for (int i = 0; i < healthPotionInCart; i++)
                                {
                                    user.inventory["Health Potion"]++;
                                }

                                for (int i = 0; i < adollaLinkInCart; i++)
                                {
                                    user.inventory["Adolla Link"]++;
                                }


                                Cart.itemsInCart[redbullLabel] = 0;
                                Cart.itemsInCart[healthPotionLabel] = 0;
                                Cart.itemsInCart[adollaLinkLabel] = 0;

                                StoreMethod.userWalletIn = 0;


                                Typewriter_Method.SlowType("You chose to checkout");
                                Typewriter_Method.SlowType("\n---------------------------\n", 90);
                                leave = true;

                            }
                            else
                            {
                                Console.WriteLine($"You do not have enough {StoreMethod.currency}...\nRemove items to checkout");
                                Typewriter_Method.SlowType("\n---------------------------\n", 90);


                            }
                            break;

                        case "Bronze":
                            if ((Cart.Total * StoreMethod.CurrencyMultiplyer) <= user.Bronze)
                            {
                                user.Bronze -= (Cart.Total * StoreMethod.CurrencyMultiplyer);
                                Typewriter_Method.SlowType($"-{Cart.Total * StoreMethod.CurrencyMultiplyer} Bronze\n");
                                Cart.Total = 0;


                                for (int i = 0; i < redbullInCart; i++)
                                {
                                    user.inventory["Redbull"]++;
                                }

                                for (int i = 0; i < healthPotionInCart; i++)
                                {
                                    user.inventory["Health Potion"]++;
                                }

                                for (int i = 0; i < adollaLinkInCart; i++)
                                {
                                    user.inventory["Adolla Link"]++;
                                }


                                Cart.itemsInCart[redbullLabel] = 0;
                                Cart.itemsInCart[healthPotionLabel] = 0;
                                Cart.itemsInCart[adollaLinkLabel] = 0;

                                StoreMethod.userWalletIn = 0;


                                Typewriter_Method.SlowType("You chose to checkout");
                                Typewriter_Method.SlowType("\n---------------------------\n", 90);
                                leave = true;

                            }
                            else
                            {
                                Console.WriteLine($"You do not have enough {StoreMethod.currency}...\nRemove items to checkout");
                                Typewriter_Method.SlowType("\n---------------------------\n", 90);


                            }
                            break;

                    }

                }
                //Player continues shopping
                else if (CartMenu.SelectedIndex == 0)
                {
                    Typewriter_Method.SlowType("Going back to store");
                    Typewriter_Method.SlowType("\n---------------------------\n", 90);

                    StoreMethod.Store(user, enemy);
                    leave = true;
                }
            }
                
            
        }
    }
}
