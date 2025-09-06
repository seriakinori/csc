using System;
using System.Collections.Generic;
using System.Linq;

namespace chapter08;

public class Employee
{
    public int Code { get; init; }
    public string? Name { get; init; }

    public Employee(int code, string name)
    {
        Code = code;
        Name = name;
    }
}

class Program {
    static void Output(string dataName)
    {
        Console.WriteLine("Data:{0}",dataName);
        if (dataName == "d1")
        {
            foreach (var item in d1)
            {
                Console.WriteLine($"{item.Key} = {item.Value}");
            }
        }
        else if (dataName == "d2")
        {
            foreach (var (key, value) in d2)
            {
                Console.WriteLine($"{key} = {value}");
            }
        }
    }

    static Dictionary<string, int> d1 = new Dictionary<string, int>
    {
        {"aaaa",400},
        {"bbbb",300},
        {"cccc",350},
        {"dddd",500},
        {"eeee",450},
        {"ffff",600},
    };
    static Dictionary<string, int> d2 = new Dictionary<string, int>
    {
        ["aaaa"] = 400,
        ["bbbb"] = 300,
        ["cccc"] = 350,
        ["dddd"] = 500,
        ["eeee"] = 450,
        ["ffff"] = 600,
    };

    static Dictionary<int, Employee> employeeDict = new Dictionary<int, Employee>
    {
        [100] = new Employee(100, "John Daw"),
        [112] = new Employee(112, "William Moth"),
        [136] = new Employee(136, "Michel Kahn"),
    };

    static void code8_10()
    {
        var average = d1.Average(n => n.Value);
        Console.WriteLine(average);

        int total = d2.Sum(x => x.Value);
        Console.WriteLine(total);

        var items = d1.Where(x => x.Value > 400);
        foreach (var (key, value) in items)
        {
            Console.WriteLine("{0}:{1}", key,value);
        }

    }

    static void code8_11()
    {
        var emp = new List<Employee>()
        {
            new Employee(222,"Max Shaw"),
            new Employee(983,"George Gren"),
            new Employee(888, "Marx Mcmillan"),
        };
        var empdict = emp.ToDictionary(emp => emp.Code);
        foreach (var item in empdict)
        {
            Console.WriteLine($"{item.Key}:{item.Value.Code}->{item.Value.Name}", item);
        }
    }

    static void code8_12()
    {
        var empdict = new Dictionary<int, Employee>
        {
            [111] = new Employee(111, "Karl Joan"),
            [222] = new Employee(222, "Frederick Straus"),
            [333] = new Employee(333, "Komodo Morero"),
        };

        var newdict = empdict
            .Where(x => x.Key > 111)
            .ToDictionary(x => x.Key, x => x.Value.Name);
        foreach (var (key, val) in newdict)
        {
            Console.WriteLine($"{key}={val}");
        }
    }

    //static void Main(string[] args)
    void main()
    {
        /*
        d1["gggg"] = 700;
        employeeDict[235] = new Employee(235, "Marco Giobanni");
        Console.WriteLine(d1.Remove("cccc"));
        Console.WriteLine(d2.Remove("gggg"));
        Console.WriteLine(d1.ContainsKey("gggg"));
        d2.Add("hhhh", 780);
        employeeDict.Add(321, new Employee(321, "Fred Good"));
        Output("d1");
        Output("d2");
        */
        //code8_10();
        //code8_11();
        code8_12();
    }
}