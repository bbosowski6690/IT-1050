using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5_LoopsAndArrays_Project
{
    public class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.Name = Question.AskForString("Please Enter Your Name");
            student.SNumber = Question.AskForString("Please Enter Your SNumber");
            student.Print();

            System.Console.WriteLine("Would you like to create a new course?");
            while (System.Console.ReadLine().ToLower().StartsWith("y"))
            {
                Course course = new Course();
                course.CourseName = Question.AskForString("Please Enter Course Name");
                course.CRN = Question.AskForInteger("Please Enter The CRN");
                course.GetStudents();
                course.Print();
            }

            System.Console.WriteLine("Is everything correct? y/n");
            while (System.Console.ReadLine().ToLower().StartsWith("n"))
            {
                Course course = new Course();
                course.CourseName = Question.AskForString("Please Enter Course Name");
                course.CRN = Question.AskForInteger("Please Enter The CRN");
                int size2 = Question.AskForInteger("How many students are in the class?");
                course.Students = new Student[size2];
                course.Print();
                System.Console.WriteLine("Is everything correct? y/n");
            }

            System.Console.WriteLine("Press Any Key To Continue...");

            System.Console.ReadKey();



            //Allow the user to create a course.
            //Ask for the course name.
            //Ask for the course number.
            //Ask how many students are in the course.
            //Use a FOR Loop to create all of the students.
            //Print the results to the screen.


                //Ask the user if everything is correct.
                //Allow the user to start over if they made a mistake.
                //Use a WHILE Loop for this.
        }
    }
}

