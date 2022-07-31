﻿using ESProMeter.IVews;

namespace ESProMeter.Models
{
    public class TAddress: ITAddressInfo
    {
        public long ID { get; set; }
        public string ADDRESS { get; set; }
        public string PROVINCE { get; set; }
        public string COUNTRY { get; set; }
    }
}
