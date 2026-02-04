using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text.Json;
using System.Text.Encodings.Web;
using System.Text.Unicode;


public class Novel
{
    public string Title { get; init; } = String.Empty;
    public string Author { get; init; } = String.Empty;
    public int PublishYear{get; init;} 
}

class Program
{
    static void code12_1(){
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
            Encoder = JavaScriptEncoder.Create(UnicodeRanges.All),
            WriteIndented = true
        };

        string jsonString = JsonSerializer.Serialize(novels, options);
        //Console.WriteLine(jsonString);
        File.WriteAllText("./novels.json",jsonString);
    }
    static void code12_3()
    {
        var abbreviations = new Dictionary<string, string>
        {
            ["ODA"] = "政府援助協力",
            ["ICU"] = "国際基督教大学",
            ["NAIST"] = "奈良先端科学技術大学院",
        };

        var options = new JsonSerializerOptions
        {
            Encoder = JavaScriptEncoder.Create(UnicodeRanges.All),
            WriteIndented = true,
        };

        string jsonString = JsonSerializer.Serialize(abbreviations, options);
        var fileName = "./abbs.json";
        File.WriteAllText(fileName, jsonString);
    }
    public static void Main(string[] args)
    {
        code12_1();
        code12_3();
    }
}