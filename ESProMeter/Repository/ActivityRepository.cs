using ESProMeter.IVews;
using ESProMeter.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESProMeter.Repository
{
    public class ActivityRepository
    {
        public bool ActivityCreate(ITACTIVITY model)
        {
           return AppService.SqlGetInstance
                        .UseProcedure("ACTIVITY_sp_INSERT")
                            .InsertOrUpdate<dynamic>(
                                   new
                                   {
                                       model.BOQID,
                                       model.ACTNAME,
                                       model.DESCRIPTION,
                                       model.STATUS,
                                       model.ISACTIVE
                                   })>0;
        }

        public bool ActivityUpdate(ITACTIVITY model)
        {
            return AppService.SqlGetInstance
                         .UseProcedure("ACTIVITY_sp_UPDATE")
                             .InsertOrUpdate<dynamic>(
                                    new
                                    {
                                        model.ID,
                                        model.BOQID,
                                        model.ACTNAME,
                                        model.DESCRIPTION,
                                        model.STATUS,
                                        model.ISACTIVE
                                    }) > 0;
        }

        public bool ActivityDelete(ITACTIVITY model)
        {
            return AppService.SqlGetInstance
                         .UseProcedure("ACTIVITY_sp_DELETE")
                             .Delete<dynamic>(
                                    new
                                    {
                                        model.ID,
                                    }) > 0;
        }

    }
}
