using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__lab_day_05_Q_1
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            int num1, num2, choice;

            Console.WriteLine("Enter the first number: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What arithmetic operation would you like to perform?");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            Console.WriteLine("Enter your choice: ");
            choice = Convert.ToInt32(Console.ReadLine());

            int answer;
            switch (choice)
            {
                case 1:
                    answer = CalculateValues.Addition(num1, num2);
                    break;
                case 2:
                    answer = CalculateValues.Subtraction(num1, num2);
                    break;
                case 3:
                    answer = CalculateValues.Multiplication(num1, num2);
                    break;
                case 4:
                    answer = CalculateValues.Division(num1, num2);
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    return;
            }
            Console.WriteLine("The answer is: {0}", answer);
            Console.ReadKey();
        }
    }
}

