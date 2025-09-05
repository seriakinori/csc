using System;
using System.Text;
using System.IO;
using System.Collections.Generic;
using System.Diagnostics.Contracts;

namespace Program20250809
{
    public class Product
    {
        public int Code { get; set; }

        public string Name { get; set; }

        public int Price { get; set; }


        public Product(int code, string name, int price)
        {
            this.Code = code;
            this.Name = name;
            this.Price = price;
        }
        private readonly double _taxRate = 0.1;

        public int GetTax()
        {
            return (int)(Price * _taxRate);
        }

        public int GetPriceIncludingTax()
        {
            return Price + GetTax();
        }

    }
    /*
        クラスの場合、変数とは別の場所にオブジェクトの領域が確保され、変数にはその参照が格納される
        構造体の場合、変数そのものにオブジェクトが格納される
    */
    public class ClassA
    {
        public int X { get; set; }
        public int Y { get; set; }
    }
    struct StructA
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

    //struct PointA
    class PointA
    {
        public int X { get; set; }
        public int Y { get; set; }
        public PointA(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
    }


    public class EntryPoint
    {
        public static void Main(string[] args)
        {
            //Product book = new Product(67548888, "The Book", 1000);
            //Console.WriteLine(book.GetPriceIncludingTax());

            /*
            ClassA classA = new ClassA { X = 1, Y = 2 };
            StructA structA = new StructA { X = 3, Y = 4 };

            Console.WriteLine(classA.X);
            Console.WriteLine(classA.Y);

            Console.WriteLine(structA.X);
            Console.WriteLine(structA.Y);
            */

            PointA a = new PointA(10, 20);
            PointA b = a;

            Console.WriteLine(a.X);
            Console.WriteLine(b.X);
            a.X = 80;
            Console.WriteLine(a.X);
            Console.WriteLine(b.X);

        }
    }
}
