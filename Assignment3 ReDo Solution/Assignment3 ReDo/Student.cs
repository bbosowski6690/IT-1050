namespace Assignment3_ReDo
{
    class Student
    {
        public string FirstName;
        public int Grade;
        public Instructor Teacher;

    
        public string PrintInformation()
        {
            return FirstName + " " + Grade + " " + Teacher + " " + Teacher.CourseName;    
        }

        public Student(string firstname, int grade, Instructor teacher)
        {
            this.FirstName = firstname;
            this.Grade = grade;
            this.Teacher = teacher;
        }

        public int SetGrade()
        {
           return Grade = 0;
        }

        public void Print()
        {
            System.Console.WriteLine("Student:" + this.PrintInformation());
            System.Console.WriteLine("   ");
            System.Console.ReadKey();



    }
}
