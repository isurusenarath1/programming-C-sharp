using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Lab_Day_01_Q_1
{
    internal class Program
    {   
            static void Main(string[] args)
            {
                Console.WriteLine("What is your name?");
                string name = Console.ReadLine();
                Console.WriteLine("What is your batch?");
                string batch = Console.ReadLine();

                Console.WriteLine("Your name is {0} and your batch is {1}.", name, batch);
                Console.ReadLine();
            }
        
    }

}
   