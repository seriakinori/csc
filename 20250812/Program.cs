using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Program20250812
{
    public class Program20250812
    {
        private const double ratio = 0.3048;
        static double FeetToMeter(int feet)
        {
            return feet * ratio;
        }
        static double MeterToFeet(int meter)
        {
            return meter / ratio;
        }

        static void PrintFeetToMeterList(int start, int stop)
        {
            for (int feet = start; feet <= stop; feet++)
            {
                double meter = FeetToMeter(feet);
                Console.WriteLine($"{feet}ft = {meter:0.0000}m");
            }
        }

        static void PrintMeterToFeetList(int start, int stop)
        {
            for (int meter = start; meter <= stop; meter++)
            {
                double feet = MeterToFeet(meter);
                Console.WriteLine($"{meter}m = {feet:0.0000}ft");
            }
        }

        public static void Main(string[] args)
        {
            if (args.Length >= 1 && args[0] == "-tom")
            {
                PrintFeetToMeterList(1, 10);
            }
            else
            {
                PrintMeterToFeetList(1, 10);
            }
        }

    }
}