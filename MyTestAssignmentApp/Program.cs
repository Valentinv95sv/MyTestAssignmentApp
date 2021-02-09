using System;
using System.Collections.Generic;

namespace MyTestAssignmentApp
{
    class Program
    {
        private static test test = new test();
        private static DateTime time = DateTime.Now;
        private static List<DateTime> data = new List<DateTime>();
        
        static void Main(string[] args) 
        {
            
            Console.WriteLine(test.mainFunc("09.07.2010 23:36", "45;12;1;29;2"));
            Console.WriteLine("Time: {0}", (DateTime.Now - time));
        }
    }

   
}
