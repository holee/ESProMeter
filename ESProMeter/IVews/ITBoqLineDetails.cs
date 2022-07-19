using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESProMeter.IVews
{
    public interface ITBoqLineDetails
    {
		public long BOQID { get; set; }
		public long BOQITEMID { get; set; }
		public decimal BOQITEMQTY { get; set; }
		public int BOQLINELineSeq { get; set; }
		public long BOQITEMITEMLINEID { get; set; }
		public string BOQITEMITEMLINETYPE { get; set; }
		public long BOQITEMITEMLINEUOMID { get; set; }
		public decimal BOQITEMITEMLINEQTY { get; set; }
		public byte ISQTYINPERCENTAGE { get; set; }
		public decimal AMOUNT { get; set; }
		public long UID { get; set; }
	}
}
