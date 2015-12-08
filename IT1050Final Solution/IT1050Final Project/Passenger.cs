using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT1050Final_Project
{
    public class Passenger
    {
        private string Name;
        private double Weight;

        public Passenger(string name, double weight)
        {
            Name = name;
            Weight = weight;
        }

        public string GetName()
        {
            return Name;
        }

        public double GetWeight()
        {
            return Weight;
        }


        //Step 1 – Create a class called "Passenger":
        // Two private member variables:
        //o Name, which is a string.
        //o Weight, which is a double.
        // One public constructor:
        //o Takes two parameters: name, which is a string, and weight, which is a double.
        //o Assigns Name the value of name.
        //o Assigns Weight the value of weight.
        // Two public methods:
        //o GetName, which returns Name.
        //o GetWeight, which returns Weight.
    }
}
