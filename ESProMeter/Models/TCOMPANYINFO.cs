using ESProMeter.IVews;
using System;

namespace ESProMeter.Models
{
    public class TCOMPANYINFO: ITCOMPANYINFO
    {
		public int ID { get; set; }
		public int EDSEQ { get; set; }
		public string COMPANYNAME { get; set; }
		public string LEGALCOMPANYNAME { get; set; }
		public string ALTLEGALCOMPANYNAME { get; set; }
		public int CONTADDRESSID { get; set; }
		public int LEGALADDRESSID { get; set; }
		public string MAINPHONE { get; set; }
		public string ALTPHONE { get; set; }
		public string FAX { get; set; }
		public string EMAIL { get; set; }
		public string WEBSITE { get; set; }
		public string LOGOFILEPATH { get; set; }
		public DateTime CDT { get; set; }
		public DateTime MDT { get; set; }
        public string ADDRESS { get; set; }
        public string PROVINCE { get; set; }
        public string COUNTRY { get; set; }
        long ITAddressInfo.ID { get; set; }
    }
}
