using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace positive_numbers_multiples_of_ten
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <10; i++)
            {
                int product = 10 * i;
                Console.WriteLine(product);
            }
            Console.ReadLine();
        }
    }
}
