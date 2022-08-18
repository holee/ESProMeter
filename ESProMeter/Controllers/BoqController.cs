﻿using ESProMeter.Extensions;
using ESProMeter.IViews;
using ESProMeter.Services;
using ESProMeter.Views.Boq;
using System.Windows.Forms;

namespace ESProMeter.Controllers
{
    public static class BoqController
    {
        /// <summary>
        /// CREATE AND UPDATE
        /// </summary>
        /// <param name="form"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        public static bool BoqCreate(this Form form,CreateBoQ_Step1_Frm data)
        {
            return AppService.GetBoqInstance.BoqCreate(data);
        }
        public static bool BoqCreate(this Form form, ITBOQ data)
        {
            return AppService.GetBoqInstance.BoqCreate(data);
        }
        public static bool BoqUpdate(this Form form, CreateBoQ_Step1_Frm data) 
        {
            return AppService.GetBoqInstance.BoqUpdate(data);
        }
        public static bool BoqDelete(this Form form,long boq_id)
        {
            return AppService.GetBoqInstance.BoqDelete(boq_id);
        }
        public static bool BoqUpdate(this Form form, ITBOQ data)
        {
            return AppService.GetBoqInstance.BoqUpdate(data);
        }
        public static bool BoqCreate(this Form form, CreateBoQ_Step1_Frm data,out long id)
        {
            return AppService.GetBoqInstance.BoqCreate(data,out id);
        }

        public static void BoqGetById(this Form form,long id, CreateBoQ_Step2_Frm boqForm)
        {
            AppService.GetBoqInstance.BoqGetById(id, boqForm);
        }
        public static void BoqLineGetById(this Form form, long id,DataGridView container)
        {
            AppService.GetBoqInstance.BoqLineGetById(id,out var table);
            container.Rows?.Clear();
            table.UsePlainDataToGridView(container);
        }
        public static void BoqLineCreateOrUpdate(this Form form, DataGridView grid,Enums.ActionType type)
        {
            var table = grid.ToTable("BOQID", "BOQITEMID", "LineSeq", "NO", "BOQITEMDESC", "BOQITEMUOMID", "BOQITEMQTY",
              "REMARKS", "UID", "BOQCOST", "LOSSEFFECENCYRATE1", "OPERATIONRATE1", "OVERHEADRATE1", "SAFETYRATE1", "TRANSPORTATIONRATE1", "MARGINRATE1", "INFlATIONRATE1");
            switch (type)
            {
                case Enums.ActionType.CREATE:
                    AppService.GetBoqInstance.BoqLineCreate(table);
                    break;
                case Enums.ActionType.EDIT:
                    AppService.GetBoqInstance.BoqLineUpdate(table);
                    break;
                default:
                    break;
            }
            
        }
        public static void BoqLineCreate(this Form form,DataGridView grid)
        {
            var table = grid.ToTable("BOQID", "BOQITEMID", "LineSeq", "NO", "BOQITEMDESC", "BOQITEMUOMID", "BOQITEMQTY",
                "REMARKS", "UID", "BOQCOST", "LOSSEFFECENCYRATE1", "OPERATIONRATE1", "OVERHEADRATE1", "SAFETYRATE1", "TRANSPORTATIONRATE1", "MARGINRATE1", "INFlATIONRATE1");
            AppService.GetBoqInstance.BoqLineCreate(table);
        }
        public static void BoqLineUpdate(this Form form, DataGridView grid)
        {
            var table = grid.ToTable("BOQID", "BOQITEMID", "LineSeq", "NO", "BOQITEMDESC", "BOQITEMUOMID", "BOQITEMQTY",
                "REMARKS", "UID", "BOQCOST", "LOSSEFFECENCYRATE1", "OPERATIONRATE1", "OVERHEADRATE1", "SAFETYRATE1", "TRANSPORTATIONRATE1", "MARGINRATE1", "INFlATIONRATE1");
            AppService.GetBoqInstance.BoqLineUpdate(table);
        }
        public static void GetAdditionalCost(this Form form,DataGridView container)
        {
            AppService.GetBoqInstance
                            .GetAdditinalCost(out var table);
            table.UseDataTableAsGridView(container);
        }


    }
}

//public static void ShowAllBoqInfo(this Form form)
//{
//    var db = DataUtility.GetInstance;
//    if (SiteController.GetAllSite(out DataTable table, "SiteID", "Name"))
//    {
//        table.AsCombobox(form.AsControl<ComboBox>("cmbSite"), "Name", "SiteID");
//    }
//    if (DivisionController.GetAllDivision(out DataTable table1, "DivID", "Name"))
//    {
//        table1.AsCombobox(form.AsControl<ComboBox>("cmbDivision"), "Name", "DivID");
//    }

//    db.UseSql("SELECT CustID,Name FROM [dbo].[Customer] WHERE IsActive=1;")
//      .FindAsTable<dynamic?>(null)
//      .AsCombobox(form.AsControl<ComboBox>("cmbCustomerID"), "Name", "CustID");

//}
//public static void CreateNewBoq(this Form form, IBoq q)
//{
//    var db = DataUtility.GetInstance;
//    try
//    {
//        db.StartTransaction();
//        db.UseProcedure("BoqCreate")
//            .InserGetId<long, dynamic>(new
//            {
//                q.BOQNumber,
//                q.CustRefID,
//                q.Date,
//                q.RefNumber,
//                q.SiteRefListID,
//                q.DivRefListID,
//                q.ValidDate,
//                q.TermsCondition
//            });

//        db.ComitTransaction();
//    }
//    catch (Exception)
//    {
//        db.RollbackTransaction();

//    }

//}
//public static bool CreateNewBoq(this Form form, IBoq q, out long boqId)
//{
//    var db = DataUtility.GetInstance;
//    boqId = 0;
//    try
//    {
//        boqId = db.UseProcedure("BoqCreate")
//            .InserGetId<long, dynamic>(new
//            {
//                q.BOQNumber,
//                q.CustRefID,
//                q.Date,
//                q.RefNumber,
//                q.SiteRefListID,
//                q.DivRefListID,
//                q.ValidDate,
//                q.TermsCondition
//            });
//        return boqId > 0;
//    }
//    catch (Exception)
//    {
//        return false;
//    }


//}
//public static object[] GetItem(this Form form, decimal itemcode)
//{
//    var sql = "SELECT ItemID,Description,Abbreviation,UomID,Price FROM vItemWithUom WHERE ItemId=@itemId;";
//    if (DataUtility.GetInstance.UseSql(sql).FindOne<dynamic>(new { itemId = itemcode }, out DataRow row))
//    {
//        return row.ItemArray;
//    }
//    return default;
//}
//public static bool GetItem(this Form form, decimal itemcode, out Dictionary<string, object> result)
//{
//    var sql = "SELECT ItemID,Description,Abbreviation,UomID,Price FROM vItemWithUom WHERE ItemId=@itemId;";
//    result = new Dictionary<string, object>();
//    if (DataUtility.GetInstance.UseSql(sql).FindOne<dynamic>(new { itemId = itemcode }, out DataRow row))
//    {
//        int col = 0;
//        foreach (var item in row.ItemArray)
//        {
//            result.Add(row.Table.Columns[col].ColumnName, item);
//            col++;
//        }
//        return true;
//    }

//    return false;
//}
//public static (long itemId, string Description, string Abbr, long UomId,
//    decimal price, decimal qty, bool result) GetBoqItem(this Form form, long itemcode)
//{
//    var sql = "SELECT ItemID,Description,Abbreviation,UomID,Price FROM vBoqItem WHERE ItemId=@itemId;";
//    if (DataUtility.GetInstance.UseSql(sql).FindOne<dynamic>(new { itemId = itemcode }, out DataRow row))
//    {
//        return (
//             row.GetValue<long>("ItemID"),
//             row.GetValue<string>("Description"),
//             row.GetValue<string>("Abbreviation"),
//             row.GetValue<long>("UomID"),
//             row.GetValue<decimal>("Price"),
//             1,
//             true
//            );
//    }
//    return (
//             0,
//             null,
//             null,
//             0,
//             0,
//             0,
//             false
//            );
//}
//public static void CreateTempBoqLine(this Form form, object data)
//{
//    DataUtility.GetInstance
//          .UseProcedure("BoqLineTempCreate")
//          .InsertOrUpdate<dynamic>(data);
//}
//public static void CreateTempBoqLineDetail(this Form form, object data)
//{
//    DataUtility.GetInstance
//          .UseProcedure("BoqLineDetailTempCreate")
//          .InsertOrUpdate<dynamic>(data);
//}
//public static bool UpdateItemItemBoq(this Form form, long itemRefId, long itemItemRefId, string tempID, decimal value)
//{
//    var sql = "UPDATE BOQLineDetailTemp SET ItemItemAmount=@amount WHERE ItemRefID=@itemRefId AND ItemItemRefID=@itemItemRefId AND BoqRefTempId=@tempID;";
//    var data = new
//    {
//        itemRefId = itemRefId,
//        itemItemRefId = itemItemRefId,
//        tempID = tempID,
//        amount = value
//    };
//    return DataUtility.GetInstance
//          .UseSql(sql)
//          .InsertOrUpdate<dynamic>(data) > 0;
//}
//public static void DisplayBoqItemDetails(this Form form, string tempId)
//{
//    var sql = "SELECT * FROM vBoqLineTemp  WHERE BOQID=@tempID;";
//    var data = new
//    {
//        tempID = tempId,
//    };
//    DataUtility.GetInstance
//          .UseSql(sql)
//          .FindAsTable<dynamic>(data)
//          .AsDataGrid(form.AsControl<DataGridView>("dataGridView1"));
//}
//public static void CreateBoqDetail(this Form form, string tempId, long itemRefId, long boqLineRefId)
//{
//    DataUtility.GetInstance.StartTransaction();
//    try
//    {
//        var data = new
//        {
//            TempRefId = tempId,
//            ItemRefId = itemRefId,
//            BoqRefID = boqLineRefId
//        };
//        DataUtility.GetInstance
//              .UseProcedure("BoqLineCreate")
//              .InsertOrUpdate<dynamic>(data);
//        DataUtility.GetInstance
//              .UseProcedure("BoqLineDetailsCreate")
//              .InsertOrUpdate(data);
//        DataUtility.GetInstance.ComitTransaction();
//    }
//    catch (Exception ex)
//    {
//        DataUtility.GetInstance.RollbackTransaction();
//        throw ex;
//    }


//}

//public static void DeleteBoq(this Form form, string tempId, long itemRefId)
//{
//    DbUtil.GetInstance.StartTransaction();
//    try
//    {
//        var data = new
//        {
//            itemRefId = itemRefId,
//            tempRefId = tempId,
//        };
//        DbUtil.GetInstance
//              .UseSql("DELETE FROM BOQLineTemp WHERE BOQID=@tempRefId AND ItemBOQRefID=@itemRefId;")
//              .UpSert(data);
//        DbUtil.GetInstance
//              .UseSql("DELETE FROM BOQLineDetailTemp WHERE BoqRefTempId=@tempRefId AND ItemRefID=@itemRefId;")
//              .UpSert(data);
//        DbUtil.GetInstance.ComitTransaction();
//    }
//    catch (Exception ex)
//    {
//        DbUtil.GetInstance.RollbackTransaction();
//        throw ex;
//    }


//}