using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleProject3_OperatorsandExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            int number; // [0]
            number = 10; // [10]
            number += 10; // [20]
            number -= 5; // [15]
            number = 50 + 50; // [100]
            number = 10 - 10; // [0]
            number = 100 * 2; //[200]
            number = 100 / 2; // [50]
            number ++; // [51]
            number --; // [50]

            bool ok; // [false]
            ok = true && false; // [false]
            ok = true || false; // [true]
            ok = !true; // [false]
            ok = 1 == 2; // [false]
            ok = 1 != 2; // [false]
            ok = 25 > 200; // [false]
            ok = 25 < 200; // [false]
            ok = 25 >= 26; // [false]
            ok = 25 <= 25; // [true]

            double weightOfCarInTons = ((4 * 10) + (4 * 100) + 3000 + 1000) / 2000;

            double weightOfTires = 4 * 10;
            double weightOfSeats = 4 * 100;
            double weightOfInternal = 3000;
            double weightOfBody = 1000;
            double totalPounds = weightOfTires + weightOfSeats + weightOfInternal + weightOfBody;
            weightOfCarInTons = totalPounds / 2000;

            int xCoordinate = 10;
            int yCoordinate = 20;
            string formattedPoint = "[" + xCoordinate + "," + yCoordinate + "]"; 
            
        }
    }
}
