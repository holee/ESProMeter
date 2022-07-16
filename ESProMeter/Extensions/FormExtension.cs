using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ESProMeter.Extensions
{
    public static class FormExtension
    {

        public static Dictionary<string,object> ErrorList=new Dictionary<string, object>();
        public static void ClearForm(this Form form,params Control[] ctrls)
        {
            foreach (Control item in ctrls)
            {
                if(item is TextBox)
                {
                    ((TextBox)item).Clear();
                }
            }
        }
        public static void Disable(this Form form,params Control[] ctrls)
        {
            foreach (var ctrl in ctrls)
            {
                ctrl.Enabled = false;
            }
        }
        public static void Able(this Form form, params Control[] ctrls)
        {
            foreach (var ctrl in ctrls)
            {
                ctrl.Enabled = true;
            }
        }
        public static bool IsValid(this Form form)
        {
            int errorCount = 0;
            foreach (Control control in form.Controls)
            {
                if(control is TextBox)
                {
                    if (((TextBox)control).Text.Trim().Length==0)
                    {
                        errorCount++;
                    }
                }
                if (control is ComboBox)
                {
                    if (((ComboBox)control).Text.Trim().Length > 0 || ((ComboBox)control).SelectedValue==null)
                    {
                        errorCount++;
                    }
                }
                if (control is MaskedTextBox)
                {
                    if (((MaskedTextBox)control).Text.Trim().Length == 0)
                    {
                        errorCount++;
                    }
                }
            }

            return errorCount <= 0;
        }
        public static bool IsValid(this Form form,params Control[] ctrls)
        {
            int errorCount = 0;
            ErrorList.Clear();
            foreach (Control control in ctrls)
            {
                if (control is TextBox)
                {
                    if (((TextBox)control).Text.Trim().Length == 0)
                    {
                        ErrorList.Add(((TextBox)control).Name,"Please enter required field.");
                        errorCount++;
                    }
                }
                if (control is Label)
                {
                    if (((Label)control).Text.Trim().Length == 0)
                    {
                        ErrorList.Add(((TextBox)control).Name, "Please enter required field.");
                        errorCount++;
                    }
                }
                if (control is RichTextBox)
                {
                    if (((RichTextBox)control).Text.Trim().Length == 0)
                    {
                        ErrorList.Add(((TextBox)control).Name, "Please enter required field.");
                        errorCount++;
                    }
                }
                if (control is ComboBox)
                {
                    if (((ComboBox)control).Text.Trim().Length == 0 || ((ComboBox)control).SelectedValue == null)
                    {
                        ErrorList.Add(((ComboBox)control).Name, "Please enter required field.");
                        errorCount++;
                    }
                }
                if (control is MaskedTextBox)
                {
                    if (((MaskedTextBox)control).Text.Trim().Length == 0)
                    {
                        ErrorList.Add(((MaskedTextBox)control).Name, "Please enter required field.");
                        errorCount++;
                    }
                }
            }
            return errorCount == 0;
        }
        public static T AsControl<T>(this Form form,string key) where T: Control
        {
            return  form.Controls.Find(key, true).OfType<T>().FirstOrDefault();
        }
        public static TextBox AsTextBox(this Form form,string key)
        {
            return form.Controls.Find(key,true).OfType<TextBox>().FirstOrDefault();
        }
        public static ComboBox AsCombobox(this Form form, string key)
        {
            return form.Controls.Find(key, true).OfType<ComboBox>().FirstOrDefault();
        }
        public static CheckBox[] AsCheckedBoxes(this Form form, string key)
        {
            return form.Controls.Find(key, true).OfType<CheckBox>().ToArray();
        }
        public static void Reset(this Form form,params Control[] controls)
        {
            foreach (Control control in controls)
            {
                if (!string.IsNullOrEmpty(control.Text))
                {
                    control.Text = string.Empty;
                }
            }
        }
        public static DataGridView AsDataGrid(this Form form, string key)
        {
            return form.Controls.Find(key, true).OfType<DataGridView>().FirstOrDefault();
        }
        public static long AsLong(this Form form,string key,int row,int col)
        {
            var grid= form.Controls.Find(key, true).OfType<DataGridView>().FirstOrDefault();
            var result=grid[col, row].Value.ToString();
            if(long.TryParse(result,out long id))
            {
                return id;
            }
            return default;
        }
        public static void AsCombobox(this DataTable table,ComboBox ctrl, string displayMember, string valueMember)
        {
            ctrl.DataSource = null;
            ctrl.DataSource = table;
            ctrl.DisplayMember = displayMember;
            ctrl.ValueMember = valueMember; 
        }
        public static void AsDataGrid(this DataTable table, DataGridView ctrl)
        {
            if (ctrl.Rows.Count > 0)
            {
                ((DataTable)ctrl.DataSource).Rows.Clear();
            }
            ctrl.DataSource = table;
        }
        public static void SetText(this ComboBox txt, DataRow row, string colName)
        {
            if (!row.IsNull(colName))
                txt.Text = row[colName].ToString();
            else
                txt.Text = string.Empty;
        }
        public static void SetText(this ComboBox txt,object value)
        {
            txt.Text = value==null?"":value.ToString();
        }
        public static void SetText(this DataGridView txt,string colName,object value)
        {
            if (txt.Rows.Count > 0)
            {
                var index = txt.CurrentCell.RowIndex;
                txt.Rows[index].Cells[colName].Value = value;
            }
        }
        public static void SetText(this DataGridView txt,int rowIndex, string colName, object value)
        {
            if (txt.Rows.Count > 0)
            {
                txt.Rows[rowIndex].Cells[colName].Value = value;
            }
        } 
        public static void SetTextFormat<T>(this DataGridView txt, int rowIndex, string colName,string format, T value) where T:IFormattable
        {
            if (txt.Rows.Count > 0)
            {
                if(value == null)
                {
                    txt.Rows[rowIndex].Cells[colName].Value = "";
                }
                else
                {
                    txt.Rows[rowIndex].Cells[colName].Value = string.Format(format,value);
                }
            }
        }
        public static void SetText(this DataGridView txt, int colIndex, object value)
        {
            if (txt.Rows.Count > 0)
            {
                var index = txt.CurrentCell.RowIndex;
                txt.Rows[index].Cells[colIndex].Value = value;
            }
        }
        public static void SetText(this TextBox txt, DataRow row, string colName)
        {
            if (!row.IsNull(colName))
                txt.Text = row[colName].ToString();
            else
                txt.Text = string.Empty;
        }
        public static void SetText(this TextBox txt,object value)
        {
              txt.Text = value!=null?value.ToString():string.Empty;
        }
        public static void SetText(this DataRow row, string colName,Control ctrl)
        {
            if (!row.IsNull(colName))
            {
                if (ctrl is TextBox)
                {
                    ((TextBox)ctrl).Text = row[colName].ToString();
                }
                if (ctrl is Label)
                {
                    ((Label)ctrl).Text = row[colName].ToString();
                }
                if (ctrl is RichTextBox)
                {
                    ((RichTextBox)ctrl).Text = row[colName].ToString();
                }
                if (ctrl is ComboBox)
                {
                    ((ComboBox)ctrl).Text = row[colName].ToString();
                }
                if (ctrl is DateTimePicker)
                {
                    if(DateTime.TryParse(row[colName].ToString(),out DateTime result))
                    {
                        ((DateTimePicker)ctrl).Value = result;
                    }
                    else
                    {
                        ((DateTimePicker)ctrl).Value = DateTime.Now;
                    }
                   
                }
            }
            else
                return;
        }
        public static void SetText(this Label txt, DataRow row, string colName)
        {
            if (!row.IsNull(colName))
                txt.Text = row[colName].ToString();
            else
                txt.Text = string.Empty;
        }
        public static void SetText(this Label txt,object value)
        {
            txt.Text = value.ToString() ?? "";
        }
        public static void SetValue(this Label txt, object value)
        {
            txt.Text=value==null?string.Empty:value.ToString();
        }
        public static void SetValue(this DateTimePicker picker, DataRow row, string colName)
        {
            if (!row.IsNull(colName))
                if(DateTime.TryParse(row[colName].ToString(),out DateTime result))
                {
                    picker.Value = result;
                }
                else
                {
                    picker.Value = DateTime.Now;
                }
                 
            else
                picker.Value = DateTime.Now;
        }
        public static void SetValue(this DataRow row, string colName, Control ctrl)
        {
            if (!row.IsNull(colName)) {
                if (ctrl is DateTimePicker)
                {
                    if (DateTime.TryParse(row[colName].ToString(), out DateTime result))
                    {
                        ((DateTimePicker)ctrl).Value = result;
                    }
                    else
                    {
                        ((DateTimePicker)ctrl).Value = DateTime.Now;
                    }
                }
                if (ctrl is ComboBox)
                {
                    ((ComboBox)ctrl).SelectedValue = row[colName];
                } 
            }
        }
        public static void SetValue(this DataRow row, string colName,DataGridViewCell cell)
        {
            if (row != null)
            {
                if (!row.IsNull(colName))
                {
                    cell.Value = row[colName];
                }
                else
                {
                    cell.Value = null;
                }
            }
        }
        public static void SetValue(this DataGridViewRow gRow, string colName,object value=null)
        {
            gRow.Cells[colName].Value = value ?? null;
        }
        public static object GetValue(this DataGridViewRow gRow, string colName)
        {
            return gRow.Cells[colName].Value??null;
        }
        public static T? GetValue<T>(this DataGridViewRow gRow, string colName) where T:IConvertible
        {
            if (gRow.Cells[colName].Value == null)
            {
                return default(T);
            }
            return (T)Convert.ChangeType(gRow.Cells[colName].Value, typeof(T));
        }
        public static void SetChecked(this CheckBox txt, DataRow row, string colName)
        {
            if (!row.IsNull(colName))
                if(bool.TryParse(row[colName].ToString(), out bool result))
                {
                    txt.Checked = result;
                }
                else
                {
                    txt.Checked = false;
                }
            
            else
                txt.Checked = false;
        }
        public static void SetChecked(this DataRow row, string colName,CheckBox txt)
        {
            if (!row.IsNull(colName))
            {
                if (row[colName].ToString()=="0")
                {
                    txt.Checked = false;
                }
                else
                {
                    txt.Checked = true;
                }
            }
            else
                txt.Checked = false;
        }
        public static void SetChecked(this DataRow row, string colName, RadioButton txt)
        {
            if (!row.IsNull(colName))
            {
                if (row[colName].ToString() == "0")
                {
                    txt.Checked = false;
                }
                else
                {
                    txt.Checked = true;
                }
            }
            else
                txt.Checked = false;
        }
        public static void SetChecked(this RadioButton txt, DataRow row, string colName)
        {
            if (!row.IsNull(colName))
                if (bool.TryParse(row[colName].ToString(), out bool result))
                {
                    txt.Checked = result;
                }
                else
                {
                    txt.Checked = false;
                }
            else
                txt.Checked = false;
        }
        public static void UseDataTableAsGridView<T>(this List<T> source,DataGridView dataGrid) where T:class
        {
            if (source.Count > 0)
            {
                if (dataGrid.Rows.Count > 0)
                {
                    ((List<T>)dataGrid.DataSource).Clear();
                }
                dataGrid.DataSource = source;
            }
        }
        public static void UseDataTableAsGridView(this DataTable source, DataGridView grid)
        {
            if (source != null)
            {
                if (source.Rows.Count > 0)
                {
                    if (grid.Rows.Count > 0)
                    {
                        ((DataTable)grid.DataSource).Rows.Clear();
                    }
                    grid.DataSource = source;
                }
            }
           
        }
        public static void UsePlainDataToGridView(this DataTable source, DataGridView grid) 
        {
            if (grid.Rows.Count > 0)
            {
                grid.Rows.Clear();
            }
            if (source.Rows.Count > 0)
            {
                foreach (DataRow rows in source.Rows)
                {
                    grid.Rows.Add(rows.ItemArray);
                }
            }
        }
        public static void ErrorMessage(this Label label,string key,string message=null)
        {
            if (ErrorList.ContainsKey(key))
            {
                label.Text = message??ErrorList[key].ToString();
                label.Visible=true;
                ErrorList.Remove(key);
            }
            else
            {
                label.Text = String.Empty;
                label.Visible=false;
            }
        }
    
    }
}
