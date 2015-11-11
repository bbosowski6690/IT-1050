using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4_NightAtTheMovies_Project
{
    class ConcessionStand
    {
        public static double ConcessionCost;

        public const double priceSmallSoda = 3.50;
        public const double priceLargeSoda = 5.99;
        public const double priceHotDog = 3.99;
        public const double pricePopcorn = 4.50;
        public const double priceCandy = 1.99;

        public static int SmallSoda = 0;
        public static int LargeSoda = 0;
        public static int HotDog = 0;
        public static int Popcorn = 0;
        public static int Candy = 0;


        public static double GetTotalConcessionCost()
        {
            
            double ConcessionCost = 0;
            bool isConcessionStand = false;
            if (isConcessionStand)
            {
                ConcessionCost = (SmallSoda * priceSmallSoda) + (LargeSoda * priceLargeSoda) + (HotDog * priceHotDog) + (Popcorn * pricePopcorn) + (Candy * priceCandy);
            }

            return ConcessionCost;


        }
    }
}