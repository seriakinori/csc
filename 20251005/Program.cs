using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Runtime.InteropServices;

class Program
{
    static void makeFile()
    {
        StreamWriter writer = new StreamWriter("sample.txt");
        using (writer)
        {
            //writer.WriteLine("12 345 67 8 9 098 7 6543 2 1");
            writer.WriteLine("version=\"v4.0\"");
            writer.WriteLine("version=\"v3.0\"");
            writer.WriteLine("Version=\"v4.0\"");
        }
    }
    static bool q11_1(string str)
    {
        var pat = @"^(090|080|070)-\d{4}-\d{4}$";
        if (Regex.IsMatch(str, pat))
        {
            return true;
        }
        return false;
    }

    static void q11_2(string fileName)
    {
        StreamReader reader = new StreamReader(fileName);
        var pat = @"\b(\d{3,})\b";
        using (reader)
        {
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                if (line is null)
                {
                    continue;
                }

                var matches = Regex.Matches(line, pat);
                foreach (Match m in matches)
                {
                    Console.WriteLine(m.Value);
                }
            }
        }
    }

    static void q11_3()
    {
        string[] texts = [
            "Time is money.",
            "What time is it?",
            "It will take time.",
            "We recoginized the timetable."
        ];
        var pattern = @"\btime\b";
        foreach(var text in texts)
        {
            var matches = Regex.Matches(text, pattern, RegexOptions.IgnoreCase);
            foreach (Match m in matches)
            {
                Console.WriteLine($"{m.Index} {text}");
            }
        }
    }

    static void q11_4(string fileName)
    {
        StreamReader reader = new StreamReader(fileName);
        var line = "";
        using (reader)
        {
            while (!reader.EndOfStream)
            {
                line += reader.ReadLine() + "\n";
            }
        }

        var pattern = @"(v|V)ersion=""(v4.0)""";
        var text = Regex.Replace(line,pattern,"version=\"v5.0\"");
        Console.WriteLine(text);
        StreamWriter writer = new StreamWriter("sample2.txt");
        using (writer)
        {
            writer.WriteLine(text);
        }

    }

    public static void Main(string[] args)
    {
        //Console.WriteLine(q11_1("090-9614-3322"));
        //Console.WriteLine(q11_1("09096143322"));
        makeFile();
        //q11_2("sample.txt");
        //q11_3();
        q11_4("sample.txt");
    }
}