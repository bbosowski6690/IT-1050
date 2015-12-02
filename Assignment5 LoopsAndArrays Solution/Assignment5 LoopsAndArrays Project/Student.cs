using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5_LoopsAndArrays_Project
{
    public class Student
    {
        public string Name;
        public string SNumber;

        public void GetStudentInfo()
        {
            string name;
            string sNumber;
            name = Question.AskForString("Student's name");
            sNumber = Question.AskForString("Student's SNumber");
            Name = name;
            SNumber = sNumber;
        }

        public void Print()
        {
            System.Console.WriteLine("Student's Name: " + Name + " " + "Student's SNumber: " + SNumber);
        }

        //Create a class “Student”.
        //Every Student has a Name.
        //Every Student has an S-Number.

    }
}
