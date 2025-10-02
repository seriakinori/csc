using System;
using System.IO;
using System.Text;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void MakeFile(string filePath, string fileContent)
    {
        using var writer = new StreamWriter(filePath);
        writer.WriteLine(fileContent);
    }

    static void ReadFile(string filePath)
    {
        if (File.Exists(filePath))
        {
            using var reader = new StreamReader(filePath);
            while (!reader.EndOfStream)
            {
                Console.WriteLine(reader.ReadLine());
            }
        }
    }

    public static void Main(string[] args)
    {
        MakeFile("aaaa.txt", "This is a File.");
        ReadFile("aaaa.txt");
    }
}