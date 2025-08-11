using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Linq.Expressions;

public class Person
{
    public string? Name { get; set; }
    public DateTime BirthDay { get; set; }

    public int GetAge()
    {
        DateTime today = DateTime.Today;
        int age = today.Year - BirthDay.Year;
        if (today < BirthDay.AddYears(age))
        {
            age--;
        }
        return age;
    }

}

public class Employee : Person
{
    public Employee():base()
    {
        base.Name = "NEMO";
        this.Name = "BUSINESSMAN";
        this.DivisionName = "no belongings";
    }
    public int ID{ get; set; }
    public string DivisionName{ get; set; }
    /*
    Employee employee = new Employee
    {
        ID = 100,
        Name = "John Smith",
        BirthDay = new DateTime(2005, 12, 31),
        DivisionName = "The first department"
    };
    */

    //Console.WriteLine($"{employee.Name}: {employee.GetAge()} years old, {employee.DivisionName}");
    /*
    int? number = null;

    if (number.HasValue)
    {
        Console.WriteLine($"num={number.Value}");
    }
    else
    {
        Console.WriteLine("num=null");
    }
    string aaaa = "AAAA";
    aaaa = null;
    */
}

public class DistanceConverter
{
    public double getFeetValue(double feet)
    {
        return Math.Round(0.3048 * feet, 5);
    }
    public double getMeterValue(double feet)
    {
        return Math.Round(feet / 0.3048);
    }

}

public class Program20250811
{
    public static void Main(string[] args)
    {
        Boolean flg = false;
        if (args.Length >= 1 && args[0] == "-tom")
        {
            flg = true;
        }
        DistanceConverter dc = new DistanceConverter();
        for (int i = 1; i < 11; i++)
        {
            if (flg == true)
            {
                double ft = dc.getMeterValue((double)i);
                Console.WriteLine($"{i}m = {ft}ft");
            }
            else
            {
                double ft = dc.getFeetValue((double)i);
                Console.WriteLine($"{i}ft = {ft:0.0000}m");
            }
        }
    }
}