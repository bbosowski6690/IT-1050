using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleProject4_ConsoleApplicationInputandOutput
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("What is your name?");

            string userName;

            userName = System.Console.ReadLine();

            System.Console.Write("How old are you?");

            int userAge;
            userAge = int.Parse(System.Console.ReadLine());

            System.Console.Write("Your name is :");
            System.Console.Write(userName);
            System.Console.Write("Your age is : ");
            System.Console.WriteLine(userAge);

            System.Console.Write("Press any key to continue...");
            System.Console.ReadKey();
             
        }
    }
}
