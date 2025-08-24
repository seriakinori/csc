using System;
using System.Linq;
using System.Collections.Generic;


public class AppVersion
{
    public int Major { get; init; }
    public int Minor { get; init; }
    public int Build { get; init; }
    public int Revision { get; init; }

    /*
    public AppVersion(int major, int minor): this(major, minor, 0, 0){
    }

    public AppVersion(int major, int minor, int build): this(major, minor, build, 0){
    }

    public AppVersion(int major, int minor, int build, int revision){
        Major = major;
        Minor = minor;
        Build = build;
        Revision = revision;
    }
    */
    public AppVersion(int major, int minor, int build = 0, int revision = 0)
    {
        Major = major;
        Minor = minor;
        Build = build;
        Revision = revision;
    }

}

public class Person
{
    public required string GivenName{ get; init; }
    public required string FamilyName{ get; init; }
}

public class Student(string name, DateOnly birthday)
{
    public string Name { get; init; } = name;
    public DateOnly BirthDay { get; init; } = birthday;
}

public record RecordPerson
{
    public required string Code { get; init; }
    public required string Name { get; init; }

    public void Check()
    {
        var p1 = new RecordPerson() { Code = "0xab98", Name = "AAAA" };
        var p2 = new RecordPerson() { Code = "0xab98", Name = "AAAA" };
        if (p1 == p2)
        {
            Console.WriteLine("p1 and p1 are the same.");
        }
    }
}
public class Program20250824
{
    /*
    public static void Main(string[] args)
    {
        var person = new Person
        {
            GivenName = "AAAA",
            FamilyName = "aaaa",
        };
        var student = new Student("0x1110", new DateOnly(2025, 8, 24));
        var recordPerson = new RecordPerson[]{
            new RecordPerson{Code = "0x4395", Name = "bbbb" },
            new RecordPerson{Code = "0x4395", Name = "bbbb" },
        };
        foreach (var rp in recordPerson.Distinct())
        {
            Console.WriteLine(rp);
        }
        return;
    }
    */
    public void a()
    {
        return;
    }
}