using ESProMeter.Contracts;
using System;
using System.Data;
using System.Data.SqlClient;
namespace DAL.Servers   
{
    public class DBConnection : 
        IServerSelection,
        IUserSelection,
        IDatabaseSelection,
        IPasswordSelection,
        IConnectionStringSelection,
        IDatabaseInitializer
    {
        private string _server;
        private string _database;
        private string _user;
        private string _password;
        private static ServerConfiguration _configuration=null;
        private static LocalConfiguration _localConfiguration=null;
        private SqlConnection _connection=null;
        private static bool isLocalDb = false;
        private DBConnection() { }

        public static DBConnection Config()
        {
            return new DBConnection();
        }
        public static DBConnection ConfigLocalDb(Action<ILocalConfiguration> options)
        {
            isLocalDb = true;
            _localConfiguration = new LocalConfiguration();
            options?.Invoke(_localConfiguration);
            return new DBConnection();
        }
        public static DBConnection Config(Action<IServerConfiguration> options)
        {
            isLocalDb = false;
            _configuration =new ServerConfiguration();
            options?.Invoke(_configuration);
            return new DBConnection();
        }
        public IUserSelection AddDatabase(string database)
        {
           _database = database;
            return this;
        }

        public IDatabaseInitializer AddPassword(string password)
        {
            _password= password;
            return this;

        }

        public IDatabaseSelection AddServer(string server)
        {
            _server = server;
            return this;
        }

        public IPasswordSelection AddUser(string username)
        {
            _user = username;
            return this;
        }
        public IDbConnection Connect()
        {
            try
            {
                if (isLocalDb)
                {
                    if (_connection == null)
                    {
                        _connection = new SqlConnection(_localConfiguration.GetConnectionString);
                    }
                    else
                    {
                        _connection = null;
                        _connection = new SqlConnection(_localConfiguration.GetConnectionString);
                    }
                }
                else
                {
                    if (_configuration == null)
                        _configuration = new ServerConfiguration(_server, _user, _database, _password);
                    if (_connection == null)
                    {
                        _connection = new SqlConnection(_configuration.GetConnectionString);
                    }
                    else
                    {
                        _connection = null;
                        _connection = new SqlConnection(_configuration.GetConnectionString);
                    }
                  
                }

                return _connection;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            
        }

        public IConnectionStringSelection SetPassword(string password)
        {
            this._password=password;
            return this;
        }

        public string GetConnectionString()
        {
            try
            {
                if (isLocalDb)
                {
                    return _localConfiguration.GetConnectionString;
                }
                else
                {
                    if (_configuration == null)
                        _configuration = new ServerConfiguration(_server, _user, _database, _password);
                    return _configuration.GetConnectionString;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
