using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2Project_ClassesObjectsAndMethods
{
    class Person
    {

        public string FirstName;
        public string LastName;
        public int Age;
        public Person Spouse;


        public static int Count;


        public static double AverageAge;


    public string GetFullName()
        {
            return this.FirstName + " " + this.LastName;
        }

        public int GetAge()
        {
            return this.Age;
        }
    
        public void PrintNameAndAge()
        {
            Console.WriteLine("Name and Age: " + this.GetFullName());
            Console.WriteLine("Age: " + GetAge());
        }

        


    }
}
