using ESProMeter.Controllers;
using ESProMeter.Enums;
using ESProMeter.Extensions;
using Microsoft.Office.Interop.Excel;
using System;
using System.Drawing;
using System.Windows.Forms;
using static ESProMeter.Extensions.FormExtension;
namespace ESProMeter.Views.Items
{

	public partial class ItemListFrm : Form
	{
        
        public ItemListFrm()
		{
			InitializeComponent();
            SetDoubleBuffer(dataItemList, true);
            dataItemList.ClearSelection();
			this.cmbPage.SelectedIndex = 0;
            this.cbmSortType.SelectedIndex = 0;
        }

		private void tslNewClick(object sender, EventArgs e)
		{
            AddItemFrm form = new AddItemFrm();
            form.WindowState = FormWindowState.Normal;
            form.StartPosition = FormStartPosition.WindowsDefaultLocation;
            form.ActionStatus = ActionStatus.New;
            
            if (form.ShowDialog() == DialogResult.OK)
            {
                //if (this.IsItemExist(form.ITEMNAME))
                //{
                //    MessageBox.Show("This Item already exist in database.", "Add New Item", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //    return;
                //}

                if (form.ItemTypes == ItemsType.Item)
                {
                        this.ItemCreate(form, ItemsType.Item);
                }
                else
                {
                    this.ItemCreate(form,ItemsType.Boq);
                }
                ShowAllItems();
            }
        }

        private void ShowAllItems(string itemName=null)
        {
            var orderType = cbmSortType.Text.Length==0?"ASC":cbmSortType.Text;
            var page = cmbPage.AsNumber<int>()==0?50: cmbPage.AsNumber<int>();
            if (checkBox1.Checked)
            {
                this.ShowItemList(itemName,this.dataItemList, 0, page,orderType);
            }
            else
            {
                this.ShowItemList(itemName,this.dataItemList, 1, page, orderType);
            }
        }
        private void tlCreateACopy_Click(object sender, EventArgs e)
        {
            if (dataItemList.Rows.Count > 0)
            {
                var index = dataItemList.CurrentRow.Index;
                var itemType = dataItemList.AsValue<string>(index, "Column3");
                if (itemType == "BillOfQuantity")
                {
                    var id = dataItemList.AsNumber<long>(index, "ID");
                    AddItemFrm updateBoqForm = new AddItemFrm(id,ItemsType.Boq, Enums.ActionType.CreateACopy);
                    updateBoqForm.ItemTypes = ItemsType.Boq;
                    if (updateBoqForm.ShowDialog() == DialogResult.OK)
                    {
                        this.ItemCreate(updateBoqForm,ItemsType.Boq);
                        this.ShowItemList(this.dataItemList,1);
                    }
                }
                else
                {
                    var id = dataItemList.AsNumber<long>(index, "ID");
                    AddItemFrm formAdd = new AddItemFrm(id,ItemsType.Item, Enums.ActionType.CreateACopy);
                    formAdd.ItemTypes = ItemsType.Item;
                    if (formAdd.ShowDialog() == DialogResult.OK)
                    {
                        this.ItemCreate(formAdd, ItemsType.Item);
                        this.ShowItemList(dataItemList,1);
                    }
                }

            }
        }
        private void tlsEdit_Click(object sender, EventArgs e)
        {
            if (dataItemList.Rows.Count > 0)
            {
                if (dataItemList.SelectedRows.Count > 0)
                {
                    var selectedRow = dataItemList.SelectedRows[0];
                    var itemType =selectedRow.GetValue<string>("Column3");
                    var id = selectedRow.GetValue<long>("ID");
                    if (itemType == "BillOfQuantity")
                    {
                        AddItemFrm form = new AddItemFrm(id,ItemsType.Boq, Enums.ActionType.EDIT);
                        form.ItemTypes = ItemsType.Boq;
                        if (form.ShowDialog() == DialogResult.OK)
                        {
                            if (this.IsItemExist(form.ID,form.ITEMNAME))
                            {
                                MessageBox.Show("This Item already exist in database.", "Update Item", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return;
                            }
                            else
                            {
                                this.ItemUpdate(form, ItemsType.Boq);
                                this.ShowItemList(this.dataItemList, 1);
                            }
                        }
                    }
                    else
                    {
                        AddItemFrm form = new AddItemFrm(id,ItemsType.Item, Enums.ActionType.EDIT);
                        form.ItemTypes = ItemsType.Item;
                        if (form.ShowDialog() == DialogResult.OK)
                        {
                            this.ItemUpdate(form, ItemsType.Item);
                            this.ShowItemList(this.dataItemList,1);
                        }

                    }
                }
            }
        }
        private void tlsRefresh_Click(object sender, EventArgs e)
        {
            ShowAllItems();
        }
        private void tlsdelete_Click(object sender, EventArgs e)
        {
            if (dataItemList.SelectedRows.Count> 0)
            {
                var selectedRow = dataItemList.SelectedRows[0];
                var id = selectedRow.GetValue<long>("ID");
                if(MessageBox.Show("Do you want to delete this item?",
                    "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (this.DeleteItem(id))
                    {
                        dataItemList.Rows.Remove(selectedRow);
                    }
                }  
            }
        }
        private void tlMakeInActiveClick(object sender, EventArgs e)
        {

            if (dataItemList.SelectedRows.Count < 1) return;
            var row = dataItemList.SelectedRows[0];
            var id = row.GetValue<long>("ID");
            byte IsActive = row.GetValue<byte>("Active") == 0 ? (byte)1 : (byte)0;
            if (this.MakeItemInactiveOrActive(id, IsActive))
            {
                this.dataItemList.SetText("Active", IsActive);
                tlsActive.Text = IsActive == 0 ? "Make Active" : "Make inActive";
            }

        }
        private void btnSearchClick(object sender, EventArgs e)
        {
            //var textField = string.IsNullOrEmpty(cmbFieldName.Text.Trim()) ? "Name" : cmbFieldName.Text.Trim();
            //if (string.IsNullOrEmpty(textField))
            //{
            //    var rows = this.AsControl<ComboBox>("cmdNumberRows").AsNumber<int>();
            //    var sortBy = string.IsNullOrEmpty(this.AsControl<ComboBox>("cmbSortBy").Text) ? "Name" : this.AsControl<ComboBox>("cmbSortBy").Text;
            //    this.ShowItemList(dataItemList,rows, sortBy);
            //    return;
            //}
            //if(textField == "Cost" || textField=="Price" || textField=="IsActive")
            //{
            //    var textValue = textSearch.GetVale<decimal>();
            //    if (this.SearchByFieldName(textField, textValue, out DataTable table))
            //    {
            //        table.AsDataGrid(this.dataItemList);
            //        return;
            //    }
            //    else
            //    {
            //        ((DataTable)dataItemList.DataSource).Rows.Clear();
            //    }
            //}
            //else
            //{
            //    var textValue = textSearch.GetVale<string>();
            //    if (this.SearchByFieldName(textField, textValue, out DataTable table))
            //    {
            //        table.AsDataGrid(this.dataItemList);
            //        return;
            //    }
            //    else
            //    {
            //        var rows = this.AsControl<ComboBox>("cmdNumberRows").AsNumber<int>();
            //        var sortBy = string.IsNullOrEmpty(this.AsControl<ComboBox>("cmbSortBy").Text) ? "Name" : this.AsControl<ComboBox>("cmbSortBy").Text;
            //        this.ShowItemList(dataItemList,rows, sortBy);
            //        return;
            //    }
            //}
        }

        private void textSearch_KeyUp(object sender, KeyEventArgs e)
        {
            var searchText= ((System.Windows.Forms.TextBox)sender).Text;
            ShowAllItems(searchText);
        }

        private void cmbSortBySelectedIndexChanged(object sender, EventArgs e)
        {
            ShowAllItems(textSearch.Text.Trim());
        }

        private void cmbPage_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowAllItems();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            ShowAllItems();
        }

        private void dataItemList_SelectionChanged(object sender, EventArgs e)
        {
            if (dataItemList.SelectedRows.Count > 0)
            {
                var selectedRow = dataItemList.SelectedRows[0];
                if (selectedRow.GetValue<byte>("Active")==1)
                {
                    tlsActive.Text = "Make InActive";
                }
                else
                {
                    tlsActive.Text = "Make Active";
                }
            }
        }

		private void textSearch_Enter(object sender, EventArgs e)
		{
            //Select text in text box
		}

        private void ItemListFrm_Load(object sender, EventArgs e)
        {
            ShowAllItems();
        }

        

        private void ItemListFrm_SizeChanged(object sender, EventArgs e)
        {
            //if (this.WindowState == FormWindowState.Maximized)
            //{
            //    this.ControlBox = false;
            //}
            //else
            //{
            //    this.ControlBox = true;
            //}
        }

        private void dataItemList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (dataItemList.Columns[e.ColumnIndex].Name== "Column5")
                {
                    if(e.Value != null)
                    {
                        e.CellStyle.Format = "N2";
                        e.CellStyle.ForeColor = Color.Red;
                    }
                }
            }
        }

        private void excelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Views.Item.ItemExportFrm form = new Item.ItemExportFrm();
            form.ShowDialog();
        }
    }
}



//var textField = string.IsNullOrEmpty(cmbFieldName.Text.Trim()) ? "Name" : cmbFieldName.Text.Trim();
//if (string.IsNullOrEmpty(textField))
//{
//    var rows = this.AsControl<ComboBox>("cmdNumberRows").AsNumber<int>();
//    var sortBy = string.IsNullOrEmpty(this.AsControl<ComboBox>("cmbSortBy").Text) ? "Name" : this.AsControl<ComboBox>("cmbSortBy").Text;
//    this.ShowItemList(rows, sortBy);
//    return;
//}
//if (textField == "Cost" || textField == "Price" || textField == "IsActive")
//{
//    var textValue = textSearch.GetVale<decimal>();
//    if (this.SearchByFieldName(textField, textValue, out DataTable table))
//    {
//        table.AsDataGrid(this.dataItemList);
//        return;
//    }
//    else
//    {
//        ((DataTable)dataItemList.DataSource).Rows.Clear();
//    }
//}
//else
//{
//    var textValue = textSearch.GetVale<string>();
//    if (this.SearchByFieldName(textField, textValue, out DataTable table))
//    {
//        table.AsDataGrid(this.dataItemList);
//        return;
//    }
//    else
//    {
//        var rows = this.AsControl<ComboBox>("cmdNumberRows").AsNumber<int>();
//        var sortBy = string.IsNullOrEmpty(this.AsControl<ComboBox>("cmbSortBy").Text) ? "Name" : this.AsControl<ComboBox>("cmbSortBy").Text;
//        this.ShowItemList(rows, sortBy);
//        return;
//    }
//}