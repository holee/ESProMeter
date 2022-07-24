using System.Windows.Forms;
using ESProMeter.Extensions;
using System.Data;
using System.Collections.Generic;
using ESProMeter.DataAccess;
using ESProMeter.Services;
using ESProMeter.IVews;
using Dapper;

namespace ESProMeter.Controllers
{
    public static class ItemController
    {
        
        private static readonly SqlAccess instance = DataUtility.GetInstance;
        public static bool SearchByFieldName(this Form form,string fieldName,object searchValue,out DataTable destination, string op = "=")
        {
            string sql = $"SELECT * FROM [dbo].[vItemWithUom] WHERE {fieldName} {op} @fieldName;";
            destination = new DataTable();
            destination = instance.UseSql(sql)
                                  .FindAsTable<dynamic>(new { fieldName = searchValue });
            if(destination.Rows.Count > 0)
            {
                return true;
            }
            return false;
        }

        public static void ShowItemList(this Form form,DataGridView grid,params string[] columns)
        {
            var sql = columns.Length == 0 ? "*" : string.Join(",", columns);
            instance.UseSql($"SELECT {sql} FROM VItem;")
               .FindAsTable<dynamic?>(null)
               .UseDataTableAsGridView(grid);
        }
        public static void ShowItemList(this Form form, DataGridView grid,
            Dictionary<string,object> search, 
            params string[] columns)
        {
            List<string> list = new List<string>();
            foreach(KeyValuePair<string,object> kv in search)
            {
                list.Add($"{kv.Key}={kv.Value}");
            }
            var condition = string.Join("",list.ToArray());
            var sql = columns.Length == 0 ? "*" : string.Join(",", columns);
            instance.UseSql($"SELECT {sql} FROM VItem;")
               .FindAsTable<dynamic?>(null)
               .UseDataTableAsGridView(grid);
        }
        public static void ShowItemList(this Form form,DataGridView grid, string type, string itemName, params string[] columns)
        {
            var sql = columns.Length == 0 ? "*" : string.Join(",", columns);

            instance.UseSql($"SELECT TOP(10) {sql} FROM [dbo].[VItem] WHERE [Type]=@type AND [Name] LIKE @itemName+'%';")
               .FindAsTable(new { type = type, itemName = itemName })
               .UseDataTableAsGridView(grid);
        }

        public static void SearchItemList(this Form form, DataGridView grid, string itemName, params string[] columns)
        {
            var sql = columns.Length == 0 ? "*" : string.Join(",", columns); 

            if(instance.UseSql($"SELECT {sql} FROM [dbo].[VItem] WHERE [ItemName] LIKE @itemName+'%';")
               .FindAsTable(new { itemName = itemName },out DataTable table))
            {
                table.UseDataTableAsGridView(grid);
            }
        }

        public static List<object> SearchItemList(this Form form,long itemId, params string[] columns)
        {
            List<object?> list = new List<object?>();
            var sql = columns.Length == 0 ? "*" : string.Join(",", columns);
            if(instance.UseSql($"SELECT TOP(10) {sql} FROM [dbo].[VItem] WHERE NOT [ItemType]='BillOfQuantity' AND [ID]=@itemId")
               .FindOne(new { itemId = itemId },out DataRow row))
            {
                list.AddRange(row.ItemArray);
            }
            return list;
        }
        //VItem
        public static void ShowItemList(this Form form, DataGridView grid,string itemName, params string[] columns)
        {
            var sql = columns.Length == 0 ? "*" : string.Join(",", columns);

            instance.UseSql($"SELECT {sql} FROM [dbo].[VItem] WHERE [ItemName] LIKE @itemName+'%';")
               .FindAsTable(new {itemName = itemName })
               .UseDataTableAsGridView(grid);
        }
        public static bool SearchByFieldName(this Form form,string type, string fieldName, object searchValue, out DataTable destination, string op = "=")
        {
            string sql = $"SELECT * FROM [dbo].[vItemWithUom] WHERE {fieldName} {op} @fieldName AND [Type]=@type;";
            destination = new DataTable();
            destination = instance.UseSql(sql)
                            .FindAsTable<dynamic>(new { fieldName = searchValue, type = type });
            if (destination.Rows.Count > 0)
            {
                return true;
            }
            return false;
        }
        public static bool MakeItemActiveOrInActive(this Form form, bool isActive = false)
        {
            var id = form.AsDataGrid("dataItemList").AsNumber<long>("Column1");
            var sql = "UPDATE [dbo].[Item] SET IsActive=@IsActive WHERE ItemID=@ItemID";
            if (instance.UseSql(sql)
                .InsertOrUpdate(new { isActive = isActive, ItemID = id }) > 0)
            {
                form.AsDataGrid("dataItemList").SetText("Column12", isActive);
                return true;
            }
            return false;
        }
        public static bool DeleteItem(this Form form,long id)
        {
            try
            {
                instance.StartTransaction();
                instance.UseSql("DELETE FROM [dbo].[TITEM] WHERE ID=@itemID;")
                       .Delete<dynamic>(new { itemID = id });
                instance.UseSql("DELETE FROM [dbo].[TBOQITEMLINE] WHERE BOQITEMID=@itemID;")
                        .Delete<dynamic>(new { itemID = id });
                instance.ComitTransaction();
                return true;
            }
            catch (System.Exception)
            {
                instance.RollbackTransaction();
                return false;
            }
            
        }
        public static void ShowItemList(this Form form, DataGridView grid, string sortBy="ID", string sortType = "DESC")
        {
            instance.UseSql($"SELECT * FROM [dbo].[VItem] ORDER BY {sortBy} {sortType};")
               .FindAsTable<dynamic?>(null)
               .UseDataTableAsGridView(grid);
        }
        public static void ShowItemList(this Form form,DataGridView grid, int numberOfRows, string sortBy,string sortType = "DESC")
        {
            instance.UseSql($"SELECT TOP({numberOfRows}) * FROM [dbo].[VItem] ORDER BY {sortBy} {sortType};")
               .FindAsTable<dynamic?>(null)
               .UseDataTableAsGridView(grid);
        }
        public static void ShowItemList(this Form form,DataGridView grid, string type, int numberOfRows, string sortBy,string sortType="DESC")
        {
            instance.UseSql($"SELECT TOP({numberOfRows}) * FROM [dbo].[VItem] WHERE [ItemType]=@type ORDER BY {sortBy} {sortType};")
               .FindAsTable<dynamic>(new { type=type })
               .UseDataTableAsGridView(grid);
        }
        public static void ShowItemList(this Form form,DataGridView grid, string type, string itemName, int numberOfRows, string sortBy,string sortType, params string[] columns)
        {
            var sql = columns.Length == 0 ? "*" : string.Join(",", columns);

            instance.UseSql($"SELECT TOP(numberOfRows) {sql} FROM [dbo].[VItem] WHERE [ItemType]=@type AND [ItemName] LIKE @itemName+'%' ORDER BY {sortBy} {sortType};")
               .FindAsTable(new { type = type, itemName = itemName })
               .UseDataTableAsGridView(grid);
        }

        /// <summary>
        /// BOQ Operation
        /// </summary>
        /// <param name="form"></param>
        /// <param name="itemId"></param>
        /// <param name="item"></param>
        /// <param name="columns"></param>
        public static void ShowItemFormUpdate(this Form form, long itemId, IItem item,DataGridView grid, params string[] columns)
        {
            var sql = columns.Length == 0 ? "*" : string.Join(",", columns);

            if (instance.UseSql($"SELECT {sql} FROM [dbo].[VItem] WHERE [ID]=@itemID;")
                       .FindOne(new { itemID = itemId }, out DataRow row))
            {
                item.Id = row.GetValue<long>("ID");
                item.ItemName = row.GetValue<string>("ItemName");
                item.Description = row.GetValue<string>("Description");
                item.Cost = row.GetValue<decimal>("Cost");
                item.IsActive = row.GetValue<bool>("IsActive");
                item.UomId = row.GetValue<long>("UomID");
                item.ItemType = row.GetValue<string>("ItemType");

                if (item.ItemType == "BillOfQuantity")
                {
                    var sql1 = "SELECT BoqItemLineId,BOQITEMITEMLINENAME,BOQITEMITEMLINETYPE,UOMNAME,BOQITEMLINEUOMID,BOQITEMLINEQTY FROM VBoqItemLine WHERE BoqItemId=@itemId;";
                    instance.UseSql(sql1)
                            .FindAsTable<dynamic>(new { itemId = itemId })
                            .UsePlainDataToGridView(grid);
                }
            }
        }
        public static void CreateNewItem(this Form form, IItem item)
        {
            instance.UseProcedure("ITEM_INSERT")
                    .InsertOrUpdate(new
                    {
                        ITEMNAME = item.ItemName,
                        DESCRIPTION = item.Description,
                        ITEMTYPE = item.ItemType,
                        UOMID = item.UomId,
                        COST = item.Cost,
                        ISRATE = 0
                    });
        }
        public static void UpdateExistingItem(this Form form, IItem item) 
        {
            instance.UseProcedure("ITEM_UPDATE_SP")
                    .InsertOrUpdate(new
                    {
                        ID=item.Id,
                        ITEMNAME = item.ItemName,
                        DESCRIPTION = item.Description,
                        ITEMTYPE = item.ItemType,
                        UOMID = item.UomId,
                        COST = item.Cost,
                        ISRATE = 0
                    });
        }
        public static void CreateNewBoqItemLine(this Form form, IItem item, DataGridView grid)
        {
            try
            {
                instance.StartTransaction();
                //create new item
                var id = instance.UseProcedure("ITEM_INSERT")
                        .InsertGetId<long, dynamic>(new
                        {
                            ITEMNAME = item.ItemName,
                            DESCRIPTION = item.Description,
                            ITEMTYPE = item.ItemType,
                            UOMID = item.UomId,
                            COST = item.Cost,
                            ISRATE = 0
                        });
                //create boq item line
                var table = ToTable(grid, id);
                instance.UseProcedure("SP_BoqItemLineInert")
                        .InsertFromTable(new { BoqItemLine = table.AsTableValuedParameter("udt_BoqItemLine_Insert") });

                instance.ComitTransaction();
            }
            catch
            {
                instance.RollbackTransaction();
                throw;
            }

        }
        public static void UpdateExistingBoqItemLine(this Form form, IItem item, DataGridView grid) 
        {
            try
            {
                instance.StartTransaction();
                //update existing boq item
                var id = instance.UseProcedure("ITEM_UPDATE_SP")
                        .InsertGetId<long, dynamic>(new
                        {
                            ID=item.Id,
                            ITEMNAME = item.ItemName,
                            DESCRIPTION = item.Description,
                            ITEMTYPE = item.ItemType,
                            UOMID = item.UomId,
                            COST = item.Cost,
                            ISRATE = 0
                        });
                //remove existing item
                instance.UseSql("DELETE FROM TBOQITEMLINE WHERE ID=@id;")
                        .Delete<dynamic>(new { id = id });

                //update existing boq_item_line
                var table = ToTable(grid, id);
                instance.UseProcedure("SP_BoqItemLineInert")
                        .InsertFromTable(new { BoqItemLine = table.AsTableValuedParameter("udt_BoqItemLine_Insert") });

                instance.ComitTransaction();
            }
            catch
            {
                instance.RollbackTransaction();
                throw;
            }

        }
        public static void ShowItemType(this Form form)
        {
            instance.UseSql("SELECT * FROM [dbo].[TTYPE];")
                .FindAsTable<dynamic?>(null)
                .AsCombobox(form.AsControl<ComboBox>("cmbType"), "Type", "Type");
        }
        public static void ShowItemType(this Form form,ComboBox storage)
        {
            instance.UseSql("SELECT [ID],[TYPENAME] FROM [dbo].[TTYPE] WHERE [TYPENAME] NOT IN ('AdditionalCost','Margin','Inflation') AND [TypeOf]='item' ORDER BY  [TYPENAME] ASC;")
                .FindAsTable<dynamic?>(null)
                .AsCombobox(storage, "TYPENAME", "ID");
        }
        public static void ShowItemType(this Form form,string ofType="item",params string[] types)
        {
            string query = "";
            if (types.Length > 0)
            {
                List<string> newValue = new List<string>();
                foreach (string type in types)
                {
                    newValue.Add($"'{type}'");
                }
                query =string.Join(",", newValue.ToArray());
            }

            instance.UseSql($"SELECT [TypeID],[Type] FROM [dbo].[TYPE] WHERE [type] NOT IN ({query}) AND [TypeOf]=@ofType;")
                .FindAsTable(new { ofType=ofType})
                .AsCombobox(form.AsControl<ComboBox>("cmbType"), "Type", "Type");
        }
        public static void ShowBoqItems(this Form form)
        {
            instance.UseSql("SELECT [TypeID],[Type] FROM [dbo].[TYPE] WHERE [type]='Bill Of Quantity' AND [TypeOf]='item';")
                .FindAsTable<dynamic?>(null)
                .AsCombobox(form.AsControl<ComboBox>("cmbType"), "Type", "Type");
        }
        public static void ShowItems(this Form form)
        {
            instance.UseSql("SELECT [TypeID],[Type] FROM [dbo].[TYPE] WHERE [type] NOT IN ('Additional Cost','Margin','Inflation','Bill Of Quantity') AND [TypeOf]='item';")
                .FindAsTable<dynamic>(new { }).AsCombobox(form.AsControl<ComboBox>("cmbType"), "Type", "Type");
        }
        public static void ShowUom(this Form form)
        {
            instance.UseSql("SELECT UomID,Abbreviation FROM [TUOM]")
                .FindAsTable<dynamic?>(null).AsCombobox(form.AsControl<ComboBox>("cmbUom"), "Abbreviation", "UOMID");
        }
        public static void ShowUom(this Form form,ComboBox storage)
        {
            instance.UseSql("SELECT ID,UOMNAME FROM [TUOM]")
                .FindAsTable<dynamic?>(null)
                .AsCombobox(storage, "UOMNAME", "ID");
        }
        public static void GetItemType(this Form form,string key,string typeName)
        {
            var cmb = form.AsCombobox(key);
            instance.UseSql("SELECT * FROM [dbo].[iTEM] WHERE [type]=@type;")
                           .FindAsTable(new { type=typeName})
                           .AsCombobox(cmb, "Type", "Type");
        }
        public static bool GetItemTypeById(this Form form,long id,out DataRow row)
        {
            if (instance.UseSql("SELECT * FROM [dbo].[vItemWithUom] WHERE [ItemId]=@id;")
                           .FindOne(new { id = id }, out row)) {
                return row != null;
            }
            return false;
        }
        public static (DataRow? row,bool found) GetItemTypeById(this Form form, long id,params string[] columns)
        {
            string sql = columns.Length == 0 ? "*" : string.Join(",", columns);
            if(instance.UseSql($"SELECT {sql} FROM [dbo].[vItemWithUom] WHERE [ItemId]=@id;")
                           .FindOne<dynamic>(new { id = id },out DataRow row)){
                if (row != null)
                {
                    return (row, true);
                }
            }
            return (null, false);
        }
      
        public static void CreateNewItem(this Form form, object data)
        {
            instance.UseProcedure("ITEM_INSERT")
                    .InsertOrUpdate(data);
        }
        public static void UpdateItem(this Form form,IItem item)
        {
            instance.UseProcedure("ItemUpdate")
                    .InsertOrUpdate(new {
                        ITEMNAME=item.ItemName,
                        DESCRIPTION=item.Description,
                        ITEMTYPE=item.ItemType,
                        UOMID=item.UomId,
                        COST=item.Cost,
                        ISRATE=0
                    });
        }
        public static void UpdateItem(this Form form, object data)
        {
            instance.UseProcedure("ItemUpdate")
                    .InsertOrUpdate(data);
        }
        public static bool ItemExist(string itemName)
        {
            var count = instance.UseSql("SELECT COUNT(*) FROM [dbo].[Item] WHERE Name=@itemName")
                    .Count<int,dynamic>(new { itemName = itemName });
           return count > 0;
        }
        public static bool ItemExistSame(long itemID,string itemName)
        {
            var count = instance.UseSql("SELECT COUNT(*) FROM [dbo].[Item] WHERE Name=@itemName AND itemID <> @itemID")
                    .Count<int, dynamic>(new { itemID = itemID, itemName = itemName });
            return count > 0;
        }
        public static bool ItemExist(long itemRefId,long boqItemLineRefID)
        {
            var count = instance.UseSql("SELECT COUNT(*) FROM [dbo].[ITEMBOQLINE] WHERE ItemRefID=@itemRefId AND BOQItemLineRefID=@boqItemLineRefID")
                    .Count<int,dynamic>(new { boqItemLineRefID = boqItemLineRefID, itemRefId = itemRefId }); 
            return count > 0;
        }
        private static DataTable ToTable(DataGridView view,long itemID)
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

    }
}




//public static bool GetExtraItem(this Form form, out DataTable data)
//{
//    data = instance.UseSql("SELECT Name,Rate FROM [dbo].[Item] WHERE [Type]='additional cost' AND IsActive=1;")
//                   .FindAsTable<dynamic?>(null);
//    if (data.Rows.Count > 0)
//    {
//        return true;
//    }
//    return false;
//}
//public static bool GetExtraItem(this Form form)
//{
//    var data = instance.UseSql("SELECT Name,Rate,ItemID FROM [dbo].[Item] WHERE [Type]='additional cost' AND IsActive=1;")
//                   .FindAsTable<dynamic?>(null);
//    if (data.Rows.Count > 0)
//    {
//        var grid = form.AsControl<DataGridView>("dataAdditional");
//        data.UsePlainDataToGridView(grid);
//        return true;
//    }
//    return false;
//}
//public static bool GetItemTypeByName(this Form form, string name, out DataRow row)
//{
//    if (instance.UseSql("SELECT * FROM [dbo].[vItemWithUom] WHERE [Name]=@Name;")
//                   .FindOne<dynamic>(new { Name = name }, out row))
//    {
//        return row != null;
//    }
//    return false;
//}
//public static void GetItemTypes(this Form form, DataGridViewComboBoxColumn column, string typeName, params string[] columns)
//{
//    var sql = columns.Length == 0 ? "*" : string.Join(",", columns);
//    var items = instance.UseSql($"SELECT {sql} FROM [dbo].[vItemWithUom] WHERE type=@type;")
//                    .FindAsTable<dynamic?>(new { type = typeName });
//    column.DataSource = items;
//    column.DisplayMember = "Name";
//    column.ValueMember = "ItemID";

//}
//public static void GetItemTypes(this Form form, ComboBox column, string typeName, params string[] columns)
//{
//    var sql = columns.Length == 0 ? "*" : string.Join(",", columns);
//    var items = instance.UseSql($"SELECT {sql} FROM [dbo].[Item] WHERE type=@type;")
//                   .FindAsTable<dynamic?>(new { type = typeName });
//    column.DataSource = items;
//    column.DisplayMember = "Name";
//    column.ValueMember = "ItemID";
//}
//public static void GetItemTypes(this Form form, DataGridView column, string typeName, params string[] columns)
//{
//    var sql = columns.Length == 0 ? "*" : string.Join(",", columns);
//    var items = instance.UseSql($"SELECT {sql} FROM [dbo].[vItemWithUom] WHERE type=@type;")
//                  .FindAsTable<dynamic?>(new { type = typeName });
//    column.DataSource = items;
//}
//public static bool GetItemTypes(this Form form, string type, out List<string> list)
//{
//    list = new List<string>();
//    var items = instance.UseSql("SELECT Name FROM [dbo].[Item] WHERE type=@type;")
//                   .FindAsTable<dynamic?>(new { type = type });
//    if (items.Rows.Count > 0)
//    {
//        foreach (DataRow item in items.Rows)
//        {
//            list.Add(item.GetValue<string>("Name"));
//        }
//        return true;
//    }
//    return false;

//}
//public static void GetItemType(this Form form, DataGridViewComboBoxCell column, string typeName)
//{
//    var items = instance.UseSql("SELECT * FROM [dbo].[vItemWithUom] WHERE type=@type;")
//                   .FindAsTable<dynamic?>(new { type = typeName });
//    column.DataSource = items;
//    column.DisplayMember = "Name";
//    column.ValueMember = "ItemID";

//}





//public static void CreateNewItemBoqLine(this Form form, object data)
//{
//    var dataLabor = form.AsControl<DataGridView>("dataLabor");
//    var dataMachinary = form.AsControl<DataGridView>("dataMachinary");
//    var dataMaterial = form.AsControl<DataGridView>("dataMaterial");
//    var dataAdditional = form.AsControl<DataGridView>("dataAdditional");
//    instance.StartTransaction();
//    var itemId = instance.UseProcedure("").InserGetId<long, dynamic>(data);
//    int itemSequent1 = 1;
//    if (dataLabor.Rows.Count > 0)
//    {
//        foreach (DataGridViewRow iRow in dataLabor.Rows)
//        {
//            if (iRow.IsNewRow) break;
//            var data1 = new
//            {
//                ItemRefID = itemId,
//                BOQLineSequense = itemSequent1,
//                BOQItemLineRefID = iRow.GetValue("laborBOQItemLineRefID"),
//                UOMRefID = iRow.GetValue("laborUomRefID"),
//                BOQItemLineQty = iRow.GetValue<double>("laborBOQItemLineQty"),
//                IsQtyInPercentage = 0,
//                Amount = iRow.GetValue<double>("Column4")
//            };

//            instance.UseProcedure("ItemBoqLineCreate").InsertOrUpdate(data1);
//            itemSequent1++;
//        }
//    }
//    if (dataMachinary.Rows.Count > 0)
//    {
//        foreach (DataGridViewRow iRow in dataMachinary.Rows)
//        {
//            if (iRow.IsNewRow) break;
//            itemSequent1++;
//            var data1 = new
//            {
//                ItemRefID = itemId,
//                BOQLineSequense = itemSequent1,
//                BOQItemLineRefID = iRow.GetValue("mnrItemID"),
//                UOMRefID = iRow.GetValue("mnrUomRefID"),
//                BOQItemLineQty = iRow.GetValue<double>("mnrQuantity"),
//                IsQtyInPercentage = 0,
//                Amount = iRow.GetValue<double>("mnrCost"),
//            };

//            instance.UseProcedure("ItemBoqLineCreate").InsertOrUpdate(data1);

//        }
//    }
//    if (dataMaterial.Rows.Count > 0)
//    {
//        foreach (DataGridViewRow iRow in dataMaterial.Rows)
//        {
//            if (iRow.IsNewRow) break;
//            itemSequent1++;
//            var data1 = new
//            {
//                ItemRefID = itemId,
//                BOQLineSequense = itemSequent1,
//                BOQItemLineRefID = iRow.GetValue("mtrItemRefId"),
//                UOMRefID = iRow.GetValue("mtrUomRefID"),
//                BOQItemLineQty = iRow.GetValue("mtrQuantity"),
//                IsQtyInPercentage = 0,
//                Amount = iRow.GetValue("mtrCost"),
//            };

//            instance.UseProcedure("ItemBoqLineCreate").InsertOrUpdate(data1);

//        }
//    }
//    if (dataAdditional.Rows.Count > 0)
//    {
//        foreach (DataGridViewRow iRow in dataAdditional.Rows)
//        {
//            if (iRow.IsNewRow) break;
//            itemSequent1++;
//            var data1 = new
//            {
//                ItemRefID = itemId,
//                BOQLineSequense = itemSequent1,
//                BOQItemLineRefID = iRow.GetValue("AdditionalID"),
//                UOMRefID = "",
//                BOQItemLineQty = iRow.GetValue("Rate"),
//                IsQtyInPercentage = 1,
//                Amount = iRow.GetValue("addAmount"),
//            };

//            instance.UseProcedure("ItemBoqLineCreate").InsertOrUpdate(data1);

//        }
//    }
//    var data2 = new
//    {
//        ItemRefID = itemId,
//        BOQLineSequense = ++itemSequent1,
//        BOQItemLineRefID = 6,
//        UOMRefID = "",
//        BOQItemLineQty = form.AsControl<TextBox>("textMargin").AsNumber<decimal>(),
//        IsQtyInPercentage = 1,
//        Amount = form.AsControl<TextBox>("textTotalMargin").AsNumber<decimal>(),
//    };
//    instance.UseProcedure("ItemBoqLineCreate").InsertOrUpdate(data2);
//    var data3 = new
//    {
//        ItemRefID = itemId,
//        BOQLineSequense = ++itemSequent1,
//        BOQItemLineRefID = 7,
//        UOMRefID = "",
//        BOQItemLineQty = form.AsControl<TextBox>("textInflation").AsNumber<decimal>(),
//        IsQtyInPercentage = 1,
//        Amount = form.AsControl<TextBox>("textTotalInlfation").AsNumber<decimal>(),
//    };
//    instance.UseProcedure("ItemBoqLineCreate").InsertOrUpdate(data3);
//    instance.ComitTransaction();

//}
//public static void UpdateItemBoqLine(this Form form, long itemId, object data)
//{
//    var dataLabor = form.AsControl<DataGridView>("dataLabor");
//    var dataMachinary = form.AsControl<DataGridView>("dataMachinary");
//    var dataMaterial = form.AsControl<DataGridView>("dataMaterial");
//    var dataAdditional = form.AsControl<DataGridView>("dataAdditional");
//    var dataTemp = form.AsControl<DataGridView>("dataTemp");
//    instance.StartTransaction();
//    instance.UseProcedure("ItemUpdate")
//        .InsertOrUpdate(data);
//    if (dataLabor.Rows.Count > 0)
//    {
//        int itemSequent1 = 1;
//        foreach (DataGridViewRow iRow in dataLabor.Rows)
//        {
//            if (iRow.IsNewRow) break;

//            if (ItemExist(itemId, iRow.GetValue<long>("laborBOQItemLineRefID")))
//            {
//                var data1 = new
//                {
//                    ItemRefID = itemId,
//                    BOQItemLineRefID = iRow.GetValue("laborBOQItemLineRefID"),
//                    BOQItemLineQty = iRow.GetValue<double>("laborBOQItemLineQty"),
//                    BOQLineSequense = itemSequent1,
//                    Amount = iRow.GetValue<double>("Column4")
//                };
//                instance.UseProcedure("ItemBoqLineUpdate").InsertOrUpdate(data1);
//            }
//            else
//            {
//                var data1 = new
//                {
//                    ItemRefID = itemId,
//                    BOQLineSequense = itemSequent1,
//                    BOQItemLineRefID = iRow.GetValue("laborBOQItemLineRefID"),
//                    UOMRefID = iRow.GetValue("laborUomRefID"),
//                    BOQItemLineQty = iRow.GetValue<double>("laborBOQItemLineQty"),
//                    IsQtyInPercentage = 0,
//                    Amount = iRow.GetValue<double>("Column4")
//                };
//                instance.UseProcedure("ItemBoqLineCreate").InsertOrUpdate(data1);
//            }
//            itemSequent1++;
//        }
//    }
//    if (dataMachinary.Rows.Count > 0)
//    {
//        int itemSequent1 = 1;
//        foreach (DataGridViewRow iRow in dataMachinary.Rows)
//        {
//            if (iRow.IsNewRow) break;

//            if (ItemExist(itemId, iRow.GetValue<long>("mnrItemID")))
//            {
//                var data1 = new
//                {
//                    ItemRefID = itemId,
//                    BOQItemLineRefID = iRow.GetValue("mnrItemID"),
//                    BOQItemLineQty = iRow.GetValue<double>("mnrQuantity"),
//                    BOQLineSequense = itemSequent1,
//                    Amount = iRow.GetValue<double>("mnrCost"),
//                };
//                instance.UseProcedure("ItemBoqLineUpdate").InsertOrUpdate(data1);
//            }
//            else
//            {
//                var data1 = new
//                {
//                    ItemRefID = itemId,
//                    BOQLineSequense = itemSequent1,
//                    BOQItemLineRefID = iRow.GetValue("mnrItemID"),
//                    UOMRefID = iRow.GetValue("mnrUomRefID"),
//                    BOQItemLineQty = iRow.GetValue<double>("mnrQuantity"),
//                    IsQtyInPercentage = 0,
//                    Amount = iRow.GetValue<double>("mnrCost"),
//                };
//                instance.UseProcedure("ItemBoqLineCreate").InsertOrUpdate(data1);
//            }
//            itemSequent1++;

//        }
//    }
//    if (dataMaterial.Rows.Count > 0)
//    {
//        int itemSequent1 = 1;
//        foreach (DataGridViewRow iRow in dataMaterial.Rows)
//        {
//            if (iRow.IsNewRow) break;
//            if (ItemExist(itemId, iRow.GetValue<long>("mtrItemRefID")))
//            {
//                var data1 = new
//                {
//                    ItemRefID = itemId,
//                    BOQItemLineRefID = iRow.GetValue("mtrItemRefID"),
//                    BOQItemLineQty = iRow.GetValue<double>("mtrQuantity"),
//                    BOQLineSequense = itemSequent1,
//                    Amount = iRow.GetValue<double>("mtrCost"),
//                };
//                instance.UseProcedure("ItemBoqLineUpdate").InsertOrUpdate(data1);
//            }
//            else
//            {
//                var data1 = new
//                {
//                    ItemRefID = itemId,
//                    BOQLineSequense = itemSequent1,
//                    BOQItemLineRefID = iRow.GetValue("mtrItemRefId"),
//                    UOMRefID = iRow.GetValue<double>("mtrUomRefID"),
//                    BOQItemLineQty = iRow.GetValue("mtrQuantity"),
//                    IsQtyInPercentage = 0,
//                    Amount = iRow.GetValue<double>("mtrCost"),
//                };
//                instance.UseProcedure("ItemBoqLineCreate").InsertOrUpdate(data1);
//            }
//            itemSequent1++;
//        }
//    }
//    if (dataAdditional.Rows.Count > 0)
//    {
//        int itemSequent1 = 1;
//        foreach (DataGridViewRow iRow in dataAdditional.Rows)
//        {
//            if (iRow.IsNewRow) break;
//            var data1 = new
//            {
//                ItemRefID = itemId,
//                BOQLineSequense = itemSequent1,
//                BOQItemLineRefID = iRow.GetValue("AdditionalID"),
//                BOQItemLineQty = iRow.GetValue<double>("Rate"),
//                Amount = iRow.GetValue<double>("addAmount"),
//            };
//            instance.UseProcedure("ItemBoqLineUpdate").InsertOrUpdate(data1);
//            itemSequent1++;
//        }
//    }
//    var data2 = new
//    {
//        ItemRefID = itemId,
//        BOQItemLineRefID = 6,
//        BOQItemLineQty = form.AsControl<TextBox>("textMargin").AsNumber<decimal>(),
//        BOQLineSequense = 1,
//        Amount = form.AsControl<TextBox>("textTotalMargin").AsNumber<decimal>(),
//    };
//    instance.UseProcedure("ItemBoqLineUpdate").InsertOrUpdate(data2);
//    var data3 = new
//    {
//        ItemRefID = itemId,
//        BOQItemLineRefID = 7,
//        BOQLineSequense = 1,
//        BOQItemLineQty = form.AsControl<TextBox>("textInflation").AsNumber<decimal>(),
//        Amount = form.AsControl<TextBox>("textTotalInlfation").AsNumber<decimal>(),
//    };
//    instance.UseProcedure("ItemBoqLineUpdate").InsertOrUpdate(data3);

//    //if (dataTemp.Rows.Count > 0)
//    //{
//    //    foreach (DataGridViewRow row in dataTemp.Rows) 
//    //    {
//    //        if (row.IsNewRow) continue;
//    //        if (ItemExist(row.GetValue<long>("col1"), row.GetValue<long>("col2")))
//    //        {
//    //            var ItemRefID = row.GetValue<long>("col1");
//    //            var BOQItemLineRefID = row.GetValue<long>("col2");
//    //            instance.UseSql("DELETE FROM [dbo].[ITEMBOQLINE] WHERE ItemRefID=@ItemRefID AND BOQItemLineRefID=@BOQItemLineRefID;")
//    //                    .Where(new { ItemRefID=ItemRefID,BOQItemLineRefID=BOQItemLineRefID })
//    //                    .Delete();
//    //        }
//    //    }
//    //}
//    instance.ComitTransaction();
//}
//public static void DisplayDataOnDataGrid(this Form form, DataGridView grid, long itemId, string itemType)
//{
//    var sql = @"SELECT ItemItemName,ItemItemQty,ItemItemAbbreviation,ItemItemAmount
//                        ,(ItemItemAmount * ItemItemQty) AS Amount,ItemID,ItemItemUOMRefID FROM vBoq WHERE 
//                        ItemId=@ItemID AND ItemItemType=@itemType";
//    instance.UseSql(sql)
//        .FindAsTable(new { itemId = itemId, itemType = itemType })
//        .UsePlainDataToGridView(grid);
//}
//public static void DisplayDataOnDataGrid(this Form form, DataGridView grid, long itemId)
//{
//    var sql = @"SELECT ItemItemName,ItemItemQty,ItemItemAbbreviation,ItemItemAmount
//                        ,(ItemItemAmount * ItemItemQty) AS Amount,ItemItemRefID,UOMRefID FROM vBoq WHERE 
//                        ItemId=@ItemID";
//    instance.UseSql(sql)
//        .FindAsTable(new { itemId = itemId })
//        .UsePlainDataToGridView(grid);
//}
//public static void GetBoQInfo(this Form form, long itemId, TextBox txtName, TextBox txtDesc, Label label)
//{
//    var sql = "SELECT Name,Description,EditSequense FROM [Item] WHERE ItemId=@ItemID;";
//    if (instance.UseSql(sql)
//        .FindOne(new { itemId = itemId }, out DataRow dr))
//    {
//        txtName.SetText(dr.GetValue<string>("Name"));
//        txtDesc.SetText(dr.GetValue<string>("Description"));
//        label.SetText(dr.GetValue<string>("EditSequense"));
//    }
//}
//public static void GetBoQInfo(this Form form, long itemId, TextBox txtName, TextBox txtDesc)
//{
//    var sql = "SELECT Name,Description,EditSequense FROM [Item] WHERE ItemId=@ItemID;";
//    if (instance.UseSql(sql)
//        .FindOne(new { itemId = itemId }, out DataRow dr))
//    {
//        txtName.SetText(dr.GetValue<string>("Name"));
//        txtDesc.SetText(dr.GetValue<string>("Description"));
//    }
//}
//public static (decimal cost, decimal salePrice, long uomRefId) GetBoqCostAndPrice(this Form form, long itemId)
//{
//    var sql = "SELECT Cost,Price,UomRefID FROM [Item] WHERE ItemId=@ItemID AND [Type]='Bill Of Quantity';";
//    if (instance.UseSql(sql)
//        .FindOne(new { itemId = itemId }, out DataRow result))
//    {
//        var _cost = result.GetValue<decimal>(0);
//        var _price = result.GetValue<decimal>(1);
//        var _uomRefId = result.GetValue<long>(2);
//        return (_cost, _price, _uomRefId);
//    }
//    return (0, 0, 0);
//}
//public static (decimal rate, decimal totalMargin, bool bMarin) GetBoqMargin(this Form form, long itemId)
//{
//    var sql = "SELECT ItemItemQty,ItemItemAmount FROM [vBoq] WHERE ItemId=@ItemID AND [ItemItemType]='margin';";
//    if (instance.UseSql(sql)
//        .FindOne(new { itemId = itemId }, out DataRow result))
//    {
//        var rate = result.GetValue<decimal>(0);
//        var totalMargin = result.GetValue<decimal>(1);
//        return (rate, totalMargin, true);
//    }
//    return (0, 0, false);
//}
//public static (decimal rate, decimal totalInlfation, bool bInlfation) GetBoqInflation(this Form form, long itemId)
//{
//    var sql = "SELECT ItemItemQty,ItemItemAmount FROM [vBoq] WHERE ItemId=@ItemID AND [ItemItemType]='inflation';";
//    if (instance.UseSql(sql)
//        .FindOne(new { itemId = itemId }, out DataRow result))
//    {
//        var rate = result.GetValue<decimal>(0);
//        var totalInlfation = result.GetValue<decimal>(1);
//        return (rate, totalInlfation, true);
//    }
//    return (0, 0, false);
//}
//public static void GetAdditionalCost(this Form form, DataGridView grid, long itemId)
//{
//    var sql = "SELECT ItemItemName,ItemLineQty,ItemItemAmount,ItemLineRefID FROM vItemLineWithUom WHERE ItemRefId=@ItemID AND ItemItemType='additional cost';";
//    instance.UseSql(sql)
//        .FindAsTable(new { itemId = itemId })
//        .UseDataTableAsGridView(grid);
//}