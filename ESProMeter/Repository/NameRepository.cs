using ESProMeter.Extensions;
using ESProMeter.IVews;
using ESProMeter.Services;
using System.Data;
namespace ESProMeter.Repository
{
    public class NameRepository
    {
        public bool GetAllCustomers(byte isActive,out DataTable table)
        {
            return AppService.SqlGetInstance
                                .UseProcedure("NAME_sp_SELECT")
                                .FindAsTable<dynamic>(new { @ISACTIVE= isActive },out table);
        }
        public bool CustomersCenter(string nameType, byte isActive, out DataTable table) 
        {
            try
            {
                return AppService.SqlGetInstance
                                     .UseProcedure("NAME_sp_SELECT")
                                     .FindAsTable<dynamic>(new
                                     {
                                         @NAMETYPE =nameType,
                                         @ISACTIVE = isActive
                                     }, out table);
            }
            catch
            {
                throw;
            }
        }
        public bool CustomersCenter(string nameType, byte isActive,string custmerName, out DataTable table)
        {
            try
            {
                return AppService.SqlGetInstance
                                     .UseProcedure("NAME_sp_SELECT")
                                     .FindAsTable<dynamic>(new
                                     {
                                         @CustmerName= custmerName,
                                         @NAMETYPE = nameType,
                                         @ISACTIVE = isActive
                                     }, out table);
            }
            catch
            {
                throw;
            }
        }
        public void GetAllCustomerById(ITName model,long nameId,byte isActive=1)
        {
            if (AppService.SqlGetInstance
                                .UseProcedure("NAME_sp_SELECT_BY_ID")
                                .FindOne<dynamic>(new { @ID = nameId, @ISACTIVE = isActive }, out var row))
            {
                model.NAME = row.GetValue<string>("NAME");
                model.NAMETYPE = row.GetValue<string>("NAMETYPE");
                model.SALUTATION = row.GetValue<string>("SALUTATION");
                model.FIRSTNAME = row.GetValue<string>("FIRSTNAME");
                model.LASTNAME = row.GetValue<string>("LASTNAME");
                model.JOBTITLE = row.GetValue<string>("JOBTITLE");
                model.ADDRESSID = row.GetValue<long>("ADDRESSID");
                model.MAINPHONE = row.GetValue<string>("MAINPHONE");
                model.ALTPHONE = row.GetValue<string>("ALTPHONE");
                model.FAX = row.GetValue<string>("FAX");
                model.EMAIL = row.GetValue<string>("EMAIL");
                model.WEBSITE = row.GetValue<string>("WEBSITE");
                model.CREDITLIMIT = row.GetValue<decimal>("CREDITLIMIT");
                model.EDSEQ = row.GetValue<int>("EDSEQ");
                model.ISACTIVE = row.GetValue<byte>("ISACTIVE");
                model.ID = row.GetValue<long>("ID");
                model.PROVINCE = row.GetValue<string>("PROVINCE");
                model.COUNTRY = row.GetValue<string>("COUNTRY");
                model.ADDRESS = row.GetValue<string>("ADDRESS");
            }
        }
        public bool GetCustomersByName(byte isActive,string customerName, out DataTable table)
        {
            return AppService.SqlGetInstance
                                .UseProcedure("NAME_sp_SELECT_BY_NAME")
                                .FindAsTable<dynamic>(new 
                                {
                                    @Name = customerName,
                                    @NAMETYPE = "customer",
                                    @ISACTIVE = isActive
                                }, out table);
        }
        /// <summary>
        /// Create Update And Delete
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public int CustomerCreate(ITName model)
        {
            AppService.SqlGetInstance.StartTransaction();
            try
            {
                var addressId = AppService.AddressGetInstance.AddressCreate(model);
                model.ADDRESSID = addressId;
                var affectedRows=AppService.SqlGetInstance
                                    .UseProcedure("[NAME_sp_INSERT]")
                                    .InsertOrUpdate<dynamic>(new 
                                    {
                                        model.NAME      ,
                                        model.NAMETYPE    ,
                                        model.SALUTATION  ,
                                        model.FIRSTNAME   ,
                                        model.LASTNAME   ,
                                        model.JOBTITLE  ,
                                        model.ADDRESSID ,
                                        model.MAINPHONE ,
                                        model.ALTPHONE ,
                                        model.FAX,
                                        model.EMAIL,
                                        model.WEBSITE,
                                        model.CREDITLIMIT ,
                                    });
                AppService.SqlGetInstance.ComitTransaction();
                return affectedRows;
            }
            catch
            {
                AppService.SqlGetInstance.RollbackTransaction();
                return 0;
            }
            
        }

        public bool CustomerCreate(ITName model,out long customerId)
        {
            AppService.SqlGetInstance.StartTransaction();
            customerId = 0;
            try
            {
                var addressId = AppService.AddressGetInstance.AddressCreate(model);
                model.ADDRESSID = addressId;
                customerId = AppService.SqlGetInstance
                                    .UseProcedure("[NAME_sp_INSERT]")
                                    .InsertGetId<long,dynamic>(new
                                    {
                                        model.NAME, 
                                        model.NAMETYPE,
                                        model.SALUTATION,
                                        model.FIRSTNAME,
                                        model.LASTNAME,
                                        model.JOBTITLE,
                                        model.ADDRESSID,
                                        model.MAINPHONE,
                                        model.ALTPHONE,
                                        model.FAX,
                                        model.EMAIL,
                                        model.WEBSITE,
                                        model.CREDITLIMIT,
                                    });
                AppService.SqlGetInstance.ComitTransaction();
                return customerId > 0;
               
            }
            catch
            {
                AppService.SqlGetInstance.RollbackTransaction();
                return false;
            }

        }

        public int CustomerUpdate(ITName model)
        {
            AppService.SqlGetInstance.StartTransaction();
            try
            {
                AppService.AddressGetInstance.AddressUpdate(new Models.TAddressInfo
                {
                    ID=model.ADDRESSID,
                    ADDRESS=model.ADDRESS,
                    PROVINCE=model.PROVINCE,
                    COUNTRY=model.COUNTRY
                });
                var affectedRows = AppService.SqlGetInstance 
                                    .UseProcedure("NAME_sp_UPDATE")
                                    .InsertOrUpdate<dynamic>(new {
                                        model.ID,
                                        model.EDSEQ,
                                        model.NAME,
                                        model.NAMETYPE,
                                        model.SALUTATION,
                                        model.FIRSTNAME,
                                        model.LASTNAME,
                                        model.JOBTITLE,
                                        model.MAINPHONE,
                                        model.ALTPHONE,
                                        model.FAX,
                                        model.EMAIL,
                                        model.WEBSITE,
                                        model.CREDITLIMIT,
                                        model.ISACTIVE
                                    });
                AppService.SqlGetInstance.ComitTransaction();
                return affectedRows;
            }
            catch
            {
                AppService.SqlGetInstance.RollbackTransaction();
                return 0;
            }

        }
        public int CustomerDelete(long nameId,long addressID)
        {
            try
            {
                var affectedRows = AppService.SqlGetInstance
                                    .UseProcedure("[NAME_sp_DELETE]")
                                    .Delete<dynamic>(new { ID=nameId,ADDRESSID=addressID });
                return affectedRows;
            }
            catch
            {
                return 0;
            }

        }
        public int CustomerInActiveOrActive(long nameId,byte isInactive) 
        {
            try
            {
                var affectedRows = AppService.SqlGetInstance
                                    .UseProcedure("[NAME_sp_INACTIVEORACTIVE]")
                                    .InsertOrUpdate<dynamic>(new { ID=nameId,ISACTIVE=isInactive });
                return affectedRows;
            }
            catch
            {
                return 0;
            }

        }

    }
}
