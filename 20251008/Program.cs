using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.Encodings.Web;
using System.Text.Unicode;

public class Novelist
{
    public string Name { get; init; } = string.Empty;
    public string[] Masterpieces { get; init; } = null!;
    public override string ToString()
    {
        var titles = String.Join(',', Masterpieces);
        return $"Name={Name} Masterpieces={titles}";
    }
}

public class Novel
{
    public string Name { get; init; } = String.Empty;
    public string Title { get; init; } = string.Empty;
    public string Author { get; init; } = String.Empty;
    public int PublishYear { get; init; } 
    
    [JsonIgnore]
    public string? Summary{ get; set; }
}

public class Person
{
    public string GivenName { get; init; } = null!;
    public string FamilyName { get; init; } = null!;
    public string Name => FamilyName + " " + GivenName;
}

class Program
{
    public static void Main(string[] args)
    {
        /*
        var text = File.ReadAllText("novelists.json");
        var novelist = JsonSerializer.Deserialize<List<Novelist>>(text);
        novelist?.ForEach(Console.WriteLine);
        return;
        var options = new JsonSerializerOptions
        {
            IgnoreReadOnlyProperties = true,
        };
        */
        var novels = new Novel[]{
            new Novel
            {
                Author = "Charles Dickens",
                Title = "A tale of two cities",
                PublishYear = 1859,
            },
            new Novel
            {
                Author = "Jane Austin",
                Title = "Pride and Prejudice",
                PublishYear = 1813,
            },
            new Novel
            {
                Author = "夏目漱石",
                Title = "それから",
                PublishYear = 1909,
            }
        };
        var options = new JsonSerializerOptions
        {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            Encoder = JavaScriptEncoder.Create(UnicodeRanges.All),
            WriteIndented = true
        };
        string jsonString = JsonSerializer.Serialize(novels, options);
        Console.WriteLine(jsonString);
    }
}