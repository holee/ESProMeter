using ESProMeter.IVews;
using ESProMeter.IViews;
using ESProMeter.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESProMeter.Repository
{
    public class BoqItemLineRepository
    {
        /// <summary>
        /// Create And Update BOQ
        /// </summary>
        /// <param name="tBoq"></param>
        /// <returns></returns>
        public long BoqCreate(ITBOQ tBoq) 
        { 
            return DataUtility.GetInstance
                       .UseProcedure("")
                       .InsertGetId<long, dynamic>(new
                       {
                           tBoq.EDSEQ,
                           tBoq.REFNUMBER,
                           tBoq.BOQTITLE,
                           tBoq.BOQDESC,
                           tBoq.CUSTOMERID,
                           tBoq.BOQDATE,
                           tBoq.VALIDDATE,
                           tBoq.ISACTIVE,
                           tBoq.SITEID,
                           tBoq.DIVID,
                           tBoq.TERMSCONDITION,
                           tBoq.STATUS,
                           tBoq.UID
                       });

        }
        public long BoqUpdate(ITBOQ tBoq)
        {
            return AppService.SqlGetInstance
                       .UseProcedure("")
                       .InsertGetId<long, dynamic>(new
                       {
                           tBoq.ID,
                           tBoq.EDSEQ,
                           tBoq.REFNUMBER,
                           tBoq.BOQTITLE,
                           tBoq.BOQDESC,
                           tBoq.CUSTOMERID,
                           tBoq.BOQDATE,
                           tBoq.VALIDDATE,
                           tBoq.ISACTIVE,
                           tBoq.SITEID,
                           tBoq.DIVID,
                           tBoq.TERMSCONDITION,
                           tBoq.STATUS,
                           tBoq.UID
                       });

        }
        /// <summary>
        /// Create and update BoqLine
        /// </summary>
        /// <param name="data"></param>
        public void BoqLineCreate(DataTable data)
        {
            AppService.SqlGetInstance
                       .UseProcedure("")
                       .InsertFromTable("", data, "");

        }
        public void BoqLineCreate(ITBOQLINE line)
        {
            AppService.SqlGetInstance
                       .UseProcedure("")
                       .InsertOrUpdate<dynamic>(new
                       {
                           line.BOQID,
                           line.BOQITEMID,
                           line.LineSeq,
                           line.NO,
                           line.BOQITEMDESC,
                           line.BOQITEMUOMID,
                           line.BOQITEMQTY,
                           line.REMARKS,
                           line.UID
                       });

        }
        public void BoqLineUpdate(ITBOQLINE line)
        {
            DataUtility.GetInstance
                       .UseProcedure("")
                       .InsertOrUpdate<dynamic>(new
                       {
                           line.BOQID,
                           line.BOQITEMID,
                           line.LineSeq,
                           line.NO,
                           line.BOQITEMDESC,
                           line.BOQITEMUOMID,
                           line.BOQITEMQTY,
                           line.REMARKS,
                           line.UID
                       });

        }

       /// <summary>
       /// Create and Update BOQLINE DETAILS
       /// </summary>
       /// <param name="itemLine"></param>
        public void BoqLineDetailsUpdate(ITBOQLINEDETAILS details)
        { 
            DataUtility.GetInstance
                       .UseProcedure("")
                       .InsertOrUpdate<dynamic>(new
                       {
                           
                       });

        }
        public void BoqLineDetailsUpdate(DataTable details)
        {
            DataUtility.GetInstance
                       .UseProcedure("")
                       .InsertFromTable("",details,"");

        }
        public void BoqLineDetailsCreate(ITBOQLINEDETAILS details) 
        {
            DataUtility.GetInstance
                       .UseProcedure("")
                       .InsertOrUpdate<dynamic>(new
                       {
                           
                       });

        }

        public void BoqLineDetailsCreate(DataTable   details)
        {
            DataUtility.GetInstance
                       .UseProcedure("BOQLINEDETAILS_sp_INSERT")
                       .InsertFromTable("udtParam", details, "udt_TBOQLINEDETAILS_Insert");

        }
        /// <summary>
        /// SELECT
        /// </summary>
        /// <param name="isActive"></param>
        /// <param name="status"></param>
        /// <param name="tblBoq"></param>
        /// <returns></returns>

        public void GetBoqListInfoByBoqId(long boqId,
            out DataTable tblBoq, out DataTable tblQuote, out DataTable tblActivity)
        {
            AppService.SqlGetInstance
                .UseProcedure("BOQLine_Sp_SELECT")
                .SelectAsTable(new 
                {
                    BOQID = boqId
                }, out tblBoq);
            DataUtility.GetInstance
                .UseProcedure("QUOTE_sp_SELECT")
                .SelectAsTable(new
                {
                    BOQID = boqId
                }, out tblQuote);
            DataUtility.GetInstance
                .UseProcedure("ACTIVITY_sp_SELECT")
                .SelectAsTable(new
                {
                    BOQID = boqId
                }, out tblActivity);

        }

       
        public bool GetBoqList(int isActive,int status,out DataTable tblBoq)
        {
            return AppService.SqlGetInstance
                .UseProcedure("BOQ_sp_SELECT_ALL")
                .SelectAsTable<dynamic>(new { isAct = isActive, status= status }, out tblBoq);
        }
        public bool GetBoqList(byte isActive, int status, out DataTable tblBoq)
        {
            return AppService.SqlGetInstance
                .UseProcedure("BOQ1_sp_SELECT_ALL")
                .SelectAsTable<dynamic?>(new { 
                    isAct = isActive, 
                    status = status
                }, out tblBoq);
        }



        public void GetBoqListByBoqId(long boqId,out DataTable tblBoq)
        {
            AppService.SqlGetInstance
                .UseProcedure("BOQLine_Sp_SELECT")
                .SelectAsTable(new
                {
                    BOQID = boqId
                }, out tblBoq);
        }
        public bool GetBoqLine(long boqId,bool isBoqClosed,out DataTable table)
        {
            if (AppService.SqlGetInstance
                .UseProcedure("BOQLine_Sp_SELECT")
                .SelectAsTable(new { 
                    isBoqClosed=isBoqClosed,
                    BOQID= boqId
                },out table))
            {
                return true;
            }
            return false;
        }

        public void GetBoqItemLine(long boqId,out DataTable table)
        {
            table = new();
            if (AppService.SqlGetInstance
                .UseProcedure("")
                .SelectAsTable(new { boqId = boqId }, out table)) ;
           
        }

        public void GetBoqQuote(long boqId,out DataTable table)
        {
            table = new();
            if (AppService.SqlGetInstance
                .UseProcedure("")
                .SelectAsTable(new { boqId = boqId }, out table)) ;
          
        }



    }
}
