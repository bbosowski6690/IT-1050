namespace Assignment3_ReDo
{
    class Instructor
    {
       public string Name;
       public string CourseName;

        public Instructor(string teacherName, string courseName)
        {
            Name = teacherName;
            CourseName = courseName;
        }

        public string GetTeacherNameAndCourse()
        {
            return Name + CourseName;
        }

        public void SetStudentGrade(Student Name, Student Grade)
        {
           System.Console.WriteLine();
        }

        public void PrintTeacherInformation()
        {
            System.Console.WriteLine("Teacher: " + this.Name + " " + "Course: " + this.CourseName);
 

    }

}
