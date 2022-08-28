using Microsoft.SqlServer.Dac;
using Microsoft.SqlServer.TransactSql.ScriptDom;
using System.Collections.Generic;

namespace ESProMeter.DataAccess
{
    public class SqlUtility
    {
        private readonly DacDeployOptions _deployOptions;
        private DacServices dacServices=null;
        public SqlUtility()
        {
            _deployOptions = new DacDeployOptions
            {
                BlockOnPossibleDataLoss = false,
                IncludeCompositeObjects = true,
                IncludeTransactionalScripts = true,
                //DropConstraintsNotInSource deployConfig.DropConstraintsNotInSource,
                //DropIndexesNotInSource = deployConfig.DropIndexesNotInSource,
                CreateNewDatabase =true,
                DropDmlTriggersNotInSource = false,
                DeployDatabaseInSingleUserMode = true
            };
        }

        public void DeployDatabase(string databasePath,string dbname)
        {
            dacServices = new DacServices("Data Source=.;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;");
            dacServices.Deploy(DacPackage.Load(databasePath), dbname, true, options: _deployOptions);
        }
        public void DeployDatabase(DacServices svr,string databasePath, string dbname)
        {
            svr.Deploy(DacPackage.Load(databasePath), dbname, true, options: _deployOptions);
        }
        public void ExportDacPac(string databasePath, string dbname)
        {
            //dacServices.Extract(databasePath, dbname);
            System.Threading.Thread.Sleep(1000);
        }


    }
}
