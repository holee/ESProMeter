using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ESProMeter.Views.Customer
{
	public partial class CustomerFrm : Form
	{
		public CustomerFrm()
		{
			InitializeComponent();
		}

		private void mbtCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void mbtSaveClose_Click(object sender, EventArgs e)
		{
			//Save customer information and close the form

			this.Close();
		}

		private void mbtSaveNew_Click(object sender, EventArgs e)
		{
			//Save customer information and clear control for new customer creation


		}
	}
}
