using ESProMeter.IViews;
using System;
namespace ESProMeter.Models
{
    public class TBOQ : ITBOQ
    {
		
		//public TBOQ(ITBOQ boq)
		//{
		//	ID = boq;
		//	CDT = boq;
		//	MDT = boq;
		//	EDSEQ = boq;
		//	REFNUMBER = boq;
		//	BOQTITLE = boq;
		//	BOQDESC = boq;
		//	CUSTOMERID = boq;
		//	BOQDATE = boq;
		//	VALIDDATE = boq;
		//	ISACTIVE = boq;
		//	SITEID = boq;
		//	DIVID = boq;
		//	TERMSCONDITION = boq;
		//	STATUS = boq;
		//	UID = boq;
		//	LOSSOFEFFECIENCYRATE = boq;
		//	OPERATIONRATE = boq;
		//	OVERHEADRATE = boq;
		//	SAFETYRATE = boq;
		//	TRANSPORTATIONRATE = boq;
		//	MARGINRATE = boq;
		//	INFlATIONRATE = boq;
		//}

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
        public decimal LOSSOFEFFECIENCYRATE { get; set; }
        public decimal OPERATIONRATE { get; set; }
        public decimal OVERHEADRATE { get; set; }
        public decimal SAFETYRATE { get; set; }
		public decimal TRANSPORTATIONRATE { get; set; }
        public decimal MARGINRATE { get; set; }
        public decimal INFlATIONRATE { get; set; }
    }
}
