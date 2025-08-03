/*
usingの後に続くのは、名前空間であり、以下のように記述すると、プログラムの中で、指定した名前空間を利用するという宣言になります
*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

/*
https://csharp.sevendays-study.com/day1.html
*/

/*
ネームスペース（日本語で、「名前空間」）と呼ばれ、このプログラムを分類する「入れ物」の名前を決める部分
*/
namespace Sample101
{
    class Program
    {
        /*
        エントリーポイント
         */
        static void Main(string[] args)
        {
            Console.WriteLine("HelloWorld");
        }
    }
}