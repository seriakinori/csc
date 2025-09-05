using System;
using System.Text;
using System.Collections.Generic;
using System.Collections.Immutable;

public class PasswordPriority
{
    public int MinimumLength{ get; set; } = 8;
}

public class Person
{
    //public string GivenName { get; init; }
    //public string FamilyName { get; init;  }
    public string GivenName { get; private set; }
    public string FamilyName { get; private set; }

    public Person(string familyName, string givenName)
    {
        FamilyName = familyName;
        GivenName = givenName;
    }

    /*
    public void ChangeFamilyName(string name)
    {
        FamilyName = name;
    }
    */
    public void ChangeFamilyName(string name) => FamilyName = name;

    public string DecorateText(string text) => $"<<{text}>>";


    public string Name
    {
        get { return FamilyName + " " + GivenName; }
    }
}

class MySample
{
    public ImmutableList<int> MyList { get; private set; }

    public MySample()
    {
        var list = new List<int>() { 1, 243, 0, 5, 56, 7, 8, 8, 3 };
        MyList = list.ToImmutableList();
    }
    public  double Median(params double[] args)
    {
        var sorted = args.OrderBy(n => n).ToArray();
        var index = sorted.Length / 2;
        if (sorted.Length % 2 == 0)
        {
            return (sorted[index] + sorted[index - 1]) / 2;
        }

        return sorted[index];
    }
}

class Sample
{
    public void DoSomething(int num, string message = "failed", int retryCount=3)
    {
        Console.Write(num);
        Console.Write(message);
        Console.Write(retryCount);
        Console.WriteLine();
        return;
    }

}

public class Program20250823
{
    public static void Main(string[] args)
    {
        //var person = new Person("AAAA", "aaaa");
        //person.GivenName = "bbbb";
        //person.ChangeFamilyName("cccc");
        //Console.WriteLine(person.Name);
        /*
        var obj = new MySample();
        var newList = obj.MyList.Add(109).RemoveAt(0);
        obj.MyList.ForEach(n => Console.Write($"{n} "));
        Console.WriteLine();
        newList.ForEach(n => Console.Write($"{n} "));
        Console.WriteLine();
        double[] a = { 1, 2, 4, 5, 678, 9, 9, 0, 3, 4, 5, 6, 7 };
        Console.WriteLine(obj.Median(a));
        */
        var sample = new Sample();
        sample.DoSomething(100);
        sample.DoSomething(100,"error!");
        sample.DoSomething(100,"exception!",777);
    }
}