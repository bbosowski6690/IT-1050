namespace IT_1050_Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            System.Console.WriteLine("What is your first name?");
            string firstName = System.Console.ReadLine();

            System.Console.WriteLine("What is your middle initial?");
            string middleInitial = System.Console.ReadLine();

            System.Console.WriteLine("What is your last name?");
            string lastName = System.Console.ReadLine();

            System.Console.WriteLine(firstName + " " + middleInitial + "." + " " + lastName);


            System.Console.WriteLine("What is your height in feet?");
            int heightFeet = int.Parse(System.Console.ReadLine());

            System.Console.WriteLine("How many inches beyond your base height in feet to add to your height?");
            double heightInches = double.Parse(System.Console.ReadLine());

            double totalHeight = heightFeet + heightInches;
            double totalHeightCM = (((heightFeet * 12) + heightInches) * 2.54);
            System.Console.WriteLine("Your total height is" + " " + totalHeightCM + " ");


            System.Console.WriteLine("Age:");
            int age = int.Parse(System.Console.ReadLine());

            System.Console.WriteLine("Are you a citizen?");
            bool isCitizen = bool.Parse(System.Console.ReadLine());

            bool canVote;
            canVote = isCitizen;
            canVote = age >= 18;
            System.Console.WriteLine("Voter Eligibility:" + " " + canVote);

            

            // Ask the user what their first name is.
            // Assign firstName the string value which the user enters.
            // Ask the user what their middle initial is.
            // Assign middleInitial the string value which the user enters.
            // Ask the user what their last name is.
            // Assign lastName the string value which the user enters.
            // Assign fullName the concatenation of the previous three string values.
            // The formatting should look something like this: “Donald J. Santos”


            // Ask the user what their height in feet is. (4, 5 or 6)
            // Assign heightFeet the integer value which the user enters.
            // Ask the user how many inches beyond their base height in feet to add to their height.
            // Assign heightInches the double value which the user enters.
            // (For example, If you are 6’1¼, then heightFeet should be 6 and heightInches should be 1.25)
            // Assign totalHeightCM the value of your total height in centimeters.
            // Compute this by using heightFeet and heightInches with the formula:


            // Centimeters = Inches * 2.54


            // Ask the user what their age is.
            // Assign age the integer value which the user enters.
            // Ask the user if they are a citizen.
            // Assign isCitizen the bool value which the user enters.
            // Assign canVote the bool value of your voter eligibility using this rule:


            // To be eligible to vote, you must be a citizen, and you must be at least 18 years old.


            // Finally, to fulfill the assignment objectives:
            // Print the value of  fullName to the screen.
            // Print the value of totalHeightCM to the screen.
            // Print the value of canVote to the screen.


        }
    }
}
