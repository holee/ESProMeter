using ESProMeter.IVews;
namespace ESProMeter.Models
{
    public class TBOQLINE: ITBOQLINE
    {
		public long BOQID { get; set; }
		public long BOQITEMID { get; set; }
		public int LineSeq { get; set; }
		public string NO { get; set; }
		public string BOQITEMDESC { get; set; }
		public long BOQITEMUOMID { get; set; }
		public decimal BOQITEMQTY { get; set; }
		public string REMARKS { get; set; }
		public long UID { get; set; }
        public decimal LOSSOFEFFECIENCYRATE { get; set; }
        public decimal LOSSOFEFFECIENCY { get; set; }
        public decimal OPERATIONRATE { get; set; }
        public decimal OPERATION { get; set; }
        public decimal OVERHEADRATE { get; set; }
        public decimal OVERHEAD { get; set; }
        public decimal SAFETYRATE { get; set; }
        public decimal SAFETY { get; set; }
        public decimal TRANSPORTATIONRATE { get; set; }
        public decimal TRANSPORTATION { get; set; }
        public decimal MARGINRATE { get; set; }
        public decimal MARGIN { get; set; }
        public decimal INFlATIONRATE { get; set; }
        public decimal INFlATION { get; set; }
    }
}
