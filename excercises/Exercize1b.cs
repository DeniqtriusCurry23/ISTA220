using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excerize1b
{
    class Program
    {
        //im going 
        //prompt user
        //what is the radius
        //4over3 times pie times radius cubed divided by 2

        static void Main(string[] args)
        {
            Console.Write("Enter radius amount");
            float r = float.Parse(Console.ReadLine());
            Console.WriteLine($"The volume of your hemisphere is {(Math.PI) * ( 4 / 3) * (r * r * r) / 2}");
        }
    }
}
