using System;

namespace Practice4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculate Final Price Item");
            Console.WriteLine("Item Price: ");
            double item_price = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("How many Items do you get?: ");
            int item_quantity = Convert.ToInt32(Console.ReadLine());
            double subtotal = item_price * item_quantity;
            double iva = (subtotal) * 0.13;
            double discount = (subtotal) * 0.10;
            double total = (subtotal - discount) + iva;
            Console.WriteLine("-------------------------------" + '\n' + "Details billed" + '\n'
                + "Unit price: " + item_price  +'\n' + "Price of all items: " + subtotal + '\n' +
                "Sales Tax: " + iva + '\n' + "Discounted amount: " + discount + '\n' + "Final Price: " + total);
        }
    }
}
