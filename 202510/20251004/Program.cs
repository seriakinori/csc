using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections.Generic;

class Program
{
    static void code11_18()
    {
        var text = "あああアアアいいいイイイうううウウウ";
        var pattern = @"(\p{IsKatakana}{3}).*(\p{IsKatakana}{3}).*(\p{IsKatakana}{3})";
        var matches = Regex.Matches(text, pattern);
        foreach (Match m in matches)
        {
            Console.WriteLine($"'{m.Groups[0]}'");
        }
    }

    static void code11_21()
    {
        var text = "<a><b>AAAA</b><c><d>BBBB</d></c></a>";
        //var pattern = @"<(\W[^>]+)>";
        var pattern = @"<(\w+?)>";
        var matches = Regex.Matches(text, pattern);
        foreach (Match m in matches)
        {
            Console.WriteLine($"'{m.Groups[1].Value}'");
        }
    }

    static void code11_24()
    {
        var text = "aabcdefgghijkllmnopqrsstuvwwxyzz";
        var pattern = @"(\w)\1";
        var matches = Regex.Matches(text, pattern);
        foreach (Match m in matches)
        {
            Console.WriteLine($"'{m.Groups[1].Value}'");
        }
    }

    static void code11_25()
    {
        var text = "abaa cddc efee ghhg klkk mllm ";
        //var pattern = @"(\w)\w\1";
        var pattern = @"(\w)(\w)\2\1";
        var matches = Regex.Matches(text, pattern);
        foreach (Match m in matches)
        {
            Console.WriteLine($"'{m.Value}'");
        }
    }

    public static void Main(string[] args)
    {
        code11_25();
    }
}