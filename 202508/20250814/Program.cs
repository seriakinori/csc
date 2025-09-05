using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace Program20250814;

class Program20250814
{
    public delegate bool Judgement(int value);

    static int Count(int[] numbers, Judgement judge)
    {
        int count = 0;
        foreach (int n in numbers)
        {
            if (judge(n) == true)
            {
                count++;
            }
        }
        return count;
    }

    static bool isEven(int a)
    {
        return true;
    }
    public void Main()
    {
        Judgement judge = isEven;
        int[] a = new int[] { 3, 56, 7, 2, 7, 8, 3, 2, 4, 68 };
        Console.WriteLine(Count(a, isEven));

        var codes = new List<string>
        {
            "AAA","BBB","CCC","DDD","EEE","FFF","GGG","HHH"
        };

        //var exists = codes.Exists(s => s[0]== 'A');
        //var a = codes.Find(s => s.Length == 2);
        //var a = codes.FindIndex(s => s == "DDD");
        /*
        var a = codes.FindAll(s => s.Length == 3);
        foreach(string i in a)
            Console.WriteLine(i);
        */
        //var a = codes.RemoveAll(s => s.Contains("BB"));
        //codes.ForEach(s => Console.WriteLine(s));
        var lowerList = codes.ConvertAll(s => s.ToLower());
        lowerList.ForEach(s => Console.WriteLine(s));
        //Console.WriteLine(a);

    }


    
}