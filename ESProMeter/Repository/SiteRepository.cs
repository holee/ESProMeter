using ESProMeter.Extensions;
using ESProMeter.IVews;
using ESProMeter.Services;
using System;
using System.Data;
namespace ESProMeter.Repository
{
    public class SiteRepository
    {
        /// <summary>
        /// GET
        /// </summary>
        /// <param name="isActive"></param>
        /// <param name="perPage"></param>
        /// <param name="table"></param>
        /// <returns></returns>
        public bool GetAllSites(byte isActive,int perPage,out DataTable table)
        {
            return AppService.SqlGetInstance.UseProcedure("[SITE_sp_SELECT_ALL]")
                        .FindAsTable<dynamic>(new 
                        {
                            @ISACTIVE= isActive,
                            @PERPAGE= perPage
                        }, out table);

        }
        public bool GetAllSites(byte isActive, out DataTable table)
        {
            return AppService.SqlGetInstance.UseProcedure("[SITE_sp_SELECT_ALL]")
                        .FindAsTable<dynamic>(new
                        {
                            @ISACTIVE = isActive,
                            @PERPAGE = 1000
                        }, out table);

        }
        
        public bool GetAllSitesByCustomer(byte isActive,long Id,out DataTable table)
        {
            return AppService.SqlGetInstance.UseProcedure("[SITE_sp_SELECT_BY_CUSTOMER]")
                        .FindAsTable<dynamic>(new
                        {
                            @ISACTIVE = isActive,
                            @CUSTOMERID=Id
                        }, out table);
        }



        /// <summary>
        /// Create Update and Delete
        /// </summary>
        /// <param name="site"></param>
        /// <param name="address"></param>
        /// <param name="id"></param>
        /// <exception cref="Exception"></exception>
        public void SiteCreate(ITSite site, ITAddressInfo address,out long id)
        {
            AppService.SqlGetInstance.StartTransaction();
            id = 0;
            try
            {
                var addressId = AppService.SqlGetInstance.UseProcedure("ADDRESS_sp_INSERT")
                                        .InsertGetId<long, dynamic>(new
                                        {
                                            address.ADDRESS,
                                            address.PROVINCE,
                                            address.COUNTRY
                                        });

                site.ADDRESSID = addressId;
                id=AppService.SqlGetInstance.UseProcedure("SITE_sp_INSERT")
                           .InsertGetId<long,dynamic>(new
                           {
                               site.SITENAME,
                               site.ADDRESSID,
                               site.DESCRIPTION,
                               site.CUSTOMERID,
                           });
                AppService.SqlGetInstance.ComitTransaction();
            }
            catch (Exception ex)
            {
                AppService.SqlGetInstance.RollbackTransaction();
                throw new Exception(ex.Message);
            }

        }
        public void SiteCreate(ITSite site,ITAddressInfo address)
        {
            AppService.SqlGetInstance.StartTransaction();
            try
            {
                var addressId= AppService.SqlGetInstance.UseProcedure("ADDRESS_sp_INSERT")
                                        .InsertGetId<long,dynamic>(new
                                        {
                                            address.ADDRESS,
                                            address.PROVINCE,
                                            address.COUNTRY
                                        });

                site.ADDRESSID = addressId;

                AppService.SqlGetInstance.UseProcedure("SITE_sp_INSERT")
                           .InsertOrUpdate<dynamic>(new
                           {
                               site.SITENAME,
                               site.ADDRESSID,
                               site.DESCRIPTION,
                               site.CUSTOMERID,
                           });
                AppService.SqlGetInstance.ComitTransaction();
            }
            catch (Exception ex)
            {
                AppService.SqlGetInstance.RollbackTransaction();
                throw new Exception(ex.Message);
            }

        }
        public  void SiteUpdate(ITSite site,ITAddressInfo address)
        {
            AppService.SqlGetInstance.StartTransaction();
            try
            {
                AppService.SqlGetInstance.UseProcedure("ADDRESS_sp_UPDATE")
                                        .InsertOrUpdate<dynamic>(new
                                        {
                                            address.ID,
                                            address.ADDRESS,
                                            address.PROVINCE,
                                            address.COUNTRY
                                        });
                AppService.SqlGetInstance.UseProcedure("SITE_sp_UPDATE")
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
                AppService.SqlGetInstance.ComitTransaction();
            }
            catch (Exception ex)
            {
                AppService.SqlGetInstance.RollbackTransaction();
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
