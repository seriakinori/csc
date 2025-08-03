using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace Sample201
{
    class Program
    {
        void StringTest1() {
            string str1, str2;
            str1 = Console.ReadLine();
            str2 = Console.ReadLine();
            Console.WriteLine("str1={0}", str1); 
            Console.WriteLine("str2={0}", str2); 
        }

        void StringTest2()
        {
            const int NUMBER = 100;
            const string STRING = "HOGE";
            //STRING = "bar";
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.StringTest2();
            /*
            Console.WriteLine("{0} + {1} = {2}", 5, 2, 5 + 2);
            Console.WriteLine("{0} - {1} = {2}", 5, 2, 5 - 2);
            Console.WriteLine("{0} * {1} = {2}", 5, 2, 5 * 2);
            Console.WriteLine("{0} / {1} = {2} % {3}", 5, 2, 5 / 2, 5 % 2);
            int a;
            int b = 3;
            int add, sub;
            double avg;
            a = 6;
            add = a + b;
            sub = a - b;
            avg = (a + b) / (double)2;

            Console.WriteLine("{0} + {1} = {2}", a, b, add);
            Console.WriteLine("{0} - {1} = {2}", a, b, sub);
            Console.WriteLine("{0} and {1}'s average = {2}", a, b, avg);
            */
        }
    }
}