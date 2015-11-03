namespace Assignment_4_ANightAtTheMovies_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            MessageFromComputer("Hello! Welcome to the CinemaPlex!");
            System.Console.WriteLine("");
            MessageFromComputer("Would you like to see a matinee or evening movie?");

            string command = System.Console.ReadLine();


            if (command.ToLower().Contains("matinee"))
            {
                MessageFromComputer("How many adults?");
                double inputInteger = double.Parse(System.Console.ReadLine());
                if (inputInteger > 0)
                {
                    double AdultMatineeTicket = 5.99;
                    double TotalAdultMatinee = (AdultMatineeTicket * inputInteger);
                }
                else
                {
                    MessageFromComputer("No adults, got it.");
                }

                MessageFromComputer("How many children?");
                inputInteger = double.Parse(System.Console.ReadLine());
                if (inputInteger > 0)
                {
                    double ChildMatineeTicket = 3.99;
                    double TotalChildMatinee = (ChildMatineeTicket * inputInteger);
                }
                else
                {
                    MessageFromComputer("No children tickets needed.");
                }

                MessageFromComputer("How many seniors?");
                inputInteger = double.Parse(System.Console.ReadLine());
                if (inputInteger > 0)
                {
                    double SeniorMatineeTicket = 4.50;
                    double TotalSeniorMatinee = (SeniorMatineeTicket * inputInteger);
                }
                else
                {
                    MessageFromComputer("No senior tickets needed for purchase.");
                }
            }

            else if (command.ToLower().Contains("evening"))
            {
                {
                    MessageFromComputer("How many adults?");
                    double inputInteger = double.Parse(System.Console.ReadLine());
                    if (inputInteger > 0)
                    {
                        double AdultEveningTicket = 10.99;
                        double TotalAdultMatinee = (AdultEveningTicket * inputInteger);
                    }
                    else
                    {
                        MessageFromComputer("No adults, got it.");
                    }

                    MessageFromComputer("How many children?");
                    inputInteger = double.Parse(System.Console.ReadLine());
                    if (inputInteger > 0)
                    {
                        double ChildEveningTicket = 6.99;
                        double TotalChildMatinee = (ChildEveningTicket * inputInteger);
                    }
                    else
                    {
                        MessageFromComputer("No children tickets needed.");
                    }

                    MessageFromComputer("How many seniors?");
                    inputInteger = double.Parse(System.Console.ReadLine());
                    if (inputInteger > 0)
                    {
                        double SeniorEveningTicket = 8.50;
                        double TotalSeniorMatinee = (SeniorEveningTicket * inputInteger);
                    }
                    else
                    {
                        MessageFromComputer("No senior tickets needed for purchase.");
                    }

                }
            }

            else
            {
                MessageFromComputer("Sorry we did not show the movie you were looking for. Please come again.");
                Finish();
            }

            MessageFromComputer("Would you like any thing from the Concession Stand?");
            command = System.Console.ReadLine();
            if (command.ToLower().Contains("y"))
            {
                MessageFromComputer("Would you like anything to drink?");
                command = System.Console.ReadLine();
                if (command.ToLower().Contains("y"))
                {
                    MessageFromComputer("Would you like small or large?");
                    command = System.Console.ReadLine();
                    if (command.ToLower().Contains("small"))
                    {
                        MessageFromComputer("How many?");
                        double inputInteger = double.Parse(System.Console.ReadLine());
                        if (inputInteger > 0)
                        {
                            double SmallSoda = 3.50;
                            double TotalSmallSoda = (SmallSoda * inputInteger);
                        }

                        else if (command.ToLower().Contains("large"))
                        {
                            MessageFromComputer("How many?");
                            inputInteger = double.Parse(System.Console.ReadLine());
                            if (inputInteger > 0)
                            {
                                double LargeSoda = 5.99;
                                double TotalLargeSoda = (LargeSoda * inputInteger);
                            }
                        }

                        MessageFromComputer("Would you like any hot dogs?");
                        command = System.Console.ReadLine();
                        if (command.ToLower().Contains("y"))
                        {
                            MessageFromComputer("How many hot dogs would you like?");
                            inputInteger = double.Parse(System.Console.ReadLine());
                            if (inputInteger > 0)
                            {
                                double HotDog = 3.99;
                                double TotalHotDogs = (HotDog * inputInteger);
                            }
                        }

                        MessageFromComputer("Would you like any popcorn?");
                        command = System.Console.ReadLine();
                        if (command.ToLower().Contains("y"))
                        {
                            MessageFromComputer("How many bags of popcorn would you like?");
                            inputInteger = double.Parse(System.Console.ReadLine());
                            if (inputInteger > 0)
                            {
                                double BagOfPopcorn = 4.50;
                                double TotalPopcorn = (BagOfPopcorn * inputInteger);
                            }
                        }

                        MessageFromComputer("Would you like any candy?");
                        command = System.Console.ReadLine();
                        if (command.ToLower().Contains("y"))
                        {
                            MessageFromComputer("How many boxes of candy?");
                            inputInteger = double.Parse(System.Console.ReadLine());
                            if (inputInteger > 0)
                            {
                                double BoxOfCandy = 1.99;
                                double TotalCandy = (BoxOfCandy * inputInteger);
                            }
                        }

                    }
                   
                }
                
            }
            else if (command.ToLower().Contains("n"))
            {
                MessageFromComputer("Maybe next time, enjoy your movie.");
            }
            Finish();
        }

 

            //Matinee Prices
            //Child  $3.99
            //Adult  $5.99
            //Senior  $4.50


            //Evening Prices
            //Child  $6.99
            //Adult  $10.99
            //Senior  $8.50


            //Concession Stand
            //Small Soda $3.50
            //Large Soda $5.99
            //Hot Dog $3.99
            //Popcorn $4.50
            //Candy  $1.99


            //Discounts & Promotions
            //Each purchase of a popcorn and a large soda grants a $2 discount on one movie ticket.
            //If 3 or more people purchase tickets to an evening show, they get 1 free bag of popcorn.
            //For each 3 candies you buy, you can get a 4th candy for free.

        private static void MessageFromComputer(string text)
        {
            System.Console.WriteLine();
            System.Console.WriteLine(" " + text);
            System.Console.WriteLine();
            System.Console.WriteLine(" ");

        }

        private static void YourFinalTotal(string text)
        {
            System.Console.WriteLine("Your final total is " + ".");
            System.Console.WriteLine(" ");
            System.Console.WriteLine("Thank you for your purchase and enjoy your movie!");
            System.Console.WriteLine(" ");
            System.Console.WriteLine("Please press any key to continue");
            System.Console.ReadKey();
        }

        private static void Finish()
        {
            System.Console.WriteLine("Press Any Key To Continue");
            System.Console.ReadKey();
        }

    
    }


    }

