using System;
using System.Collections.Generic;
using System.Data;

namespace ESProMeter.DataAccess 
{
    //public interface ISqlDbAccess
    //{
    //    DataTable SelectMany();
    //    List<T> SelectManyMany<T,U>(U parameters) where T : class;
    //    T SelectSingle<T,U>(U paramteres) where T : class;
    //    T SelectSingle<T>(Func<T,bool> prediction) where T : class;
    //    DataRow SelectSingle<T>(T parameters,params string[] columns);
    //    DataRow SelectSingle();
    //    IEnumerable<TResult> SelectTwoTable<T1,T2,TResult,U>(Func<T1,T2,TResult> map, U parameters,string split="Id") where TResult : class;
    //    IEnumerable<TResult> SelectThreeTable<T1, T2,T3, TResult, U>(Func<T1, T2,T3, TResult> map,U parameters) where TResult : class;
    //    IEnumerable<TResult> Select<T1, T2,T3,T4, TResult, U>(Func<T1, T2,T3,T4, TResult> map, U parameters) where TResult : class;
    //    List<T> SelectAsList<T>(Func<T, bool> prediction) where T : class;
        
    //    int Delete();
    //    int SaveChanged();
    //    int Count();
    //    void SaveMany();
    //}


    public interface IUseSqlAccess  
    {
        ISqlAccess UseSql(string sql);
        ISqlAccess UseProcedure(string sql);
        ISqlAccess CreateConnection(string connectionstring);
        void CloseConnection();
    }
    public interface IUseTabe 
    {
        ISqlAccess UseTable(string table);
    }
    public interface ISqlAccess 
    {
        void StartTransaction();
        DataTable FindAsTable<T>(T parameters);
        bool FindAsTable<T>(T parameters,out DataTable table);
        bool FindMany<T>(T parameters,out DataTable table); 
        bool FindOne<T>(string colName,T value, out DataRow row);
        bool FindOne<T>(T paramaters , out DataRow row);
        bool FindOne<T,U>(U paramaters, out T TResult) where T:class;
        bool FindMany<T, U>(U paramaters, out List<T> TResult);
        DataRow FindAsDataRow<TCol,TValue>(string colName, TValue value);
        T InserGetId<T,U>(U parameters);
        int InsertOrUpdate<T>(T parameter);
        int InsertFromTable<T>(T parameter);
        int InsertFromTable(string ParamName,DataTable data,string typeName);
        int Delete<T>(T parameter);
        T SelectOne<T, U>(U parameter);
        T Count<T,U>(U parameter);  
        IEnumerable<T> SelectMany<T, U>(U paramter);
        IEnumerable<TResult> Select<TRelation1, TRelation2, TResult, U>(Func<TRelation1, TRelation2, TResult> map, U parameters, string split = "Id")
          where TResult : class;
        IEnumerable<TResult> Select<TRelation1, TRelation2, TRelation3, TResult, U>(Func<TRelation1, TRelation2, TRelation3, TResult> map, U parameters)
        where TResult : class;
        IEnumerable<TResult> Select<TRelation1, TRelation2, TRelation3, TRelation4, TResult, U>(Func<TRelation1, TRelation2, TRelation3, TRelation4, TResult> map, U parameters)
        where TResult : class;

    }


}
