using ESProMeter.Controllers;
using ESProMeter.Extensions;
using ESProMeter.Services;
using ESProMeter.Views.Activies;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace ESProMeter.Views.Boq
{
    public partial class BOQListFrm : Form
	{
		public BOQListFrm()
		{
			InitializeComponent();
			menuStrip5.Cursor = Cursors.Default;
			tab.Cursor = Cursors.Default;
			dtgBOQLine.Cursor = Cursors.Default;
			dtgBOQList.Cursor = Cursors.Default;
			ShowCustomersWith();

        }
        private void dtgBOQList_SelectionChanged(object sender, EventArgs e)
        {

			if (dtgBOQList.SelectedRows.Count >0)
			{
				var selectedRow = dtgBOQList.SelectedRows[0];
				if (selectedRow != null)
				{
					var id = selectedRow.GetValue<long>("ID");
                    txtCustomerName.SetText(selectedRow.GetValue<string>("Column2"));
					txtDate.SetText(selectedRow.GetValue<string>("Column3"));
					txtTitle.SetText(selectedRow.GetValue<string>("BOQTITLE"));
					txtSite.SetText(selectedRow.GetValue<string>("SITENAME"));
					txtValidDate.SetText(selectedRow.GetValue<string>("VALIDDATE"));
					txtReferenceNo.SetText(selectedRow.GetValue<string>("REFNUMBER"));
					AppService.GetBoqItemLineInstance.GetBoqListInfoByBoqId(id,out var tblBoqLine);
					tblBoqLine.UseDataTableAsGridView(dtgBOQLine);
					AppService.GetActivityInstance.ActivityGetByBoqID(id, out var tableActivity);
					tableActivity.UseDataTableAsGridView(dtgActivities);
					AppService.GetQuoteInstance.QuoteGetByBoq(id, out var tableQuotes);
					tableQuotes.UseDataTableAsGridView(dtgQuotes);
				}
			}
		}
		private void toolStripButton1_Click(object sender, EventArgs e)
		{
            Form form = new Views.Boq.CreateBoQ_Step1_Frm();
            form.ShowDialog();
        }

		private void toolStripButton2_Click(object sender, EventArgs e)
		{
            if (dtgBOQList.SelectedRows.Count > 0)
            {
                var selectedRow = dtgBOQList.SelectedRows[0];
                var id = selectedRow.GetValue<long>("ID");
                CreateBoQ_Step2_Frm form = new CreateBoQ_Step2_Frm(id, Enums.ActionType.EDIT);
				//form.Show();
				this.OpenChildForm(form,MainFrm.ActiveForm);
            }
        }
		void ShowCustomersWith(int status=1)
		{
			((DataTable)dtgBOQList.DataSource)?.Rows.Clear();
			if (chkIncludeClosedBOQ.Checked)
			{
                if (AppService.GetBoqItemLineInstance.GetBoqList(1, status, out var table))
                {
                    dtgBOQList.DataSource = table;
                }
            }
			else
			{
                if (AppService.GetBoqItemLineInstance.GetBoqList(0, status, out var table))
                {
                    dtgBOQList.DataSource = table;
                }
            }
            
        }


		private void toolRefreshClick(object sender, EventArgs e)
		{
			ShowCustomersWith();
        }

		private void tlsActivityAddClick(object sender, EventArgs e)
		{
			if (dtgBOQList.SelectedRows.Count > 0)
			{
				var selectedRow = dtgBOQList.SelectedRows[0];
				var boq_id = selectedRow.GetValue<long>("ID");
				var form = new ActivityCreateFrm(boq_id);
				if (form.ShowDialog() == DialogResult.OK)
				{
					if (this.ActivityCreate(form))
					{
						this.ActivityGetByBoq(boq_id);
					}
				}
            }
		}

		private void tlsDeleteClick(object sender, EventArgs e)
		{
			if (dtgBOQList.SelectedRows.Count > 0)
			{
				var selectedRow = dtgBOQList.SelectedRows[0];
				var boq_id = selectedRow.GetValue<long>("ID");
				if (MessageBox.Show("do you want to delete this BOQ?", "BOQ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
				{
					if (this.BoqDelete(boq_id))
					{
						dtgBOQList?.Rows.Remove(selectedRow);
					}
				}
				else
				{
					return;
				}
			}
		}

		private void dtgBOQLine_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			foreach (DataGridViewRow item in dtgBOQLine.Rows)
			{
				if (item.GetValue<string>("ITEMNAME").Equals(string.Empty))
				{
					item.DefaultCellStyle.BackColor = Color.Teal;
                    item.DefaultCellStyle.ForeColor = Color.White;
                }
			}
        }
	}
}
