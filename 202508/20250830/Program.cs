using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.VisualBasic;
using System.Net.Security;

public class Program{
    public List<string> data;
    public Program()
    {
        data = new List<string>
        {
            "AAAA","BBBB","CCCC","abcd","abCD","ABcd","aabb","ccdd"
        };
    }

    public static void Main(string[] args)
    {
        Program p = new Program();
        /*
        do
        {
            var name = Console.ReadLine();
            if (string.IsNullOrEmpty(name))
            {
                break;
            }
            var index = p.data.FindIndex(s => s == name);
            Console.WriteLine(index);
        } while (true);
        var count = p.data
            .Where(s => s.Contains("ab"))
            .ToArray();
        foreach (var c in count) {
            Console.WriteLine(c);
        }
        */
        var selected = p.data
            .Where(s => s.StartsWith('a'))
            .Select(s => s.Length);
        foreach (var length in selected)
        {
            Console.WriteLine(length);
        }
    }
}