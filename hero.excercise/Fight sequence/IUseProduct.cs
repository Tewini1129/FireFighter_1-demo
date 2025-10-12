using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireFighter_1.Fight_sequence
{
    public interface IUseProduct
    {
        public void Use(Player user)
        {
            Console.WriteLine("You used an item");
        }
    }
}
