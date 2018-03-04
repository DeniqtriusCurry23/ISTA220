using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excerise2b
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter each of the ten 10 test scores");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double d = double.Parse(Console.ReadLine());
            double e = double.Parse(Console.ReadLine());
            double f = double.Parse(Console.ReadLine());
            double g = double.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double z = double.Parse(Console.ReadLine());

            double Average_Test_Scores = (a + b + c + d + e + f + g + x + y + z) / 10;

            if (Average_Test_Scores > 60)
            {
                Console.WriteLine("Your Grade is a D");

            }
            else if (Average_Test_Scores > 70)
            {
                Console.WriteLine("Your Grade is an C");
            }

            else if (Average_Test_Scores > 80)
            {
                Console.WriteLine("Your Grade is an B");
                  
                    }

            else if (Average_Test_Scores > 90)

            {
                Console.WriteLine("Your Grade is an A");
           
                    }

            }

        }
    }
}
