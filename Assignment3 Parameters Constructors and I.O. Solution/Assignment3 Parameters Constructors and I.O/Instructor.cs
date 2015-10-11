namespace Assignment3_Parameters_Constructors_and_I.O
{
    class Instructor
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string CourseName { get; private set; }

        public Instructor(string FirstName, string LastName, string CourseName)
        {
         
        }

        public void SetStudentGrade(Student Grade, string v1, int v2)
        {
            
        }



        public string GetFullName()
        {
            return this.FirstName + this.LastName;
        }

        public string GetCourseName()
        {
            return CourseName;
        }
 
        public void PrintNameandCourse()
        {
            System.Console.WriteLine("Name: " + GetFullName () + " " + "Course:" + GetCourseName()); 
        }

        //Create a class “Instructor” according to the following specifications:
//Every Instructor has a Name. (string)
//Every Instructor has a CourseName. (string)
//Every Instructor is created with specified default values for Name and CourseName.
//Every Instructor can SetStudentGrade of any Student. (2 parameters, a Student, and an int)
//Every Instructor can Print their FirstName, LastName and CourseName.
    }
}
