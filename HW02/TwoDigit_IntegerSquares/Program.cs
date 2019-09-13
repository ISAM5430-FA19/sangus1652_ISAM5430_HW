using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoDigit_IntegerSquares
{
    class Program
    {
        static void Main(string[] args)
        {
            
            for (int i = 1; i <= 9; i++)
            {
                int num = i * i;
                if (num > 10 && num < 99)
                {
                    Console.WriteLine(num);
                }
                            
            }
            
            Console.ReadLine();
        }
    }
}
