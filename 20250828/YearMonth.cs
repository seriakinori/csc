
using System;
using System.Linq;
using System.Collections.Generic;

public class YearMonth
{
    public int Year { get; init; }
    public int Month { get; init; }

    public YearMonth(int year, int month)
    {
        Year = year;
        Month = month;
    }

    public bool Is21Century => 2001 <= Year && Year <= 2100;

    public YearMonth AddOneMonth()
    {
        if (Month == 12)
        {
            return new YearMonth(Year + 1, 1);
        }
        else
        {
            return new YearMonth(Year, Month + 1);
        }
    }
}