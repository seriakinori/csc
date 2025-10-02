using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;


public class Abbreviations
{
    private readonly Dictionary<string, string> _dict = new();

    public Abbreviations()
    {
        var file = File.ReadAllLines("./abbreviations.txt");
        _dict = file
            .Select(line => line.Split('='))
            .ToDictionary(x => x[0], x => x[1]);
    }

    public void Add(string abbr, string japanese)
    {
        _dict[abbr] = japanese;
    }

    public string? Get(string abbr) =>
        _dict.ContainsKey(abbr) ? _dict[abbr] : null;

    public string? ToAbbreviation(string japanese) =>
        _dict.FirstOrDefault(x => x.Value == japanese).Key;

    public IEnumerable<(string, string)> FindAll(string substring)
    {
        foreach (var (key, value) in _dict)
        {
            if (value.Contains(substring))
            {
                yield return (key, value);
            }
        }
    }

    public int Count() => _dict.Count();

    public bool Remove(string abbr)
    {
        if (_dict.ContainsKey(abbr))
        {
            _dict.Remove(abbr);
            return true;
        }
        return false;
    }

    public void OutputNlenAbbr(int n)
    {
        foreach (var (key, val) in _dict)
        {
            if (key.Length == n)
            {
                Console.WriteLine($"{key}={val}");
            }
        }
    }

}

class Q8_2{
    /// <summary>
    /// static void Main(string[] args){
    /// </summary>
    void main(){
        var abbrs = new Abbreviations();
        Console.WriteLine(abbrs.Count());
        abbrs.Add("ICU","国際基督教大学");
        abbrs.Add("NDA","秘密保持契約");
        Console.WriteLine(abbrs.Remove("ICU"));
        Console.WriteLine(abbrs.Count());
        Console.WriteLine(abbrs.Remove("ICU"));

        abbrs.OutputNlenAbbr(3);
        /*
        foreach(var (key,val) in abbrs.){
            Console.WriteLine($"{key}={val}");
        }
        */
        Console.WriteLine();
    }
}

class Q8_1
{
    public static string str = "Cozy lummox gives smart squid who asks for job pen";
    static void q8_1()
    {
        Dictionary<char, int> dict = new Dictionary<char, int>();
        for (int i = 0; i < str.Length; i++)
        {
            char ch = char.ToUpper(str[i]);
            if (!('A' <= ch && ch <= 'Z'))
            {
                continue;
            }
            if (dict.ContainsKey(ch))
            {
                dict[ch] += 1;
            }
            else
            {
                dict[ch] = 1;
            }
        }
        foreach (var (k, v) in dict.OrderBy(x => x.Key))
        {
            Console.WriteLine($"'{k}': {v}");
        }
    }

    static void q8_1_()
    {
        SortedDictionary<char, int> sdict = new SortedDictionary<char, int>();
        for (int i = 0; i < str.Length; i++)
        {
            char ch = char.ToUpper(str[i]);
            if (!('A' <= ch && ch <= 'Z'))
            {
                continue;
            }
            if (sdict.ContainsKey(ch))
            {
                sdict[ch] += 1;
            }
            else
            {
                sdict[ch] = 1;
            }
        }
        foreach (var (k, v) in sdict)
        {
            Console.WriteLine($"'{k}': {v}");
        }
    }

    /*
    static void Main(string[] args)
    {
        q8_1_();
    }
    */
}
