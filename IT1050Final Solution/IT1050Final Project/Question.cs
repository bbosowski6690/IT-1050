using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT1050Final_Project
{
    public class Question
    {
        public static string AskForString(string prompt)
        {
            System.Console.Write(prompt.PadRight(33) + " : ");
            return System.Console.ReadLine();
        }

        public static int AskForInteger(string prompt)
        {
            return int.Parse(AskForString(prompt));
        }

        public static double AskForDouble(string prompt)
        {
            return double.Parse(AskForString(prompt));
        }

        public static bool AskForBool(string prompt)
        {
            string input = System.Console.ReadLine().ToLower();
            return input.StartsWith("y") || input.StartsWith("t");
        }
    }
}
