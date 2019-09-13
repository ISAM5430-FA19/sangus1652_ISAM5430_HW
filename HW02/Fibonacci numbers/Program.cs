using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b = 1, c = 0;
            Console.WriteLine("{0} {1}", a, b);
            for (int i = 2; i <= 25; i++)
            {
                c = a + b;
                Console.WriteLine(c);
                a = b;
                b=c;
            }
            Console.ReadLine();
        }
    }
}
