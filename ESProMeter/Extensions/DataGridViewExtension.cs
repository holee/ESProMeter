using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection;
using System.Windows.Forms;

namespace ESProMeter.Extensions
{
    public static class DataGridViewExtension
    {
        public static List<object> GetValues(this DataGridViewRow row,params string[] celllNames)
        {
            if (row.Cells.Count == 0) return default;
            List<object> obj=new List<object> ();
            foreach (DataGridViewCell cell in row.Cells)
            {
                foreach (var item in celllNames)
                {
                    if (cell.DataGridView.Columns[cell.ColumnIndex].Name.ToLower() == item.ToLower())
                    {
                        obj.Add(cell.Value);
                    }
                    else continue;
                }
                
            }
            return obj;
        }
        public static List<T> SelectedValues<T>(this DataGridView gridview,int rowIndex = 0)
        {
            var list = new List<T>();

            foreach (DataGridViewCell item in gridview.SelectedRows[rowIndex].Cells) 
            {
                list.Add((T)item.Value);
            }

            return list;
        }
        public static T SelectedValue<T>(this DataGridView gridview,string cellName,int rowIndex = 0)
        {
            return (T)gridview.SelectedRows[rowIndex].Cells[cellName].Value;
        }
        public static T SelectedValue<T>(this DataGridView gridview, int colIndex, int rowIndex = 0)
        {
            return (T)gridview.SelectedRows[rowIndex].Cells[colIndex].Value;
        }
        public static DataTable ToTable(this DataGridView view)
        {
            DataTable table = new DataTable();
            foreach (DataGridViewColumn column in view.Columns)
            {
                table.Columns.Add(column.Name);
            }
            foreach (DataGridViewRow row in view.Rows)
            {
                DataRow dRow = table.NewRow();
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if(cell.Value != null)
                    {
                        dRow[cell.ColumnIndex] = cell?.Value;
                    }
                    else
                    {
                        dRow[cell.ColumnIndex] = null;
                    }
                    
                }
            }

            return table;
        }
        public static List<T> AsListOf<T>(this DataGridView grid) where T : class 
        {
            List<T> list = new List<T>();
            foreach (DataGridViewRow row in grid.Rows)
            {
                list.Add(GetItem<T>(row));
            }
            return list;
        }
        public static T AsTypeof<T>(DataGridViewRow row)
        {
            Type temp = typeof(T);
            T obj = Activator.CreateInstance<T>();
            foreach (DataGridViewCell item in row.Cells)
            {
                foreach (PropertyInfo prop in temp.GetProperties())
                {
                    if (prop.Name.ToLower() == item.OwningColumn.DataPropertyName.ToLower())
                        prop.SetValue(obj, item.Value ?? null, null);
                    else continue;
                }
            }

            return obj;
        }
        private static T GetItem<T>(DataGridViewRow row)
        {
            Type temp = typeof(T);
            T obj = Activator.CreateInstance<T>();
            foreach (DataGridViewCell item in row.Cells)
            {
                foreach (PropertyInfo prop in temp.GetProperties())
                {
                    if (prop.Name.ToLower() == item.OwningColumn.DataPropertyName.ToLower())
                        prop.SetValue(obj, item.Value ?? null, null);
                    else continue;
                }
            }
            
            return obj;
        }
        public static DataTable ToTable(this DataGridView view,params string[] columns)
        {
            DataTable table = new DataTable();
            foreach (string column in columns)
            {
                table.Columns.Add(column);
            }
            foreach (DataGridViewRow row in view.Rows)
            {
                DataRow dRow = table.NewRow();
                foreach (var item in columns)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (view.Columns[cell.ColumnIndex].Name == item)
                        {
                            dRow[item] = row.Cells[item].Value;
                        }
                        else
                        {
                            continue;
                        }
                    }
                   
                }
                table.Rows.Add(dRow);
               
            }

            return table;
        }
    
    
    }
}

//foreach (DataGridViewCell cell in row.Cells)
//{
//    if (cell.Value != null)
//    {
//        dRow[cell.ColumnIndex] = cell?.Value;
//    }
//    else
//    {
//        dRow[cell.ColumnIndex] = null;
//    }


//}