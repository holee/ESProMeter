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

namespace ESProMeter.Controllers
{
    public static class SiteController
    {
        private static readonly SqlAccess instance = DataUtility.GetInstance;
        public static bool GetAllSite(out DataTable table,params string[] columns)
        {
            string sql = columns.Length == 0 ? "*" : string.Join(",", columns);
            var sql1 = $"SELECT {sql} FROM [dbo].[Site];";
            if(instance.UseSql(sql1).FindAsTable<dynamic?>(null,out table))
            {
                return true;
            }
            return true;

        }


        public static void SiteCreateNewOrUpdate(this Form form,ISite site)
        {
            if (site.SiteID == 0 && site.AddressRefId == 0)
            {
                SiteUpdate(site);
            }
            else
            {
                CreateNewSite(site);
            }
        }



        private static void CreateNewSite(ISite site) 
        {
            instance.StartTransaction();
            instance.UseProcedure("")
              .InsertOrUpdate(new AddressUpdateDto
              {
                  AddrID = site.AddressRefId,
                  Address = site.Address,
                  City = site.City,
                  Country = site.Country,
                  Province = site.Province,
                  EditSequense = site.EditSequense
              });
            instance.UseProcedure("")
                   .InsertOrUpdate(new SiteUpdateDto
                   {
                       SiteId = site.SiteID,
                       Name = site.SiteName,
                       Description = site.Description,
                       AddrRefID = site.AddressRefId,
                       CustRefID = site.CustomerRefId,
                       IsActive = site.IsActive
                   });
            instance.ComitTransaction();
        }
        private static void SiteUpdate(ISite site)
        {
            instance.StartTransaction();
            int addrId = instance.UseProcedure("")
              .InserGetId<int,dynamic>(new { site.Address, site.City, site.Country, site.Province });
            instance.UseProcedure("")
                   .InsertOrUpdate(new SiteUpdateDto
                   {
                       SiteId = site.SiteID,
                       Name = site.SiteName,
                       Description = site.Description,
                       AddrRefID = addrId,
                       CustRefID = site.CustomerRefId,
                       IsActive = site.IsActive
                   });

            instance.ComitTransaction();

        }
        public static void ShowCustomerForUpdate(this Form form) 
        {
            try
            {
                instance.UseSql("SELECT custID, Name FROM customer;")
                          .FindAsTable<dynamic?>(null)
                          .AsCombobox(form.AsCombobox("textCustomerID"), "Name", "CustID");
                form.AsCombobox("textCustomerID").Text = String.Empty;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public static void ShowFormSiteUpdate(this Form form,ISite site, long siteId)
        {
            try
            {
                //instance.UseSql("SELECT custID, Name FROM customer;")
                //           .Where(null)
                //           .Gets()
                //           .AsCombobox(form.AsCombobox("textCustomerID"), "Name", "CustID");
                //var data = instance.UseSql(AppConstants.SiteSelect)
                //       .Where(new { siteId = siteId })
                //       .Select<Site>();
                using (IDbConnection con = new SqlConnection(ConnectionService.GetConnectionString))
                {
                    var sql = @"SELECT s.SiteId,s.Name As SiteName,s.IsActive,s.Description,c.CustID AS CustomerID,c.Name,a.AddrID,a.Country,a.City,a.Address,a.EditSequense FROM Site s
                                                INNER JOIN [Customer] c ON s.CustRefID=c.CustID
                                                INNER JOIN AddressInfo a ON a.AddrID=s.AddrRefID
                                                WHERE siteId=@siteId";

                    var result = con.Query<Site, Customer, AddressInfo, Site>(sql, (s, c, a) =>
                      {
                          s.Customer = c;
                          s.AddressInfo = a;
                          return s;
                      }, new { siteId = siteId },
                     splitOn: "CustomerID,AddrID").FirstOrDefault();
                    site.SiteName = result.SiteName;
                    site.CustomerRefId = result.Customer.CustID;
                    site.IsActive = !result.IsActive;
                    site.Description = result.Description;
                    site.Address = result.AddressInfo.Address;
                    site.Country = result.AddressInfo.Country;
                    site.City = result.AddressInfo.City;
                    site.AddressRefId = result.AddressInfo.AddrID;
                    site.SiteID = result.SiteID;
                    site.EditSequense = result.AddressInfo.AddressEditSequense;
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static void ShowSiteOnDataGridView(this Form form,bool IncludeInActive)
        {
            try
            {
                //if (IncludeInActive)
                //{
                //    instance.UseSql(AppConstants.SiteSelectAll)
                //                    .Where(null)
                //                    .Gets()
                //                    .AsDataGrid(form.AsDataGrid("siteDataGrid"));
                //}
                //else
                //{
                //    instance.UseSql(AppConstants.SiteSelects)
                //                    .Where(new { IsActive = true })
                //                    .Gets()
                //                    .AsDataGrid(form.AsDataGrid("siteDataGrid"));
                //}
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static void DeleteSite(this Form form,long siteId)
        {
            try
            {

                //if (instance.UseSql("DELETE FROM [SITE] WHERE siteId=@siteId;")
                //    .Where(new { siteId = siteId })
                //    .Delete() > 0)
                //{
                //    var index = form.AsDataGrid("siteDataGrid").CurrentCell.RowIndex;
                //    form.AsDataGrid("siteDataGrid").Rows.RemoveAt(index); 
                //}

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static bool IsSiteExist(this Form form, string name)
        {
            try
            {

                //if (instance.UseSql("SELECT COUNT(*) FROM [SITE] WHERE Name=@name;")
                //    .Where(new { name = @name})
                //    .Count() > 0)
                //{
                //    return true;
                //}
                return false;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static bool IsSiteExistsame(this Form form,string name, long siteId)
        {
            try
            {

                //if (instance.UseSql("SELECT COUNT(*) FROM [SITE] WHERE Name=@name AND SiteID <> @siteId;")
                //    .Where(new { name = @name,SiteId=siteId })
                //    .Count() > 0)
                //{
                //    return true;
                //}
                return false;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static void MakeSiteActiveOrInactive(this Form form, long siteId)
        {
            try
            {
                //var index = form.AsDataGrid("siteDataGrid").CurrentCell.RowIndex;
                //var boolActive=form.AsDataGrid("siteDataGrid").AsNumber<int>("Column7") ==0?1:0;
                //if (instance.UseSql("UPDATE [SITE] SET IsAcTive=@isActive WHERE siteId=@siteId;")
                //    .Update(new {
                //        IsActive=boolActive,
                //        siteId=siteId
                //     }) > 0)
                //{
                //    form.AsDataGrid("siteDataGrid").SetText("Column7", boolActive);
                //}

            }
            catch (Exception ex)
            {
                throw ex;
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