namespace Assignment4_NightAtTheMovies_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Ticket.TicketCount = 0;


            System.Console.WriteLine("Would you like to see a matinee or evening movie?");
            if (System.Console.ReadLine().ToLower().StartsWith("matinee"))
            {
                MessageFromComputer("How many adult tickets?");
                int inputInteger = int.Parse(System.Console.ReadLine());
                Ticket quantityAdultMatinee = new Ticket();
                inputInteger += Ticket.TicketCount;

                MessageFromComputer("How many adult tickets?");
                inputInteger = int.Parse(System.Console.ReadLine());
                Ticket quantityChildMatinee = new Ticket();
                inputInteger += Ticket.TicketCount;

                MessageFromComputer("How many adult tickets?");
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

                MessageFromComputer("How many adult tickets?");
                inputInteger = int.Parse(System.Console.ReadLine());
                Ticket quantityChildEvening = new Ticket();
                inputInteger += Ticket.TicketCount;

                MessageFromComputer("How many adult tickets?");
                inputInteger = int.Parse(System.Console.ReadLine());
                Ticket quantitySeniorEvening = new Ticket();
                inputInteger += Ticket.TicketCount;

            }


            double TotalTicketCost = Ticket.GetTotalTicketCost();

            double TotalConessionCost = ConcessionStand.GetTotalConcessionCost();

            double DiscountAmount = Discount.GetTotalDiscountAmount();

            double FinalTotalCost = TotalTicketCost + TotalConessionCost - DiscountAmount;

        }
        private static void MessageFromComputer(string text)
        {
            System.Console.WriteLine();
            System.Console.WriteLine(" " + text);
            System.Console.WriteLine();
            System.Console.Write(" ");
        }

        private static void YourFinalTotal(string text)
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
    

