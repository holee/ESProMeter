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
	public partial class CreateBoQ_Step1_Frm : Form
	{
		public CreateBoQ_Step1_Frm()
		{
			InitializeComponent();
		}

		private void mbtNext_Click(object sender, EventArgs e)
		{
			Form form = new Views.Boq.CreateBoQ_Step2_Frm();
			form.TopLevel = false;
			form.TopMost = true;
			form.FormBorderStyle = FormBorderStyle.None;
			form.WindowState = FormWindowState.Maximized;
			MainFrm.MainF.panel2.Controls.Clear();
			MainFrm.MainF.panel2.Controls.Add(form);
			form.Show();
			form.Dock = DockStyle.Fill;

			this.Close();
		}

		private void mbtCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
