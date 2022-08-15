using ESProMeter.Extensions;
using ESProMeter.Services;
using System;
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
            if (AppService.GetBoqItemLineInstance.GetBoqList(1, 1,out var table))
			{
				dtgBOQList.DataSource = table;
            }
			if (dtgBOQList.Rows.Count > 0)
			{
                dtgBOQList.Rows[0].Selected = true;
			}
		}

		private void newBoQToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form form = new Views.Boq.CreateBoQ_Step1_Frm();
			form.ShowDialog();
		}
        private void dtgBOQList_SelectionChanged(object sender, EventArgs e)
        {

			if (dtgBOQList.SelectedRows.Count >0)
			{
				var selectedRow = dtgBOQList.SelectedRows[0];
				if (selectedRow != null)
				{
					txtCustomerName.SetText(selectedRow.GetValue<string>("Column2"));
					txtDate.SetText(selectedRow.GetValue<string>("Column3"));
					txtTitle.SetText(selectedRow.GetValue<string>("BOQTITLE"));
					txtSite.SetText(selectedRow.GetValue<string>("SITENAME"));
					txtValidDate.SetText(selectedRow.GetValue<string>("VALIDDATE"));
					txtReferenceNo.SetText(selectedRow.GetValue<string>("REFNUMBER"));
					AppService.GetBoqItemLineInstance.GetBoqListInfoByBoqId(selectedRow.GetValue<long>("ID"),
						out var tblBoqLine, out var tblquote, out var tblactivy);

					dtgActivities.DataSource = tblactivy;
					dtgBOQLine.DataSource = tblBoqLine;
					dtgQuotes.DataSource = tblquote;
				}
			}
		}

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dtgBOQList.SelectedRows.Count > 0)
            {
				var selectedRow=dtgBOQList.SelectedRows[0];
				var id = selectedRow.GetValue<long>("ID");
				CreateBoQ_Step2_Frm form = new CreateBoQ_Step2_Frm(id,Enums.ActionType.EDIT);
				form.Show();
            }
        }
    }
}
