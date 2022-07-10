using ESProMeter.IViews;
using System;
namespace ESProMeter.Models
{
    public class AddressCreateDto 
    {
        public string Address { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public string Country { get; set; }

    }
    public class AddressUpdateDto
    {
        public long AddrID { get; set; }
        public int EditSequense { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public string Country { get; set; }
    }
    public class AddressInfo
    {
        public long AddrID { get; set; }
        public int AddressEditSequense { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public string Country { get; set; }
        public DateTime? CreatedTime { get; set; }
        public DateTime? ModifiedTime { get; set; }
        public AddressInfo()
        {

        }
        public AddressInfo(IAddressInfo address)
        {
            AddrID=address.AddrID;
            AddressEditSequense = address.AddressEditSequense;
            Address = address.Address;
            City = address.City;
            Province = address.Province;
            Country = address.Country;
        }

        //public Customer Customer { get; set; }

    }
}
