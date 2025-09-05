using System;
using System.Linq;
using System.Collections.Generic;


public class Class1
{

    static void Exercise1(int[] numbers){
        var max = numbers.Max();
        Console.WriteLine(max);
    }

    static void Exercise2(int[] numbers){
        foreach(int s in numbers.TakeLast(2))
            Console.WriteLine(s);
    }

    static void Exercise3(int[] numbers){
        var strs = numbers.Select(n => n.ToString("000"));
        foreach(string s in strs)
            Console.WriteLine(s);
    }

    static void Exercise4(int[] numbers){
        foreach(int i in numbers.Order().Take(3))
            Console.WriteLine(i);
    }

    static void Exercise5(int[] numbers){
        var count = numbers.Distinct().Count(n => n > 10);
        Console.WriteLine(count);
    }


    //static void Main(string[] args){
    void main(){
        int[] numbers = [5, 10, 17, 9, 3, 21, 10, 40, 21, 3, 35];
        Console.WriteLine("7.1.1");
        Exercise1(numbers);

        Console.WriteLine("7.1.2");
        Exercise2(numbers);

        Console.WriteLine("7.1.3");
        Exercise3(numbers);

        Console.WriteLine("7.1.4");
        Exercise4(numbers);

        Console.WriteLine("7.1.5");
        Exercise5(numbers);


    }
}


