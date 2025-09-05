using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.VisualBasic;



// 演習問題なので、意味のない名前空間になっているが、本来は適切な名前にする必要あり。
//  Exercise2で、このプロジェクトを参照に追加し利用している。
namespace CSharp.Exercise;

// 4.1.1
public class YearMonth {
    public int Year { get; init; }

    public int Month { get; init; }

    public YearMonth(int year, int month) {
        Year = year;
        Month = month;
    }

    // 4.1.2
    public bool Is21Century => 2001 <= Year && Year <= 2100;

    // 4.1.3
    public YearMonth AddOneMonth() {
        if (Month == 12) {
            return new YearMonth(this.Year + 1, 1);
        } else {
            return new YearMonth(this.Year, this.Month + 1);
        }
    }

    // 4.1.4
    public override string ToString() => $"{Year}年{Month}月";
}

public class Program
{
// 5.2.2
    static void Exercise2(YearMonth[] ymCollection) {
        foreach (var ym in ymCollection) {
            Console.WriteLine(ym);
        }
    }

    static YearMonth? FindFirst21(YearMonth[]? ymCollection)
    {
        foreach (YearMonth ym in ymCollection) {
            if ( ym.Is21Century ) {
                return ym;
            }
        }
        return null;
    }

    public static void Main(string[] args)
    {
        // 5.2.1
        var ymCollection = new YearMonth[] {
            new YearMonth(1980, 1),
            new YearMonth(1990, 4),
            new YearMonth(2000, 7),
            new YearMonth(2010, 9),
            new YearMonth(2024, 12),
        };

        /*
        var First21 = FindFirst21(ymCollection);
        if (First21 is not null)
        {
            Console.WriteLine(First21);
        }
        else
        {
            Console.WriteLine("None 21 century");
        }
        */

        var addymCollection = ymCollection
            .Select(ym => ym.AddOneMonth())
            .ToArray();
        foreach (var ym in addymCollection)
        {
            Console.WriteLine(ym);
        }

    }
}