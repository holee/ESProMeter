using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ESProMeter.IVews;
using ESProMeter.Extensions;
using ESProMeter.Controllers;


namespace ESProMeter.Views.UserManagement
{
	public partial class ChangePasswordFrm : Form, IChangePassword
	{
		public string oldPassword { 
			get => txtOldPassword.Text.Trim();
			set => txtOldPassword.SetText(value);
		}

		public string newPassword { 
			get => txtNewPassword.Text.Trim(); 
			set => txtNewPassword.SetText(value); 
		}

		public string confirmPassword { 
			get =>txtConfirmPassword.Text.Trim(); 
			set => txtConfirmPassword.SetText(value); 
		}

		public ChangePasswordFrm()
		{
			InitializeComponent();
		}

		private void mbtSave_Click(object sender, EventArgs e)
		{
			if (this.IsValid(txtOldPassword, txtNewPassword, txtConfirmPassword))
			{
				if (this.isPasswordChangable(this))
				{
					//Change pasword
					DialogResult = DialogResult.OK;
				}
				else
				{
					DialogResult = DialogResult.None;
				}
			}
			else
			{
				DialogResult = DialogResult.None;
			}
		}
	}
}
