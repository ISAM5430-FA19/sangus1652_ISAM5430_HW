using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CounterControlledIterations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter third number");
            int c = int.Parse(Console.ReadLine());
            if (a >= b && a >= c)
            {
                if (b >= c)
                {
                    Console.WriteLine($"second largest number is {b}");
                }
                else
                {
                    Console.WriteLine($"second largest number is {c}");
                }
            }
            else if (b >= a && b >= c)
            {
                if (a >= c)
                {
                    Console.WriteLine($"second largest number is {a}");
                }
                else
                {
                    Console.WriteLine($"second largest number is {c}");
                }

            }
            else if (a >= b)
            {
                Console.WriteLine($"second largest number is {a}");

            }
            else
            {

                Console.WriteLine($"second largest number is {b}");
            }
            Console.ReadLine();
        }
    }
}