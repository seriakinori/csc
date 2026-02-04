using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class Program
{
    static void code11_1(){
        var text = "private List<string> results = new List<string>();";
        bool isMatch = Regex.IsMatch(text, @"List<\w+>");
        if (isMatch)
        {
            Console.WriteLine("Found");
        }
        else
        {
            Console.WriteLine("Not Found");
        }
    }
    static void code11_2()
    {
        var text = "private List<string> results = new List<string>();";
        var regex = new Regex(@"List<\w+>");
        bool isMatch = regex.IsMatch(text);
        if (isMatch)
        {
            Console.WriteLine("Found");
        }
        else
        {
            Console.WriteLine("Not Found");
        }
    }

    static void code11_3()
    {
        var text = "using System.Text.RegularExpressions;";
        bool isMatch = Regex.IsMatch(text, @"^using");
        if(isMatch){
            Console.WriteLine("Begins with `using`.");
        }
    }

    static void code11_4()
    {
        var text = "using System.Text.RegularExpressions;";
        bool isMatch = Regex.IsMatch(text, @"ions;$");
        if(isMatch){
            Console.WriteLine("Ends with `ions;`.");
        }
    }

    public static void Main(string[] args)
    {
        code11_4();
    }
}