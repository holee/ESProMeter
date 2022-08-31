namespace ESProMeter.Models
{
    public class VBOQITEM
    {
        public long ID { get; set; }
        public string ITEMNAME { get; set; }
        public string DESCRIPTION { get; set; }
        public string ITEMTYPE { get; set; }
        public byte ISACTIVE { get; set; }
        public string UOMNAME { get; set; }
        public string UOM { get; set; }
        public decimal COST { get; set; }
        public decimal ISRATE { get; set; }
        public int EDSEQ { get; set; }
        public long UOMID { get; set; }
        public decimal BOGCOST { get; set; }
    }
}
