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
using ESProMeter.Extensions;

namespace ESProMeter.Views.UserManagement
{
	public partial class UserManagementFrm : Form
	{
		public UserManagementFrm()
		{
			InitializeComponent();
			showActivedUserList();
		}

		private void mbtNew_Click(object sender, EventArgs e)
		{
			Views.UserManagement.UserFrm form = new Views.UserManagement.UserFrm();
			form.Text = "Create New User";
			if (form.ShowDialog() == DialogResult.OK)
			{
				this.CreateNewUser(form);
				showActivedUserList();
			}
		}

		private void mbtEdit_Click(object sender, EventArgs e)
		{
			Views.UserManagement.UserFrm form = new Views.UserManagement.UserFrm();
			form.Text = "Edit User";
			if (form.ShowDialog() == DialogResult.OK)
			{

				showActivedUserList();
			}
		}

		private void showActivedUserList()
		{
			this.showUserList(dtgUserList, 1);
		}

		private void mbtDelete_Click(object sender, EventArgs e)
		{
			var selRow = dtgUserList.SelectedRows[0];
			if (selRow.GetValue<string>("LOGSTATE").ToUpper() == "LOGGED ON")
			{
				MessageBox.Show("You cannot delete a user while it is logged on", "Delete User");
			}
			else
			{
				this.DeleteUser(selRow.GetValue<int>("ID"));
				this.showUserList(dtgUserList, 1);
			}
		}
	}
}
