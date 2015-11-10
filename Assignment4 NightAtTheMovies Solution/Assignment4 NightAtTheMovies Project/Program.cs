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
                

                    System.Console.WriteLine("How many children tickets?");
                    quantityChildMatinee = int.Parse(System.Console.ReadLine());
                    ChildMatinee.Pricing(NumberOfChildren);
                    TotalTicketPrice += ChildMatinee.TicketTotals();

                    System.Console.WriteLine("How many adult tickets?");
                    NumberOfAdults = int.Parse(System.Console.ReadLine());
                    AdultMatinee.Pricing(NumberOfAdults);
                    TotalTicketCost += quantityAdultMatinee.TicketTotals();

                    System.Console.WriteLine("How many senior tickets?");
                    NumberOfSeniors = int.Parse(System.Console.ReadLine());
                    SeniorMatinee.Pricing(NumberOfSeniors);
                    TotalTicketPrice += SeniorMatinee.TicketTotals();
                }
                else if (input == "2")
                {
                MessageFromComputer("How many adult tickets?")

                    System.Console.WriteLine("How many children tickets?");
                    NumberOfChildren = int.Parse(System.Console.ReadLine());
                    ChildEvening.Pricing(NumberOfChildren);
                    TotalTicketPrice += ChildEvening.TicketTotals();

                    System.Console.WriteLine("How many adult tickets?");
                    NumberOfAdults = int.Parse(System.Console.ReadLine());
                    AdultEvening.Pricing(NumberOfAdults);
                    TotalTicketPrice += AdultEvening.TicketTotals();

                    System.Console.WriteLine("How many senior tickets?");
                    NumberOfSeniors = int.Parse(System.Console.ReadLine());
                    SeniorEvening.Pricing(NumberOfSeniors);
                    TotalTicketPrice += SeniorEvening.TicketTotals();
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
    

