using ESProMeter.DataAccess;
using System;
using System.Windows.Forms;
using ESProMeter.Controllers;
using ESProMeter.Services;
using ESProMeter.Sessions;
using ESProMeter.Views.FileAndLogin;


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

		public void mbtOpen_Click(object sender, EventArgs e)
		{
			try
			{
				this.Cursor = Cursors.WaitCursor;
				if (MainFrm.ULNF == null || MainFrm.ULNF.Visible == false) MainFrm.ULNF = new Views.FileAndLogin.UserLoginFrm();
				MainFrm.ULNF.StartPosition = FormStartPosition.CenterScreen;

				this.SetServerConnectionInformation();


				if (this.openCompanyFileConnection())
				{
					this.Hide();
				
					if (MainFrm.ULNF.ShowDialog() == DialogResult.OK)
					{
						MainController.AccessableRole(true);

					}
                    else
                    {
                        this.Show();
                    }
                }
				else
				{
					MessageBox.Show("The selected company file is not available, please recheck and try again.");
				}
				this.Cursor = Cursors.Default;
			}
			catch (Exception ex)
			{
                throw;
            }
		}

		private void FileSelectionFrm_Load(object sender, EventArgs e)
		{
			this.loadActivedCompanyList();
		}

		private void mbtConnectToExistingCompanyFile_Click(object sender, EventArgs e)
		{
			ConnectNewCompanyFileFrm form = new ConnectNewCompanyFileFrm();
			if (form.ShowDialog() == DialogResult.OK)
			{
				//Reload company list and select the new company connection
				this.loadActivedCompanyList();
				//Open the company file for login

			}
		}
	}
}
