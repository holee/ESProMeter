namespace ESProMeter.IViews 
{
    public interface IAccount
    {
        int AccountId { get; set; }
        string UserName { get; set; }
        string Password { get; set; }
        bool IsActive { get; set; }
        bool IsSystemAdmin { get; set; }


    }
}
