using ESProMeter.Extensions;
using ESProMeter.Services;
using System;
using System.Data;
using System.Windows.Forms;
using ESProMeter.Enums;
using ESProMeter.IVews;

namespace ESProMeter.Controllers
{
    public static class SiteController
    {
        public static void GetAllSitesByCustomer(this Form form,byte isActive, long customerId, out DataTable table)
        {
            AppService.SqlGetInstance.UseProcedure("[SITE_sp_SELECT_BY_CUSTOMER]")
                        .SelectAsTable<dynamic>(new
                        {
                            @ISACTIVE = isActive,
                            @CUSTOMERID = customerId
                        }, out table);
        }
        public static void GetAllSites(this Form form,byte isActive,int perPage=50) 
        {
            var container = form.AsControl<DataGridView>("siteDataGrid");
            ((DataTable)container.DataSource)?.Rows.Clear();
            if (AppService.SiteGetInstance.GetAllSites(isActive, perPage, out var table))
            {
                container.DataSource = table;
            }
            else
            {
                container.DataSource = "";
            }
        }
        public static void FillSitesCmb(this Form form, ComboBox constainer)
        {
            ((DataTable)constainer.DataSource)?.Rows.Clear();
            if (AppService.SiteGetInstance.GetAllSites(1, out var table))
            {
                constainer.DataSource = table;
                constainer.DisplayMember = "SITENAME";
                constainer.ValueMember = "ID";
                constainer.SelectedIndex = -1;
            }
        }
        public static void FillSitesCmbByCustomer(this Form form,long customerId, ComboBox constainer)
        {
            ((DataTable)constainer.DataSource)?.Rows.Clear();
            if (AppService.SiteGetInstance.GetAllSitesByCustomer(1,customerId, out var table))
            {
                constainer.DataSource = table;
                constainer.DisplayMember = "SITENAME";
                constainer.ValueMember = "ID";
                constainer.SelectedIndex = -1;
            }
        }
        public static void SiteCreateNewOrUpdate(this Form form,ITSite site,ITAddressInfo tAddress, ActionType actionType=ActionType.CREATE)
        {
            switch (actionType)
            {
                case ActionType.CREATE:
                    AppService.SiteGetInstance.SiteCreate(site,tAddress);
                    break;
                case ActionType.EDIT:
                    AppService.SiteGetInstance.SiteUpdate(site,tAddress);
                    break;
                default:break;
            }
        }

        public static bool SiteCreateNewOrUpdate(this Form form, Views.Sites.AddSiteFrm data,out long id)
        {
            id = 0;  
            AppService.SiteGetInstance.SiteCreate(data, data,out id);
            return id > 0;
        }
        public static void ShowFormSiteUpdate(this Form form,ITSite site,ITAddressInfo tAddress, long siteId)
        {
            try
            {
               AppService.SiteGetInstance.ShowSiteForUpdate(site,tAddress,siteId);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
       
        public static bool DeleteSite(this Form form,long siteId)
        {
            try
            {
                if (AppService.SiteGetInstance.IsSiteAlreadyInUsed(siteId))
                {
                    throw new Exception("This Site Already In Used.");
                }
                return AppService.SiteGetInstance.SiteDelete(siteId)>0;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public static bool IsSiteExist(this Form form, string name)
        {
            try
            {

                return AppService.SiteGetInstance
                                    .IsSiteExist(name);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static bool IsSiteExistsame(this Form form,string name, long siteId)
        {
            try
            {

                return AppService.SiteGetInstance
                                    .IsSiteExistsame(name, siteId);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public static bool MakeSiteActiveOrInactive(this Form form, long siteId,byte isActive)
        {
            try
            {
               return AppService.SiteGetInstance
                                    .MakeSiteActiveOrInactive(siteId,isActive);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}

//public static void SiteCreateNewOrUdate(this Form form)
//{
//    var textName = form.AsTextBox("textName").Text;
//    var textAddress = form.AsTextBox("textAddress").Text;
//    var textCity = form.AsTextBox("textCity").Text;
//    var textCountry = form.AsTextBox("textCountry").Text;
//    var longCustomerId = form.AsCombobox("textCustomerID").AsNumber<long>(true);
//    var boolInactive = form.AsCheckedBox("checkInactive").Checked ? 0 : 1;
//    var longSiteId = form.AsLabel("longSiteID").AsNumber<long>();
//    var longAddrRefId = form.AsLabel("longAddrRefId").AsNumber<long>();
//    var intEditSequense = form.AsLabel("intEditSequense").AsNumber<int>();
//    var textDescription = form.AsTextBox("textDescription").Text;
//    if (longAddrRefId == 0 && longSiteId == 0)
//    {
//        instance.StartTransaction();
//        int addrId = instance.UseProcedure(AppConstants.AddressCreate)
//          .InsertGetId(new
//          {
//              address = textAddress,
//              city = textCity,
//              province = textCity,
//              country = textCountry
//          });
//        instance.UseProcedure(AppConstants.SiteCreateNew)
//               .InsertOrUpdate(new
//               {
//                   Name = textName,
//                   Description = textDescription,
//                   CustRefId = longCustomerId,
//                   AddrRefId = addrId,
//                   IsActive = boolInactive,
//               });
//        instance.Complete();
//    }
//    else
//    {
//        instance.StartTransaction();
//        instance.UseProcedure(AppConstants.AddressUpdate)
//          .Update(new
//          {
//              addrId = longAddrRefId,
//              EditSequense = intEditSequense,
//              address = textAddress,
//              city = textCity,
//              province = textCity,
//              country = textCountry
//          });
//        instance.UseProcedure(AppConstants.SiteUpdate)
//               .Update(new
//               {
//                   siteId = longSiteId,
//                   Name = textName,
//                   Description = textDescription,
//                   CustRefId = longCustomerId,
//                   AddrRefId = longAddrRefId,
//                   IsActive = boolInactive,
//               });
//        instance.Complete();
//    }
//}
//public static void ShowFormUpdate(this Form form)
//{
//    var textName = form.AsTextBox("textName").Text;
//    var textAddress = form.AsTextBox("textAddress").Text;
//    var textCity = form.AsTextBox("textCity").Text;
//    var textCountry = form.AsTextBox("textCountry").Text;
//    var longCustomerId = form.AsCombobox("textCustomerID").AsNumber<long>(true);
//    var boolInactive = form.AsCheckedBox("checkInactive").Checked ? 1 : 0;
//    var data = instance.UseSql("SELECT Name FROM customer;")
//                    .Where(new { })
//                    .First();
//    form.AsTextBox("textName").SetText(data, "Name");

//}