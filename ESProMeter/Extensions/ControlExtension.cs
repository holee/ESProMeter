using System;
using System.Data;
using System.Windows.Forms;

namespace ESProMeter.Extensions
{
    public static class ControlExtension
    {
        public static T? GetVale<T>(this TextBox txt) where T : IConvertible
        {

            try
            {
                var result = string.IsNullOrEmpty(txt.Text) ? "0" : txt.Text;
                return (T)Convert.ChangeType(result, typeof(T));
            }
            catch
            {
                return default(T?);
            }

        }
        public static T? AsNumber<T>(this TextBox txt) where T : IConvertible
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
        public static T? AsNumber<T>(this Label txt) where T : IConvertible
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
        public static T? AsNumber<T>(this DataGridView grid, int colIndex) where T : IConvertible
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
            try
            {
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
        public static bool AsBealean(this DataGridView grid, int rowIndex, string colName)
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
        public static T? AsNumber<T>(this DataGridView grid, string colName) where T : IConvertible
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
        public static T? AsNumber<T>(this DataGridView grid, int rowIndex, string colName) where T : IConvertible
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
        public static T? AsValue<T>(this DataGridView grid, int rowIndex, string colName) where T : IConvertible
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
        public static T? GetValue<T>(this DataGridView grid, int rowIndex, string colName)
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

        public static T? GetValue<T>(this ComboBox grid)
        {
            try
            {
                return (T)Convert.ChangeType(grid.SelectedValue, typeof(T));
            }
            catch
            {
                return default(T);
            }
        }
        public static T? AsNumber<T>(this ComboBox grid) where T : IConvertible
        {
            try
            {
                var value=grid.SelectedValue??grid.Text;
                return (T)Convert.ChangeType(value, typeof(T));
            }
            catch
            {
                return default(T);
            }
        }
        public static string GetText(this ComboBox grid)
        {
            return grid.SelectedItem.ToString() ?? "";
        }
        public static T? AsNumber<T>(this ComboBox combo,bool isValueFromSelectItem) where T : IConvertible
        {
            if (combo.SelectedValue == null || combo.Text.Length==0)
            {
                return default(T);
            }
            else
            {
                if (isValueFromSelectItem)
                {
                    return (T)Convert.ChangeType(combo.SelectedValue, typeof(T));
                }
                return (T)Convert.ChangeType(combo.SelectedItem, typeof(T));
            }

        }


    }

}
