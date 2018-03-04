using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercize1d
{
    class Program
    {
        //solve for x
        //identify the values of a b and c
        //insert the values of a b and c
        //solve for a b and c to find x
        static void Main(string[] args)
        {
            Console.Write("Enter three values to solve for x :");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine($"The first value of x is {((-b - (Math.Sqrt(b*b)- 4 * (a * c))) / (2*a))}");
            Console.WriteLine($"The second value of x is {((-b + (Math.Sqrt(b*b) - 4 * (a*c))) / (2 * a))}");
            Console.WriteLine("Thank you have a nice day!");
        }
    }
}
