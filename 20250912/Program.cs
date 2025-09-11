using System;
using System.IO;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

public class Program
{
    public static DateTime getLastWrite(string filePath)
    {
        return new DirectoryInfo(filePath).LastWriteTime;
    }

    public static void setLastWrite(string filePath)
    {
        File.SetLastWriteTime(filePath, DateTime.Now);
    }

    static void MakeFile(string filePath, string text)
    {
        using (var writer = new StreamWriter(filePath))
        {
            writer.WriteLine(text);
        }
    }

    static void ConsoleWrite(string filePath)
    {
        if (!File.Exists(filePath))
        {
            return;
        }
        using var reader = new StreamReader(filePath);
        while (!reader.EndOfStream)
        {
            Console.WriteLine(reader.ReadLine());
        }
    }

    static void code10_47(string filePath) {
        var path = filePath;
        var directoryName = Path.GetDirectoryName(path);
        var fileName = Path.GetFileName(path);
        var extension = Path.GetExtension(path);
        var filenameWithoutExtension = Path.GetFileNameWithoutExtension(path);

        Console.WriteLine(directoryName);
        Console.WriteLine(fileName);
        Console.WriteLine(extension);
        Console.WriteLine(filenameWithoutExtension);
    }

    static string code10_48(string filePath)
    {
        return Path.GetFullPath(filePath);
    }

    static void code10_53()
    {
        var userProfile = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
        Console.WriteLine(userProfile);

        var desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        Console.WriteLine(desktopPath);

        var myDocumentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        Console.WriteLine(myDocumentsPath);

        var programFilePath = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles);
        Console.WriteLine(programFilePath);

        var systemPath = Environment.GetFolderPath(Environment.SpecialFolder.System);
        Console.WriteLine(systemPath);
    }

    static void p246_column()
    {
        Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
        var sjis = Encoding.GetEncoding("shift_jis");
        using (var writer = new StreamWriter("aaaa_sjis.txt", append: false, encoding: sjis))
        {
            writer.WriteLine("aaaa - this is sjis encoding.");
        }
    }


    static void Main(string[] args)
    {
        //MakeFile("ghgh.txt","ghgh\nijij\nklkl");
        //ConsoleWrite("ghgh.txt");
        //setLastWrite("ghgh.txt");
        //Console.WriteLine(getLastWrite("ghgh.txt"));
        //code10_47(@"C:\Users\User\Desktop\csc\20250912\bin\Debug\net8.0\20250912.exe");
        //Console.WriteLine(code10_48(@"../ghgh.txt"));
        //code10_53();
        p246_column();
        return;
    }
}