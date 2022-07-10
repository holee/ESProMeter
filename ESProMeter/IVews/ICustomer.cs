using System;
namespace ESProMeter.IViews
{
    public interface ICustomer:IAddressInfo
    {
        long CustID { get; set; }
        string FirstName { get; set; }
        string MiddleName { get; set; }
        string LastName { get; set; }
        string CustomerName { get; set; }
        string TypeRefId { get; set; }
        int AddressRefId { get; set; }
        string Salutation { get; set; }
        string JobTitle { get; set; }
        string Email { get; set; }
        string MainPhone { get; set; }
        string AltPhone { get; set; }
        string Fax { get; set; }
        string WebSite { get; set; }
        int EditSequense { get; set; } 
        decimal CreditLimit { get; set; }
        bool IsActive { get; set; }
    }
}
