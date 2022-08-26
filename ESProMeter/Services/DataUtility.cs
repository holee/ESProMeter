using ESProMeter.DataAccess;
namespace ESProMeter.Services
{
    public class DataUtility
    {
        private static SqlAccess sqlAccess = null;

        public static SqlAccess GetInstance
        {
            get
            {
                if (sqlAccess == null)
                {
                    sqlAccess = new SqlAccess(ConnectionService.ConnectionString());
                }
                return sqlAccess;
            }

        }
    }
}
