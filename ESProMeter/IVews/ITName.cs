using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESProMeter.IVews
{
    public interface ITName:ITAddressInfo
    {
		new public long ID { get; set; }
		public DateTime CDT { get; set; }
		public DateTime MDT { get; set; }
		public int EDSEQ { get; set; }
		public string NAME { get; set; }
		public string NAMETYPE { get; set; }
		public byte ISACTIVE { get; set; }
		public string SALUTATION { get; set; }
		public string FIRSTNAME { get; set; }
		public string LASTNAME { get; set; }
		public string JOBTITLE { get; set; }
		public long ADDRESSID { get; set; }
		public string MAINPHONE { get; set; }
		public string ALTPHONE { get; set; }
		public string FAX { get; set; }
		public string EMAIL { get; set; }
		public string WEBSITE { get; set; }
		public decimal CREDITLIMIT { get; set; }
	}
}
