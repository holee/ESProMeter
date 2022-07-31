using ESProMeter.Controllers;
using ESProMeter.Extensions;
using ESProMeter.IVews;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace ESProMeter.Views.Items
{
    public partial class CreateACopyItemFrm : Form, IItem
    {
        public string ItemName
        {
            get => textName.Text.Trim();
            set => textName.SetText(value);
        }
        public string ItemType
        {
            get => cmbType.Text;
            set => cmbType.Text = value;
        }
        public long UomId
        {
            get => (long)cmbUom.SelectedValue;
            set => cmbUom.SelectedValue = value;
        }
        public decimal Cost
        {
            get => textCost.AsNumber<decimal>();
            set => textCost.SetText(value);
        }
        public string Description
        {
            get => textDescription.Text.Trim();
            set => textDescription.SetText(value);
        }
        public bool IsActive
        {
            get => !chkIsInActive.Checked;
            set => chkIsInActive.Checked = !value;
        }
        public long Id
        {
            get => lblItemID.AsNumber<long>();
            set => lblItemID.SetText(value);
        }
        public CreateACopyItemFrm()
        {
            InitializeComponent();
            this.ShowItemType(this.cmbType);
            this.ShowUom(this.cmbUom);
            materialButton1.Text = "Save";
        }
        public CreateACopyItemFrm(long Id)
        {
            InitializeComponent();
            this.ShowItemType(this.cmbType);
            this.ShowUom(this.cmbUom);
            //this.ShowItemFormUpdate(Id, this);
            materialButton1.Text = "Update";
        }
        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (((TextBox)sender).Text.Length > 0)
            {
                //((DataTable)dgvItem.DataSource)?.Clear();
                //this.SearchItemList(dgvItem, ((TextBox)sender).Text, "ID", "ItemName", "ItemType", "Uom", "UomID", "Cost");
                //dgvItem.Visible = true;
                //dgvItem.BringToFront();
                //dgvItem.Location = new Point(((TextBox)sender).Location.X, ((TextBox)sender).Location.Y + ((TextBox)sender).Height);
                //return;
            }
            dgvItem.Visible = false;
            dgvItem.SendToBack();
        }

        private void ShowItemOnlyForm()
        {
            this.groupBoq.Visible = false;
            this.Controls.RemoveByKey(groupBoq.Name);
            this.Height = 300;
            this.textCost.Enabled = true;
            this.materialButton1.Location = new Point(460, 220);
            this.materialButton2.Location = new Point(585, 220);
        }
        private void ShowBoqItemOnlyForm()
        {
            this.groupBoq.Visible = true;
            this.Controls.Add(this.groupBoq);
            this.Height = 594;
            this.textCost.Enabled = false;
            this.materialButton1.Location = new Point(460, 498);
            this.materialButton2.Location = new Point(585, 498);
        }
        private void AddItemFrm_Load(object sender, EventArgs e)
        {

            //if(ItemListFrm._itemType != 0)
            //{
            //    ShowItemOnlyForm();
            //}
            //else
            //{
            //    ShowBoqItemOnlyForm();
            //}
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbType.SelectedIndex == 3)
            {
                ShowBoqItemOnlyForm();
            }
            else
            {
                ShowItemOnlyForm();
            }
        }

        int itemSequence = 1;
        private void dgvItem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvItem.Columns[e.ColumnIndex].Name == "Column1" &&
                    (dgvItem.Columns[e.ColumnIndex] is DataGridViewButtonColumn))
            {
                var id = dgvItem.GetValue<long>(e.RowIndex, "ItemID");
                if (CheckItemExist(id))
                {
                    dgvItem.Visible = false;
                    dgvItem.SendToBack();
                    textBox1.Text = "";
                    return;
                }
                //var data=this.SearchItemList(id, "ID", "ItemName", "ItemType", "Uom", "UomID");
                //data.Add(Utility.NumberString(1,"N2"));
                //dgvBoq.Rows.Add(data.ToArray());
                //dgvItem.Visible = false;
                //dgvItem.SendToBack();
                //textBox1.Text = "";
                //itemSequence++;
            }
        }

        private void dgvBoq_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }
        private bool CheckItemExist(object value)
        {
            foreach (DataGridViewRow item in dgvBoq.Rows)
            {
                if (item.Cells["BOQITEMLINEID"].Value.Equals(value))
                {
                    return true;
                }

            }
            return false;
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            if (cmbType.SelectedIndex > 0)
            {
                if (this.IsValid(textName, textDescription, textCost))
                {
                    this.DialogResult = DialogResult.OK;
                }

            }
            else
            {
                if (this.IsValid(textName, textDescription, textCost))
                {
                    //this.CreateNewBoqItem(this, this.dgvBoq);
                    this.DialogResult = DialogResult.OK;
                }

            }
        }

        private void dgvBoq_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvBoq.Rows.Count > 0)
            {
                if (dgvBoq.Columns[e.ColumnIndex].Name == "btnDeleteColumn"
                    && dgvBoq.Columns[e.ColumnIndex] is DataGridViewColumn)
                {
                    dgvBoq.Rows.RemoveAt(e.RowIndex);
                }
            }
        }





















        //    private void TextCost_LostFocus(object sender, EventArgs e)
        //    {
        //        if (string.IsNullOrEmpty(((TextBox)sender).Text)){
        //            ((TextBox)sender).SetText(Utility.NumberString(0));
        //            return;
        //        }
        //        else
        //        {
        //            var value = ((TextBox)sender).AsNumber<long>();
        //            ((TextBox)sender).SetText(Utility.NumberString(value));
        //            return;
        //        }
        //    }

        //    private void TextCost_GotFocus(object sender, EventArgs e)
        //    {
        //        var value = ((TextBox)sender).AsNumber<long>();
        //        if (value==0.0)
        //        {
        //            ((TextBox)sender).SetText("");
        //            return;
        //        }
        //        else
        //        {
        //            ((TextBox)sender).SetText(Utility.NumberString(value));
        //            return;
        //        }
        //    }

        //    private void TextMargin_LostFocus(object sender, EventArgs e)
        //    {
        //        if (string.IsNullOrEmpty(((TextBox)sender).Text))
        //        {
        //            ((TextBox)sender).SetText(Utility.NumberString(0, "N2"));
        //        }
        //    }

        //    private void textMargin_Enter(object sender, EventArgs e)
        //    {
        //        ((TextBox)sender)?.BeginInvoke(new Action(((TextBox)sender).SelectAll));
        //    }
        //    private void TextMargin_GotFocus(object sender, EventArgs e)
        //    {

        //        //else
        //        //{
        //        //    var margin = ((TextBox)sender).AsNumber<decimal>();
        //        //    ((TextBox)sender).SetText(Utility.Number(margin, "N0"));
        //        //    ((TextBox)sender).Select(2, 1);
        //        //}

        //    }

        //    private void TextInflation_LostFocus(object sender, EventArgs e)
        //    {
        //        if (string.IsNullOrEmpty(((TextBox)sender).Text))
        //        {
        //            ((TextBox)sender).SetText(Utility.NumberString(0, "N2"));
        //        }
        //        else
        //        {
        //            var inflation = ((TextBox)sender).AsNumber<decimal>();
        //            ((TextBox)sender).Text = Utility.NumberString(inflation, "N2");
        //        }
        //    }

        //    private void TextInflation_GotFocus(object sender, EventArgs e)
        //    {
        //        if (!string.IsNullOrEmpty(((TextBox)sender).Text))
        //        {
        //            ((TextBox)sender).SelectAll();
        //            return;
        //        }
        //        else
        //        {
        //            var margin = ((TextBox)sender).AsNumber<decimal>();
        //            ((TextBox)sender).SetText(Utility.NumberString(margin, "N0"));
        //            ((TextBox)sender).Select(2, 1);
        //        }
        //    }
        //    private void AddItemFrm_Load(object sender, EventArgs e)
        //    {
        //        this.ShowItemType();
        //        this.ShowUom();

        //    }


        //    private void btnUomCreate_Click(object sender, EventArgs e)
        //    {
        //        Form form = new AddUoMFrm();
        //        if (form.ShowDialog() == DialogResult.OK)
        //        {
        //            this.ShowUom();
        //        };
        //    }
        //    private void materialButton2_Click(object sender, EventArgs e)
        //    {
        //        this.Close();
        //    }
        //    private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        //    {
        //        if (cmbType.SelectedIndex == -1) return;
        //        if (cmbType.Text == "Bill Of Quantity")
        //        {
        //            this.Able(checkMargin, checkInflation, dataAdditional);
        //            this.Disable(textPrice, textCost);
        //            try
        //            {
        //                groupBoq.Enabled = true;
        //            }
        //            catch (Exception)
        //            {
        //                throw;
        //            }
        //            try
        //            {
        //                DataGridViewComboBoxColumn cmbLabor = (DataGridViewComboBoxColumn)dataLabor.Columns["Column1"];
        //                if (this.GetItemTypes("Labor", out List<string> data))
        //                {
        //                    cmbLabor.Items.Clear();
        //                    cmbLabor.Items.AddRange(data.ToArray());
        //                }

        //                DataGridViewComboBoxColumn cmbMachinary = (DataGridViewComboBoxColumn)dataMachinary.Columns["mnrItemName"];
        //                if (this.GetItemTypes("Machinary", out List<string> data1))
        //                {
        //                    cmbMachinary.Items.Clear();
        //                    cmbMachinary.Items.AddRange(data1.ToArray());
        //                }
        //                DataGridViewComboBoxColumn cmdMaterial = (DataGridViewComboBoxColumn)dataMaterial.Columns["mtrItemName"];
        //                if (this.GetItemTypes("Material", out List<string> data2))
        //                {
        //                    cmdMaterial.Items.Clear();
        //                    cmdMaterial.Items.AddRange(data2.ToArray());
        //                }
        //                if (this.GetExtraItem())
        //                {
        //                    CalculateAdditionalCost();

        //                }
        //            }
        //            catch (Exception)
        //            {
        //                throw;
        //            }

        //        }
        //        else
        //        {
        //            groupBoq.Enabled = false;
        //            this.Disable(this.dataAdditional, this.checkInflation, this.checkMargin, textInflation, textMargin);
        //            this.Able(textPrice, textCost);
        //            if (this.dataAdditional.Rows.Count > 0)
        //            {
        //                this.dataAdditional.Rows.Clear();
        //            }
        //            dataLabor.Rows.Clear();
        //            dataMachinary.Rows.Clear();
        //            dataMaterial.Rows.Clear();
        //        }
        //    }

        //    #region textbox_keyup_event
        //    private void TextBoxLaborCostKeyUp(object sender, KeyEventArgs e)
        //    {
        //        if (!string.IsNullOrEmpty(((TextBox)sender).Text))
        //        {
        //            var cost = ((TextBox)sender).AsNumber<decimal>();
        //            if (cost < 0)
        //            {
        //                ((TextBox)sender).SetText("1.00000");
        //                cost = 1;
        //            }
        //            var qty = dataLabor.AsNumber<decimal>("Column3");
        //            dataLabor.SetText("Column5", string.Format("{0:0.00000}", (qty * cost)));
        //        }
        //        else
        //        {
        //            dataLabor.SetText("Column5","0.00000");
        //        }
        //        //Calculate total cost
        //        CalculateCost();
        //        //Calculate Additinal cost
        //        CalculateAdditionalCost();
        //        //Calculate Sale Price
        //        CalculateSalePrice();
        //    }
        //    private void TextBoxLaborQauntityKeyUp(object sender, KeyEventArgs e)
        //    {
        //        if (!string.IsNullOrEmpty(((TextBox)sender).Text))
        //        {
        //            var qty = ((TextBox)sender).AsNumber<decimal>();
        //            if (qty < 0)
        //            {
        //                ((TextBox)sender).SetText("1.00");
        //                qty = 1;
        //            }
        //            var cost = dataLabor.AsNumber<decimal>("Column4");
        //            dataLabor.SetText("Column5", String.Format("{0:0.00000}", (qty * cost)));
        //        }
        //        else
        //        {
        //            dataLabor.SetText("Column5","0.00000");
        //        }
        //        //Calculate total cost
        //        CalculateCost();
        //        //Calculate Additinal cost
        //        CalculateAdditionalCost();
        //        //Calculate Sale Price
        //        CalculateSalePrice();
        //        return;
        //    }

        //    private void TextBoxMachinaryCostKeyUp(object sender, KeyEventArgs e)
        //    {

        //        if (!string.IsNullOrEmpty(((TextBox)sender).Text))
        //        {

        //            var cost = ((TextBox)sender).AsNumber<decimal>();
        //            if (cost < 0)
        //            {
        //                ((TextBox)sender).SetText("1.00000");
        //                cost = 1;
        //            }
        //            var qty = dataMachinary.AsNumber<decimal>("mnrQuantity");
        //            dataMachinary.SetText("mnrSubTotal", string.Format("{0:0.00000}", (qty * cost)));
        //        }
        //        else
        //        {
        //            dataMachinary.SetText("mnrSubTotal","0.00000");
        //        }
        //        //Calculate total cost
        //        CalculateCost();
        //        //Calculate Additinal cost
        //        CalculateAdditionalCost();
        //        //Calculate Sale Price
        //        CalculateSalePrice();
        //        return;
        //    }
        //    private void TextBoxMachinaryQuantityKeyUp(object sender, KeyEventArgs e)
        //    {
        //        if (!string.IsNullOrEmpty(((TextBox)sender).Text))
        //        {

        //            var qty = ((TextBox)sender).AsNumber<decimal>();
        //            if (qty < 0)
        //            {
        //                ((TextBox)sender).SetText("1.00");
        //                qty = 1;
        //            }
        //            var cost = dataMachinary.AsNumber<decimal>("mnrCost");
        //            dataMachinary.SetText("mnrSubTotal", string.Format("{0:0.00000}", (qty * cost)));
        //        }
        //        else
        //        {
        //            dataMachinary.SetText("mnrSubTotal", "0.00000");
        //        }
        //        //Calculate total cost
        //        CalculateCost();
        //        //Calculate Additinal cost
        //        CalculateAdditionalCost();
        //        //Calculate Sale Price
        //        CalculateSalePrice();
        //        return;
        //    }
        //    private void TextBoxMaterialQuantityKeyUp(object sender, KeyEventArgs e)
        //    {
        //        if (!string.IsNullOrEmpty(((TextBox)sender).Text))
        //        {
        //            var qty = ((TextBox)sender).AsNumber<decimal>();
        //            if (qty < 0)
        //            {
        //                ((TextBox)sender).SetText("1.00");
        //                qty = 1;
        //            }
        //            var cost = dataMaterial.AsNumber<decimal>("mtrQuantity");
        //            dataMaterial.SetText("mtrSubTotal", string.Format("{0:0.00000}", (qty * cost)));
        //        }
        //        else
        //        {
        //            dataMaterial.SetText("mtrSubTotal", "0.00000");
        //        }
        //        //Calculate total cost
        //        CalculateCost();
        //        //Calculate Additinal cost
        //        CalculateAdditionalCost();
        //        //Calculate Sale Price
        //        CalculateSalePrice();
        //        return;
        //    }
        //    private void TextBoxMaterialCostKeyUp(object sender, KeyEventArgs e)
        //    {
        //        if (!string.IsNullOrEmpty(((TextBox)sender).Text))
        //        {
        //            var cost = ((TextBox)sender).AsNumber<decimal>();
        //            if (cost < 0)
        //            {
        //                ((TextBox)sender).SetText(Utility.NumberString(1));
        //                cost = 1;
        //            }
        //            var qty = dataMaterial.AsNumber<decimal>("mtrQuantity");
        //            dataMaterial.SetText("mtrSubTotal",Utility.NumberString(qty * cost));
        //        }
        //        else
        //        {
        //            dataMaterial.SetText("mtrSubTotal",Utility.NumberString(0));
        //        }
        //        //Calculate total cost
        //        CalculateCost();
        //        //Calculate Additinal cost
        //        CalculateAdditionalCost();
        //        //Calculate Sale Price
        //        CalculateSalePrice();
        //        return;
        //    }
        //    private void TextBoxAdditionalCostKeyUp(object sender, KeyEventArgs e)
        //    {

        //        if (!string.IsNullOrEmpty(((TextBox)sender).Text)) {

        //            var rate = ((TextBox)sender).AsNumber<decimal>();
        //            var cost = textCost.AsNumber<decimal>();
        //            if (rate < 0)
        //            {
        //                ((TextBox)sender).SetText("1.00");
        //                rate = 1;
        //            }
        //            if (rate > 100)
        //            {
        //                ((TextBox)sender).SetText("1.00");
        //                rate = 1;
        //            }
        //            var additionalCost = string.Format("{0:0.00000}", (cost * (rate / 100)));
        //            dataAdditional.SetText("addAmount", additionalCost);
        //        }
        //        else
        //        {
        //            dataAdditional.SetText("addAmount","0.00000");
        //        }
        //        CalculateSalePrice();
        //        return;
        //    }

        //    #endregion
        //    //Key Press event
        //    private void TextBoxKeyPress(object sender, KeyPressEventArgs e)
        //    {
        //        if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
        //        {
        //            e.Handled = true;
        //        }
        //        if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
        //        {
        //            e.Handled = true;
        //        }
        //    }
        //    private void materialButton1_Click(object sender, EventArgs e)
        //    {
        //        if (this.IsValid(textName, textDescription, cmbType, cmbUom))
        //        {
        //            var data = this.AsObjectOnly(textName, textCost, chkIsInActive, textPrice, cmbType, cmbUom, textDescription);

        //            if (cmbType.Text == "Bill Of Quantity")
        //            {
        //                if (ItemController.ItemExist(textName.Text.Trim()))
        //                {
        //                    MessageBox.Show("Item Already exist", "Informaton", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //                    return;
        //                }
        //                else
        //                {
        //                    this.CreateNewItemBoqLine(data);
        //                    this.ClearForm(textName, textDescription,
        //                        textTotalInlfation, textTotalMargin,
        //                        textCost, textPrice, textMargin, textInflation);
        //                    dataAdditional.Rows.Clear();
        //                    dataLabor.Rows.Clear();
        //                    dataMachinary.Rows.Clear();
        //                    dataMaterial.Rows.Clear();
        //                }
        //            }
        //            else
        //            {
        //                if (ItemController.ItemExist(textName.Text.Trim()))
        //                {
        //                    MessageBox.Show("Item Already exist", "Informaton", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //                    return;
        //                }
        //                this.CreateNewItem(data);
        //                this.ClearForm(textName, textDescription, textCost, textPrice);
        //            }

        //        }
        //        else
        //        {
        //            lblName.ErrorMessage(textName.Name, "please enter Text Name field");
        //            lblDescription.ErrorMessage(textDescription.Name);
        //        }
        //    }

        //    //Labor Datagridview Events

        //    #region Labor 
        //    private void dataLaborCellEndEdit(object sender, DataGridViewCellEventArgs e)
        //    {
        //        if (dataLabor.Columns[e.ColumnIndex].Name == "Column3")
        //        {
        //            if (string.IsNullOrEmpty(dataLabor.GetValue<string>(e.RowIndex, "Column3")))
        //            {
        //                dataLabor.SetText(e.RowIndex, "Column3", "0.00");
        //            }
        //            else
        //            {
        //                var qty = dataLabor.GetValue<decimal>(e.RowIndex, "Column3");
        //                dataLabor.SetText(e.RowIndex, "Column3",qty.ToString("0.00") );
        //            }
        //        }
        //        if (dataLabor.Columns[e.ColumnIndex].Name == "Column4")
        //        {
        //            if (string.IsNullOrEmpty(dataLabor.GetValue<string>(e.RowIndex, "Column4")))
        //            {
        //                dataLabor.SetText(e.RowIndex, "Column4", "0.0000");
        //            }
        //            else
        //            {
        //                var cost = dataLabor.GetValue<decimal>(e.RowIndex,"Column4");
        //                dataLabor.SetText(e.RowIndex, "Column4", cost.ToString("0.00000"));
        //            }
        //        }
        //        CalculateCost();
        //        //Calculate Additinal cost
        //        CalculateAdditionalCost();
        //        //calculate sale price
        //        CalculateSalePrice();
        //    }
        //    private void dataLaborCellValueChanged(object sender, DataGridViewCellEventArgs e)
        //    {
        //        if (dataLabor.Rows.Count == 1) return;
        //        if (e.ColumnIndex == 0)
        //        {
        //            bool found = false;
        //            var gRow = dataLabor.CurrentRow;
        //            for (int i = 0; i < dataLabor.Rows.Count - 2; i++)
        //            {
        //                if (dataLabor.Rows[i].IsNewRow) continue;
        //                if (dataLabor.Rows[i].Cells["Column1"].Value.Equals(dataFound))
        //                {
        //                    found = true;
        //                    break;
        //                }
        //            }
        //            if (found)
        //            {
        //                dataLabor.Rows.Remove(gRow);
        //                dataFound = string.Empty;
        //            }

        //            return;
        //        }

        //    }
        //    private void dataLaborEditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        //    {
        //        if (dataLabor.CurrentCell.ColumnIndex == 0 && dataLabor.Columns["Column1"] is DataGridViewComboBoxColumn)
        //        {
        //            ComboBox cmb = e.Control as ComboBox;
        //            cmb.DropDownStyle = ComboBoxStyle.DropDown;
        //            cmb.AutoCompleteMode = AutoCompleteMode.Suggest;
        //            //unregister event
        //            cmb.SelectedIndexChanged -= cmbSelectedIndexChanged;
        //            //resgister event
        //            cmb.SelectedIndexChanged += cmbSelectedIndexChanged;
        //            cmb.KeyDown += cmbKeyDown;

        //        }

        //        if (dataLabor.CurrentCell.ColumnIndex == 2 && dataLabor.Columns["Column3"] is DataGridViewTextBoxColumn)
        //        {
        //            var gRow = dataLabor.CurrentRow;
        //            if (gRow.GetValue("Column1") == null)
        //            {
        //                gRow.Cells["Column3"].ReadOnly = true;
        //            }
        //            else
        //            {
        //                gRow.Cells["Column3"].ReadOnly = false;
        //                TextBox textBox = e.Control as TextBox;
        //                if (textBox != null)
        //                {
        //                    textBox.KeyPress -= TextBoxKeyPress;
        //                    textBox.KeyUp -= TextBoxLaborQauntityKeyUp;

        //                    //===============
        //                    textBox.KeyPress += TextBoxKeyPress;
        //                    textBox.KeyUp += TextBoxLaborQauntityKeyUp;

        //                }
        //            }
        //        }
        //        if (dataLabor.CurrentCell.ColumnIndex == 4 && dataLabor.Columns["Column4"] is DataGridViewTextBoxColumn)
        //        {

        //            TextBox textBox = e.Control as TextBox;
        //            if (textBox != null)
        //            {
        //                textBox.KeyPress -= TextBoxKeyPress; ;
        //                textBox.KeyUp -= TextBoxLaborCostKeyUp;

        //                //=====================
        //                textBox.KeyPress += TextBoxKeyPress; ;
        //                textBox.KeyUp += TextBoxLaborCostKeyUp;

        //            }
        //        }
        //    }
        //    private void cmbKeyDown(object sender, KeyEventArgs e)
        //    {
        //        if (e.KeyCode == Keys.Enter)
        //        {
        //            //Calculate total cost
        //            CalculateCost();
        //            //Calculate Additinal cost
        //            CalculateAdditionalCost();
        //            //calculate sale price
        //            CalculateSalePrice();

        //            return;
        //        }
        //    }
        //    private void cmbSelectedIndexChanged(object sender, EventArgs e)
        //    {
        //        bool found = false;
        //        var gRow = dataLabor.CurrentRow;
        //        dataFound = string.IsNullOrEmpty(((ComboBox)sender).Text.Trim()) ? "" : ((ComboBox)sender).Text.Trim();
        //        for (int i = 0; i < dataLabor.Rows.Count; i++)
        //        {
        //            if (dataLabor.Rows[i].IsNewRow || dataLabor.Rows[i].Cells["Column1"].Value == null) continue;
        //            if (dataLabor.Rows[i].Cells["Column1"].Value.Equals(dataFound))
        //            {
        //                found = true;
        //                break;
        //            }
        //        }
        //        if (!found)
        //        {
        //            if (this.GetItemTypeByName(dataFound, out DataRow row))
        //            {
        //                gRow.SetValue("laborBOQItemLineQty", "1.00");
        //                row.SetValue("ItemID", gRow.Cells["laborBOQItemLineRefID"]);
        //                row.SetValue("Cost", gRow.Cells["Column4"]);
        //                row.SetValue("UomID", gRow.Cells["laborUomRefID"]);
        //                row.SetValue("Abbreviation", gRow.Cells["Column2"]);
        //                //add sub total
        //                var qty = dataLabor.AsNumber<decimal>("laborBOQItemLineQty");
        //                var cost = dataLabor.AsNumber<decimal>("Column4");
        //                gRow.SetValue("Column5",Utility.NumberString(qty * cost));
        //                dataFound = string.Empty;
        //            }
        //        }

        //        return;
        //    }
        //    private void dataLaborCellContentClick(object sender, DataGridViewCellEventArgs e)
        //    {
        //        if (e.ColumnIndex == 6)
        //        {
        //            if (!dataLabor.Rows[e.RowIndex].IsNewRow)
        //            {
        //                dataLabor.Rows.RemoveAt(e.RowIndex);
        //                //Calculate total cost
        //                CalculateCost();
        //                //Calculate Additinal cost
        //                CalculateAdditionalCost();
        //                //calculate sale price
        //                CalculateSalePrice();
        //            }

        //        }
        //    }
        //    private void dataLaborCellEnter(object sender, DataGridViewCellEventArgs e)
        //    {
        //        if (dataLabor.Rows[e.RowIndex].IsNewRow)
        //        {
        //            if ((dataLabor.Columns[e.ColumnIndex] is DataGridViewComboBoxColumn)
        //                && (dataLabor.Columns[e.ColumnIndex].Name == "Column1"))
        //            {
        //                dataLabor.BeginEdit(true); ;
        //                ((ComboBox)dataLabor.EditingControl).DropDownStyle = ComboBoxStyle.DropDown;
        //                ((ComboBox)dataLabor.EditingControl).DroppedDown = true;
        //            }
        //        }
        //    }
        //    private void dataLabor_CellLeave(object sender, DataGridViewCellEventArgs e)
        //    {
        //        if ((dataLabor.Columns[e.ColumnIndex] is DataGridViewComboBoxColumn)
        //            && (dataLabor.Columns[e.ColumnIndex].Name == "Column1"))
        //        {
        //            dataLabor.BeginEdit(true); ;
        //            ((ComboBox)dataLabor.EditingControl).DropDownStyle = ComboBoxStyle.Simple;
        //            ((ComboBox)dataLabor.EditingControl).DroppedDown = false;
        //        }

        //    }
        //    private void dataLaborDataError(object sender, DataGridViewDataErrorEventArgs e)
        //    {
        //        if (e.ThrowException)
        //        {

        //            e.ThrowException = false;
        //        }
        //    }
        //    #endregion
        //    //Machinary Datagridview Events
        //    #region Machinary
        //    private void dataMachinaryCellEnter(object sender, DataGridViewCellEventArgs e)
        //    {
        //        if (dataMachinary.Rows[e.RowIndex].IsNewRow)
        //        {
        //            if ((dataMachinary.Columns[e.ColumnIndex] is DataGridViewComboBoxColumn)
        //                && (dataMachinary.Columns[e.ColumnIndex].Name == "mnrItemName"))
        //            {
        //                dataMachinary.BeginEdit(true); ;
        //                ((ComboBox)dataMachinary.EditingControl).DropDownStyle = ComboBoxStyle.DropDown;
        //                ((ComboBox)dataMachinary.EditingControl).DroppedDown = true;
        //            }
        //        }
        //    }
        //    private void dataMachinaryDataError(object sender, DataGridViewDataErrorEventArgs e)
        //    {
        //        if (e.ThrowException)
        //        {
        //            e.ThrowException = false;
        //        }
        //    }
        //    private void dataMachinaryCellValueChanged(object sender, DataGridViewCellEventArgs e)
        //    {
        //        if (dataMachinary.Rows.Count == 0) return;
        //        if (e.ColumnIndex == 0)
        //        {
        //            bool found = false;
        //            var gRow = dataMachinary.CurrentRow;
        //            for (int i = 0; i < dataMachinary.Rows.Count - 2; i++)
        //            {
        //                if (dataMachinary.Rows[i].IsNewRow) continue;
        //                if (dataMachinary.Rows[i].Cells["mnrItemName"].Value.Equals(dataFound))
        //                {
        //                    found = true;
        //                    break;
        //                }
        //            }
        //            if (found)
        //            {
        //                dataMachinary.Rows.Remove(gRow);
        //                dataFound = string.Empty;
        //            }
        //        }
        //        //Calculate total cost
        //        CalculateCost();
        //        //Calculate Additinal cost
        //        CalculateAdditionalCost();
        //        //calculate sale price
        //        CalculateSalePrice();
        //        return;
        //    }
        //    private void dataMachinaryEditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        //    {
        //        if (dataMachinary.CurrentCell.ColumnIndex == 0 && dataMachinary.Columns["mnrItemName"] is DataGridViewComboBoxColumn)
        //        {
        //            ComboBox cmbMachinary = e.Control as ComboBox;
        //            cmbMachinary.AutoCompleteMode = AutoCompleteMode.Suggest;
        //            //unregister event
        //            cmbMachinary.SelectedValueChanged -= CmbMachinarySelectedValueChanged;
        //            //register event
        //            cmbMachinary.SelectedValueChanged += CmbMachinarySelectedValueChanged;
        //        }

        //        if (dataMachinary.CurrentCell.ColumnIndex == 2 && dataMachinary.Columns["mnrQuantity"] is DataGridViewTextBoxColumn)
        //        {
        //            var gRow = dataMachinary.CurrentRow;
        //            if (gRow.GetValue("mnrItemName") == null)
        //            {
        //                gRow.Cells["mnrQuantity"].ReadOnly = true;
        //            }
        //            else
        //            {
        //                gRow.Cells["mnrQuantity"].ReadOnly = false;
        //                TextBox textBox = e.Control as TextBox;
        //                if (textBox != null)
        //                {
        //                    textBox.KeyPress += TextBoxKeyPress;
        //                    textBox.KeyUp += TextBoxMachinaryQuantityKeyUp;
        //                }
        //            }

        //        }
        //        if (dataMachinary.CurrentCell.ColumnIndex == 4 && dataMachinary.Columns["mnrCost"] is DataGridViewTextBoxColumn)
        //        {

        //            TextBox textBox = e.Control as TextBox;
        //            if (textBox != null)
        //            {
        //                textBox.KeyPress += TextBoxKeyPress;
        //                textBox.KeyUp += TextBoxMachinaryCostKeyUp;
        //            }
        //        }
        //    }
        //    private void CmbMachinarySelectedValueChanged(object sender, EventArgs e)
        //    {
        //        if (dataMachinary.Rows.Count == 0) return;
        //        bool found = false;
        //        var gRow = dataMachinary.CurrentRow;
        //        dataFound = ((ComboBox)sender).Text;
        //        for (int i = 0; i < dataMachinary.Rows.Count; i++)
        //        {
        //            if (dataMachinary.Rows[i].IsNewRow || dataMachinary.Rows[i].Cells["mnrItemName"].Value==null) continue;
        //            if (dataMachinary.Rows[i].Cells["mnrItemName"].Value.Equals(dataFound))
        //            {
        //                found = true;
        //                break;
        //            }
        //        }
        //        if (!found)
        //        {
        //            if (this.GetItemTypeByName(dataFound, out DataRow row))
        //            {
        //                gRow.SetValue("mnrQuantity", "1.00");
        //                row.SetValue("ItemID", gRow.Cells["mnrItemId"]);
        //                row.SetValue("Cost", gRow.Cells["mnrCost"]);
        //                row.SetValue("UomID", gRow.Cells["mnrUomRefID"]);
        //                row.SetValue("Abbreviation", gRow.Cells["mnrUom"]);
        //                var qty = dataMachinary.AsNumber<decimal>("mnrQuantity");
        //                var cost = dataMachinary.AsNumber<decimal>("mnrCost");
        //                gRow.SetValue("mnrSubTotal", (qty * cost).ToString("0.00000"));
        //            }

        //        }

        //        return;
        //    }
        //    private void dataMachinary_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //    {
        //        if (e.ColumnIndex == 6)
        //        {
        //            if (!dataMachinary.Rows[e.RowIndex].IsNewRow)
        //            {
        //                dataMachinary.Rows.RemoveAt(e.RowIndex);
        //                //Calculate total cost
        //                CalculateCost();
        //                //Calculate Additinal cost
        //                CalculateAdditionalCost();
        //                //calculate sale price
        //                CalculateSalePrice();
        //                return;
        //            }

        //        }
        //    }
        //    #endregion
        //    //Material Datagridview Events

        //    #region Material
        //    private void dataMaterialCellEnter(object sender, DataGridViewCellEventArgs e)
        //    {
        //        if (dataMaterial.Rows[e.RowIndex].IsNewRow)
        //        {
        //            if ((dataMaterial.Columns[e.ColumnIndex] is DataGridViewComboBoxColumn)
        //                && (dataMaterial.Columns[e.ColumnIndex].Name == "mtrItemName"))
        //            {
        //                dataMaterial.BeginEdit(true); ;
        //                ((ComboBox)dataMaterial.EditingControl).DropDownStyle = ComboBoxStyle.DropDown;
        //                ((ComboBox)dataMaterial.EditingControl).DroppedDown = true;
        //            }
        //            if ((dataMaterial.Columns[e.ColumnIndex] is DataGridViewTextBoxColumn))
        //            {
        //                dataMaterial.BeginEdit(true);
        //                ((DataGridViewTextBoxCell)dataMaterial.Rows[e.RowIndex].Cells[e.ColumnIndex]).ReadOnly = true;
        //            }
        //        }
        //        else
        //        {

        //            if ((dataMaterial.Columns[e.ColumnIndex] is DataGridViewTextBoxColumn)
        //                && (dataMaterial.Columns[e.ColumnIndex].Name == "mtrQuantity"))
        //            {
        //                dataMaterial.BeginEdit(true);

        //            }
        //            if ((dataMaterial.Columns[e.ColumnIndex] is DataGridViewTextBoxColumn)
        //                && (dataMaterial.Columns[e.ColumnIndex].Name == "mtrCost"))
        //            {

        //                dataMaterial.BeginEdit(true);
        //            }
        //        }
        //    }
        //    private void dataMaterialDataError(object sender, DataGridViewDataErrorEventArgs e)
        //    {
        //        if (e.ThrowException)
        //        {
        //            e.ThrowException = false;
        //        }
        //    }
        //    private void dataMaterialCellValueChanged(object sender, DataGridViewCellEventArgs e)
        //    {
        //        if (dataMaterial.Rows.Count == 1) return;
        //        if (e.ColumnIndex == 0)
        //        {
        //            int currentRow = 0;
        //            bool found = false;
        //            var gRow = dataMaterial.CurrentRow;
        //            for (int i = 0; i < dataMaterial.Rows.Count - 2; i++)
        //            {
        //                if (dataMaterial.Rows[i].IsNewRow) continue;
        //                if (dataMaterial.Rows[i].Cells["mtrItemName"].Value.Equals(dataFound))
        //                {
        //                    currentRow = i;
        //                    found = true;
        //                    break;
        //                }
        //            }
        //            if (found)
        //            {

        //                dataMaterial.Rows.Remove(gRow);
        //                dataFound = string.Empty;
        //            }
        //        }
        //        //Calculate total cost
        //        CalculateCost();
        //        //Calculate Additinal cost
        //        CalculateAdditionalCost();
        //        //calculate sale price
        //        CalculateSalePrice();
        //        return;
        //    }
        //    private void dataMaterialEditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        //    {
        //        if (dataMaterial.Columns[dataMaterial.CurrentCell.ColumnIndex].Name == "mtrItemName"
        //            && dataMaterial.Columns["mtrItemName"] is DataGridViewComboBoxColumn)
        //        {
        //            ComboBox cmbMaterial = e.Control as ComboBox;
        //            cmbMaterial.DropDownStyle = ComboBoxStyle.DropDown;
        //            cmbMaterial.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        //            //unregister event
        //            cmbMaterial.SelectedValueChanged -= CmbMaterialSelectedValueChanged;
        //            //register event

        //            cmbMaterial.SelectedValueChanged += CmbMaterialSelectedValueChanged;

        //        }
        //        if (dataMaterial.Columns[dataMaterial.CurrentCell.ColumnIndex].Name == "mtrCost"
        //            && dataMaterial.Columns["mtrCost"] is DataGridViewTextBoxColumn)
        //        {
        //            TextBox textBox = e.Control as TextBox;
        //            if (textBox != null)
        //            {
        //                textBox.KeyPress += TextBoxKeyPress;
        //                textBox.KeyUp += TextBoxMaterialCostKeyUp;
        //            }
        //        }
        //        if (dataMaterial.Columns[dataMaterial.CurrentCell.ColumnIndex].Name == "mtrQuantity"
        //            && dataMaterial.Columns["mtrQuantity"] is DataGridViewTextBoxColumn)
        //        {
        //            TextBox textBox = e.Control as TextBox;
        //            if (textBox != null)
        //            {
        //                textBox.KeyPress += TextBoxKeyPress;
        //                textBox.KeyUp += TextBoxMaterialQuantityKeyUp;
        //            }
        //        }
        //    }
        //    private void CmbMaterialSelectedValueChanged(object sender, EventArgs e)
        //    {
        //        if (dataMaterial.Rows.Count == 0) return;
        //        bool found = false;
        //        var gRow = dataMaterial.CurrentRow;
        //        dataFound = ((ComboBox)sender).Text;
        //        for (int i = 0; i < dataMaterial.Rows.Count; i++)
        //        {
        //            if (dataMaterial.Rows[i].IsNewRow || dataMaterial.Rows[i].Cells["mtrItemName"].Value==null) continue;
        //            if (dataMaterial.Rows[i].Cells["mtrItemName"].Value.Equals(dataFound))
        //            {
        //                found = true;
        //                break;
        //            }
        //        }
        //        if (!found)
        //        {
        //            if (this.GetItemTypeByName(dataFound, out DataRow row))
        //            {
        //                gRow.SetValue("mtrQuantity", "1.00");
        //                row.SetValue("ItemID", gRow.Cells["mtrItemRefID"]);
        //                row.SetValue("Cost", gRow.Cells["mtrCost"]);
        //                row.SetValue("UomID", gRow.Cells["mtrUomRefID"]);
        //                row.SetValue("Abbreviation", gRow.Cells["mtrUom"]);
        //                var qty = dataMaterial.AsNumber<decimal>("mtrQuantity");
        //                var cost = dataMaterial.AsNumber<decimal>("mtrCost");
        //                gRow.SetValue("mtrSubTotal", (qty * cost).ToString("0.00000"));
        //            }

        //        }

        //        return;
        //    }

        //    private void dataMaterial_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //    {
        //        if (dataMaterial.Columns[e.ColumnIndex].Name== "Column8")
        //        {
        //            if (!dataMaterial.Rows[e.RowIndex].IsNewRow)
        //            {
        //                dataMaterial.Rows.RemoveAt(e.RowIndex);
        //                //Calculate total cost
        //                CalculateCost();
        //                //Calculate Additinal cost
        //                CalculateAdditionalCost();
        //                //calculate sale price
        //                CalculateSalePrice();
        //                return;
        //            }

        //        }
        //    }
        //    #endregion
        //    #region Additinal Cost
        //    private void dataAdditionalCellEndEdit(object sender, DataGridViewCellEventArgs e)
        //    {
        //        if (dataAdditional.Columns[e.ColumnIndex].Name == "Rate")
        //        {
        //            if (string.IsNullOrEmpty(dataAdditional.GetValue<string>(e.RowIndex, "Rate")))
        //            {
        //                dataAdditional.SetText(e.RowIndex, "Rate",Utility.NumberString(0,"N3"));
        //            }
        //            else
        //            {
        //                var rate = dataAdditional.GetValue<decimal>(e.RowIndex, "Rate");
        //                dataAdditional.SetText(e.RowIndex, "Rate",Utility.NumberString(rate,"N3"));
        //            }
        //        }
        //        if (dataAdditional.Columns[e.ColumnIndex].Name == "addAmount")
        //        {
        //            if (string.IsNullOrEmpty(dataAdditional.GetValue<string>(e.RowIndex, "addAmount")))
        //            {
        //                dataAdditional.SetText(e.RowIndex, "addAmount",Utility.NumberString(0));
        //            }
        //            else
        //            {
        //                var cost = dataAdditional.GetValue<decimal>(e.RowIndex, "addAmount");
        //                dataAdditional.SetText(e.RowIndex, "addAmount", Utility.NumberString(cost));
        //            }

        //        }
        //    }
        //    private void dataAdditionalEditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        //    {

        //        if (dataAdditional.Columns[dataAdditional.CurrentCell.ColumnIndex].Name == "Rate"
        //            &&
        //            dataAdditional.Columns["Rate"] is DataGridViewTextBoxColumn)
        //        {
        //            TextBox textBox = e.Control as TextBox;
        //            if (textBox != null)
        //            {
        //                //unregister events
        //                textBox.KeyPress -= TextBoxKeyPress;
        //                textBox.KeyUp -= TextBoxAdditionalCostKeyUp;

        //                //regsiter event
        //                textBox.KeyPress += TextBoxKeyPress;
        //                textBox.KeyUp += TextBoxAdditionalCostKeyUp;

        //            }
        //        }
        //    }

        //    #endregion
        //    private void checkMargin_CheckedChanged(object sender, EventArgs e)
        //    {
        //        if (checkMargin.Checked)
        //        {
        //            textMargin.Enabled = true;
        //        }
        //        else
        //        {
        //            textMargin.Enabled = false;
        //            textMargin.SetText(0);
        //            textTotalMargin.SetText(0);
        //        }
        //        CalculateSalePrice();
        //    }

        //    private void checkInflation_CheckedChanged(object sender, EventArgs e)
        //    {
        //        if (checkInflation.Checked)
        //        {
        //            textInflation.Enabled = true;
        //        }
        //        else
        //        {
        //            textInflation.Enabled = false;
        //            textInflation.SetText(0);
        //            textTotalInlfation.SetText(0);
        //        }
        //        CalculateSalePrice();
        //    }

        //    private void textMargin_KeyUp(object sender, KeyEventArgs e)
        //    {
        //        var margin = ((TextBox)sender).AsNumber<decimal>();
        //        if (margin > 100)
        //        {
        //            MessageBox.Show("Margin value cannot exeed 100.");
        //            ((TextBox)sender).Focus();
        //            ((TextBox)sender).SelectAll();
        //            CalculateMargin();
        //        }
        //        else
        //        {
        //            CalculateMargin(margin);

        //        }
        //        CalculateSalePrice();
        //    }
        //    private void textInflation_KeyUp(object sender, KeyEventArgs e)
        //    {
        //        var inflation = ((TextBox)sender).AsNumber<decimal>();
        //        if (inflation > 100)
        //        {
        //            ((TextBox)sender).SetText(0);
        //            CalculateInflation();
        //        }
        //        else
        //        {
        //            CalculateInflation(inflation);
        //        }
        //        CalculateSalePrice();
        //    }
        //    private void CalculateMarginAndInflation()
        //    {
        //        //calculate margin and inflation
        //        if (checkMargin.Checked)
        //        {
        //            var margin = textMargin.AsNumber<decimal>();
        //            CalculateMargin(margin);
        //        }
        //        else
        //        {
        //            textTotalMargin.SetText(0);
        //            CalculateMargin();
        //        }
        //        if (checkInflation.Checked)
        //        {
        //            var inflation = textInflation.AsNumber<decimal>();
        //            CalculateInflation(inflation);
        //        }
        //        else
        //        {
        //            textTotalInlfation.SetText(0);
        //            CalculateInflation();
        //        }
        //    }
        //    private void CalculateCost()
        //    {
        //        decimal subtotal = 0;
        //        //if (dataLabor.Rows.Count ==0) return;
        //        foreach (DataGridViewRow item in dataLabor.Rows)
        //        {
        //            if (item.IsNewRow) break;
        //            subtotal += item.GetValue<decimal>("Column5");

        //        }
        //        foreach (DataGridViewRow item in dataMachinary.Rows)
        //        {
        //            if (item.IsNewRow) break;
        //            subtotal += item.GetValue<decimal>("mnrSubTotal");

        //        }
        //        foreach (DataGridViewRow item in dataMaterial.Rows)
        //        {
        //            if (item.IsNewRow) break;
        //            subtotal += item.GetValue<decimal>("mtrSubTotal");

        //        }
        //        textCost.Text =Utility.NumberString(subtotal);
        //    }
        //    private void CalculateAdditionalCost()
        //    {

        //        foreach (DataGridViewRow iRow in dataAdditional.Rows)
        //        {
        //            if (iRow.IsNewRow) break;
        //            var amount = (textCost.AsNumber<decimal>() * (iRow.GetValue<decimal>("Rate") / 100));
        //            iRow.SetValue("addAmount", string.Format("{0:0.00000}", amount));
        //        }
        //        CalculateTotalAdditionalCost();
        //    }
        //    private void CalculateTotalAdditionalCost()
        //    {
        //        var totalAdditionalCost = 0M;
        //        foreach (DataGridViewRow iRow in dataAdditional.Rows)
        //        {
        //            if (iRow.IsNewRow) break;
        //            totalAdditionalCost += iRow.GetValue<decimal>("addAmount");
        //        }
        //        textAdditionalCost.SetText(Utility.NumberString(totalAdditionalCost));
        //    }
        //    private void CalculateSalePrice()
        //    {

        //        //CalculateAdditionalCost();
        //        CalculateTotalAdditionalCost();
        //        //calculate margin and inflation
        //        CalculateMarginAndInflation();
        //        var cost = textCost.AsNumber<decimal>();
        //        var margin = textTotalMargin.AsNumber<decimal>();
        //        var inflation = textTotalInlfation.AsNumber<decimal>();
        //        var totalAdditionalCost = textAdditionalCost.AsNumber<decimal>();
        //        var salePrice = margin + inflation + totalAdditionalCost + cost;
        //        textPrice.SetText( Utility.NumberString(salePrice));
        //    }

        //    private void CalculateInflation(decimal inflationRate = 0)
        //    {
        //        var inflationTotal = ((inflationRate / 100) * (textCost.AsNumber<decimal>() + textAdditionalCost.AsNumber<decimal>()));
        //        textTotalInlfation.SetText(Utility.NumberString(inflationTotal));
        //    }

        //    private void CalculateMargin(decimal marginRate = 0)
        //    {
        //        var marginTotal = ((marginRate / 100) * (textCost.AsNumber<decimal>() + textAdditionalCost.AsNumber<decimal>()));
        //        textTotalMargin.SetText(Utility.NumberString(marginTotal));
        //    }

        //    private void textCostKeyUp(object sender, KeyEventArgs e)
        //    {
        //        if (!string.IsNullOrEmpty(((TextBox)sender).Text)) {
        //            textPrice.SetText(Utility.NumberString(textCost.Text));
        //        }
        //    }

        //    private void textCost_Leave(object sender, EventArgs e)
        //    {
        //        if (string.IsNullOrEmpty(((TextBox)sender).Text))
        //        {
        //            textCost.SetText(Utility.NumberString(0));
        //        }
        //        else
        //        {
        //            var cost=((TextBox)sender).AsNumber<decimal>();
        //            ((TextBox)sender).SetText(Utility.NumberString(cost));
        //            var price = textPrice.AsNumber<decimal>();
        //            textPrice.SetText(Utility.NumberString(price));
        //        }
        //    }

        //    private void dataMachinaryCellEndEdit(object sender, DataGridViewCellEventArgs e)
        //    {
        //        if (dataMachinary.Columns[e.ColumnIndex].Name == "mnrQuantity")
        //        {
        //            if (string.IsNullOrEmpty(dataMachinary.GetValue<string>(e.RowIndex, "mnrQuantity")))
        //            {
        //                dataMachinary.SetText(e.RowIndex, "mnrQuantity", "0.00");
        //            }
        //            else
        //            {
        //                var qty = dataMachinary.GetValue<decimal>(e.RowIndex, "mnrQuantity");
        //                dataMachinary.SetText(e.RowIndex, "mnrQuantity", qty.ToString("0.00"));
        //            }
        //        }
        //        if (dataMachinary.Columns[e.ColumnIndex].Name == "mnrCost")
        //        {
        //            if (string.IsNullOrEmpty(dataMachinary.GetValue<string>(e.RowIndex, "mnrCost")))
        //            {
        //                dataMachinary.SetText(e.RowIndex, "mnrCost", "0.00000");
        //            }
        //            else
        //            {
        //                var cost = dataMachinary.GetValue<decimal>(e.RowIndex, "mnrCost");
        //                dataMachinary.SetText(e.RowIndex, "mnrCost", cost.ToString("0.00000"));
        //            }
        //        }
        //        CalculateCost();
        //        //Calculate Additinal cost
        //        CalculateAdditionalCost();
        //        //calculate sale price
        //        CalculateSalePrice();
        //    }

        //    private void dataMaterialCellEndEdit(object sender, DataGridViewCellEventArgs e)
        //    {
        //        if (dataMaterial.Columns[e.ColumnIndex].Name == "mtrQuantity")
        //        {
        //            if (string.IsNullOrEmpty(dataMaterial.GetValue<string>(e.RowIndex, "mtrQuantity")))
        //            {
        //                dataMaterial.SetText(e.RowIndex, "mtrQuantity", "0.00");
        //            }
        //            else
        //            {
        //                var qty = dataMaterial.GetValue<decimal>(e.RowIndex, "mtrQuantity");
        //                dataMaterial.SetText(e.RowIndex, "mtrQuantity", qty.ToString("0.00"));
        //            }
        //        }
        //        if (dataMaterial.Columns[e.ColumnIndex].Name == "mtrCost")
        //        {
        //            if (string.IsNullOrEmpty(dataMaterial.GetValue<string>(e.RowIndex, "mtrCost")))
        //            {
        //                dataMaterial.SetText(e.RowIndex, "mtrCost",Utility.NumberString(0));
        //            }
        //            else
        //            {
        //                var cost = dataMaterial.GetValue<decimal>(e.RowIndex, "mtrCost");
        //                dataMaterial.SetText(e.RowIndex, "mtrCost",Utility.NumberString(cost));
        //            }
        //        }
        //        CalculateCost();
        //        //Calculate Additinal cost
        //        CalculateAdditionalCost();
        //        //calculate sale price
        //        CalculateSalePrice();
        //    }

        //    private void dataAdditional_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        //    {
        //        if (dataAdditional.Rows.Count > 0)
        //        {
        //            if (dataAdditional.Columns[e.ColumnIndex].Name == "Rate")
        //            {
        //                if(e.Value != null)
        //                {
        //                    dataAdditional.Columns[e.ColumnIndex].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        //                    dataAdditional.Columns[e.ColumnIndex].DefaultCellStyle.Format = "N3";
        //                }

        //            }
        //            if (dataAdditional.Columns[e.ColumnIndex].Name == "addAmount")
        //            {
        //                if (e.Value != null)
        //                {
        //                    dataAdditional.Columns[e.ColumnIndex].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        //                    dataAdditional.Columns[e.ColumnIndex].DefaultCellStyle.Format = "N5";
        //                }

        //            }
        //        }
        //    }

        //    private void textMargin_MouseEnter(object sender, EventArgs e)
        //    {
        //        if (textMargin.AsNumber<decimal>() == 0.00M)
        //        {
        //            ((TextBox)sender).Text = "";
        //        }
        //    }
        //    private void textInflation_MouseEnter(object sender, EventArgs e)
        //    {
        //        if (textInflation.AsNumber<decimal>() == 0.00M)
        //        {
        //            ((TextBox)sender).Text = "";
        //        }
        //    }

        //    private void textInflation_MouseLeave(object sender, EventArgs e)
        //    {
        //        if (string.IsNullOrEmpty(((TextBox)sender).Text))
        //        {
        //            ((TextBox)sender).Text = Utility.NumberString(0, "N2");
        //        }
        //        else
        //        {
        //            var inflation = ((TextBox)sender).AsNumber<decimal>();
        //            ((TextBox)sender).Text = Utility.NumberString(inflation, "N2");
        //        }
        //    }

        //    private void textMargin_MouseLeave(object sender, EventArgs e)
        //    {
        //        if (string.IsNullOrEmpty(((TextBox)sender).Text))
        //        {
        //            ((TextBox)sender).Text = Utility.NumberString(0, "N2");
        //        }
        //        else
        //        {
        //            var magrin = ((TextBox)sender).AsNumber<decimal>();
        //            ((TextBox)sender).Text = Utility.NumberString(magrin, "N2");
        //        }
        //    }

        //    private void textName_KeyUp(object sender, KeyEventArgs e)
        //    {
        //        var text=((TextBox)sender).Text.Trim();
        //        if (ItemController.ItemExist(text))
        //        {
        //            MessageBox.Show("Item already exist.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //            ((TextBox)sender).Select(0, ((TextBox)sender).Text.Length);
        //            return;
        //        }
        //    }


    }
}


//if (cmb != null)
//{
//    cmb.SelectionChangeCommitted += (s, evt) =>
//    {
//        var gRow = dataMaterial.CurrentRow;
//        var id = cmb.AsNumber<long>(true);
//        if (this.GetItemTypeById(id, out DataRow row))
//        {
//            //display data to data grid
//            gRow.Cells["mtrQuantity"].Value = 1;
//            gRow.Cells["mtrCost"].Value = row["Cost"];
//            gRow.Cells["mtrUom"].Value = row["Abbreviation"];
//            //add sub total
//            var qty = dataMaterial.AsNumber<decimal>("mtrCost");
//            var cost = dataMaterial.AsNumber<decimal>("mtrQuantity");
//            dataMaterial.SetText("mtrSubTotal", (qty * cost));
//        }
//    };
//}