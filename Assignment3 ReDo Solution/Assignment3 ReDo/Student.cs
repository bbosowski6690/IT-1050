namespace Assignment3_ReDo
{
    class Student
    {
        private string FirstName;
        private int Grade;
        private Instructor Teacher;

    
        public string PrintInformation()
        {
            return FirstName + " " + Grade;   
        }

        public Student(string firstname, int grade, Instructor teacher)
        {
            this.FirstName = firstname;
            this.Grade = grade;
            this.Teacher = teacher;
        }

        public void SetGrade(int Grade)
        {
            this.Grade = Grade;
        }

        public void Print()
        {
            System.Console.WriteLine("Student:" + PrintInformation());
            this.Teacher.PrintTeacherInformation();
            System.Console.WriteLine("   ");
            System.Console.ReadKey();

        }

    }
}
