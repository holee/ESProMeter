using ESProMeter.IVews;
namespace ESProMeter.Models
{
    public class LoginModel:ILogin
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool RememberMe { get; set; }
    }
}
