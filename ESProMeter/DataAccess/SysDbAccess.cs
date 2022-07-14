using ESProMeter.Services;
using Microsoft.Data.Sqlite;
using System.Data;
namespace ESProMeter.DataAccess
{
    public class SysDbAccess
    {
        private static SysDBConnection? _db;

        private static SysDBConnection GetInstance
        {
            get
            {
                if(_db== null)
                {
                    _db = new SysDBConnection();
                }
                return _db;
            }
        }
        public bool GetCompanies(out DataTable table,params string[] columns) 
        {
            table = new DataTable();
            var sql = columns.Length == 0 ? "*" : string.Join(",", columns);
            using (SqliteConnection con= GetInstance.GetConnection())
            {
                con.Open();
                using SqliteCommand command = con.CreateCommand();
                command.CommandText = $"SELECT {sql} FROM TCOMP WHERE IsActive=1;";
                var result = command.ExecuteReader(CommandBehavior.CloseConnection);
                table.Load(result);
                return table.Rows.Count > 0;
            }
           
           
        }
        public bool InsertCompanyDbInfo(params object[] data)  
        {
            using (SqliteConnection con = GetInstance.GetConnection())
            {
                con.Open();
                using SqliteCommand command = con.CreateCommand();
                var sql = "INSERT INTO TCOMP(CompanyName,ServerName,DBName,UName,Password,isActive) VALUES(@0,@1,@2,@3,@4,@5)";
                command.CommandText = sql;
                command.Parameters.AddWithValue("@0", data[0]);
                command.Parameters.AddWithValue("@1", data[1]);
                command.Parameters.AddWithValue("@2", data[2]);
                command.Parameters.AddWithValue("@3", data[3]);
                command.Parameters.AddWithValue("@4", data[4]);
                command.Parameters.AddWithValue("@5", data[5]);
                var result = command.ExecuteNonQuery();
                return result > 0;
            }
        }
        
    }
}
