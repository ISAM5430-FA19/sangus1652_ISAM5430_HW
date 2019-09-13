using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalfofPreviousInteger
{
    class Program
    {
        static void Main(string[] args)
        {


            for (int j = 100; j > 0; j = j / 2)
            {
                Console.WriteLine(j);
            }
            //Console.ReadLine();
            for (float i = 100; i >=1; i = i / 2)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
