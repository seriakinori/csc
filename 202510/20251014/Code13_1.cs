
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void q13_1()
    {
        Console.WriteLine("ans 2");
        var ans_2 = Library.Books
            .MaxBy(b => b.Price);
        Console.WriteLine(ans_2);

        Console.WriteLine("ans 3");
        var ans_3 = Library.Books
            .GroupBy(x => x.PublishedYear)
            .Select(x => new
            {
                PublishedYear = x.Key,
                Count = x.Count()
            });
        foreach (var b in ans_3)
            Console.WriteLine($"{b}");

        Console.WriteLine("ans 4");
        var ans_4 = Library.Books
            .OrderByDescending(b => b.PublishedYear)
            .ThenByDescending(b => b.Price);
        foreach (var b in ans_4)
            Console.WriteLine($"{b.PublishedYear}年 {b.Price}円 {b.Title}");

        Console.WriteLine("ans 5");
        var ans_5 = Library.Books
            .Where(b => b.PublishedYear == 2022)
            .Join(
                Library.Categories,
                b => b.CategoryId,
                c => c.Id,
                (b,c) => new
                {
                    CategoryName = c.Name
                }
            )
            .Distinct();
        foreach (var b in ans_5)
            Console.WriteLine($"{b}");

        Console.WriteLine("ans 6");
        var ans_6 = Library.Books
            .Join(Library.Categories,
                book => book.CategoryId,
                category => category.Id,
                (b, c) => new { CategoryName = c.Name, Title = b.Title }
            )
            .GroupBy(c => c.CategoryName)
            .OrderBy(c => c.Key);
        foreach(var group in ans_6)
        {
            Console.WriteLine($"# {group.Key}");
            foreach(var book in group)
            {
                Console.WriteLine($"  {book.Title}");
            }
        }

        Console.WriteLine("ans 7");
        var ans_7 = Library.Categories
            .Where(b => b.Name == "Development")
            .Join(Library.Books,
                category => category.Id,
                book => book.CategoryId,
                (b, c) => new { PublishedYear = c.PublishedYear, Title = c.Title }
            )
            .GroupBy(c => c.PublishedYear);
        foreach(var group in ans_7)
        {
            Console.WriteLine($"# {group.Key}");
            foreach(var book in group)
            {
                Console.WriteLine($"  {book.Title}");
            }
        }

        Console.WriteLine("ans 8");
        var ans_8 = Library.Categories
            .GroupJoin(
                Library.Books,
                c => c.Id,
                b => b.CategoryId,
                (c,b) => new
                {
                    CategoryName = c.Name,
                    Count = b.Count()
                } 
            )
            .Where(g => g.Count > 3);
        foreach(var group in ans_8)
        {
            Console.WriteLine($"{group.CategoryName} {group.Count}");
        }


    }

    public static void Main(string[] args)
    {
        q13_1();
    }
}

public class Category {
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public override string ToString() {
        return $"Id:{Id}, カテゴリ名:{Name}";
    }
}

public class Book {

    public string Title { get; set; } = string.Empty;
    public int Price { get; set; }
    public int CategoryId { get; set; }
    public int PublishedYear { get; set; }

    public override string ToString() {
        return $"発行年:{PublishedYear}, カテゴリ:{CategoryId}, 価格:{Price}, タイトル:{Title}";
    }
}

public static class Library {
    // Categoriesプロパティで上記のカテゴリの一覧を得ることができる。
    public static IEnumerable<Category> Categories { get; private set; }

    // Booksプロパティで上記の書籍情報の一覧を得ることができる。
    public static IEnumerable<Book> Books { get; private set; }

    static Library() {
        Categories = new List<Category> {
                new Category { Id = 1, Name = "Development"  },
                new Category { Id = 2, Name = "Server"  },
                new Category { Id = 3, Name = "Web Design"  },
                new Category { Id = 4, Name = "Windows"  },
                new Category { Id = 5, Name = "Application"  },
            };

        Books = new List<Book> {
            new Book {
                Title = "C#で作成するWebアプリ開発講座" ,
                CategoryId = 1 ,
                Price = 2780 ,
                PublishedYear = 2021
            },
            new Book {
                Title = "フレーズで学ぶC# Book",
                CategoryId = 1 ,
                Price = 2400 ,
                PublishedYear = 2021
            },
            new Book {
                Title = "TypeScript初級講座",
                CategoryId = 1 ,
                Price = 2500 ,
                PublishedYear = 2022
            },
            new Book {
                Title = "Writing C# Solid Code",
                CategoryId = 1 ,
                Price = 2500 ,
                PublishedYear = 2023
            },
            new Book {
                Title = "C#開発指南",
                CategoryId = 1,
                Price = 3800,
                PublishedYear = 2020
            },
            new Book {
                Title = "SQL Server 完全入門",
                CategoryId = 2 ,
                Price = 3800 ,
                PublishedYear = 2020
            },
            new Book {
                Title = "IIS Webサーバー運用ガイド",
                CategoryId = 2 ,
                Price = 3180 ,
                PublishedYear = 2020
            },
            new Book {
                Title = "PowerShell 実践レシピ",
                CategoryId = 2 ,
                Price = 4200 ,
                PublishedYear = 2022
            },
            new Book {
                Title = "Microsoft Azureサーバー構築",
                CategoryId = 2 ,
                Price = 4800 ,
                PublishedYear = 2022
            },
            new Book {
                Title = "HTML+JavaScript Web大百科",
                CategoryId = 3 ,
                Price = 3800 ,
                PublishedYear = 2020
            },
            new Book {
                Title = "CSSデザイン 逆引き辞典",
                CategoryId = 3 ,
                Price = 3550 ,
                PublishedYear = 2021
            },
            new Book {
                Title = "続Webデザイン講座 HTML＆CSS",
                CategoryId = 3 ,
                Price = 2800 ,
                PublishedYear = 2023
            },
            new Book {
                Title = "Windows11使いこなし術",
                CategoryId = 4 ,
                Price = 1890 ,
                PublishedYear = 2020
            },
            new Book {
                Title = "Windows11で楽しくお仕事",
                CategoryId = 4 ,
                Price = 2280 ,
                PublishedYear = 2021
            },
            new Book {
                Title = "Windows11 やさしい操作入門",
                CategoryId = 4 ,
                Price = 2300 ,
                PublishedYear = 2021
            },
            new Book {
                Title = "続Windows11使いこなし術",
                CategoryId = 4 ,
                Price = 2080 ,
                PublishedYear = 2023
            },
            new Book {
                Title = "たのしく学ぶExcel初級編",
                CategoryId = 5 ,
                Price = 2800 ,
                PublishedYear = 2021
            },
            new Book {
                Title = "Word・Excel実践テンプレート集",
                CategoryId = 5 ,
                Price = 2600 ,
                PublishedYear = 2021
            },
            new Book {
                Title = "まるわかりMicrosoft365入門",
                CategoryId = 5,
                Price = 1890,
                PublishedYear = 2022
            },
        };
    }
}

