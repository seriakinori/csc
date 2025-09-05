using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.VisualBasic;

namespace Program20250816;

public class Promgram
{
    public void Main()
    {
        var numbers = new List<int> { 12, 87, 94, 14, 53, 20, 40, 35, 76, 91, 31, 17, 48 };
        Q4(numbers);
    }
    public static void Q3(List<int> numbers)
    {
        var ans3 = numbers.Where(s => s >= 50);
        foreach (int s in ans3)
        {
            Console.WriteLine(s);
        }
    }

    public static void Q4(List<int> numbers)
    {
        List<int> ans4 = numbers.Select(s => s * 2).ToList();
        
        foreach (int i in ans4)
        {
            Console.WriteLine(i);
        }
    }

    //public static void Main(string[] args)
}