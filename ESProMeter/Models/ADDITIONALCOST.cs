﻿using ESProMeter.IVews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESProMeter.Models
{
    public class ADDITIONALCOST:IADDITIONALCOST
    {
        public decimal LOSSOFEFFECIENCYRATE { get; set; }
        public decimal OPERATIONRATE { get; set; }
        public decimal OVERHEADRATE { get; set; }
        public decimal SAFETYRATE { get; set; }
        public decimal TRANSPORTATIONRATE { get; set; }
        public decimal MARGINRATE { get; set; }
        public decimal INFlATIONRATE { get; set; }
    }
}