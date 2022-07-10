namespace ESProMeter.IViews
{
    public interface IDivision
    {
        long DivID { get; set; }
        string DivName { get; set; }
        string Description { get; set; }
        int EditSequense { get; set; }
        bool IsActive { get; set; }
    }
}
