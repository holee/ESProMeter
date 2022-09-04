﻿using System.Windows.Forms;
using ESProMeter.Extensions;
using ESProMeter.Services;
using ESProMeter.Views.Items;
using ESProMeter.Enums;
using System.Data;
using ESProMeter.Models;

namespace ESProMeter.Controllers
{
    public static class ItemController
    {
        /// <summary>
        /// Get Items And Boqs
        /// </summary>
        /// <param name="form"></param>
        /// <param name="grid"></param>
        /// <param name="page"></param>
        /// <param name="columns"></param>
        public static void GetItemsWithBoq(this Form form, DataGridView grid,int page,string sort,params string[] columns)
        {
            if (page <= 0)
            {
                if (AppService.GetItemInstance.GetAllItems(1, out var table))
                {
                    table.WithColumn(columns).UseDataTableAsGridView(grid);
                }
            }
            else
            {
                if (AppService.GetItemInstance.GetAllItems(1,page,sort, out var table))
                {
                    table.WithColumn(columns).UseDataTableAsGridView(grid);
                }
            }
        }
        public static void GetItemsWithoutBoq(this Form form, DataGridView grid,string itemType, params string[] columns) 
        {
            if (AppService.GetItemInstance.GetItemsWithoutBoq(1, itemType, out var table))
            {
                table.WithColumn(columns).UseDataTableAsGridView(grid);
            }
        }
        public static void GetItemsWithoutBoqByName(this Form form,string itemName,string itemType, DataGridView grid, params string[] columns)
        {
            if (AppService.GetItemInstance.GetItemeWithoutBoqByName(1,itemName, itemType, out var table))
            {
                table.WithColumn(columns).UseDataTableAsGridView(grid);
            }
        }
        public static void GetBoqItems(this Form form, DataGridView grid, string itemName, params string[] columns)
        {
            if (AppService.GetItemInstance.GetBoqItems(1, itemName, out var table))
            {
                table.WithColumn(columns).UseDataTableAsGridView(grid);
            }
        }
        public static void GetBoqItemById(this Form form,long boqId,ref VBOQITEM item)
        {
            item = new();
            AppService.GetItemInstance.GetBoqItemById(boqId,out item);
        }
        public static void ShowItemList(this Form form, DataGridView grid,byte isActive)
        {
            ((DataTable)grid.DataSource)?.Rows.Clear();
            if (AppService.GetItemInstance.GetAllItems(isActive,out var table))
            {
                grid.DataSource = table;
            }

        }
        public static bool MakeItemInactiveOrActive(this Form form,long id,byte i)
        {
            return AppService.GetItemInstance.MakeInActiveOrActive(id, i);
        }
        public static void ShowItemList(this Form form, DataGridView grid, byte isActive,
            int page,string fieldName="ItemName",string orderBy="asc")
        {
            ((DataTable)grid.DataSource)?.Rows.Clear();
            if (AppService.GetItemInstance.GetAllItems(isActive,page,orderBy, out var table))
            {
                grid.DataSource = table;
            }

        }
        public static void ShowItemList(this Form form, DataGridView grid, byte isActive,
           int page, string orderBy = "ASC")
        {
            ((DataTable)grid.DataSource)?.Rows.Clear();
            if (AppService.GetItemInstance.GetAllItems(isActive, page,orderBy, out var table))
            {
                grid.DataSource = table;
            }

        }
        public static void ShowItemList(this Form form,string itemName, DataGridView grid, byte isActive=1,
            int page=50, string orderBy = "ASC")
        {

            ((DataTable)grid.DataSource)?.Rows.Clear();
            if (AppService.GetItemInstance.GetAllItems(itemName,isActive, page,orderBy, out var table))
            {
                grid.DataSource = table;
            }

        }
        public static bool IsItemExist(this Form form, string itemName)
        {
            return AppService.GetItemInstance.ItemAlreadyExist(itemName);
        }
        public static bool IsItemExist(this Form form,long itemId, string itemName)
        {
            return AppService.GetItemInstance.ItemSame(itemId,itemName);
        }
        /// <summary>
        /// BOQ Operation
        /// </summary>
        /// <param name="form"></param>
        /// <param name="itemId"></param>
        /// <param name="item"></param>
        /// <param name="columns"></param>
        public static void GetItemForUpdate(this Form form,ItemsType itemType, long itemId,AddItemFrm item)
        {
            switch(itemType)    
            {
                case ItemsType.Boq:
                     if (AppService.GetItemInstance.GetBoqItemWithItemLineById(itemId, item, out var labour,out var machinery,out var material))
                     {
                        item.AsControl<DataGridView>("dgvLabor").DataSource = labour.WithColumn("BOQITEMLINEID", "BOQITEMITEMLINENAME", "BOQITEMITEMLINETYPE", "UOM", "BOQITEMLINEUOMID","COST", "BOQITEMLINEQTY", "BOQITEMLINESEQ");
                        item.AsControl<DataGridView>("dgvMachinary").DataSource = machinery.WithColumn("BOQITEMLINEID", "BOQITEMITEMLINENAME", "BOQITEMITEMLINETYPE", "UOM", "BOQITEMLINEUOMID", "COST", "BOQITEMLINEQTY", "BOQITEMLINESEQ");
                        item.AsControl<DataGridView>("dgvMaterial").DataSource = material.WithColumn("BOQITEMLINEID", "BOQITEMITEMLINENAME", "BOQITEMITEMLINETYPE", "UOM", "BOQITEMLINEUOMID", "COST", "BOQITEMLINEQTY", "BOQITEMLINESEQ");
                    }
                    break;
                case ItemsType.Item:
                    AppService.GetItemInstance.GetItemById(itemId, item);
                    break;
            }
        }
        public static void GetItemForUpdate(this Form form,long itemId)
        {
            if (AppService.GetItemInstance.GetBoqItemWithItemLineById(itemId,out var labour))
            {
                form.AsControl<DataGridView>("dgvBoqItemLine").DataSource = labour.WithColumn("BOQITEMLINEID", "BOQITEMITEMLINENAME", "BOQITEMITEMLINETYPE", "UOM", "BOQITEMLINEUOMID", "BOQITEMLINEQTY", "BOQITEMLINESEQ", "COST", "SUBCOST");
            }
        }
        public static void GetItemForUpdate(this Form form,long boq_id,long itemId)
        {
            if (AppService.GetItemInstance.GetBoqItemWithItemLineById(itemId, out var labour, out var machinery, out var material))
            {
                form.AsControl<DataGridView>("dgvLabor").DataSource = labour.WithColumn("BOQITEMLINEID", "BOQITEMITEMLINENAME", "BOQITEMITEMLINETYPE", "UOM", "BOQITEMLINEUOMID", "BOQITEMLINEQTY", "BOQITEMLINESEQ", "COST", "SUBCOST");
                form.AsControl<DataGridView>("dgvMachinary").DataSource = machinery.WithColumn("BOQITEMLINEID", "BOQITEMITEMLINENAME", "BOQITEMITEMLINETYPE", "UOM", "BOQITEMLINEUOMID", "BOQITEMLINEQTY", "BOQITEMLINESEQ", "COST", "SUBCOST");
                form.AsControl<DataGridView>("dgvMaterial").DataSource = material.WithColumn("BOQITEMLINEID", "BOQITEMITEMLINENAME", "BOQITEMITEMLINETYPE", "UOM", "BOQITEMLINEUOMID", "BOQITEMLINEQTY", "BOQITEMLINESEQ", "COST", "SUBCOST");
            }
        }
        public static void ShowItemType(this Form form, ComboBox storage)
        {
            if(AppService.GetItemInstance.GetItemsType(out var table)){
                table.WithColumn("ID", "TYPENAME")
                        .AsCombobox(storage, "TYPENAME", "ID");
            }

        }
        public static void ShowUom(this Form form, ComboBox storage)
        {
            if (AppService.UomGetInstance.GetAllUoms(1, out var table))
            {
                table.WithColumn("Abbreviation", "ID")
                       .AsCombobox(storage, "Abbreviation", "ID");
            }
        }

        /// <summary>
        /// Create and Update Items
        /// </summary>
        /// <param name="form"></param>
        /// <param name="itemFrm"></param>
        /// <param name="itemType"></param>

        public static void ItemCreate(this Form form,AddItemFrm itemFrm,ItemsType itemType)
        {
            switch (itemType)
            {
                case ItemsType.Item:
                    AppService.GetItemInstance.ItemCreate(itemFrm);
                    break;
                case ItemsType.Boq:
                    var constainer = itemFrm.AsControl<DataGridView>("dgvBoq");
                    AppService.GetItemInstance.BoqCreateItemLine(itemFrm, constainer);
                    break;
                default:
                    break;
            }    
        }
        public static VBOQITEM BoqItemCreate(this Form form,AddItemFrm itemFrm)
        {
            var item = new VBOQITEM();
            var constainer = itemFrm.AsControl<DataGridView>("dgvBoq");
            var result=AppService.GetItemInstance.BoqCreateItemLineGetId(itemFrm, constainer);
            if (result.success)
            {
                AppService.GetItemInstance
                            .GetBoqItemById(result.id,out item);
            }
            return item;
        }
        public static void ItemCreate(this Form form, AddItemFrm itemFrm,DataTable table, ItemsType itemType)
        {
            switch (itemType)
            {
                case ItemsType.Item:
                    AppService.GetItemInstance.ItemCreate(itemFrm);
                    break;
                case ItemsType.Boq:
                    AppService.GetItemInstance.BoqCreateItemLine(itemFrm, table);
                    break;
                default:
                    break;
            }
        }
        public static void ItemUpdate(this Form form,AddItemFrm item,ItemsType itemType) 
        {
            switch(itemType)
            {
                case ItemsType.Item:
                    AppService.GetItemInstance.ItemUpdate(item);
                break;
                case ItemsType.Boq:
                    var constainer = item.AsControl<DataGridView>("dgvBoq");
                    AppService.GetItemInstance.BoqUpdateItemLine(item, constainer);
                break;
                default:
                    break;
            }
        }

        /// <summary>
        /// Items And Boq Delete
        /// </summary>
        /// <param name="form"></param>
        /// <param name="isActive"></param>
        /// <returns></returns>

        public static bool MakeItemActiveOrInActive(this Form form, bool isActive = false)
        {
            //var id = form.AsDataGrid("dataItemList").AsNumber<long>("Column1");
            //var sql = "UPDATE [dbo].[Item] SET IsActive=@IsActive WHERE ItemID=@ItemID";
            //if (instance.UseSql(sql)
            //    .InsertOrUpdate(new { isActive = isActive, ItemID = id }) > 0)
            //{
            //    form.AsDataGrid("dataItemList").SetText("Column12", isActive);
            //    return true;
            //}
            return false;
        }
        public static bool DeleteItem(this Form form, long id)
        {
            try
            {
                if (!AppService.GetItemInstance.ItemIsInUsed(id))
                {
                    return AppService.GetItemInstance.DeleteItemWithBoq(id);
                }
                else 
                {
                    MessageBox.Show("You cannot delete this item while it is in used.","Delete Item");
                    return false; 
                }
            }
            catch (System.Exception)
            {
                return false;
            }

        }
    }
}

