using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Collections.Generic;


class Practice
{
    static void q10_1_1(string filePath)
    {
        if (!File.Exists(filePath))
        {
            return;
        }

        using var reader = new StreamReader(filePath);
        int cnt = 0;
        string line = "";
        while (!reader.EndOfStream)
        {
            line = reader.ReadLine();
            if (line.Contains("class"))
            {
                Console.WriteLine(line);
                cnt++;
            }
        }

        Console.WriteLine(cnt);
    }

    static void q10_1_2(string filePath)
    {
        if (!File.Exists(filePath))
        {
            return;
        }

        var lines = File.ReadAllLines(filePath);
        int cnt = 0;
        foreach (var line in lines)
        {
            if (line.Contains("class"))
            {
                Console.WriteLine(line);
                cnt++;
            }
        }
        Console.WriteLine(cnt);
    }

    static void q10_1_3(string filePath)
    {
        if (!File.Exists(filePath))
        {
            return;
        }

        var cnt = File.ReadLines(filePath).Count(s => s.Contains("class"));
        Console.WriteLine(cnt);
    }

    static void q10_2(string inputPath, string outputPath)
    {
        using var reader = new StreamReader(inputPath);
        using var writer = new StreamWriter(outputPath);
        int cnt = 1;
        string outputContent = "";
        while (!reader.EndOfStream)
        {
            outputContent = reader.ReadLine();
            writer.WriteLine("{0}:{1}",cnt.ToString("00"),outputContent);
            cnt++;
        }
    }

    static void q10_3(string filePath1, string filePath2)
    {
        using var reader = new StreamReader(filePath1);
        using var writer = new StreamWriter(filePath2, append:true);
        string outputContent = "";
        while (!reader.EndOfStream)
        {
            outputContent = reader.ReadLine();
            writer.WriteLine(outputContent);
        }
    }

    static void q10_4()
    {
        var d1 = new DirectoryInfo("./d1");
        var files = d1.EnumerateFiles();
        foreach (var file in files)
        {
            if (file.Length > 1048576)
                Console.WriteLine(file.Name);
        }
        var subdirs = d1.EnumerateDirectories();
        foreach (var d2 in subdirs)
        {
            var files2 = d2.EnumerateFiles();
            foreach(var file2 in files2)
                if (file2.Length > 1048576)
                    Console.WriteLine(file2.Name);
        }
    }

    static void q10_5(string filePath)
    {
        var d1 = new DirectoryInfo(filePath);
        var d1_files = new List<string>();
        foreach (var f1 in d1.EnumerateFiles())
        {
            d1_files.Add(f1.Name);
        }
        foreach (var f2 in d1_files)
        {
            File.Copy("d1/" + f2,"d2/" + Path.GetFileNameWithoutExtension(f2) + "_bak" + Path.GetExtension(f2));
        }
    }

    public static void Main(string[] args)
    {
        //q10_1_1("target.cs");
        //q10_1_2("target.cs");
        //q10_1_3("target.cs");
        //q10_2("target.cs", "indexed_output.txt");
        //q10_3("aaaa.txt", "abab.txt");
        //q10_4();
        q10_5("d1");
    }
}