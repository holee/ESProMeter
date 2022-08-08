using ESProMeter.Services;
using ESProMeter.Extensions;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using ESProMeter.DataAccess;
using ESProMeter.IVews;
using ESProMeter.Enums;

namespace ESProMeter.Controllers
{

   

    public static class UomController
    {
        public static void ShowAllUomWithDataGrid(this Form form,byte active=0,int page=10)
        {
            if(AppService.UomGetInstance.GetAllUoms(active,page,out var table))
            {
                form.AsControl<DataGridView>("dataUom").DataSource = table;
            }
        }
        public static void ShowAllUomWithDataGrid(this Form form,long uomId, byte active=0,int page=10)
        {
            if (AppService.UomGetInstance.GetAllUoms(active,page, out var table))
            {
                var container = form.AsControl<DataGridView>("dataUom");
                container.DataSource = table;
                if (container.Rows.Count > 0)
                {
                    foreach (DataGridViewRow row in container.Rows)
                    {
                        if (row.Cells["ID"].Value.Equals(uomId))
                        {
                            row.Selected = true;
                            break;
                        }
                        else continue;
                    }
                }
            }
        }
        public static void AddNewUom(this Form form,ITUom uom)
        {
            AppService.UomGetInstance.UomCreate(uom);
        }
        public static void AddOrUpdate(this Form form,ActionType action, ITUom uom)
        {
            switch (action)
            {
                case ActionType.CREATE:
                    AppService.UomGetInstance.UomCreate(uom);
                    break;
                case ActionType.EDIT:
                    AppService.UomGetInstance.UomUpdate(uom);
                    break;
                case ActionType.DELETE:
                    break;
                default:
                    break;
            }
            
        }
        //public static bool UpdateUom(this Form form, ITUom uom)
        //{
        //    try
        //    {
        //        //var txtName = form.AsTextBox("txtUoM").Text.Trim();
        //        //var txtDescription = form.AsTextBox("txtDescription").Text.Trim();
        //        //var txtType = form.AsCombobox("cmbType").Text;
        //        //var lblUom = form.AsLabel("lblUomID").AsNumber<long>();
        //        //var lblEditSequence = form.AsLabel("lblEditSequense").AsNumber<int>();
        //        //var isActive = form.AsCheckedBox("chkInactive").Checked ? 0 :1 ;
        //        //connection = (SqlConnection)ConnectionService.Connection;
        //        //GetService.UpdateUom(connection,lblUom, txtName, txtType, txtDescription, lblEditSequence, isActive, null);
        //        return true;
        //    }
        //    catch
        //    {
        //        return false;
        //    }

        //}
        //public static bool CheckUomExist(this Form form,string name)
        //{
        //    //var count = DbAccess.UseSql("SELECT COUNT(*) FROM [dbo].[Uom] WHERE Name=@UomName")
        //    //         .Where(new { UomName = name })
        //    //         .Count();
        //    //return count > 0;

        //    return false;
        //}
        //public static bool CheckUomExistWithSame(this Form form, string name,long UomId) 
        //{
        //    //var count = DbAccess.UseSql("SELECT COUNT(*) FROM [dbo].[Uom] WHERE Name=@UomName AND UomId <> @UomId")
        //    //         .Where(new { UomName = name,UomId= UomId })
        //    //         .Count();
        //    //return count > 0;
        //    return false;
        //}
        //public static bool UpdateUom(this Form form)
        //{
        //    try
        //    {
        //        //var txtName = form.AsTextBox("txtUoM").Text.Trim();
        //        //var txtDescription = form.AsTextBox("txtDescription").Text.Trim();
        //        //var txtType = form.AsCombobox("cmbType").Text;
        //        //var lblUom = form.AsLabel("lblUomID").AsNumber<long>();
        //        //var lblEditSequence = form.AsLabel("lblEditSequense").AsNumber<int>();
        //        //var isActive = form.AsCheckedBox("chkInactive").Checked ? 0 :1 ;
        //        //connection = (SqlConnection)ConnectionService.Connection;
        //        //GetService.UpdateUom(connection,lblUom, txtName, txtType, txtDescription, lblEditSequence, isActive, null);
        //        return true;
        //    }
        //    catch
        //    {
        //        return false;   
        //    }

        //}
        //public static void ShowUomForm(this Form form)
        //{
        //    try
        //    {
        //        //connection = (SqlConnection)ConnectionService.Connection;
        //        //if(TypeService.GetAllType(out DataTable table,"Uom"))
        //        //{
        //        //    form.AsCombobox("cmbType").DataSource = table;
        //        //    form.AsCombobox("cmbType").ValueMember = "type";
        //        //    form.AsCombobox("cmbType").DisplayMember = "type";
        //        //}
                
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception(ex.Message);
        //    }
        //}
        //public static void ShowUomForm(this Form form,long UomId)
        //{
        //    try
        //    {
        //        //connection = (SqlConnection)ConnectionService.Connection;
        //        //if (GetService.GetAUomById(connection,UomId,out DataTable table))
        //        //{
        //        //    var row = table.Rows[0];
        //        //    form.AsTextBox("txtUoM").Text=row.Field<string>("Name");
        //        //    form.AsTextBox("txtDescription").Text = row.Field<string>("Abbreviation");
        //        //    form.AsCombobox("cmbType").Text =row.Field<string>("Type");
        //        //    form.AsLabel("lblEditSequense").Text = row.Field<int>("EditSequense").ToString();
        //        //    form.AsLabel("lblUomID").Text = row.Field<long>("UomID").ToString();
        //        //    form.AsCheckedBox("chkInactive").Checked=row.Field<byte>("IsActive")==0?true:false;
                    
        //       // }

        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception(ex.Message);
        //    }
        //}
        //public static void ShowDataDataGrid(this Form form)
        //{
        //    try
        //    {
        //        //connection = (SqlConnection)ConnectionService.Connection;
        //        //if (GetService.GetAllUoms(connection,out DataTable table))
        //        //{
        //        //    form.AsDataGrid("dataUom").DataSource = table;
        //        //}

        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception(ex.Message);
        //    }
        //}
        public static bool DeleteUomById(this Form form,long id)
        {
            try
            {
                if (AppService.UomGetInstance.IsUomAlreadyUsed(id))
                {
                    throw new Exception("UOM Already in use.");
                }
                return AppService.UomGetInstance.Delete(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public static bool MakeInactive(this Form form, long id,byte isActive=0)
        {
            try
            {
                return AppService.UomGetInstance.MakeInactive(id, isActive);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }



    }
}
