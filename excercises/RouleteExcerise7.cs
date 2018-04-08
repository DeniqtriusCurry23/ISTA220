using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingExcerise7
{
    class Program
    {



        static void Main(string[] args)
        {
            int[] left = new int[] { 1, 4, 7, 10, 13, 16, 19, 22, 25, 28, 31, 34 };
            int[] middle = new int[] { 2, 5, 8, 11, 14, 17, 20, 23, 26, 29, 32, 35 };
            int[] right = new int[] { 3, 6, 9, 12, 15, 18, 21, 24, 27, 30, 33, 36 };

            int[] NewArr = new int[] { 0, 00, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15
                , 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36 };
            Random r = new Random();
            int RouleteBall = r.Next(00, 36);
            Console.WriteLine(RouleteBall);


            int[] red = new int[] { 1, 3, 5, 7, 12, 14, 16, 18, 19, 21, 23, 25, 27, 30, 32, 34, 36 };
            int[] black = new int[] { 2, 4, 6, 8, 10, 11, 13, 15, 17, 20, 22, 24, 26, 28, 29, 31, 33, 35 };

            if (black.Contains<int>(RouleteBall)) 
            {
                Console.WriteLine("The winning ball is black");
            }
            else
            {
                Console.WriteLine("The ball is red");
            }
            
                if (RouleteBall % 2 == 0)
                {

                    Console.WriteLine("Even bets win");
                }
                else if (RouleteBall % 2 != 0)
                {
                    Console.WriteLine("Odd bets win");
                }
                else
                {
                    Console.WriteLine("The Winning number is 0");
                }
            if ((RouleteBall  >= 0) && (RouleteBall < 18))

            {

                Console.WriteLine("1 to 18 bets win");

            }
            
            else if (RouleteBall > 18)

            {

                Console.WriteLine("19 to 36 bets win");

            }



        }



    }





            
 
}
