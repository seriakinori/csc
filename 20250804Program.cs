using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program20250804{
    public class Class1
    {
        static void ListTest1(){
            List<int> a = new List<int>();
            a.Add(5);
            a.Add(3);
            a.Add(0);
            a.Add(9);
            foreach(int i in a)
                Console.Write(i);
            Console.WriteLine("");

            a.Insert(1,4);
            foreach(int i in a)
                Console.Write(i);
        }

        static void ListTest2(){
            List<String> a = new List<String>();
            a.Add("AAAA");
            a.Add("BBBB");
            a.Add("CCCC");
            a.Add("DDDD");
            foreach(String i in a)
                Console.Write(i);
            Console.WriteLine("");

            //a.Remove("DDDD");
            a.RemoveAt(1);
            foreach(String i in a)
                Console.Write(i);
            Console.WriteLine("");
        }

        static void DictionaryTest(){
            Dictionary<String, String> dict = new Dictionary<String, String>();

            dict["0"] = "0000";
            dict["1"] = "0001";
            dict["2"] = "0010";
            dict["3"] = "0011";
            dict["4"] = "0100";

            foreach(String s in dict.Keys)
                Console.WriteLine("{0}:{1}", s, dict[s]);
        }

        static void HashSetTest(){
            HashSet<int> t = new HashSet<int>();
            t.Add(4);
            t.Add(2);
            t.Add(2);
            t.Add(0);
            t.Add(3);
            t.Add(1);
            t.Add(2);
            t.Add(4);

            foreach(int i in t)
                Console.WriteLine(i);
        }

        static void Main(string[] args){
            //ListTest2();
            //DictionaryTest();
            HashSetTest();

        }
        
    }

}

