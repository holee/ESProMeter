using ESProMeter.IViews;
using System;


namespace ESProMeter.Models
{


    public class Customer
    {
        public long CustID { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Name { get; set; }
        public string TypeRefId { get; set; }

        //[Column("AddrRefID")]
        //[ForeignKey("AddressInfo")]
        public long AddressRefId { get; set; }
        public AddressInfo AddressInfo { get; set; }
        public string Salutation { get; set; }
        public string JobTitle { get; set; }
        public string Email { get; set; }
        public string MainPhone { get; set; }
        public string AlternatePhone { get; set; }
        public string Fax { get; set; }
        public string WebSite { get; set; }
        public int EditSequense { get; set; }
        public decimal CreditLimit { get; set; }
        public DateTime CreatedTime { get; set; }
        public DateTime UpdatedTime { get; set; }
        public bool IsActive { get; set; }
        public Customer()
        {

        }
        public Customer(ICustomer customer)
        {
            CustID=customer.CustID;
            FirstName=customer.FirstName;
            MiddleName=customer.MiddleName;
            LastName=customer.LastName;
            Name=customer.CustomerName;
            TypeRefId=customer.TypeRefId;
            AddressRefId=customer.AddressRefId;
            Salutation=customer.Salutation;
            JobTitle=customer.JobTitle;
            Email=customer.Email;
            MainPhone=customer.MainPhone;
            AlternatePhone=customer.AltPhone;
            Fax=customer.Fax;
            WebSite=customer.WebSite;
            EditSequense = customer.EditSequense;
            IsActive=customer.IsActive;
            CreditLimit=customer.CreditLimit;
        }
    }
}
