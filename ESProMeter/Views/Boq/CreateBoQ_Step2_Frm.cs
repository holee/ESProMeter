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
	public partial class CreateBoQ_Step2_Frm : Form
	{
		public CreateBoQ_Step2_Frm()
		{
			InitializeComponent();
			

		}

		private void txtBOQDesc_Enter(object sender, EventArgs e)
		{
			txtBOQDesc.BringToFront();
			txtBOQDesc.Height = 97;
		}

		private void txtBOQDesc_Leave(object sender, EventArgs e)
		{
			txtBOQDesc.Height = 23;
		}

		private void txtTermsCondition_Leave(object sender, EventArgs e)
		{
			txtTermsCondition.Height = 23;
			txtTermsCondition.Top = this.Height - 49;
		}

		private void txtTermsCondition_Enter(object sender, EventArgs e)
		{
			txtTermsCondition.BringToFront();
			txtTermsCondition.Height = 127;
			txtTermsCondition.Top = this.Height - 153;
		}

		private void CreateBoQ_Step2_Frm_Activated(object sender, EventArgs e)
		{
			//this.txtTermsCondition.Top = this.Height - 50;
		}

		private void mbtCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
