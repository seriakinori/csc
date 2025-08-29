using System;
using System.Linq;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        YearMonth[] yms = {
                new YearMonth(2001,5),
                new YearMonth(2011,3),
                new YearMonth(2021,8),
                new YearMonth(2025,8),
                new YearMonth(2091,5),
        };

        var onelaters = yms.Select(ym => ym.AddOneMonth()).ToArray();

        foreach (YearMonth ym in onelaters)
        {
            Console.WriteLine(ym.Year);
            Console.WriteLine(ym.Month);
        }
    }
}