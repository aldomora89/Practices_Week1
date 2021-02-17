using System;

namespace Practice2
{
    class Program
    {
        static void Main(string[] args)
        {
            int t_base;
            int t_heigth;
            int result;
            Console.WriteLine("Triangule Measures");
            Console.WriteLine("Base: ");
            t_base = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Height: ");
            t_heigth = Convert.ToInt32(Console.ReadLine());
            result = t_base * t_heigth / 2;
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Triangule area is: "+result);
        }
    }
}
