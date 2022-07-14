using ESProMeter.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESProMeter.Services
{
    public class DataUtility
    {
        private static SqlAccess? sqlAccess = null;

        public static SqlAccess GetInstance
        {
            get
            {
                if (sqlAccess == null)
                {
                    sqlAccess = new SqlAccess(ConnectionService.GetConnectionString??ConnectionService.ConnectionString());
                }
                return sqlAccess;
            }

        }
    }
}
