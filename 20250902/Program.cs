using System;
using System.Linq;
using System.Collections.Generic;
using System.Globalization;

class Program
{
    static void a6_1()
    {
        string s1 = Console.ReadLine();
        string s2 = Console.ReadLine();
        if (string.Compare(s1, s2, ignoreCase: true) == 0)
        {
            Console.WriteLine("equals");
        }
        else
        {
            Console.WriteLine("not equals");
        }
    }

    static void a6_2()
    {
        string s = Console.ReadLine();
        if (int.TryParse(s, out int num))
        {
            Console.WriteLine("{0:#,#}", num);
        }
        else
        {
            Console.WriteLine("not convertable string");
        }
    }

    static void a6_3()
    {
        
    }


    public static void Main(string[] args)
    {
        //a6_1();
        a6_2();
    }
}