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
			SysDbUtility.GetInstance.InsertCompanyDbInfo(this);
			DialogResult = DialogResult.OK;
		}

		private void mbtTestCnn_Click(object sender, EventArgs e)
		{
			this.Cursor = Cursors.WaitCursor;
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
			}
			this.Cursor = Cursors.Default;
		}
	}
}
