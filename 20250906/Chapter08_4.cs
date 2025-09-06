using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

public class Abbreviations 
{
    private readonly Dictionary<string, string> _dict = new();    

    public Abbreviations(){
        var file = File.ReadAllLines("./abbreviations.txt");
        _dict = file
            .Select(line => line.Split('='))
            .ToDictionary(x => x[0], x => x[1]);
    }

    public void Add(string abbr, string japanese){
        _dict[abbr] = japanese;
    }

    public string? Get(string abbr) => 
        _dict.ContainsKey(abbr) ? _dict[abbr] : null;
    
    public string? ToAbbreviation(string japanese) => 
        _dict.FirstOrDefault(x => x.Value == japanese).Key;

    public IEnumerable<(string, string)> FindAll(string substring){
        foreach(var (key,value) in _dict){
            if(value.Contains(substring)){
                yield return (key, value);
            }
        }
    }
}

class Program{
    static void Main(string[] args){
        var abbrs = new Abbreviations();
        abbrs.Add("ICU","国際基督教大学");
        abbrs.Add("NDA","秘密保持契約");

        var names = new[] {"WHO", "FIFA", "ICU",};

        foreach(var name in names){
            var fullname = abbrs.Get(name);
            if(fullname is null){
                Console.WriteLine($"Could not find {name}");
            }else{
                Console.WriteLine($"{name}={fullname}");
            }
        }
        Console.WriteLine();

        var japanese = "秘密保持契約";
        var abbreviation = abbrs.ToAbbreviation(japanese);
        if(abbreviation is null){
            Console.WriteLine($"{japanese} not found.");
        }else{
            Console.WriteLine($"{japanese}'s Abbreviation is {abbreviation}.");
        }
        Console.WriteLine();

        foreach(var (key,val) in abbrs.FindAll("国際")){
            Console.WriteLine($"{key}={val}");
        }
        Console.WriteLine();
    }
}