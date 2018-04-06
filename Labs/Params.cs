using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParamsArray
{
    class Program
    {
        static void doWork()
        {
            //Console.WriteLine(Utill.Sum(null));
            Console.WriteLine(Utill.Sum());
            Console.WriteLine(Utill.Sum(10, 9, 8, 7, 6, 5, 4, 3, 2, 1));

        }

        static void Main()
        {
            try
            {
                doWork();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: {0}", ex.Message);
            }
        }
    }
}
