using ESProMeter.IViews;
using System;
namespace ESProMeter.Models
{
    public class Boq : IBoq
    {
        public long BOQID { get ; set ; }
        public DateTime CreatedTime { get ; set ; }
        public DateTime ModifiedTime { get ; set ; }
        public int EditSequense { get ; set ; }
        public double BOQNumber { get ; set ; }
        public long CustRefID { get ; set ; }
        public DateTime Date { get ; set ; }
        public string RefNumber { get ; set ; }
        public bool IsActive { get ; set ; }
        public long SiteRefListID { get ; set ; }
        public long DivRefListID { get ; set ; }
        public DateTime ValidDate { get ; set ; }
        public string TermsCondition { get ; set ; }
        public byte IsDelete { get ; set ; }
    }
}
