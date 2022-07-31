using ESProMeter.Controllers;
using ESProMeter.Enums;
using ESProMeter.Extensions;
using System;
using System.Data;
using System.Windows.Forms;

namespace ESProMeter.Views.Items
{
	public partial class ItemListFrm : Form
	{
        internal static int actionType = 0;
        internal static int _itemType = 0; 
        public ItemListFrm()
		{
			InitializeComponent();
            dataItemList.ClearSelection();
            dataItemList.AutoGenerateColumns = false;
			this.cmdNumberRows.SelectedIndex = 0;
            this.cmbSortBy.SelectedIndex = 0;
            this.cmbFieldName.SelectedIndex = 0;
        }

		private void tslNewClick(object sender, EventArgs e)
		{
            AddItemFrm form =new AddItemFrm();
            actionType = 0;
            _itemType = 0;
           
			if(form.ShowDialog() == DialogResult.OK)
            {
                if (form.ItemTypes == ItemType.Item)
                {
                    this.ItemCreate(form,ItemType.Item);
                }else
                {
                    this.ItemCreate(form, ItemType.Boq);
                }
                this.ShowItemList(this.dataItemList);
            }
		}
        private void ItemListFrm_Load(object sender, EventArgs e)
        {
            this.ShowItemList(this.dataItemList);
            dataItemList.ClearSelection();
        }
        private void tlCreateACopy_Click(object sender, EventArgs e)
        {
            if (dataItemList.Rows.Count > 0)
            {
                var index = dataItemList.CurrentRow.Index;
                var itemType = dataItemList.AsValue<string>(index, "Column3");
                if (itemType == "BillOfQuantity")
                {
                    var id = dataItemList.AsNumber<long>(index, "Column1");
                    AddItemFrm updateBoqForm = new AddItemFrm(id, Enums.ActionType.CreateACopy);
                    actionType = 0;
                    updateBoqForm.ItemTypes = ItemType.Boq;
                    if (updateBoqForm.ShowDialog() == DialogResult.OK)
                    {
                        //this.CreateNewItem(updateBoqForm);
                        this.ShowItemList(this.dataItemList);
                    }
                }
                else
                {
                    var id = dataItemList.AsNumber<long>(index, "Column1");
                    AddItemFrm formAdd = new AddItemFrm(id, Enums.ActionType.CreateACopy);
                    actionType = 1;
                    formAdd.ItemTypes = ItemType.Item;
                    if (formAdd.ShowDialog() == DialogResult.OK)
                    {

                        this.ShowItemList(dataItemList);
                        dataItemList.Rows[index].Selected = true;
                    }
                }

            }
        }
        private void tlsEdit_Click(object sender, EventArgs e)
        {
            if (dataItemList.Rows.Count > 0)
            {
                var index = dataItemList.CurrentRow.Index;
                var itemType = dataItemList.AsValue<string>(index, "Column3");
                var id = dataItemList.AsNumber<long>(index, "Column1");
                if (itemType == "BillOfQuantity")
                {
                    AddItemFrm form = new AddItemFrm(id,Enums.ActionType.EDIT);
                    actionType = 1;
                    _itemType = 0;
                    form.ItemTypes = ItemType.Boq;
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        //this.UpdateExistingBoqItemLine(form, form.dgvBoq);
                    }
                }
                else
                {
                    AddItemFrm form = new AddItemFrm(id,Enums.ActionType.EDIT);
                    _itemType = 1;
                    form.ItemTypes = ItemType.Item;
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        //this.UpdateExistingItem(form);
                        this.ShowItemList(this.dataItemList);
                    }

                }
            }
        }
        private void tlsRefresh_Click(object sender, EventArgs e)
        {
            var rows = this.AsControl<ComboBox>("cmdNumberRows").AsNumber<int>();
            var sortBy = string.IsNullOrEmpty(this.AsControl<ComboBox>("cmbSortBy").Text) ? "Name" : this.AsControl<ComboBox>("cmbSortBy").Text;
            this.ShowItemList(dataItemList,rows,sortBy);
        }
        private void tlsdelete_Click(object sender, EventArgs e)
        {
            if (dataItemList.Rows.Count > 0)
            {
                var index = dataItemList.CurrentRow.Index;
                var id = dataItemList.AsNumber<long>(index, "Column1");
                if(MessageBox.Show("Do you want to delete this item?",
                    "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (this.DeleteItem(id)){
                        //var rows = this.AsControl<ComboBox>("cmdNumberRows").AsNumber<int>();
                        dataItemList.Rows.RemoveAt(index);
                        //this.ShowItemList(dataItemList);
                    }
                }  
            }
        }
        private void tlMakeInActiveClick(object sender, EventArgs e)
        {
            if (dataItemList.AsBealean("Column12"))
            {
                if (this.MakeItemActiveOrInActive(false))
                {
                    toolStripButton5.Text = dataItemList.AsBealean("Column12") == false ? "Make Active" : "Make in Active";
                }
            }
            else
            {
                if (this.MakeItemActiveOrInActive(true))
                {
                    toolStripButton5.Text = dataItemList.AsBealean("Column12") == false ? "Make Active" : "Make in Active";
                }
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

            this.SearchItemList(this.dataItemList,((TextBox)sender).Text);
            //var textField = string.IsNullOrEmpty(cmbFieldName.Text.Trim()) ? "Name" : cmbFieldName.Text.Trim();
            //if (string.IsNullOrEmpty(textField))
            //{
            //    var rows = this.AsControl<ComboBox>("cmdNumberRows").AsNumber<int>();
            //    var sortBy = string.IsNullOrEmpty(this.AsControl<ComboBox>("cmbSortBy").Text) ? "Name" : this.AsControl<ComboBox>("cmbSortBy").Text;
            //    this.ShowItemList(rows, sortBy);
            //    return;
            //}
            //if (textField == "Cost" || textField == "Price")
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
        }

        private void cmbSortBySelectedIndexChanged(object sender, EventArgs e)
        {
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
        }

		private void textSearch_Enter(object sender, EventArgs e)
		{
            //Select text in text box
		}
	}
}
