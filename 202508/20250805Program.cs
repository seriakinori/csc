using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;

namespace Program20250805
{
    public class Program20250805
    {
        private static void DictionaryLinq()
        {
            var dict = new Dictionary<string, string>
            {
                { "CCCC", "2222" },
                { "AAAA", "0000" },
                { "DDDD", "3333" },
                { "BBBB", "1111" }
            };

            Console.WriteLine("");
            Console.WriteLine("Before Sort");

            foreach (string k in dict.Keys)
                Console.WriteLine(k + " " + dict[k]);

            var orderedKeys  =  from k in dict.Keys
                                orderby k
                                select k
                                ;

            Console.WriteLine("");
            Console.WriteLine("After Sort by Keys");
            foreach (string k in orderedKeys)
                Console.WriteLine(k + " " + dict[k]);

            var orderedValues = from v in dict.Values
                                orderby v
                                select v
                                ;

            Console.WriteLine("");
            Console.WriteLine("After Sort by Values");
            foreach (string v in orderedValues)
                Console.WriteLine(v);
        }

        private static void SelectLinq()
        {
            var points = new[] { 20, 30, 40, 50, 30, 60 };

            var result1 = new int[points.Length];
            var i = 0;
            foreach (var p in points)
            {
                result1[i] = p * 2;
                i++;
            }

            Console.WriteLine("");
            Console.WriteLine("foreach version");
            Console.WriteLine(string.Join(",", result1));

            var result2 = points.Select( x => x * 2 ).ToArray();
            Console.WriteLine("");
            Console.WriteLine("Linq version");
            Console.WriteLine(string.Join(",", result2));
        }

        private static void WhereLinq()
        {
            var points = new[] { 20, 30, 40, 50, 30, 60 };

            var result1 = new List<int>();
            //for (int i=0; i < points.Length; i++)
            foreach(var p in points)
            {
                if(p >= 40){
                    result1.Add(p);
                }
            }
            Console.WriteLine("");
            Console.WriteLine("foreach version");
            Console.WriteLine(string.Join(",", result1));

            var result2 = points.Where( x => x >= 40 ).ToArray();
            Console.WriteLine("");
            Console.WriteLine("Linq version");
            Console.WriteLine(string.Join(",", result2));
        }

        private static void DistinctLinq()
        {
            var points = new[] { 20, 30, 40, 50, 30, 60 };
            var result1 = new List<int>();

            foreach (var p in points)
            {
                if (!result1.Contains(p))
                {
                    result1.Add(p);
                }
            }
            Console.WriteLine("");
            Console.WriteLine("foreach version");
            Console.WriteLine(string.Join(",", result1));

            var result2 = points
                            .Distinct()
                            .ToList();

            Console.WriteLine("");
            Console.WriteLine("Linq version");
            Console.WriteLine(string.Join(",", result2));
        }
        private static void ConcatLinq()
        {
            var points1 = new[] { 20, 30, 40, 50, 30, 60 };
            var points2 = new[] { 90, 70, 60, 80, 100 };

            var result1 = new List<int>();
            foreach (int p1 in points1)
            {
                result1.Add(p1);
            }
            foreach (int p2 in points2)
            {
                result1.Add(p2);
            }

            Console.WriteLine("");
            Console.WriteLine("foreach version");
            Console.WriteLine(string.Join(",", result1));

            var result2 = points1.Concat(points2).ToArray();
            Console.WriteLine("");
            Console.WriteLine("Linq version");
            Console.WriteLine(string.Join(",", result2));

        }

        private static void TakeLinq()
        {
            var points = new[] { 20, 30, 40, 50, 30, 60 };
            var result = points.Skip(1).Take(3).ToList();
            Console.WriteLine(string.Join(",", result));
        }


        private static void ShowConsole(Dictionary<string, int> elements)
        {
            Console.WriteLine(
                string.Join(
                    "\n",
                    elements.Select(
                            x => { return x.Key + "\t" + x.Value; }
                    )
                )
            );
        }

        private static void ToDictionaryLinq()
        {
            var productList = new Dictionary<string, int>
            {
                {"apple", 200},
                {"orange", 100},
                {"grape", 500},
                {"bananas", 50}
            };

            /*
            var result1 = new Dictionary<string, int>();
            foreach (var i in productList)
            {
                result1.Add(i.Key, i.Value * 200);
            }

            Console.WriteLine("");
            Console.WriteLine("foreach version");
            ShowConsole(result1);
            */

            var result2 = productList
                            .OrderBy(x => x.Value)
                            .ToDictionary(x => x.Key, x => x.Value );
            Console.WriteLine("");
            Console.WriteLine("Order by Ascend");
            ShowConsole(result2);

            result2 = productList
                            .OrderByDescending(x => x.Value)
                            .ToDictionary(x => x.Key, x => x.Value );
            Console.WriteLine("");
            Console.WriteLine("Order by Descend");
            ShowConsole(result2);
        }

        public static void Main(string[] args)
        {
            //SelectLinq();
            //WhereLinq();
            //DistinctLinq();
            //ConcatLinq();
            ToDictionaryLinq();
        }
    }
}