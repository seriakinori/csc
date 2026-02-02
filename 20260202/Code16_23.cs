using System.Runtime.CompilerServices;
using Gushwell.Utilities;

public static class Code16_23{
    public static void Run()
    {
        Gender male = Gender.Male;
        Gender female = Gender.Female;
        Console.WriteLine(male.GetDisplayName());
        Console.WriteLine(female.GetDisplayName());

    }
}