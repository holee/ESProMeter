using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ESProMeter.Extensions;
using ESProMeter.Services;
using ESProMeter.Sessions;

namespace ESProMeter.Controllers
{
	public static class MainController
	{
		public static void AccessableRole(bool EnableRole)
		{
			//Main form text
			
			MainFrm.MainF.Text = EnableRole?"ES-Pro Metré" + " - " + UserSession.CompanyName: "ES-Pro Metré";

			//Application alive timer
			MainFrm.MainF.tmrAlive.Interval =  60000;
			MainFrm.MainF.tmrAlive.Enabled = EnableRole;
			if (EnableRole) { MainFrm.MainF.tmrAlive.Start(); } else { MainFrm.MainF.tmrAlive.Stop(); }

			//Show panel menu
			MainFrm.MainF.panelMenu.Visible = EnableRole;

			//Main form menu
			//File
			MainFrm.MainF.toolStripMenuItem7.Enabled = !EnableRole;
			MainFrm.MainF.openCompanyFileToolStripMenuItem.Enabled = !EnableRole;
			MainFrm.MainF.connectToExistingCompanyFileToolStripMenuItem.Enabled = !EnableRole;
			MainFrm.MainF.closeCompanyToolStripMenuItem.Enabled = EnableRole;
			MainFrm.MainF.backupCompanyFileToolStripMenuItem.Enabled = EnableRole;
			MainFrm.MainF.toolStripMenuItem8.Enabled = !EnableRole;

			//List
			MainFrm.MainF.listToolStripMenuItem.Enabled = EnableRole;

			//Company
			MainFrm.MainF.companyToolStripMenuItem.Enabled = EnableRole;

			//Customer
			MainFrm.MainF.customerToolStripMenuItem.Enabled = EnableRole;

			//Bill of Quantity
			MainFrm.MainF.billOfQuantityToolStripMenuItem.Enabled = EnableRole;

			//Report
			MainFrm.MainF.reportToolStripMenuItem.Enabled = EnableRole;
			//Help
		}

		public static void closeCompanyFile()
		{
			//Close all actived form

			//Close company connection
			UserSession.clearSession();
			Properties.Settings.Default.curLoggedUID = 0;

			//Open file selection form
			AccessableRole(false);
			MainFrm.FSNF.Show();
		}

		public static bool CreateCompanyFileBackup(this Form form,string filename)
		{
			try
			{
				AppService.GetCompanyInstance.CreateCompanyFileBackup(UserSession.DatabaseName, filename);
				return true;
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
				return false; 
			}
		}


		public static bool RestoreCompanyFile(this Form form)
		{
			return AppService.GetCompanyInstance.RestoreCompanyFile("Test1", @"D:\Backup.esp");
		}
		

	}
}
