public static class Code16_11
{
    public static void Run()
    {
        foreach(var n in GetNumbers())
        {
            Console.WriteLine(n);
        }
    }

    static public IEnumerable<int> GetNumbers()
    {
        yield return 0;
        yield return 2;
        yield return 4;
        var rnd = new Random();
        if(rnd.Next(0,2) == 0)
        {
            yield break;
        }
        yield return 6;
        yield return 8;
        yield return 10;
    }
}