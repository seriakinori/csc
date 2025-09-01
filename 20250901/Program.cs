using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

public class Program
{
    public static void q6_1()
    {
        Console.WriteLine("first:");
        string s1 = Console.ReadLine();
        Console.WriteLine("second:");
        string s2 = Console.ReadLine();
        if (String.Compare(s1, s2, ignoreCase: true) == 0)
        {
            Console.WriteLine("equals");
        }
        else
        {
            Console.WriteLine("not equals");
        }
    }

    public static void q6_2()
    {
        Console.WriteLine("input:");
        string s1 = Console.ReadLine();
        int i;
        bool flag = int.TryParse(s1, out i);
        if (flag)
        {
            string s2 = i.ToString("#,0");
            Console.WriteLine(s2);
        }
        else
        {
            Console.WriteLine("Convert failed");
        }
    }

    public static void q6_3()
    {
        string str = "Jackdaws love my big sphinx of quartz";
        Console.WriteLine(str);
        /*
        // 1
        int n_space = str.Where(s => s == ' ').Count();
        Console.WriteLine(n_space);
        // 2 
        Console.WriteLine(str.Replace("big","small"));
        // 3 
        var sp = str.Split(" ").ToArray();
        StringBuilder sb = new StringBuilder(50);
        for(int i=0; i < sp.Length; i++)
        {
            sb.Append(sp[i]);
            if(i < sp.Length-1)
                sb.Append(" ");
        }
        Console.WriteLine(str.Length);
        Console.WriteLine(sb.Length);
        // 4
        var sp = str.Split(" ").ToArray();
        Console.WriteLine(sp.Length);
        */
        // 5
        //var sp = str.Split(" ").ToArray();
        //var less4 = sp.Where(s => s.Length <= 4).ToArray();
        var less4 = str.Split(" ").Where(s => s.Length <= 4);
        foreach(string s in less4)
            Console.WriteLine(s);
    }

    public static void q6_4()
    {
        string str = "Novelist=Pushkin;BestWork=Onegin;Born=1799";
        var info = str.Split(";");

        foreach (string s in info)
        {
            var e = s.Split("=");
            e[0] = e[0].Replace("Novelist","Poet");
            e[0] = e[0].Replace("BestWork","Chef d'oeuvre");
            e[0] = e[0].Replace("Born","BirthYear");
            Console.Write($"{e[0],-14}");
            Console.Write(":");
            Console.Write($" {e[1]}");
            Console.WriteLine("");
        }

    }

    static string ToJapanese(string key)
    {
        return key switch
        {
            "Novelist" => "詩人　",
            "BestWork" => "代表作",
            "Born" => "誕生年",
            _ => throw new ArgumentException("The argument `key` is not proper value."),
        };
    }

    public static void a6_4()
    {
        string line = "Novelist=Pushkin;BestWork=Onegin;Born=1799";
        foreach (var p in line.Split(";"))
        {
            var array = p.Split('=');
            Console.WriteLine("{0,-4}:{1,-10}", ToJapanese(array[0]), array[1]);
        }
    }

    public static void Main(string[] args)
    {
        //q6_1();
        //q6_2();
        //q6_3();
        //q6_4();
        a6_4();
    }
}