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
				int selindex = form.AsDataGrid("dtgCompanyList").SelectedRows[0].Index;

				//var row = form.AsDataGrid("dtgCompanyList").SelectedRows[0];

				//UserSession.CompanyName = row.GetValue<string>("companyName");


				UserSession.CompanyName = form.AsDataGrid("dtgCompanyList").Rows[selindex].Cells["companyName"].Value.ToString();
				UserSession.ServerName = form.AsDataGrid("dtgCompanyList").Rows[selindex].Cells["serverName"].Value.ToString();
				UserSession.DatabaseName = form.AsDataGrid("dtgCompanyList").Rows[selindex].Cells["DBName"].Value.ToString();
				UserSession.UserName = form.AsDataGrid("dtgCompanyList").Rows[selindex].Cells["UName"].Value.ToString();
				UserSession.Password = form.AsDataGrid("dtgCompanyList").Rows[selindex].Cells["Password"].Value.ToString();
				
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
	}
}
