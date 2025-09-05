using System;
using System.Collections;
using System.Linq;
//using System.Text;
using System.Text.RegularExpressions;
using System.IO;

/*
    C# Program for changing filenames in this directory.
    The new names should begin with dates: yyyymmddProgram.**
 */
namespace ChangeFileName
{
    class ChangeFileName
    {
        public static void Main(string[] args)
        {
            string[] fileEntries = Directory.GetFiles("./");
            foreach (string fileName in fileEntries)
                //ChangeName(fileName);
                RemoveUnderscore(fileName);
        }
        private static void ChangeName(string before)
        {
            string after = "None";
            string rgx = @"^(\.\/)(.+)(2025\d{2}\d{2})(.+)$";
            if (Regex.IsMatch(before, rgx))
            {
                before = before.Replace("_", "");
                Console.WriteLine("before: {0}", before);
                after = Regex.Replace(before, rgx, "$1$3_$2$4");
                File.Move(before, after);
                Console.WriteLine("before: {0}, after: {1}", before, after);
            }
        }

        private static void RemoveUnderscore(string before) {
            string after = before.Replace("_", "");
            File.Move(before, after);
        }
    }
}