using System.Data;
namespace ESProMeter.Contracts
{
    public interface IServerSelection
    {
        IDatabaseSelection AddServer(string database);
    }
    public interface IDatabaseSelection
    {
        IUserSelection AddDatabase(string database);
    }
    public interface IUserSelection
    {
        IPasswordSelection AddUser(string username);
    }
    public interface IPasswordSelection
    {
        IDatabaseInitializer AddPassword(string password);
        IConnectionStringSelection SetPassword(string password);
    }
    public interface IConnectionStringSelection
    {
        string GetConnectionString();
    }
    public interface IDatabaseInitializer
    {
        IDbConnection Connect();
    }
}
