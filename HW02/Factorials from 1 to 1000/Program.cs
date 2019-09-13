using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorials_from_1_to_1000
{
    class Program
    {
        static void Main(string[] args)
        {
            int fact = 1;
            int i = 1;
            while (fact < 1000)
            {    
                fact = fact * i;
                if(fact<=720)
                {
                    Console.WriteLine(fact);
                }
                
                i++;
            }
            Console.ReadLine();
        }
    }
}
