using Gushwell.Utilities;

public static class Code16_18
{
    public static void Run()
    {
        List<string> strs = ["C#","Java","Ruby","","Python"];
        Console.WriteLine(strs.StringJoin("-"));

        Console.WriteLine(string.Join("-",strs));

        int[] nums = [35,7,81,8,9,8];
        Console.WriteLine(nums.StringJoin(", "));
        Console.WriteLine(string.Join("-",nums));
    }
}