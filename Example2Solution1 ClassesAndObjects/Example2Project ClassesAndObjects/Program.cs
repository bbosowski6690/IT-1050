namespace Example2Project_ClassesAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {

            Person somePerson = new Person();
            somePerson.Name = "John Doe";
            somePerson.Age = 21;

            Person anotherPerson = new Person();
            anotherPerson.Name = "Jane Doe";
            anotherPerson.Age = 19;

            Person oldestPerson = somePerson;

        }
    }
}
