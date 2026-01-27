using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading;
using Microsoft.VisualBasic;

/*
public class Code15_0
{
    public static void Run()
    {
        List<GreetBase> list = [
            new GreetMorning(),
            new GreetAfternoon(),
            new GreetEvening(),
        ];
        foreach(var obj in list)
        {
            string msg = obj.GetMessage();
            Console.WriteLine(msg);
        }
    }
    public static void Main(string[] args)
    {
        Run();
    }
}

abstract class GreetBase
{
    //public virtual string GetMessage() => "";
    public abstract string GetMessage();
}

class GreetMorning: GreetBase
{
    public override string GetMessage() => "Morning";
}

class GreetAfternoon:GreetBase
{
    public override string GetMessage() => "Afternoon";
}

class GreetEvening:GreetBase
{
    public override string GetMessage() => "Evening";
}

*/

public class Code15_7
{
    public static void Run()
    {
        List<IGreet> greetings = [
            new Greet1(),
            new Greet2(),
            new Greet3(),
        ];
        foreach(var obj in greetings){
            string msg = obj.GetMessage();
            Console.WriteLine(msg);
        }
    }
    public static void Main(string[] args)
    {
        Run();
    }
}

interface IGreet
{
    string GetMessage();
}
class  Greet1: IGreet
{
    public string GetMessage() => "0000";
}
class  Greet2: IGreet
{
    public string GetMessage() => "0001";
}
class  Greet3: IGreet
{
    public string GetMessage() => "0010";
}

