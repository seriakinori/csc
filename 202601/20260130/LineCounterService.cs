using System.Runtime.CompilerServices;

public class LineCounterService : ITextFileService
{
    private int _count;

    public void Initialize(string fname)
    {
        _count = 0;
    }

    public void Execute(string line)
    {
        _count++;
    }

    public void Terminate()
    {
        Console.WriteLine($"{_count} line");
    }
}