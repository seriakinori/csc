using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections.Generic;

class Program
{
    static void code11_1()
    {
        var strings = new[] { "abab", "cdcd", "efef", "baba", "eded" };
        var regex = new Regex(@"(a|e)(b|f)(a|e)(b|f)");
        var count = strings.Count(s => regex.IsMatch(s));
        Console.WriteLine($"{count} line matched.");
    }

    static void column_p254()
    {
        var text = "abab\ncdcd\nefef\nbaba\neded";
        var pattern = @"^[a-d]{4}$";
        var matches = Regex.Matches(text, pattern, RegexOptions.Multiline);
        foreach(Match m in matches){
            Console.WriteLine($"{m.Index} {m.Value}"); 
        }
    }

    static void code11_7()
    {
        var text = "かかカカ";
        Match match = Regex.Match(text, @"\p{IsKatakana}+");
        if (match.Success)
        {
            Console.WriteLine($"{match.Index} {match.Value}");
        }
    }

    static void code11_8()
    {
        var text = "abab\ncdcd\nefef\nbaba\neded\n";
        var regex = @"(a|e)(b|d|f)(a|e)(b|d|f)\n";
        var matches = Regex.Matches(text, regex);
        foreach (Match m in matches)
        {
            Console.WriteLine($"{m.Index} {m.Length} {m.Value}");
        }
    }

    public static void Main(string[] args)
    {
        //code12_1();
        //column_p254();
        //code11_7();
        code11_8();
    }
}