namespace Example2Project_ObjectMethods
{
    class Person
    {
        public string FirstName;
        public string MiddleInitial;
        public string LastName;
        public int Age;

        public string GetFullName()
        {
            return this.FirstName + " " + this.MiddleInitial + ". " + this.LastName;
        }


        public void StateYourNameAndAge()
        {
            System.Console.WriteLine(this.FirstName + " says, 'Hello.'");
            System.Console.WriteLine("My name is "+this.GetFullName());
            System.Console.WriteLine("My age is " + this.Age);
        }
    }
}
