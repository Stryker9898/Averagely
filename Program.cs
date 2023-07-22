using System;
namespace Averagely
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter the first subject: ");
            decimal number1 = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Enter the second subject: ");
            decimal number2 = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Enter the third subject: ");
            decimal number3 = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Enter the forth subject: ");
            decimal number4 = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Enter the fifth subject: ");
            decimal number5 = Convert.ToDecimal(Console.ReadLine());

            decimal average = (number1 + number2 + number3 + number4 + number5) / 5;
            Console.WriteLine("Average:  " + average);

            if (average > 3 && average < 5)
            {
                System.Console.WriteLine("You passed");
            }
            else if (average < 3 && average > 0)
            {
                System.Console.WriteLine("You failed");
            }
            else
                System.Console.WriteLine("Invalid Input");
        }
    }
}
