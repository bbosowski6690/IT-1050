namespace Assignment4_NightAtTheMovies_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Ticket.TicketCount = 0;
            ShowMainMenu();

            string input = System.Console.ReadLine();

            if (input == "1")
            {
                MessageFromComputer("How many adult tickets?");

                int.Parse(System.Console.ReadLine());

                MessageFromComputer("How many child tickets?");

                int.Parse(System.Console.ReadLine());

                MessageFromComputer("How many senior tickets?");

                int.Parse(System.Console.ReadLine());


            }
                else if (input == "2")
                {
                MessageFromComputer("How many adult tickets?");

                int.Parse(System.Console.ReadLine());

                MessageFromComputer("How many child tickets?");

                int.Parse(System.Console.ReadLine());

                MessageFromComputer("How many senior tickets?");

                int.Parse(System.Console.ReadLine());



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

        private static void ShowMainMenu()
        {
            System.Console.WriteLine();
            System.Console.WriteLine(" +-------------------------------------------+ ");
            System.Console.WriteLine("      When would you like to see a movie?:     ");
            System.Console.WriteLine(" +-------------------------------------------+ ");
            System.Console.WriteLine("   (1) - Evening ");
            System.Console.WriteLine("   (2) - Matinee ");
            System.Console.WriteLine(" +-------------------------------------------+ ");
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
    

