using ESProMeter.Services;
using System;
using System.Collections.Generic;
using System.Data;
namespace ESProMeter.Repository
{
    public class QuoteRepository
    {
        public void QuoteGetByBoq(long boqId,out DataTable table)
        {
            AppService.SqlGetInstance
                           .UseProcedure("QUOTE_sp_SELECT")
                               .SelectAsTable(new
                               {
                                   BOQID = boqId
                               }, out table);
        }


        public void QuoteCreate()
        {

        }
        
    }
}
