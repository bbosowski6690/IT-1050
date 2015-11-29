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
        
        public double DiscountTicket;
        public double DiscountPS2;
        public double DiscountCandy;
       
        

        public static double GetTotalDiscountAmount()
        {
            double DiscountTicket = 0;
            double DiscountPS2 = 0;
            double DiscountCandy = 0;
            double DiscountAmount = 0;
            
                if (Ticket.Count >= 3)
                {
                    DiscountTicket = ( - ConcessionStand.pricePopcorn);
                }

                if (ConcessionStand.LargeSoda >= 1 && ConcessionStand.Popcorn >= 1)
                {
                    DiscountPS2 = ( - 2);
                }

                if (ConcessionStand.Candy >= 3)
                {
                    DiscountCandy = ((ConcessionStand.Candy / 3) * 1.99);
                }


                return DiscountAmount;
            
        }

            //Discounts & Promotions
            //Each purchase of a popcorn and a large soda grants a $2 discount on one movie ticket.
            //If 3 or more people purchase tickets to an evening show, they get 1 free bag of popcorn.
            //For each 3 candies you buy, you can get a 4th candy for free.
        }

        
    }

