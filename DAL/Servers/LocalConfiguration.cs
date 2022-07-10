using ESProMeter.Contracts;
using System;
namespace DAL.Servers  
{
    public class LocalConfiguration : ILocalConfiguration
    {
        private string _attachDbFile;
        public string AttchachDbFile 
        { 
            get => _attachDbFile; 
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("no local database was supply.");
                _attachDbFile = value;
            } 
        }
        public LocalConfiguration(string _dbFile)
        {
            this._attachDbFile = _dbFile;
        }
        public LocalConfiguration()
        {
            this._attachDbFile = "";
        }
        public string GetConnectionString
        {
            get
            {
                try
                {
                    var connectionString = $@"Data Source =(LocalDB)\MSSQLLocalDB;
                        AttachDbFilename={_attachDbFile};Integrated Security=true;MultipleActiveResultSets=True;";
                    return connectionString;
                }
                catch (Exception)
                {
                    return string.Empty;
                }
            }
        }

    }
}
