using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections.Concurrent;


public class Book
{
    public string Title { get; init; } = string.Empty;
    public int Price { get; init; }
    public int Pages { get; init; }
}

class Program
{
    public static void q7_1()
    {
        int[] n = [5, 10, 17, 9, 3, 21, 10, 40, 21, 3, 35];
        // 1
        //Console.WriteLine(n.Max(s => s));
        // 2 
        //n.TakeLast(2).ToList().ForEach(Console.WriteLine);
        // 3 
        //n.Select(i => i.ToString("000")).ToList().ForEach(Console.WriteLine);
        // 4
        //n.Order().Take(3).ToList().ForEach(Console.WriteLine);
        // 5
        //Console.WriteLine(n.Distinct().Count(i => i > 10));
    }

    public static void q7_2()
    {
        var books = new List<Book> {
            new Book { Title = "C#プログラミングの新常識", Price = 3800, Pages = 378 },
            new Book { Title = "ラムダ式とLINQの極意", Price = 2500, Pages = 312 },
            new Book { Title = "ワンダフル・C#ライフ", Price = 2900, Pages = 385 },
            new Book { Title = "一人で学ぶ並列処理プログラミング", Price = 4800, Pages = 464 },
            new Book { Title = "フレーズで覚えるC#入門", Price = 5300, Pages = 604 },
            new Book { Title = "私でも分かったASP.NET Core", Price = 3200, Pages = 453 },
            new Book { Title = "楽しいC#プログラミング教室", Price = 2540, Pages = 348 },
        };
        // 1
        /*
        var a1 = books.Where(b => b.Title == "ワンダフル・C#ライフ");
        foreach (Book b in a1)
            Console.WriteLine("{0},{1}", b.Price, b.Pages);
        */
        // 2
        //Console.WriteLine(books.Count(b => b.Title.Contains("C#")));
        // 3
        //books.Where(b => b.Title.Contains("C#")).Select(b => b.Title).ToList().ForEach(Console.WriteLine);
        //Console.WriteLine(books.Where(b => b.Title.Contains("C#")).Average(b => b.Price));
        // 4
        //Console.WriteLine(books.Where(b => b.Price >= 4000).First().Title);
        // 5
        //Console.WriteLine(books.Where(b => b.Price < 4000).Max(b => b.Pages));
        // 6
        /*
        foreach (Book bk in books.Where(b => b.Pages >= 400).OrderByDescending(b => b.Price))
        {
            Console.WriteLine("Title:{0}, Price:{1}, Pages:{2}", bk.Title, bk.Price, bk.Pages);
        }
        */
        // 7
        books.Where(b => b.Title.Contains("C#") && b.Pages <= 500).Select(b => b.Title).ToList().ForEach(Console.WriteLine);

    }

    static void main()
    {
        //q7_1();
        q7_2();
        return;
    }
}