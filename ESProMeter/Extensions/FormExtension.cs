using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace ESProMeter.Extensions
{
    public static class FormExtension
    {

        private static bool HasChildFormOpen(Form form,Form mainFrm)
        {
            if (mainFrm.MdiChildren.Any(frm => frm.Name == form.Name))
            {
                return true;
            }
            return false;
        }
        public static void OpenChildForm(this Form form,Form child,Form mainFrm)
        { 
            if (!HasChildFormOpen(child, mainFrm))
            {
                child.MdiParent = mainFrm;
                child.StartPosition = FormStartPosition.CenterParent;
                child.Show();
            }
            else
            {
                return;
            }

        }

        public static void SetDoubleBuffer(Control dtg, bool DoubleBuffered)
        {
            typeof(Control).InvokeMember("DoubleBuffered",
              BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.SetProperty,
              null, dtg, new object[] { DoubleBuffered });
        }

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
            return gRow.Cells[colName].Value??default(object);
        }
        public static T GetValue<T>(this DataGridViewRow gRow, string colName) where T:IConvertible
        {
            if (gRow.Cells[colName]?.Value == null)
            {
                return default(T);
            }
            return (T)Convert.ChangeType(gRow.Cells[colName]?.Value, typeof(T));
        }
        public static string GetString(this DataGridViewRow gRow, string colName)
        {
            if (gRow.Cells[colName].Value == null)
            {
                return String.Empty;
            }
            return gRow.Cells[colName].Value.ToString();
        }
        public static bool GetBoolean(this DataGridViewRow gRow, string colName)
        {
            if (gRow.Cells[colName].Value == null)
            {
                return false;
            }
            return (bool)gRow.Cells[colName].Value;
        }
        
        public static void UseDataTableAsGridView(this DataTable source, DataGridView grid)
        {
            ((DataTable)grid.DataSource)?.Rows.Clear();
            if (source != null)
            {
                if (source.Rows.Count > 0)
                {
                    grid.DataSource = source;
                    //grid.DataMember
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
        public static string AsString(this DateTimePicker picker,string formater="MM/dd/yyyy")
        {
            return picker.Value.ToString(formater);
        }

        /// <summary>
        /// Format
        /// </summary>
        /// <param name="txt"></param>
        /// <param name="rowIndex"></param>
        /// <param name="colName"></param>
        /// <param name="value"></param>
        /// <param name="format"></param>
        public static void NumberFormat(this DataGridView txt, int rowIndex, string colName, object value, string format = "N2")
        {
            if (rowIndex >= 0)
            {
                if (value == null)
                {
                    txt.SetText(rowIndex, colName, Utility.NumberString(0, format));
                }
                else
                {
                    txt.SetText(rowIndex, colName, Utility.NumberString(value, format));
                }
            }
        }
        public static void NumberFormat(this TextBox txt, object value, string format = "N2")
        {

            if (value == null)
            {
                txt.SetText(Utility.NumberString(0, format));
            }
            else
            {
                txt.SetText(Utility.NumberString(value, format));
            }
        }
        public static void NumberFormat(this Label txt, object value, string format = "N2")
        {

            if (value == null)
            {
                txt.SetText(Utility.NumberString(0, format));
            }
            else
            {
                txt.SetText(Utility.NumberString(value, format));
            }
        }
    }
}
