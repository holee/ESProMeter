using System;
using System.Data;
using System.Drawing;
using System.Threading.Tasks;
namespace ESProMeter.Extensions
{
    public static class ExcelUtility
    {
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
        public static void Print(this DataTable data, string fileName, string Range1, string Range2)
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
        public static void Print(this DataTable data, string fileName)
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
        public static void Print(this DataTable data, string fileName,int row)
        {
            Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
            xlApp.Workbooks.Open(fileName);
            try
            {
                //create columns header
                for (int k = 0; k < data.Columns.Count; k++)
                {
                    xlApp.Cells[row, row + k].Value = data.Columns[k].ColumnName;
                    xlApp.Cells[row, row + k].Borders.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlDash;
                    xlApp.Cells[row, row + k].Interior.Color = Color.Yellow;
                    xlApp.Cells[row, row + k].Borders.Weight = 2d;
                }
                //insert data to excel
                for (int i = 0; i < data.Rows.Count; i++)
                {
                    for (int k = 0; k < data.Columns.Count; k++)
                    {
                        xlApp.Cells[row + i, row + k].Value = data.Rows[i][k];
                        xlApp.Cells[row + i, row + k].Borders.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
                        xlApp.Cells[row + i, row + k].Borders.Weight = 2d;
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
    }
}


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