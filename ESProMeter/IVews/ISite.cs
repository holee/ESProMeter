namespace ESProMeter.IViews
{
    public interface ISite
    {
        int SiteID { get; set; }
        string SiteName { get; set; }
        string Description { get; set; }
        long AddressRefId { get; set; }
        string Address { get; set; }
        int EditSequense { get; set; }
        string City { get; set; }
        string Province { get; set; }
        string Country { get; set; }
        long CustomerRefId { get; set; }
        bool IsActive { get; set; }
    }
}
