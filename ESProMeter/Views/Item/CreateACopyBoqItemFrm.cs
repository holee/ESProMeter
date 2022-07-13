using ESProMeter.Controllers;
using ESProMeter.Extensions;
using ESProMeter.Views.UnitOfMeasures;
using System;
using System.Data;
using System.Windows.Forms;
using System.Drawing;

namespace ESProMeter.Views.Items
{
   
    public partial class CreateACopyBoqItemFrm : Form
    {
        int quantity = 0;
        string dataFound = "";
        public CreateACopyBoqItemFrm(long id)
        {
            InitializeComponent();
            this.ShowBoqItems();
            this.ShowUom();
        }

        private void TextInflation_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(((TextBox)sender).Text))
            {
                ((TextBox)sender).SetText(Utility.NumberString(0, "N2"));
            }
            else
            {
                var inflation = ((TextBox)sender).AsNumber<decimal>();
                ((TextBox)sender).Text = Utility.NumberString(inflation, "N2");
            }
        }

        private void TextInflation_GotFocus(object sender, EventArgs e)
        {
            if (((TextBox)sender).AsNumber<decimal>() == 0.00M)
            {
                ((TextBox)sender).SetText("");
            }
            else
            {
                var margin = ((TextBox)sender).AsNumber<decimal>();
                ((TextBox)sender).SetText(Utility.NumberString(margin, "N0"));
                ((TextBox)sender).Select(2, 1);
            }
        }

        private void TextMargin_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(((TextBox)sender).Text))
            {
                ((TextBox)sender).SetText(Utility.NumberString(0, "N2"));
            }
            else
            {
                var magrin = ((TextBox)sender).AsNumber<decimal>();
                ((TextBox)sender).Text = Utility.NumberString(magrin, "N2");
            }
        }

        private void TextMargin_GotFocus(object sender, EventArgs e)
        {
            if (((TextBox)sender).AsNumber<decimal>() == 0.00M)
            {
                ((TextBox)sender).Text = "";
            }
            else
            {
                var margin = ((TextBox)sender).AsNumber<decimal>();
                ((TextBox)sender).SetText(Utility.NumberString(margin, "N0"));
                ((TextBox)sender).Select(2, 1);
            }
            
        }

        private void AddItemFrm_Load(object sender, EventArgs e)
        {
           
        }
        private void btnUomCreate_Click(object sender, EventArgs e)
        {
            Form form = new AddUoMFrm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                this.ShowUom();
            };
        }
        private void materialButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        #region textbox_keyup_event
        private void TextBoxLaborCostKeyUp(object sender, KeyEventArgs e)
        {
            if (!string.IsNullOrEmpty(((TextBox)sender).Text))
            {
                var cost = ((TextBox)sender).AsNumber<double>();
                if (cost < 0)
                {
                    ((TextBox)sender).SetText(Utility.NumberString(1));
                    cost = 1;
                }
                var qty = dataLabor.AsNumber<double>("laborBOQItemLineQty");
                dataLabor.SetText("laborAmount",Utility.NumberString((qty * cost)));
            }
            else
            {
                dataLabor.SetText("laborAmount",Utility.NumberString(0));
            }
            //Calculate total cost
            CalculateCost();
            //Calculate Additinal cost
            CalculateAdditionalCost();
            //Calculate Sale Price
            CalculateSalePrice();
        }
        private void TextBoxLaborQauntityKeyUp(object sender, KeyEventArgs e)
        {
            if (!string.IsNullOrEmpty(((TextBox)sender).Text))
            {
                var qty = ((TextBox)sender).AsNumber<double>();
                if (qty < 0)
                {
                    ((TextBox)sender).SetText("1.000");
                    qty = 1;
                }
                var cost = dataLabor.AsNumber<double>("Column4");
                dataLabor.SetText("laborAmount",Utility.NumberString((cost * qty)));
            }
            else
            {
                dataLabor.SetText("laborAmount",Utility.NumberString(0));
            }
            //Calculate total cost
            CalculateCost();
            //Calculate Additinal cost
            CalculateAdditionalCost();
            //Calculate Sale Price
            CalculateSalePrice();
            return;
        }
      
        private void TextBoxMaterialQuantityKeyUp(object sender, KeyEventArgs e) 
        {
            if (!string.IsNullOrEmpty(((TextBox)sender).Text))
            {
                var qty = ((TextBox)sender).AsNumber<decimal>();
                if (qty < 0)
                {
                    ((TextBox)sender).SetText("1.000");
                    qty = 1;
                }
                var cost = dataMaterial.AsNumber<decimal>("mtrCost");
                dataMaterial.SetText("mtrSubTotal",Utility.NumberString((qty * cost)));
            }
            else
            {
                dataMaterial.SetText("mtrSubTotal","0.00000");
            }
            //Calculate total cost
            CalculateCost();
            //Calculate Additinal cost
            CalculateAdditionalCost();
            //Calculate Sale Price
            CalculateSalePrice();
            return;
        }
        private void TextBoxMaterialCostKeyUp(object sender, KeyEventArgs e)
        {
            if (!string.IsNullOrEmpty(((TextBox)sender).Text))
            {
                var cost = ((TextBox)sender).AsNumber<decimal>();
                if (cost < 0)
                {
                    ((TextBox)sender).SetText("1.000");
                    cost = 1;
                }
                var qty = dataMaterial.AsNumber<decimal>("mtrCost");
                dataMaterial.SetText("mtrSubTotal",Utility.NumberString((qty * cost)));
            }
            else
            {
                dataMaterial.SetText("mtrSubTotal", "0.00000");
            }
            //Calculate total cost
            CalculateCost();
            //Calculate Additinal cost
            CalculateAdditionalCost();
            //Calculate Sale Price
            CalculateSalePrice();
            return;
        }
        private void TextBoxAdditionalCostKeyUp(object sender, KeyEventArgs e)
        {
            if (!string.IsNullOrEmpty(((TextBox)sender).Text))
            {

                var rate = ((TextBox)sender).AsNumber<decimal>();
                var cost = textCost.AsNumber<decimal>();
                if (rate < 0)
                {
                    ((TextBox)sender).SetText("1.000");
                    rate = 1;
                }
                if (rate > 100)
                {
                    ((TextBox)sender).SetText(1);
                    rate = 1;
                }
                var additionalCost = Utility.NumberString(cost * (rate / 100));
                dataAdditional.SetText("addAmount", additionalCost);
            }
            else
            {
                dataAdditional.SetText("addAmount", Utility.NumberString(0));
            }
            CalculateSalePrice();
            return;
        }

        #endregion
        //Key Press event
        private void TextBoxKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        private void materialButton1_Click(object sender, EventArgs e)
        {
            if (ItemController.ItemExist(textName.Text.Trim()))
            {
                MessageBox.Show("Item Already exist", "Informaton", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (this.IsValid(textName, textDescription, cmbType, cmbUom))
            {
                var data = new
                {
                    Name = textName.Text.Trim(),
                    Description = textDescription.Text.Trim(),
                    @Type = cmbType.Text.Trim(),
                    IsActive = chkIsInActive.Checked?false:true,
                    UOMRefID = cmbUom.SelectedValue,
                    Cost = textCost.AsNumber<double>(),
                    Price =textPrice.AsNumber<double>(),
                };
                //this.CreateNewItemBoqLine(data);
                this.ClearForm(textName, textDescription);
                ((DataTable)dataAdditional.DataSource).Rows.Clear() ;
                dataLabor.Rows.Clear();
                dataMachinary.Rows.Clear();
                dataMaterial.Rows.Clear();
                this.DialogResult=DialogResult.OK;
            }
            else
            {
                lblName.ErrorMessage(textName.Name, "please enter Text Name field");
                lblDescription.ErrorMessage(textDescription.Name);
            }
        }

        //Labor Datagridview Events

        #region Labor
        private void dataLabor_CellValueChanged(object sender, DataGridViewCellEventArgs e)
       {
            if (dataLabor.Rows.Count==1) return;
            if (dataLabor.Columns[e.ColumnIndex].Name == "Column1")
            {
                bool found = false;
                var gRow = dataLabor.CurrentRow;
                for (int i = 0; i < dataLabor.Rows.Count-1; i++)
                {
                    if (dataLabor.Rows[i].IsNewRow) continue;
                    if (dataLabor.Rows[i].Cells["Column1"].Value.Equals(dataFound))
                    {
                        found = true;
                        break;
                    }
                }
                if (found)
                {
                    dataLabor.Rows.Remove(gRow);
                    dataFound = "";
                }
                return;
            }
            
        }
        private void dataLabor_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dataLabor.Columns[dataLabor.CurrentCell.ColumnIndex].Name == "Column1" && dataLabor.Columns["Column1"] is DataGridViewComboBoxColumn)
            {
                ComboBox cmb = e.Control as ComboBox;
                cmb.DropDownStyle = ComboBoxStyle.DropDown;
                cmb.AutoCompleteMode = AutoCompleteMode.Suggest;
                if(cmb != null)
                {
                    cmb.SelectedIndexChanged -= Cmb_SelectedIndexChanged;
                    cmb.SelectedIndexChanged += Cmb_SelectedIndexChanged;
                }
            }

            if (dataLabor.Columns[dataLabor.CurrentCell.ColumnIndex].Name == "laborBOQItemLineQty" && dataLabor.Columns["laborBOQItemLineQty"] is DataGridViewTextBoxColumn)
            {
                var gRow = dataLabor.CurrentRow;
                if (gRow.GetValue("Column1") == null)
                {
                    gRow.Cells["laborBOQItemLineQty"].ReadOnly = true;
                }
                else
                {
                    gRow.Cells["laborBOQItemLineQty"].ReadOnly = false;
                    TextBox textBox = e.Control as TextBox;
                    if (textBox != null)
                    {
                        textBox.KeyPress -= TextBoxKeyPress;
                        textBox.KeyUp -= TextBoxLaborQauntityKeyUp;

                        textBox.KeyPress += TextBoxKeyPress ;
                        textBox.KeyUp += TextBoxLaborQauntityKeyUp;
                    }
                }
            }
            if (dataLabor.Columns[dataLabor.CurrentCell.ColumnIndex].Name == "Column4" && dataLabor.Columns["Column4"] is DataGridViewTextBoxColumn)
            {

                TextBox textBox = e.Control as TextBox;
                if (textBox != null)
                {
                    textBox.KeyPress -= TextBoxKeyPress; ;
                    textBox.KeyUp -= TextBoxLaborCostKeyUp;
                    ///
                    textBox.KeyPress += TextBoxKeyPress; ;
                    textBox.KeyUp += TextBoxLaborCostKeyUp;
                }
            }
        }
        private void Cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
                int founRow = 0;
                bool found = false;
                dataFound = ((ComboBox)sender).Text;
                for (int i = 0; i < dataLabor.Rows.Count - 1; i++)
                {
                    if (dataLabor.Rows[i].IsNewRow) continue;
                    if (dataLabor.Rows[i].Cells["Column1"].Value.Equals(dataFound))
                    {
                        founRow = i;
                        found = true;
                        break;
                    }
                }
                if (!found)
                {
                    var gRow = dataLabor.CurrentRow;
                    if (this.GetItemTypeByName(dataFound, out DataRow row))
                    {
                            gRow.SetValue("Column3", 1);
                            row.SetValue("ItemID", gRow.Cells["Column9"]);
                            row.SetValue("Cost", gRow.Cells["Column4"]);
                            row.SetValue("Abbreviation", gRow.Cells["Column2"]);
                            var qty = dataLabor.AsNumber<decimal>("Column3");
                            var cost = dataLabor.AsNumber<decimal>("Column4");
                            gRow.SetValue("Column5", (qty * cost));
                            dataFound = "";
                    }
                }
                else
                {

                    quantity = dataLabor.GetValue<int>(founRow, "Column3");
                    dataLabor.SetText(founRow, "Column3", ++quantity);
                    var qty = dataLabor.AsNumber<decimal>(founRow, "Column3");
                    var cost = dataLabor.AsNumber<decimal>(founRow, "Column4");
                    dataLabor.SetText(founRow, "Column5", (qty * cost));
                }
                //Calculate total cost
                CalculateCost();
                //Calculate Additinal cost
                CalculateAdditionalCost();
                //calculate sale price
                CalculateSalePrice();
                return;
        }
        private void dataLabor_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
             e.Cancel = true;

            //object value = dataLabor.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
            //if (!((DataGridViewComboBoxColumn)dataLabor.Columns["Column1"]).Items.Contains(value))
            //{
            //    var dt = DBQuery.UseSql("SELECT Name FROM [vItemWithUom] WHERE Type='Labor'")
            //                   .Gets();
            //    foreach (DataRow item in dt.Rows)
            //    {
            //        ((DataGridViewComboBoxColumn)dataLabor.Columns["Column1"]).Items.Add(item[0].ToString());
            //    }
            //    e.ThrowException = false;
            //}

            //return;

            //e.ThrowException = false;
        }
        private void dataLabor_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            //bool validClick = (e.RowIndex != -1 && e.ColumnIndex != -1); //Make sure the clicked row/column is valid.
            //var datagridview = sender as DataGridView;
            //if (datagridview.Columns[e.ColumnIndex].Name == "Column1")
            //{
            //    if (datagridview.Rows[datagridview.CurrentRow.Index].IsNewRow)
            //    {
            //        // Check to make sure the cell clicked is the cell containing the combobox 
            //        if (datagridview.Columns[e.ColumnIndex] is DataGridViewComboBoxColumn && validClick)
            //        {
            //            datagridview.BeginEdit(true);
            //            ((ComboBox)datagridview.EditingControl).DropDownStyle = ComboBoxStyle.DropDown;
            //            ((ComboBox)datagridview.EditingControl).DroppedDown = true;
            //        }
            //    }
            //    else
            //    {
            //        //datagridview.BeginEdit(false);
            //        //((ComboBox)datagridview.EditingControl).DropDownStyle = ComboBoxStyle.Simple;
            //        //((ComboBox)datagridview.EditingControl).Enabled = false;
            //        //((ComboBox)datagridview.EditingControl).DroppedDown = false;
            //    }
            //}
        }
        private void dataLabor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        #endregion
        //Machinary Datagridview Events
        #region Machinary
        private void dataMachinary_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            //object value = dataMachinary.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
            //if (!((DataGridViewComboBoxColumn)dataMachinary.Columns["mnrItemName"]).Items.Contains(value))
            //{
            //    var dt = DBQuery.UseSql("SELECT Name FROM [vItemWithUom] WHERE Type='Machinary'")
            //                   .Gets();
            //    foreach (DataRow item in dt.Rows)
            //    {
            //        //if (item.Exist(0, value)) continue;
            //        ((DataGridViewComboBoxColumn)dataMachinary.Columns["mnrItemName"]).Items.Add(item[0].ToString());
            //    }
            //    e.ThrowException = false;
            //}

            //return;
        }

        private void dataMachinary_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //if (dataMachinary.Rows.Count == 1) return;
            //if (e.ColumnIndex == 0)
            //{
            //    int currentRow = 0;
            //    bool found = false;
            //    var gRow = dataMachinary.CurrentRow;
            //    var dataFound = gRow.GetValue("mnrItemName");
            //    for (int i = 0; i < dataMachinary.Rows.Count - 2; i++)
            //    {
            //        if (dataMachinary.Rows[i].IsNewRow) continue;
            //        if (dataMachinary.Rows[i].Cells["mnrItemName"].Value.Equals(dataFound))
            //        {
            //            currentRow = i;
            //            found = true;
            //            break;
            //        }
            //    }
            //    var id = dataMachinary.AsValue<long>(e.RowIndex, "mnrItemName");
            //    if (this.GetItemTypeById(id, out DataRow row))
            //    {
            //        if (!found)
            //        {
            //            gRow.SetValue("mnrQuantity", 1);
            //            row.SetValue("ItemID", gRow.Cells["mnrItemId"]);
            //            row.SetValue("Cost", gRow.Cells["mnrCost"]);
            //            row.SetValue("UomID", gRow.Cells["mnrUomID"]);
            //            row.SetValue("Abbreviation", gRow.Cells["mnrUom"]);
            //            //add sub total
            //            var qty = dataMachinary.AsNumber<decimal>("mnrQuantity");
            //            var cost = dataMachinary.AsNumber<decimal>("mnrCost");
            //            gRow.SetValue("mnrSubTotal", (qty * cost));
            //            //Calculate total cost
            //            CalculateCost();
            //            //Calculate Additinal cost
            //            CalculateAdditionalCost();
            //            //calculate sale price
            //            CalculateSalePrice();
            //            return;
            //        }
            //        else
            //        {

            //            quantity = dataMachinary.GetValue<int>(currentRow, "mnrQuantity");
            //            dataMachinary.SetText(currentRow, "mnrQuantity", ++quantity);
            //            //MessageBox.Show(@"Item already selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //            //add sub total
            //            var qty = dataMachinary.AsNumber<decimal>(currentRow, "mnrQuantity");
            //            var cost = dataMachinary.AsNumber<decimal>(currentRow, "mnrCost");
            //            dataMachinary.SetText(currentRow, "mnrSubTotal", (qty * cost));
            //            dataMachinary.Rows.Remove(gRow);
            //            //Calculate total cost
            //            CalculateCost();
            //            //Calculate Additinal cost
            //            CalculateAdditionalCost();
            //            //calculate sale price
            //            CalculateSalePrice();
            //            return;
            //        }
            //    }
            //    //Calculate total cost
            //    CalculateCost();
            //    //Calculate Additinal cost
            //    CalculateAdditionalCost();
            //    //calculate sale price
            //    CalculateSalePrice();
            //    return;
            //}
        
        }
        private void dataMachinary_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dataMachinary.CurrentCell.ColumnIndex == 0 && dataMachinary.Columns["mnrItemName"] is DataGridViewComboBoxColumn)
            {
                ComboBox cmb = e.Control as ComboBox;
                cmb.DropDownStyle = ComboBoxStyle.DropDown;
                cmb.AutoCompleteMode = AutoCompleteMode.Suggest;
            }

            if (dataMachinary.Columns[dataMachinary.CurrentCell.ColumnIndex].Name == "mnrQuantity" && dataMachinary.Columns["mnrQuantity"] is DataGridViewTextBoxColumn)
            {
                var gRow = dataMachinary.CurrentRow;
                if (gRow.GetValue("mnrItemName") == null)
                {
                    gRow.Cells["mnrQuantity"].ReadOnly = true;
                }
                else
                {
                    gRow.Cells["mnrQuantity"].ReadOnly = false;
                    TextBox textBoxMachinaryQuantity = e.Control as TextBox;
                    if (textBoxMachinaryQuantity != null)
                    {
                        textBoxMachinaryQuantity.KeyPress -= TextBoxKeyPress;
                        textBoxMachinaryQuantity.KeyUp -= TextBoxMachinaryQuantityKeyUp;

                        //===
                        textBoxMachinaryQuantity.KeyPress += TextBoxKeyPress;
                        textBoxMachinaryQuantity.KeyUp += TextBoxMachinaryQuantityKeyUp;
                    }
                }

            }

            if (dataMachinary.Columns[dataMachinary.CurrentCell.ColumnIndex].Name == "mnrCost" && dataMachinary.Columns["mnrCost"] is DataGridViewTextBoxColumn)
            {
                TextBox textGridCost = e.Control as TextBox;
                if (textGridCost != null)
                {
                    textGridCost.KeyPress -= TextBoxKeyPress;
                    textGridCost.KeyUp -= TextGridCostKeyUp;
                    //===
                    textGridCost.KeyPress += TextBoxKeyPress;
                    textGridCost.KeyUp += TextGridCostKeyUp;
                }
            }
        }

        private void TextBoxMachinaryQuantityKeyUp(object sender, KeyEventArgs e)
        {
            if (!string.IsNullOrEmpty(((TextBox)sender).Text))
            {
                var qty = ((TextBox)sender).AsNumber<decimal>();
                if (qty < 0)
                {
                    ((TextBox)sender).SetText("1.000");
                    qty = 1;
                }
                var cost = dataMachinary.AsNumber<decimal>("mnrCost");
                dataMachinary.SetText("mnrSubTotal", (qty * cost).ToString("0.00000"));
            }
            else
            {
                dataMachinary.SetText("mnrSubTotal","0.00000");
            }
            //Calculate total cost
            CalculateCost();
            //Calculate Additinal cost
            CalculateAdditionalCost();
            //calculate sale price
            CalculateSalePrice();
        }

        private void TextGridCostKeyUp(object sender, KeyEventArgs e)
        {
            if (!string.IsNullOrEmpty(((TextBox)sender).Text))
            {
                var cost = ((TextBox)sender).AsNumber<decimal>();
                if (cost < 0)
                {
                    ((TextBox)sender).SetText("1.00000");
                    cost = 1;
                }
                var qty = dataMachinary.AsNumber<decimal>("mnrQuantity");
                dataMachinary.SetText("mnrSubTotal", (qty * cost).ToString("0.00000"));
            }
            else
            {
                dataMachinary.SetText("mnrSubTotal", "0.00000");
            }
            //Calculate total cost
            CalculateCost();
            //Calculate Additinal cost
            CalculateAdditionalCost();
            //Calculate Sale Price
            CalculateSalePrice();
            return;
        }

        private void dataMachinary_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        #endregion
        //Material Datagridview Events

        #region Material
        private void dataMaterial_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            //object value = dataMaterial.AsValue<string>(e.RowIndex, "mtrItemName");
            //if (!((DataGridViewComboBoxColumn)dataMaterial.Columns["mtrItemName"]).Items.Contains(value))
            //{
            //    var dt = DBQuery.UseSql("SELECT Name FROM [vItemWithUom] WHERE Type='Material'")
            //                   .Gets();
            //    foreach (DataRow item in dt.Rows)
            //    {
            //        ((DataGridViewComboBoxColumn)dataMaterial.Columns["mtrItemName"]).Items.Add(item[0].ToString());
            //    }
            //    e.ThrowException = false;
            //}

            //return;
        }
        private void dataMaterial_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //if (dataMaterial.Rows.Count == 1) return;
            //if (e.ColumnIndex == 0)
            //{
            //    int currentRow = 0;
            //    bool found = false;
            //    var gRow = dataMaterial.CurrentRow;
            //    var dataFound = gRow.GetValue("mtrItemName");
            //    for (int i = 0; i < dataMaterial.Rows.Count - 2; i++)
            //    {
            //        if (dataMaterial.Rows[i].IsNewRow) continue;
            //        if (dataMaterial.Rows[i].Cells["mtrItemName"].Value.Equals(dataFound))
            //        {
            //            currentRow = i;
            //            found = true;
            //            break;
            //        }
            //    }
            //    var id = dataMaterial.AsValue<long>(e.RowIndex, "mtrItemName");
            //    if (this.GetItemTypeById(id, out DataRow row))
            //    {
            //        if (!found)
            //        {
            //            gRow.SetValue("mtrQuantity", 1);
            //            row.SetValue("ItemID", gRow.Cells["mtrItemId"]);
            //            row.SetValue("Cost", gRow.Cells["mtrCost"]);
            //            row.SetValue("UomID", gRow.Cells["mtrUomID"]);
            //            row.SetValue("Abbreviation", gRow.Cells["mtrUom"]);
            //            //add sub total
            //            var qty = dataMaterial.AsNumber<decimal>("mtrQuantity");
            //            var cost = dataMaterial.AsNumber<decimal>("mtrCost");
            //            gRow.SetValue("mtrSubTotal", (qty * cost));
            //            //Calculate total cost
            //            CalculateCost();
            //            //Calculate Additinal cost
            //            CalculateAdditionalCost();
            //            //calculate sale price
            //            CalculateSalePrice();
            //            return;
            //        }
            //        else
            //        {

            //            quantity = dataMaterial.GetValue<int>(currentRow, "mtrQuantity");
            //            dataMaterial.SetText(currentRow, "mtrQuantity", ++quantity);
            //            //MessageBox.Show(@"Item already selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //            //add sub total
            //            var qty = dataMaterial.AsNumber<decimal>(currentRow, "mtrQuantity");
            //            var cost = dataMaterial.AsNumber<decimal>(currentRow, "mtrCost");
            //            dataMaterial.SetText(currentRow, "mtrSubTotal", (qty * cost));
            //            dataMaterial.Rows.Remove(gRow);
            //            //Calculate total cost
            //            CalculateCost();
            //            //Calculate Additinal cost
            //            CalculateAdditionalCost();
            //            //calculate sale price
            //            CalculateSalePrice();
            //            return;
            //        }
            //    }
            //    //Calculate total cost
            //    CalculateCost();
            //    //Calculate Additinal cost
            //    CalculateAdditionalCost();
            //    //calculate sale price
            //    CalculateSalePrice();
            //    return;

            //}
        
        }
        private void dataMaterial_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dataMaterial.CurrentCell.ColumnIndex == 0 && dataMaterial.Columns["mtrItemName"] is DataGridViewComboBoxColumn)
            {
                ComboBox cmb = e.Control as ComboBox;
                cmb.DropDownStyle = ComboBoxStyle.DropDown;
                cmb.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            }
            if (dataMaterial.Columns[dataMaterial.CurrentCell.ColumnIndex].Name == "mtrCost" 
                && dataMaterial.Columns[dataMaterial.CurrentCell.ColumnIndex] is DataGridViewTextBoxColumn)
            {
                TextBox textBox = e.Control as TextBox;
                if (textBox != null)
                {
                    textBox.KeyPress += TextBoxKeyPress;
                    textBox.KeyUp += TextBoxMaterialCostKeyUp;
                }
            }
            if (dataMaterial.Columns[dataMaterial.CurrentCell.ColumnIndex].Name == "mtrQuantity" 
                && dataMaterial.Columns[dataMaterial.CurrentCell.ColumnIndex] is DataGridViewTextBoxColumn)
            {
                TextBox textBox = e.Control as TextBox;
                if (textBox != null)
                {
                    textBox.KeyPress += TextBoxKeyPress;
                    textBox.KeyUp += TextBoxMaterialQuantityKeyUp;
                }
            }
            
        }
        private void dataMaterial_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataMaterial.Columns[e.ColumnIndex].Name== "Column8")
            {
                if (!dataMaterial.Rows[e.RowIndex].IsNewRow)
                {
                    dataMaterial.Rows.RemoveAt(e.RowIndex);
                    //Calculate total cost
                    CalculateCost();
                    //Calculate Additinal cost
                    CalculateAdditionalCost();
                    //calculate sale price
                    CalculateSalePrice();
                }

            }
        }
        #endregion
        #region Additinal Cost
        private void dataAdditionalEditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {

            if (dataAdditional.Columns[dataAdditional.CurrentCell.ColumnIndex].Name == "Rate" 
                && dataAdditional.Columns["Rate"] is DataGridViewTextBoxColumn)
            {
                TextBox textBox = e.Control as TextBox;
                if (textBox != null)
                {
                    //unregister event
                    textBox.KeyPress -= TextBoxKeyPress;
                    textBox.KeyUp -= TextBoxAdditionalCostKeyUp;
                    //Register Event
                    textBox.KeyPress += TextBoxKeyPress;
                    textBox.KeyUp += TextBoxAdditionalCostKeyUp;
                }
            }
        }
        #endregion
        private void checkMargin_CheckedChanged(object sender, EventArgs e)
        {
            if (checkMargin.Checked)
            {
                textMargin.Enabled = true;
            }
            else
            {
                textMargin.Enabled = false;
                textMargin.SetText(0);
                textTotalMargin.SetText(0);
            }
            CalculateSalePrice();
        }
        private void checkInflation_CheckedChanged(object sender, EventArgs e)
        {
            //if (checkInflation.Checked)
            //{
            //    textInflation.Enabled = true;
            //}
            //else
            //{
            //    textInflation.Enabled= false;
            //    textInflation.SetText(0);
            //    textTotalInlfation.SetText(0);
            //}
            //CalculateSalePrice();
        }
        private void textMargin_KeyUp(object sender, KeyEventArgs e)
        {
            //var margin=((TextBox)sender).AsNumber<decimal>();
            //if(margin > 100)
            //{
            //    ((TextBox)sender).SetText(0);
            //    CalculateMargin();
            //}
            //else
            //{
            //    CalculateMargin(margin);
               
            //}
            //CalculateSalePrice();
        }
        private void textInflation_KeyUp(object sender, KeyEventArgs e)
        {
            //var inflation = ((TextBox)sender).AsNumber<decimal>();
            //if (inflation > 100)
            //{
            //    ((TextBox)sender).SetText(0);
            //    CalculateInflation();
            //}
            //else
            //{
            //    CalculateInflation(inflation);
            //}
            //CalculateSalePrice();
        }
        private void CalculateMarginAndInflation()
        {
            ////calculate margin and inflation
            //if (checkMargin.Checked)
            //{
            //    var margin = textMargin.AsNumber<decimal>();
            //    CalculateMargin(margin);
            //}
            //else
            //{
            //    textTotalMargin.SetText(0);
            //    CalculateMargin();
            //}
            //if (checkInflation.Checked)
            //{
            //    var inflation = textInflation.AsNumber<decimal>();
            //    CalculateInflation(inflation);
            //}
            //else
            //{
            //    textTotalInlfation.SetText(0);
            //    CalculateInflation();
            //}
        }
        private void CalculateCost()
        {
            //decimal subtotal = 0;
            //foreach (DataGridViewRow item in dataLabor.Rows)
            //{
            //    if (item.IsNewRow) break;
            //    subtotal += item.GetValue<decimal>("laborAmount");
            //}
            //foreach (DataGridViewRow item in dataMachinary.Rows)
            //{
            //    if (item.IsNewRow) break;
            //    subtotal += item.GetValue<decimal>("mnrSubTotal");
            //}
            //foreach (DataGridViewRow item in dataMaterial.Rows)
            //{
            //    if (item.IsNewRow) break;
            //    subtotal += item.GetValue<decimal>("mtrSubTotal");
            //}
            //textCost.Text = subtotal.ToString("0.0000");
        }
        private void CalculateAdditionalCost()
        {

            //foreach (DataGridViewRow iRow in dataAdditional.Rows)
            //{
            //    if (iRow.IsNewRow) break;
            //    var amount = (textCost.AsNumber<decimal>() * (iRow.GetValue<decimal>("Rate") / 100));
            //    iRow.SetValue("addAmount", string.Format("{0:0.00000}", amount));
            //}
            //CalculateTotalAdditionalCost();
        }
        private void CalculateTotalAdditionalCost()
        {
            //var totalAdditionalCost = 0M;
            //foreach (DataGridViewRow iRow in dataAdditional.Rows)
            //{
            //    if (iRow.IsNewRow) break;
            //    totalAdditionalCost += iRow.GetValue<decimal>("addAmount");
            //}
            //textAdditionalCost.SetText(totalAdditionalCost.ToString("0.00000"));
        }
        private void CalculateSalePrice() 
        {
           
            ////CalculateAdditionalCost();
            //CalculateTotalAdditionalCost();
            ////calculate margin and inflation
            //CalculateMarginAndInflation();
            //var cost = textCost.AsNumber<decimal>();
            //var margin = textTotalMargin.AsNumber<decimal>();
            //var inflation=textTotalInlfation.AsNumber<decimal>();
            //var totalAdditionalCost = textAdditionalCost.AsNumber<decimal>();
            //var salePrice =margin + inflation + totalAdditionalCost + cost;
            //textPrice.SetText(Utility.NumberString(salePrice,"N5"));
        }
        private void CalculateInflation(decimal inflationRate=0)
        {
            //var inflationTotal = ((inflationRate / 100) * (textCost.AsNumber<decimal>() + textAdditionalCost.AsNumber<decimal>()));
            //textTotalInlfation.SetText(inflationTotal.ToString("N5"));
        }
        private void CalculateMargin(decimal marginRate=0)
        {
            //var marginTotal = ((marginRate / 100) * (textCost.AsNumber<decimal>() + textAdditionalCost.AsNumber<decimal>()));
            //textTotalMargin.SetText(marginTotal.ToString("N5"));
        }

        private void btnLabor_Click(object sender, EventArgs e)
        {
            AddItemDialog form = new AddItemDialog();
            if (form.ShowDialog() == DialogResult.OK)
            {
                foreach (var itemId in form.ItemIdList)
                {
                    AddNewLaborToGrid(itemId);
                }
            }
        }
        internal void AddNewLaborToGrid(long itemID)
        {
            //int founRow = 0;
            //bool found = false;
            //for (int i = 0; i < dataLabor.Rows.Count; i++)
            //{
            //    if (dataLabor.Rows[i].IsNewRow) continue;
            //    if (dataLabor.Rows[i].Cells["laborBOQItemLineRefID"].Value.Equals(itemID))
            //    {
            //        founRow = i;
            //        found = true;
            //        break;
            //    }
            //}

            //if (found)
            //{
            //    var qty = dataLabor.GetValue<decimal>(founRow, "laborBOQItemLineQty") + 1;
            //    dataLabor.SetText(founRow, "laborBOQItemLineQty", qty.ToString("0.000"));
            //    //var qty = dataLabor.AsNumber<decimal>(founRow, "Column3");
            //    var cost = dataLabor.AsNumber<decimal>(founRow, "Column4");
            //    dataLabor.SetText(founRow, "laborAmount", string.Format("{0:N5}", (qty * cost)));
            //}
            //else
            //{
            //    //var data = DbAccess.UseSql("SELECT ItemID,Name,Price,UOMID,Abbreviation FROM vItemWithUom WHERE ItemID=@itemID")
            //    //                .Where(new { itemID = itemID })
            //    //                .First();
            //    //if (data != null)
            //    //{
            //    //    dataLabor.Rows.Add(
            //    //        data.GetValue<string>("Name"),
            //    //        "1.000", data.GetValue<string>("Abbreviation"),
            //    //        data.GetValue<double>("Price").ToString("0.00000"),
            //    //        data.GetValue<double>("Price").ToString("0.00000"),
            //    //        itemID, 
            //    //        data.GetValue<long>("UOMID")
            //    //        );
            //    //}
            //}
            ////Calculate total cost
            //CalculateCost();
            ////Calculate Additinal cost
            //CalculateAdditionalCost();
            ////calculate sale price
            //CalculateSalePrice();
        }
        private void AddNewMaterialToGrid(long itemID)
        {
            
            //int founRow = 0;
            //bool found = false;
   
            //    for (int i = 0; i < dataMaterial.Rows.Count; i++)
            //    {
            //        if (dataMaterial.Rows[i].IsNewRow) continue;
            //        if (dataMaterial.Rows[i].Cells["mtrItemRefID"].Value.Equals(itemID))
            //        {
            //            founRow = i;
            //            found = true;
            //            break;
            //        }
            //    }

            //    if (found)
            //    {
            //        var quantity = dataMaterial.GetValue<decimal>(founRow, "mtrQuantity") + 1;
            //        dataMaterial.SetText(founRow, "mtrQuantity", quantity);
            //        var qty = dataMaterial.AsNumber<decimal>(founRow, "mtrQuantity");
            //        var cost = dataMaterial.AsNumber<decimal>(founRow, "mtrCost");
            //        dataMaterial.SetText(founRow, "mtrSubTotal",(qty * cost).ToString("0.00000"));
            //    }
            //    else
            //    {
            //        //var data = DbAccess.UseSql("SELECT ItemID,Name,Price,UOMID,Abbreviation FROM vItemWithUom WHERE ItemID=@itemID")
            //        //                .Where(new { itemID = itemID })
            //        //                .First();
            //        //if (data != null)
            //        //{
            //        //    dataMaterial.Rows.Add(
            //        //        data.GetValue<string>("Name"),
            //        //        "1.000", 
            //        //        data.GetValue<string>("Abbreviation"),
            //        //        data.GetValue<double>("Price").ToString("0.00000"),
            //        //        data.GetValue<double>("Price").ToString("0.00000"),
            //        //        itemID,
            //        //        data.GetValue<long>("UOMID")
            //        //        );
            //        //}
            //    }
            //    //Calculate total cost
            //    CalculateCost();
            //    //Calculate Additinal cost
            //    CalculateAdditionalCost();
            //    //calculate sale price
            //    CalculateSalePrice();
          
        }
        //private void AddNewMachinaryToGrid(long itemID)
        //{
        //    int founRow = 0;
        //    bool found = false;
        //        for (int i = 0; i < dataMachinary.Rows.Count; i++)
        //        {
        //            if (dataMachinary.Rows[i].IsNewRow) continue;
        //            if (dataMachinary.Rows[i].Cells["mnrItemID"].Value.Equals(itemID))
        //            {
        //                founRow = i;
        //                found = true;
        //                break;
        //            }
        //        }
        //        if (found)
        //        {
        //            var quantity = dataMachinary.GetValue<decimal>(founRow, "mnrQuantity") + 1;
        //            dataMachinary.SetText(founRow, "mnrQuantity", quantity.ToString("0.00"));
        //            var qty = dataMachinary.AsNumber<decimal>(founRow, "mnrQuantity");
        //            var cost = dataMachinary.AsNumber<decimal>(founRow, "mnrCost");
        //            dataMachinary.SetText(founRow, "mnrSubTotal",(qty * cost).ToString("0.00000"));
        //        }
        //        else
        //        {
        //            //var data = DbAccess.UseSql("SELECT ItemID,Name,Price,UOMID,Abbreviation FROM vItemWithUom WHERE ItemID=@itemID")
        //            //               .Where(new { itemID = itemID })
        //            //               .First();
        //            //if (data != null)
        //            //{
        //            //    dataMachinary.Rows.Add(
        //            //        data.GetValue<string>("Name"),
        //            //        "1.00", data.GetValue<string>("Abbreviation"),
        //            //        data.GetValue<double>("Price").ToString("0.00000"),
        //            //        data.GetValue<double>("Price").ToString("0.00000"),
        //            //        itemID,
        //            //        data.GetValue<long>("UOMID")
        //            //        );
        //            //}
        //        }
        //        //Calculate total cost
        //        CalculateCost();
        //        //Calculate Additinal cost
        //        CalculateAdditionalCost();
        //        //calculate sale price
        //        CalculateSalePrice();
        //}
        private void btnMachinaryClick(object sender, EventArgs e)
        {
            AddItemDialog form = new AddItemDialog(type: "Machinary");
            if (form.ShowDialog() == DialogResult.OK)
            {
                foreach (var itemId in form.ItemIdList)
                {
                    AddNewMachinaryToGrid(itemId);
                }
            }
        }
        private void btnMaterialClick(object sender, EventArgs e)
        {
            AddItemDialog form = new AddItemDialog(type: "Material");
            if (form.ShowDialog() == DialogResult.OK)
            {
                foreach (var itemId in form.ItemIdList)
                {
                    AddNewMaterialToGrid(itemId);
                }
            }
        }

        //Cell Edit Event
        //private void dataLabor_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        //{
        //    if (e.RowIndex == -1) return;
        //    if (dataLabor.Columns[e.ColumnIndex].Name == "laborBOQItemLineQty")
        //    {
        //        if (dataLabor.GetValue<object>(e.RowIndex, "laborBOQItemLineQty") == null)
        //        {
        //            dataLabor.SetText(e.RowIndex, "laborBOQItemLineQty", "0.000");
        //        }
        //        else
        //        {
        //            var qty = dataLabor.GetValue<decimal>(e.RowIndex, "laborBOQItemLineQty");
        //            dataLabor.SetText(e.RowIndex, "laborBOQItemLineQty", qty.ToString("N3"));

        //        }
        //    }
        //    if (dataLabor.Columns[e.ColumnIndex].Name == "Column4")
        //    {
        //        if (dataLabor.GetValue<object>(e.RowIndex, "Column4") == null)
        //        {
        //            dataLabor.SetText(e.RowIndex, "Column4", "0.00000");
        //        }
        //        else
        //        {
        //            var cost = dataLabor.GetValue<double>(e.RowIndex, "Column4");
        //            dataLabor.SetText(e.RowIndex, "Column4", cost.ToString("N5"));

        //        }
        //    }
        //    if (dataLabor.Columns[e.ColumnIndex].Name == "laborAmount")
        //    {
        //        if (dataLabor.GetValue<object>(e.RowIndex, "laborAmount") == null)
        //        {
        //            dataLabor.SetText(e.RowIndex, "laborAmount", "0.00000");
        //        }
        //        else
        //        {
        //            var price = dataLabor.GetValue<double>(e.RowIndex, "laborAmount");
        //            dataLabor.SetText(e.RowIndex, "laborAmount", price.ToString("N5"));

        //        }
        //    }
        //}

        //private void dataMachinary_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        //{
        //    if (e.RowIndex == -1) return;
        //    if (dataMachinary.Columns[e.ColumnIndex].Name == "mnrQuantity")
        //    {
        //        if (dataMachinary.GetValue<object>(e.RowIndex, "mnrQuantity") == null)
        //        {
        //            dataMachinary.SetText(e.RowIndex, "mnrQuantity", "0.000");
        //        }
        //        else
        //        {
        //            var qty = dataMachinary.GetValue<decimal>(e.RowIndex, "mnrQuantity");
        //            dataMachinary.SetText(e.RowIndex, "mnrQuantity", qty.ToString("0.000"));

        //        }
        //    }
        //    if (dataMachinary.Columns[e.ColumnIndex].Name == "mnrCost")
        //    {
        //        if (dataMachinary.GetValue<object>(e.RowIndex, "mnrCost") == null)
        //        {
        //            dataMachinary.SetText(e.RowIndex, "mnrCost", "0.00000");
        //        }
        //        else
        //        {
        //            var cost = dataMachinary.GetValue<decimal>(e.RowIndex, "mnrCost");
        //            dataMachinary.SetText(e.RowIndex, "mnrCost", cost.ToString("0.00000"));

        //        }
        //    }
        //}

        //private void dataMaterial_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        //{
        //    if (e.RowIndex == -1) return;
        //    if (dataMaterial.Columns[e.ColumnIndex].Name == "mtrQuantity")
        //    {
        //        if (dataMaterial.GetValue<object>(e.RowIndex, "mtrQuantity") == null)
        //        {
        //            dataMaterial.SetText(e.RowIndex, "mtrQuantity", "0.000");
        //        }
        //        else
        //        {
        //            var qty = dataMaterial.GetValue<decimal>(e.RowIndex, "mtrQuantity");
        //            dataMaterial.SetText(e.RowIndex, "mtrQuantity", qty.ToString("0.000"));

        //        }
        //    }
        //    if (dataMaterial.Columns[e.ColumnIndex].Name == "mtrCost")
        //    {
        //        if (dataMaterial.GetValue<object>(e.RowIndex, "mtrCost") == null)
        //        {
        //            dataMaterial.SetText(e.RowIndex, "mtrCost", "0.00000");
        //        }
        //        else
        //        {
        //            var cost = dataMaterial.GetValue<decimal>(e.RowIndex, "mtrCost");
        //            dataMaterial.SetText(e.RowIndex, "mtrCost", cost.ToString("0.00000"));

        //        }
        //    }
        //}

        //private void dataLabor_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        //{
        //    if (dataLabor.Rows.Count > 0)
        //    {
        //        if (dataLabor.Columns[e.ColumnIndex].Name == "Column4")
        //        {
        //            if(e.Value != null)
        //            {
        //                dataLabor.Columns["Column4"].DefaultCellStyle.Format = "N5";
        //                dataLabor.Columns["Column4"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        //            }
        //        }
        //        if (dataLabor.Columns[e.ColumnIndex].Name == "laborAmount")
        //        {
        //            if (e.Value != null)
        //            {
        //                dataLabor.Columns["laborAmount"].DefaultCellStyle.Format = "N5";
        //                dataLabor.Columns["laborAmount"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        //            }

        //        }
        //        if (dataLabor.Columns[e.ColumnIndex].Name == "laborBOQItemLineQty")
        //        {
        //            if (e.Value != null)
        //            {
        //                dataLabor.Columns["laborBOQItemLineQty"].DefaultCellStyle.Format = "N3";
        //                dataLabor.Columns["laborBOQItemLineQty"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        //            }
        //        }
        //    }
        //}

        //private void dataMachinary_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        //{
        //    if (dataMachinary.Rows.Count > 0)
        //    {
        //        if (dataMachinary.Columns[e.ColumnIndex].Name == "mnrQuantity")
        //        {
        //            if(e.Value != null)
        //            {
        //                dataMachinary.Columns["mnrQuantity"].DefaultCellStyle.Format = "N3";
        //                dataMachinary.Columns["mnrQuantity"].DefaultCellStyle.Alignment= DataGridViewContentAlignment.MiddleRight;
        //            }
        //        }
        //        if (dataMachinary.Columns[e.ColumnIndex].Name == "mnrCost")
        //        {
        //            if (e.Value != null)
        //            {
        //                dataMachinary.Columns["mnrCost"].DefaultCellStyle.Format = "N5";
        //                dataMachinary.Columns["mnrCost"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        //            }
        //        }
        //        if (dataMachinary.Columns[e.ColumnIndex].Name == "mnrSubTotal")
        //        {
        //            if (e.Value != null)
        //            {
        //                dataMachinary.Columns["mnrSubTotal"].DefaultCellStyle.Format = "N5";
        //                dataMachinary.Columns["mnrSubTotal"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        //            }
        //        }
        //    }
        //}

        //private void dataMaterial_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        //{
        //    if (dataMaterial.Rows.Count > 0)
        //    {
        //        if (dataMaterial.Columns[e.ColumnIndex].Name == "mtrQuantity")
        //        {
        //            if (e.Value != null)
        //            {
        //                dataMaterial.Columns["mtrQuantity"].DefaultCellStyle.Format = "N3";
        //                dataMaterial.Columns["mtrQuantity"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        //            }
        //        }
        //        if (dataMaterial.Columns[e.ColumnIndex].Name == "mtrCost")
        //        {
        //            if (e.Value != null)
        //            {
        //                dataMaterial.Columns["mtrCost"].DefaultCellStyle.Format = "N5";
        //                dataMaterial.Columns["mtrCost"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        //            }
        //        }
        //        if (dataMaterial.Columns[e.ColumnIndex].Name == "mtrSubTotal")
        //        {
        //            if (e.Value != null)
        //            {
        //                dataMaterial.Columns["mtrSubTotal"].DefaultCellStyle.Format = "N5";
        //                dataMaterial.Columns["mtrSubTotal"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        //            }
        //        }
        //    }
        //}

        //private void dataAdditional_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        //{
        //    if (e.RowIndex == -1) return;
        //    if (dataAdditional.Columns[e.ColumnIndex].Name == "Rate")
        //    {
        //        if (dataAdditional.GetValue<object>(e.RowIndex, "Rate") == null)
        //        {
        //            dataAdditional.SetText(e.RowIndex, "Rate", "0.000");
        //        }
        //        else
        //        {
        //            var rate = dataAdditional.GetValue<decimal>(e.RowIndex, "Rate");
        //            dataAdditional.SetText(e.RowIndex, "Rate", rate.ToString("N3"));

        //        }
        //    }
           
        }
        //private void dataAdditional_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        //{
        //    if (dataMaterial.Rows.Count > 0)
        //    {
        //        if (dataMaterial.Columns[e.ColumnIndex].Name == "Rate")
        //        {
        //            if (e.Value != null)
        //            {
        //                dataMaterial.Columns["Rate"].DefaultCellStyle.Format = "N3";
        //                dataMaterial.Columns["Rate"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        //            }
        //        }
        //        if (dataMaterial.Columns[e.ColumnIndex].Name == "addAmount")
        //        {
        //            if (e.Value != null)
        //            {
        //                dataMaterial.Columns["addAmount"].DefaultCellStyle.Format = "N5";
        //                dataMaterial.Columns["addAmount"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        //            }
        //        }
                
        //    }
        //}

        private void textInflation_MouseLeave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(((TextBox)sender).Text))
            {
                ((TextBox)sender).Text = Utility.NumberString(0, "N2");
            }
            else
            {
                var inflation = ((TextBox)sender).AsNumber<decimal>();
                ((TextBox)sender).Text = Utility.NumberString(inflation, "N2");
            }
        }

        private void textName_KeyUp(object sender, KeyEventArgs e)
        {
            var text = ((TextBox)sender).Text.Trim();
            if (ItemController.ItemExist(text))
            {
                MessageBox.Show("Item already exist.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ((TextBox)sender).Select(0, ((TextBox)sender).Text.Length);
                return;
            }
        }
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


//private void Cmb_DropDownClosed(object sender, EventArgs e)
//{
//    DataGridViewComboBoxEditingControl cmbBx = sender as DataGridViewComboBoxEditingControl;
//    if (cmbBx != null)
//        cmbBx.DisplayMember = "ItemName";
//}

//private void Cmb_DropDown(object sender, EventArgs e)
//{
//    DataGridViewComboBoxEditingControl cmbBx = sender as DataGridViewComboBoxEditingControl;
//    if (cmbBx != null)
//    {
//        cmbBx.DisplayMember = "ItemName";
//        cmbBx.ValueMember = "ItemID";
//    }
//}

//private void dataGridView1_CellValidating(object sender,
//DataGridViewCellValidatingEventArgs e)
//{
//    if (dataGridView1.CurrentCell.IsInEditMode)
//    {
//        if (dataGridView1.CurrentCell.GetType() ==
//        typeof(DataGridViewComboBoxCell))
//        {
//            DataGridViewComboBoxCell cell =
//            (DataGridViewComboBoxCell)dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];

//            if (!cell.Items.Contains(e.FormattedValue))
//            {
//                cell.Items.Add(e.FormattedValue);

//                cell.Value = e.FormattedValue;

//                //keep the new value in the member variable
//                newCellValue
//                newCellValue = e.FormattedValue;
//            }
//        }
//    }

//}

//private void dataGridView1_EditingControlShowing(object sender,
//DataGridViewEditingControlShowingEventArgs e)
//{
//    if (e.Control.GetType() ==
//    typeof(DataGridViewComboBoxEditingControl))
//    {
//        ((ComboBox)e.Control).DropDownStyle = ComboBoxStyle.DropDown;
//    }
//}

//private void dataGridView1_CellValidated(object sender,
//DataGridViewCellEventArgs e)
//{
//    if (dataLabor.CurrentCell.GetType() ==
//    typeof(DataGridViewComboBoxCell))
//    {
//        DataGridViewCell cell =
//        dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];
//        cell.Value = newCellValue;
//    }

//private void dataLabor_CellEnter(object sender, DataGridViewCellEventArgs e)
//{
//    SetComboBoxCellType objChangeCellType = new SetComboBoxCellType(ChangeCellToComboBox);
//    if (e.ColumnIndex == this.dataGridView1.Columns["Company"].Index)
//    {
//        this.dataGridView1.BeginInvoke(objChangeCellType, e.RowIndex);
//        bIsComboBox = false;

//    }
//}
//private void ChangeCellToComboBox(int iRowIndex)
//{

//    if (bIsComboBox == false)
//    {

//        DataGridViewComboBoxCell dgComboCell = new DataGridViewComboBoxCell();
//        dgComboCell.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;
//        DataTable dt = new DataTable();
//        dt.Columns.Add("Name", typeof(string));
//        dt.Columns.Add("Company", typeof(string));
//        for (int i = 0; i < 5; i++)

//        {
//            DataRow dr = dt.NewRow();
//            dr["Name"] = "Name - " + i.ToString();
//            dr["Company"] = "Company - " + i.ToString();
//            dt.Rows.Add(dr);
//        }
//        dgComboCell.DataSource = dt;
//        dgComboCell.ValueMember = "Company";
//        dgComboCell.DisplayMember = "Company";
//        dataGridView1.Rows[iRowIndex].Cells[dataGridView1.CurrentCell.ColumnIndex] = dgComboCell;
//        bIsComboBox = true;

//    }

//}