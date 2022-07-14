using Microsoft.Data.Sqlite;
namespace ESProMeter.Services
{
    public class SysDBConnection
    {
        public SqliteConnection GetConnection()
        {
            var _connection = new SqliteConnection("Data Source=sysDB.db");
            return _connection;
        }
    }
}
