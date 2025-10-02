using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections.Frozen;
using System.Data;

public class Book
{
    public string Title { get; init; } = string.Empty;
    public int Price { get; init; }
    public int Pages { get; init; }
}

public class BookShelf {
    public List<Book> books = new List<Book>
    {
        new Book{Title = "Pride and Prejudice", Price = 500, Pages = 400},
        new Book{Title = "Crime and Punishment", Price = 900, Pages = 700},
        new Book{Title = "The tale of two cities", Price = 600, Pages = 500},
        new Book{Title = "Madame Bovary", Price = 600, Pages = 400},
        new Book{Title = "Faust", Price = 800, Pages = 700},
        new Book{Title = "War and Peace", Price = 1000, Pages = 1000},
        new Book{Title = "Les fleurs du mal", Price = 800, Pages = 300},
    };
}

class Program
{
    static void code7_9()
    {
        var numbers = new List<int>{8,6,87,4,2,4,6,8,9,2,3,5,6};
        var average = numbers.Average();
        Console.WriteLine(average);
    }
    public static void code7()
    {
        BookShelf bs = new BookShelf();
        //Console.WriteLine(bs.books.Min(b => b.Pages));
        //Console.WriteLine(bs.books.Max(b => b.Price));
        //var average = bs.books.Average(s => s.Price);
        //Console.WriteLine(average);
        //var sum = bs.books.Sum(s => s.Price);
        //Console.WriteLine(sum);
        //Console.WriteLine(bs.books.Count(n => n.Title.Contains("and")));
        //Console.WriteLine(bs.books.Any(n => n.Price > 1000));
        //bs.books.Select(n => n.Title.ToLower()).ToList().ForEach(Console.WriteLine);
        var ordered = bs.books.OrderBy(n => n.Title)
            .ThenBy(n => n.Price).ThenBy(n => n.Pages)
        ;
        foreach (Book b in ordered)
        {
            Console.WriteLine("Title:{0}, Price:{1}, Pages:{2}", b.Title, b.Price, b.Pages);
        }
    }

    public static void code7_16()
    {
        var numbers = new List<int> { 7, 3, 5, 8, 3, 9, 2, 1 };
        Console.WriteLine(numbers.Count(s => s % 2 == 1));
    }

    static void code7_20()
    {
        var numbers = new List<int> { 7, 3, 5, 8, 3, 9, 2, 1 };
        Console.WriteLine(numbers.Any(s => s % 5 == 0));
    }
    static void code7_21()
    {
        var numbers = new List<int> { 7, 3, 5, 8, 3, 9, 2, 1 };
        //Console.WriteLine(numbers.All(s => s < 10 ));
        Console.WriteLine(numbers.All(s => s%2 == 0 ));
    }

    static void code7_26()
    {
        var numbers1 = new List<int> { 7, 3, 5, 8, 3, 9, 2, 1 };
        var numbers2 = new List<int> { 7, 3, 5, 8, 3, 9, 2, 1 };
        Console.WriteLine(numbers1.SequenceEqual(numbers2));
    }

    static void code7_28()
    {
        string text = "This is an apple. This is a pen. An apple pen.";
        var words = text.Split(" ");
        Console.WriteLine(words.FirstOrDefault(x => x.Length == 5));
    }

    static void code7_32()
    {
        var numbers = new List<int> { 7, 3, 5, 8, 3, 9, 2, 1 };
        //Console.WriteLine(numbers.FindIndex(i => i == 2));
        Console.WriteLine(numbers.FindIndex(i => i == 4));
    }

    static void code7_33()
    {
        var numbers = new List<int> { 7, 3, 5, 8, 3, 9, 2, 1 };
        var p = numbers.Where(n => n > 4).Take(3);
        foreach(int i in p)
            Console.WriteLine(i);
    }

    static void code7_35()
    {
        var numbers = new List<int> { 7, 3, 5, 8, 3, 9, 2, 1 };
        var p = numbers.TakeWhile(n => n > 2);
        foreach(int i in p)
            Console.WriteLine(i);
    }
    static void code7_37()
    {
        var numbers = new List<int> { 7, 3, 5, 8, 3, 9, 2, 1 };
        var p = numbers.SkipWhile(n => n < 9).ToList();
        p.ForEach(Console.WriteLine);
    }

    static void code7_39()
    {
        /*
        var words = new List<string> { "AAA", "AbC", "CbC", "bBb" };
        var lowers = words.Select(n => n.ToLower()).ToList();
        lowers.ForEach(Console.WriteLine);
        */
        var numbers = new List<int> { 8, 20, 6, 137, 11, 1150 };
        numbers.Select(n => n.ToString("0000")).ToList().ForEach(Console.WriteLine);
    }

    static void code7_42()
    {
        var numbers = new List<int> { 1,1,2,4,4,6,7,9,9,0,4,5,8};
        numbers.Distinct().ToList().ForEach(Console.WriteLine);
    }

    static void code7_44()
    {
        var numbers = new List<int> { 1,1,2,4,4,6,7,9,9,0,4,5,8};
        //numbers.Distinct().OrderBy(x => x).ToList().ForEach(Console.WriteLine);
        numbers.Distinct().OrderByDescending(x => x).ToList().ForEach(Console.WriteLine);
    }
    static void code7_47()
    {
        var list1 = new List<int> { 1, 1, 2, 4, 4, 6, 7, 9, 9, 0, 4, 5, 8 };
        var list2 = new List<int> { 11, 1, 22, 43, 43, 6, 67, 97, 9, 90, 40, 51, -8 };
        list2.Concat(list1).OrderBy(x => x).ToList().ForEach(Console.WriteLine);
    }
    static void code_column()
    {
        var list2 = new List<int> { 11, 1, 22, 43, 43, 6, 67, 97, 9, 90, 40, 51, -8 };
        Console.WriteLine(list2.RemoveAll(x => x > 10));
        Console.WriteLine();
        list2.RemoveAll(x => x > 10);
        foreach (int i in list2)
        {
            Console.WriteLine(i);
        }

    }

    static void Main(string[] args)
    {
        /*
        var numbers = Enumerable.Repeat(-1,20).ToList();
        foreach (int i in numbers)
        {
            Console.WriteLine(i);
        }
        foreach (string i in strings)
        {
            Console.WriteLine(i);
        }
        var array = Enumerable.Range(1, 20).ToArray();
        foreach (int i in array)
        {
            Console.WriteLine(i);
        }
        */
        //code7();
        ///code7_9();
        //code7_16();
        //code7_20();
        //code7_21();
        //code7_26();
        //code7_28();
        //code7_32();
        //code7_33();
        //code7_35();
        //code7_37();
        //code7_39();
        //code7_42();
        //code7_44();
        //code7_47();
        code_column();
    }

}