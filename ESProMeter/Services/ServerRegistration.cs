using DAL.Servers;
using ESProMeter.Properties;
using System;
using System.Data.SqlClient;
namespace ESProMeter.Services
{
    public class ServerRegistration
    {
        private static SqlConnection connection = null;

        //It is use to open SQL connection for testing and the server information is not
        //register in the system.
        public static bool TestConnection(string srv, string db, string uid, string pwd)
        {
            try
            {
                if (CheckServerRegsiteration(srv, db, uid, pwd))
                {
                    return true;
                }
                return false;

            }
            catch (Exception)
            {
                return false;
            }

        }

        //It is use to open LocalDB connection for testing and the server information is not
        //register in the system.
        public static bool TestConnection(string FilePath)
        {
            SqlConnection cnn = new SqlConnection();
            try
            {
                cnn.ConnectionString = $@"Data Source =(LocalDB)\MSSQLLocalDB;
                    AttachDbFilename={FilePath};integrated Security=IntegratedSecurity;";
                cnn.Open();
                //cnn.ConnectionString = @"Data Source =(LocalDB)\MSSQLLocalDB;" +
                //    "AttachDbFilename=" + FilePath + "; Integrated Security =true;";
                //cnn.Open();
                DBConnection.ConfigLocalDb(option => option.AttchachDbFile = FilePath)
                            .Connect().Open();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool SetRegisterKey(string srv, string db, string userid, string pwd)
        {
            try
            {
                Settings.Default.serverName = srv;
                Settings.Default.database = db;
                Settings.Default.userID = userid;
                Settings.Default.Password = pwd;
                Settings.Default.DBFilePath = "";
                Settings.Default.isLDB = false;
                Settings.Default.Save();
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
        public static bool SetRegisterKey(string dbFP)
        {
            try
            {
                Settings.Default.serverName = string.Empty;
                Settings.Default.userID = string.Empty;
                Settings.Default.database = string.Empty;
                Settings.Default.Password = string.Empty;
                Settings.Default.DBFilePath = dbFP;
                Settings.Default.isLDB = true;
                Settings.Default.Save();
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
        public static bool ChekedServerRegistrationInfo(bool isLocalDb = true)
        {
            try
            {
                if (!isLocalDb)
                {
                    var srv = Settings.Default.serverName;
                    var db = Settings.Default.database;
                    var userId = Settings.Default.userID;
                    var pwd = Settings.Default.Password;
                    if (CheckServerRegsiteration(srv, db, userId, pwd))
                    {
                        return true;
                    }
                }
                else
                {
                    var dbFile = Settings.Default.DBFilePath;
                    if (CheckServerRegsiteration(dbFile))
                    {
                        return true;
                    }
                }

                return false;

            }
            catch (Exception)
            {
                return false;
            }
        }

        public static string GetConnectionString
        {
            get
            {
                try
                {
                    var srv = Settings.Default.serverName;
                    var db = Settings.Default.database;
                    var userId = Settings.Default.userID;
                    var pwd = Settings.Default.Password;
                    return $"server={srv};database={db};User Id={userId};password={pwd};";

                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
        }
        private static bool CheckServerRegsiteration(string srv, string db, string userid, string pwd)
        {
            try
            {

                if (connection == null)
                {
                    connection = new SqlConnection($"server={srv};database={db};User Id={userid};password={pwd};");
                    connection.Open();
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }


        private static bool CheckServerRegsiteration(string dbFile)
        {
            try
            {
                var connString = $@"Data Source =(LocalDB)\MSSQLLocalDB;
                        AttachDbFilename={dbFile};Integrated Security=true;MultipleActiveResultSets=True;";
                if (connection == null)
                {
                    connection = new SqlConnection(connString);
                    connection.Open();
                }
                else
                {
                    connection = null;
                    connection = new SqlConnection(connString);
                    connection.Open();
                }

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

    }
}
