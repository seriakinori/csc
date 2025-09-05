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
        int year = Year;
        int month = Month;
        if (11 < month)
        {
            year += 1;
            month = 1;
        }
        else
        {
            month += 1;
        }
        YearMonth nextYearMonth = new YearMonth(year, month);
        return nextYearMonth;
    }

    /*
    public override string ToString()
    {
        return Year + "年" + Month + "月";
    }
    */

    public override string ToString() => $"{Year}年{Month}月";
}

public class Program
{
    public static void Main(string[] args)
    {
        return;
    }
}