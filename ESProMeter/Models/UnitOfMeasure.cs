using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESProMeter.Models
{
    public class UnitOfMeasure
    {
        public int UomID { get; set; }
        public string Name { get; set; }
        public string EditSequent { get; set; }
        public bool IsActive { get; set; }
        public string Description { get; set; }
        public DateTime CreatedTime { get; set; }
        public DateTime ModifiedTime { get; set; }

    }
}
