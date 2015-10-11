namespace Assignment3_Parameters_Constructors_and_I.O
{
    class Student
    {
        public string Name { get; private set; }
        public int Grade { get; private set; }
        public class Instructor { }
        public int SetGrade  { get; private set; }

        public Student(string Name, int Grade, Instructor Instructor, int SetGrade)
        {

        }

   
        public void PrintNameGradeInstructor()
        {
            System.Console.WriteLine("Name and Grade: " + Name + Grade + "Instructor: " + Instructor());
        }


          //  Create a class “Student” according to the following specifications:
//Every Student has a Name. (string)
//Every Student has a Grade. (int)
//Every Student has a Teacher. (Instructor)
//Every Student is created with specified default values for Name and Teacher.
//Every Student is created with a default value of 0 for their Grade.
//Every Student can SetGrade which allows their Grade to be assigned a value.
//Every Student can Print their Name, Grade, and Teacher’s complete information.


    }
}
