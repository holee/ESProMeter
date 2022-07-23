using ESProMeter.DataAccess;
using ESProMeter.Extensions;
using ESProMeter.IVews;
using ESProMeter.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESProMeter.Repository
{
    public class UomRepository
    {
        private static readonly SqlAccess instance = DataUtility.GetInstance;
        public bool GetAllUoms(byte isActive,out DataTable table)
        {
            return instance.UseProcedure($"UOM_sp_SELECT_ALL").FindAsTable<dynamic>(new
            {
                isAct = isActive,
            }, out table);
        }
        public bool GetAllUoms(byte isActive,int PerPage, out DataTable table)
        {
            return instance.UseProcedure($"UOM_sp_SELECT_ALL").FindAsTable<dynamic>(new 
            { 
                isAct = isActive,
                PerPage= PerPage
            }, out table);
        }
        public bool GetAllUOMTypes(out DataTable table)
        {
            return instance.UseProcedure($"UOMTYPE_SP_SELECT_ALL").FindAsTable<dynamic>(null, out table);
        }
        public void UomCreate(ITUom uom)
        {
            if (this.CheckUomExist(uom.UOMNAME))
            {
                throw new Exception("UOM NAME Already Exist in Database.");
            }
            else
            {
                instance.UseProcedure("UOM_sp_CreateNew")
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
                instance.UseProcedure("UOM_sp_EDIT")
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
            return instance.UseProcedure("UOM_sp_CHECKEDUOMNAME_EXIST").Exist(new
            {
                UOMNAME = name
            });
        }
        public bool CheckUomExistWithSame(string name, long UomId)
        {
            return instance.UseProcedure("UOM_sp_CHECKEDUOMNAME_EXIST_WITHID").Count<int, dynamic>(new
            {
                UOMNAME = name,
                ID = UomId
            }) > 0;
        }
        
        public void ShowUomFormForUpdate(ITUom uom, long id)
        {
            try
            {
                if (instance.UseProcedure("UOM_sp_SELECT_BYID").FindOne<dynamic>(new
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
               var deletedRow=instance.UseProcedure("UOM_sp_DELETE").Delete<dynamic>(new { @ID=id });
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
                var rowsAffected = instance.UseProcedure("[UOM_sp_MAKEINACTIVE]")
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
