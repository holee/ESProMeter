using Microsoft.Data.Sqlite;
namespace ESProMeter.Services
{
    public class SysDBConnection
    {
        public SqliteConnection GetConnection()
        {
            return new SqliteConnection("Data Source=sysDB.db");
        }





    }
}
