using ESProMeter.Services;
using ESProMeter.Extensions;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using ESProMeter.DataAccess;

namespace ESProMeter.Controllers
{
    internal static class UomController
    {

        private static readonly SqlAccess instance = DataUtility.GetInstance;
        
        public static void GetAllUom(this Form form,ComboBox storage,
            string displayMember,
            string valueMember,
            params string[] columns)
        {
            string sql = columns.Length == 0 ? "*" : string.Join(",", columns);
            ((DataTable)storage.DataSource).Clear();
            if(instance.UseSql($"SELECT {sql} FROM TUOM;").FindAsTable<dynamic?>(null,out DataTable table)){
                storage.DisplayMember = displayMember;
                storage.ValueMember = valueMember;
                storage.DataSource=table;
            }
        }
        public static void GetAllUom(this Form form, DataGridView storage,params string[] columns)
        {
            string sql = columns.Length == 0 ? "*" : string.Join(",", columns);
            //((DataTable)storage.DataSource).Rows.Clear();
            if (instance.UseSql($"SELECT {sql} FROM TUOM;").FindAsTable<dynamic?>(null, out DataTable table))
            {
                storage.DataSource = table;
            }
        }
        public static void AddNewUom(this Form form)
        {
            //var txtName = form.AsTextBox("txtUoM").Text.Trim();
            //var txtDescription=form.AsTextArea("txtDescription").Text.Trim();
            //var txtType = form.AsCombobox("cmbType").Text;
            //var isActive = form.AsCheckedBox("chkInactive").Checked ? 0 : 1;
            //try
            //{
            //    connection = (SqlConnection)ConnectionService.Connection;
            //    GetService.AddNewUom(connection, txtName, txtType, txtDescription, null);
            //}
            //catch (Exception ex)
            //{
            //    throw new Exception(ex.Message);
            //}

        }
        public static bool CheckUomExist(this Form form,string name)
        {
            //var count = DbAccess.UseSql("SELECT COUNT(*) FROM [dbo].[Uom] WHERE Name=@UomName")
            //         .Where(new { UomName = name })
            //         .Count();
            //return count > 0;

            return false;
        }
        public static bool CheckUomExistWithSame(this Form form, string name,long UomId) 
        {
            //var count = DbAccess.UseSql("SELECT COUNT(*) FROM [dbo].[Uom] WHERE Name=@UomName AND UomId <> @UomId")
            //         .Where(new { UomName = name,UomId= UomId })
            //         .Count();
            //return count > 0;
            return false;
        }
        public static bool UpdateUom(this Form form)
        {
            try
            {
                //var txtName = form.AsTextBox("txtUoM").Text.Trim();
                //var txtDescription = form.AsTextBox("txtDescription").Text.Trim();
                //var txtType = form.AsCombobox("cmbType").Text;
                //var lblUom = form.AsLabel("lblUomID").AsNumber<long>();
                //var lblEditSequence = form.AsLabel("lblEditSequense").AsNumber<int>();
                //var isActive = form.AsCheckedBox("chkInactive").Checked ? 0 :1 ;
                //connection = (SqlConnection)ConnectionService.Connection;
                //GetService.UpdateUom(connection,lblUom, txtName, txtType, txtDescription, lblEditSequence, isActive, null);
                return true;
            }
            catch
            {
                return false;   
            }

        }
        public static void ShowUomForm(this Form form)
        {
            try
            {
                //connection = (SqlConnection)ConnectionService.Connection;
                //if(TypeService.GetAllType(out DataTable table,"Uom"))
                //{
                //    form.AsCombobox("cmbType").DataSource = table;
                //    form.AsCombobox("cmbType").ValueMember = "type";
                //    form.AsCombobox("cmbType").DisplayMember = "type";
                //}
                
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public static void ShowUomForm(this Form form,long UomId)
        {
            try
            {
                //connection = (SqlConnection)ConnectionService.Connection;
                //if (GetService.GetAUomById(connection,UomId,out DataTable table))
                //{
                //    var row = table.Rows[0];
                //    form.AsTextBox("txtUoM").Text=row.Field<string>("Name");
                //    form.AsTextBox("txtDescription").Text = row.Field<string>("Abbreviation");
                //    form.AsCombobox("cmbType").Text =row.Field<string>("Type");
                //    form.AsLabel("lblEditSequense").Text = row.Field<int>("EditSequense").ToString();
                //    form.AsLabel("lblUomID").Text = row.Field<long>("UomID").ToString();
                //    form.AsCheckedBox("chkInactive").Checked=row.Field<byte>("IsActive")==0?true:false;
                    
               // }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public static void ShowDataDataGrid(this Form form)
        {
            try
            {
                //connection = (SqlConnection)ConnectionService.Connection;
                //if (GetService.GetAllUoms(connection,out DataTable table))
                //{
                //    form.AsDataGrid("dataUom").DataSource = table;
                //}

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public static bool DeleteDataDataGrid(this Form form,long id)
        {
            try
            {
                //connection = (SqlConnection)ConnectionService.Connection;
                //if (GetService.DeleteUom(connection, id))
                //{
                //    return true;
                //}
                return false;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public static bool MakeInactive(this Form form, long id,int isActive=0)
        {
            try
            {
                //connection = (SqlConnection)ConnectionService.Connection;
                //if (GetService.MakeUomInActive(connection, id, isActive))
                //{
                //    return true;
                //}
                return false;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }



    }
}
