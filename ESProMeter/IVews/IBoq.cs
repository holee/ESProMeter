using System;
namespace ESProMeter.IViews
{
    public interface IBoq
    {
        long BOQID { get; set; }
        DateTime CreatedTime { get; set; }
        DateTime ModifiedTime { get; set; }
        int EditSequense { get; set; }
        double BOQNumber { get; set; }
        long CustRefID { get; set; }
        DateTime Date { get; set; }
        string RefNumber { get; set; }
        bool IsActive { get; set; }
        long SiteRefListID { get; set; }
        long DivRefListID { get; set; }
        DateTime ValidDate { get; set; }
        string TermsCondition { get; set; }
        byte IsDelete { get; set; }
    }
}
