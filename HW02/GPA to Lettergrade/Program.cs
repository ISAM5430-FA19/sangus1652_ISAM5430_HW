using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPA_to_Lettergrade
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your gpa");
            decimal number = decimal.Parse(Console.ReadLine());
            decimal gpa = (int)(3 * number + 0.5m);
            Console.WriteLine(gpa);
            string grade = null;
            switch (gpa)
            {
                case 12:
                case 11:
                    {
                        grade = "A";
                        break;
                    }
                case 10:
                case 9:
                case 8:
                    {
                        grade = "B";
                        break;

                    }
                case 7:
                case 6:
                case 5:
                    {
                        grade = "C";
                        break;

                    }
                case 4:
                case 3:
                    {
                        grade = "D";
                        break;
                    }
                default:
                    {
                        grade = "F";
                        break;
                    }
            }
            if ((gpa == 11) || (gpa == 8) || (gpa == 5))
            {

                Console.WriteLine(grade + "-");
            }
            else if (gpa == 7 || gpa == 4)
            {
                Console.WriteLine(grade + "+");
            }
            else if (gpa == 12)
            {

                Console.WriteLine("Grade A");
            }
            else if (gpa == 9)
            {
                Console.WriteLine("Grade B");
            }
            else if (gpa == 6)
            {
                Console.WriteLine("Grade C");
            }
            else if (gpa == 3)
            {
                Console.WriteLine("Grade D");
            }
            Console.ReadLine();
        }
    }
}