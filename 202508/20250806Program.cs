using System;
using System.Windows.Forms;
using ClosedXML.Excel;
using System.IO;

namespace Program20250806
{
    class Program20250806
    {
        static void Main(string[] args)
        {

            Console.WriteLine("AAAAA");
            ClosedXML.Excel.XLWorkbook book = new ClosedXML.Excel.XLWorkbook();

            ClosedXML.Excel.IXLWorksheet worksheet = book.Worksheets.Add("sheet1");

            worksheet.Cell("A1").Value = 10;

            worksheet.Cell("A1").Style.Fill.BackgroundColor = ClosedXML.Excel.XLColor.Red;

            try
            {
                string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string fileName = "20250806Excel.xlsx";
                string filePath = Path.Combine(desktopPath, fileName);
                Console.WriteLine(filePath);
                book.SaveAs(filePath);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                Console.WriteLine("BBBBB");
            }

            book.Dispose();
        }
    }
}