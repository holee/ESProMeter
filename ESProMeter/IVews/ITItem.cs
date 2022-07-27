using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESProMeter.IVews
{
    public interface ITItem
    {
        public long ID { get; set; }
        public string ITEMNAME { get; set; }
        public string DESCRIPTION { get; set; }
        public string ITEMTYPE { get; set; }
        public long UOMID { get; set; }
        public decimal COST { get; set; }
        public byte ISACTIVE { get; set; }
        public byte ISRATE { get; set; }
        public int EDSEQ { get; set; }
        public DateTime? CDT { get; set; }
        public DateTime? MDT { get; set; }
    }
}