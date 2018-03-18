using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgammingExcerise4
{
    class Horse
    {
        private int Weight;
        private int Age;
        private string NumOfLegs;
        private string Meat;

        public Horse(int horseweight, int horseAge, string horseNumOfLegs, string horseMeat)
        {
            Weight = horseweight;
            Age = horseAge;
            NumOfLegs = horseNumOfLegs;
            Meat = horseMeat;

        }
        public void Thickness()
        {

            Console.WriteLine("The horse weighs" + "{0}", Weight);
            Console.ReadKey();

        }
        public void YearsOld()
        {
            Console.WriteLine("The horse is" + "{1}", Age + "" + "Years Old");
            Console.ReadKey();
        }
        public void Legs()
        {
            Console.WriteLine("The horse has" + "{2}", NumOfLegs + "" + "Legs");
            Console.ReadKey();
        }
        public void TypesofMeat()
        {
            Console.WriteLine("The horse has" + "{3}", Meat);
            Console.ReadKey();
        }

        class pigs
        {
            private int Weight;
            private int Age;
            private string NumOfLegs;
            private string Meat;

            public pigs(int pigweight, int pigAge, string pigNumOfLegs, string pigMeat)
            {
                Weight = pigweight;
                Age = pigAge;
                NumOfLegs = pigNumOfLegs;
                Meat = pigMeat;

            }
            public void Thickness()
            {

                Console.WriteLine("The pig weighs" + "{0}", Weight);
                Console.ReadLine();

            }
            public void YearsOld()
            {
                Console.WriteLine("The pig is" + "{1}", Age + "" + "Years Old");
                Console.ReadLine();
            }
            public void Legs()
            {
                Console.WriteLine("The pig has" + "{2}", NumOfLegs + "" + "Legs");
                Console.ReadLine();
            }
            public void TypesofMeat()
            {
                Console.WriteLine("The pig has" + "{3}", Meat);
                Console.ReadLine();
            }

        }
        class Cows
        {
            private int Weight;
            private int Age;
            private string NumOfLegs;
            private string Meat;

            public Cows(int Cowweight, int CowAge, string CowNumOfLegs, string CowMeat)
            {
                Weight = Cowweight;
                Age = CowAge;
                NumOfLegs = CowNumOfLegs;
                Meat = CowMeat;

            }
            public void Thickness()
            {

                Console.WriteLine("The cow weighs" + "{0}", Weight);
                Console.ReadLine();

            }
            public void YearsOld()
            {
                Console.WriteLine("The cow is" + "{1}", Age + "" + "Years Old");
                Console.ReadLine();
            }
            public void Legs()
            {
                Console.WriteLine("The cow has" + "{2}", NumOfLegs + "" + "Legs");
                Console.ReadLine();
            }
            public void TypesofMeat()
            {
                Console.WriteLine("The cow has" + "{3}", Meat);
                Console.ReadLine();
            }

        }
        class dog
        {
            private int Weight;
            private int Age;
            private string NumOfLegs;
            private string Meat;

            public dog(int dogweight, int dogAge, string dogNumOfLegs, string dogMeat)
            {
                Weight = dogweight;
                Age = dogAge;
                NumOfLegs = dogNumOfLegs;
                Meat = dogMeat;

            }
            public void Thickness()
            {

                Console.WriteLine("The dog weighs" + "{0}", Weight);
                Console.ReadLine();

            }
            public void YearsOld()
            {
                Console.WriteLine("The dog is" + "{1}", Age + "" + "Years Old");
                Console.ReadLine();
            }
            public void Legs()
            {
                Console.WriteLine("The dog has" + "{2}", NumOfLegs + "" + "Legs");
                Console.ReadLine();
            }
            public void TypesofMeat()
            {
                Console.WriteLine("The dog has" + "{3}", Meat);
                Console.ReadLine();
            }

        }

        class Program
        {
            static void Main(string[] args)
            {
                try
                {
                    Horse Bobby = new Horse(152, 12, "four", "Venison");
                    Bobby.YearsOld();
                    Bobby.Legs();
                    Bobby.TypesofMeat();
                    pigs Tommy = new pigs(76, 4, "five", "Bacon, Porkchops");
                    Tommy.YearsOld();
                    Tommy.Legs();
                    Tommy.TypesofMeat();
                    Cows Randy = new Cows(200, 5, "three", "Steak");
                    Randy.YearsOld();
                    Randy.Legs();
                    Randy.TypesofMeat();
                    dog Jacob = new dog(50, 3, "four", "dog meat");
                    Jacob.YearsOld();
                    Jacob.Legs();
                    Jacob.TypesofMeat();

                }
                catch (FormatException Fex)
                {
                    Console.WriteLine(Fex.Message);
                    Console.ReadKey();

                  
                }
                
            }
        }
    }
}

