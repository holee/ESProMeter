using System;
namespace ESProMeter.IViews
{
    public interface IAddressInfo
    {
       long AddrID { get; set; } 
       int AddressEditSequense { get; set; } 
       string Address { get; set; }
       string City { get; set; }
       string Province { get; set; }
       string Country { get; set; }
    }
}
