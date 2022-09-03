using ESProMeter.Extensions;
using ESProMeter.Services;
using System;
using System.Data;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ESProMeter.Views.Item
{
    public partial class ListImportFrm : Form
    {
        public ListImportFrm()
        {
            InitializeComponent();
        }

        private async void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Title = "Browse excel file to export";
            file.DefaultExt = "xlsx";
            file.Filter = "Excel 2007(*.xlsx)|*.xlsx|Excel 2003(*.xls)|*.xls";
            this.pictureBox1.Visible = true;
            if (file.ShowDialog() == DialogResult.OK)
            {
                
                textSearch.SetText(file.FileName);
                var dt = ExcelUtility.Import(textSearch.Text);
                dt.UseDataTableAsGridView(this.dataItemList);
                double waited = dt.Rows.Count / 25;
                await Task.Delay((int)Math.Ceiling(waited));
                this.pictureBox1.Visible = false;
            }
        }

        private void dataItemList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (dataItemList.Columns[e.ColumnIndex].Name == "Cost")
                {
                    if (e.Value != null)
                    {
                        e.CellStyle.Format = "N2";
                        e.CellStyle.ForeColor = Color.Red;
                    }
                }
            }
        }

        private void ButtonCloseClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            btnClose.Enabled = false;
            btnOpen.Enabled = false;
            this.pictureBox1.Visible = true;
            var dt=ToTable(this.dataItemList);
            await Task.Run(() =>
            {
                AppService.GetItemInstance.ItemImport(dt);
            });
            await Task.Delay(2000);
            this.pictureBox1.Visible = false;
            btnClose.Enabled = true;
            btnOpen.Enabled = true;
        }
        private DataTable ToTable(DataGridView view)
        {
            DataTable table = new DataTable();
            table.Columns.Add("itemName", typeof(string));
            table.Columns.Add("itemDesc", typeof(string));
            table.Columns.Add("itemType", typeof(string));
            table.Columns.Add("uomID", typeof(long));
            table.Columns.Add("cost", typeof(decimal));
            foreach (DataGridViewRow row in view.Rows)
            {
                if (row.IsNewRow) break;
                DataRow dRow = table.NewRow();
                dRow["itemName"] = row.Cells["itemName"].Value; ;
                dRow["itemType"] = row.Cells["itemType"].Value;
                dRow["uomID"] = row.Cells["uomID"].Value;
                dRow["cost"] = row.Cells["cost"].Value;
                dRow["itemDesc"] = row.Cells["itemDesc"].Value;
                table.Rows.Add(dRow);
            }
            return table;
        }

        private void dataItemList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
