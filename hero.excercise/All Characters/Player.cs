using FireFighter_1.Menu_s;
using FireFighter_1.Store_Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireFighter_1
{

    public class Player
    {


        //Stats
        public string? Name { get; set; }
        public string IdCode { get; set; }
        public int PowerClass{ get; set; }
        public int OriginalHp { get; set; }
        public int MaxHp{ get; set; }
        public int Hp { get; set; }
        public int Shield { get; set; }
        public int MaxShield { get; set; }
        public int MaxEnergyLevel { get; set; }
        public int EnergyLevel { get; set; }
        public int OriginalDamage { get; set; }
        public int RegulareDamage { get; set; }
        public Dictionary<string, double> Wallet { get; set; } = null;

       
        public int Progress { get; set; }

        public Membership MemberCard = new Membership();
        public Customer UserCustomer = new Customer();
        public Dictionary<string, int> inventory { get; set; } = new Dictionary<string, int>()
        {
            { "Redbull 500ml  ", 0},
            { "Health Potion  ", 0},
            { "Adolla Link  ", 0}
        };



        //Constructor
        public Player()
        {
            Name = Introduction.name;
            Wallet = new()
            {
                { "Gold", 0 },
                { "Silver", 0},
                { "Bronze", 0 },
            };
        }

        
    }
}





       

        
    





