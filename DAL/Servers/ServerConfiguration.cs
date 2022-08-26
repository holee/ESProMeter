using ESProMeter.Contracts;
using System;
namespace DAL.Servers
{
    public class ServerConfiguration : IServerConfiguration
    {
        string _serverName;
        string _databaseName;
        string _userID;
        string _password;
        bool _auth;
        public ServerConfiguration()
        {

        }
        public ServerConfiguration(string srv, string userId, string databse, string password,bool auth=false)
        {
            _serverName = srv;
            _userID = userId;
            _databaseName = databse;
            _password = password;
            _auth = auth;
        }
        public string ServerName { get => _serverName; set => _serverName=value; }
        public string DatabaseName { get => _databaseName; set => _databaseName=value; }
        public string UserID { get => _userID; set => _userID=value; }
        public string Password { get => _password; set => _password=value; }
        public bool Auth { get=> _auth; set=>_auth=value; }
        public string GetConnectionString
        {
            get
            {
                try
                {
                    if (!_auth)
                    {
                        return $"server={_serverName};database={_databaseName};User Id={_userID};password={_password};";
                    }
                    return $"server={_serverName};database={_databaseName};integrated security=false;";
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
        }

       
    }
}
