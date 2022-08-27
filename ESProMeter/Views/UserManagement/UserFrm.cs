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
using ESProMeter.Services;

namespace ESProMeter.Views.UserManagement
{
	public partial class UserFrm : Form, IUser
	{

		#region Fields
		private byte _isSysAdmin = 0;
		private DateTime _createdAt = DateTime.Now;
		private DateTime _updatedAt = DateTime.Now;
		#endregion
		#region Properties

		public UserFrm()
		{
			InitializeComponent();
		}

		public UserFrm(int id)
		{
			InitializeComponent();
			this.Text = "Edit User";
			AppService.GetUserInstance.GetUserInformForUpdate(this, id);
		}

		int IUser.Id
		{
			get => lblID.AsNumber<int>();
			set => lblID.SetText(value);
		}
		string IUser.UserId 
		{
			get => txtUserName.Text.Trim();
			set => txtUserName.SetText(value);
		}
		string IUser.Password 
		{
			get => txtPassword.Text;
			set => txtPassword.SetText(value); 
		}

		int IUser.EditSequense 
		{
			get => lblEditSequense.AsNumber<int>();
			set => lblEditSequense.SetText(value); 
		}
		byte IUser.IsActive 
		{
			get => chkIsInActive.Checked ? (byte)0 : (byte)1;
			set => chkIsInActive.Checked = value == 0 ? true : false;
		}
		byte IUser.IsSysAdmin 
		{
			get => _isSysAdmin;
			set => _isSysAdmin = value;
		}
		DateTime IUser.CreatedTime 
		{
			get => _createdAt;
			set => _createdAt = value;
		}
		DateTime IUser.ModifiedTime 
		{
			get => _updatedAt;
			set => _updatedAt = value;
		}
		#endregion

		private void mbtClose_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
		}

		private void mbtSave_Click(object sender, EventArgs e)
		{
			//if valid and accepted for add
			DialogResult = DialogResult.OK;
		}

		private void txtConfirm_TextChanged(object sender, EventArgs e)
		{
			
		}
	}
}
