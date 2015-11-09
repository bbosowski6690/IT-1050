namespace Assignment4_NightAtTheMovies_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            ShowMainMenu();

            string command = System.Console.ReadLine();

            if (command == "1")
            {
            }

            else if (command == "2")
            {
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
   

    }
    }
    

