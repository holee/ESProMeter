using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ESProMeter.Extensions;
using ESProMeter.IVews;

namespace ESProMeter.Views.FileAndLogin
{
	public partial class BackupFrm : Form,IFileBackup
	{
		public string path { get => txtFilePath.Text.Trim(); set => txtFilePath.SetText(value); }
		public string name { get => txtFileName.Text.Trim(); set => txtFileName.SetText(value); }
		public byte overwrite { get => chkOverwrite.Checked?(byte)1:(byte)0; set => chkOverwrite.Checked = value ==1 ? true : false; }

		public BackupFrm()
		{
			InitializeComponent();
			txtFilePath.SetText(Properties.Settings.Default.backupPath);
			txtFileName.SetText("Backup" + " " + DateTime.Now.ToString("ddMMMyyyy hhmmss") + ".ESP");
		}

		private void mbtCancel_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
		}

		private void mbtBrowse_Click(object sender, EventArgs e)
		{
			using (var fbd = new FolderBrowserDialog())
			{
				fbd.SelectedPath = Properties.Settings.Default.backupPath.Length>0? Properties.Settings.Default.backupPath: @"C:\";
				DialogResult result = fbd.ShowDialog();
				//fbd.RootFolder = Environment.SpecialFolder.Desktop;
				
				if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
				{
					txtFilePath.SetText(fbd.SelectedPath);
				}
			}
		}

		private void mbtBackup_Click(object sender, EventArgs e)
		{
			//Check if everything acceptable
			if (this.IsValid(txtFilePath, txtFileName))
			{
				DialogResult = DialogResult.OK;
			}
			else
			{
				MessageBox.Show("Please select folder and name your backup file then try again.", "Backup File");
			}
		}

		private void txtFileName_Leave(object sender, EventArgs e)
		{
			if (txtFileName.Text.Trim().Substring(txtFileName.Text.Trim().Length-4,4).ToUpper() != ".ESP")
			{
				txtFileName.Text = txtFileName.Text.Trim() + ".ESP";
			}
		}
	}
}
