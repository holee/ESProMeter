using System;
using System.Windows.Forms;
using ESProMeter.Controllers;
using ESProMeter.IVews;
using ESProMeter.Extensions;

namespace ESProMeter.Views.FileAndLogin
{
    public partial class UserLoginFrm : Form, ILogin
	{
        public string UserName { 
			get => txtUserName.Text.Trim(); 
			set => txtUserName.SetText(value); 
		}
        public string Password { 
			get => txtPassword.Text.Trim(); 
			set => txtPassword.SetText(value); 
		}
        public bool RememberMe { 
			get => chkRememberPassword.Checked; 
			set => chkRememberPassword.Checked=value; 
		}

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
			if (this.GrantUserAccess(this))
			{
				this.userLoggedIn(Properties.Settings.Default.curLoggedUID);
				this.memorizeUserCredential();
			}
			else
			{
				MessageBox.Show("Failed to login to the company file, please verify your user name and password, then try again.", "Login Failed");
				DialogResult = DialogResult.None;
			}
		}
    }
}
