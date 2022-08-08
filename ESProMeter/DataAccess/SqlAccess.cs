using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace ESProMeter.DataAccess 
{
    public class SqlAccess:IDisposable,IUseSqlAccess,ISqlAccess
    {
        private IDbConnection _connection=null;
        private IDbTransaction _transaction=null;
        private CommandType? _commandType;
        private string _connectionString=string.Empty;
        private string _sql=string.Empty;
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
            var affectedRow=_connection.Execute(_sql, param: parameters, transaction: _transaction, commandType: _commandType);
            return affectedRow;
        }
        public int InsertFromTable<T>(T parameter)
        {
            return _connection.Execute(_sql, param: parameter, transaction: _transaction, commandType: _commandType);
        }
        public int InsertFromTable(string ParamName,DataTable table,string typeName)
        {
            Dictionary<string, object> dictionary = new Dictionary<string, object>();

            dictionary.Add(ParamName, table.AsTableValuedParameter(typeName));

            var parameters = new DynamicParameters(dictionary);

            return _connection.Execute(_sql, parameters, transaction: _transaction, commandType: _commandType);
        }
        public T InsertGetId<T,U>(U parameters) 
        {
            return _connection.ExecuteScalar<T>(_sql, param: parameters, commandType: _commandType, transaction: _transaction);
        }
       
        public int Delete<T>(T parameter)
        {
            return _connection.Execute(_sql, param: parameter, transaction: _transaction, commandType: _commandType);
        }
        public DataTable FindAsTable<T>(T parameters)
        {
            DataTable table = new DataTable();
            var result = _connection.ExecuteReader(_sql, param: parameters,transaction:_transaction,commandType:_commandType);
            table.Load(result);
             return table;
        }
        public bool FindAsTable<T>(T parameters, out DataTable table)
        {
            var result = _connection.ExecuteReader(_sql, param: parameters, transaction: _transaction, commandType: _commandType);
            table = new DataTable();
            table.Load(result);
            return table.Rows.Count > 0;
        }
        public bool FindOne<T>(T paramaters, out DataRow row)
        {
            DataTable table = new DataTable();
            var result = _connection.ExecuteReader(_sql,param:paramaters, transaction: _transaction, commandType: _commandType);
            table.Load(result);
            row = table?.AsEnumerable().FirstOrDefault();
            return row != null;
        }
        public T Count<T, U>(U parameters) 
        {
            return _connection.ExecuteScalar<T>(_sql, parameters, transaction: _transaction, commandType: _commandType);
        }

        public bool Exist(object paramaters)
        {
            return _connection.ExecuteScalar<int>(_sql, paramaters, transaction: _transaction, commandType: _commandType) > 0;
        }

    }
}
