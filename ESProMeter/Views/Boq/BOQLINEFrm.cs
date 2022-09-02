﻿using Azure;
using ESProMeter.Controllers;
using ESProMeter.Extensions;
using ESProMeter.IVews;
using ESProMeter.Models;
using ESProMeter.Services;
using System;
using System.Windows.Forms;

namespace ESProMeter.Views.Boq
{
    public partial class BOQLINEFrm : Form,IADDITIONALCOSTRATE,IADDITIONALCOST
    {
        public BOQLINEFrm(long boq_id,long itemId,ADDITIONALCOST aCost)
        {
            InitializeComponent();
            lblBoqID.SetText(boq_id);
            lblBoqItemID.SetText(itemId);
            this.GetItemForUpdate(itemId);
            if (aCost == null)
            {
                AppService.GetBoqInstance.GetAdditinalCost(boq_id, out aCost);
                txtBoqCOST.SetText(CalculateItemPrice(dgvBoqItemLine, "labourSubtotal"));
                txtSubtotalBoqItem.SetText(CalculateItemPrice(dgvBoqItemLine, "labourSubtotal"));
                this.LOSSOFEFFECIENCYRATE = aCost?.LOSSOFEFFECIENCYRATE;
                this.OPERATIONRATE = aCost?.OPERATIONRATE;
                this.OVERHEADRATE = aCost?.OVERHEADRATE;
                this.TRANSPORTATIONRATE = aCost?.TRANSPORTATIONRATE;
                this.SAFETYRATE = aCost?.SAFETYRATE;
                this.MARGINRATE = aCost?.MARGINRATE;
                this.INFlATIONRATE = aCost?.INFlATIONRATE;
                ///Assign Additinal cost value
                this.LOSSOFEFFECIENCY = aCost?.LOSSOFEFFECIENCY>0?aCost?.LOSSOFEFFECIENCY:(txtSubtotalBoqItem.AsNumber<decimal>() * (aCost.LOSSOFEFFECIENCYRATE /100));
                this.OPERATION = aCost?.OPERATION > 0 ? aCost?.OPERATION : (txtSubtotalBoqItem.AsNumber<decimal>() * (aCost.OPERATIONRATE / 100)); ;
                this.OVERHEAD = aCost?.OVERHEAD > 0 ? aCost?.OVERHEAD : (txtSubtotalBoqItem.AsNumber<decimal>() * (aCost.OVERHEADRATE / 100)); ;
                this.TRANSPORTATION = aCost?.TRANSPORTATION > 0 ? aCost?.TRANSPORTATION : (txtSubtotalBoqItem.AsNumber<decimal>() * (aCost.TRANSPORTATIONRATE / 100)); ;
                this.SAFETY = ((txtSubtotalBoqItem.AsNumber<decimal>() + (aCost.LOSSOFEFFECIENCY + aCost.OPERATION + aCost.OVERHEAD + aCost.SAFETY + aCost.TRANSPORTATION) )  * (aCost.SAFETYRATE / 100)); 
                this.MARGIN = CalculateInflation(this.INFlATIONRATE.Value, (this.LOSSOFEFFECIENCY.Value + this.OPERATION.Value + this.OVERHEAD.Value + this.TRANSPORTATION.Value + this.SAFETY.Value));
                this.INFlATION =CalculateInflation(this.INFlATIONRATE.Value ,(this.LOSSOFEFFECIENCY.Value + this.OPERATION.Value + this.OVERHEAD.Value + this.TRANSPORTATION.Value + this.SAFETY.Value)) ;
                ////Assign Total Additional Cost
                this.TOTALADDITIONALCOST = aCost?.TOTALADDITIONALCOST;
                this.TOTALMARINANDINFLATION = aCost?.TOTALMARINANDINFLATION;
                //this.BOQCOST = aCost?.BOQCOST;
                //UpdateAdditionCost();
                UpdateMarginAndInflation();
            }
            else
            {
                txtBoqCOST.SetText(CalculateItemPrice(dgvBoqItemLine, "labourSubtotal"));
                txtSubtotalBoqItem.SetText(CalculateItemPrice(dgvBoqItemLine, "labourSubtotal"));
                this.LOSSOFEFFECIENCYRATE = aCost?.LOSSOFEFFECIENCYRATE;
                this.OPERATIONRATE = aCost?.OPERATIONRATE;
                this.OVERHEADRATE = aCost?.OVERHEADRATE;
                this.TRANSPORTATIONRATE = aCost?.TRANSPORTATIONRATE;
                this.SAFETYRATE = aCost?.SAFETYRATE;
                this.MARGINRATE = aCost?.MARGINRATE;
                this.INFlATIONRATE = aCost?.INFlATIONRATE;
                ///Assign Additinal cost value
                this.LOSSOFEFFECIENCY = aCost?.LOSSOFEFFECIENCY;
                this.OPERATION = aCost?.OPERATION;
                this.OVERHEAD = aCost?.OVERHEAD;
                this.TRANSPORTATION = aCost?.TRANSPORTATION;
                this.SAFETY = aCost?.SAFETY;
                this.MARGIN = aCost?.MARGIN;
                this.INFlATION = aCost?.INFlATION;
                ////Assign Total Additional Cost
                this.TOTALADDITIONALCOST = aCost?.TOTALADDITIONALCOST;
                this.TOTALMARINANDINFLATION = aCost?.TOTALMARINANDINFLATION;
                this.BOQCOST = aCost?.BOQCOST;
            }
            ////
            txtLoseEffecency.LostFocus -= TxtLostFocus;
            txtOperation.LostFocus -= TxtLostFocus;
            txtOverhead.LostFocus -= TxtLostFocus;
            txtSafty.LostFocus -= TxtLostFocus;
            txtMargin.LostFocus -= TxtLostFocus;
            txtInflation.LostFocus += TxtLostFocus;
            txtTransportation.LostFocus -= TxtLostFocus;
            ////
            txtLoseEffecency.LostFocus += TxtLostFocus;
            txtOperation.LostFocus += TxtLostFocus;
            txtOverhead.LostFocus += TxtLostFocus;
            txtSafty.LostFocus += TxtLostFocus;
            txtMargin.LostFocus += TxtLostFocus;
            txtInflation.LostFocus += TxtLostFocus;
            txtTransportation.LostFocus += TxtLostFocus;
            ///
            txtLoseEffecency.GotFocus -= TxtGotFocus;
            txtOperation.GotFocus -= TxtGotFocus;
            txtOverhead.GotFocus -= TxtGotFocus;
            txtSafty.GotFocus -= TxtGotFocus;
            txtMargin.GotFocus -= TxtGotFocus;
            txtInflation.GotFocus -= TxtGotFocus;
            txtTransportation.GotFocus -= TxtGotFocus;
            //-------------------------------
            txtLoseEffecency.GotFocus += TxtGotFocus;
            txtOperation.GotFocus += TxtGotFocus;
            txtOverhead.GotFocus += TxtGotFocus;
            txtSafty.GotFocus += TxtGotFocus;
            txtMargin.GotFocus += TxtGotFocus;
            txtInflation.GotFocus += TxtGotFocus;
            txtTransportation.GotFocus += TxtGotFocus;
            //keyup event
            txtLoseEffecency.KeyUp += TxtLoeCostKeyUp;
            txtOperation.KeyUp += TxtOperation_KeyUp; ;
            txtOverhead.KeyUp += TxtOverhead_KeyUp; ;
            txtSafty.KeyUp += TxtSafty_KeyUp; ;
            txtMargin.KeyUp += TxtMargin_KeyUp; ;
            txtInflation.KeyUp += TxtInflation_KeyUp; ;
            txtTransportation.KeyUp += TxtTransportation_KeyUp;

            ////
            ///
            UpdateAdditionCost();
            UpdateMarginAndInflation();
            UpdateSalePrice();

        }

        private void TxtTransportation_KeyUp(object sender, KeyEventArgs e)
        {
            var textValue = ((TextBox)sender).AsNumber<decimal>();
            var transportation = (textValue * txtBoqCOST.AsNumber<decimal>() / 100);
            txtTransportationValue.SetText(Utility.NumberString(transportation));
            UpdateAdditionCost();
            UpdateMarginAndInflation();
            UpdateSalePrice();
        }

        private void TxtInflation_KeyUp(object sender, KeyEventArgs e)
        {
            var textValue = ((TextBox)sender).AsNumber<decimal>();
            var inflation = ((textValue / 100) * (txtBoqCOST.AsNumber<decimal>() + txtAdditionalSubTotal.AsNumber<decimal>()));
            txtInflationValue.SetText(Utility.NumberString(inflation,"N3"));
            UpdateAdditionCost();
            UpdateMarginAndInflation();
            UpdateSalePrice();
        }

        private void TxtMargin_KeyUp(object sender, KeyEventArgs e)
        {
            var textValue = ((TextBox)sender).AsNumber<decimal>();
            var margin = ((textValue / 100) * (txtBoqCOST.AsNumber<decimal>() + txtAdditionalSubTotal.AsNumber<decimal>()));
            txtMarginValue.SetText(Utility.NumberString(margin));
            UpdateAdditionCost();
            UpdateMarginAndInflation();
            UpdateSalePrice();
        }

        private void TxtSafty_KeyUp(object sender, KeyEventArgs e)
        {
            var textValue = ((TextBox)sender).AsNumber<decimal>();
            var safty = (textValue * txtBoqCOST.AsNumber<decimal>() / 100);
            txtSaftyValue.SetText(Utility.NumberString(safty));
            UpdateAdditionCost();
            UpdateMarginAndInflation();
            UpdateSalePrice();
        }

        private void TxtOverhead_KeyUp(object sender, KeyEventArgs e)
        {
            var textValue = ((TextBox)sender).AsNumber<decimal>();
            var overhead = (textValue * txtBoqCOST.AsNumber<decimal>() / 100);
            txtOverheadValue.SetText(Utility.NumberString(overhead));
            UpdateAdditionCost();
            UpdateMarginAndInflation();
            UpdateSalePrice();
        }

        private void TxtOperation_KeyUp(object sender, KeyEventArgs e)
        {
            var textValue = ((TextBox)sender).AsNumber<decimal>();
            var operation = (textValue * txtBoqCOST.AsNumber<decimal>() / 100);
            txtOperationValue.SetText(Utility.NumberString(operation));
            UpdateAdditionCost();
            UpdateMarginAndInflation();
            UpdateSalePrice();
        }

        private void TxtLoeCostKeyUp(object sender, KeyEventArgs e)
        {
            var textValue = ((TextBox)sender).AsNumber<decimal>();
            var loe = (textValue * txtBoqCOST.AsNumber<decimal>() /100);
            txtLoseEfficencyValue.SetText(Utility.NumberString(loe));
            UpdateAdditionCost();
            UpdateMarginAndInflation();
            UpdateSalePrice();
        }

        private void TxtGotFocus(object sender, EventArgs e)
        {
            ((TextBox)sender)?.BeginInvoke(new Action(((TextBox)sender).SelectAll));
        }

        private void TxtLostFocus(object sender, EventArgs e)
        {
            var textValue = ((TextBox)sender).AsNumber<decimal>();
            if (textValue >= 100)
            {
                MessageBox.Show("The value must not greater than 100.","Additinal Cost",MessageBoxButtons.OK);
                ((TextBox)sender).Focus();
                ((TextBox)sender).SelectAll();
                return;
            }
            ((TextBox)sender).Text=Utility.NumberString(textValue, "N3");
        }


        void UpdateAdditionCost()
        {
            var totalAdditionalCost = 0M;
            var loe = txtLoseEfficencyValue.AsNumber<decimal>();
            var operate = txtOperationValue.AsNumber<decimal>();
            var overhead = txtOverheadValue.AsNumber<decimal>();
            var transportation = txtTransportationValue.AsNumber<decimal>(); 
            var satfy = txtSaftyValue.AsNumber<decimal>();
            totalAdditionalCost = (loe + operate + overhead + transportation + satfy);
            txtAdditionalSubTotal.SetText(Utility.NumberString(totalAdditionalCost, "N3"));
        }
        void UpdateMarginAndInflation()
        {
            var totalCost = 0M;
            var margin = txtMarginValue.AsNumber<decimal>();
            var inflation = txtInflationValue.AsNumber<decimal>();
            totalCost = (margin + inflation);
            txtSubtotalMagrinAndInflation.SetText(Utility.NumberString(totalCost,"N3"));
        }

        decimal CalculateMargin(decimal rate,decimal price) 
        {
            return (rate / 100) * price;
        }
        decimal CalculateInflation(decimal rate, decimal price) 
        {
            return (rate / 100) * price;
        }
        void UpdateSalePrice()
        {
            var totalCost = 0M;
            var additionalCost  = txtAdditionalSubTotal.AsNumber<decimal>();
            var marginAndInflation = txtSubtotalMagrinAndInflation.AsNumber<decimal>();
            var boqCost = txtBoqCOST.AsNumber<decimal>();
            totalCost = (additionalCost + marginAndInflation + boqCost);
            txtsalePrice.SetText(Utility.NumberString(totalCost, "N3"));
        }

        void UpdateBoqCost() 
        {
            var totalCost = 0M;
            var labour = txtSubtotalBoqItem.AsNumber<decimal>();
            var material = txtAdditionalSubTotal.AsNumber<decimal>();
            var machinery = txtSubtotalMagrinAndInflation.AsNumber<decimal>();
            totalCost = (labour + material + machinery);
            txtBoqCOST.SetText(Utility.NumberString(totalCost, "N3"));
        }
        #region properties
        public decimal? LOSSOFEFFECIENCYRATE 
        { 
            get => txtLoseEffecency.AsNumber<decimal>(); 
            set => txtLoseEffecency.SetText(Utility.NumberString(value,"N3")); 
        }
        public decimal? OPERATIONRATE 
        { get => txtOperation.AsNumber<decimal>(); 
            set => txtOperation.SetText(Utility.NumberString(value, "N3")); 
        }
        public decimal? OVERHEADRATE 
        { get => txtOverhead.AsNumber<decimal>(); 
            set => txtOverhead.SetText(Utility.NumberString(value, "N3")); 
        }
        public decimal? SAFETYRATE 
        { get => txtSafty.AsNumber<decimal>(); 
            set => txtSafty.SetText(Utility.NumberString(value, "N3")); 
        }
        public decimal? TRANSPORTATIONRATE 
        { get => txtTransportation.AsNumber<decimal>(); 
            set => txtTransportation.SetText(Utility.NumberString(value, "N3")); 
        }
        public decimal? MARGINRATE 
        { get => txtMargin.AsNumber<decimal>(); 
            set => txtMargin.SetText(Utility.NumberString(value, "N3")); 
        }
        public decimal? INFlATIONRATE 
        { 
            get => txtInflation.AsNumber<decimal>(); 
            set => txtInflation.SetText(Utility.NumberString(value, "N3")); 
        }
        public decimal? LOSSOFEFFECIENCY { 
            get => txtLoseEfficencyValue.AsNumber<decimal>();
            set => txtLoseEfficencyValue.SetText(Utility.NumberString(value, "N3"));
        }
        public decimal? OPERATION { 
            get => txtOperationValue.AsNumber<decimal>(); 
            set => txtOperationValue.SetText(Utility.NumberString(value, "N3")); 
        }
        public decimal? OVERHEAD { 
            get => txtOverheadValue.AsNumber<decimal>(); 
            set => txtOverheadValue.SetText(Utility.NumberString(value, "N3")); 
        }
        public decimal? SAFETY { 
            get => txtSaftyValue.AsNumber<decimal>(); 
            set => txtSaftyValue.SetText(Utility.NumberString(value, "N3")); 
        }
        public decimal? TRANSPORTATION { 
            get => txtTransportationValue.AsNumber<decimal>(); 
            set => txtTransportationValue.SetText(Utility.NumberString(value, "N3")); 
        }
        public decimal? MARGIN { 
            get => txtMarginValue.AsNumber<decimal>(); 
            set => txtMarginValue.SetText(Utility.NumberString(value, "N3")); 
        }
        public decimal? INFlATION { 
            get => txtInflationValue.AsNumber<decimal>(); 
            set => txtInflationValue.SetText(Utility.NumberString(value, "N3")); 
        }
        public decimal? TOTALADDITIONALCOST { 
            get=>txtAdditionalSubTotal.AsNumber<decimal>(); 
            set=>txtAdditionalSubTotal.SetText(Utility.NumberString(value, "N3")); }
        public decimal? TOTALMARINANDINFLATION { 
            get=>txtSubtotalMagrinAndInflation.AsNumber<decimal>(); 
            set=>txtSubtotalMagrinAndInflation.SetText(Utility.NumberString(value, "N3")); }
        public decimal? BOQCOST { 
            get=>txtBoqCOST.AsNumber<decimal>(); 
            set=>txtBoqCOST.SetText(Utility.NumberString(value, "N3")); 
        }
        #endregion
        
        
        private void CalculateAdditionalCost()
        {
            txtLoseEfficencyValue.SetText(Utility.NumberString(txtBoqCOST.AsNumber<decimal>() * (txtLoseEffecency.AsNumber<decimal>()/100),"N3"));
            txtOperationValue.SetText(Utility.NumberString(txtBoqCOST.AsNumber<decimal>() * (txtOperation.AsNumber<decimal>() / 100),"N3"));
            txtOverheadValue.SetText(Utility.NumberString(txtBoqCOST.AsNumber<decimal>() * (txtOverhead.AsNumber<decimal>() / 100),"N3"));
            txtSaftyValue.SetText(Utility.NumberString(txtBoqCOST.AsNumber<decimal>() * (txtSafty.AsNumber<decimal>() / 100),"N3"));
            txtTransportationValue.SetText(Utility.NumberString(txtBoqCOST.AsNumber<decimal>() * (txtTransportation.AsNumber<decimal>() / 100),"N3"));

        }
        private void mbtCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void mbtNext_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
        private decimal CalculateItemPrice(DataGridView view,string columnName)
        {
            var subtotal = 0M;
            foreach (DataGridViewRow row in view.Rows)
            {
                if (row.IsNewRow) continue;
                if (row.GetValue<decimal>(columnName)>=0)
                {
                    subtotal += row.GetValue<decimal>(columnName);
                }
            }
            return subtotal;
        }
        private void BOQLINEFrm_Load(object sender, EventArgs e)
        {
            
        }

        private void dgvBoqItemLine_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvBoqItemLine.Columns[e.ColumnIndex].Name == "labourSubtotal")
            {
                if(e.Value != null)
                {
                    e.CellStyle.Format = "N2";
                }
            }
            if (dgvBoqItemLine.Columns[e.ColumnIndex].Name == "buttoncolumn1")
            {
                if (e.Value != null)
                {
                    e.CellStyle.Format = "N2";
                }
            }
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