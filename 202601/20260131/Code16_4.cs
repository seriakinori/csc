using System.Runtime.CompilerServices;

public class Code16_4
{
    public static void Run()
    {
        var abbrs = new Abbreviations();
        var names = new[]{"WHO", "FIFA", "TPP", };
        foreach(var name in names)
        {
            var fullname = abbrs[name];
            if(fullname == null)
            {
                Console.WriteLine("{0} not found", name);
            }
            else
            {
                Console.WriteLine("{0} = {1}", name, fullname);
            }
        }
    }
}