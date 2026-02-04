using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Serialization;

public record Employee
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public DateTime HireDate{ get; set; }
}

public record Novelist
{
    public int Id{ get; init; }
    public string? Name { get; init; }
    [JsonPropertyName("birth")]
    public DateTime Birthday{ get; init; }
    [XmlArray("masterpieces")]
    [XmlArrayItem("title", typeof(string))]
    public string[]? Masterpieces{ get; init; }
}

public class Program
{
    static void q12_1()
    {
        var employees = new Employee[] {
            new Employee
            {
                Id = 1000,
                Name = "AAAA",
                HireDate = new DateTime(2025,10,01),
            },
            new Employee{
                Id = 2000,
                Name = "BBBB",
                HireDate = new DateTime(2025,10,13),
            },
        };

        var options = new JsonSerializerOptions
        {
            WriteIndented = true
        };
        string jsonString = JsonSerializer.Serialize(employees, options);
        //Console.WriteLine(jsonString);
        File.WriteAllText("employees.json", jsonString);

        var text = File.ReadAllText("employees.json");
        var employees_deserialized = JsonSerializer.Deserialize<List<Employee>>(text);
        employees_deserialized?.ForEach(Console.WriteLine);
    }

    static void q12_2()
    {
        var options = new JsonSerializerOptions
        {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            NumberHandling = JsonNumberHandling.AllowReadingFromString |
                             JsonNumberHandling.AllowNamedFloatingPointLiterals
        };
        var text = File.ReadAllText("novelist.json");
        var novelist = JsonSerializer.Deserialize<Novelist>(text,options);
        if(novelist is not null)
        {
            Console.WriteLine(novelist);
            foreach(var item in novelist.Masterpieces)
            {
                Console.WriteLine(item);
            }

        }
    }

    static void q12_3()
    {
        var options = new JsonSerializerOptions
        {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            NumberHandling = JsonNumberHandling.AllowReadingFromString |
                             JsonNumberHandling.AllowNamedFloatingPointLiterals
        };
        var text = File.ReadAllText("novelist.json");
        var novelist = JsonSerializer.Deserialize<Novelist>(text, options);
        /*
        if(novelist is not null)
        {
            Console.WriteLine(novelist);
            foreach(var item in novelist.Masterpieces)
            {
                Console.WriteLine(item);
            }

        }
        */
        using(var writer = XmlWriter.Create("novelist.xml"))
        {
            var serializer = new XmlSerializer(novelist.GetType());
            serializer.Serialize(writer, novelist);
        }
    }

    public static void Main(string[] args)
    {
        //q12_1();
        q12_3();
    }
}