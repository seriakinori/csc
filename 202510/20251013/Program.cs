using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualBasic;

class Program
{
    static void code13_2()
    {
        var price = Library.Books
                        .Where(b => b.CategoryId == 1)
                        .Max(b => b.Price);
        Console.WriteLine(price);
    }

    static void code13_3()
    {
        var book = Library.Books
            .Where(x => x.PublishedYear >= 2021)
            .MinBy(x => x.Price);
        Console.WriteLine(book);
    }

    static void code13_4()
    {
        var avg = Library.Books
            .Average(x => x.Price);
        var above = Library.Books
            .Where(x => x.Price > avg);
        foreach (var b in above)
            Console.WriteLine(b);
    }

    static void code13_5()
    {
        var query = Library.Books
            .Select(b => b.PublishedYear)
            .Distinct()
            .Order();
        foreach (var n in query)
        {
            Console.WriteLine(n);
        }
    }

    static void code13_6()
    {
        var books = Library.Books
            .OrderByDescending(b => b.PublishedYear)
            .ThenBy(b => b.CategoryId)
            .ThenBy(b => b.Price);
        foreach (var n in books)
        {
            Console.WriteLine(n);
        }

    }

    static void code13_9(){
        var selected = Library.Books
            .GroupBy(b => b.PublishedYear)
            .Select(group => group.MaxBy(b => b.Price))
            .OrderBy(b => b!.PublishedYear);
        foreach (var n in selected)
        {
            Console.WriteLine(n);
        }
    }

    static void code13_12()
    {
        var books = Library.Books
            .Join(Library.Categories,
                book => book.CategoryId,
                category => category.Id,
                (book, category) => new
                {
                    book.Title,
                    Category = category.Name,
                    book.PublishedYear
                }
            )
            .OrderBy(b => b.PublishedYear)
            .ThenBy(b => b.Category);
        foreach (var b in books)
        {
            Console.WriteLine($"{b.Title}, {b.Category}, {b.PublishedYear}");
        }
    }

    static void code13_13()
    {
        var names = Library.Books
            .Where(b => b.PublishedYear == 2022)
            .Join(
                Library.Categories,
                book => book.CategoryId,
                category => category.Id,
                (book, category) => category.Name
            )
            .Distinct();
        foreach (var name in names)
        {
            Console.WriteLine(name);
        }
    }

    static void code13_14()
    {
        var groups = Library.Categories
            .GroupJoin(
                Library.Books,
                c => c.Id,
                b => b.CategoryId,
                (c, books) => new { Category = c.Name, Books = books }
            );
        foreach (var g in groups)
        {
            Console.WriteLine(g.Category);
            foreach (var b in g.Books)
            {
                Console.WriteLine($"  {b.Title} {b.PublishedYear}");
            }
        }
    }

    static void code13_15()
    {
        var groups = Library.Categories
            .GroupJoin(
                Library.Books,
                c => c.Id,
                b => b.CategoryId,
                (c, books) => new
                {
                    Category = c.Name,
                    Count = books.Count(),
                    Average = books.Average(b => b.Price)
                }
            );
        foreach (var o in groups)
        {
            Console.WriteLine($"{o.Category} {o.Count} {o.Average:0.0}");
        }
    }

    public static void Main(string[] args)
    {
        code13_15();
    }
}