using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Program20250819;
public class Program20250819{
    public static void Main(string[] args)
    {
        List<string> a = ["Abc", "ABC", "abc", "aBC", "AbC"];
        var l = a.Where(s => s.Contains('B'));
        foreach (string s in l) {
            Console.WriteLine(s);
        }
    }
}
