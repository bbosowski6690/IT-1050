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
            int size = Question.AskForInteger("How many students are in the class?");
            Students = new Student[size];
            for (int i=0; i<size; i++)
            {
                Students[i] = new Student();
                Students[i].GetStudentInfo(); 
            }
            foreach (Student student in Students)
            {
                student.Print();
            }
        }

        public void Print()
        {
            System.Console.WriteLine("The name of the course is " + CourseName + ".");
            System.Console.WriteLine("The CRN is " + CRN + ".");
            System.Console.WriteLine("There are " + Students.Length + " students in the class");
        }

        
        
        //Create a class “Course”.
        //Every Course has a Name.
        //Every Course has a CRN Number.
        //Every Course has a list of Students.
    }
}

