using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESProMeter.IVews
{
    public interface IItem
    {
        public long Id { get; set; }
        public string ItemName { get; set; }
        public string ItemType { get; set; }
        public long UomId { get; set; }
        public decimal Cost { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
    }
}
