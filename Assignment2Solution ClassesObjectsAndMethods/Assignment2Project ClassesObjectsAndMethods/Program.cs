namespace Assignment2Project_ClassesObjectsAndMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Person.AverageAge = 0;
            Person.Count = 0;

          
            Person person1 = new Person();
            System.Console.WriteLine("What is your first name?");
            System.Console.WriteLine("First Name: ");
            person1.FirstName = System.Console.ReadLine();
            System.Console.WriteLine("What is your last name?");
            System.Console.WriteLine("Last Name: ");
            person1.LastName = System.Console.ReadLine();
            System.Console.WriteLine("How old are you?");
            System.Console.WriteLine("Age: ");
            person1.Age = int.Parse(System.Console.ReadLine());
            Person.AverageAge += person1.Age;
            System.Console.WriteLine("Are you married?");
            if (System.Console.ReadLine().ToLower() == "Y")
            System.Console.WriteLine("What is your spouse's name?");
            Person Spouse = new Person();
            System.Console.WriteLine("Your Spouse's First Name: ");
            person1.Spouse.FirstName = System.Console.ReadLine();
            System.Console.WriteLine("How old is your spouse?");
            person1.Spouse.Age = int.Parse(System.Console.ReadLine());
                Person.AverageAge += person1.Spouse.Age;


            System.Console.WriteLine();
            person1.PrintNameAndAge();
            person1.Spouse.PrintNameAndAge();
            




            Person.AverageAge /= Person.Count;
            System.Console.WriteLine("Average age is {0}", Person.AverageAge);
            System.Console.WriteLine("Press any key to continue");
            System.Console.ReadKey();







            //Create a class called “Person” that has the following public 
            //instance variables:

            //Age(int)
            //FirstName(string)
            //LastName(string)
            //Spouse(Person)


            //The “Person” class should also have the following public 
            //static variable:

            //AverageAge(double)


            //The “Person” class should also have the following public 
            //instance method:

            //GetFullName(string)
            //PrintNameAndAge(void)


            //Ask the user to provide you with the name, age, and marital status 
            //of 3 separate individuals.

            //If any of the 3 persons are married, additionally ask for the 
            //first name and age of their spouse.

            //After you have collected this information, compute and print all
            //values:

            //Full name and age of every person, including spouses.

            //Average age of all people.


            //You may only have 3 “Person” type variables local to the Main 
            //Program.

            //The spouses must be referenced through the original three Person 
            //objects.


            //NOTE:  It is strongly encouraged to use methods anywhere potential 
            //code reuse can be achieved to make your code shorter more efficient and reusable.
            //You may also create any additional classes and objects that you feel make your 
                //design better.
        }
    }
}
