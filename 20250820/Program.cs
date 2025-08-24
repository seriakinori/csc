using System;
using System.Linq;

public class Program
{
    public static void Main(string[] args)
    {
        List<string> a = ["abc", "Abc", "ABc", "ABC", "aBc", "aBC"];
        var b = a.Find(s => s.Count() == 10 );
        Console.WriteLine(b ?? "unknown");
    }
}