using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;

namespace Linq20250814;

public class LinqPractice
{
    static void QueryTest01(){
        var codes = new List<string>{"aaa","abc","AAA","ABC","AaA","AbC","abC","aaA"};

        IEnumerable<string> query = codes
            .Where(s => s.Contains("aA"))
            .Select(s => s.ToUpper());
        //var query = codes.Where(s => s.Contains("aA"));
        //query.ForEach(s => Console.WriteLine(s));

        var varquery = codes.Select(s => s.Length);
        foreach(var s in varquery){
            Console.WriteLine(s);
        }
    } 

    static void QueryTest02(){
        var codes = new List<string>{"aaa","abc","AAA","ABC","AaA","AbC","abC","aaA"};
        var query = codes.Select( s => (int)s[1]);
        foreach(int i in query){
            Console.WriteLine("0x" + i);
        }

        Console.WriteLine("---------");

        codes[0] = "ZZZ";
        foreach(int i in query){
            Console.WriteLine("0x" + i);
        }
    }

    public static void Main(string[] args){
        var codes = new List<string>{"aaa","abc","AAA","ABC","AaA","AbC","abC","aaA"};
        var query = codes
            .Select( s => (int)s[1] ).ToArray();
        foreach(int i in query){
            Console.WriteLine("0x" + i);
        }

        Console.WriteLine("---------");

        codes[0] = "ZZZ";

        foreach(int i in query){
            Console.WriteLine("0x" + i);
        }
    }
}
