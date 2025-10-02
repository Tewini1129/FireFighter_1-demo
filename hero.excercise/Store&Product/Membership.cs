using System;
using FireFighter_1.Menu_s;
using FireFighter_1.Store_Product;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireFighter_1
{
    public class Membership: Customer
    {
        public double CurrentDiscount;
        public string CurrentMemberShipLevel;
        public double NotMember = 1.00;
        public double BronzeMember = 0.95;
        public double SilverMember = 0.90;
        public double GoldMember = 0.85;
        

        public Membership()
        {
            CurrentDiscount = NotMember;
            CurrentMemberShipLevel = "Not a Member";

        }

        public void UpgradeMemberShip(Customer UserCustomer, Player user)
        {

            


            CurrentDiscount = Math.Round(CurrentDiscount, 2);


            switch (CurrentDiscount)
            {
                case 1.00:
                    if (user.Bronze >= 10)
                    {
                        user.Bronze -= 10;
                        StoreMethod.userWalletIn -= 10; 
                        CurrentDiscount = BronzeMember;
                        CurrentMemberShipLevel = "Bronze Member 5%";
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("Congratulations! You are now upgraded to BronzeMember");
                        Typewriter_Method.SlowType("---------------------\n", 90);
                        Console.ResetColor();

                    }
                    else
                    {
                        Console.WriteLine("You need more Bronze to upgrade your membership...");
                        Typewriter_Method.SlowType("---------------------\n", 90);
                    }
                    
                    break;

                case 0.95:
                    if (user.Silver >= 10)
                    {
                        user.Silver -= 10;
                        StoreMethod.userWalletIn -= 10;
                        CurrentDiscount = SilverMember;
                        CurrentMemberShipLevel = "Silver Member 10%";
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("Congratulations! You are now upgraded to SilverMember");
                        Typewriter_Method.SlowType("---------------------\n", 90);
                        Console.ResetColor();

                    }
                    else
                    {
                        Console.WriteLine("You need more Silver to upgrade your membership...");
                        Typewriter_Method.SlowType("---------------------\n", 90);
                    }

                    break;

                case 0.90:
                    if (user.Gold >= 10)
                    {
                        user.Gold -= 10;
                        StoreMethod.userWalletIn -= 10;
                        CurrentDiscount = GoldMember;
                        CurrentMemberShipLevel = "Gold Member 15%";
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Typewriter_Method.SlowType("---------------------\n", 90);
                        Console.WriteLine("Congratulations! You are now upgraded to GoldMember, the highest we offer!");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.WriteLine("You need more Gold to upgrade your membership...");
                        Typewriter_Method.SlowType("---------------------\n", 90);
                    }

                    break;

                case 0.85:
                    Console.WriteLine("You are alreadyhighest level, Gold Member");
                    Typewriter_Method.SlowType("---------------------\n", 90);
                    break;
            }
        }
        public double MembersPrice(double OriginalPrice)
        {
            double NewPrice = OriginalPrice * CurrentDiscount;
            NewPrice = Math.Round(NewPrice, 2);
            return NewPrice;
        }



    }
}
