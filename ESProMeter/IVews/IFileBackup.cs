using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESProMeter.IVews
{
	interface IFileBackup
	{
		string path { get; set; }
		string name { get; set; }
		byte overwrite { get; set; }
	}
}
