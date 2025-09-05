using ClosedXML.Excel;
using System;

class Program20250806
{
    static void Main(string[] args)
    {
        using (var workbook = new XLWorkbook())
        {
            var worksheet = workbook.Worksheets.Add("SampleSheet");
            worksheet.Cell("A1").Value = "200";
            worksheet.Cell("A1").Style.Fill.BackgroundColor = ClosedXML.Excel.XLColor.Red;
            workbook.SaveAs(@"C:\Users\User\Desktop\csc\20250806\20250806Excel.xlsx");
            workbook.Dispose();
        }
    }
}