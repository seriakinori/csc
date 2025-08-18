using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<string> a = ["Abc", "ABC", "abc", "aBC", "AbC"];
        foreach (string i in a)
        {
            if (i.Contains('b'))
            {
                Console.WriteLine(i);
            }
        }

        for (int i = 0; i < a.Count; i++)
        {
            if (a[i].Contains('b'))
                Console.WriteLine(a[i]);
        }

        int j = 0;
        while (j < a.Count)
        {
            if (a[j].Contains('b'))
                Console.WriteLine(a[j]);
            j++;
        }
    }
}