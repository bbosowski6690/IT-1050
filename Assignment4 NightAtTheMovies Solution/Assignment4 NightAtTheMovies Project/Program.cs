﻿namespace Assignment4_NightAtTheMovies_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Ticket.TicketCount = 0;
            ConcessionStand.ConcessionCost = 0;
            Discount.DiscountAmount = 0;

            double TotalTicketCost = Ticket.GetTotalTicketCost();
            double TotalConessionCost = ConcessionStand.GetTotalConcessionCost();
            double TotalDiscountAmount = Discount.GetTotalDiscountAmount();
            double FinalTotalCost = TotalTicketCost + TotalConessionCost - TotalDiscountAmount;

            System.Console.WriteLine("Would you like to see a matinee or evening movie?");
            if (System.Console.ReadLine().ToLower().StartsWith("matinee"))
            {
                System.Console.WriteLine("How many adult tickets?");
                int inputInteger = int.Parse(System.Console.ReadLine());
                Ticket quantityAdultMatinee = new Ticket();
                inputInteger += Ticket.TicketCount;

                System.Console.WriteLine("How many child tickets?");
                inputInteger = int.Parse(System.Console.ReadLine());
                Ticket quantityChildMatinee = new Ticket();
                inputInteger += Ticket.TicketCount;

                System.Console.WriteLine("How many senior tickets?");
                inputInteger = int.Parse(System.Console.ReadLine());
                Ticket quantitySeniorMatinee = new Ticket();
                inputInteger += Ticket.TicketCount;
            }
            else
            {
                System.Console.WriteLine("How many adult tickets?");
                int inputInteger = int.Parse(System.Console.ReadLine());
                Ticket quantityAdultEvening = new Ticket();
                inputInteger += Ticket.TicketCount;

                System.Console.WriteLine("How many child tickets?");
                inputInteger = int.Parse(System.Console.ReadLine());
                Ticket quantityChildEvening = new Ticket();
                inputInteger += Ticket.TicketCount;

                System.Console.WriteLine("How many senior tickets?");
                inputInteger = int.Parse(System.Console.ReadLine());
                Ticket quantitySeniorEvening = new Ticket();
                inputInteger += Ticket.TicketCount;

            }

            System.Console.WriteLine("Would you like anything from the concession stand?");
            System.Console.ReadLine();

            if (System.Console.ReadLine().ToLower().StartsWith("y"))
            {
                System.Console.WriteLine("One small soda is $" + ConcessionStand.priceSmallSoda + " ");
                System.Console.WriteLine("How many would you like?");
                double inputConcessionInteger = double.Parse(System.Console.ReadLine());
                ConcessionStand SmallSoda = new ConcessionStand();
                ConcessionStand.ConcessionCost += (ConcessionStand.SmallSoda * ConcessionStand.priceSmallSoda);

                System.Console.WriteLine("One large soda is $" + ConcessionStand.priceLargeSoda + " ");
                System.Console.WriteLine("How many would you like?");
                inputConcessionInteger = double.Parse(System.Console.ReadLine());
                ConcessionStand LargeSoda = new ConcessionStand();
                ConcessionStand.ConcessionCost += (ConcessionStand.LargeSoda * ConcessionStand.priceLargeSoda);

                System.Console.WriteLine("One hot dog is $" + ConcessionStand.priceHotDog + " ");
                System.Console.WriteLine("How many would you like?");
                inputConcessionInteger = double.Parse(System.Console.ReadLine());
                ConcessionStand HotDog = new ConcessionStand();
                ConcessionStand.ConcessionCost += (ConcessionStand.HotDog * ConcessionStand.priceHotDog);

                System.Console.WriteLine("One bag of popcorn is $" + ConcessionStand.pricePopcorn + " ");
                System.Console.WriteLine("How many would you like?");
                inputConcessionInteger = double.Parse(System.Console.ReadLine());
                ConcessionStand Popcorn = new ConcessionStand();
                ConcessionStand.ConcessionCost += (ConcessionStand.Popcorn * ConcessionStand.pricePopcorn);

                System.Console.WriteLine("One box of candy is $" + ConcessionStand.priceCandy + " ");
                System.Console.WriteLine("How many would you like?");
                inputConcessionInteger = double.Parse(System.Console.ReadLine());
                ConcessionStand Candy = new ConcessionStand();
                ConcessionStand.ConcessionCost += (ConcessionStand.Candy * ConcessionStand.priceCandy);
            }

            else
            {
                System.Console.WriteLine("Press Any Key To Continue to Your Final Total");
            }

            System.Console.WriteLine("Your final total is $" + FinalTotalCost + ".");
            System.Console.WriteLine(" ");
            System.Console.WriteLine("Thank you for your purchase and enjoy your movie!");
            System.Console.WriteLine(" ");
            System.Console.WriteLine("Please press any key to continue");
            System.Console.ReadKey();


        }
    }
}

    

