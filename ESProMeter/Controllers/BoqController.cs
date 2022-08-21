using DocumentFormat.OpenXml.Spreadsheet;
using ESProMeter.Extensions;
using ESProMeter.IViews;
using ESProMeter.Models;
using ESProMeter.Services;
using ESProMeter.Views.Boq;
using System.Data;
using System.Windows.Forms;

namespace ESProMeter.Controllers
{
    public static class BoqController
    {
        /// <summary>
        /// CREATE AND UPDATE
        /// </summary>
        /// <param name="form"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        public static bool BoqCreate(this Form form,CreateBoQ_Step1_Frm data)
        {
            return AppService.GetBoqInstance.BoqCreate(data);
        }
        public static bool BoqCreate(this Form form, ITBOQ data)
        {
            return AppService.GetBoqInstance.BoqCreate(data);
        }
        public static bool BoqUpdate(this Form form, CreateBoQ_Step1_Frm data) 
        {
            return AppService.GetBoqInstance.BoqUpdate(data);
        }
        public static bool BoqDelete(this Form form,long boq_id)
        {
            return AppService.GetBoqInstance.BoqDelete(boq_id);
        }
        public static bool BoqUpdate(this Form form, ITBOQ data)
        {
            return AppService.GetBoqInstance.BoqUpdate(data);
        }
        public static bool BoqCreate(this Form form, CreateBoQ_Step1_Frm data,out long id)
        {
            return AppService.GetBoqInstance.BoqCreate(data,out id);
        }

        public static void BoqLineCreateOrUpdate(this Form form, DataGridView grid,Enums.ActionType type)
        {
            var table = grid.ToTable("BOQID", "BOQITEMID", "LineSeq", "NO", "BOQITEMDESC", "BOQITEMUOMID", "BOQITEMQTY",
              "REMARKS", "UID", "BOQCOST", "LOSSEFFECENCYRATE1", "OPERATIONRATE1", "OVERHEADRATE1", "SAFETYRATE1", "TRANSPORTATIONRATE1", "MARGINRATE1", "INFlATIONRATE1");
            switch (type)
            {
                case Enums.ActionType.CREATE:
                    AppService.GetBoqInstance.BoqLineCreate(table);
                    break;
                case Enums.ActionType.EDIT:
                    AppService.GetBoqInstance.BoqLineUpdate(table);
                    break;
                default:
                    break;
            }
            
        }
        public static void BoqLineCreate(this Form form,DataGridView grid)
        {
            var table = grid.ToTable("BOQID", "BOQITEMID", "LineSeq", "NO", "BOQITEMDESC", "BOQITEMUOMID", "BOQITEMQTY",
                "REMARKS", "UID", "BOQCOST", "LOSSEFFECENCYRATE1", "OPERATIONRATE1", "OVERHEADRATE1", "SAFETYRATE1", "TRANSPORTATIONRATE1", "MARGINRATE1", "INFlATIONRATE1");
            AppService.GetBoqInstance.BoqLineCreate(table);
        }
        public static void BoqLineUpdate(this Form form, DataGridView grid)
        {
            var table = grid.ToTable("BOQID", "BOQITEMID", "LineSeq", "NO", "BOQITEMDESC", "BOQITEMUOMID", "BOQITEMQTY",
                "REMARKS", "UID", "BOQCOST", "LOSSEFFECENCYRATE1", "OPERATIONRATE1", "OVERHEADRATE1", "SAFETYRATE1", "TRANSPORTATIONRATE1", "MARGINRATE1", "INFlATIONRATE1");
            AppService.GetBoqInstance.BoqLineUpdate(table);
        }

        /// <summary>
        /// GET
        /// </summary>
        /// <param name="form"></param>
        /// <param name="container"></param>
        public static void GetAdditionalCost(this Form form,DataGridView container)
        {
            AppService.GetBoqInstance
                            .GetAdditinalCost(out var table);
            table.UseDataTableAsGridView(container);
        }

        public static void BoqGetById(this Form form, long id,CreateBoQ_Step2_Frm boqForm)
        {
            AppService.GetBoqInstance.BoqGetById(id, boqForm);
        }
        public static bool BoqGetById(this Form form, long id, out TBOQ boq)
        {
            return AppService.GetBoqInstance.BoqGetById(id, out boq);
        }
        public static void BoqLineGetById(this Form form, long id, DataGridView container)
        {
            AppService.GetBoqInstance.BoqLineGetById(id, out var table);
            container.Rows?.Clear();
            table.UsePlainDataToGridView(container);
        }
        public static void BoqListGet(this Form form, int status = 1)
        {
            var constainer = form.AsControl<DataGridView>("dtgBOQList");
            var chkIncludeClosedBOQ = form.AsControl<CheckBox>("chkIncludeClosedBOQ");
            ((DataTable)constainer.DataSource)?.Rows.Clear();
            if (chkIncludeClosedBOQ.Checked)
            {
                if (AppService.GetBoqItemLineInstance.GetBoqList(0, status, out var table))
                {
                    table.UseDataTableAsGridView(constainer);
                }
            }
            else
            {
                if (AppService.GetBoqItemLineInstance.GetBoqList(1, status, out var table))
                {
                    table.UseDataTableAsGridView(constainer);
                }
            }
        }



        public static void EchoMaterial()
        {

        }
        public static void EchoMachinery()
        {

        }
        public static void EchoLabour()
        {
             
        }
    }
}

