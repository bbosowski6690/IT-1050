namespace Assignment2Project_ClassesObjectsAndMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Person.AverageAge = 0;
            Person.SumOfAllAges = 0;
            Person.Count = 0;



            Person person1 = new Person();
            System.Console.WriteLine("What is your first name?");
            person1.FirstName = System.Console.ReadLine();
            System.Console.WriteLine("What is your last name?");
            person1.LastName = System.Console.ReadLine();
            System.Console.WriteLine("How old are you?");
            person1.Age = int.Parse(System.Console.ReadLine());
            Person.Count++;
            Person.SumOfAllAges += person1.Age;

            System.Console.WriteLine("       ");
            System.Console.WriteLine("       ");

            System.Console.WriteLine("Are you married?  (y/n)");
            if (System.Console.ReadLine().ToLower().StartsWith("y"))
             {
                System.Console.WriteLine("What is your spouse's name?");
                person1.Spouse = new Person();
                person1.Spouse.FirstName = System.Console.ReadLine();
                System.Console.WriteLine("How old is your spouse?");
                person1.Spouse.Age = int.Parse(System.Console.ReadLine());
                Person.Count++;
                Person.SumOfAllAges += person1.Spouse.Age;
            }

            System.Console.WriteLine("       ");
            System.Console.WriteLine("       ");

            Person person2 = new Person();
            System.Console.WriteLine("What is your first name?");
            person2.FirstName = System.Console.ReadLine();
            System.Console.WriteLine("What is your last name?");
            person2.LastName = System.Console.ReadLine();
            System.Console.WriteLine("How old are you?");
            person2.Age = int.Parse(System.Console.ReadLine());
            Person.Count++;
            Person.SumOfAllAges += person2.Age;

            System.Console.WriteLine("       ");
            System.Console.WriteLine("       ");

            System.Console.WriteLine("Are you married? (y/n)");
            if (System.Console.ReadLine().ToLower().StartsWith("y"))
            {
                System.Console.WriteLine("What is your spouse's name?");
                person2.Spouse = new Person();
                person2.Spouse.FirstName = System.Console.ReadLine();
                System.Console.WriteLine("How old is your spouse?");
                person2.Spouse.Age = int.Parse(System.Console.ReadLine());
                Person.Count++;
                Person.SumOfAllAges += person2.Spouse.Age;
            }

            System.Console.WriteLine("       ");
            System.Console.WriteLine("       ");

            Person person3 = new Person();
            System.Console.WriteLine("What is your first name?");
            person3.FirstName = System.Console.ReadLine();
            System.Console.WriteLine("What is your last name?");
            person3.LastName = System.Console.ReadLine();
            System.Console.WriteLine("How old are you?");
            person3.Age = int.Parse(System.Console.ReadLine());
            Person.Count++;
            Person.SumOfAllAges += person3.Age;

            System.Console.WriteLine("       ");
            System.Console.WriteLine("       ");

            System.Console.WriteLine("Are you married? (y/n)");
            if (System.Console.ReadLine().ToLower().StartsWith("y"))
            {
                System.Console.WriteLine("What is your spouse's name?");
                person3.Spouse = new Person();
                person3.Spouse.FirstName = System.Console.ReadLine();
                System.Console.WriteLine("How old is your spouse?");
                person3.Spouse.Age = int.Parse(System.Console.ReadLine());
                Person.Count++;
                Person.SumOfAllAges += person3.Spouse.Age;

            }

            System.Console.WriteLine("       ");
            System.Console.WriteLine("       ");

            System.Console.WriteLine();
            person1.PrintNameAndAge();
            if (person1.IsMarried())
            {
                person1.Spouse.PrintNameAndAge();

            }

            System.Console.WriteLine("       ");
            System.Console.WriteLine("       ");

            System.Console.WriteLine();
            person2.PrintNameAndAge();
            if (person2.IsMarried())

            {
                person2.Spouse.PrintNameAndAge();

            }

            System.Console.WriteLine("       ");
            System.Console.WriteLine("       ");

            System.Console.WriteLine();
            person3.PrintNameAndAge();
            if (person3.IsMarried())

            {
                person3.Spouse.PrintNameAndAge();
            }

            System.Console.WriteLine("       ");
            System.Console.WriteLine("       ");

            Person.AverageAge = Person.SumOfAllAges /= Person.Count;
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
