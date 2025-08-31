using System;
using System.Linq;
using System.Collections.Generic;
using System.Globalization;
using System.Data;
using System.Text;

public class Program
{
    public static void code6_2(string str1, string str2)
    {

        if (String.Compare(str1, str2, ignoreCase: true) == 0)
        {
            Console.WriteLine("The same");
        }
        else
        {
            Console.WriteLine("Not same");
        }
    }

    public static void code6_3(string katakana, string hiragana)
    {
        var cultureinfo = new CultureInfo("ja-JP");
        if (String.Compare(katakana, hiragana, cultureinfo, CompareOptions.IgnoreKanaType) == 0)
        {
            Console.WriteLine("The same");
        }
        else
        {
            Console.WriteLine("Not same");
        }
    }

    public static void code6_4(string hankaku, string zenkaku)
    {
        var cultureinfo = new CultureInfo("ja-JP");
        if (String.Compare(hankaku, zenkaku, cultureinfo, CompareOptions.IgnoreWidth) == 0)
        {
            Console.WriteLine("The same");
        }
        else
        {
            Console.WriteLine("Not same");
        }
    }

    public static void code6_5(string str1, string str2)
    {
        var cultureinfo = new CultureInfo("ja-JP");
        if (String.Compare(str1, str2, cultureinfo, CompareOptions.IgnoreCase | CompareOptions.IgnoreWidth) == 0)
        {
            Console.WriteLine("The same");
        }
        else
        {
            Console.WriteLine("Not same");
        }
    }

    public static void code6_7()
    {
        string? str = "";
        if (str == String.Empty)
        {
            Console.WriteLine("The string is empty");
        }
    }

    public static void code6_8()
    {
        string str = null;
        if (String.IsNullOrWhiteSpace(str))
        {
            Console.WriteLine("The string is null or whitespace");
        }
    }

    public static void code6_9(string str){
        if (str.StartsWith("z"))
        {
            Console.WriteLine("The string starts with z");
        }
    }

    public static void code6_11(string str1)
    {
        if (str1.Contains("ab"))
        {
            Console.WriteLine("The string contains ab");
        }
        else
        {
            Console.WriteLine("The string does not contains ab");
        }
    }

    public static void code6_13(string str)
    {
        var ifExists = str.Any(c => Char.IsAsciiLetterLower(c));
        if (ifExists)
        {
            Console.WriteLine("Lower letter exists");
        }
        else
        {
            Console.WriteLine("Lower letter does not exist");
        }
    }

    public static void code6_14(string str)
    {
        var isAllDigits = str.All(c => Char.IsAsciiDigit(c));
        if (isAllDigits)
        {
            Console.WriteLine("All digits");
        }
        else
        {
            Console.WriteLine("Not All digits");
        }
    }

    public static void code6_15(string str)
    {
        var index = str.IndexOf("ab");
        Console.WriteLine(index);
    }

    public static string code6_16(string str)
    {
        int startIdx = str.IndexOf("ab") + "ab".Length;
        int endIdx = str.IndexOf("C", startIdx);
        //Console.WriteLine(idx);
        return str.Substring(startIdx, endIdx - startIdx);
    }

    public static void code6_19(string str)
    {
        var trim1 = str.TrimStart();
        var trim2 = str.TrimEnd();
        Console.WriteLine($"{trim1}:{trim2}");
        var trim3 = str.Trim();
        Console.WriteLine($"{trim3}");
    }

    public static void code6_20(string str)
    {
        Console.WriteLine(str.Remove(4, 4));
    }

    public static void code6_22(string str)
    {
        string replaced = str.Replace("abab","xyxy");
        Console.WriteLine(replaced);
    }

    public static void code6_23(string str)
    {
        Console.WriteLine(str.ToLower());
    }

    public static string code6_25(string s1, string s2, string s3)
    {
        return s1 + ":" + s2 + ":" + s3;
    }

    public static void code6_29(string str)
    {
        var s =  str.Split(" ");
        foreach (string c in s)
        {
            Console.WriteLine(c);
        }
    }

    public static void code6_31(string str)
    {
        var sb = new StringBuilder(100);
        foreach (var word in str.Split(" "))
        {
            sb.Append(word);
        }
        Console.WriteLine(sb);
    }

    public static void code6_35()
    {
        int n = 23456;
        var s1 = n.ToString();
        var s2 = n.ToString("aaa#abab");
        var s3 = n.ToString("000000");
        var s4 = n.ToString("#,0");

        Console.WriteLine(s1);
        Console.WriteLine(s2);
        Console.WriteLine(s3);
        Console.WriteLine(s4);

        decimal d = 9876.543m;
        var s5 = d.ToString();
        var s6 = d.ToString("#");
        var s7 = d.ToString("#,0.0");
        var s8 = d.ToString("#,0.00000");
        Console.WriteLine(s5);
        Console.WriteLine(s6);
        Console.WriteLine(s7);
        Console.WriteLine(s8);
    }

    public static void code6_39()
    {
        var a = 12;
        var b = 1000;
        Console.WriteLine($"{a,4}:{b,7}");
        Console.WriteLine($"{a,4}:{b:0000000}");
    }

    public static void Main(string[] args)
    {
        //string str1 = "カナ";
        //string str2 = "かな";
        //code6_2(str1, str2);
        //code6_3(str1, str2);
        //str1 = "A";
        //str2 = "Ａ";
        //code6_4(str1, str2);
        //str1 = "aaaa";
        //str2 = "ＡＡＡＡ";
        //code6_5(str1, str2);
        //code6_7();
        //code6_8();
        //code6_9("zyx");
        //code6_11("abab");
        //code6_11("bbaa");
        //code6_13("AAAa");
        //code6_13("AAAA");
        //code6_14("124f");
        //code6_14("1243");
        //code6_15("AAAAababCCCC");
        //Console.WriteLine(code6_16("AAAAabcdCCCC"));
        //code6_19("    abab    ");
        //code6_20("1234gtnt5678");
        //code6_22("AAAAababCCCC");
        //code6_23("AAAAababCCCC");
        //Console.WriteLine(code6_25("AAAA", "abab", "CCCC"));
        //code6_29("AAAA BBBB abab cdcd");
        //code6_31("AAAA BBBB abab cdcd");
        //code6_35();
        code6_39();
    } 
}