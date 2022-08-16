using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESProMeter.IVews
{
    public interface ITACTIVITY
    {
        public long ID { get; set; }
        public int EDSEQ { get; set; }
        public long BOQID { get; set; }
        public string ACTNAME { get; set; }
        public string DESCRIPTION { get; set; }
        public int STATUS { get; set; }
        public byte ISACTIVE { get; set; }
        public DateTime CDT { get; set; }
        public DateTime MDT { get; set; }
    }
}
