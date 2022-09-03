using ESProMeter.Extensions;
using System;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using Application = Microsoft.Office.Interop.Excel.Application;
using System.Runtime.InteropServices;
using Microsoft.Win32;
using System.IO;
using ESProMeter.Services;
using DocumentFormat.OpenXml.Office2021.DocumentTasks;
using ClosedXML.Excel;
using System.Diagnostics;

namespace ESProMeter.Views.Item 
{
    public partial class ItemExportFrm : Form
    {
        public ItemExportFrm()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.SaveFileDialog file = new System.Windows.Forms.SaveFileDialog();
            file.Title = "Browse excel file to export";
            file.DefaultExt = "xlsx";
            file.Filter = "Excel 2003(*.xls)|*.xls|Excel 2007(*.xlsx)|*.xlsx";
            if (file.ShowDialog() == DialogResult.OK)
            {
                textBox1.SetText(file.FileName);
            }
        }

        private async void materialButton2_Click(object sender, EventArgs e)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            this.pictureBox1.Visible = true;
            await System.Threading.Tasks.Task.Run(() =>
            {
                Application excelObj = new Microsoft.Office.Interop.Excel.Application();
                excelObj.Workbooks.Add(Type.Missing);
                Workbook wbook = excelObj.ActiveWorkbook;
                wbook.SaveCopyAs(textBox1.Text);
                wbook.Close();
            });
            await System.Threading.Tasks.Task.Run(() =>
            {
                AppService.SqlGetInstance.UseProcedure("ITEM_sp_SELECT_Export")
                           .SelectAsTable<dynamic>(null, out var table);
                table.Export(textBox1.Text,1,1);
            });
            this.pictureBox1.Visible = false;

            sw.Stop();

            MessageBox.Show($"Item was exported Completely.","Export");
            //this.Close();

        }
    }
}
