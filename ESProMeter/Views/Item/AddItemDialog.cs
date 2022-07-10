using ESProMeter.Controllers;
using ESProMeter.Extensions;
using ESProMeter.Views.UnitOfMeasures;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ESProMeter.Views.Items
{
    public partial class AddItemDialog : Form
    {
        public List<long> ItemIdList = new List<long>();
        public event EventHandler GridButtonClick;

        public virtual void OnGridButtonClick(DataGridViewCellEventArgs e)
        {
            EventHandler handler = GridButtonClick;
            if(handler != null)
            {
                handler(this,e);
            }

        }
        public AddItemDialog(string type="Labor")
        {
            InitializeComponent();
            this.GetItemTypes(dataGridView1, type,"ItemID","Name","Abbreviation", "UOMID", "Price");
        }
        private void btnUomCreate_Click(object sender, EventArgs e)
        {
            Form form = new AddUoMFrm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                this.ShowUom();
            };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridViewCellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Column6")
            {
                //ItemID = dataGridView1.GetValue<long>(e.RowIndex, "Column1");
                OnGridButtonClick(e);
            }
        }

        private void buttonCloseClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void materialButton3_Click(object sender, EventArgs e)
        {
            ItemIdList.Clear();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow) continue;
                if (row.GetValue<bool>("Column7"))
                {
                    ItemIdList.Add(row.GetValue<long>("Column1"));
                }
            }

            this.DialogResult = DialogResult.OK;
    
        }
    }
}
