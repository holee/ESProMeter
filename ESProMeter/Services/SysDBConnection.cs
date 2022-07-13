using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
