using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4_NightAtTheMovies_Project
{
    class Discount
    {
       
        public static double DiscountAmount;
       
        public double DiscountB = 0;
        public double DiscountC = 0;
        
        public static double GetTotalDiscountAmount()
        {
            double DiscountA = 0;
            double DiscountB = 0;
            double DiscountC = 0;
            double DiscountAmount = 0;
            bool isDiscount = false;
            if (isDiscount)
            {
                if (Ticket.TicketCount >= 3)
                {
                    DiscountA = (Ticket - 4.50);
                }
                
                if (ConcessionStand.LargeSoda < ConcessionStand.Popcorn)
                {
                    DiscountB = ConcessionStand.LargeSoda * 2;
                }
                else if (ConcessionStand.Popcorn < ConcessionStand.LargeSoda)
                {
                    DiscountB = ConcessionStand.Popcorn * 2;
                }
                else
                {
                    DiscountB = ConcessionStand.Popcorn * 2;
                }

                if (ConcessionStand.Candy >= 4)
                {
                    DiscountC = (ConcessionStand.Candy / 4) * 1.99;
                }

            }

            return DiscountAmount;

            //Discounts & Promotions
            //Each purchase of a popcorn and a large soda grants a $2 discount on one movie ticket.
            //If 3 or more people purchase tickets to an evening show, they get 1 free bag of popcorn.
            //For each 3 candies you buy, you can get a 4th candy for free.
        }
    }
}
