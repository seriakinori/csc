using System;
using System.IO;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using ClosedXML.Excel;
using DocumentFormat.OpenXml.Spreadsheet;
using System.Runtime.InteropServices.Marshalling;


namespace Program20250807{
    class HandleExcel
    {
        public static String ExcelDataPath = @"C:\Users\User\Desktop\csc\20250807\data\Excel20250807.xlsx";

        // エクセルを開いて、シートを参照
        public void OpenExcelFile()
        {
            try
            {
                using (var workbook = new XLWorkbook(ExcelDataPath))
                {
                    var worksheet = workbook.Worksheet(1);

                    // データが入力されている行末尾を取得
                    var lastRow = worksheet.LastRowUsed();
                    // 警告 CS8602 は、「その変数は null かもしれないのに、null でないことを確認せずにプロパティやメソッドを使おうとしています」という警告の回避 
                    if (lastRow != null)
                    {
                        int lastRowNumber = lastRow.RowNumber();
                        for (int i=1; i<lastRowNumber; i++)
                        {
                            var numcell = worksheet.Cell(i, 1);
                            var datacell = worksheet.Cell(i, 8);
                            Console.WriteLine("{0}: {1}", numcell.Value, datacell.Value);
                        }
                    }
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return;
        }

        // エクセル内のデータを取得
        public List<List<String>> GetExcelData(IXLWorksheet worksheet)
        {
            List<List<String>> ExcelData = new List<List<String>>();

            return ExcelData;
        }
        // セルのNo列からシーケンス番号を取得
    }

    class HandleTextFile
    {
        // 新規のテキストファイルを作成
        public void WriteCellDataToText(List<String> RowData)
        {
            String TextName = RowData[0];
            String CellData = RowData[1];
            // テキストの保存先指定のため、カレントディレクトリを取得
            string SavePath = Directory.GetCurrentDirectory();

            // シーケンス番号を名前として新規テキストファイルを作成
            try
            {
                // ストリームを開く
                StreamWriter sw = new StreamWriter(SavePath + @"\output\" + TextName + ".txt");
                // セルの内容をテキストファイルに書き込む
                sw.Write(CellData);
                // ストリームを閉じる
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }
    }

    class Program20250807
    {
        static void Main(string[] args)
        {
            HandleExcel handleExcel = new HandleExcel();
            handleExcel.OpenExcelFile();
        }
    }
}