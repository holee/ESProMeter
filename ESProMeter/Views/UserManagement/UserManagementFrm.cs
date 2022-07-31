﻿using System;
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
	public partial class UserManagementFrm : Form
	{
		public UserManagementFrm()
		{
			InitializeComponent();
		}

		private void mbtNew_Click(object sender, EventArgs e)
		{
			Form form = new Views.UserManagement.UserFrm();
			form.Text = "Create New User";
			form.ShowDialog();
		}

		private void mbtEdit_Click(object sender, EventArgs e)
		{
			Form form = new Views.UserManagement.UserFrm();
			form.Text = "Edit User";
			form.ShowDialog();
		}
	}
}