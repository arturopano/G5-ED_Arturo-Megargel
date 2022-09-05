using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operaciones_bASICAS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = 12;
            int secondNumber = 7;

            int sum = 7 + 5;
            int difference = 7 - 5;
            int product = 7 * 5;
            int quotient = 7 / 5;
            decimal decimalQuotient = 7.0m / 5;
        

            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("Difference: " + difference);
            Console.WriteLine("Product: " + product);
            Console.WriteLine("Quotient: " + quotient);
            Console.WriteLine("Decimal quotient: " + decimalQuotient);

            Console.WriteLine(firstNumber + secondNumber);
            
            string firstName = "Bob";
            int widgetsSold = 7;
            Console.WriteLine(firstName + " sold " + widgetsSold + " widgets.");


            int value = 1;

            value = value + 1;
            Console.WriteLine("First increment: " + value);

            value += 1;
            Console.WriteLine("Second increment: " + value);

            value++;
            Console.WriteLine("Third increment: " + value);

            value = value - 1;
            Console.WriteLine("First decrement: " + value);

            value -= 1;
            Console.WriteLine("Second decrement: " + value);

            value--;
            Console.WriteLine("Third decrement: " + value);

            int fanhrenheit = 94;
            int c;

            c = (fanhrenheit - 32) *5/9;
            
            Console.WriteLine("Resultado celsuus: " + c);
            Console.ReadLine();
        }
    }
}
