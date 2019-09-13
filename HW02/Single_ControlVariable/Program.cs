using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_ControlVariable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of integers");
            int count = int.Parse(Console.ReadLine());
            //int num = 0;
            int positive_count = 0;
            int zero_count = 0;
            int even_count = 0;
           // int temp = 0;
           // bool is_True= true;

            
            

            for (int i = 0; i <= count; i++)
            {

                int[] intnum = new int[count];

                if (intnum[i] > 0)
                {
                    positive_count++;
                }
                if (intnum[i] == 0)
                {
                    zero_count++;
                }
                if (intnum[i] == 0)
                {
                    even_count++;
                }
            }
           

            Console.WriteLine("The positive count is:"+positive_count);
            Console.WriteLine("The zero count is :"+ zero_count);
            Console.WriteLine("The even count is: "+ even_count);
            Console.ReadLine();
        }
    }
}
