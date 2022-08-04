namespace ESProMeter.IVews
{
    public interface ITBOQLINE
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
	}
}
