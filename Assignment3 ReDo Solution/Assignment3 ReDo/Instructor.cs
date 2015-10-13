namespace Assignment3_ReDo
{
    class Instructor
    {
        private string Name;
        private string CourseName;

        public Instructor(string teacherName, string courseName)
        {
            Name = teacherName;
            CourseName = courseName;
        }

        public string GetTeacherNameAndCourse()
        {
            return Name + CourseName;
        }

        public void SetStudentGrade(Student Name, int Grade)
        {
            Name.SetGrade(Grade);
        }

        public void PrintTeacherInformation()
        {
            System.Console.WriteLine("Teacher: " + this.Name + " " + "Course: " + this.CourseName);
        } 

    }

    }
