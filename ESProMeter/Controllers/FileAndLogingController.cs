using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ESProMeter.DataAccess;
using System.Windows.Forms;
using ESProMeter.Extensions;
using ESProMeter.Services;
using ESProMeter.Sessions;

namespace ESProMeter.Controllers
{
	public static class FileAndLogingController
	{
		public static bool loadActivedCompanyList(this Form form)
		{
			if (SysDbUtility.GetInstance.GetCompanies(out DataTable dtCompList))
			{
				if (dtCompList.Rows.Count > 0)
				{
					form.AsDataGrid("dtgCompanyList").Rows.Clear();

					foreach (DataRow dR in dtCompList.Rows)
					{
						form.AsDataGrid("dtgCompanyList").Rows.Add(dR.ItemArray);
					}
					return true;
				}
			}
			return false;
		}

		public static bool setServerConnectionInformation(this Form form)
		{
			try
			{
				var row = form.AsDataGrid("dtgCompanyList").SelectedRows[0];

				UserSession.CompanyName = row.GetValue<string>("companyName");
				UserSession.ServerName = row.GetValue<string>("serverName");
				UserSession.DatabaseName = row.GetValue<string>("DBName");
				UserSession.UserName = row.GetValue<string>("UName");
				UserSession.Password = row.GetValue<string>("Password");

				MainFrm.ULNF.lblSelectedCompany.Text = UserSession.CompanyName;
				return true;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		public static bool openCompanyFileConnection(this Form form)
		{
			
			try
			{
				return ServerRegistration.TestConnection(UserSession.ServerName, UserSession.DatabaseName, UserSession.UserName, UserSession.Password);
			} 
			catch (Exception ex)
			{
				throw ex;
			}
		}

		public static bool GrantUserAccess(this Form form)
		{
			try
			{
				return UserService.GetUserInstance.Authenticated(form.AsTextBox("txtUserName").Text,
					form.AsTextBox("txtPassword").Text);
				//TextEncrypt(form.AsTextBox("txtPassword").Text));
			} catch (Exception ex) { return false; }
		}

		public static bool memorizeUserCredential(this Form form)
		{
			try
			{
				Properties.Settings.Default.ULOGID = form.AsTextBox("txtUserName").Text;
				Properties.Settings.Default.ULOGPWD = form.AsTextBox("txtPassword").Text;
				Properties.Settings.Default.isPWDREM = form.AsCheckedBox("chkRememberPassword").Checked;
				
				return true;
			}
			catch (Exception ex) { return false; }


		}

		public static bool getUserCredential(this Form form)
		{
			try
			{
				form.AsTextBox("txtUserName").Text = Properties.Settings.Default.ULOGID;
				if (Properties.Settings.Default.isPWDREM)
				{
					form.AsCheckedBox("chkRememberPassword").Checked = true;
					form.AsTextBox("txtPassword").Text = Properties.Settings.Default.ULOGPWD;
				}
				return true;
			}
			catch (Exception ex) { return false; }
		}
	}
}
