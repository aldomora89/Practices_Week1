﻿using System;

namespace Practice3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Salary Details Calculate");
            Console.WriteLine("Your Full Name: ");
            string name = Console.ReadLine();
            double CCSS = 0.08;
            double BP = 0.01;
            Console.WriteLine("Salary: ");
            double salary = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("-------------------------------" + '\n' + "Hi " + name);

            double CSSS_fee = salary * CCSS;
            double BP_fee = salary * BP;
            double salary_net = salary - (CSSS_fee + BP_fee);
            Console.WriteLine("CCSS Fee: " + CSSS_fee + '\n'+"Banco Popular Fee: " + BP_fee +
                '\n' + "Net Salary: " + salary_net);
        }
    }
}
