using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__lab_day_02_Q_02
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
            int subtraction = firstNumber - secondNumber;
            int multiplication = firstNumber * secondNumber;
            float divition = firstNumber / secondNumber;

            Console.WriteLine("The sum of the two numbers is: {0}", sum);
            Console.WriteLine("The subtraction of the two numbers is: {0}", subtraction);
            Console.WriteLine("The multiplication of the two numbers is: {0}", multiplication);
            Console.WriteLine("The divition of the two numbers is: {0}", divition);
            Console.ReadKey();
        }
    }
}
