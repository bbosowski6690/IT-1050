using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4_NightAtTheMovies_Project
{
    public class Ticket
    {
        public enum TicketType {Adult, Child, Senior}
        public static int TicketCount;
        public bool isMatinee = false;

        private const double priceAdultMatinee = 5.99;
        private const double priceChildMatinee = 3.99;
        private const double priceSeniorMatinee = 4.50;
        private const double priceAdultEvening = 10.99;
        private const double priceChildEvening = 6.99;
        private const double priceSeniorEvening = 8.50;

        private static int quantityAdultMatinee = 0;
        public static int quantityChildMatinee = 0;
        private static int quantitySeniorMatinee = 0;
        private static int quantityAdultEvening = 0;
        private static int quantityChildEvening = 0;
        private static int quantitySeniorEvening = 0;

        public double GetTicketCost(TicketType ticketType, bool isMatinee)
        {
            switch(ticketType)
            {
                case TicketType.Adult: return isMatinee ? priceAdultMatinee : priceAdultEvening;
                case TicketType.Child: return isMatinee ? priceChildMatinee : priceChildEvening;
                case TicketType.Senior: return isMatinee ? priceSeniorMatinee : priceSeniorEvening;
                default: return 0;
            }

        }

        public static void GetTicketQuantities()
        { 
            TicketCount = 0;
            bool isMatinee = false;
            if (isMatinee)
                {
                quantityChildMatinee += TicketCount;
                quantityAdultMatinee += TicketCount;
                quantitySeniorMatinee += TicketCount;
            }
            else
            {
                quantityChildEvening += TicketCount;
                quantityAdultEvening += TicketCount;
                quantitySeniorEvening += TicketCount;
            }
        }
        public static double GetTotalTicketCost()
        {
            GetTicketQuantities();
            double TotalTicketCost = 0;
            bool isMatinee = false;
            if (isMatinee)
            {
                TotalTicketCost += (quantityAdultMatinee * priceAdultMatinee) + (quantityChildMatinee * priceChildMatinee) + (quantitySeniorMatinee * priceSeniorMatinee);
            }
            else
            {
                TotalTicketCost += (quantityAdultEvening * priceAdultEvening) + (quantityChildEvening * priceChildEvening) + (quantitySeniorEvening * priceSeniorEvening);
            }

            return TotalTicketCost;

        }
        


    }
}
