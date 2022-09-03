using ESProMeter.IVews;
using ESProMeter.Services;
using System.Data;
using System.Windows.Forms;
using Dapper;
using ESProMeter.Extensions;
using ESProMeter.Models;

namespace ESProMeter.Repository
{
    public  class ItemRepository
    {

        /// <summary>
        /// Select items from database
        /// </summary>
        /// <param name="form"></param>
        /// <param name="grid"></param>
        /// <param name="sortBy"></param>
        /// <param name="sortType"></param>
        public bool GetAllItems(byte isActive,out DataTable table)
        {
            return AppService.SqlGetInstance.UseProcedure("ITEM_sp_SELECT_ALL")
               .SelectAsTable<dynamic>(new
               {
                   @ISACTIVE=isActive
               }, out table);
        }
        public bool GetAllItems(byte isActive,int page,string sort, out DataTable table)
        {
            return AppService.SqlGetInstance.UseProcedure("[ITEM_sp_SELECT_BY_PAGE]")
               .SelectAsTable<dynamic>(new
               {
                   @ISACTIVE = isActive,
                   @PAGE=page,
                   @SORT=sort
               }, out table);
        }
        public bool GetAllItems(string itemName,byte isActive, int page,string sort, out DataTable table)
        {
            return AppService.SqlGetInstance.UseProcedure("[ITEM_sp_SELECT_BY_PAGE]")
               .SelectAsTable<dynamic>(new
               {
                   @searchText=itemName,
                   @ISACTIVE = isActive,
                   @PAGE = page,
                   @SORT=sort

               }, out table);
        }
        public bool GetItemsWithoutBoq(byte isActive,string itemType, out DataTable table)  
        {
            return AppService.SqlGetInstance.UseProcedure("[ITEM_sp_SELECT_ITEMWITHOUTBOQ]")
               .SelectAsTable<dynamic>(new
               {
                   @ISACTIVE = isActive,
                   @ITEMTYPE=itemType
               }, out table);
        }
        public bool GetItemeWithoutBoqByName(byte isActive,string itemName,string itemType, out DataTable table)
        {
            return AppService.SqlGetInstance.UseProcedure("[ITEM_sp_SELECT_ITEMWITHOUTBOQ_BY_NAME]")
               .SelectAsTable<dynamic>(new
               {
                   @ITEMNAME= itemName,
                   @ITEMTYPE=itemType,
                   @ISACTIVE = isActive
               }, out table);
        }
        public bool GetBoqItems(byte isActive, string itemName, out DataTable table)
        {
            return AppService.SqlGetInstance.UseProcedure("[ITEM_sp_SELECT_BOQITEM]")
               .SelectAsTable<dynamic>(new
               {
                   @ISACTIVE = isActive,
                   @ITEMNAME = itemName
               }, out table);
        }
        public bool GetBoqItemById(long Id,out VBOQITEM item)
        {
            return AppService.SqlGetInstance.UseProcedure("[ITEM_sp_SELECT_BOQITEM_ID]")
               .FindOne<dynamic,VBOQITEM>(new
               {
                   @ISACTIVE=1,
                   @ID=Id
               },out item);
        }
        public bool GetItemsType(out DataTable table)
        {
            return AppService.SqlGetInstance.UseProcedure("[ITEMTYPE_SP_SELECT]")
               .SelectAsTable<dynamic>(null, out table);
        }
        public void GetItemById(long itemId,ITItem item)
        {
            if(AppService.SqlGetInstance.UseProcedure("ITEM_sp_SELECT_BY_ID")
               .FindOne<dynamic>(new { @ID = itemId }, out var row))
            {
                item.ID = row.GetValue<long>("ID");
                item.ITEMNAME = row.GetValue<string>("ItemName");
                item.DESCRIPTION = row.GetValue<string>("Description");
                item.COST = row.GetValue<decimal>("Cost");
                item.ISACTIVE = row.GetValue<byte>("IsActive");
                item.UOMID = row.GetValue<long>("UomID");
                item.ITEMTYPE = row.GetValue<string>("ItemType");
            }
        }
        public bool GetBoqItemWithItemLineById(long itemId, ITItem item,out DataTable labour,out DataTable machinery,out DataTable material) 
        {
            labour=new();
            machinery=new();
            material=new();
            if (AppService.SqlGetInstance.UseProcedure("ITEM_sp_SELECT_BY_ID")
               .FindOne<dynamic>(new { @ID=itemId }, out var row))
            {
                item.ID = row.GetValue<long>("ID");
                item.ITEMNAME = row.GetValue<string>("ItemName");
                item.DESCRIPTION = row.GetValue<string>("Description");
                item.COST = row.GetValue<decimal>("Cost");
                item.ISACTIVE = row.GetValue<byte>("IsActive");
                item.UOMID = row.GetValue<long>("UomID");
                item.ITEMTYPE = row.GetValue<string>("ItemType");
                AppService.GetItemInstance.BoqItemLineGetByItemID(itemId, "labour", out labour);
                AppService.GetItemInstance.BoqItemLineGetByItemID(itemId, "machinery", out machinery);
                AppService.GetItemInstance.BoqItemLineGetByItemID(itemId, "material", out material);
                return true;
            };
            return false;
        }
        public bool GetBoqItemWithItemLineById(long itemId,out DataTable labour, out DataTable machinery, out DataTable material)
        {
            labour = new();
            machinery = new();
            material = new();
            try
            {
                AppService.GetItemInstance.BoqItemLineGetByItemID(itemId, "labour", out labour);
                AppService.GetItemInstance.BoqItemLineGetByItemID(itemId, "machinery", out machinery);
                AppService.GetItemInstance.BoqItemLineGetByItemID(itemId, "material", out material);
                return true;
            }
            catch
            {
                return false;
                throw;
            }
               
        }
        public bool GetBoqItemWithItemLineById(long itemId, out DataTable table)
        {
            table = new();
            try
            {
                AppService.GetItemInstance.BoqItemLineGetByItemID(itemId,null, out table);
                return true;
            }
            catch
            {
                return false;
                throw;
            }

        }
        /// <summary>
        /// Create Items and update
        /// </summary>
        /// <param name="item"></param>
        public  void ItemCreate(ITItem item)
        {
            AppService.SqlGetInstance.UseProcedure("ITEM_INSERT")
                    .InsertOrUpdate(new
                    {
                        item.ITEMNAME,
                        item.DESCRIPTION,
                        item.ITEMTYPE,
                        item.UOMID,
                        item.COST,
                        item.ISRATE
                    });
        }
        public void ItemImport(DataTable table)
        {
            AppService.SqlGetInstance.UseProcedure("ITEM_sp_Import")
                    .InsertFromTable("@udtItemNew", table, "udt_Item_Import");
        }
        public  void ItemUpdate(ITItem item)
        {
            AppService.SqlGetInstance.UseProcedure("ITEM_UPDATE_SP")
                    .InsertOrUpdate(new
                    {
                        item.ID,
                        item.ITEMNAME,
                        item.DESCRIPTION,
                        item.ITEMTYPE,
                        item.UOMID,
                        item.COST,
                        item.ISRATE
                    });
        }

        /// <summary>
        /// Create new and update BOQ Item Lines
        /// </summary>
        /// <param name="item"></param>
        /// <param name="grid"></param>
        public  void BoqCreateItemLine(ITItem item,DataGridView grid)
        {
            try
            {
                AppService.SqlGetInstance.StartTransaction();
                //create new item
                var id = AppService.SqlGetInstance.UseProcedure("ITEM_INSERT")
                        .InsertGetId<long, dynamic>(new
                        {
                            item.ITEMNAME,
                            item.DESCRIPTION,
                            item.ITEMTYPE,
                            item.UOMID,
                            item.COST,
                            item.ISRATE
                        });
                //create boq item line
                var table = ToTable(grid, id);
                AppService.SqlGetInstance.UseProcedure("SP_BoqItemLineInert")
                        .InsertFromTable(new { BoqItemLine = table.AsTableValuedParameter("udt_BoqItemLine_Insert") });
                AppService.SqlGetInstance.ComitTransaction();
            }
            catch
            {
                AppService.SqlGetInstance.RollbackTransaction();
                throw;
            }

        }
        public (bool success,long id) BoqCreateItemLineGetId(ITItem item, DataGridView grid)
        {
            try
            {
                AppService.SqlGetInstance.StartTransaction();
                //create new item
                var id = AppService.SqlGetInstance.UseProcedure("ITEM_INSERT")
                        .InsertGetId<long, dynamic>(new
                        {
                            item.ITEMNAME,
                            item.DESCRIPTION,
                            item.ITEMTYPE,
                            item.UOMID,
                            item.COST,
                            item.ISRATE
                        });
                //create boq item line
                var table = ToTable(grid, id);
                AppService.SqlGetInstance.UseProcedure("SP_BoqItemLineInert")
                        .InsertFromTable(new { BoqItemLine = table.AsTableValuedParameter("udt_BoqItemLine_Insert") });
                AppService.SqlGetInstance.ComitTransaction();
                return (id > 0, id);
            }
            catch
            {
                AppService.SqlGetInstance.RollbackTransaction();
                throw;
            }

        }
        public void BoqCreateItemLine(ITItem item, DataTable grid)
        {
            try
            {
                AppService.SqlGetInstance.StartTransaction();
                //create new item
                var id = AppService.SqlGetInstance.UseProcedure("ITEM_INSERT")
                        .InsertGetId<long, dynamic>(new
                        {
                            item.ITEMNAME,
                            item.DESCRIPTION,
                            item.ITEMTYPE,
                            item.UOMID,
                            item.COST,
                            item.ISRATE
                        });
                //create boq item line
                AppService.SqlGetInstance.UseProcedure("SP_BoqItemLineInert")
                        .InsertFromTable(new { BoqItemLine = grid.AsTableValuedParameter("udt_BoqItemLine_Insert") });
                AppService.SqlGetInstance.ComitTransaction();
            }
            catch
            {
                AppService.SqlGetInstance.RollbackTransaction();
                throw;
            }

        }
        public  void BoqUpdateItemLine(ITItem item, DataGridView grid)
        {
            try
            {
                AppService.SqlGetInstance.StartTransaction();
                //update existing boq item
                AppService.SqlGetInstance.UseProcedure("ITEM_UPDATE_SP")
                        .InsertOrUpdate<dynamic>(new
                        {
                            item.ID,
                            item.ITEMNAME,
                            item.DESCRIPTION,
                            item.ITEMTYPE,
                            item.UOMID,
                            item.COST,
                            item.ISRATE
                        });
                //remove existing item
                AppService.SqlGetInstance.UseSql("DELETE FROM TBOQITEMLINE WHERE BOQITEMID=@id;")
                        .Delete<dynamic>(new { id = item.ID });

                //update existing boq_item_line
                var table = ToTable(grid, item.ID);
                AppService.SqlGetInstance.UseProcedure("SP_BoqItemLineInert")
                        .InsertFromTable(new { BoqItemLine = table.AsTableValuedParameter("udt_BoqItemLine_Insert") });

                AppService.SqlGetInstance.ComitTransaction();
            }
            catch
            {
                AppService.SqlGetInstance.RollbackTransaction();
                throw;
            }

        }
        public void BoqUpdateItemLine(ITItem item, DataTable grid)
        {
            try
            {
                AppService.SqlGetInstance.StartTransaction();
                //update existing boq item
                AppService.SqlGetInstance.UseProcedure("ITEM_UPDATE_SP")
                        .InsertOrUpdate<dynamic>(new
                        {
                            item.ID,
                            item.ITEMNAME,
                            item.DESCRIPTION,
                            item.ITEMTYPE,
                            item.UOMID,
                            item.COST,
                            item.ISRATE
                        });
                //remove existing item
                AppService.SqlGetInstance.UseSql("DELETE FROM TBOQITEMLINE WHERE BOQITEMID=@id;")
                        .Delete<dynamic>(new { id = item.ID });

                //update existing boq_item_line
                AppService.SqlGetInstance.UseProcedure("SP_BoqItemLineInert")
                        .InsertFromTable(new { BoqItemLine = grid.AsTableValuedParameter("udt_BoqItemLine_Insert") });

                AppService.SqlGetInstance.ComitTransaction();
            }
            catch
            {
                AppService.SqlGetInstance.RollbackTransaction();
                throw;
            }

        }
        public bool DeleteItemWithBoq(long itemId)
        {
            return AppService.SqlGetInstance.UseProcedure("ITEM_sp_DELETE")
                        .Delete<dynamic>(new { @itemID = itemId })>0;
        }
        public bool ItemIsInUsed(long itemId)
        {
            var count = AppService.SqlGetInstance.UseSql("SELECT COUNT(*) FROM [dbo].[TBOQITEMLINE] WHERE BOQITEMLINEID=@ID;")
                    .Count<int, dynamic>(new { @ID = itemId });
            var count1 = AppService.SqlGetInstance.UseSql("SELECT COUNT(*) FROM [dbo].[TBOQLINE] WHERE BOQITEMID=@ID;")
                    .Count<int, dynamic>(new { @ID = itemId });
            return (count + count1) > 0;
        }
        public bool BoqItemLineGetByItemID(long itemID,out DataTable table)
        {
            try
            {
                return AppService.SqlGetInstance.UseProcedure("BOQITEMLINE_sp_SELECT_BY_ID")
                        .SelectAsTable<dynamic>(new
                        {
                            @BOQITEMID= itemID
                        },out table);
            }
            catch
            {
                throw;
            }

        }
        public void BoqItemLineGetByItemID(long itemID,string ItemTypeName, out DataTable table)
        {
            try
            {
                table=AppService.SqlGetInstance.UseProcedure("BOQITEMLINE_sp_SELECT_BY_ID")
                        .SelectAsTable<dynamic>(new
                        {
                            @BOQITEMID = itemID,
                            @ITEMTYPE= ItemTypeName
                        });
            }
            catch
            {
                throw;
            }

        }
        public void BoqItemLineGetByItemID(long boq_id,long itemID, string ItemTypeName, out DataTable table)
        {
            try
            {
                table = AppService.SqlGetInstance.UseProcedure("BOQITEMLINE_sp_SELECT_BY_ID")
                        .SelectAsTable<dynamic>(new
                        {
                            @BOQID= boq_id,
                            @BOQITEMID = itemID,
                            @ITEMTYPE = ItemTypeName
                        });
            }
            catch
            {
                throw;
            }

        }
        public bool MakeInActiveOrActive(long id,byte isActive) 
        {
            var count = AppService.SqlGetInstance.UseProcedure("[ITEM_sp_ISACTIVE]")
                    .InsertOrUpdate<dynamic>(new { 
                     @ID=id,
                        @ISACTIVE = isActive
                    });
            return count > 0;
        }

        









        /// <summary>
        /// check item are existing
        /// </summary>
        /// <param name="itemName"></param>
        /// <returns></returns>
        public  bool ItemAlreadyExist(string itemName) 
        {
            var count = AppService.SqlGetInstance.UseSql("SELECT COUNT(*) FROM [dbo].[VItem] WHERE ITEMNAME=@itemName")
                    .Count<int, dynamic>(new { itemName = itemName });
            return count > 0;
        }

        /// <summary>
        /// this method use for check item name for update
        /// </summary>
        /// <param name="itemID"></param>
        /// <param name="itemName"></param>
        /// <returns></returns>
        public bool ItemSame(long itemID, string itemName)
        {
            var count = AppService.SqlGetInstance.UseSql("SELECT COUNT(*) FROM [dbo].[VItem] WHERE ITEMNAME=@itemName AND ID <> @ID")
                    .Count<int, dynamic>(new { ID = itemID, itemName = itemName });
            return count > 0;
        }
        public bool ItemExist(long itemId, long boqItemLineID)
        {
            var count = AppService.SqlGetInstance.UseSql("SELECT COUNT(*) FROM [dbo].[ITEMBOQLINE] WHERE ItemRefID=@itemRefId AND BOQItemLineRefID=@boqItemLineRefID")
                    .Count<int, dynamic>(new { boqItemLineRefID = boqItemLineID, itemRefId = itemId });
            return count > 0;
        }


        /// <summary>
        /// Private methods
        /// </summary>
        /// <param name="view"></param>
        /// <param name="itemID"></param>
        /// <returns></returns>
        private  DataTable ToTable(DataGridView view, long itemID)
        {
            DataTable table = new DataTable();
            table.Columns.Add("BOQITEMID", typeof(long));
            table.Columns.Add("BOQITEMLINEID", typeof(long));
            table.Columns.Add("BOQITEMLINESEQ", typeof(int));
            table.Columns.Add("BOQITEMLINEUOMID", typeof(long));
            table.Columns.Add("BOQITEMLINEQTY", typeof(decimal));
            int index = 1;
            foreach (DataGridViewRow row in view.Rows)
            {
                if (row.IsNewRow) break;
                DataRow dRow = table.NewRow();
                dRow["BOQITEMID"] = itemID;
                dRow["BOQITEMLINEID"] = row.Cells["BOQITEMLINEID"].Value;
                dRow["BOQITEMLINESEQ"] = index;
                dRow["BOQITEMLINEUOMID"] = row.Cells["BOQITEMLINEUOMID"].Value;
                dRow["BOQITEMLINEQTY"] = row.Cells["BOQITEMLINEQTY"].Value;
                table.Rows.Add(dRow);
                index++;
            }
            return table;
        }



        private DataTable ToTable(DataGridView view)
        {
            DataTable table = new DataTable();
            table.Columns.Add("itemName", typeof(string));
            table.Columns.Add("itemType", typeof(string));
            table.Columns.Add("uomID", typeof(long));
            table.Columns.Add("cost", typeof(decimal));
            table.Columns.Add("itemDesc", typeof(string));
            foreach (DataGridViewRow row in view.Rows)
            {
                if (row.IsNewRow) break;
                DataRow dRow = table.NewRow();
                dRow["itemName"] = row.Cells["itemName"].Value; ;
                dRow["itemType"] = row.Cells["itemType"].Value;
                dRow["uomID"] = row.Cells["uomID"].Value;
                dRow["cost"] = row.Cells["cost"].Value;
                dRow["itemDesc"] = row.Cells["itemDesc"].Value;
                table.Rows.Add(dRow);
            }
            return table;
        }
    }
}
