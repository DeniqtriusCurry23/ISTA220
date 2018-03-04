using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playball
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum;
            int y;
            int count;
            Console.WriteLine("Input Values between 1-100 of all test scores");
            Console.WriteLine("How many test scores will you be entering?");
            int x = int.Parse(Console.ReadLine());

            {
                Console.WriteLine("The first value is ?");
                sum = int.Parse(Console.ReadLine());

                count = 1;

                Get_Average();
                Console.WriteLine("Test Value? : " );
                Call_GetAverage();
                Repeat();

                Get_Average();
                Console.WriteLine($"The next value is {count}:");
                Call_GetAverage();
                Get_Average();
                Console.WriteLine($"The next value is {count}:");
                Call_GetAverage();
         

                void Get_Average()

                {
                    if (sum < 100)
                        Console.WriteLine("Enter another value : ");
                    sum += int.Parse(Console.ReadLine());

                    count++;
                    Console.WriteLine($"The Grade Average is " + (sum / count));
                    Call_GetAverage();
                    return;

                }
                void Call_GetAverage()
                {
                    if (sum < 1000) ; Get_Average();  Grade_Average();
                }
                void Grade_Average()
                {
                    if (sum > 80)
                    {
                        Console.WriteLine("Your Grade is a B");
                    }
                    else if
                      (sum > 70)
                    {
                        Console.WriteLine("Your Grade is a C");
                    }

                    else if
                        (sum > 60)
                    {
                        Console.WriteLine("Your Grade is a D");
                    }

                }
                void Repeat()
                {
                    if (x >= 5)
                    {

                        Get_Average();
                        Get_Average();
                        Get_Average();
                        Get_Average();
                        Get_Average();
                    }
                    else if (x >= 10)
                    {
                        Get_Average();
                        Get_Average();
                        Get_Average();
                        Get_Average();
                        Get_Average();
                        Get_Average();
                        Get_Average();
                        Get_Average();
                        Get_Average();
                        Get_Average();


                    }


                }

            }
        }
          
    }
}
        
