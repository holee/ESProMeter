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
		}

		private void newBoQToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form form = new Views.Boq.CreateBoQ_Step1_Frm();
			form.ShowDialog();
		}
	}
}
