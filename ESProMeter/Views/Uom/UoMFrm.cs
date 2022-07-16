using ESProMeter.Controllers;
using ESProMeter.Extensions;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ESProMeter.Views.UnitOfMeasures
{
	public partial class UoMFrm : Form 
	{
		public UoMFrm()
		{
			InitializeComponent();
			this.GetAllUom(this.dataUom);
		}
		private void tsbNewUoM_Click(object sender, EventArgs e)
		{
			Form form = new AddUoMFrm();
            if (form.ShowDialog() == DialogResult.OK)
            {
				this.ShowDataDataGrid();
			}
		}

        private void GridViewCellContentClick(object sender, DataGridViewCellEventArgs e)
        {
			var id=dataUom.AsNumber<long>(e.RowIndex, "Column3");
			AddUoMFrm form = new AddUoMFrm(id);
			if (form.ShowDialog() == DialogResult.OK)
			{
				this.ShowDataDataGrid();
			}
		}

        private void stbDeleteUoM_Click(object sender, EventArgs e)
        {
			if (dataUom.Rows.Count > 0)
			{
				var index = dataUom.CurrentCell.RowIndex;
				var id = dataUom.AsNumber<long>(index, "Column3");
				if (MessageBox.Show("Do you want to delete?", "Confirm", MessageBoxButtons.OKCancel,MessageBoxIcon.Question) == DialogResult.OK)
                {
					if (this.DeleteDataDataGrid(id))
					{
						this.dataUom.Rows.RemoveAt(index);
					}
				}
				
			}
		}

        private void stbEditUoM_Click(object sender, EventArgs e)
        {
			if (dataUom.Rows.Count > 0)
			{
                var index = dataUom.CurrentCell.RowIndex;
				var id = dataUom.AsNumber<long>(index, "Column3");
				AddUoMFrm form = new AddUoMFrm(id);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    this.ShowDataDataGrid();
					dataUom.Rows[index].Selected = true;
                }
            }
		}

        private void stbMakInactive_Click(object sender, EventArgs e)
        {
			if (dataUom.Rows.Count > 0)
			{
				var index = dataUom.CurrentCell.RowIndex;
				var id = dataUom.AsNumber<long>(index, "Column3");
				var IsActive = dataUom.AsNumber<int>(index, "IsActive")==0?1:0;
                if (this.MakeInactive(id,IsActive))
                {
					this.dataUom.SetText("IsActive", IsActive);
					stbMakInactive.Text = IsActive==0?"Make Active":"Make in Active";
				}
			}
		}

        private void dataGridView1_MouseUp(object sender, MouseEventArgs e)
        {
			// Load context menu on right mouse click
			DataGridView.HitTestInfo hitTestInfo;
			if (e.Button == MouseButtons.Right)
			{
				hitTestInfo = dataUom.HitTest(e.X, e.Y);
				// If column is first column
				if (hitTestInfo.Type == DataGridViewHitTestType.Cell && hitTestInfo.ColumnIndex > 1)
					contextMenuStrip1.Show(dataUom, new Point(e.X, e.Y));
				// If column is second column
				if (hitTestInfo.Type == DataGridViewHitTestType.Cell && hitTestInfo.ColumnIndex == 1)
					contextMenuStrip1.Show(dataUom, new Point(e.X, e.Y));
			}
		}

        private void addNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
			Form form = new AddUoMFrm();
			if (form.ShowDialog() == DialogResult.OK)
			{
				this.ShowDataDataGrid();
			}
		}

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
			if (dataUom.Rows.Count > 0)
			{
				var index = dataUom.CurrentCell.RowIndex;
				var id = dataUom.AsNumber<long>(index, "Column3");
				AddUoMFrm form = new AddUoMFrm(id);
				if (form.ShowDialog() == DialogResult.OK)
				{
					this.ShowDataDataGrid();
				}
			}
		}

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
			if (dataUom.Rows.Count > 0)
			{
				var index = dataUom.CurrentCell.RowIndex;
				var id = dataUom.AsNumber<long>(index, "Column3");
				if (MessageBox.Show("Do you want to delete?", "Confirm", MessageBoxButtons.OKCancel) == DialogResult.OK)
				{
					if (this.DeleteDataDataGrid(id))
					{
						this.dataUom.Rows.RemoveAt(index);
					}
				}

			}
		}

        private void makeInActiveToolStripMenuItem_Click(object sender, EventArgs e)
        {
			if (dataUom.Rows.Count > 0)
			{
				var index = dataUom.CurrentCell.RowIndex;
				var id = dataUom.AsNumber<long>(index, "Column3");
				if (this.MakeInactive(id))
				{
					this.ShowDataDataGrid();
				}
			}
		}

        private void reloadToolStripMenuItem_Click(object sender, EventArgs e)
        {
			this.ShowDataDataGrid();
		}

        private void tltRefresh_Click(object sender, EventArgs e)
        {
			this.ShowDataDataGrid();
		}

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in ((DataGridView)sender).Rows)
            {
                if (row.Selected)
                {
                    if (row.Cells["IsActive"].Value.ToString()=="0")
                    {
						stbMakInactive.Text = "Make Active";
					}
                    else
                    {
						stbMakInactive.Text = "Make In Active";

					}
                }
            }
			//var index = dataGridView1.CurrentCell.RowIndex;
			//dataGridView1.Rows[index].Selected = true;
        }

	}
}
