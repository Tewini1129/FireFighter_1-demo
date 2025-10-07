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
        public int nrItemsInCart;
        public double currentPrice;
        public Dictionary<string, int> itemsInCart;
        Dictionary<string, (Products p, double price, List<Products> itemList)> StoreProducts;

        //Reference products
        public static Redbull r1 = new Redbull();
        public static HealthPotion h1 = new HealthPotion();
        public static AdollaLink a1 = new AdollaLink();


        public static string redbullLabel = $"{r1.Name}";
        public static string healthPotionLabel = $"{h1.Name}";
        public static string adollaLinkLabel = $"{a1.Name}";


        public ShoppingCart()
        {
            itemsInCart = new Dictionary<string, int>()
            {
                { redbullLabel, 0 },
                { healthPotionLabel, 0 },
                { adollaLinkLabel, 0 }
            };

            StoreProducts = new()
            {
                { r1.Name, (r1, r1.Price, StoreMethod.redbulls)  },
                { h1.Name,(h1, h1.Price, StoreMethod.healthPotions) },
                { a1.Name,(a1, a1.Price, StoreMethod.adollaLink)}
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




            bool leave = false;
            while (!leave)
            {
                //sets the options to items in cart
                
                nrItemsInCart = itemsInCart.Values.Sum();
                int nrOfOption = 2;
                foreach (var item in itemsInCart)
                {
                    if (item.Value > 0)
                    {
                        Options[nrOfOption] = ($"{item.Value}x {item.Key}");
                        nrOfOption++;
                    }
                }

                int PositionOfRedbull = Array.FindIndex(Options, s => s != null && s.Contains($"{itemsInCart[redbullLabel]}x {redbullLabel}"));
                if (PositionOfRedbull > 0)
                {
                    Options[PositionOfRedbull] = $"{itemsInCart[redbullLabel]}x {redbullLabel} {user.MemberCard.MembersPrice(r1.Price * StoreMethod.CurrencyMultiplyer)} {StoreMethod.currency}";
                }

                int PositionOfHealthPotion = Array.FindIndex(Options, s => s != null && s.Contains($"{itemsInCart[healthPotionLabel]}x {healthPotionLabel}"));
                if (PositionOfHealthPotion > 0)
                {
                    Options[PositionOfHealthPotion] = $"{itemsInCart[healthPotionLabel]}x {healthPotionLabel} {user.MemberCard.MembersPrice(h1.Price * StoreMethod.CurrencyMultiplyer)} {StoreMethod.currency}";
                }

                int PositionOfAdollaLink = Array.FindIndex(Options, s => s != null && s.Contains($"{itemsInCart[adollaLinkLabel]}x {adollaLinkLabel}"));
                if (PositionOfAdollaLink > 0)
                {
                    Options[PositionOfAdollaLink] = $"{itemsInCart[adollaLinkLabel]}x {adollaLinkLabel} {user.MemberCard.MembersPrice(a1.Price * StoreMethod.CurrencyMultiplyer)} {StoreMethod.currency}";
                }


                if (!Options.Contains("Continue shopping"))
                {
                    Options[0] = ("Continue shopping");
                    Options[1] = ($"Checkout Total: {user.MemberCard.MembersPrice(Cart.Total * StoreMethod.CurrencyMultiplyer)} {StoreMethod.currency}  ||  {nrItemsInCart}x Items in cart");
                }


                Console.Clear();
                string Prompt = $"\n\t----<====== Shopping Cart ======>----\n\nChoose a item to remove from your ShoppingCart\n";

                FunMenu CartMenu = new(Prompt, Options);
                CartMenu.Run();

                //Player removes item in cart
                if (CartMenu.SelectedIndex > 1)
                {
                    RemoveItem(CartMenu,user, StoreProducts);
                    ShoppingCartMenu(user, enemy, Cart);
                    leave = true;
                }

                //Player chose Checkout
                else if (CartMenu.SelectedIndex == 1)
                {
                    if ((Cart.Total * StoreMethod.CurrencyMultiplyer) <= user.Wallet[StoreMethod.currency])
                    {
                        user.Wallet[StoreMethod.currency] -= (Cart.Total * StoreMethod.CurrencyMultiplyer);
                        Typewriter_Method.SlowType($"-{Cart.Total} {StoreMethod.currency}\n");
                        Cart.Total = 0;

                        for (int i = 0; i < itemsInCart[redbullLabel]; i++)
                        {
                            user.inventory[redbullLabel]++;

                        }

                        for (int i = 0; i < itemsInCart[healthPotionLabel]; i++)
                        {
                            user.inventory[healthPotionLabel]++;
                        }

                        for (int i = 0; i < itemsInCart[adollaLinkLabel]; i++)
                        {
                            user.inventory[adollaLinkLabel]++;
                        }


                        Cart.itemsInCart[redbullLabel] = 0;
                        Cart.itemsInCart[healthPotionLabel] = 0;
                        Cart.itemsInCart[adollaLinkLabel] = 0;


                        Typewriter_Method.SlowType("You chose to checkout");
                        Typewriter_Method.SlowType("\n---------------------------\n", 90);
                        leave = true;

                    }
                    else
                    {
                        Console.WriteLine($"You do not have enough {StoreMethod.currency}...\nRemove items to checkout");
                        Typewriter_Method.SlowType("\n---------------------------\n", 90);


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
        public void RemoveItem(FunMenu CartMenu, Player user, Dictionary<string, (Products p, double price, List<Products> itemList)> StoreProducts)
        {
            foreach (var item in StoreProducts)
            {
                
                if (CartMenu.Options[CartMenu.SelectedIndex].Contains($"{itemsInCart[item.Value.p.Name]}x {item.Value.p.Name} {user.MemberCard.MembersPrice(item.Value.price * StoreMethod.CurrencyMultiplyer)} {StoreMethod.currency}"))
                {
                    item.Value.itemList.Add(new Redbull());
                    itemsInCart[item.Value.p.Name] -= 1;
                    Total -= user.MemberCard.MembersPrice(item.Value.price);
                }
            }
        }
    }
}
