using ESProMeter.Controllers;
using ESProMeter.Enums;
using ESProMeter.Extensions;
using ESProMeter.Services;
using ESProMeter.Views.Activies;
using Microsoft.Office.Interop.Excel;
using System;
using System.Drawing;
using System.Windows.Forms;
using static ESProMeter.Extensions.FormExtension;
namespace ESProMeter.Views.Boq
{
    public partial class BOQListFrm : Form
	{
		public BOQListFrm()
		{
			InitializeComponent();
			this.ShowCustomersWith(1);
			this.dtgBOQList.SelectionChanged += dtgBOQListSelectionChanged;
			this.dtgBOQList.DataBindingComplete += dtgDataBindingComplete;
			this.dtgBOQLine.DataBindingComplete += dtgDataBindingComplete;
			this.dtgActivities.DataBindingComplete += dtgDataBindingComplete;
			this.dtgQuotes.DataBindingComplete += dtgDataBindingComplete;
        }
        private void dtgBOQListSelectionChanged(object sender, EventArgs e)
        {

            if (dtgBOQList.SelectedRows.Count > 0)
            {
                var selectedRow = dtgBOQList.SelectedRows[0];
                if (selectedRow != null)
                {
                    var id = selectedRow.GetValue<long>("ID");
                    txtCustomerName.SetText(selectedRow.GetValue<string>("Column2"));
                    txtDate.SetText(selectedRow.GetValue<string>("Column3"));
                    txtTitle.SetText(selectedRow.GetValue<string>("BOQTITLE"));
                    txtSite.SetText(selectedRow.GetText("SITENAME"));
                    txtValidDate.SetText(selectedRow.GetValue<string>("VALIDDATE"));
                    txtReferenceNo.SetText(selectedRow.GetValue<string>("REFNUMBER"));
                    AppService.GetBoqItemLineInstance.GetBoqListInfoByBoqId(id, out var tblBoqLine);
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
            CreateBoQ_Step1_Frm form = new Views.Boq.CreateBoQ_Step1_Frm();
            form.ShowDialog();
        }

		private void toolStripButton2_Click(object sender, EventArgs e)
		{
            if (dtgBOQList.SelectedRows.Count > 0)
            {
                var selectedRow = dtgBOQList.SelectedRows[0];
                var id = selectedRow.GetValue<long>("ID");
                CreateBoQ_Step2_Frm form = new CreateBoQ_Step2_Frm(id, Enums.ActionType.EDIT);
				OpenChildForm(form,MainFrm.ActiveForm);
            }
        }
		void ShowCustomersWith(int status=1)
		{
            this.BoqListGet(status);
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

        private void ClearNew()
        {
            txtCustomerName.Text = "";
            txtTitle.Text = "";
            txtSite.Text = "";
            txtValidDate.Text = "";
            txtDate.Text = "";
			txtReferenceNo.Text = "";

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
						if (dtgBOQList.SelectedRows.Count == 0)
						{
							((System.Data.DataTable)dtgBOQLine.DataSource)?.Rows.Clear();
							ClearNew();
						}
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
				if (item.GetText("Column1").Equals(string.Empty))
				{
					item.DefaultCellStyle.BackColor = Color.Yellow;
                    item.DefaultCellStyle.ForeColor = Color.Black;
                }
			}
        }

		private void dtgDataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
		{
			((DataGridView)sender).ClearSelection();
            ((DataGridView)sender).CurrentCell = null;
		}

		private void toolStripButton5_Click(object sender, EventArgs e)
		{
			if (dtgBOQList.SelectedRows.Count > 0)
			{
				var selectedRow = dtgBOQList.SelectedRows[0];
				var boq_id = selectedRow.GetValue<long>("ID");
				Views.ReportFrm.RptBOQLineFrm formRpt = new ReportFrm.RptBOQLineFrm(boq_id);
				formRpt.Show();
			}
		}

		private void BOQListFrm_Activated(object sender, EventArgs e)
		{
			
		}

		private void dtgBOQLine_RowEnter(object sender, DataGridViewCellEventArgs e)
		{
			if (dtgBOQLine.SelectedRows.Count > 0)
			{
				var item = dtgBOQLine.SelectedRows[0].GetValue<int>("Column10");

				if (item==0)
				{
					dtgBOQLine.Rows[e.RowIndex].DefaultCellStyle.SelectionBackColor = Color.Yellow;
                    dtgBOQLine.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Black;
				}
			}
        }

		private void toolStripButton10_Click(object sender, EventArgs e)
		{
            if (dtgBOQList.SelectedRows.Count > 0)
            {
                var selectedRow = dtgBOQList.SelectedRows[0];
                var id = selectedRow.GetValue<long>("ID");
                BoqDetailsFrm form = new BoqDetailsFrm(id);
                OpenChildForm(form, MainFrm.ActiveForm);
            }
        }

		private void dtgBOQLine_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
            if (dtgBOQLine.SelectedRows.Count == 0) return;
            var selectedRow = dtgBOQLine.SelectedRows[0];
            if (selectedRow.GetValue<int>("Column10") == 0) return;
            var boqId = selectedRow.GetValue<long>("Column8");
            var boqItemId = selectedRow.GetValue<int>("Column10");
            var seq = selectedRow.GetValue<int>("Column11");
            BOQLINEDetailFrm form = new BOQLINEDetailFrm(boqId, boqItemId, seq);
            form.ShowDialog();
        }
	}
}
