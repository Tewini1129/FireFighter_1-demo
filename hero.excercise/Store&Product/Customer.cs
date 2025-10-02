using System;
using FireFighter_1;
using FireFighter_1.Menu_s;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireFighter_1.Store_Product
{
    public class Customer
    {
        
        public ShoppingCart Cart = new ShoppingCart();
        public Customer()
        {
            
        }

        public override string ToString()
        {
            string Items = "";
            Player user = LogIn.currentUser;
            
            if ((user.UserCustomer.Cart.itemsInCart["Redbull 500ml  "] <= 0)&&
                (user.UserCustomer.Cart.itemsInCart["Health Potion  "] <= 0)&&
                (user.UserCustomer.Cart.itemsInCart["Adolla Link  "] <= 0))
            {
                Items = "Empty...";
            }
            else
            {
                foreach (var item in user.UserCustomer.Cart.itemsInCart)
                {
                    if (item.Value > 0)
                    {
                        Items += $"   {item.Value}x {item.Key}\n";
                    }
                }
            }
            
            return $"\n\n---<====)( Account Info )(====>----\n" +
                $"\nUsername: {user.Name}\n" +
                $"Password: {user.IdCode}\n" +
                $"MemberShip Level: {user.MemberCard.CurrentMemberShipLevel}\n" +
                $"\n\nShopping Cart:\n\n" +
                $"   {Items}\n" +
                $"  >>>-------<==========>-------<<<";
        }

    }
}
