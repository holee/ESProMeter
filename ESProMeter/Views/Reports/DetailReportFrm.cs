using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ESProMeter.Views.Reports
{
	public partial class DetailReportFrm : Form
	{
		public DetailReportFrm()
		{
			InitializeComponent();
		}

		private void toolStripButton1_Click(object sender, EventArgs e)
		{
			Form form = new Views.Reports.ReportFilterFrm();

			if(form.ShowDialog() == DialogResult.OK)
			{
				//Refresh the report

			}
		}
	}
}
