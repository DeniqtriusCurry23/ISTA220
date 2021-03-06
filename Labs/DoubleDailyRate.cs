﻿using System;
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

            double fee = calculateFee(thedailyRate: 375.0);
            Console.WriteLine($"Fee is  {fee}");

        }

        private double calculateFee(double thedailyRate = 500.0, int noOfDays = 1)
        {
            Console.WriteLine("CalculateFee using two optional parameters");
            return thedailyRate * noOfDays;

        }
        private double calculateFee(double dailyRate = 500.0)
        {
            Console.WriteLine("Calculate using on optional parameter");
            int defaultNoOfDays = 1;
            return dailyRate * defaultNoOfDays;
        }

        private double calculateFee()
    {
        Console.WriteLine("Calculate using hardcoded values");
        double defaultDailyRate = 400.0;
        int defaultNoOfDays = 1;
        return defaultDailyRate * defaultNoOfDays;

    }
}
    
}
