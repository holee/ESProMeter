using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESProMeter.IVews
{
    public interface ITUom 
    {
		public long ID { get; set; }
		public DateTime CDT { get; set; }
		public DateTime MDT { get; set; }
		public int EDSEQ { get; set; }
		public string UOMNAME { get; set; }
		public string ABBREVIATION { get; set; }
		public byte ISACTIVE { get; set; }
		public string TYPE { get; set; }

	}
}
