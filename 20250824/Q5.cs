using System;
using System.Linq;
using System.Collections.Generic;

public class Q5_01
{

    public class YearMonth{
        public int Year{ get; init;}
        public int Month{ get; init;}

        public YearMonth(int year, int month){
            Year = year;
            Month = month;
        }

        public bool Is21Century => 2000 < this.Year && this.Year < 2101;

        public YearMonth AddOneMonth(){
            /*
            NextMonth = Month + 1;
            if (12 < NextMonth){
                return 1;
            }
            return NextMonth;
            */
            if(Month == 12){
                return new YearMonth(this.Year + 1, 1);
            }else{
                return new YearMonth(this.Year, this.Month + 1);
            }
        }

        public override string ToString(){
            //return this.Year + "年" + this.Month + "月";
            return $"{Year}年{Month}月";
        }
    }
    

    public static void Main(string[] args){
        YearMonth[] yearMonth5 = new YearMonth[]{
            new YearMonth(1986,1),
            new YearMonth(2004,4),
            new YearMonth(2015,7),
            new YearMonth(2017,7),
            new YearMonth(2025,8),
        };

        foreach(var s in yearMonth5){
            Console.WriteLine(s);
        }
    }
}
