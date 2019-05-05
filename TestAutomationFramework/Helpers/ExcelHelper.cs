using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAutomationFramework.Helpers
{
    public class ExcelHelper
    {
        private static List<DataCollection> dataCol = new List<DataCollection>();

        private static DataTable ExcelToDataTable(string filePath)
        {
            FileStream stream = File.Open(filePath,FileMode.Open,FileAccess.Read);
            IExcelDataReader excelReader = ExcelReaderFactory.CreateOpenXmlReader(stream);//.xlsx
                                                                                          // excelReader = true;
            DataSet result = excelReader.AsDataSet();//returns dataset
            DataTableCollection table = result.Tables;
            DataTable resultTable = table["Sheet1"];

            return resultTable;
        }

        public static void PopulateIntoCollection(string filePath)
        {
            DataTable table = ExcelToDataTable(filePath);
            //iterate through rows and columns of the table
            for (int row = 2; row <= table.Rows.Count; row++)
            {
                for (int col = 0; col < table.Columns.Count; col++)
                {
                    DataCollection dtTable = new DataCollection()
                    {
                        rowNumber = row,
                        colName=table.Columns[col].ColumnName ,
                        colValue=table.Rows[row-1][col].ToString()
                    };
                    //add all the details of each row
                    dataCol.Add(dtTable);
                }
            }
        }

        public static string ReadData(int rowNum, string colName)
        {
            try
            {
                string data = (from colData in dataCol
                               where colData.rowNumber == rowNum && colData.colName == colName
                               select colData.colValue).SingleOrDefault();
                return data.ToString();
            }
            catch (Exception e)
            {
                return null;
            }
        }

    }

    public class DataCollection
    {
        public int rowNumber { get; set; }
        public string colName { get; set; }
        public string colValue { get; set; }
    }
}
