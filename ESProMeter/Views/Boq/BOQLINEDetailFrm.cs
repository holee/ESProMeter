using ESProMeter.Controllers;
using ESProMeter.Extensions;
using ESProMeter.IVews;
using ESProMeter.Models;
using ESProMeter.Services;
using System;
using System.Windows.Forms;

namespace ESProMeter.Views.Boq
{
    public partial class BOQLINEDetailFrm : Form
    {
        public BOQLINEDetailFrm(long boq_id,long itemId,int seq)
        {
            InitializeComponent();
            AppService.GetItemInstance.BoqItemLineGetByBOQID(boq_id, itemId,seq,out var table);
            table.WithColumn("BOQITEMITEMLINEID", "BOQITEMITEMLINENAME", "BOQITEMITEMLINETYPE", "UOM", "BOQITEMLINEUOMID", "BOQITEMLINEQTY", "BOQITEMLINESEQ", "COST", "SUBCOST");
            table.UseDataTableAsGridView(this.dgvBoqItemLine);

        }

        private void mbtCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}


//private void dgvLabor_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
//{
//    if (dgvBoqItemLine.Rows.Count == 0) return;

//    if (dgvBoqItemLine.Columns["laborBOQItemLineQty"].Name== "laborBOQItemLineQty" 
//        && dgvBoqItemLine.Columns["laborBOQItemLineQty"] is DataGridViewTextBoxColumn)
//    {
//        var textbox = e.Control as TextBox;
//        textbox.KeyUp += (s, e) =>
//        {
//            var textvalue = ((TextBox)s).AsNumber<decimal>();

//            var cost = dgvBoqItemLine.GetValue<decimal>(dgvBoqItemLine.CurrentRow.Index, "ButtonColumn1");

//            var subcost = textvalue * cost;

//            dgvBoqItemLine.SetText(dgvBoqItemLine.CurrentRow.Index, "labourSubtotal", Utility.NumberString(subcost));

//            txtSubtotalLabour.SetText(CalculateItemPrice(dgvBoqItemLine, "labourSubtotal"));
//            UpdateSalePrice();

//        };
//    }
//}

//private void dgvLabor_CellEndEdit(object sender, DataGridViewCellEventArgs e)
//{
//    if (dgvBoqItemLine.Rows.Count == 0) return;
//    if (dgvBoqItemLine.Columns[e.ColumnIndex].Name == "laborBOQItemLineQty")
//    {
//        var selectedRow = dgvBoqItemLine.SelectedRows[0];
//        if (selectedRow.GetValue<int>("laborBOQItemLineQty") == 0)
//        {
//            dgvBoqItemLine.SetText(dgvBoqItemLine.CurrentRow.Index,"laborBOQItemLineQty",Utility.NumberString(0,"N2"));
//        }
//        else
//        {
//            var selectedValue = dgvBoqItemLine.GetValue<decimal>(dgvBoqItemLine.CurrentRow.Index,"laborBOQItemLineQty");
//            dgvBoqItemLine.SetText(dgvBoqItemLine.CurrentRow.Index,"laborBOQItemLineQty", Utility.NumberString(selectedValue, "N2"));
//        }
//    }
//}

//private void dgvMachinary_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
//{
//    //if (dgvMachinary.Rows.Count == 0) return;

//    //if (dgvMachinary.Columns["machineryQty"].Name == "machineryQty"
//    //    && dgvMachinary.Columns["machineryQty"] is DataGridViewTextBoxColumn)
//    //{
//    //    var textbox = e.Control as TextBox;
//    //    textbox.KeyUp += (s, e) =>
//    //    {
//    //        var textvalue = ((TextBox)s).AsNumber<decimal>();

//    //        var cost = dgvMachinary.GetValue<decimal>(dgvMachinary.CurrentRow.Index, "machineryCost");

//    //        var subcost = textvalue * cost;

//    //        dgvMachinary.SetText(dgvMachinary.CurrentRow.Index, "machinerySubtotal", Utility.NumberString(subcost));

//    //        txtSubtotalMachinery.SetText(CalculateItemPrice(dgvMachinary, "machinerySubtotal"));

//    //        UpdateBoqCost();

//    //        UpdateSalePrice();

//    //    };
//    //}
//}

//private void dgvMachinary_CellEndEdit(object sender, DataGridViewCellEventArgs e)
//{
////    if (dgvMachinary.Rows.Count == 0) return;
////    if (dgvMachinary.Columns[e.ColumnIndex].Name == "machineryQty")
////    {
////        var selectedRow = dgvMachinary.SelectedRows[0];
////        if (selectedRow.GetValue<int>("machineryQty") == 0)
////        {
////            dgvMachinary.SetText(dgvMachinary.CurrentRow.Index,"machineryQty", Utility.NumberString(0, "N2"));
////        }
////        else
////        {
////            var selectedValue = dgvMachinary.GetValue<decimal>(dgvMachinary.CurrentRow.Index,"machineryQty");
////            dgvMachinary.SetText(dgvMachinary.CurrentRow.Index, "machineryQty", Utility.NumberString(selectedValue, "N2"));
////        }
////    }
//}

//private void dgvMaterial_CellEndEdit(object sender, DataGridViewCellEventArgs e)
//{
//    //if (dgvMaterial.Rows.Count == 0) return;
//    //if (dgvMaterial.Columns[e.ColumnIndex].Name == "materialQty")
//    //{
//    //    var selectedRow = dgvMaterial.SelectedRows[0];
//    //    if (selectedRow.GetValue<int>("materialQty") == 0)
//    //    {
//    //        dgvMaterial.SetText(dgvMaterial.CurrentRow.Index,"materialQty", Utility.NumberString(0, "N2"));
//    //    }
//    //    else
//    //    {
//    //        var selectedValue = dgvMaterial.GetValue<int>(dgvMaterial.CurrentRow.Index,"materialQty");
//    //        dgvMaterial.SetText(dgvMaterial.CurrentRow.Index, "materialQty", Utility.NumberString(selectedValue, "N2"));
//    //    }
//    //}
//}

//private void dgvMaterial_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
//{
//    //if (dgvMaterial.Rows.Count == 0) return;

//    //if (dgvMaterial.Columns["materialQty"].Name == "materialQty"
//    //    && dgvMaterial.Columns["materialQty"] is DataGridViewTextBoxColumn)
//    //{
//    //    var textbox = e.Control as TextBox;
//    //    textbox.KeyUp += (s, e) =>
//    //    {
//    //        var textvalue = ((TextBox)s).AsNumber<decimal>();

//    //        var cost = dgvMaterial.GetValue<decimal>(dgvMaterial.CurrentRow.Index, "materialCost");

//    //        var subcost = textvalue * cost;

//    //        dgvMaterial.SetText(dgvMaterial.CurrentRow.Index, "materialSubtotal", Utility.NumberString(subcost));

//    //        txtSubtotalMaterial.SetText(CalculateItemPrice(dgvMaterial, "materialSubtotal"));

//    //        UpdateBoqCost();

//    //        UpdateSalePrice();

//    //    };
//    //}
//}

//if (aCost == null)
//{
//    AppService.GetBoqInstance.GetAdditinalCost(boq_id, out aCost);
//    txtBoqCOST.SetText(Utility.NumberString(CalculateItemPrice(dgvBoqItemLine, "labourSubtotal"), "N3"));
//    txtSubtotalBoqItem.SetText(Utility.NumberString(CalculateItemPrice(dgvBoqItemLine, "labourSubtotal"), "N3"));
//    this.LOSSOFEFFECIENCYRATE = aCost?.LOSSOFEFFECIENCYRATE;
//    this.OPERATIONRATE = aCost?.OPERATIONRATE;
//    this.OVERHEADRATE = aCost?.OVERHEADRATE;
//    this.TRANSPORTATIONRATE = aCost?.TRANSPORTATIONRATE;
//    this.SAFETYRATE = aCost?.SAFETYRATE;
//    this.MARGINRATE = aCost?.MARGINRATE;
//    this.INFlATIONRATE = aCost?.INFlATIONRATE;
//    ///Assign Additinal cost value
//    this.LOSSOFEFFECIENCY = aCost?.LOSSOFEFFECIENCY > 0 ? aCost?.LOSSOFEFFECIENCY : (txtSubtotalBoqItem.AsNumber<decimal>() * (aCost.LOSSOFEFFECIENCYRATE / 100));
//    this.OPERATION = aCost?.OPERATION > 0 ? aCost?.OPERATION : (txtSubtotalBoqItem.AsNumber<decimal>() * (aCost.OPERATIONRATE / 100)); ;
//    this.OVERHEAD = aCost?.OVERHEAD > 0 ? aCost?.OVERHEAD : (txtSubtotalBoqItem.AsNumber<decimal>() * (aCost.OVERHEADRATE / 100)); ;
//    this.TRANSPORTATION = aCost?.TRANSPORTATION > 0 ? aCost?.TRANSPORTATION : (txtSubtotalBoqItem.AsNumber<decimal>() * (aCost.TRANSPORTATIONRATE / 100)); ;
//    this.SAFETY = ((txtSubtotalBoqItem.AsNumber<decimal>() + (aCost.LOSSOFEFFECIENCY + aCost.OPERATION + aCost.OVERHEAD + aCost.SAFETY + aCost.TRANSPORTATION)) * (aCost.SAFETYRATE / 100));
//    this.MARGIN = CalculateInflation(this.INFlATIONRATE.Value, (this.LOSSOFEFFECIENCY.Value + this.OPERATION.Value + this.OVERHEAD.Value + this.TRANSPORTATION.Value + this.SAFETY.Value));
//    this.INFlATION = CalculateInflation(this.INFlATIONRATE.Value, (this.LOSSOFEFFECIENCY.Value + this.OPERATION.Value + this.OVERHEAD.Value + this.TRANSPORTATION.Value + this.SAFETY.Value));
//    ////Assign Total Additional Cost
//    this.TOTALADDITIONALCOST = aCost?.TOTALADDITIONALCOST;
//    this.TOTALMARINANDINFLATION = aCost?.TOTALMARINANDINFLATION;
//    //this.BOQCOST = aCost?.BOQCOST;
//    //UpdateAdditionCost();
//    UpdateMarginAndInflation();
//}
//else
//{