using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace ESProMeter.DataAccess 
{
    public class SqlAccess:IDisposable,IUseSqlAccess,ISqlAccess,IUseTabe
    {
        private IDbConnection? _connection;
        private IDbTransaction? _transaction;
        private CommandType? _commandType;
        private string _connectionString=string.Empty;
        private string _sql=string.Empty;
        private string _table=string.Empty;
        public SqlAccess()
        {
            _connectionString = string.Empty;
            _connection = null;   
            _transaction = null; 
        }
        public SqlAccess(string sqlString)
        {
            this._connectionString = sqlString;
            _connection=new SqlConnection(_connectionString);
        }
        public ISqlAccess CreateConnection(string connectionstring)
        {
            this._connectionString = connectionstring;
            _connection=new SqlConnection(this._connectionString);
            return this;
        }
        public void StartTransaction()
        {
            if (_connection != null)
            {
                _connection?.Open();
                _transaction = _connection?.BeginTransaction();
            }
        }
        public void CloseConnection()
        {
            _connection?.Close();
        }
        public void ComitTransaction()
        {
            _transaction?.Commit();
            _connection?.Close();
        }
        public void RollbackTransaction()
        {
            _transaction?.Commit();
            _connection?.Close();
        }
        public void Dispose()
        {
            ComitTransaction();

        }
        public ISqlAccess UseSql(string sql)
        {
            this._sql = sql;
            this._commandType = CommandType.Text;
            return this;
        }
        public ISqlAccess UseProcedure(string procedureName)
        {
            this._sql = procedureName;
            this._commandType = CommandType.StoredProcedure;
            return this;
        }
        public int InsertOrUpdate<T>(T parameters)
        {
            return _connection.Execute(_sql, param: parameters, transaction: _transaction, commandType: _commandType);
        }
        public T InserGetId<T,U>(U parameters) 
        {
            return _connection.ExecuteScalar<T>(_sql, param: parameters, commandType: _commandType, transaction: _transaction);
        }
        public T SelectOne<T, U>(U parameters)
        {
            return _connection.QueryFirst<T>(_sql,param: parameters, transaction: _transaction, commandType: _commandType);
        }
        public IEnumerable<T> SelectMany<T, U>(U parameters)
        {
            return _connection.Query<T>(_sql, param: parameters, transaction: _transaction, commandType: _commandType);
        }
        public IEnumerable<TResult> Select<TRelation1, TRelation2, TResult, U>(Func<TRelation1, TRelation2, TResult> map, U parameters, string split = "Id")
           where TResult : class
        {
            return _connection.Query<TRelation1, TRelation2, TResult>(_sql, map, param: parameters, transaction: _transaction, commandType: _commandType, splitOn: split);
        }
        public IEnumerable<TResult> Select<TRelation1, TRelation2, TRelation3, TResult, U>(Func<TRelation1, TRelation2, TRelation3, TResult> map, U parameters)
        where TResult : class
        {
            return _connection.Query<TRelation1, TRelation2, TRelation3, TResult>(_sql, map, param: parameters,transaction: _transaction, commandType: _commandType);
        }
        public IEnumerable<TResult> Select<TRelation1, TRelation2, TRelation3, TRelation4, TResult, U>(Func<TRelation1, TRelation2, TRelation3, TRelation4, TResult> map, U parameters)
        where TResult : class
        {
            return _connection.Query<TRelation1, TRelation2, TRelation3, TRelation4, TResult>(_sql, map, param: parameters,transaction: _transaction, commandType: _commandType);
        }
        public int Delete<T>(T parameter)
        {
            return _connection.Execute(_sql, param: parameter, transaction: _transaction??null, commandType: _commandType);
        }
        public int UpSert<T>(List<T> parameters)
        {
            return _connection.Execute(_sql, param: parameters, transaction: _transaction??null, commandType: _commandType);
        }
        public DataTable FindAsTable<T>(T parameters)
        {
            DataTable table = new DataTable();
            var result = _connection.ExecuteReader(_sql, param: parameters,transaction:_transaction,commandType:_commandType);
            table.Load(result);
            if (table.Rows.Count > 0)
                return table;
            else
                return null;
        }
        public DataRow FindAsDataRow<TCol,TValue>(string colName,TValue value)
        {
            DataTable table = new DataTable();
            var result = _connection.ExecuteReader(_sql, transaction: _transaction, commandType: _commandType);
            table.Load(result);
            var row= table.AsEnumerable()
                .Where(x => x.Field<TCol>(colName).Equals(value))
                .FirstOrDefault();
            if (row != null)
                return row;
            else
                return null;
        }
        public bool FindMany<T>(T parameters,out DataTable table)
        {
            table = new DataTable();
            var result = _connection.ExecuteReader(_sql, param: parameters, transaction: _transaction, commandType: _commandType);
            table.Load(result);
            if (table.Rows.Count > 0)
                return true;
            else
                return false;
        }
        public bool FindOne<T>(string colName,T value,out DataRow row) 
        {
            DataTable table = new DataTable();
            var result = _connection.ExecuteReader(_sql, transaction: _transaction, commandType: _commandType);
            table.Load(result);
            row = table.AsEnumerable()
                .Where(x => x.Field<T>(colName).Equals(value))
                .FirstOrDefault();
            if (row != null)
                return true;
            else
                return false;
        }
        public bool FindOne<T>(T paramaters, out DataRow row)
        {
            DataTable table = new DataTable();
            var result = _connection.ExecuteReader(_sql,param:paramaters, transaction: _transaction, commandType: _commandType);
            table.Load(result);
            row = (from r in table.AsEnumerable()
                  select r).FirstOrDefault();
            if (row != null)
                return true;
            else
                return false;

        }
        public bool FindOne<T, U>(U paramaters, out T TResult) where T:class
        {
            TResult = _connection.Query<T>(_sql,paramaters,transaction: _transaction, commandType: _commandType).FirstOrDefault();
            if(TResult !=null)
            {
                return true;
            }
            return false;
        }
        public bool FindMany<T, U>(U paramaters, out List<T> TResult)
        {
            TResult = _connection.Query<T>(_sql, paramaters, transaction: _transaction, commandType: _commandType).ToList();
            if (TResult.Count>0)
            {
                return true;
            }
            return false;
        }

        public ISqlAccess UseTable(string table)
        {
            _table=table;
            return this;
        }

        public T Count<T, U>(U parameters) 
        {
            return _connection.ExecuteScalar<T>(_sql, parameters, transaction: _transaction, commandType: _commandType);
        }

        public bool FindAsTable<T>(T parameters,out DataTable table)
        {
            var result = _connection.ExecuteReader(_sql, param: parameters, transaction: _transaction, commandType: _commandType);
            table = new DataTable();
            table.Load(result);
            return table.Rows.Count > 0;
        }
    }
}
