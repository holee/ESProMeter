using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESProMeter.IVews
{
	public interface INCConnection
	{
		string serverName { get; set; }
		string dbName { get; set; }
		string login { get; set; }
		string pwd { get; set; }
		string comName { get; set; }
	}
}
