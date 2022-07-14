using DAL.Servers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ESProMeter.Properties;
using ESProMeter.Sessions;

namespace ESProMeter.Services
{
    public class ConnectionService
    {
        private static IDbConnection? _connection = null;

        public static IDbConnection Connection
        {
            get
            {
                if (_connection == null)
                {
                    if (Settings.Default.isLDB)
                    {
                        _connection = DBConnection.ConfigLocalDb(local =>
                        {
                            local.AttchachDbFile = Settings.Default.DBFilePath;
                        }).Connect();
                    }
                    else
                    {
                        _connection = DBConnection.ConfigServerDb(opt =>
                        {
                            opt.ServerName = Settings.Default.serverName;
                            opt.DatabaseName = Settings.Default.database;
                            opt.UserID = Settings.Default.userID;
                            opt.Password = Settings.Default.Password;
                        }).Connect();
                    }

                    _connection.Open();
                }
                else
                {
                    if (Settings.Default.isLDB)
                    {
                        _connection = DBConnection.ConfigLocalDb(local =>
                        {
                            local.AttchachDbFile = Settings.Default.DBFilePath;
                        }).Connect();
                    }
                    else
                    {
                        _connection = DBConnection.ConfigServerDb(opt =>
                        {
                            opt.ServerName = Settings.Default.serverName;
                            opt.DatabaseName = Settings.Default.database;
                            opt.UserID = Settings.Default.userID;
                            opt.Password = Settings.Default.Password;
                        }).Connect();
                    }

                    _connection.Open();
                }
                return _connection;

            }
        }

        public static string GetConnectionString
        {
            get
            {
                if (Settings.Default.isLDB)
                {
                    return DBConnection.ConfigLocalDb(local =>
                    {
                        local.AttchachDbFile = Settings.Default.DBFilePath;
                    }).GetConnectionString();
                }
                else
                {
                    return DBConnection.Config()
                                       .AddServer(Settings.Default.serverName)
                                       .AddDatabase(Settings.Default.database)
                                       .AddUser(Settings.Default.userID)
                                       .SetPassword(Settings.Default.Password)
                                       .GetConnectionString();
                }
            }
        }

        public static string ConnectionString() 
        {
               return DBConnection.Config()
                                  .AddServer(UserSession.ServerName??"")
                                  .AddDatabase(UserSession.DatabaseName ?? "")
                                  .AddUser(UserSession.UserName ?? "")
                                  .SetPassword(UserSession.Password ?? "")
                                  .GetConnectionString();
        }


    }
}
