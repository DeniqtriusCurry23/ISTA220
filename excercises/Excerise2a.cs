using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerise2a
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numArray = new int[10];                                    

            Console.WriteLine("Enter ten numbers to add together");

            int count = 0;

            while (count < 10)                                                       

            {                                                                   

                count++;                                                           

                Console.Write($"{count}: ");

                numArray[count - 1] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"The sum of your numbers is " + numArray);
        }
    }
}
