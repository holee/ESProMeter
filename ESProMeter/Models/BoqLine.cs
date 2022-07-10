using ESProMeter.IViews;
using System;
namespace ESProMeter.Models
{
    public class BoqLine
    {
        public long BOQLINEID { get ; set ; }
        public long BOQRefID { get; set; } 
        public int BOQLineSequense {  get ; set ; }
        public long ItemBOQUOMRefID { get ; set ; }
        public long ItemBOQLineUOMRefID { get ; set ; }
        public double ItemBOQLineQty { get; set; } = 0;
        public decimal ItemBOQPrice { get; set; } = 0;
        public string Remark { get; set; } = string.Empty;

    }
}
