using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ESProMeter.Extensions;

namespace ESProMeter.Controllers
{
	public static class MainController
	{
		public static void AccessableRole(bool EnableRole)
		{
			//Show split container
			MainFrm.MainF.splitContainer1.Visible = EnableRole;

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

			//Open file selection form
			AccessableRole(false);
			MainFrm.FSNF.Show();
		}
	}
}
