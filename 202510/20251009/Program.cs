using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Text.Json;

public class Novel {
    public string Title { get; init; } = String.Empty;
    public string Author { get; init; } = string.Empty;
    
    [JsonPropertyName("year")]
    public int PublishedYear{ get; init; }
}

class Program
{
    public static void Main(string[] args)
    {
        var options = new JsonSerializerOptions
        {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
        };

        var text = File.ReadAllText("./novels.json");
        var novelist = JsonSerializer.Deserialize<List<Novel>>(text,options);
        novelist?.ForEach(Console.WriteLine);
    }
}