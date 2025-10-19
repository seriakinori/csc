using System;
using System.Text;
using System.Threading.Tasks;

public class code14_22
{
    private readonly HttpClient _httpClient = new HttpClient();

    public async Task Run()
    {
        var tasks = new Task<string>[]
        {
            GetPageAsync(@"https://toyokeizai.net/articles/-/911750?display=b"),
            GetPageAsync(@"https://backlog.com/ja/git-tutorial/")
        };
        var results = await Task.WhenAll(tasks);

        var text = $"{results[0].Substring(0, 400)}\n\n{results[1].Substring(0, 400)}";

        Console.WriteLine(text);
    }

    private async Task<string> GetPageAsync(string urlstr)
    {
        var str = await _httpClient.GetStringAsync(urlstr);
        return str;
    }
}

public class q14_1()
{
    public async Task Run()
    {
        var text = await TextReader.ReadFileAsync("Code14_12.cs");
        Console.WriteLine(text);
    }

    public async void Main()
    {
        Task task = Run();
    }
}

static class TextReader{
    public static async Task<string> ReadFileAsync(string filename)
    {
        var reader = new StreamReader(filename);
        var sb = new StringBuilder();
        using (reader)
        {
            while (!reader.EndOfStream)
            {
                var line = await reader.ReadLineAsync();
                sb.AppendLine(line);
                await Task.Delay(80);
            }
        }
        return sb.ToString();
    }
}
    


public class Program
{
    public static async Task Main(string[] args)
    {
        new q14_1().Main();
        //var o = new code14_22();
        //await o.Run();
    }
}