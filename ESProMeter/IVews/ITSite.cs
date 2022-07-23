using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESProMeter.IVews
{
    public interface ITSite
    {
		public long ID { get; set; }
		public DateTime CDT { get; set; }
		public DateTime MDT { get; set; }
		public int EDSEQ { get; set; }
		public string SITENAME { get; set; }
		public string DESCRIPTION { get; set; }
		public long ADDRESSID { get; set; }
		public long CUSTOMERID { get; set; }
		public byte ISACTIVE { get; set; }
	}
}
