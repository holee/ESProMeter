using ESProMeter.Extensions;
using ESProMeter.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ESProMeter.Views.Boq
{
	public partial class BOQListFrm : Form
	{
		public BOQListFrm()
		{
			InitializeComponent();
			dtgBOQList.AutoGenerateColumns = true;
            if (BoqItemLineService.GetInstance.GetBoqList(1, 1,out var table))
			{
				dtgBOQList.DataSource = table;
            }
		}

		private void newBoQToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form form = new Views.Boq.CreateBoQ_Step1_Frm();
			form.ShowDialog();
		}

        private void dtgBOQList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgBOQList.Rows.Count > 0)
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
					BoqItemLineService.GetInstance.GetBoqListInfoByBoqId(selectedRow.GetValue<long>("Column1"),
						out var tblBoqLine, out var tblquote, out var tblactivy);

					dtgActivities.DataSource = tblactivy;
					dtgBOQLine.DataSource = tblBoqLine;
					dtgQuotes.DataSource= tblquote;
				}
			}
        }
    }
}
