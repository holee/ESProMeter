namespace ESProMeter.Contracts 
{
  
    public interface IServerConfiguration:IConnectionString
    {
        string ServerName { get; set; }
        string DatabaseName { get; set; }
        string UserID { get; set; } 
        string Password { get; set; }   
        bool Auth { get; set; }
    }
    
}
