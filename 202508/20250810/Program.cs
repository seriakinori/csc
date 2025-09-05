using System;
using SampleApp;
using System.Text;
using System.IO;
using System.Collections.Generic;
using System.Linq;
/*
*/

namespace SampleApp
{
    public class Product
    {
        public Product(int code, string name, int price)
        {
            this.Code = code;
            this.ProductName = name;
            this.Price = price;
        }
        public int Code { get; set; }
        public string ProductName { get; set; }
        public int Price { get; set; }
    }
}
namespace Program20250810
{
    public class Program
    {
        /*
        }
        */
        public void Run()
        {
            Product p = new Product(123,"AAA",1000);
            Console.WriteLine(p.Code);
            Console.WriteLine(p.Price);
        }
        public static void Main(string[] args)
        {
            //System.Diagnostics.Debug.WriteLine("System.Diagnostics.Debug.WriteLine");
            //Console.WriteLine("System.Console.WriteLine");
            Program pgm = new Program();
            pgm.Run();
        }
    }
}