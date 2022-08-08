namespace ESProMeter.IVews
{
    public interface ILogin
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public  bool RememberMe { get; set; }
    }
}
