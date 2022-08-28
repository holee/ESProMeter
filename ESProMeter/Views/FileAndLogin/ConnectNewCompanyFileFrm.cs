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
using ESProMeter.Services;

namespace ESProMeter.Views.FileAndLogin
{
	public partial class ConnectNewCompanyFileFrm : Form, INCConnection
	{
		bool connectionAvailable;

		string INCConnection.serverName 
		{
			get => txtServer.Text.Trim();
			set => txtServer.SetText(value);
		}
		string INCConnection.dbName 
		{
			get => txtDBName.Text.Trim();
			set => txtDBName.SetText(value);
		}
		string INCConnection.login 
		{
			get => txtLoginName.Text.Trim();
			set => txtLoginName.SetText(value);
		}
		string INCConnection.pwd 
		{
			get => txtPassword.Text.Trim();
			set => txtPassword.SetText(value);
		}

		string INCConnection.comName
		{
			get => txtCompanyName.Text.Trim();
			set => txtCompanyName.SetText(value);
		}

		public ConnectNewCompanyFileFrm()
		{
			InitializeComponent();
		}

		private void mbtClose_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
		}

		private void mbtConnect_Click(object sender, EventArgs e)
		{
			if (connectionAvailable)
			{
				SysDbUtility.GetInstance.InsertCompanyDbInfo(this);
				DialogResult = DialogResult.OK;
			} else 
			{
				MessageBox.Show("You cannot create new connection to this company file, it may not available or has already connected to the application.", "New Company File Connection");
			}
		}

		private void mbtTestCnn_Click(object sender, EventArgs e)
		{
			if (!this.IsValid(txtServer, txtDBName, txtLoginName, txtPassword))
			{
				return;
			}

			this.Cursor = Cursors.WaitCursor;
			connectionAvailable = false;
			lblMsg.Visible = false;
			if (this.testCompanyFileConnection(this))
			{

				this.SetServerConnectionInformation(this);

				txtCompanyName.SetText(AppService.GetCompanyInstance.ShowCompanyInformation().cn);
				txtLegalCompanyName.SetText(AppService.GetCompanyInstance.ShowCompanyInformation().lcn);

				if (SysDbUtility.GetInstance.isConnectionEstablished(this))
				{
					lblMsg.Visible = true;
				}
				else
				{
					connectionAvailable = true;
				}
			}
			else
			{
				MessageBox.Show("The company file you are trying to connect may not available, please check connection information and try again.", "New Company File Connection");
			}
			this.Cursor = Cursors.Default;
		}
	}
}
