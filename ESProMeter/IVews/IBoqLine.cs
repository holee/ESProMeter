namespace ESProMeter.IViews
{
    public interface IBoqLine
    {
        long BOQID { get; set; }
        long BOQLINEID { get; set; }
        int BOQLineSequense { get; set; }
        long ItemBOQRefID { get; set; }
        long ItemBOQUOMRefID { get; set; }
        double ItemBOQQty { get; set; }
        long ItemBOQLineRefID { get; set; }
        long ItemBOQLineUOMRefID { get; set; }
        double ItemBOQLineQty { get; set; }
        bool IsQtyInPercentage { get; set; }
        double Amount { get; set; }
    }
}
