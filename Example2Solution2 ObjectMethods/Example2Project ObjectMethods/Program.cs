namespace Example2Project_ObjectMethods
{
    class Program
    {
        static void Main(string[] args)
        {

            Person person1 = new Person();
            person1.FirstName = "Brittany";
            person1.MiddleInitial = "V";
            person1.LastName = "Bosowski";
            person1.Age = 25;

            Person person2 = new Person();
            person2.FirstName = "Catherine";
            person2.MiddleInitial = "A";
            person2.LastName = "Dronet";
            person2.Age = 19;

            person1.StateYourNameAndAge();
            person2.StateYourNameAndAge();

            System.Console.WriteLine("Press Any Key to Continue...");
            System.Console.ReadKey();

        }
    }
}
