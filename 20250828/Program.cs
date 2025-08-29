using System;
using System.Linq;
using System.Collections.Generic;

public class Program
{
    public static YearMonth? q1()
    {
        YearMonth[] yms = {
            new YearMonth(2001,5),
            new YearMonth(2011,3),
            new YearMonth(2021,8),
            new YearMonth(2025,8),
            new YearMonth(2091,5),
        };
        /*
        foreach (YearMonth ym in yms)
        {
            Console.WriteLine(ym.Year);
        }
        */
        foreach (YearMonth ym in yms)
        {
            if (ym.Is21Century)
            {
                return ym;
            }
        }

        return null;
    }
    public static void q3()
    {
        YearMonth[] yms = {
            new YearMonth(2001,5),
            new YearMonth(2011,3),
            new YearMonth(2021,8),
            new YearMonth(2025,8),
            new YearMonth(2091,5),
        };

        var array = yms
            .Select(ym => ym.AddOneMonth())
            .ToArray();
        foreach (YearMonth ym in array) {
            Console.WriteLine(ym.Year);
            Console.WriteLine(ym.Month);
        }
    }
    public static void Main(string[] args)
    {
        /*
        YearMonth ym = q1();
        Console.WriteLine(ym.Year);
        Console.WriteLine(ym.Month);
        */
        q3();
    }
}