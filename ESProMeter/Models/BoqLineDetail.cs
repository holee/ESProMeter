using ESProMeter.IViews;
using System;
namespace ESProMeter.Models
{
    public class BoqLineDetail : IBoqLine
    {
        public long BOQID
        {
            get;
            set;
        }
        public long BOQLINEID
        {
            get;
            set;
        }
        public int BOQLineSequense
        {
            get;
            set;
        }
        public long ItemBOQRefID
        {
            get;
            set;
        }
        public long ItemBOQUOMRefID
        {
            get;
            set;
        }
        public double ItemBOQQty
        {
            get;
            set;
        }
        public long ItemBOQLineRefID
        {
            get;
            set;
        }
        public long ItemBOQLineUOMRefID
        {
            get;
            set;
        }
        public double ItemBOQLineQty
        {
            get;set;
        } = 0;
        public bool IsQtyInPercentage { get; set; }
        public double Amount { get; set; }
    }
}
