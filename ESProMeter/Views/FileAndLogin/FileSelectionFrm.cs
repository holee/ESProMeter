using ESProMeter.DataAccess;
using System;
using System.Windows.Forms;
using ESProMeter.Controllers;


namespace ESProMeter.Views.FileAndLogin
{
	public partial class FileSelectionFrm : Form
	{
		public FileSelectionFrm()
		{
			InitializeComponent();
		}

		private void mbtClose_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void mbtOpen_Click(object sender, EventArgs e)
		{
			try
			{
				this.Cursor = Cursors.WaitCursor;
				if (MainFrm.ULNF == null || MainFrm.ULNF.Visible == false) MainFrm.ULNF = new Views.FileAndLogin.UserLoginFrm();
				MainFrm.ULNF.StartPosition = FormStartPosition.CenterScreen;

				

				//if (Connections.getDBServerConnection().State == ConnectionState.Open)
				//{
					this.Hide();
				MainFrm.ULNF.lblSelectedCompany.Text = "Test";// ServerConfiguration.CompanyName;
				if (MainFrm.ULNF.ShowDialog() == DialogResult.OK)
				{
					MainFrm.MainF.splitContainer1.Visible = true;
				}
				else
				{
					this.Show();
				}
				//}
				//else
				//{
				//	MessageBox.Show("The selected company file is not available, please recheck and try again.");
				//}
				this.Cursor = Cursors.Default;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
