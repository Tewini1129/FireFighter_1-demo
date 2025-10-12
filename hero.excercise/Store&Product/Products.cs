using System;
using FireFighter_1.Menu_s;
using FireFighter_1;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FireFighter_1.Fight_sequence;

namespace FireFighter_1.Store_Product
{
    public abstract class Products: IUseProduct
    {

        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private double price;
        public double Price
        {
            get { return price; }
            set { price = value; }
        }
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

        public abstract void Use(Player user);
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
                user.Cart.itemsInCart[Name] += 1;
                RemoveFromStoreList();
                user.Cart.Total += (Price);
            }
        }


    }
}
