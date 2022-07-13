using DAL.Servers;
using ESProMeter.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESProMeter.Services
{
    public class SysDbUtility
    {
        private static string GetConnectionString()
        {
                return DBConnection.Config()
                                   .AddServer("")
                                   .AddDatabase("")
                                   .AddUser("")
                                   .SetPassword("")
                                   .GetConnectionString();
        }
        private static SysDbAccess? _sysDbAccess;
        public static SysDbAccess? GetInstance
        {
            get
            {
                if (_sysDbAccess == null)
                {
                    _sysDbAccess = new SysDbAccess(GetConnectionString());
                }
                return _sysDbAccess;
            }
        }

    }
}
