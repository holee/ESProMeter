using System;

namespace ESProMeter.Models
{
    public class Item:BaseEntity
    {
        public long ItemID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public byte IsActive { get; set; } = 0;
        public int UomRefId { get; set; }
        public decimal Cost { get; set; }
        public decimal Price { get; set; }
    }
}
