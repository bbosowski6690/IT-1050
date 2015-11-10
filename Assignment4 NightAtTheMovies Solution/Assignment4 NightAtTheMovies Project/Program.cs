namespace Assignment4_NightAtTheMovies_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Ticket.TicketCount = 0;
            ConcessionStand.ConcessionCost = 0;

            double TotalTicketCost = Ticket.GetTotalTicketCost();
            double TotalConessionCost = ConcessionStand.GetTotalConcessionCost();
            double TotalDiscountAmount = Discount.GetTotalDiscountAmount();
            double FinalTotalCost = TotalTicketCost + TotalConessionCost - TotalDiscountAmount;
            
            MessageFromComputer("Would you like to see a matinee or evening movie?");
            if (System.Console.ReadLine().ToLower().StartsWith("matinee"))
            {
                MessageFromComputer("How many adult tickets?");
                int inputInteger = int.Parse(System.Console.ReadLine());
                Ticket quantityAdultMatinee = new Ticket();
                inputInteger += Ticket.TicketCount;

                MessageFromComputer("How many child tickets?");
                inputInteger = int.Parse(System.Console.ReadLine());
                Ticket quantityChildMatinee = new Ticket();
                inputInteger += Ticket.TicketCount;

                MessageFromComputer("How many senior tickets?");
                inputInteger = int.Parse(System.Console.ReadLine());
                Ticket quantitySeniorMatinee = new Ticket();
                inputInteger += Ticket.TicketCount;
            }
            else
            {
                MessageFromComputer("How many adult tickets?");
                int inputInteger = int.Parse(System.Console.ReadLine());
                Ticket quantityAdultEvening = new Ticket();
                inputInteger += Ticket.TicketCount;

                MessageFromComputer("How many child tickets?");
                inputInteger = int.Parse(System.Console.ReadLine());
                Ticket quantityChildEvening = new Ticket();
                inputInteger += Ticket.TicketCount;

                MessageFromComputer("How many senior tickets?");
                inputInteger = int.Parse(System.Console.ReadLine());
                Ticket quantitySeniorEvening = new Ticket();
                inputInteger += Ticket.TicketCount;

            }

            MessageFromComputer("Would you like anything from the concession stand?");
            System.Console.ReadLine();

            if (System.Console.ReadLine().ToLower().StartsWith("y"))
            {
                MessageFromComputer("One small soda is $" + ConcessionStand.priceSmallSoda + " ");
                MessageFromComputer("How many would you like?");
                double inputConcessionInteger = double.Parse(System.Console.ReadLine());
                ConcessionStand SmallSoda = new ConcessionStand();
                ConcessionStand.ConcessionCost += (SmallSoda * priceSmallSoda);

                MessageFromComputer("One large soda is $" + ConcessionStand.priceLargeSoda + " ");
                MessageFromComputer("How many would you like?");
                inputConcessionInteger = double.Parse(System.Console.ReadLine());
                ConcessionStand LargeSoda = new ConcessionStand();
                ConcessionStand.ConcessionCost += (LargeSoda * priceLargeSoda);

                MessageFromComputer("One hot dog is $" + ConcessionStand.priceHotDog + " ");
                MessageFromComputer("How many would you like?");
                inputConcessionInteger = double.Parse(System.Console.ReadLine());
                ConcessionStand HotDog = new ConcessionStand();
                ConcessionStand.ConcessionCost += (HotDog * priceHotdog);

                MessageFromComputer("One bag of popcorn is $" + ConcessionStand.pricePopcorn + " ");
                MessageFromComputer("How many would you like?");
                inputConcessionInteger = double.Parse(System.Console.ReadLine());
                ConcessionStand Popcorn = new ConcessionStand();
                ConcessionStand.ConcessionCost += (Popcorn * pricePopcorn);

                MessageFromComputer("One box of candy is $" + ConcessionStand.priceCandy + " ");
                MessageFromComputer("How many would you like?");
                inputConcessionInteger = double.Parse(System.Console.ReadLine());
                ConcessionStand Candy = new ConcessionStand();
                ConcessionStand.ConcessionCost += (Candy * priceCandy);
            }

            else
            {
                System.Console.WriteLine("Press Any Key To Continue to Your Final Total");
            }



            

       
        private static void MessageFromComputer(string text)
        {
            System.Console.WriteLine();
            System.Console.WriteLine(" " + text);
            System.Console.WriteLine();
            System.Console.Write(" ");
        }

        private static void YourFinalTotal()
        {
            System.Console.WriteLine("Your final total is $" + FinalTotalCost + ".");
            System.Console.WriteLine(" ");
            System.Console.WriteLine("Thank you for your purchase and enjoy your movie!");
            System.Console.WriteLine(" ");
            System.Console.WriteLine("Please press any key to continue");
            System.Console.ReadKey();
        }

        
    }
    
}
}
    

