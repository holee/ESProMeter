using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESProMeter.IVews
{
    public interface IItem
    {
        string ItemName { get; set; }
        string ItemType { get; set; }
        long UomId { get; set; }
        decimal Cost { get; set; }
        string Description { get; set; }
        bool IsActive { get; set; }
    }
}
