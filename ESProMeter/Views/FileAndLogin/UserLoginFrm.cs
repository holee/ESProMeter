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
using ESProMeter.Controllers;

namespace ESProMeter.Views.FileAndLogin
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
			this.getUserCredential();
		}

		private void mbtOK_Click(object sender, EventArgs e)
		{
			if (this.GrantUserAccess())
			{
				this.memorizeUserCredential();
			}
			else
			{
				MessageBox.Show("Failed to login to the company file, please verify your user name and password, then try again.", "Login Failed");
				DialogResult = DialogResult.None;
			}
		}

        private void mbtOK_Click(object sender, EventArgs e)
        {
			//if (UserService.GetUserInstance.Authenticated(txtUserName.Text, txtPassword.Text))
			//{
			//	MessageBox.Show("Login");
			//	this.DialogResult = DialogResult.OK;
			//}
			//else
			//{
			//	this.DialogResult = DialogResult.Cancel;
			//	MessageBox.Show("failed");
			//	return;
			//}
        }
    }
}
