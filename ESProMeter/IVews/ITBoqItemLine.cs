using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESProMeter.IVews
{
    public interface ITBoqItemLine
    {
        public long BOQITEMID { get; set; }
        public long BOQITEMLINEID { get; set; }
        public int BOQITEMLINESEQ { get; set; }
        public long BOQITEMLINEUOMID { get; set; }
        public decimal BOQITEMLINEQTY { get; set; }
    }
   
}
