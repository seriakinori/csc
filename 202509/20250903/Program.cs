using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.VisualBasic;
using System.Text;

class Program6
{
    static void q2()
    {
        string s = Console.ReadLine();
        if (int.TryParse(s, out int var))
        {
            Console.WriteLine(var);
        }
        else
        {
            Console.WriteLine("Convert failed");
        }
    }

    static void q3()
    {
        string s = "Jackdaws love my big sphinx of quartz";
        //Console.WriteLine(s.Count(si => si == ' '));
        //Console.WriteLine(s.Replace("big", "small"));
        /*
        var array = s.Split(" ").ToArray();
        StringBuilder sb = new StringBuilder(array[0]);
        foreach (string s_i in array.Skip(1))
        {
            sb.Append(' ');
            sb.Append(s_i);
        }
        Console.WriteLine(sb);
        */
        //Console.WriteLine(s.Split(" ").ToArray().Length);
        var sp = s.Split(" ");
        var less4 = sp.Where(w => w.Length < 5);
        foreach(string s_i in less4)
            Console.WriteLine(s_i);
    }

    static void Main(string[] args)
    {
        q3();
    }
    
}