using System.Text.Json;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

class Program
{
    static async Task<string> GetFromWikipediaAsync(HttpClient httpClient, string keyword)
    {
        var builder = new UriBuilder("https://ja.wikipedia.org/w/api.php");
        var content = new FormUrlEncodedContent(new Dictionary<string, string>()
        {
            ["action"] = "query",
            ["format"] = "json",
            ["prop"] = "extracts",
            ["redirects"] = "1",
            ["explaintext"] = "1",
            ["titles"] = keyword,
        });

        builder.Query = await content.ReadAsStringAsync();
        var jsonString = await httpClient.GetStringAsync(builder.Uri);

        return GetContentString(jsonString);
    }

    static string GetContentString(string jsonString)
    {
        var jsonNode = JsonNode.Parse(jsonString);
        var node = jsonNode["query"]!["pages"]!;
        var pagesElement = JsonSerializer.Deserialize<JsonElement>(node);
        var name = GetChildPropertyName(pagesElement);
        JsonElement contentElement = pagesElement.GetProperty(name);
        JsonElement extractElement = contentElement.GetProperty("extract");
        return extractElement.GetString() ?? "";
    }

    static string GetChildPropertyName(JsonElement element)
    {
        return element.EnumerateObject().First().Name;
    }


    public static async Task Main(string[] args)
    {
        var httpClient = new HttpClient();
        httpClient.DefaultRequestHeaders.Add("User-Agent", 
    "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/108.0.0.0 Safari/537.36");
        var text = await GetFromWikipediaAsync(httpClient, "森鷗外");
        Console.WriteLine(text);
    }
}