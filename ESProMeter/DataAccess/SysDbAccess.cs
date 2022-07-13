using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESProMeter.DataAccess
{
    public class SysDbAccess
    {
        private string? _connectionString;

        public SysDbAccess(string connectionString)
        {
            _connectionString = connectionString;
        }

        public bool GetCompanies(out DataTable table,params string[] columns) 
        {
            table = new DataTable();
            using (IDbConnection connection = new SqlConnection(_connectionString))
            {
                var sql = columns.Length == 0 ? "*" : string.Join(",", columns);
                connection.Open();
                var result=connection.ExecuteReader($"SELECT {sql} FROM TCOMP WHERE IsActive=1;", null);
                table.Load(result);
                return table.Rows.Count > 0;
            };
            
        }





    }
}
