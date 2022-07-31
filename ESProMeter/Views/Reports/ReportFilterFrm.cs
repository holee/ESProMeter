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
	public partial class ReportFilterFrm : Form
	{
		public ReportFilterFrm()
		{
			InitializeComponent();
		}

		private void mbtCancel_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			this.Close();
		}

		private void mbtOK_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.OK;
			//Return condition clause
			this.Close();
		}
	}
}
