using System;
using System.Windows.Forms;

namespace ESProMeter.Views.FileAndLogin
{
	public partial class FileSelectionFrm : Form
	{
		public FileSelectionFrm()
		{
			InitializeComponent();
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}
