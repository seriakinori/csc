using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Linq;

namespace SalesCalculator;

public class SalesCalculator
{
    private readonly IEnumerable<Sale> _sales;

    public SalesCalculator(string filePath)
    {
        _sales = ReadSales(filePath);
    }

    public IDictionary<string, int> GetPerStoreSales()
    {
        var dict = new SortedDictionary<string, int>();
        foreach (Sale sale in _sales)
        {
            if (dict.ContainsKey(sale.Id))
            {
                dict[sale.Id] += sale.Value;
            }
            else
            {
                dict[sale.Id] = sale.Value;
            }
        }
        return dict;
    }

    public static IEnumerable<Sale> ReadSales(string filePath)
    {
        List<Sale> sales = new List<Sale>();
        string[] lines = File.ReadAllLines(filePath);
        foreach (string line in lines)
        {
            string[] items = line.Split(',');
            Sale sale = new Sale{
                Id = items[0],
                Category = items[1],
                Value = int.Parse(items[2])
            };
            sales.Add(sale);
        }
        return sales;
    }
}

public class Sale
{
    public string? Id { get; set; }
    public string? Category { get; set; }
    public int Value { get; set; }
}

public class Program20250813
{
    
    public static void Main(string[] args)
    {
        /*
        foreach (Sale sale in sales) {
            Console.WriteLine(sale.Id);
            Console.WriteLine(sale.Category);
            Console.WriteLine(sale.Value);
        }
        */
        var sc = new SalesCalculator("data.csv");
        var dict = sc.GetPerStoreSales();
        foreach (var obj in dict) {
            Console.WriteLine("{0}:{1}",obj.Key, obj.Value);
        }
    }
}


