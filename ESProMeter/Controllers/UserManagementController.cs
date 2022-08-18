using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ESProMeter.IVews;
using ESProMeter.Views.UserManagement;
using ESProMeter.Services;


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

		public static bool CreateNewUser(this Form form, IUser user)
		{
			return AppService.GetUserInstance.Register(user);
		}

		public static bool ChangePassword(this Form form, IChangePassword  cPwd)
		{
			if (AppService.GetUserInstance.ChangePassword(cPwd))
			{
				MessageBox.Show("Your password has successfully changed.", "Change Password");
				return true;
			}
			return false;
		}

		public static void showUserList(this Form form, DataGridView dtg,  byte includeinactive)
		{
			if (AppService.GetUserInstance.GetAllUserList(includeinactive, out var table))
			{
				//table.DefaultView.Sort = $"ITEMTYPE,ITEMNAME {orderBy}";
				dtg.DataSource = table;
				for (int i = 0; i < dtg.Columns.Count;i++)
				{
					dtg.Columns[i].Visible = false;
					if (dtg.Columns[i].Name == "USERID" || dtg.Columns[i].Name =="LOGSTATE")
					{
						dtg.Columns[i].Visible = true;
					}
				}
			}
		}

		//public static bool DeleteUser(this Form form, int uid)
		//{

		//}
	}
}
