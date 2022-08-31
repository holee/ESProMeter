using ClosedXML.Excel;
using DocumentFormat.OpenXml.Spreadsheet;
using ESProMeter.Services;
using Microsoft.CodeAnalysis.VisualBasic.Syntax;
using Microsoft.Office.Interop.Excel;
using System;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using Color = System.Drawing.Color;
using DataTable = System.Data.DataTable;
using workbook=Microsoft.Office.Interop.Excel.Workbook;

namespace ESProMeter.Extensions
{
    public static class ExcelUtility
    {


        private const string Excel03ConString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Extended Properties='Excel 8.0;HDR={1}'";
        private const string Excel07ConString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties='Excel 8.0;HDR={1}'";
        /// <summary>
        /// Export
        /// </summary>
        /// <param name="data"></param>
        /// <param name="fileName"></param>
        /// <param name="Range1"></param>
        /// <param name="Range2"></param>
        /// <exception cref="Exception"></exception>
        public static void Export(this DataTable data, string fileName, string Range1, string Range2)
        {
            //A1,B1
            Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
            xlApp.Workbooks.Open(fileName);
            try
            {
                ///insert columns header
                for (int k = 0; k < data.Columns.Count; k++)
                {
                    xlApp.Cells[1, 1 + k].Value = data.Columns[k].ColumnName;
                    xlApp.Cells[1, 1 + k].Borders.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlDash;
                    xlApp.Cells[1, 1 + k].Interior.Color = Color.Yellow;
                    xlApp.Cells[1, 1 + k].Borders.Weight = 2d;
                }
                ///write data
                for (int i = 0; i < data.Rows.Count; i++)
                {
                    for (int k = 0; k < data.Columns.Count; k++)
                    {
                        xlApp.Range[Range1, Range2].Cells[1 + i, 1 + k].Value = data.Rows[i][k];
                        xlApp.Range[Range1, Range2].Cells[1 + i, 1 + k].Borders.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
                        xlApp.Range[Range1, Range2].Cells[1 + i, 1 + k].Borders.Weight = 2d;
                    }

                }
                xlApp.Columns.AutoFit();
                xlApp.Visible = true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                releaseObject(xlApp);
            }

        }
        public static void Export(this DataTable data, string fileName)
        {
            Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
            xlApp.Workbooks.Open(fileName);
            try
            {
                //create columns header
                for (int k = 0; k < data.Columns.Count; k++)
                {
                    xlApp.Cells[1,k+1].Value = data.Columns[k].ColumnName;
                    xlApp.Cells[1, 1 + k].Borders.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlDash;
                    xlApp.Cells[1, 1 + k].Interior.Color = Color.Yellow;
                    xlApp.Cells[1, 1 + k].Borders.Weight = 2d;
                }
                //insert data to excel
                for (int i = 0; i < data.Rows.Count; i++)
                {
                    for (int k = 0; k < data.Columns.Count; k++)
                    {
                        xlApp.Cells[2 + i, 1 + k].Value = data.Rows[i][k];
                        xlApp.Cells[2 + i, 1 + k].Borders.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
                        xlApp.Cells[2 + i, 1 + k].Borders.Weight = 2d;
                    }

                }
                xlApp.Columns.AutoFit();
                xlApp.Visible = true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                releaseObject(xlApp);
            }

        }
        public static void Export(this DataTable data, string fileName,int row=1,int col=1)
        {
            Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
            xlApp.Workbooks.Open(fileName);
            try
            {
                //create columns header
                for (int k = 0; k < data.Columns.Count; k++)
                {
                    xlApp.Cells[row, col + 1 + k ].Value = data.Columns[k].ColumnName;
                    xlApp.Cells[row, col + 1 + k].Borders.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlDash;
                    xlApp.Cells[row, col + 1 + k].Interior.Color = Color.Yellow;
                    xlApp.Cells[row, col + 1 + k].Borders.Weight = 2d;
                }
                //insert data to excel
                for (int i = 0; i < data.Rows.Count; i++)
                {
                    for (int k = 0; k < data.Columns.Count; k++)
                    {
                        xlApp.Cells[row + 1 + i,col + 1 + k].Value = data.Rows[i][k];
                        xlApp.Cells[row + 1 + i,col + 1 + k].Borders.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
                        xlApp.Cells[row + 1 + i,col + 1 + k].Borders.Weight = 2d;
                    }

                }
                xlApp.Columns.AutoFit();
                xlApp.Visible = true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                releaseObject(xlApp);
            }

        }
        public static void Exprot(this DataTable data, string fileName,int row)
        {
            //Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
            //xlApp.Workbooks.Open(fileName);
            try
            {
                XLWorkbook wb = new XLWorkbook();
                wb.Range("A10");
                wb.Worksheets.Add(data, "Sheet1");
                wb.SaveAs(fileName);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
               // releaseObject(xlApp);
            }

        }
        private static void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                throw new Exception("Exception Occured while releasing object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }
    
        /// <summary>
        /// Import
        /// </summary>
        /// <param name="filePath"></param>
        public static void Import(string filePath)
        {
 
            string extension = Path.GetExtension(filePath);
            string conString = "";
            string sheetName = "";
            switch (extension)
            {
                case ".xls":
                    conString = string.Format(Excel03ConString, filePath, "YES");
                    break;
                case ".xlsx":
                    conString = string.Format(Excel07ConString, filePath, "YES");
                    break;
            }
            using (OleDbConnection con = new OleDbConnection(conString))
            {
                using (OleDbCommand cmd = new OleDbCommand())
                {
                    cmd.Connection = con;
                    con.Open();
                    DataTable dt = con.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                    sheetName = dt.Rows[0]["Table_Name"].ToString();
                    con.Close();
                }
            }
            using (OleDbConnection con = new OleDbConnection(conString))
            {
                using (OleDbCommand cmd = new OleDbCommand())
                {
                    OleDbDataAdapter oda = new OleDbDataAdapter();
                    cmd.CommandText = "SELECT * FROM [" + sheetName + "]";
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = con;
                    con.Open();
                    oda.SelectCommand = cmd;
                    DataTable dt = new DataTable();
                    oda.Fill(dt);
                    con.Close();
                    //dgvCustomer.DataSource = dt;
                }
            }
        }
        private static void InsertRecord(string table,DataTable data)
        {
           // DataTable dt = new DataTable();
            //dt.Columns.AddRange(new DataColumn[3] {
            //    new DataColumn("CustomerId",typeof(int)),
            //    new DataColumn("Name",typeof(string)),
            //    new DataColumn("Country",typeof(string))
            //});
            //foreach (DataGridViewRow rowin dgvCustomer.Rows)
            //{
            //    int customerId = Convert.ToInt32(row.Cells[0].Value);
            //    string name = row.Cells[1].Value.ToString();
            //    string country = row.Cells[2].Value.ToString();
            //    dt.Rows.Add(customerId, name, country);
            //}
            if (data.Rows.Count > 0)
            {
                
                using (SqlConnection con = new SqlConnection(ConnectionService.ConnectionString()))
                {
                    using (SqlBulkCopy sqlBulkCopy = new SqlBulkCopy(con))
                    {
                        sqlBulkCopy.DestinationTableName = $"dbo.{table}";
                        //sqlBulkCopy.ColumnMappings.Add("CustomerId", "CustomerId");
                        //sqlBulkCopy.ColumnMappings.Add("Name", "Name");
                        //sqlBulkCopy.ColumnMappings.Add("Country", "Country");
                        con.Open();
                        sqlBulkCopy.WriteToServer(data);
                        con.Close();
                    }
                }
            }
        }

    }
}


//public static void Print(data, string fileName, int Rows = 1, int Cols = 1)
//{
//    if (Rows < 1) throw new ArgumentException("Number of Rows must greater than 0.");
//    if (Cols < 1) throw new ArgumentException("Number of Columns must greater than 0.");
//    Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
//    xlApp.Workbooks.Open(fileName);
//    int rows = data.GetLength(0);
//    int cols = data.GetLength(1);
//    try
//    {
//        for (int i = 0; i < rows; i++)
//        {
//            for (int j = 0; j < cols; j++)
//            {
//                xlApp.Cells[Rows + i, j + Cols] = data[j, i];
//            }
//        }
//        xlApp.Columns.AutoFit();
//        xlApp.Visible = true;
//    }
//    catch (Exception ex)
//    {

//        throw ex;
//    }
//    finally
//    {
//        releaseObject(xlApp);
//    }
//}
//public virtual void Print(List<object[]> data, string fileName)
//{
//    Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
//    xlApp.Workbooks.Open(fileName);
//    try
//    {
//        int j = 0;
//        foreach (var item in data)
//        {
//            for (int i = 0; i < item.Length; i++)
//            {
//                xlApp.Range["A6:C6"].Cells[1 + j, 1 + i] = item[i];
//                xlApp.Range["A6:C6"].Cells[1 + j, 1 + i].Borders.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
//                xlApp.Range["A6:C6"].Cells[1 + j, 1 + i].Borders.Weight = 2d;
//            }
//            j++;
//        }
//        xlApp.Columns.AutoFit();
//        xlApp.Visible = true;
//    }
//    catch (Exception ex)
//    {
//        throw ex;
//    }
//    finally
//    {
//        releaseObject(xlApp);
//    }
//}

//public virtual void Print(object[,] data, string fileName, int Rows = 1, int Cols = 1)
//{
//    if (Rows < 1) throw new ArgumentException("Number of Rows must greater than 0.");
//    if (Cols < 1) throw new ArgumentException("Number of Columns must greater than 0.");
//    Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
//    xlApp.Workbooks.Open(fileName);
//    int rows = data.GetLength(0);
//    int cols = data.GetLength(1);
//    try
//    {
//        for (int i = 0; i < rows; i++)
//        {
//            for (int j = 0; j < cols; j++)
//            {
//                xlApp.Cells[Rows + i, j + Cols] = data[j, i];
//            }
//        }
//        xlApp.Columns.AutoFit();
//        xlApp.Visible = true;
//    }
//    catch (Exception ex)
//    {

//        throw ex;
//    }
//    finally
//    {
//        releaseObject(xlApp);
//    }
//}
//public virtual void Print(List<object[]> data, string fileName, int Rows = 1, int Cols = 1)
//{
//    if (Rows < 1) throw new ArgumentException("Number of Rows must greater than 0.");
//    if (Cols < 1) throw new ArgumentException("Number of Columns must greater than 0.");
//    Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
//    xlApp.Workbooks.Open(fileName);
//    try
//    {
//        int j = 0;
//        foreach (var item in data)
//        {
//            for (int i = 0; i < item.Length; i++)
//            {
//                xlApp.Cells[Rows + i, Cols + i].Value = item[i];
//                xlApp.Cells[Rows + i, Cols + i].Borders.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
//                xlApp.Cells[Rows + i, Cols + i].Borders.Weight = 2d;
//            }
//            j++;
//        }
//        xlApp.Columns.AutoFit();
//        xlApp.Visible = true;
//    }
//    catch (Exception ex)
//    {
//        throw ex;
//    }
//    finally
//    {
//        releaseObject(xlApp);
//    }

//}
//public virtual void Print(List<object[]> data, string fileName, string Range1 = "A1", string Range2 = "B1")
//{
//    Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
//    xlApp.Workbooks.Open(fileName);
//    try
//    {
//        int j = 0;
//        foreach (var item in data)
//        {
//            for (int i = 0; i < item.Length; i++)
//            {
//                xlApp.Range[Range1, Range2].Cells[1 + j, 1 + i].Value = item[i];
//                xlApp.Range[Range1, Range2].Cells[1 + j, 1 + i].Borders.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
//                xlApp.Range[Range1, Range2].Cells[1 + j, 1 + i].Borders.Weight = 2d;
//            }
//            j++;
//        }
//        xlApp.Columns.AutoFit();
//        xlApp.Visible = true;
//    }
//    catch (Exception ex)
//    {
//        throw ex;
//    }
//    finally
//    {
//        releaseObject(xlApp);
//    }

//}


//public void openExcelTemplateFromResources()
//{
//    string tempPath = System.IO.Path.GetTempFileName();

//    System.IO.File.WriteAllBytes(tempPath, Properties.Resources.excelResource);

//    Excel.Application excelApplication = new Excel.Application();
//    Excel._Workbook excelWorkbook;
//    excelWorkbook = excelApplication.Workbooks.Open(tempPath)

//    excelApplication.Visible = true; // at this point its up to the user to save the file
//}