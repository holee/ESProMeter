namespace ESProMeter.Contracts 
{
    public interface ILocalConfiguration : IConnectionString
    {
        string AttchachDbFile { get; set; }
    }
}
