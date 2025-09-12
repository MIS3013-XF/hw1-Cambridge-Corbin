// HW1a Sales Total

// Your Name:Cambridge Corbin
// Did you seek help ? If yes, specify the helper or web link here: 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HW1a_Sales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double quantity;
            double price;

            const double sales_tax_rate = 0.085;


            string productName;
            string QuantityAsString;
            String PriceAsString;


            Console.WriteLine("What is the name of the product you are buying?");
            productName = Console.ReadLine();

            Console.WriteLine("How many would you like to buy?");
            QuantityAsString = Console.ReadLine();

            Console.WriteLine("What is the cost of each item?");
            PriceAsString = Console.ReadLine();

            quantity = Convert.ToDouble(QuantityAsString);
            price = Convert.ToDouble(PriceAsString);
            
            Double subtotal = quantity * price;
            Double sales_tax = price * sales_tax_rate;
            double total = subtotal + sales_tax;
            
            Console.WriteLine("Your subtotal for the bill is $" + subtotal.ToString("N3"));

            Console.WriteLine("Your sales tax for the bill is $" + sales_tax.ToString("N3"));

            Console.WriteLine("Your total is $" + total.ToString("N3"));

            Console.ReadKey();

        }
    }
}
