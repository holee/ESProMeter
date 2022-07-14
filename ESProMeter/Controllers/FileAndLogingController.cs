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

namespace ESProMeter.Controllers
{
	public static class FileAndLogingController
	{
		public static bool loadActivedCompanyList(this Form form)
		{
			if (SysDbUtility.GetInstance.GetCompanies(out DataTable dtCompList))
			{
				form.AsDataGrid("dtgCompanyList").DataSource = dtCompList;
				return true;
			}
			return false;
		}

	}
}
