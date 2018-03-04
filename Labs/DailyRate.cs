using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyRate
{
    class Program
    {
        static void Main(string[] args)
        {
            (new Program()).run();
        }
        
        void run()
        {
            double dailyRate = readDouble("Enter your daily rate: ");
            int noOfDays = susan("Enter the number of days: ");
            writeFee(calculateFee(dailyRate, noOfDays));

           }

        private void writeFee(double v)
        {
            //throw new NotImplementedException();
            Console.WriteLine($"The consultant's fee is:" +
                $" {v *1.1}");
        }

        private double calculateFee(double dailyRate, int noOfDays)
        {
            //throw new NotImplementedException();
            double rv = dailyRate * noOfDays;
            return rv;

           
        }

        private int susan(string v)
        {
            //throw new NotImplementedException();
            Console.Write(v);
            string anything = Console.ReadLine();
            return int.Parse(anything);
        }

        private double readDouble(string user_prompt)
        {
            //throw new NotImplementedException()
            Console.Write(user_prompt);
            string line = Console.ReadLine();
            return double.Parse(line);
           
        }
    }
}
