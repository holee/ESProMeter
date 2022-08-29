using ESProMeter.Controllers;
using ESProMeter.Enums;
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
			this.dataUom.AutoGenerateColumns = false;
			tlsSelectedRow.SelectedIndex = 0;
			FormExtension.SetDoubleBuffer(dataUom, true);
			ShowUom();
		}

		private void ShowUom()
        {
			if (chkInactive.Checked)
			{
				if (int.TryParse(tlsSelectedRow.Text, out var page))
				{
					this.ShowAllUomWithDataGrid(0, page);
				}
            }
            else
            {
				if (int.TryParse(tlsSelectedRow.Text, out var page))
				{
					this.ShowAllUomWithDataGrid(1, page);
				}
			}
		}





		private void tsbNewUoM_Click(object sender, EventArgs e)
		{
			AddUoMFrm form = new AddUoMFrm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                try
                {
					this.AddOrUpdate(ActionType.CREATE, form);
					ShowUom();
				}
				catch(Exception ex)
                {
					MessageBox.Show(ex.Message, "Error");
					return;
                }
				
			}
		}
        private void stbDeleteUoM_Click(object sender, EventArgs e)
        {
			if (dataUom.SelectedRows.Count > 0)
			{
				var row = dataUom.SelectedRows[0];
				var id = row.GetValue<long>("ID");
				if (MessageBox.Show("Do you want to delete?", "Confirm", MessageBoxButtons.OKCancel,MessageBoxIcon.Question) == DialogResult.OK)
                {
                    try
                    {
						if (this.DeleteUomById(id))
						{
							this.dataUom.Rows.Remove(row);
							//row.Visible = false;
						}
					}
                    catch(Exception ex)
                    {
						MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
					
				}
				
			}
		}

        private void stbEditUoM_Click(object sender, EventArgs e)
        {
			if (dataUom.Rows.Count > 0)
			{
				var row = dataUom.SelectedRows[0];
				var id = row.GetValue<long>("ID");
				AddUoMFrm form = new AddUoMFrm(id);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
						this.AddOrUpdate(ActionType.EDIT, form);
						ShowUom();
					}
                    catch (Exception ex)
                    {

						MessageBox.Show(ex.Message, "ESPRO-METER",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
					
				}
            }
		}

        private void stbMakInactive_Click(object sender, EventArgs e)
        {
			if (dataUom.Rows.Count > 0)
			{
				if (dataUom.SelectedRows.Count < 1 ) return;

				var row = dataUom.SelectedRows[0];
				var id = row.GetValue<long>("ID");
				byte IsActive =row.GetValue<byte>("IsActive") ==0?(byte)1:(byte)0;

				if (this.MakeInactive(id, IsActive))
				{
					this.dataUom.SetText("IsActive", IsActive);
					if (IsActive == 0 && this.chkInactive.Checked == false)
					{
						dataUom.Rows.RemoveAt(row.Index);
					}
					else
					{
						stbMakInactive.Text = IsActive == 0 ? "Make Active" : "Make Inctive";
					}
				}
				
			}
		}

  //      private void dataGridView1_MouseUp(object sender, MouseEventArgs e)
  //      {
		//	// Load context menu on right mouse click
		//	DataGridView.HitTestInfo hitTestInfo;
		//	if (e.Button == MouseButtons.Right)
		//	{
		//		hitTestInfo = dataUom.HitTest(e.X, e.Y);
		//		// If column is first column
		//		if (hitTestInfo.Type == DataGridViewHitTestType.Cell && hitTestInfo.ColumnIndex > 1)
		//			contextMenuStrip1.Show(dataUom, new Point(e.X, e.Y));
		//		// If column is second column
		//		if (hitTestInfo.Type == DataGridViewHitTestType.Cell && hitTestInfo.ColumnIndex == 1)
		//			contextMenuStrip1.Show(dataUom, new Point(e.X, e.Y));
		//	}
		//}


        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
			if (dataUom.Rows.Count > 0)
			{
				var index = dataUom.CurrentCell.RowIndex;
				var id = dataUom.AsNumber<long>(index, "Column3");
				if (MessageBox.Show("Do you want to delete?", "Confirm", MessageBoxButtons.OKCancel) == DialogResult.OK)
				{
					if (this.DeleteUomById(id))
					{
						this.dataUom.Rows.RemoveAt(index);
					}
				}

			}
		}
        private void tltRefresh_Click(object sender, EventArgs e)
        {
			ShowUom();
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
						stbMakInactive.Text = "Make Inactive";

					}
                }
            }
        }

        private void tlsSelectedRow_SelectedIndexChanged(object sender, EventArgs e)
        {
			if(int.TryParse(tlsSelectedRow.Text, out var page))
            {
				this.ShowAllUomWithDataGrid(0,page);
			}	
			
        }

        private void chkInactive_CheckedChanged(object sender, EventArgs e)
        {
            if (chkInactive.Checked)
            {
				if (int.TryParse(tlsSelectedRow.Text, out var page))
				{
					this.ShowAllUomWithDataGrid(0, page);
				}
            }
            else
            {
				if (int.TryParse(tlsSelectedRow.Text, out var page))
				{
					this.ShowAllUomWithDataGrid(1, page);
				}
			}
        }

		private void dataUom_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void excelToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}
	}
}
