namespace ESProMeter.Models
{

    public class Division:BaseEntity
    {
        public long DivID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; } = false; 
    }
}
