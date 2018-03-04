using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excerize1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the radius:");
            float r = float.Parse(Console.ReadLine());
            Console.WriteLine($"The area of your circle is {Math.PI * r * r}");
            Console.WriteLine($"The circumference of your circle is {Math.PI * 2 * r}");
              Console.WriteLine("What a great Calculation!");
        }
    }
}
     