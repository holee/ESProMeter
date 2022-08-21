using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESProMeter.IVews
{
    public interface IADDITIONALCOST
    {
        public decimal? LOSSOFEFFECIENCY { get; set; }
        public decimal? OPERATION { get; set; }
        public decimal? OVERHEAD { get; set; }
        public decimal? SAFETY { get; set; }
        public decimal? TRANSPORTATION { get; set; }
        public decimal? MARGIN{ get; set; }
        public decimal? INFlATION { get; set; }
    }
}
