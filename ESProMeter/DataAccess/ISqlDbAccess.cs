using System.Data;
namespace ESProMeter.DataAccess 
{

    public interface IUseSqlAccess  
    {
        ISqlAccess UseSql(string sql);
        ISqlAccess UseProcedure(string sql);
        ISqlAccess CreateConnection(string connectionstring);
        void CloseConnection();
    }
    public interface ISqlAccess 
    {
        void StartTransaction();
        DataTable FindAsTable<T>(T parameters);
        bool FindAsTable<T>(T parameters,out DataTable table);
        bool FindOne<T>(T paramaters , out DataRow row);
        bool Exist(object paramaters);
        T InsertGetId<T,U>(U parameters);
        int InsertOrUpdate<T>(T parameter);
        int InsertFromTable<T>(T parameter);
        int InsertFromTable(string ParamName,DataTable data,string typeName);
        int Delete<T>(T parameter);
        T Count<T,U>(U parameter);  
    }


}
