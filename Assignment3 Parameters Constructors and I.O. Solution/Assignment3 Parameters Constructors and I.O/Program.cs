namespace Assignment3_Parameters_Constructors_and_I.O
{
    class Program
    {
        
        static void Main(string[] args)
        {

           Instructor John = new Instructor("John", "Smith", "English");

           Instructor Mike = new Instructor("Mike", "Thornton", "Math");


            John.SetStudentGrade("Jane", 95);
            John.SetStudentGrade("Joe", 85);
            Mike.SetStudentGrade("Melissa", 90);
            Mike.SetStudentGrade("Matt", 92);


            Student Jane = new Student("Jane", 0, John);
            Jane.Print();

            Student Joe = new Student("Joe", 0, John);
            Joe.Print();

            Student Melissa = new Student("Melissa", 0, Mike);
            Melissa.Print();

            Student Matt = new Student("Matt", 0, Mike);
            Matt.Print();

            System.Console.ReadKey();


           

            //Write your “main” method in Program.cs according to the following pseudocode:
//Create an Instructor named “John” who teaches “English”.
//Create an Instructor named “Mike” who teaches “Math”.
//Create a Student named “Jane” whose teacher is John.
//Create a Student named “Joe” whose teacher is John.
//Create a Student named “Melissa” whose teacher is Mike.
//Create a Student named “Matt” whose teacher is Mike.
//Have John give Jane a grade of 95.
//Have John give Joe a grade of 85.
//Have Mike give Melissa a grade of 90.
//Have Mike give Matt a grade of 92.
//Have every student Print their information.
        }

      
    }
}
