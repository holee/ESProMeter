using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ESProMeter.Views.UserManagement
{
	public partial class UserFrm : Form
	{
		public UserFrm()
		{
			InitializeComponent();
		}

		private void mbtClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
