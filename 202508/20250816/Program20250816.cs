namespace ConsoleApp1;

public class Program20250816
{
    static void Q1(List<string> cities){
        var name = Console.ReadLine();
        int idx = cities.FindIndex(s => s == name);
        Console.WriteLine(idx);
    }

    static void Q2(List<string> cities){
        var ocities = cities.Count(s => s.Contains('o'));
        Console.WriteLine(ocities);

    }

    static void Q3(List<string> cities){
        var ocities = cities.Where(s => s.Contains('o'));
        foreach(string ocity in ocities){
            Console.WriteLine(ocity);
        }
    }

    static void Q4(List<string> cities){
        //var cities_length = cities.Where(s => s[0] == 'B').Select(s => s.Length);
        var cities_length = cities.Where(s => s.StartsWith('B')).Select(s => s.Length);


        foreach(int city_length in cities_length){
            Console.WriteLine(city_length);
        }

    }
    public static void Main(string[] args){
        var cities = new List<string> {
            "Tokyo", "New Delhi", "Bangkok", "London", "Paris", "Berlin",
            "Canberra", "Hong Kong",
        };

        //Q1(cities);
        Q4(cities);
    }
}
