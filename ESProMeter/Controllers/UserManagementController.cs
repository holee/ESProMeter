using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ESProMeter.IVews;


namespace ESProMeter.Controllers
{
	public static class UserManagementController
	{
		public static bool isPasswordChangable(this Form form, IChangePassword changePassword)
		{
			try
			{
				if (changePassword?.oldPassword == Properties.Settings.Default.ULOGPWD)
				{
					if (changePassword?.newPassword != changePassword?.oldPassword)
					{
						if (changePassword?.newPassword == changePassword?.confirmPassword)
						{
							return true;
						}
						else
						{
							MessageBox.Show("Confirm password is incorrect, please check your new password and confirm password then try again.", "Incorrect password");
							return false;
						}
					}
					else
					{
						MessageBox.Show("New password must different from old password, please try again.", "Incorrect password");
						return false;
					}
				}
				else
				{
					MessageBox.Show("Incorrect password, please re-enter your old password and try again.", "Incorrect password");
					return false;
				}
			}
			catch (Exception ex)
			{
				throw ex;
			}

		}
	}
}
