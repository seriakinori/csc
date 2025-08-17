using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Collections;
using System.Data;
using System.Security.Cryptography.X509Certificates;

namespace Promgram20250817;

public class Program
{
    static void DictTest()
    {
        var dict = new Dictionary<string, string>()
        {
            ["aaa"] = "123",
            ["bbb"] = "356",
            ["ccc"] = "789",
            ["ddd"] = "012",
        };

        dict = new Dictionary<string, string>()
        {
            {"xxx", "---"},
            {"yyy", "---"},
            {"zzz", "---"},
            {"aaa", "---"},
        };

        foreach (KeyValuePair<string, string> d in dict)
        {
            //Console.WriteLine("{0}:{1}", d.Key, d.Value);
        }
    }

    static void SwitchTest()
    {
        var line = Console.ReadLine();
        int num = int.Parse(line);
        switch (num)
        {
            case > 90:
                Console.WriteLine("Rank A");
                break;
            default:
                Console.WriteLine("Rank ?");
                break;
        }
    }

    static void ForEachTest()
    {
        var nums = new List<int> { 1, 2, 3, 4, 5, };
        nums.ForEach(n => Console.WriteLine("0x0" + n));
    }

    static int ReturnLoopTest()
    {
        var numbers = new int[] { 235, 6, 7, 32, 57, 8, 9, 0, 311 };
        foreach (var n in numbers)
        {
            if (n > 100)
            {
                return n;
            }
        }
        return -1; 
    }

    static Object ReturnNull()
    {
        return null;
    }

    static string ReturnNotNull()
    {
        return "not null";
    }

    static void NullUnionTest()
    {
        var result = ReturnNull() ?? ReturnNotNull();
        Console.WriteLine(result);
        result = ReturnNull();
        result ??= ReturnNotNull();
        Console.WriteLine(result);
    }

    [Flags]
    public enum Direction
    {
        None = 0,
        Fore = 0b0001,
        Back = 0b0010,
        Left = 0b0100,
        Right = 0b1000,
        All = 0b1111,
    }

    static void BitFlag()
    {
        var direction = Direction.Fore;
        direction |= Direction.Left;

        //direction |= Direction.Right;
        if (direction.HasFlag(Direction.Left))
        {
            Console.WriteLine("Left");
        }
        if (direction.HasFlag(Direction.Fore))
        {
            Console.WriteLine("forward");
        }
        if (direction.HasFlag(Direction.All))
        {
            Console.WriteLine("All direction");
        }
    }

    static void TryParseTest()
    {
        string str = "AAAA";
        str = "123";
        if (int.TryParse(str, out int decoded)) {
            Console.WriteLine(decoded);
        } else {
            Console.WriteLine("type not matched");
        }
    }

    public static void ReferenceCastTest()
    {
        //Obj o = new Obj();
        Obj o = new Obj();
        if (o is Obj o2) {
            o2.OutputConsole();
        }
    }

    static void Main(string[] args)
    {
        //SwitchTest();
        //ForEachTest();
        //Console.WriteLine(ReturnLoopTest());
        //NullUnionTest();
        //BitFlag();
        //TryParseTest();
        ReferenceCastTest();
    }
}

public class Obj
{
    public String object_member = "I am a Object";
    public void OutputConsole()
    {
        Console.Write(this.object_member);
    }
}
