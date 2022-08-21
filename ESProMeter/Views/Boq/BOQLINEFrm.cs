using Azure;
using ESProMeter.Controllers;
using ESProMeter.Extensions;
using ESProMeter.IVews;
using ESProMeter.Models;
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
            this.LOSSOFEFFECIENCYRATE = aCost?.LOSSOFEFFECIENCYRATE;
            this.OPERATIONRATE = aCost?.OPERATIONRATE;
            this.OVERHEADRATE = aCost?.OVERHEADRATE;
            this.TRANSPORTATIONRATE = aCost?.TRANSPORTATIONRATE;
            this.SAFETYRATE = aCost?.SAFETYRATE;
            this.MARGINRATE = aCost?.MARGINRATE;
            this.INFlATIONRATE = aCost?.INFlATIONRATE;
            this.LOSSOFEFFECIENCY = aCost?.LOSSOFEFFECIENCY;
            this.OPERATION = aCost?.OPERATION;
            this.OVERHEAD= aCost?.OVERHEAD;
            this.TRANSPORTATION = aCost?.TRANSPORTATION;
            this.SAFETY = aCost?.SAFETY;
            this.MARGIN = aCost?.MARGIN;
            this.INFlATION = aCost?.INFlATION;
            this.TOTALADDITIONALCOST = aCost?.TOTALADDITIONALCOST;
            this.TOTALMARINANDINFLATION = aCost?.TOTALMARINANDINFLATION;
            this.BOQCOST = aCost?.BOQCOST;
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
            txtTransportation.KeyUp += TxtTransportation_KeyUp; ;
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
            var inflation = (textValue * txtBoqCOST.AsNumber<decimal>() / 100);
            txtInflationValue.SetText(Utility.NumberString(inflation));
            UpdateAdditionCost();
            UpdateMarginAndInflation();
            UpdateSalePrice();
        }

        private void TxtMargin_KeyUp(object sender, KeyEventArgs e)
        {
            var textValue = ((TextBox)sender).AsNumber<decimal>();
            var margin = (textValue * txtBoqCOST.AsNumber<decimal>() / 100);
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
            txtLoseEfficency.SetText(Utility.NumberString(loe));
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
            var loe = txtLoseEfficency.AsNumber<decimal>();
            var operate = txtOperationValue.AsNumber<decimal>();
            var overhead = txtOverheadValue.AsNumber<decimal>();
            var transportation = txtTransportationValue.AsNumber<decimal>(); 
            var satfy = txtSaftyValue.AsNumber<decimal>();
            totalAdditionalCost = (loe + operate + overhead + transportation + satfy);
            txtAdditionalSubTotal.SetText(Utility.NumberString(totalAdditionalCost));
        }
        void UpdateMarginAndInflation()
        {
            var totalCost = 0M;
            var margin = txtMarginValue.AsNumber<decimal>();
            var inflation = txtInflationValue.AsNumber<decimal>();
            totalCost = (margin + inflation);
            txtSubtotalMagrinAndInflation.SetText(Utility.NumberString(totalCost));
        }

        void UpdateSalePrice()
        {
            var totalCost = 0M;
            var additionalCost  = txtAdditionalSubTotal.AsNumber<decimal>();
            var marginAndInflation = txtSubtotalMagrinAndInflation.AsNumber<decimal>();
            var boqCost = txtBoqCOST.AsNumber<decimal>();
            totalCost = (additionalCost + marginAndInflation + boqCost);
            txtsalePrice.SetText(Utility.NumberString(totalCost));
        }

        void UpdateBoqCost() 
        {
            var totalCost = 0M;
            var labour = txtSubtotalLabour.AsNumber<decimal>();
            var material = txtSubtotalMaterial.AsNumber<decimal>();
            var machinery = txtSubtotalMachinery.AsNumber<decimal>();
            totalCost = (labour + material + machinery);
            txtBoqCOST.SetText(Utility.NumberString(totalCost));
        }
        #region properties
        public decimal? LOSSOFEFFECIENCYRATE 
        { 
            get => txtLoseEffecency.AsNumber<decimal>(); 
            set => txtLoseEffecency.SetText(value); 
        }
        public decimal? OPERATIONRATE 
        { get => txtOperation.AsNumber<decimal>(); 
            set => txtOperation.SetText(value); 
        }
        public decimal? OVERHEADRATE 
        { get => txtOverhead.AsNumber<decimal>(); 
            set => txtOverhead.SetText(value); 
        }
        public decimal? SAFETYRATE 
        { get => txtSafty.AsNumber<decimal>(); 
            set => txtSafty.SetText(value); 
        }
        public decimal? TRANSPORTATIONRATE 
        { get => txtTransportation.AsNumber<decimal>(); 
            set => txtTransportation.SetText(value); 
        }
        public decimal? MARGINRATE 
        { get => txtMargin.AsNumber<decimal>(); 
            set => txtMargin.SetText(value); 
        }
        public decimal? INFlATIONRATE 
        { 
            get => txtInflation.AsNumber<decimal>(); 
            set => txtInflation.SetText(value); 
        }
        public decimal? LOSSOFEFFECIENCY { 
            get => txtLoseEfficency.AsNumber<decimal>();
            set => txtLoseEfficency.SetText(value);
        }
        public decimal? OPERATION { 
            get => txtOperationValue.AsNumber<decimal>(); 
            set => txtOperationValue.SetText(value); 
        }
        public decimal? OVERHEAD { 
            get => txtOverheadValue.AsNumber<decimal>(); 
            set => txtOverheadValue.SetText(value); 
        }
        public decimal? SAFETY { 
            get => txtSaftyValue.AsNumber<decimal>(); 
            set => txtSaftyValue.SetText(value); 
        }
        public decimal? TRANSPORTATION { 
            get => txtTransportationValue.AsNumber<decimal>(); 
            set => txtTransportationValue.SetText(value); 
        }
        public decimal? MARGIN { 
            get => txtMarginValue.AsNumber<decimal>(); 
            set => txtMarginValue.SetText(value); 
        }
        public decimal? INFlATION { 
            get => txtInflationValue.AsNumber<decimal>(); 
            set => txtInflationValue.SetText(value); 
        }
        public decimal? TOTALADDITIONALCOST { 
            get=>txtAdditionalSubTotal.AsNumber<decimal>(); 
            set=>txtAdditionalSubTotal.SetText(value); }
        public decimal? TOTALMARINANDINFLATION { 
            get=>txtSubtotalMagrinAndInflation.AsNumber<decimal>(); 
            set=>txtSubtotalMagrinAndInflation.SetText(value); }
        public decimal? BOQCOST { 
            get=>txtBoqCOST.AsNumber<decimal>(); 
            set=>txtBoqCOST.SetText(value); 
        }
        #endregion
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

        private void dgvLabor_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
           
        }

        private void BOQLINEFrm_Load(object sender, EventArgs e)
        {
            txtSubtotalLabour.SetText(CalculateItemPrice(dgvLabor, "labourSubtotal"));
            txtSubtotalMachinery.SetText(CalculateItemPrice(dgvMachinary, "machinerySubtotal"));
            txtSubtotalMaterial.SetText(CalculateItemPrice(dgvMaterial, "materialSubtotal"));
            UpdateBoqCost();
            UpdateSalePrice();
        }

        private void dgvLabor_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dgvLabor.Rows.Count == 0) return;

            if (dgvLabor.Columns["laborBOQItemLineQty"].Name== "laborBOQItemLineQty" 
                && dgvLabor.Columns["laborBOQItemLineQty"] is DataGridViewTextBoxColumn)
            {
                var textbox = e.Control as TextBox;
                textbox.KeyUp += (s, e) =>
                {
                    var textvalue = ((TextBox)s).AsNumber<decimal>();

                    var cost = dgvLabor.GetValue<decimal>(dgvLabor.CurrentRow.Index, "ButtonColumn1");

                    var subcost = textvalue * cost;

                    dgvLabor.SetText(dgvLabor.CurrentRow.Index, "labourSubtotal", Utility.NumberString(subcost));

                    txtSubtotalLabour.SetText(CalculateItemPrice(dgvLabor, "labourSubtotal"));

                    UpdateBoqCost();

                    UpdateSalePrice();

                };
            }
        }

        private void dgvLabor_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvLabor.Rows.Count == 0) return;
            if (dgvLabor.Columns[e.ColumnIndex].Name == "laborBOQItemLineQty")
            {
                var selectedRow = dgvLabor.SelectedRows[0];
                if (selectedRow.GetValue<int>("laborBOQItemLineQty") == 0)
                {
                    dgvLabor.SetText(dgvLabor.CurrentRow.Index,"laborBOQItemLineQty",Utility.NumberString(0,"N2"));
                }
                else
                {
                    var selectedValue = dgvLabor.GetValue<decimal>(dgvLabor.CurrentRow.Index,"laborBOQItemLineQty");
                    dgvLabor.SetText(dgvLabor.CurrentRow.Index,"laborBOQItemLineQty", Utility.NumberString(selectedValue, "N2"));
                }
            }
        }

        private void dgvMachinary_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dgvMachinary.Rows.Count == 0) return;

            if (dgvMachinary.Columns["machineryQty"].Name == "machineryQty"
                && dgvMachinary.Columns["machineryQty"] is DataGridViewTextBoxColumn)
            {
                var textbox = e.Control as TextBox;
                textbox.KeyUp += (s, e) =>
                {
                    var textvalue = ((TextBox)s).AsNumber<decimal>();

                    var cost = dgvMachinary.GetValue<decimal>(dgvMachinary.CurrentRow.Index, "machineryCost");

                    var subcost = textvalue * cost;

                    dgvMachinary.SetText(dgvMachinary.CurrentRow.Index, "machinerySubtotal", Utility.NumberString(subcost));

                    txtSubtotalMachinery.SetText(CalculateItemPrice(dgvMachinary, "machinerySubtotal"));

                    UpdateBoqCost();

                    UpdateSalePrice();

                };
            }
        }

        private void dgvMachinary_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvMachinary.Rows.Count == 0) return;
            if (dgvMachinary.Columns[e.ColumnIndex].Name == "machineryQty")
            {
                var selectedRow = dgvMachinary.SelectedRows[0];
                if (selectedRow.GetValue<int>("machineryQty") == 0)
                {
                    dgvMachinary.SetText(dgvMachinary.CurrentRow.Index,"machineryQty", Utility.NumberString(0, "N2"));
                }
                else
                {
                    var selectedValue = dgvMachinary.GetValue<decimal>(dgvMachinary.CurrentRow.Index,"machineryQty");
                    dgvMachinary.SetText(dgvMachinary.CurrentRow.Index, "machineryQty", Utility.NumberString(selectedValue, "N2"));
                }
            }
        }

        private void dgvMaterial_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvMaterial.Rows.Count == 0) return;
            if (dgvMaterial.Columns[e.ColumnIndex].Name == "materialQty")
            {
                var selectedRow = dgvMaterial.SelectedRows[0];
                if (selectedRow.GetValue<int>("materialQty") == 0)
                {
                    dgvMaterial.SetText(dgvMaterial.CurrentRow.Index,"materialQty", Utility.NumberString(0, "N2"));
                }
                else
                {
                    var selectedValue = dgvMaterial.GetValue<int>(dgvMaterial.CurrentRow.Index,"materialQty");
                    dgvMaterial.SetText(dgvMaterial.CurrentRow.Index, "materialQty", Utility.NumberString(selectedValue, "N2"));
                }
            }
        }

        private void dgvMaterial_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dgvMaterial.Rows.Count == 0) return;

            if (dgvMaterial.Columns["materialQty"].Name == "materialQty"
                && dgvMaterial.Columns["materialQty"] is DataGridViewTextBoxColumn)
            {
                var textbox = e.Control as TextBox;
                textbox.KeyUp += (s, e) =>
                {
                    var textvalue = ((TextBox)s).AsNumber<decimal>();

                    var cost = dgvMaterial.GetValue<decimal>(dgvMaterial.CurrentRow.Index, "materialCost");

                    var subcost = textvalue * cost;

                    dgvMaterial.SetText(dgvMaterial.CurrentRow.Index, "materialSubtotal", Utility.NumberString(subcost));

                    txtSubtotalMaterial.SetText(CalculateItemPrice(dgvMaterial, "materialSubtotal"));

                    UpdateBoqCost();

                    UpdateSalePrice();

                };
            }
        }
    }
}
