using ESProMeter.DataAccess;
namespace ESProMeter.Services
{
    public class SysDbUtility
    {
        private static SysDbAccess? _sysDbAccess;
        public static SysDbAccess? GetInstance
        {
            get
            {
                if (_sysDbAccess == null)
                {
                    _sysDbAccess = new SysDbAccess();
                }
                return _sysDbAccess;
            }
        }



    }
}
