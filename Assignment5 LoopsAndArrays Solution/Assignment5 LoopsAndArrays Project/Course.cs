using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5_LoopsAndArrays_Project
{
    public class Course
    {
        public string CourseName;
        public int CRN;
        public Student[] Students;

        public void GetStudents()
        {
            for (int i = 0; i < Students.Length; i++)
            {
                Students[i] = new Student();
            }
            foreach (Student student in Students)
            {
                student.Print();
            }
        }

        public void Print()
        {
            System.Console.WriteLine("The name of the course is " + CourseName + "." + "The CRN is " + CRN + "." + 
                "There are " + Students.Length + " students in the class");
        }

        
        
        //Create a class “Course”.
        //Every Course has a Name.
        //Every Course has a CRN Number.
        //Every Course has a list of Students.
    }
}

