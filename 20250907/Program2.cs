using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

public class Program2
{
    static void code9_1_4()
    {
        var dt1 = new DateTime(2025, 9, 7);
        var dt2 = new DateTime(2025, 9, 7, 16, 0, 0);

        Console.WriteLine(DateTime.Today);
        var now = DateTime.Now;
        Console.WriteLine(now.Year);
        Console.WriteLine(now.Month);
        Console.WriteLine(now.Day);
        Console.WriteLine(now.Hour);
        Console.WriteLine(now.Month);
        Console.WriteLine(now.Second);
        Console.WriteLine(now.Millisecond);
    }

    static void code9_4()
    {
        var today = DateTime.Today;
        DayOfWeek dayOfWeek = today.DayOfWeek;
        if (dayOfWeek == DayOfWeek.Sunday)
        {
            Console.WriteLine("Today is Sunday");
        }
        else
        {
            Console.WriteLine("Not is Sunday");
        }
    }

    static void code9_7()
    {
        if (DateTime.TryParse("2023/4/8", out var dt1)) {
            Console.WriteLine(dt1);
        }
        if (DateTime.TryParse("2023/4/8 16:14:32", out var dt2)) {
            Console.WriteLine(dt2);
        }
        if (DateTime.TryParse("令和7年9月7日 11時52分39秒", out var dt)) {
            Console.WriteLine(dt);
        }
    }

    static void code9_9()
    {
        var date = new DateTime(2025, 8, 9, 16, 23, 40);
        Console.WriteLine(date.ToString("yyyy-MM-dd"));
        Console.WriteLine(date.ToString("yyyy年M月d日(ddd)"));
        Console.WriteLine(date.ToString("yyyy年M月d日(dddd)"));
        Console.WriteLine(date.ToString("yyyy年MM月dd日 HH:mm:ss"));
        Console.WriteLine(date.ToString("tt hh:mm"));
        Console.WriteLine(date.ToString("HH字mm分ss秒"));
    }

    static void code9_11()
    {
        var today = DateTime.Today;
        var str = $"{today.Year}年{today.Month,2}月{today.Day,2}日";
        Console.WriteLine(str);
    }

    static void code9_12()
    {
        var date = new DateTime(2025, 7, 29);
        var culture = new CultureInfo("ja-JP");
        culture.DateTimeFormat.Calendar = new JapaneseCalendar();
        var str = date.ToString("ggyy年M月d日",culture);
        Console.WriteLine(str);
    }

    static void code9_13()
    {
        var date = new DateTime(1940, 8, 6);
        var culture = new CultureInfo("ja-Jp");
        culture.DateTimeFormat.Calendar = new JapaneseCalendar();
        var era = culture.DateTimeFormat.Calendar.GetEra(date);
        var eraName = culture.DateTimeFormat.GetEraName(era);
        Console.WriteLine(eraName);
        Console.WriteLine(culture.DateTimeFormat.GetAbbreviatedEraName(era));
    }

    static void code9_14()
    {
        var date = new DateTime(2025, 9, 7);
        var culture = new CultureInfo("ja-JP");
        culture.DateTimeFormat.Calendar = new JapaneseCalendar();

        var dayOfWeek = culture.DateTimeFormat.GetDayName(date.DayOfWeek);
        Console.WriteLine(dayOfWeek);
        Console.WriteLine(culture.DateTimeFormat.GetAbbreviatedDayName(date.DayOfWeek));
    }

    static void code9_15_16()
    {
        var dt1 = new DateTime(2025, 9, 7, 19, 1, 1);
        var dt2 = DateTime.Now;
        Console.WriteLine(dt1 < dt2);
        Console.WriteLine(dt1.Date == dt2.Date);
    }

    static void code9_17_18()
    {
        var now = DateTime.Now;
        var future = now + new TimeSpan(1, 20, 0);
        Console.WriteLine(future);
        var past = now - new TimeSpan(1, 20, 0);
        Console.WriteLine(past);
    }

    static void code9_19()
    {
        var today = DateTime.Today;
        var future = today.AddDays(9);
        var past = today.AddDays(-8);
        Console.WriteLine(future);
        Console.WriteLine(past);
    }

    static void code9_20()
    {
        var date = new DateTime(2024, 5, 23);
        var future = date.AddYears(1).AddMonths(3).AddDays(15);
        Console.WriteLine(future);
    }

    static void code9_22()
    {
        var dt1 = new DateTime(2025, 9, 1, 19, 1, 1);
        var dt2 = DateTime.Now;
        TimeSpan diff = dt2.Date - dt1.Date;
        Console.WriteLine(diff.Days);
    }

    static void code9_23()
    {
        var today = DateTime.Today;
        int day = DateTime.DaysInMonth(today.Year, today.Month);
        var endOfMonth = new DateTime(today.Year, today.Month, day);
        Console.WriteLine(endOfMonth);
    }

    static void code9_24()
    {
        var today = DateTime.Today;
        int dayOfYear = today.DayOfYear;
        Console.WriteLine(dayOfYear);
    }

    static DateTime NextDay(DateTime date, DayOfWeek dayOfWeek)
    {
        var days = (int)dayOfWeek - (int)(date.DayOfWeek);
        if (days <= 0)
        {
            days += 7;
        }
        return date.AddDays(days);
    }

    static int GetAge(DateTime birthday, DateTime targetDay)
    {
        var age = targetDay.Year - birthday.Year;
        if (targetDay < birthday.AddYears(age))
        {
            age--;
        }
        return age;
    }

    static int NthWeek(DateTime date)
    {
        var firstDay = new DateTime(date.Year, date.Month, 1);
        var firstOfWeek = (int)(firstDay.DayOfWeek);
        return (date.Day + firstOfWeek - 1) / 7 + 1;
    }

    static DateTime DayOfNthWeek(int year, int month, DayOfWeek dayOfWeek, int nth)
    {
        var firstDay = Enumerable.Range(1, 7)
            .Select(d => new DateTime(year, month, d))
            .First(d => d.DayOfWeek == dayOfWeek)
            .Day;

        var day = firstDay + (nth - 1) * 7;
        return new DateTime(year, month, day);
    }

    static void Main(string[] args)
    {

        //code9_1_4();
        //code9_4();
        //code9_7();
        //code9_9();
        //code9_11();
        //code9_12();
        //code9_13();
        //code9_14();
        //code9_15_16();
        //code9_17_18();
        //code9_19();
        //code9_20();
        //code9_22();
        //code9_23();
        //code9_24();
        //Console.WriteLine(NextDay(DateTime.Now.Date, DateTime.Now.DayOfWeek).DayOfWeek);
        //Console.WriteLine(GetAge(new DateTime(1941,1,1), DateTime.Now.Date));
        //Console.WriteLine(NthWeek(new DateTime(1986, 1, 8)));
        Console.WriteLine(DayOfNthWeek(2025, 9, DayOfWeek.Sunday, 4));
    }
}
