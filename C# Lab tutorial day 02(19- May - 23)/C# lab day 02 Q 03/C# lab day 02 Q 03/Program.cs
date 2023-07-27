using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__lab_day_02_Q_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the radius of the circle: ");
            double radius = Convert.ToDouble(Console.ReadLine());

            double area = Math.PI * radius * radius;
            double circumference = 2 * Math.PI * radius;

            Console.WriteLine("The area of the circle is: {0}", area);
            Console.WriteLine("The circumference of the circle is: {0}", circumference);
            Console.ReadKey();
        }
    }
}
