using System;
using System.Collections.Generic;
using System.Globalization;

public class Program
{
    static void q1(){
        var v = Console.ReadLine();
        int n = 0;
        bool isInt = int.TryParse(v, out n);
        if (!isInt)
        {
            Console.WriteLine("not int");
            return;
        }
        if (n < 0)
        {
            Console.WriteLine(n);
        }
        else if (0 <= n && n < 100)
        {
            Console.WriteLine(n * 2);
        }
        else if (100 <= n && n < 500)
        {
            Console.WriteLine(n * 3);
        }
        else
        {
            Console.WriteLine(n);
        }
    }

    static void q2()
    {
        var line = Console.ReadLine();
        if (!int.TryParse(line, out var num)){
            Console.WriteLine("Wrong Value");
            return;
        }

        switch (num) {
            case < 0:
                Console.WriteLine(num);
                break;
            case < 100:
                Console.WriteLine(num*2);
                break;
            case < 500:
                Console.WriteLine(num*3);
                break;
            default :
                Console.WriteLine(num);
                break;
        }

    }

    static void q3()
    {
        var line = Console.ReadLine();
        if (!int.TryParse(line, out int num))
        {
            Console.WriteLine("Wrong Value");
            return;
        }

        var text = num switch
        {
            < 0 => num,
            < 100 => num * 2,
            < 500 => num * 3,
            _ => num,
        };

        Console.WriteLine(text);
    }
    public static void Main(string[] args)
    {
        q3();
    }
}