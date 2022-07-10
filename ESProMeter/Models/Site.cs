namespace ESProMeter.Models
{

    public class Site
    {
        public int SiteID { get; set; }
        public string SiteName { get; set; }
        public string Description { get; set; }
        public long AddressRefId { get; set; }
        public long CustomerRefId { get; set; }
        public bool IsActive { get; set; }
        public AddressInfo AddressInfo { get; set; }
        public Customer Customer { get; set; }
    }
    public class SiteUpdateDto 
    {
        public int SiteId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public long AddrRefID { get; set; }
        public long CustRefID { get; set; }
        public bool IsActive { get; set; }
    }


    public class SiteCreateDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public long AddrRefID { get; set; }
        public long CustRefID { get; set; }
        public bool IsActive { get; set; }
    }
}