using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExcelDataReader;
using System.IO;
using System.Data;

namespace TalentShareSkillProject.DataUtility
{
    public class ExcelUtility
    {
        
        public List<DataCollection> dcList = new List<DataCollection>();  

        public int TotalRows { get; set; }
         
        private DataTable readExcelDataIntoDataTable(string filename,string sheetName)
        {
            using (System.IO.FileStream memory = File.Open(filename, FileMode.Open, FileAccess.Read))
            {
                System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
                using (IExcelDataReader reader = ExcelDataReader.ExcelReaderFactory.CreateOpenXmlReader(memory))
                {
                    DataSet result = reader.AsDataSet(new ExcelDataSetConfiguration()
                    {
                        ConfigureDataTable = (_) => new ExcelDataTableConfiguration()
                        {
                            UseHeaderRow = true
                        }
                    });


                    DataTableCollection tableColl = result.Tables;
                    DataTable dataTable = tableColl[sheetName];

                    return dataTable;
                }

            }

        }

        public void populateDataCollectionList()
        {
            // DataTable dt = readExcelDataIntoDataTable(@"C:\Renu\Indusconnect\TalentProfileProject\TalentProfileProject\Data\ShareSkill_Data.xlsx", "Add_Data_ShareSkill");
            string RootFolder = Directory.GetParent(@"../../../").FullName
                + Path.DirectorySeparatorChar + "Data" 
                + Path.DirectorySeparatorChar + "ShareSkill_Data.xlsx";

            DataTable dt = readExcelDataIntoDataTable(RootFolder, "Add_Data_ShareSkill");

            TotalRows = dt.Rows.Count;
          
            //  System.Diagnostics.Debug.WriteLine("Matrix has you..." + dt.Columns.Count + " " + dt.Rows.Count + "  " + dt.Rows[1][1].ToString());

            for (int row = 0; row < dt.Rows.Count;row++ )
            {
                for (int col = 0; col < dt.Columns.Count; col++)
                {
                    DataCollection dtTable = new DataCollection()
                    {
                        rowNum = row,
                        colName = dt.Columns[col].ColumnName.ToUpper(),
                        colValue = dt.Rows[row][col].ToString()
                    };
                  dcList.Add(dtTable);  
                }
            }

        }


        public string readSingleRowData(int rownum, string colname)
        {

            try
            {
                string data = (from colData in dcList
                               where colData.colName == colname && colData.rowNum == rownum
                               select colData.colValue).SingleOrDefault();
                return data;
            }
            catch (Exception ex)
            {
                return null;
            }


        }
        
    }
}
