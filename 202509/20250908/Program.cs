using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Globalization;

class Program
{
    static void code9_1()
    {
        var now = DateTime.Now;
        Console.WriteLine(now.ToString("yyyy/MM/dd HH:mm"));
        Console.WriteLine(now.ToString("yyyy年MM月dd日 HH時mm分ss秒"));
        var culture = new CultureInfo("ja-JP");
        culture.DateTimeFormat.Calendar = new JapaneseCalendar();
        var era = culture.DateTimeFormat.Calendar.GetEra(now);
        var eraName = culture.DateTimeFormat.GetEraName(era);
        Console.WriteLine(now.ToString("gg y年 M月 d日(dddd)", culture));
    }

    static DateTime code9_2_1(DateTime date, DayOfWeek dayOfWeek)
    {
        var nextweek = date.AddDays(7);
        var days = (int)dayOfWeek - (int)(date.DayOfWeek);
        return nextweek.AddDays(days);
    }

    static int code9_2_2(DateOnly birthDay, DateOnly targetDay)
    {
        var age = targetDay.Year - birthDay.Year;
        if (targetDay < birthDay.AddYears(age))
        {
            age--;
        }
        return age;
    }

    static void Main(string[] args)
    {
        //code9_1();
        //Console.WriteLine(code9_2_1(DateTime.Now, DayOfWeek.Monday));
        //Console.WriteLine(code9_2_2(new DateOnly(2005,2,4), DateOnly.FromDateTime(DateTime.Now)));
        var tw = new TimeWatch();
        tw.Start();
        while (Console.ReadLine() is null)
        {
            continue;
        }
        TimeSpan duration = tw.Stop();
        //Console.WriteLine(duration.TotalMilliseconds);
        Console.WriteLine(duration.TotalSeconds);
    }
}

public class TimeWatch
{
    private DateTime begin;

    public void Start()
    {
        begin = DateTime.Now;
    }

    public TimeSpan Stop()
    {
        return DateTime.Now - begin;
    }
}