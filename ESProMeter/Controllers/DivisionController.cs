//using System;
//using ESProMeter.Services;
//using System.Data;
//using System.Windows.Forms;
//using ESProMeter.Extensions;
//using ESProMeter.IViews;
//using ESProMeter.DataAccess;

//namespace ESProMeter.Controllers
//{
//	public static class DivisionController
//	{
//		private static readonly SqlAccess instance = DataUtility.GetInstance;
//		public static bool GetAllDivision(out DataTable table, params string[] columns) 
//		{
//			string sql = columns.Length == 0 ? "*" : string.Join(",", columns);
//			var sql1 = $"SELECT {sql} FROM [dbo].[DIVISION];";
//			table = instance.UseSql(sql1).FindAsTable<dynamic>(null);
//			if (table.Rows.Count == 0)
//			{
//				return false;
//			}
//			return true;

//		}
//		public static bool AddNewDivision(this Form form,IDivision division)
//		{
//            try
//            {
//				instance.UseProcedure("")
//                   .InsertOrUpdate<dynamic>(new
//                   {
//                       DivName = division.DivName,
//                       Description = division.Description,
//                       IsActive = division.IsActive
//                   });

//                return true;
//            }
//            catch (Exception ex)
//            {
//				return false;
//            }
//            finally
//            {
//				di.CloseConnection();
//			}

//        }
//        public static bool UpdateDivision(this Form form,IDivision division)
//		{
//			try
//			{
//				return DbService.GetInstance
//									 .UseProcedure(AppConstants.DivisionUpdate)
//									 .UpSert(
//									new
//									{
//										division.DivID,
//										division.DivName,
//										division.Description,
//										IsActive = division.IsActive,
//										division.EditSequense
//									}) > 0;
//			}
//			catch (Exception ex)
//			{
//				throw new Exception(ex.Message);
//			}

//		}
//		public static bool DivisionDelete(this Form form,long id)
//		{
//			try
//			{
//				var data = new
//				{
//					DivId=id,
//				};
//				if(DbService.GetInstance.UseSql("DELETE FROM [dbo].[DIVISION] WHERE DIVID=@DivId")
//						.Delete(new { DivId= id })>0)
//                {
//                    return true;
//                }
//				return false;
//            }
//			catch (Exception ex)
//			{
//				throw new Exception(ex.Message);
//			}

//		}
//		public static void ShowFormData(this Form form, long id,IDivision division)
//		{
//			if (DbService.GetInstance
//                                .UseSql("SELECT * FROM [dbo].[DIVISION];")
//                               .Find<long>("DivId", id, out DataRow row))
//            {
//                division.DivID = row.GetValue<long>("DivId");
//				division.DivName = row.GetValue<string>("Name");
//				division.IsActive = !row.GetValue<bool>("IsActive");
//				division.Description = row.GetValue<string>("Description"); 
//				division.EditSequense= row.GetValue<int>("EditSequense");
//			}

//		}
//		public static void DisplayDividionOnDataGrid(this Form form,bool includeInActive,params string[] columns)
//        {
//			var sql1 = columns.Length == 0 ? "*" : string.Join(",", columns);
//			object where = null;
//            if (includeInActive)
//            {
//				var sql= $"SELECT {sql1} FROM division ORDER BY DivId DESC;";
//				DbService.GetInstance.UseSql(sql)
//				.AsTable<dynamic>(where).AsDataGrid(form.AsDataGrid("dataGridView1"));
//			}
//            else
//            {
//				var sql = $"SELECT {sql1} FROM division WHERE isActive=@isActive ORDER BY DivId DESC;";
//				where = new { isActive = true };
//				DbService.GetInstance.UseSql(sql)
//				.AsTable<dynamic>(where).AsDataGrid(form.AsDataGrid("dataGridView1"));
//			}
			
//		}
//		public static bool MakeDividionActiveOrInActive(this Form form,bool isActive=false)
//		{
//			var id = form.AsDataGrid("dataGridView1").AsNumber<long>("Column1");
//			if(DbService.GetInstance.UseProcedure(AppConstants.DivisionInActive)
//				.UpSert(new{isActive = isActive,DivId=id}) > 0)
//            {
//				form.AsDataGrid("dataGridView1").SetText("Column4", isActive);
//				return true;
//            }
//			return false;
//		}
//	}
//}
