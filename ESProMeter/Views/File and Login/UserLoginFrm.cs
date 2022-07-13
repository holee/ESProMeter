using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ESProMeter.Views.File_and_Login
{
	public partial class UserLoginFrm : Form
	{
		public UserLoginFrm()
		{
			InitializeComponent();
		}

		private void mbtCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void UserLoginFrm_Load(object sender, EventArgs e)
		{

		}
	}
}
