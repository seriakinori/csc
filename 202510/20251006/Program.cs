using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections.Generic;

class Program
{
    static bool code11_6(string line)
    {

        var pattern = @"([0-9A-Za-z\p{IsHiragana}\p{IsKatakana}])([0-9A-Za-z\p{IsHiragana}\p{IsKatakana}])([0-9A-Za-z\p{IsHiragana}\p{IsKatakana}])\2\1";
        return Regex.IsMatch(line, pattern);
    }

    public static void Main(string[] args)
    {
        Console.WriteLine(code11_6("madam"));
        Console.WriteLine(code11_6("12321"));
        Console.WriteLine(code11_6("トマト"));
        Console.WriteLine(code11_6("しんぶんし"));
        Console.WriteLine(code11_6("シンブンシ"));
    }
}