using ESProMeter.IViews;
using System;
namespace ESProMeter.Models
{
    public class TBOQ : ITBOQ
    {
		public long ID { get; set; }
		public DateTime CDT { get; set; }
		public DateTime MDT { get; set; }
		public int EDSEQ { get; set; }
		public string REFNUMBER { get; set; }
		public string BOQTITLE { get; set; }
		public string BOQDESC { get; set; }
		public long CUSTOMERID { get; set; }
		public DateTime BOQDATE { get; set; }
		public DateTime VALIDDATE { get; set; }
		public byte ISACTIVE { get; set; }
		public long SITEID { get; set; }
		public long DIVID { get; set; }
		public string TERMSCONDITION { get; set; }
		public int STATUS { get; set; }
		public long UID { get; set; }
	}
}
