using System;
using System.IO;
using System.Text;
using System.Linq;
using System.Collections.Generic;

using ClosedXML.Excel;
using DocumentFormat.OpenXml.Spreadsheet;
using System.Runtime.InteropServices.Marshalling;

namespace Program20250808
{
    class HandleExcel
    {
        public static String ExcelDataPath = @"C:\Users\User\Desktop\csc\20250808\data\Excel20250807.xlsx";

        // エクセルを開いて、シートを参照
        public Dictionary<String, List<String>> OpenExcelFile()
        {
            Dictionary<String, List<String>> excelData = new Dictionary<string, List<String>>();
            try
            {
                using (var workbook = new XLWorkbook(ExcelDataPath))
                {
                    var worksheet = workbook.Worksheet(1);
                    var lastRow = worksheet.LastRowUsed();

                    if (lastRow != null)
                    {
                        int lastRowIndex = lastRow.RowNumber();
                        for (int i = 2; i < lastRowIndex; i++)
                        {
                            List<String> excelValue = new List<String>();
                            excelValue.Add(worksheet.Cell(i, 2).Value.ToString());
                            excelValue.Add(worksheet.Cell(i, 8).Value.ToString());

                            excelData.Add(worksheet.Cell(i, 1).Value.ToString(), excelValue);
                            //Console.WriteLine(worksheet.Cell(i, 1).Value.ToString());
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }

            return excelData;
        }

    }

    class HandleTextFile
    {
        public static String WriteTextPath = @"C:\Users\User\Desktop\csc\20250808\text\";
        public void HandleTextFileWriteCellDataToText(Dictionary<String, List<String>> excelData)
        {
            foreach (String k in excelData.Keys)
            {
                List<String> rowValue = excelData[k];
                String newFileName = k;
                Console.WriteLine("Writing {0}.txt...", k);
                try
                {
                    using (StreamWriter textFile = new StreamWriter(WriteTextPath + newFileName + ".txt"))
                    {
                        //Console.WriteLine("key:{0} category:{1} Value:{2}", k, rowValue[0], rowValue[1]);
                        textFile.WriteLine(rowValue[0]);
                        textFile.WriteLine(rowValue[1]);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine(e.StackTrace);
                }
            }
        }

    }

    class Program20250808
    {
        public static void Main(string[] args)
        {
            HandleExcel handleExcel = new HandleExcel();
            Dictionary<String, List <String>> excelData = handleExcel.OpenExcelFile();
            HandleTextFile handleText = new HandleTextFile();
            handleText.HandleTextFileWriteCellDataToText(excelData);
        }
    }
}