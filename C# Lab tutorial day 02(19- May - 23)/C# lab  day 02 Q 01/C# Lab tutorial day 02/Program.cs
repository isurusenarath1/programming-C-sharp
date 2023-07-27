using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Lab_tutorial_day_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number: ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            int sum = firstNumber + secondNumber;

            Console.WriteLine("The sum of the two numbers is: {0}", sum);
            Console.ReadKey();
        }
    }
}
