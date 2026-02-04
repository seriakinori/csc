using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;

public record Novel
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int PublishedYear { get; set; }
}

class Program{
    private static void serialize1()
    {
        var novel = new Novel
        {
            Author = "aaaa",
            Title = "AAAA",
            PublishedYear = 2000,
        };

        using (var writer = XmlWriter.Create("novel.xml"))
        {
            var serializer = new XmlSerializer(novel.GetType());
            serializer.Serialize(writer, novel);
        }
    }

    private static void serialize2()
    {
        var novel = new Novel
        {
            Author = "aaaa",
            Title = "AAAA",
            PublishedYear = 2000,
        };
        var sb = new StringBuilder();
        using (var writer = XmlWriter.Create(sb))
        {
            var serializer = new XmlSerializer(novel.GetType());
            serializer.Serialize(writer, novel);
        }
        var xmlText = sb.ToString();
        Console.WriteLine(xmlText);
    }

    private static void deserialize()
    {
        using (var reader = XmlReader.Create("novel.xml"))
        {
            var serializer = new XmlSerializer(typeof(Novel));
            var novel = serializer.Deserialize(reader) as Novel;
            Console.WriteLine(novel);
        }
    }
    public static void Main(string[] args)
    {
        deserialize();
    }
}