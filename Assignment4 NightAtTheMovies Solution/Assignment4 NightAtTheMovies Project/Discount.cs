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

        public static double GetTotalDiscountAmount()
        {
            double DiscountAmount = 0;
            bool isDiscount = false;
            if (isDiscount)
            {
                if (ConcessionStand.LargeSoda < ConcessionStand.Popcorn)
                {
                    Discount1 = ConcessionStand.LargeSoda * 2;
                }
                else if (ConcessionStand.Popcorn < ConcessionStand.LargeSoda)
                {
                    Discount1 = ConcessionStand.Popcorn * 2;
                }
                else
                {
                    Discount1 = ConcessionStand.Popcorn * 2;
                }

                if (ConcessionStand.Candy >= 4)
                {
                    Discount3 = (Candy / 4) * 1.99;
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
