﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5_LoopsAndArrays_Project
{
    public class Question
    {
       public static string AskForString(string prompt)
            {
                System.Console.Write(prompt.PadRight(35) + ": ");
                return System.Console.ReadLine();
            }

            public static int AskForInteger(string prompt)
            {
                return int.Parse(AskForString(prompt));
            }
        
    }
}
