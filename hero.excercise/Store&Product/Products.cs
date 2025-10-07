using System;
using FireFighter_1.Menu_s;
using FireFighter_1;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireFighter_1.Store_Product
{
    public abstract class Products
    {


        public string Name;
        public double Price;
        private static int allProducts;
        public static int AllProducts
        {
            get { return allProducts; }
            set { allProducts = value; }
        }


        public Products()
        {
            AllProducts++;
        }


        public abstract bool InventoryChecker();

        public abstract void RemoveFromStoreList();

        public void AddToCart(Player user)
        {
            if (InventoryChecker() == false)
            {
                Console.WriteLine($"We are out of {Name}, sorry");
                Typewriter_Method.SlowType("-----------------", 90);

            }
            else
            {
                user.UserCustomer.Cart.itemsInCart[Name] += 1;
                RemoveFromStoreList();
                user.UserCustomer.Cart.Total += (user.MemberCard.MembersPrice(Price));
            }
        }


    }
}
