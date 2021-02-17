using System;

namespace Practice1_Week1
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare variables
            double num1;
            double result;
            int value = 2;
            double P = 3.14;
            Console.WriteLine("Circle Measures");
            Console.WriteLine("Add Circule Radius:");
            num1 = Convert.ToInt32(Console.ReadLine());
            result = (P * (Math.Pow(num1, value)));
            Console.WriteLine("-------------------------------");
            Console.WriteLine($"Circle Area is: " + result);
        }
    }
}
