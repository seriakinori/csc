using System;
using System.IO;
using System.Text;
using System.Linq;
using System.Collections.Generic;


class Program{

    static void ReadOutput(string filePath){
        if(File.Exists(filePath)){
            using var reader = new StreamReader(filePath, Encoding.UTF8);
            while(!reader.EndOfStream){
                var line = reader.ReadLine();
                Console.WriteLine(line);
            }
        }
    }

    static void code10_10(){
        var filePath = "aaaa.txt";
        using(var writer = new StreamWriter(filePath)){
            writer.WriteLine("aaaa");
            writer.WriteLine("bbbb");
            writer.WriteLine("cccc");
        }
    }

    static void code10_11(){
        var lines = new[] { "====", "****", "++++"};
        var filePath = "aaaa.txt";
        using (var writer = new StreamWriter(filePath, append: true)){
            foreach(var line in lines){
                writer.WriteLine(line);
            }
        }
    }

    static void code10_12(){
        var lines = new[] {"AAAA","BBBB","CCCC"};
        var filePath = "bbbb.txt";
        File.WriteAllLines(filePath,lines);
    }

    static void code10_13(){
        var lines = new[] {"abcd","efgh","baba","aabb"};
        var filePath = "abab.txt";
        File.WriteAllLines(filePath, lines.Where(s => s.Contains("ab")));
    }

    static void code10_14(){
        var filePath = "abab.txt";
        using var stream = new FileStream(filePath, FileMode.Open, FileAccess.ReadWrite, FileShare.None);
        using var reader = new StreamReader(stream);
        using var writer = new StreamWriter(stream);

        string texts = reader.ReadToEnd();
        stream.Position = 0;
        writer.WriteLine("xyxy");
        writer.WriteLine("z.z.");
        writer.Write(texts);
    }

    static void Main(string[] args){
        //code10_10();
        //code10_11();
        //code10_12();
        //code10_13();
        code10_14();
        ReadOutput("abab.txt");
    }
}