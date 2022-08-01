using ESProMeter.Services;
using ESProMeter.Extensions;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using ESProMeter.Views.Companies;

namespace ESProMeter.Controllers
{
    public static class CompanyController
    {
        public static void UpdateCompany(this Form form, CompanyInfoFrm com)
        {
            try
            {
                AppService.GetCompanyInstance.UpdateCompany(com);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static void ShowCompanyInformation(this Form form,CompanyInfoFrm com)
        {

            try
            {
                AppService.GetCompanyInstance.ShowCompanyInformation(com);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }




    }
}
