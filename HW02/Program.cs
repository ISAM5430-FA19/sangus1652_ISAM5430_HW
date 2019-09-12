using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first Integer");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second Integer");
            int num2 = int.Parse(Console.ReadLine());
            if (num1 == num2)
            {
                Console.WriteLine("Both the numbers are same");
            }
            else if (num1 > num2)
            {
                Console.WriteLine(num1 + "is larger");
            }
            else
            {
                Console.WriteLine(num2 + "is larger");
            }
            Console.ReadLine();
        }
    }
}
