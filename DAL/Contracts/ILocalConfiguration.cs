namespace ESProMeter.Contracts 
{
    public interface ILocalConfiguration : IConnectionString
    {
        string AttchachDbFile { get; set; }
    }
    public interface IWindowsConfiguration : IConnectionString 
    {
        string? Database { get; set; }
        string? ServerName { get; set; }
    }
}
