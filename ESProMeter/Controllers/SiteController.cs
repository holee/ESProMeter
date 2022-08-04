using Dapper;
using ESProMeter.Extensions;
using ESProMeter.Models;
using ESProMeter.Services;
using ESProMeter.IViews;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using ESProMeter.DataAccess;
using ESProMeter.Enums;
using ESProMeter.IVews;

namespace ESProMeter.Controllers
{
    public static class SiteController
    {
        public static void GetAllSites(this Form form,byte isActive,int perPage=50) 
        {
            var container = form.AsControl<DataGridView>("siteDataGrid");
            if (AppService.SiteGetInstance.GetAllSites(isActive, perPage, out var table))
            {
                container.DataSource = table;
            }
            else
            {
                container.DataSource = "";
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