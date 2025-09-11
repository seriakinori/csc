using System;
using System.IO;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System.Reflection.Metadata;
using Microsoft.VisualBasic;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void ConsoleWrite(string filePath)
    {
        if (File.Exists(filePath))
        {
            using var reader = new StreamReader(filePath, Encoding.UTF8);
            while (!reader.EndOfStream) {
                var content = reader.ReadLine();
                Console.WriteLine(content);
            }
        }
        return;
    }
    static void MakeFile(string filePath)
    {
        using (var writer = new StreamWriter(filePath))
        {
            writer.WriteLine("pppp");
            writer.WriteLine("qqqq");
            writer.WriteLine("rrrr");
        }
        return;
    }

    static void code10_15(string filePath)
    {
        if (File.Exists(filePath))
        {
            Console.WriteLine("Already exists.");
        }
        else
        {
            Console.WriteLine("Not exists yet.");
        }
    }

    static void code10_17(string filePath)
    {
        File.Delete(filePath);
    }

    static void code10_18(string orgFilePath, string newFilePath)
    {
        File.Copy(orgFilePath,newFilePath);
    }

    static void code10_20(string orgFilePath, string newFilePath)
    {
        File.Move(orgFilePath,newFilePath);
    }

    static void code10_25(string filePath)
    {
        var lastWriteTime = File.GetLastWriteTime(filePath);
        Console.WriteLine(lastWriteTime);
        return;
    }

    static void code10_26(string filePath)
    {
        File.SetLastWriteTime(filePath,DateTime.Now);
        //Console.WriteLine(lastWriteTime);
        return;
    }

    static void code10_29(string filePath)
    {
        var finfo = new FileInfo(filePath);
        DateTime lastCreationTime = finfo.CreationTime;
        Console.WriteLine(lastCreationTime);
        return;
    }

    static void code10_30(string filePath)
    {
        var finfo = new FileInfo(filePath);
        Console.WriteLine(finfo.Length);
        return;
    }

    static void code10_32(string filePath)
    {
        Console.WriteLine(Directory.Exists(filePath));
    }

    static void code10_33(string dirPath)
    {
        Console.WriteLine(Directory.CreateDirectory(dirPath));
    }
    static void code10_34(string dirPath)
    {
        Console.WriteLine(Directory.CreateDirectory(dirPath));
    }
    static void code10_35(string dirPath, string subDirPath)
    {
        DirectoryInfo di = new DirectoryInfo(dirPath);
        DirectoryInfo sdi = di.CreateSubdirectory(subDirPath);
    }

    static void code10_36(string dirPath)
    {
        Directory.Delete(dirPath);
    }
    static void p238_memo()
    {
        Console.WriteLine(Directory.GetCurrentDirectory());
        Directory.SetCurrentDirectory("ssss");
        Console.WriteLine(Directory.GetCurrentDirectory());
        Directory.SetCurrentDirectory("../");
        Console.WriteLine(Directory.GetCurrentDirectory());
    }

    static void code10_39(string dirPath, string newDirPath)
    {
        Directory.Move(dirPath, newDirPath);
    }

    static void code10_43(string dirPath)
    {
        var di = new DirectoryInfo(dirPath);
        var files = di.EnumerateFiles("*");
        foreach (var file in files)
        {
            Console.WriteLine($"{file.Name} {file.CreationTime}");
        }
    }

    static void code10_43_(string dirPath)
    {
        var di = new DirectoryInfo(dirPath);
        var files = di.EnumerateFiles("*.txt")
            .Where(s => s.Name.Contains("r"));
        foreach (var file in files)
        {
            Console.WriteLine($"{file.Name} {file.CreationTime}");
        }
    }

    static void code10_44(string dirPath)
    {
        var di = new DirectoryInfo(dirPath);
        var directories = di.EnumerateDirectories();
        foreach (var dir in directories)
        {
            Console.WriteLine($"{dir.FullName} {dir.CreationTime}");
        }
    }

    static void code10_45(string dirPath)
    {
        var di = new DirectoryInfo(dirPath);
        var fileSystems = di.EnumerateFileSystemInfos();
        foreach (var item in fileSystems)
        {
            if (item.Attributes.HasFlag(FileAttributes.Directory))
            {
                Console.WriteLine($"{item.Name} {item.CreationTime} {item.Attributes}");
            }
            else
            {
                Console.WriteLine($"{item.Name} {item.CreationTime} {item.Attributes}");
            }
        }
    }

    static void code10_46(string dirPath)
    {
        var now = DateTime.Now;
        var di = new DirectoryInfo(dirPath);
        FileSystemInfo[] fileSystems = di.GetFileSystemInfos();
        foreach (var item in fileSystems)
        {
            item.LastWriteTime = now;
        }
    }

    static void Main(string[] args)
    {
        //MakeFile("pppp.txt");
        //ConsoleWrite("pppp.txt");
        //code10_18("pppp.txt", "qqqq.txt");
        //code10_17("pppp.txt");
        //code10_15("pppp.txt");
        //code10_20("qqqq.txt", "rrrr.txt");
        //code10_26("pppp.txt");
        //code10_25("pppp.txt");
        //code10_29("pppp.txt");
        //code10_30("pppp.txt");
        //code10_33("ssss");
        //code10_34("tttt/uuuu");
        //code10_32("ssss");
        //code10_35("ssss", "vvvv");
        //code10_36("ssss/vvvv");
        //code10_39("tttt/uuuu", "ssss/uuuu");
        //p238_memo();
        //code10_43("./");
        //code10_43_("./");
        //code10_44("./");
        //code10_45("./");
        code10_46("./");

        return;
    }
}
