﻿using System;
using System.Data;
using System.Windows.Forms;

namespace ESProMeter.Extensions
{
    public static class ControlExtension
    {
        public static T GetVale<T>(this TextBox txt) where T : IConvertible
        {

            try
            {
                var result = string.IsNullOrEmpty(txt.Text) ? "0" : txt.Text;
                return (T)Convert.ChangeType(result, typeof(T));
            }
            catch
            {
                return default(T);
            }

        }
        public static T AsNumber<T>(this TextBox txt) where T : IConvertible
        {
            
            try
            {
                var result = string.IsNullOrEmpty(txt.Text.Trim()) ? "0" : txt.Text;
                return (T)Convert.ChangeType(result, typeof(T));
            }
            catch
            {
                return default(T);
            }
           
        }
        public static T AsNumber<T>(this Label txt) where T : IConvertible
        {
            try
            {
                var result = string.IsNullOrEmpty(txt.Text) ? "0" : txt.Text;
                return (T)Convert.ChangeType(result, typeof(T));
            }
            catch
            {
                return default(T);
            }
        }
        public static T AsNumber<T>(this DataGridView grid, int colIndex) where T : IConvertible
        {
            try
            {
                var result = grid.Rows[grid.CurrentCell.RowIndex].Cells[colIndex].Value ?? 0;
                return (T)Convert.ChangeType(result, typeof(T));
            }
            catch
            {
                return default(T);
            }
          
        }
        public static bool AsBealean(this DataGridView grid, int colIndex)
        {
            try { 
                var result = grid.Rows[grid.CurrentCell.RowIndex].Cells[colIndex].Value ?? 0;
                return (bool)Convert.ChangeType(result, typeof(bool));
            }
            catch
            {
                return default(bool);
            }
        }
        public static bool AsBealean(this DataGridView grid, string colName)
        {
            
            try
            {
                var result = grid.Rows[grid.CurrentCell.RowIndex].Cells[colName].Value ?? 0;
                return (bool)Convert.ChangeType(result, typeof(bool));
            }
            catch
            {
                return default(bool);
            }
        }
        public static bool AsBealean(this DataGridView grid,int rowIndex, string colName)
        {

            try
            {
                var result = grid.Rows[rowIndex].Cells[colName].Value ?? 0;
                return (bool)Convert.ChangeType(result, typeof(bool));
            }
            catch
            {
                return default(bool);
            }
        }
        public static T AsNumber<T>(this DataGridView grid, string colName) where T : IConvertible
        {
            try
            {
                var result = grid.Rows[grid.CurrentCell.RowIndex].Cells[colName].Value ?? 0;
                return (T)Convert.ChangeType(result, typeof(T));
            }
            catch
            {
                return default(T);
            }
        }
        public static T AsNumber<T>(this DataGridView grid,int rowIndex, string colName) where T : IConvertible
        {
            try
            {
                var result = grid.Rows[rowIndex].Cells[colName].Value ?? 0;
                return (T)Convert.ChangeType(result, typeof(T));
            }
            catch
            {
                return default(T);
            }
        }
        public static T AsValue<T>(this DataGridView grid,int rowIndex, string colName) where T : IConvertible
        {
            try
            {
                var result = grid.Rows[rowIndex].Cells[colName].Value ?? 0;
                return (T)Convert.ChangeType(result, typeof(T));
            }
            catch
            {
                return default(T);
            }
        }
        public static object GetValue(this DataGridView grid, int rowIndex, string colName)
        {
            try
            {
                return grid.Rows[rowIndex].Cells[colName].Value;
            }
            catch
            {
                return default(object);
            }
        }
        public static T GetValue<T>(this DataGridView grid, int rowIndex, string colName)
        {
            try
            {
                return (T)Convert.ChangeType(grid.Rows[rowIndex].Cells[colName].Value, typeof(T));
            }
            catch
            {
                return default(T);
            }
        }
        public static T AsNumber<T>(this ComboBox txt,bool selected=false) where T : IConvertible
        {
            if (selected)
            {
                if(txt.SelectedValue==null)
                {
                    return default(T);
                }
                else
                {
                    return (T)Convert.ChangeType(txt.SelectedValue, typeof(T));
                }
                
            }
            else
            {
                if (string.IsNullOrEmpty(txt.Text))
                {
                    return default(T);
                }
                else
                {
                    return (T)Convert.ChangeType(txt.Text, typeof(T));
                }
                
            }
           
        }
        
        

    }
    
}
