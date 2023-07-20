using System;
namespace Averagely
{
class Program
{
    static void Main()
    {
    Console.Write("Enter the first number: ");
    decimal number1 = Convert.ToDecimal(Console.ReadLine());

    Console.Write("Enter the second number: ");
    decimal number2 = Convert.ToDecimal(Console.ReadLine());
    
    Console.Write("Enter the third number: ");
    decimal number3 = Convert.ToDecimal(Console.ReadLine());
    
    Console.Write("Enter the forth number: ");
    decimal number4 = Convert.ToDecimal(Console.ReadLine());
    
    Console.Write("Enter the fifth number: ");
    decimal number5 = Convert.ToDecimal(Console.ReadLine());
    
    decimal average = (number1+number2+number3+number4+number5)/5;
    Console.WriteLine("Average:  "+average);
    }
}
}
