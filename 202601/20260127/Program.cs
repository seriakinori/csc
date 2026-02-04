using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;


namespace TextFileProcessor;

public abstract class TextProcessor{
    public static void Run<T>(String filename) where T:
    TextProcessor, new(){
        var self = new T();
        self.Process(filename);
    }

    private void Process(string filename)
    {
        Initialize(filename);
        using(var sr = new StreamReader(filename))
        {
            while(!sr.EndOfStream)
            {
                string? line = sr.ReadLine();
                Execute(line!);
            }
        }
        Terminate();
    }

    protected virtual void Initialize(string fname){}
    protected virtual void Execute(string line){}
    protected virtual void Terminate(){}
}
