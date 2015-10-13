using System;

namespace Assignment3_Parameters_Constructors_and_I.O
{
    class Student
    {
        public string Name { get; set; }
        public int Grade { get; set; }
        private string v1;
        private int v2;
        private string Teacher = null;
        public void SetGrade()
        {
            Grade = 0;
        }

        public Student(string v1, int v2, Instructor Teacher)
        {
            this.v1 = v1;
            this.v2 = v2;
        }

        public void Print()
        {
            
            Console.WriteLine("Name and Grade: " + Name + Grade + "Instructor: " + Teacher);
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
