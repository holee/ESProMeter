namespace ESProMeter.Models
{
    public class ItemBoqLine
    {
        public long ItemRefID { get; set; }
        public long BoqLineSequent { get; set; }
        public long BoqItemLineRefID { get; set; }
        public long UomRefID { get; set; }
        public decimal BoqItemLineQty { get; set; }
        public int IsQtyInPercentage { get; set; } =0;
        public decimal Amount { get; set; }=0;

    }
}
