using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESProMeter.Models
{
    public class CustomerContact
    {
        public long CustomerID { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Name { get; set; }
        public string TypeRefId { get; set; }
        public int AddressRefId { get; set; }
        public string Salutation { get; set; }
        public string JobTitle { get; set; }
        public string Email { get; set; }
        public string MainPhone { get; set; }
        public string AlternatePhone { get; set; }
        public string Fax { get; set; }
        public string WebSite { get; set; }
        public string EditSequent { get; set; }
        public decimal CreditLimit { get; set; }
        public DateTime CreadedTime { get; set; }
        public DateTime UpdatedTime { get; set; }
        public bool IsActive { get; set; }


    }
}
