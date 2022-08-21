using ESProMeter.IVews;
namespace ESProMeter.Models
{
    public class ADDITIONALCOST:IADDITIONALCOSTRATE,IADDITIONALCOST
    {
        public decimal? LOSSOFEFFECIENCYRATE { get; set; } = 0M;
        public decimal? OPERATIONRATE { get; set; } = 0M;
        public decimal? OVERHEADRATE { get; set; } = 0M;
        public decimal? SAFETYRATE { get; set; } = 0M;
        public decimal? TRANSPORTATIONRATE { get; set; } = 0M;
        public decimal? MARGINRATE { get; set; } = 0M;
        public decimal? INFlATIONRATE { get; set; } = 0M;
        public decimal? LOSSOFEFFECIENCY { get; set; } = 0M;
        public decimal? OPERATION { get; set; } = 0M;
        public decimal? OVERHEAD { get; set; } = 0M;
        public decimal? SAFETY { get; set; } = 0M;
        public decimal? TRANSPORTATION { get; set; } = 0M;
        public decimal? MARGIN { get; set; } = 0M;
        public decimal? INFlATION { get; set; } = 0M;
        public decimal? TOTALADDITIONALCOST { get; set; } = 0M;
        public decimal? TOTALMARINANDINFLATION { get; set; } = 0M;
        public decimal? SUBTOTAL { get; set; } = 0M;
        public decimal? SALEPRICE { get; set; } = 0M;
        public decimal? BOQCOST { get; set; } = 0M;
    }
}
