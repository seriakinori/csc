using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class Program
{

    static void code11_10()
    {
        var text = "aaaaababcdcdcbcb";
        var matches = Regex
            .Matches(text, @".b.b")
            .Cast<Match>()
            .OrderBy(x => x.Length);
        foreach (Match m in matches)
        {
            Console.WriteLine($"{m.Index} {m.Length} {m.Value}");
        }
    }
    static void code11_11()
    {
        var text = "aaaaababcdcdcbcb";
        var matches = Regex
            .Matches(text, @"([ab]{4})")
            .Cast<Match>()
            .OrderBy(x => x.Length);
        foreach (Match m in matches)
        {
            Console.WriteLine($"{m.Groups[0]}");
        }
    }

    static void code11_12()
    {
        var text = "aaaaababcdcdcbcb";
        var pattern = @".b.b";
        var replaced = Regex.Replace(text, pattern, "____");
        Console.WriteLine(replaced);
    }

    static void code11_13()
    {
        var text = "aaaaababcdcdcbcb";
        var pattern = @"(ab)ab";
        var replaced = Regex.Replace(text, pattern,"$1cd");
        Console.WriteLine(replaced);
    }
    static void code11_16()
    {
        var text = "1234567890";
        var pattern = @"^(\d{3})(\d{3})(\d{4})";
        var replaced = Regex.Replace(text, pattern,"$1-$2-$3");
        Console.WriteLine(replaced);
    }

    static void code11_17()
    {
        var text = "aaaaababcdcdcbcb";
        var pattern = @"c";
        var substr = Regex.Split(text, pattern);
        foreach(var m in substr)
            Console.WriteLine($"'{m}'");
    }

    public static void Main(string[] args)
    {
        code11_17();
    }
}