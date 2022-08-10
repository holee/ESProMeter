using ESProMeter.Extensions;
using ESProMeter.IVews;
using ESProMeter.IViews;
using ESProMeter.Services;
using System;
using System.Data;

namespace ESProMeter.Repository
{
    public class BoqRepository
    {
        /// <summary>
        /// Create New
        /// </summary>
        /// <param name="boq"></param>
        /// <returns></returns>
        public bool BoqCreate(ITBOQ boq)
        {
            var id=AppService.SqlGetInstance
                        .UseProcedure("[TBOQ_sp_INSERT]")
                            .InsertGetId<long, dynamic>(new
                            {
                                boq.BOQTITLE,
                                boq.BOQDESC,
                                boq.CUSTOMERID,
                                boq.BOQDATE,
                                boq.VALIDDATE,
                                boq.SITEID,
                                boq.TERMSCONDITION,
                                boq.STATUS,
                                boq.UID
                            });
            return id > 0;

        }
        public bool BoqCreate(ITBOQ boq,out long id)
        {
            id = AppService.SqlGetInstance
                        .UseProcedure("[TBOQ_sp_INSERT]")
                            .InsertGetId<long, dynamic>(new
                            {
                                boq.BOQTITLE,
                                boq.BOQDESC,
                                boq.CUSTOMERID,
                                boq.BOQDATE,
                                boq.VALIDDATE,
                                boq.SITEID,
                                boq.TERMSCONDITION,
                                boq.STATUS,
                                boq.UID
                            });
            return id > 0;

        }

        public bool BoqUpdate(ITBOQ boq)
        {
            var id = AppService.SqlGetInstance
                        .UseProcedure("[TBOQ_sp_INSERT]")
                            .InsertGetId<long, dynamic>(new
                            {
                                boq.ID,
                                boq.BOQTITLE,
                                boq.BOQDESC,
                                boq.CUSTOMERID,
                                boq.BOQDATE,
                                boq.VALIDDATE,
                                boq.SITEID,
                                boq.TERMSCONDITION,
                                boq.STATUS,
                                boq.UID
                            });
            return id > 0;

        }

        /// <summary>
        /// GET BY BOQ
        /// </summary>
        /// <param name="id"></param>
        /// <param name="boq"></param>
        public void BoqGetById(long id,ITBOQ boq)
        {
            if(AppService.SqlGetInstance
                            .UseProcedure("[BOQ_sp_SELECT_BY_ID]")
                                .FindOne<dynamic>(new {
                                    @ID=id 
                                },out var row))
            {
                boq.ID = id;
                boq.BOQDESC = row.GetValue<string>("BOQDESC");
                boq.BOQTITLE = row.GetValue<string>("BOQTITLE");
                boq.BOQDATE = row.GetValue<DateTime>("BOQDATE");
                boq.VALIDDATE = row.GetValue<DateTime>("VALIDDATE");
                boq.EDSEQ = row.GetValue<int>("EDSEQ");
                boq.UID = row.GetValue<long>("UID"); 
                boq.STATUS = row.GetValue<int>("STATUS");
                boq.SITEID = row.GetValue<long>("SITEID");
                boq.CUSTOMERID = row.GetValue<long>("CUSTOMERID");
                boq.BOQDESC = row.GetValue<string>("BOQDESC");
                boq.MDT = row.GetValue<DateTime>("MDT");
                boq.CDT = row.GetValue<DateTime>("CDT");
                boq.TERMSCONDITION = row.GetValue<string>("TERMSCONDITION");
                boq.REFNUMBER = row.GetValue<string>("REFNUMBER");
                boq.ISACTIVE = row.GetValue<byte>("ISACTIVE");
            }
        }

        public bool BoqGetAll(byte isActive,int status,out DataTable table)
        {
            return AppService.SqlGetInstance
                            .UseProcedure("[BOQ_sp_SELECT]")
                                .SelectAsTable<dynamic>(new
                                {
                                    ISACTIVE=isActive,
                                    STATUS=status,
                                }, out table);
        }

        /// <summary>
        /// BOQLINE
        /// </summary>
        /// <param name="model"></param>
        public void BoqLineCreate(DataTable model)
        {
            AppService.SqlGetInstance
                        .UseProcedure("[TBOQLINE_sp_INSERT]")
                            .InsertFromTable("TBOQLINE", model, "TBOQLINE_udt_INSERT");
        }   


    










    }
}


//    {
//        AppService.SqlGetInstance
//                    .UseProcedure("[TBOQLINE_sp_INSERT]")
//                        .InsertFromTable(new
//                        {
//                            model.BOQID,
//                            model.BOQITEMID,
//                            model.NO,
//                            model.LineSeq,
//                            model.BOQITEMUOMID,
//                            model.BOQITEMDESC,
//                            model.REMARKS,
//                            model.BOQITEMQTY,
//                            model.UID
//},);
//    }   
