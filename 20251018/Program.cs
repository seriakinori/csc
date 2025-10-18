using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Threading.Tasks;

public class code14_20 {
    private static int Get5000thPrime()
    {
        return GetPrimes().Skip(4999).First();
    }
    private static int Get6000thPrime()
    {
        return GetPrimes().Skip(5999).First();
    }

    static IEnumerable<int> GetPrimes()
    {
        for (int i = 2; i < int.MaxValue; i++)
        {
            bool isPrime = true;
            for (int j = 2; j < i; j++)
            {
                if (i % j == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            if (isPrime)
            {
                yield return i;
            }
        }
    }

    public static async Task Run()
    {
        var sw = Stopwatch.StartNew();
        var task1 = Task.Run(() => Get5000thPrime());
        var task2 = Task.Run(() => Get6000thPrime());
        var prime1 = await task1;
        var prime2 = await task2;
        sw.Stop();
        Console.WriteLine(prime1);
        Console.WriteLine(prime2);
        Console.WriteLine($"Elapsed time:{sw.ElapsedMilliseconds} ms");
    }
}
public class Program{
    public static async Task Main(string[] args)
    {
        await code14_20.Run();
    }
}

