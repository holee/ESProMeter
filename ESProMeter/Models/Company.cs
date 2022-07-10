using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESProMeter.Models
{
    public class Company
    {
        public string CompanyName { get; set; }
        public string LegalCompanyName { get; set; }
        public string AltlegalCompanyName { get; set; }
        public long AddressRefID { get; set; } 
        public long LegalAddressefID { get; set; }
        public string MainPhone { get; set; }
        public string AlternatePhone { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
    }
}
