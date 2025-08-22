using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    static void q1()
    {
        var val = Console.ReadLine();

        if (!int.TryParse(val, out var n))
        {
            Console.WriteLine("cannot convert");
            return;
        }

        int output = n switch
        {
            <= 100 => n * 2,
            <= 500 => n * 3,
            _ => n
        };

        Console.WriteLine(output);
    }

    public static void Main(string[] args){
        q1();
    }
}