using System;

namespace Practice5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculate Measures");
            Console.WriteLine("Choose with measure do what to get 1 or 2");
            Console.WriteLine("inch -> cm (1)");
            Console.WriteLine("cm -> inch (2)");
            try
            {
                int option = Convert.ToInt32(Console.ReadLine());
                if (option == 1)
                {
                    Console.WriteLine("inch measure: ");
                    double inch = Convert.ToDouble(Console.ReadLine());
                    double cm = inch * 2.54;
                    Console.WriteLine("This measure in Centimeters(cm) is: " + cm);
                }
                else if (option == 2)
                {
                    Console.WriteLine("cm measure: ");
                    double cm = Convert.ToDouble(Console.ReadLine());
                    double inch = cm / 2.54;
                    Console.WriteLine("This measure in Inches(inch) is: " + inch);
                }
                else
                {
                    Console.WriteLine("Write 1 or 2!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error Exception: " + ex);
            }
     
       
        }
    }
}
