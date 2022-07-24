using ESProMeter.DataAccess;
using ESProMeter.Extensions;
using ESProMeter.IVews;
using ESProMeter.Services;
using System;
using System.Data;
using System.Linq;

namespace ESProMeter.Repository
{
    public class SiteRepository
    {
        private static readonly SqlAccess instance = DataUtility.GetInstance;
        public bool GetAllSites(byte isActive,int perPage,out DataTable table)
        {
            return instance.UseProcedure("[SITE_sp_SELECT_ALL]")
                        .FindAsTable<dynamic>(new 
                        {
                            @ISACTIVE= isActive,
                            @PERPAGE= perPage
                        }, out table);

        }
        public void SiteCreate(ITSite site,ITAddressInfo address)
        {
            instance.StartTransaction();
            try
            {
                var addressId=instance.UseProcedure("ADDRESS_sp_INSERT")
                                        .InsertGetId<long,dynamic>(new
                                        {
                                            address.ADDRESS,
                                            address.PROVINCE,
                                            address.COUNTRY
                                        });

                site.ADDRESSID = addressId;

                instance.UseProcedure("SITE_sp_INSERT")
                           .InsertOrUpdate<dynamic>(new
                           {
                               site.SITENAME,
                               site.ADDRESSID,
                               site.DESCRIPTION,
                               site.CUSTOMERID,
                           });
                instance.ComitTransaction();
            }
            catch (Exception ex)
            {
                instance.RollbackTransaction();
                throw new Exception(ex.Message);
            }

        }
        public  void SiteUpdate(ITSite site,ITAddressInfo address)
        {
            instance.StartTransaction();
            try
            {
                instance.UseProcedure("ADDRESS_sp_UPDATE")
                                        .InsertOrUpdate<dynamic>(new
                                        {
                                            address.ID,
                                            address.ADDRESS,
                                            address.PROVINCE,
                                            address.COUNTRY
                                        });
                instance.UseProcedure("SITE_sp_UPDATE")
                           .InsertOrUpdate<dynamic>(new
                           {
                               site.ID,
                               site.SITENAME,
                               site.ADDRESSID,
                               site.DESCRIPTION,
                               site.CUSTOMERID,
                               site.ISACTIVE,
                               site.EDSEQ
                           });
                instance.ComitTransaction();
            }
            catch (Exception ex)
            {
                instance.RollbackTransaction();
                throw new Exception(ex.Message);
            }

        }
        public int SiteDelete(long id)
        {
            try
            {
                return AppService.SqlGetInstance
                                    .UseProcedure("SITE_sp_DELETE")
                                     .Delete<dynamic>(new
                                     {
                                         ID=id
                                     });

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public void ShowSiteForUpdate(ITSite site,ITAddressInfo tAddress, long siteId)
        {
            try
            {
                if(AppService.SqlGetInstance.UseProcedure("SITE_sp_SELECTED_BY_ID")
                           .FindOne<dynamic>(new { ID = siteId }, out var row))

                {
                    site.ID = row.GetValue<long>("ID");
                    site.CUSTOMERID= row.GetValue<long>("CUSTOMERID");
                    site.SITENAME = row.GetValue<string>("SITENAME");
                    site.DESCRIPTION = row.GetValue<string>("DESCRIPTION");
                    site.ADDRESSID= row.GetValue<long>("ADDRESSID");
                    site.ISACTIVE= row.GetValue<byte>("ISACTIVE");
                    site.EDSEQ= row.GetValue<int>("EDSEQ");
                    tAddress.ID = site.ADDRESSID;
                    tAddress.PROVINCE= row.GetValue<string>("PROVINCE"); 
                    tAddress.COUNTRY= row.GetValue<string>("COUNTRY");
                    tAddress.ADDRESS= row.GetValue<string>("ADDRESS");
                }
               
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public  bool IsSiteExist(string name)
        {
            try
            {

                if (AppService.SqlGetInstance.UseSql("SELECT COUNT(*) FROM [TSITE] WHERE SITENAME=@SiteName;")
                    .Count<int,dynamic>(new {
                        SiteName=name
                    }) > 0)
                {
                    return true;
                }
                return false;

            }
            catch
            {
                throw ;
            }
        }

        public  bool IsSiteExistsame(string name, long siteId)
        {
            try
            {

                return AppService.SqlGetInstance
                                    .UseSql("SELECT COUNT(*) FROM [TSITE] WHERE SITENAME=@name AND ID <> @siteId;")
                                        .Count<int,dynamic>(new { name = @name, SiteId = siteId })> 0;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public bool MakeSiteActiveOrInactive(long siteId,byte isActive)
        {
            try
            {
                return AppService.SqlGetInstance
                                    .UseSql("UPDATE [TSITE] SET IsAcTive=@isActive WHERE ID=@ID;")
                                        .InsertOrUpdate(new
                                        {
                                            isActive = isActive,
                                            ID = siteId
                                        }) > 0;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }



    }
}
