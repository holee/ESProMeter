using ESProMeter.DataAccess;
using ESProMeter.Extensions;
using ESProMeter.IVews;
using ESProMeter.Services;
using System;
using System.Data;

namespace ESProMeter.Repository
{
    public class UomRepository
    {
        public bool GetAllUoms(byte isActive,out DataTable table)
        {
            return AppService.SqlGetInstance.UseProcedure($"UOM_sp_SELECT_ALL").FindAsTable<dynamic>(new
            {
                isAct = isActive,
            }, out table);
        }
        public bool GetAllUoms(byte isActive,int PerPage, out DataTable table)
        {
            return AppService.SqlGetInstance.UseProcedure($"UOM_sp_SELECT_ALL_PAGES").FindAsTable<dynamic>(new 
            { 
                isAct = isActive,
                PerPage= PerPage
            }, out table);
        }
        public bool GetAllUOMTypes(out DataTable table)
        {
            return AppService.SqlGetInstance.UseProcedure($"UOMTYPE_SP_SELECT_ALL").FindAsTable<dynamic>(null, out table);
        }
        public void UomCreate(ITUom uom)
        {
            if (this.CheckUomExist(uom.UOMNAME))
            {
                throw new Exception("UOM NAME Already Exist in Database.");
            }
            else
            {
                AppService.SqlGetInstance.UseProcedure("UOM_sp_CreateNew")
                        .InsertOrUpdate<dynamic>(new
                        {
                            uom.UOMNAME,
                            uom.ABBREVIATION,
                            uom.TYPE
                        });
            }
        }
        public void UomUpdate(ITUom uom)
        {
            if (CheckUomExistWithSame(uom.UOMNAME, uom.ID)){
                throw new Exception("UOM NAME Already Exist.");
            }
            else
            {
                AppService.SqlGetInstance.UseProcedure("UOM_sp_EDIT")
                        .InsertOrUpdate<dynamic>(new
                        {
                            uom.ID,
                            uom.EDSEQ,
                            uom.ISACTIVE,
                            uom.UOMNAME,
                            uom.ABBREVIATION,
                            uom.TYPE
                        });
            }
        }
        public bool CheckUomExist(string name)
        {
            return AppService.SqlGetInstance.UseProcedure("UOM_sp_CHECKEDUOMNAME_EXIST").Exist(new
            {
                UOMNAME = name
            });
        }
        public bool IsUomAlreadyUsed(long uomId) 
        {
            return AppService.SqlGetInstance.UseSql("SELECT COUNT(*) FROM VItem WHERE UOMID=@UOMID").Exist(new
            {
                @UOMID = uomId
            });
        }
        public bool CheckUomExistWithSame(string name, long UomId)
        {
            return AppService.SqlGetInstance.UseProcedure("UOM_sp_CHECKEDUOMNAME_EXIST_WITHID").Count<int, dynamic>(new
            {
                UOMNAME = name,
                ID = UomId
            }) > 0;
        }
        
        public void ShowUomFormForUpdate(ITUom uom, long id)
        {
            try
            {
                if (AppService.SqlGetInstance.UseProcedure("UOM_sp_SELECT_BYID").FindOne<dynamic>(new
                {
                    ID = id
                }, out var row))
                {
                    uom.ID = row.GetValue<long>("ID");
                    uom.UOMNAME = row.GetValue<string>("UOMNAME");
                    uom.ABBREVIATION = row.GetValue<string>("ABBREVIATION");
                    uom.EDSEQ = row.GetValue<int>("EDSEQ");
                    uom.TYPE = row.GetValue<string>("TYPE");
                    uom.ISACTIVE = row.GetValue<byte>("ISACTIVE");
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public bool Delete(long id)
        {
            try
            {
              
               var deletedRow= AppService.SqlGetInstance.UseProcedure("UOM_sp_DELETE").Delete<dynamic>(new { @ID=id });
                return deletedRow > 0;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public bool MakeInactive(long id, byte isActive = 0)
        {
            try
            {
                var rowsAffected = AppService.SqlGetInstance.UseProcedure("[UOM_sp_MAKEINACTIVE]")
                                            .InsertOrUpdate<dynamic>(new { @ID=id, @ISACTIVE=isActive });
                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                throw;
            }
        }





    }
}
