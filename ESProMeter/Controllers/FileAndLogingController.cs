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
using System.Security.Cryptography;
using ESProMeter.IVews;
using ESProMeter.Views.FileAndLogin;
using ESProMeter.Models;

namespace ESProMeter.Controllers
{
	public static class FileAndLogingController
	{
		public static string TextEncrypt(string input)
		{
			// step 1, calculate MD5 hash from input
			MD5 md5 = MD5.Create();
			byte[] inputBytes = Encoding.ASCII.GetBytes(input);
			byte[] hash = md5.ComputeHash(inputBytes);

			// step 2, convert byte array to hex string
			StringBuilder sb = new StringBuilder();
			for (int i = 0; i < hash.Length; i++)
			{
				sb.Append(hash[i].ToString());
			}
			return sb.ToString();
		}

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

		public static bool SetServerConnectionInformation(this Form form)
		{
			try
			{
				var row = form.AsDataGrid("dtgCompanyList").SelectedRows[0];
				//UserSession.UID = row.GetValue<Int32>("ID");
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
				throw new Exception(ex.Message);
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
				throw new Exception(ex.Message);
			}
		}

		public static bool GrantUserAccess(this Form form)
		{
			try
			{
				return AppService.GetUserInstance.Authenticated(form.AsTextBox("txtUserName").Text,
				TextEncrypt(form.AsTextBox("txtPassword").Text));
			} catch { return false; }
		}
		public static bool GrantUserAccess(this Form form, ILogin login)
		{
			try
			{
				return AppService.GetUserInstance.Authenticated(login.UserName,login.Password);
			}
			catch
			{ 
				return false; 
			}
		}

		public static bool memorizeUserCredential(this Form form)
		{
			try
			{
				Properties.Settings.Default.ULOGID = form.AsTextBox("txtUserName").Text;
				Properties.Settings.Default.ULOGPWD = form.AsTextBox("txtPassword").Text;
				Properties.Settings.Default.isPWDREM = form.AsControl<CheckBox>("chkRememberPassword").Checked;
				Properties.Settings.Default.Save();
				
				return true;
			}
			catch { return false; }


		}

		public static bool getUserCredential(this Form form)
		{
			try
			{
				form.AsTextBox("txtUserName").Text = Properties.Settings.Default.ULOGID;
				if (Properties.Settings.Default.isPWDREM)
				{
					form.AsControl<CheckBox>("chkRememberPassword").Checked = true;
					form.AsTextBox("txtPassword").Text = Properties.Settings.Default.ULOGPWD;
				}
				return true;
			}
			catch (Exception ex) { return false; }
		}
	}
}
