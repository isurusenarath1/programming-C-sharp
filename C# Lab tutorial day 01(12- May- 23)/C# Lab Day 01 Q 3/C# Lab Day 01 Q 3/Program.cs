using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Lab_Day_01_Q_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1, num2;
            Console.WriteLine("Enter the first number: ");
            num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            num2 = double.Parse(Console.ReadLine());
            double Result;
            Result = num1 + num2;
            Console.WriteLine("Sum of two nmbers: " + Result.ToString());
            Console.ReadLine();
        }
    }
}
