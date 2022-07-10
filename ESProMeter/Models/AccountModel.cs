using ESProMeter.IViews;

namespace ESProMeter.Models
{
    public class AccountModel
    {
        public int AccountId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }
        public bool IsSystemAdmin { get; set; }
        public AccountModel(IAccount  account)
        {
            AccountId = account.AccountId; 
            UserName = account.UserName;
            Password = account.Password;
            IsActive = account.IsActive;
            IsSystemAdmin = account.IsSystemAdmin;
        }


    }
}
