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
        public long TBoqCreate(ITBoq tBoq)
        {
            return DataUtility.GetInstance
                       .UseProcedure("")
                       .InserGetId<long, dynamic>(new
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
        public long TBoqUpdate(ITBoq tBoq)
        {
            return DataUtility.GetInstance
                       .UseProcedure("")
                       .InserGetId<long, dynamic>(new
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
        public void TBoqLineCreate(DataTable data)
        {
            DataUtility.GetInstance
                       .UseProcedure("")
                       .InsertFromTable("", data, "");

        }

        public void TBoqLineCreate(ITBoqLine line)
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
        public void TBoqLineUpdate(ITBoqLine line)
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

        public void TBoqItemLineUpdate(ITBoqItemLine itemLine)
        {
            DataUtility.GetInstance
                       .UseProcedure("")
                       .InsertOrUpdate<dynamic>(new
                       {
                           itemLine.BOQITEMID,
                           itemLine.BOQITEMLINEID,
                           itemLine.BOQITEMLINESEQ,
                           itemLine.BOQITEMLINEUOMID,
                           itemLine.BOQITEMLINEQTY
                       });

        }

        public void TBoqItemLineCreate(ITBoqItemLine itemLine)
        {
            DataUtility.GetInstance
                       .UseProcedure("")
                       .InsertOrUpdate<dynamic>(new
                       {
                           itemLine.BOQITEMID,
                           itemLine.BOQITEMLINEID,
                           itemLine.BOQITEMLINESEQ,
                           itemLine.BOQITEMLINEUOMID,
                           itemLine.BOQITEMLINEQTY
                       });

        }


        public void GetBoqListByBoqId(long boqId,
            out DataTable tblBoq, out DataTable tblQuote, out DataTable tblActivity)
        {
            tblBoq = new();
            tblQuote = new();
            tblActivity = new();
            DataUtility.GetInstance
                .UseProcedure("BOQLine_Sp_SELECT")
                .FindAsTable(new
                {
                    BOQID = boqId
                }, out tblBoq);
            DataUtility.GetInstance
                .UseProcedure("QUOTE_sp_SELECT")
                .FindAsTable(new
                {
                    BOQID = boqId
                }, out tblQuote);
            DataUtility.GetInstance
                .UseProcedure("ACTIVITY_sp_SELECT")
                .FindAsTable(new
                {
                    BOQID = boqId
                }, out tblActivity);

        }
        public void GetBoqListByBoqId(long boqId,
           out DataTable tblBoq)
        {
            tblBoq = new();
            DataUtility.GetInstance
                .UseProcedure("BOQLine_Sp_SELECT")
                .FindAsTable(new
                {
                    BOQID = boqId
                }, out tblBoq);
        }
        public bool GetBoqLine(long boqId,bool isBoqClosed,out DataTable table)
        {
            if (DataUtility.GetInstance
                .UseProcedure("BOQLine_Sp_SELECT")
                .FindAsTable(new { 
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
            if (DataUtility.GetInstance
                .UseProcedure("")
                .FindAsTable(new { boqId = boqId }, out table))
            {
                return true;
            }
            return false;
        }

        public void GetBoqQuote(long boqId,out DataTable table)
        {
            table = new();
            if (DataUtility.GetInstance
                .UseProcedure("")
                .FindAsTable(new { boqId = boqId }, out table))
            {
                return true;
            }
            return false;
        }
    }
}
