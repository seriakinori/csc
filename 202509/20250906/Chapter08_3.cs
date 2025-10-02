using System;
using System.Linq;
using System.Collections.Generic;
using System.Security.Permissions;
using System.ComponentModel;

namespace Chapter08;

public class Program08_3
{
    public static Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>
    {
        ["PC"] = new List<string> { "Personal Computer", "Program Counter", },
        ["DI"] = new List<string> { "Inject Dependency", "Data Integration", },
    };

    static void code8_16()
    {
        var key = "EC";
        var value = "Electronic Commerce";
        if (dict.ContainsKey(key)) {
            dict[key].Add(value);
        } else {
            dict[key] = new List<string> { value };
        }

        foreach (var (k, v) in dict) {
            foreach (var term in v)
            {
                Console.WriteLine($"{k} => {term}", key, term);
            }
        }
    }
    //public static void Main(string[] args)
    void main()
    {
        code8_16();
    }

}
