using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberDoublingPreviousNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int product = 1;
            while(product < 100)
            { 
                Console.WriteLine(product);
                product = product * 2;
            }
            Console.ReadLine();
        }
    }
}
