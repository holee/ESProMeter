using ESProMeter.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESProMeter.Repository
{
    public class ReportRepository
    {
        public void BoqListReport(long boqId,out DataTable source)
        {
            AppService.SqlGetInstance
                            .UseProcedure("[VTBOQLINE_sp_RPT]")
                                .SelectAsTable<dynamic>(new
                                {
                                    @ID= boqId
                                },out source);
        }




    }
}
