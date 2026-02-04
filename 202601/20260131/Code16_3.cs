using System.Security.Cryptography.X509Certificates;

public class Abbreviations
{
    private readonly Dictionary<string, string> _dict = [];

    public Abbreviations()
    {
        var lines = File.ReadAllLines("./Abbreviations.txt");
        _dict = lines.Select(line => line.Split('=')).ToDictionary(x => x[0],  x => x[1]);
    }

    public void Add(string abbr, string japanese) => _dict[abbr] = japanese;

    public string? this[string abbr]  => _dict.ContainsKey(abbr) ? _dict[abbr] : null;

    public string? ToAbbreviation(string japanese) => _dict.FirstOrDefault(x => x.Value == japanese).Key;

    public IEnumerable<(string, string)> FindAll(string substring)
    {
        foreach(var (key, value) in _dict)
        {
            if (value.Contains(substring))
            {
                yield return (key, value);
            }
        }
    }
}