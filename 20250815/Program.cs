using System;
using System.IO;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Program20250815;

public class Program
{
    public void Q3_1()
    {
        var numbers = new List<int> { 1, 85, 33, 90, 81, 99, 21, 94, 5, 37, 93, 49, 569, 33 };
        // 1
        //var answer = numbers.Exists(s => s % 8 == 0 || s % 9 == 0);
        //Console.WriteLine(answer);

        // 2
        //numbers.ForEach(s => Console.WriteLine(s/2.0));


    }

    public static void Main(string[] args)
    {
        Program p = new Program();
        p.Q3_1();        
    }
}