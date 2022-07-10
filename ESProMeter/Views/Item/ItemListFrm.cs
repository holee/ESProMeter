using ESProMeter.Controllers;
using ESProMeter.Extensions;
using System;
using System.Data;
using System.Windows.Forms;

namespace ESProMeter.Views.Items
{
	public partial class ItemListFrm : Form
	{
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
			Form form=new AddItemFrm();
			if(form.ShowDialog() == DialogResult.OK)
            {
                var rows = this.AsControl<ComboBox>("cmdNumberRows").AsNumber<int>();
                this.ShowItemList(this.dataItemList);
            }
		}

        private void ItemListFrm_Load(object sender, EventArgs e)
        {
            this.ShowItemList(this.dataItemList);
            //         dataItemList.ClearSelection();
        }

        private void cmdNumberRows_SelectedIndexChanged(object sender, EventArgs e)
        {
			//var rows = this.AsControl<ComboBox>("cmdNumberRows").AsNumber<int>();
   //         var sortBy =string.IsNullOrEmpty(this.AsControl<ComboBox>("cmbSortBy").Text)?"Name": this.AsControl<ComboBox>("cmbSortBy").Text;
   //         this.ShowItemList(rows,sortBy);
		}

        private void tlsEdit_Click(object sender, EventArgs e)
        {
            if (dataItemList.Rows.Count > 0)
            {
				var index = dataItemList.CurrentRow.Index;
				var itemType = dataItemList.AsValue<string>(index, "Column3");
                if (itemType == "Bill Of Quantity")
                {
                    var id = dataItemList.AsNumber<long>(index, "Column1");
                    Form updateBoqForm = new UpdateBoqItemFrm(id);
                    updateBoqForm.ShowDialog();
                }
                else
                {
                    var id = dataItemList.AsNumber<long>(index, "Column1");
                    Form formAdd = new UpdateItemFrm(id);
                    if (formAdd.ShowDialog() == DialogResult.OK)
                    {
                        this.ShowItemList();
                        dataItemList.Rows[index].Selected = true;
                    }
                }
				
            }
        }

        private void tlsRefresh_Click(object sender, EventArgs e)
        {
            var rows = this.AsControl<ComboBox>("cmdNumberRows").AsNumber<int>();
            var sortBy = string.IsNullOrEmpty(this.AsControl<ComboBox>("cmbSortBy").Text) ? "Name" : this.AsControl<ComboBox>("cmbSortBy").Text;
            this.ShowItemList(rows, sortBy);
        }

        private void tlsdelete_Click(object sender, EventArgs e)
        {
            if (dataItemList.Rows.Count > 0)
            {
                var index = dataItemList.CurrentRow.Index;
                var id = dataItemList.AsNumber<long>(index, "Column1");

                if(MessageBox.Show("Do you want to delete this item?",
                    "Confirn", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (this.DeleteItem(id)){
                        var rows = this.AsControl<ComboBox>("cmdNumberRows").AsNumber<int>();
                        this.ShowItemList(rows);
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
            var textField = string.IsNullOrEmpty(cmbFieldName.Text.Trim()) ? "Name" : cmbFieldName.Text.Trim();
            if (string.IsNullOrEmpty(textField))
            {
                var rows = this.AsControl<ComboBox>("cmdNumberRows").AsNumber<int>();
                var sortBy = string.IsNullOrEmpty(this.AsControl<ComboBox>("cmbSortBy").Text) ? "Name" : this.AsControl<ComboBox>("cmbSortBy").Text;
                this.ShowItemList(rows, sortBy);
                return;
            }
            if(textField == "Cost" || textField=="Price" || textField=="IsActive")
            {
                var textValue = textSearch.GetVale<decimal>();
                if (this.SearchByFieldName(textField, textValue, out DataTable table))
                {
                    table.AsDataGrid(this.dataItemList);
                    return;
                }
                else
                {
                    ((DataTable)dataItemList.DataSource).Rows.Clear();
                }
            }
            else
            {
                var textValue = textSearch.GetVale<string>();
                if (this.SearchByFieldName(textField, textValue, out DataTable table))
                {
                    table.AsDataGrid(this.dataItemList);
                    return;
                }
                else
                {
                    var rows = this.AsControl<ComboBox>("cmdNumberRows").AsNumber<int>();
                    var sortBy = string.IsNullOrEmpty(this.AsControl<ComboBox>("cmbSortBy").Text) ? "Name" : this.AsControl<ComboBox>("cmbSortBy").Text;
                    this.ShowItemList(rows, sortBy);
                    return;
                }
            }
        }

        private void textSearch_KeyUp(object sender, KeyEventArgs e)
        {

            this.ShowItemList(this.dataItemList,((TextBox)sender).Text);
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

        private void tlCreateACopy_Click(object sender, EventArgs e)
        {
            if (dataItemList.Rows.Count > 0)
            {
                var index = dataItemList.CurrentRow.Index;
                var itemType = dataItemList.AsValue<string>(index, "Column3");
                if (itemType == "Bill Of Quantity")
                {
                    var id = dataItemList.AsNumber<long>(index, "Column1");
                    CreateACopyBoqItemFrm updateBoqForm = new CreateACopyBoqItemFrm(id);
                    if (updateBoqForm.ShowDialog() == DialogResult.OK)
                    {
                        var rows = this.AsControl<ComboBox>("cmdNumberRows").AsNumber<int>();
                        var sortBy = string.IsNullOrEmpty(this.AsControl<ComboBox>("cmbSortBy").Text) ? "Name" : this.AsControl<ComboBox>("cmbSortBy").Text;
                        this.ShowItemList(rows, sortBy);
                    }
                }
                else
                {
                    var id = dataItemList.AsNumber<long>(index, "Column1");
                    Form formAdd = new CreateACopyItemFrm(id);
                    if (formAdd.ShowDialog() == DialogResult.OK)
                    {
                        this.ShowItemList();
                        dataItemList.Rows[index].Selected = true;
                    }
                }

            }
        }

        private void dataItemList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (dataItemList.Rows.Count == 0) return;
            //if (dataItemList.AsBealean("Column12"))
            //{
            //    toolStripButton5.Text = "Make InActive";
            //}
            //else
            //{
            //    toolStripButton5.Text = "Make Active";
            //}
        }
    }
}
