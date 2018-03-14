using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingExcerise
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Triangle();
                hemipshere();
                circle();
                quadratic();
            }
            catch (FormatException fe)
            {
                Console.WriteLine("Only numerical values please");
                Triangle();
                hemipshere();
                circle();
                quadratic();
                return;
            }


            void Triangle()
              
            {
                
                try
                {
                    Console.Write("Enter three values for a triangle:");
                    int a = int.Parse(Console.ReadLine());
                    if (a < 0)
                    {
                        Console.WriteLine("Number must be greater then 0");

                    }
                    else
                    {
                        int b = int.Parse(Console.ReadLine());
                        int c = int.Parse(Console.ReadLine());
                        int p = (a + b + c) / 2;
                        Console.WriteLine($"The area of the triangle is {Math.Sqrt(p * (p - a) * (p - b) * (p - c))}");
                        return;
                    }
                }
                catch(FormatException fe)
                {
                    Console.WriteLine("Numbers only greater then 0");
                    return;
                }
                
            }

            void hemipshere()

            {
                Console.Write("Enter radius amount");
                float r = float.Parse(Console.ReadLine());
                Console.WriteLine($"The volume of your hemisphere is {(Math.PI) * (4 / 3) * (r * r * r) / 2}");
                return;
            }

            void circle()

            {
                //circle

                Console.Write("Enter the radius:");
                float r = float.Parse(Console.ReadLine());
                Console.WriteLine($"The area of your circle is {Math.PI * r * r}");
                Console.WriteLine($"The circumference of your circle is {Math.PI * 2 * r}");
                Console.WriteLine("What a great Calculation!");
                return;
            }
            void quadratic()
            {

                Console.Write("Enter three values to solve for x :");
                int a = int.Parse(Console.ReadLine());
                if (a < 0)
                {
                    Console.WriteLine("Only positive numbers please");
                    quadratic();
                }
                else
                {
                    int b = int.Parse(Console.ReadLine());
                    int c = int.Parse(Console.ReadLine());
                    Console.WriteLine($"The first value of x is {((-b - (Math.Sqrt(b * b) - 4 * (a * c))) / (2 * a))}");
                    Console.WriteLine($"The second value of x is {((-b + (Math.Sqrt(b * b) - 4 * (a * c))) / (2 * a))}");
                    Console.WriteLine("Thank you have a nice day!");
                }

            }


        }
    }
}