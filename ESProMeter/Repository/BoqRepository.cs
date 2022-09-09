using ESProMeter.Extensions;
using ESProMeter.IVews;
using ESProMeter.IViews;
using ESProMeter.Models;
using ESProMeter.Services;
using System;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
                                boq.UID,
                                boq.LOSSOFEFFECIENCYRATE,
                                boq.OPERATIONRATE,
                                boq.OVERHEADRATE,
                                boq.SAFETYRATE,
                                boq.TRANSPORTATIONRATE,
                                boq.MARGINRATE,
                                boq.INFlATIONRATE
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
                                boq.UID,
                                boq.LOSSOFEFFECIENCYRATE,
                                boq.OPERATIONRATE,
                                boq.OVERHEADRATE,
                                boq.SAFETYRATE,
                                boq.TRANSPORTATIONRATE,
                                boq.MARGINRATE,
                                boq.INFlATIONRATE
                            });
            return id > 0;

        }
        public bool BoqUpdate(ITBOQ boq)
        {
            var id = AppService.SqlGetInstance
                        .UseProcedure("[TBOQ_sp_UPDATE]")
                            .InsertGetId<long, dynamic>(new
                            {
                                boq.ID,
                                boq.BOQTITLE,
                                boq.BOQDESC,
                                boq.EDSEQ,
                                boq.CUSTOMERID,
                                boq.BOQDATE,
                                boq.VALIDDATE,
                                boq.SITEID,
                                boq.TERMSCONDITION,
                                boq.STATUS,
                                boq.UID,
                                boq.LOSSOFEFFECIENCYRATE,
                                boq.OPERATIONRATE,
                                boq.OVERHEADRATE,
                                boq.SAFETYRATE,
                                boq.TRANSPORTATIONRATE,
                                boq.MARGINRATE,
                                boq.INFlATIONRATE
                            });
            return id > 0;

        }
        public bool BoqDelete(long boq_id)
        {
            var id = AppService.SqlGetInstance
                        .UseProcedure("[TBOQ_sp_DELETE]")
                            .Delete<dynamic>(new
                            {
                                @BOQID=boq_id
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
                boq.LOSSOFEFFECIENCYRATE = row.GetValue<decimal>("LOSSOFEFFECIENCYRATE");
                boq.OPERATIONRATE = row.GetValue<decimal>("OPERATIONRATE");
                boq.OVERHEADRATE = row.GetValue<decimal>("OVERHEADRATE");
                boq.SAFETYRATE = row.GetValue<decimal>("SAFETYRATE");
                boq.MARGINRATE = row.GetValue<decimal>("MARGINRATE");
                boq.INFlATIONRATE = row.GetValue<decimal>("INFlATIONRATE");
                boq.TRANSPORTATIONRATE = row.GetValue<decimal>("TRANSPORTATIONRATE");
            }
        }
        public bool BoqGetById(long id,out TBOQ boq)
        {
            return AppService.SqlGetInstance
                            .UseProcedure("[BOQ_sp_SELECT_BY_ID]")
                                .FindOne<dynamic, TBOQ>(new
                                {
                                    @ID = id
                                }, out boq);
            
        }
        public bool BoqGetAll(byte isActive, int status, out DataTable table)
        {
            return AppService.SqlGetInstance
                            .UseProcedure("[BOQ_sp_SELECT]")
                                .SelectAsTable<dynamic>(new
                                {
                                    ISACTIVE = isActive,
                                    STATUS = status,
                                }, out table);
        }
        public void BoqGetByCustomer(long id,out DataTable table)
        {
            AppService.SqlGetInstance
                            .UseProcedure("[BOQ_sp_SELECT_BY_CUSTOMER]")
                                .SelectAsTable<dynamic>(new
                                {
                                    @ACTIVE="",
                                    @STATUS="",
                                    @CUSTOMERID = id 
                                }, out table);
          
        }
        public void BoqGetByCustomer(long id,int active,DateTime start,DateTime end, out DataTable table)
        {
            AppService.SqlGetInstance
                            .UseProcedure("[BOQ_sp_SELECT_CUSTOMER_DATE]")
                                .SelectAsTable<dynamic>(new
                                {
                                    @START=start,
                                    @END=end,
                                    @ACTIVE = active,
                                    @STATUS = "",
                                    @CUSTOMERID = id
                                }, out table);

        }

        /// <summary>
        /// BOQLINE
        /// </summary>
        /// <param name="model"></param>
        /// 

        public bool CreateSection(string no, long boqId, int order, string section)
        {
            return AppService.SqlGetInstance
                        .UseProcedure("[TBOQLINETEMP_sp_INSERT_SECTION]")
                            .InsertOrUpdate<dynamic>(new
                            {
                                @NO = no,
                                @BOQID = boqId,
                                @ORDER = order,
                                @SECTIONNAME = section
                            })>0;
        }
        public bool DeleteSection(long boqId, int order)
        {
            return AppService.SqlGetInstance
                        .UseProcedure("[TBOQLINETEMP_sp_DELETE_SECTION]")
                            .InsertOrUpdate<dynamic>(new
                            {
                                @BOQID = boqId,
                                @ORDER = order,
                            }) > 0;
        }
        public void BoqLineCreate(DataTable model)
        {
            AppService.SqlGetInstance
                        .UseProcedure("[TBOQLINE_sp_INSERT]")
                            .InsertFromTable("TBOQLINE", model, "TBOQLINE_udt_INSERT");
        }
        public void BoqLineTempCreate(DataTable model)
        {
            AppService.SqlGetInstance
                        .UseProcedure("[TBOQLINETEMP_sp_INSERT]")
                            .InsertFromTable("TBOQLINE", model, "TBOQLINETEMP_udt_INSERT");
        }
        public void BoqLineTempChanged(long BoqId,long BoqItemRefId,string no,string description,
              string remark,decimal qty=1,int order=1,int iscompleted=0)
        {
            AppService.SqlGetInstance
                        .UseProcedure("[TBOQLINETemp_sp_CHANGE]")
                            .InsertOrUpdate<dynamic>(new
                            {
                                @BOID=BoqId,
                                @BOQITEMRefID=BoqItemRefId,
                                @NO=no,
                                @REMARK=remark,
                                @BOQITEMDESC=description,
                                @QTY=qty,
                                @ISCOMPLETE=iscompleted,
                                @ORDER=order
                            });
        }

        public bool Migrate(long BoqId)
        {
            return AppService.SqlGetInstance
                        .UseProcedure("[TBOQLINE_sp_MIGRATE]")
                            .InsertOrUpdate<dynamic>(new
                            {
                                @BOQID = BoqId
                            })>0;
        }
        public void BoqLineChangedOrder(long BoqId, long BoqItemRefId,int order = 1,int newOrder=1)
        {
            AppService.SqlGetInstance
                        .UseProcedure("[TBOQLINE_sp_CHANGEORDER]")
                            .InsertOrUpdate<dynamic>(new
                            {
                                @BOID = BoqId,
                                @BOQITEMRefID = BoqItemRefId,
                                @ORDER = order,
                                @NEWORDER= newOrder
                            });
        }
        public bool BoqTempDelete(long BoqId)
        {
            return AppService.SqlGetInstance
                       .UseProcedure("[TBOQLINETEMP_sp_REMOVE]")
                           .InsertOrUpdate<dynamic>(new
                           {
                               @BOQID = BoqId
                           }) > 0;
        }
        

        public bool BoqLineDetailChangePrice(long boqId,long boqItemId,long boqItemLineId,int order,decimal price)
        {
            return AppService.SqlGetInstance
                                .UseProcedure("TBOQLINEDETAIL_sp_UPDATEPRICE")
                                .InsertOrUpdate<dynamic>(new
                                {
                                    @BOID=boqId,
                                    @BOQITEMRefID= boqItemId,
                                    @BOQITEMLINEID= boqItemLineId,
                                    @ORDER=order,
                                    @NEWPRICE=price
                                })>0;


        }
        //Remove boqline for update
        public bool BoqLineTempDelete(long BoqId, long BoqItemRefId,int Seq,int iscomplete=0)
        {
            return AppService.SqlGetInstance
                        .UseProcedure("[TBOQLINETemp_sp_DELETE]")
                            .Delete<dynamic>(new
                            {
                                @BOQID = BoqId,
                                @BOQITEMID = BoqItemRefId,
                                @LineSeq =Seq,
                            })>0;
                        //.UseProcedure("[TBOQLINETemp_sp_INSERT]")
                        //    .InsertFromTable("TBOQLINE", model, "TBOQLINETemp_udt_INSERT");
        }
        public void BoqLineUpdate(DataTable model) 
        {
            AppService.SqlGetInstance
                        .UseProcedure("TBOQLINE_sp_UPDATE")
                            .InsertFromTable("TBOQLINE", model, "TBOQLINE_udt_UPDATE");
        }
        public void BoqLineGetById(long id, out DataTable table)
        {
            AppService.SqlGetInstance
                            .UseProcedure("[TBOQLINE_sp_GET_BY_ID]")
                                .SelectAsTable<dynamic>(new
                                {
                                    @BODREFID = id
                                }, out table);
        }
        public void AdditinalCostGet(out DataTable table)
        {
            AppService.SqlGetInstance
                            .UseProcedure("[SETTING_sp_SELECT]")
                                .SelectAsTable<dynamic>(null,out table);
        }
        public void AdditinalCostGet(long boqId,long boqItemId,out ADDITIONALCOST model)
        {
            model = new();
            AppService.SqlGetInstance
                            .UseProcedure("TBOQLINE_sp_ADDITIONALCOST")
                                .FindOne<dynamic, ADDITIONALCOST>(new
                                {
                                    @BODREFID= boqId,
                                    @BOQITEMRefID= boqItemId
                                }, out model);
        }
        public void tAdditinalCostGet(long boqId, out ADDITIONALCOST model)
        {
            model = new();
            AppService.SqlGetInstance
                            .UseSql(@"SELECT [LOSSOFEFFECIENCYRATE],[OPERATIONRATE],
                                        [OVERHEADRATE],[SAFETYRATE],[TRANSPORTATIONRATE],
                                        [MARGINRATE],[INFlATIONRATE] FROM TBOQ WHERE ID=@ID")
                                .FindOne<dynamic, ADDITIONALCOST>(new
                                {
                                    @ID = boqId,
                                }, out model);
        }

        public bool AdditinalCostBoqLineUpate(long boqId,long boqItemLineId,int seq,int complete, IADDITIONALCOSTRATE model)
        {
            return AppService.SqlGetInstance
                            .UseProcedure("[TBOQLINE_sp_ADDITIONALCOST_UPDATE]")
                                .InsertOrUpdate<dynamic>(new
                                {
                                    @BODREFID=boqId,
                                    @BOQITEMRefID= boqItemLineId,
                                    @SEQ=seq,
                                    @COMPLETED=complete,
                                    model.LOSSOFEFFECIENCYRATE,
                                    model.OVERHEADRATE,
                                    model.OPERATIONRATE,
                                    model.SAFETYRATE,
                                    model.TRANSPORTATIONRATE,
                                    model.MARGINRATE,
                                    model.INFlATIONRATE
                                })>0;
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
