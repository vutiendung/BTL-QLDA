using Excel;
using System.Data;
using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
    public class MoFileExcel
    {
        public static DataTable GetDatasetFromExcel(string path)
        {
            FileStream stream = File.Open(path, FileMode.Open, FileAccess.Read);
            IExcelDataReader excelReader = ExcelReaderFactory.CreateBinaryReader(stream);
            excelReader.IsFirstRowAsColumnNames = true;
            DataSet result = excelReader.AsDataSet();
            DataTable dt = result.Tables[0];
            return dt;
        }

        public static DataTable GetDatasetFromExcel(string path, string tableName)
        {
            FileStream stream = File.Open(path, FileMode.Open, FileAccess.Read);
            IExcelDataReader excelReader = ExcelReaderFactory.CreateBinaryReader(stream);
            excelReader.IsFirstRowAsColumnNames = true;
            DataSet result = excelReader.AsDataSet();
            DataTable dt = result.Tables[tableName];
            return dt;
        }

        public static string[] getTableName(string path)
        {
            FileStream stream = File.Open(path, FileMode.Open, FileAccess.Read);
            IExcelDataReader excelReader = ExcelReaderFactory.CreateBinaryReader(stream);
            excelReader.IsFirstRowAsColumnNames = true;
            DataSet result = excelReader.AsDataSet();
            DataTable dt = result.Tables[0];
            string[] files = new string[result.Tables.Count];
            for (int i = 0; i < files.Length; i++)
            {
                files[i] = result.Tables[i].TableName;
            }
            return files;
        }

    }
}
