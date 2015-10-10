namespace Assignment3_Parameters_Constructors_and_I.O
{
    class Instructor
    {
        public string FirstName;
        public string LastName;
        public string CourseName;
        public SetStudentGrade()
        {
            
        }

      
        public string GetFullName()
        {
            return this.FirstName + " " + this.LastName;
        }

        public string GetCourseName()
        {
            return this.CourseName;
        }
 
        public void PrintNameandCourse()
        {
            System.Console.WriteLine(this.GetFullName = new Name() + this.GetCourseName()); 
        }

        Create a class “Instructor” according to the following specifications:
Every Instructor has a Name. (string)
Every Instructor has a CourseName. (string)
Every Instructor is created with specified default values for Name and CourseName.
Every Instructor can SetStudentGrade of any Student. (2 parameters, a Student, and an int)
Every Instructor can Print their FirstName, LastName and CourseName.
    }
}
