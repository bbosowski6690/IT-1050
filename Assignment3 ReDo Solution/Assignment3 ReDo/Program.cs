namespace Assignment3_ReDo
{
    class Program
    {
        static void Main(string[] args)
        {
            Instructor John = new Instructor("John", "English");

            Instructor Mike = new Instructor("Mike", "Math");
            
            John.PrintTeacherInformation();
            
            System.Console.WriteLine(" ");

            Mike.PrintTeacherInformation();

            System.Console.WriteLine(" ");

            Student Jane = new Student("Jane", 0, John);

            Student Joe = new Student("Joe", 0, John);

            Student Melissa = new Student("Melissa", 0, Mike);

            Student Matt = new Student("Matt", 0, Mike);

            John.SetStudentGrade = Jane, ++ 95;
            
            John.SetStudentGrade = John, ++ 85;
            
            Mike.SetStudentGrade = Melissa, ++ 90;
            
            Mike.SetStudentGrade = Matt, ++ 92;

            System.Console.WriteLine(" ");

            Jane.PrintInformation();
            
            Joe.PrintInformation();
            
            Melissa.PrintInformation();
            
            Matt.PrintInformation();

            System.Console.WriteLine(" ");

            System.Console.ReadKey();
        }
    }
}
