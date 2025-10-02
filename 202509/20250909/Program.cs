using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using System.Text;

public class Program
{
    public static readonly string filePath = "./greeting.txt";
    static void code10_1()
    {
        if (File.Exists(filePath))
        {
            using var reader = new StreamReader(filePath, Encoding.UTF8);
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                Console.WriteLine(line);
            }
        }
    }

    static void code10_2()
    {
        var lines = File.ReadAllLines(filePath, Encoding.UTF8);
        foreach (var line in lines)
        {
            Console.WriteLine(line);
        }
    }

    static void code10_3_5()
    {
        //var lines = File.ReadLines(filePath, Encoding.UTF8);
        /*
        var lines = File.ReadLines(filePath).Take(10).ToArray();
        foreach (var line in lines)
        {
            Console.WriteLine(line);
        }
        */
        int a_count = File.ReadLines(filePath).Count(s => s.Contains("人"));
        Console.WriteLine(a_count);
    }

    static void code10_6()
    {
        var lines = File.ReadLines(filePath, Encoding.UTF8)
            .Where(s => !String.IsNullOrWhiteSpace(s))
            .ToArray();
        foreach (var line in lines)
        {
            Console.WriteLine(line);
        }
    }

    static void code10_7()
    {
        var lines = File.ReadLines(filePath);
        var exists = lines.Where(s => !String.IsNullOrEmpty(s)).Any(s => s.All(c => Char.IsAsciiDigit(c)));
        Console.WriteLine(exists);
    }

    static void code10_9()
    {
        var lines = File.ReadLines(filePath).Select((s, ix) => $"{ix + 1,4}: {s}");
        foreach (var line in lines)
        {
            Console.WriteLine(line);
        }
    }

    static void Main(string[] args)
    {
        //code10_1();
        //code10_2();
        //code10_3_5();
        //code10_6();
        //code10_7();
        code10_9();
    }
}