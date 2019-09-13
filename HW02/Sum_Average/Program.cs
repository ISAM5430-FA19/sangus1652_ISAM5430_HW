using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_Average
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the count of numbers");
            int count = int.Parse(Console.ReadLine());
            int n = 0;
            int sum = 0;
            float average = 0;
            for (int i = 1; i<=count; i++)
            {
                n=int.Parse(Console.ReadLine());
                sum = sum + n;     
            }
            Console.WriteLine(sum);
            average =(float) (sum) / (count);
            Console.WriteLine(average);
            Console.ReadLine();
        }
    }
}
