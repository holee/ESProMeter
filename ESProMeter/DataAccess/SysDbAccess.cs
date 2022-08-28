using ESProMeter.Services;
using Microsoft.Data.Sqlite;
using System.Data;
using ESProMeter.IVews;

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

        public bool DeleteCompanies(INCConnection server)
        {
            
            using (SqliteConnection con = GetInstance.GetConnection())
            {
                con.Open();
                using SqliteCommand command = con.CreateCommand();
                var sql = "DELETE FROM TCOMP WHERE  CompanyName=@0 and ServerName=@1 and DBName=@2 and UName = @3 and Password=@4";
                command.CommandText = sql;
                command.Parameters.AddWithValue("@0", server.comName);
                command.Parameters.AddWithValue("@1", server.serverName);
                command.Parameters.AddWithValue("@2", server.dbName);
                command.Parameters.AddWithValue("@3", server.login);
                command.Parameters.AddWithValue("@4", server.pwd);
                var result = command.ExecuteNonQuery();
                return result > 0;
            }
        }

        public bool InsertCompanyDbInfo(INCConnection server)  
        {
            using (SqliteConnection con = GetInstance.GetConnection())
            {
                con.Open();
                using SqliteCommand command = con.CreateCommand();
                var sql = "INSERT INTO TCOMP(CompanyName,ServerName,DBName,UName,Password,isActive) VALUES(@0,@1,@2,@3,@4,@5)";
                command.CommandText = sql;
                command.Parameters.AddWithValue("@0", server.comName);
                command.Parameters.AddWithValue("@1", server.serverName);
                command.Parameters.AddWithValue("@2", server.dbName);
                command.Parameters.AddWithValue("@3", server.login);
                command.Parameters.AddWithValue("@4", server.pwd);
                command.Parameters.AddWithValue("@5", true);
                var result = command.ExecuteNonQuery();
                return result > 0;
            }
        }

        public bool isConnectionEstablished(INCConnection server)
        {
            var table = new DataTable();
            using (SqliteConnection con = GetInstance.GetConnection())
            {
                con.Open();
                using SqliteCommand command = con.CreateCommand();
                var sql = "SELECT * FROM TCOMP WHERE CompanyName=@0 and ServerName=@1 and DBName=@2 and UName = @3 and Password=@4";
                command.CommandText = sql;
				command.Parameters.AddWithValue("@0", server.comName);
				command.Parameters.AddWithValue("@1", server.serverName);
				command.Parameters.AddWithValue("@2", server.dbName);
				command.Parameters.AddWithValue("@3", server.login);
				command.Parameters.AddWithValue("@4", server.pwd);
                var result = command.ExecuteReader(CommandBehavior.CloseConnection);
                table.Load(result);
                return table.Rows.Count > 0;
            }
        }
    }
}
