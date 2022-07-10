using ESProMeter.Controllers;
using ESProMeter.Extensions;
using ESProMeter.Views.UnitOfMeasures;
using System;
using System.Data;
using System.Windows.Forms;

namespace ESProMeter.Views.Items
{
    public partial class UpdateItemFrm : Form
    {
     
        public UpdateItemFrm( long itemID)
        {
            InitializeComponent();
            this.ShowItems();
            this.ShowUom();
            lblItemID.SetText(itemID);
            //var dr=DbAccess.UseSql("SELECT Name,Description,Type,UOMRefID,Cost,Price,EditSequense FROM [dbo].[Item] WHERE itemID=@itemID;")
            //                .Where(new { itemID = itemID })
            //                .First();
            //if(dr != null)
            //{
            //    textName.SetText(dr.GetValue<string>("Name"));
            //    textDescription.SetText(dr.GetValue<string>("Description"));
            //    textCost.SetText(dr.GetValue<decimal>("Cost").ToString("0.00000"));
            //    textPrice.SetText(dr.GetValue<decimal>("Price").ToString("0.00000"));
            //    cmbType.SelectedValue= dr.GetValue<string>("Type");
            //    cmbUom.SelectedValue = dr.GetValue<string>("UOMRefID");
            //    lblEditSequense.SetText(dr.GetValue<string>("EditSequense"));
            //}
          
        }
        private void AddItemFrm_Load(object sender, EventArgs e)
        {
            //this.ShowItems();
            //this.ShowUom();

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
        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbType.SelectedIndex == -1) return;
            if (cmbType.Text == "Bill Of Quantity")
            {
                this.Able(checkMargin, checkInflation);
                this.Disable(textPrice, textCost);
                try
                {
                   
                }
                catch (Exception)
                {
                    throw;
                }
            }
            
        }
        
      
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
            if (this.IsValid(textName, textDescription, cmbType, cmbUom))
            {
                var data = this.AsObjectOnly(textName, textCost, chkIsInActive,
                    lblItemID,lblEditSequense,
                    textPrice, cmbType, cmbUom, textDescription);
                if (cmbType.Text == "Bill Of Quantity")
                {
                    //this.CreateNewItemBoqLine(data);
                    //this.ClearForm(textName, textDescription);
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    if (ItemController.ItemExistSame(lblItemID.AsNumber<long>(), textName.Text.Trim()))
                    {
                        MessageBox.Show("Item Already exist","Informaton",MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        this.UpdateItem(data);
                        this.ClearForm(textName, textDescription);
                        this.DialogResult = DialogResult.OK;
                    }
                }
              
            }
            else
            {
                lblName.ErrorMessage(textName.Name,"please enter Text Name field");
                lblDescription.ErrorMessage(textDescription.Name);
            }
        }

        private void textCost_KeyUp(object sender, KeyEventArgs e)
        {
            if (!string.IsNullOrEmpty(((TextBox)sender).Text))
            {
                textPrice.SetText(textCost.Text);
            }
        }

        private void textCost_MouseLeave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(((TextBox)sender).Text))
            {
                textCost.SetText("0.0000");
            }
            else
            {
                var cost = ((TextBox)sender).AsNumber<decimal>();
                ((TextBox)sender).SetText(cost.ToString("0.00000"));
                var price = textPrice.AsNumber<decimal>();
                textPrice.SetText(price.ToString("0.00000"));
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