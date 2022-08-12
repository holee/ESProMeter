using ESProMeter.Controllers;
using ESProMeter.Extensions;
using ESProMeter.IViews;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ESProMeter.Views.Boq
{
    public partial class CreateBoQ_Step2_Frm : Form, ITBOQ
    {
        #region private
        private DateTime _createdAt = DateTime.UtcNow;
        private DateTime _updatedAt = DateTime.UtcNow;
        private byte _isActive = 1;
        private long _divId = 0;
        private string _refnumber = string.Empty;
        private int _edit = 0;
        private int _status = 1;
        private long _uid = 0;
        private bool toggle = false;
        int dragRow = -1;
        Label dragLabel = null;
        private Rectangle dragBoxFromMouseDown;
        private int rowIndexFromMouseDown;
        private int rowIndexOfItemUnderMouseToDrop;
        #endregion
        #region properties
        public long ID
        {
            get => lblID.AsNumber<long>();
            set => lblID.SetText(value);
        }
        public DateTime CDT
        {
            get => _createdAt;
            set => _createdAt = value;
        }
        public DateTime MDT
        {
            get => _updatedAt;
            set => _updatedAt = value;
        }
        public int EDSEQ
        {
            get => _edit;
            set => _edit = value;
        }
        public string REFNUMBER
        {
            get => _refnumber;
            set => _refnumber = value;
        }
        public string BOQTITLE
        {
            get => txtBOQTitle.Text.Trim();
            set => txtBOQTitle.SetText(value);
        }
        public string BOQDESC
        {
            get => txtBOQDesc.Text.Trim();
            set => txtBOQDesc.SetText(value);
        }
        public long CUSTOMERID
        {
            get => cboCustomerName.AsNumber<long>(true);
            set => cboCustomerName.SelectedValue = value;
        }
        public DateTime BOQDATE
        {
            get => dtpDate.Value;
            set => dtpDate.Value = value;
        }
        public DateTime VALIDDATE
        {
            get => dtpValidDate.Value;
            set => dtpValidDate.Value = value;
        }
        public byte ISACTIVE
        {
            get => _isActive;
            set => _isActive = value;
        }
        public long SITEID
        {
            get => cboSite.AsNumber<long>();
            set => cboSite.SelectedValue = value;
        }
        public long DIVID
        {
            get => _divId;
            set => _divId = value;
        }
        public string TERMSCONDITION
        {
            get => txtTermsCondition.Text.Trim();
            set => txtTermsCondition.SetText(value);
        }
        public int STATUS
        {
            get => _status;
            set => _status = value;
        }
        public long UID
        {
            get => _uid;
            set => _uid = value;
        }
        #endregion



        public CreateBoQ_Step2_Frm()
        {
            InitializeComponent();
            this.cboCustomerName.LostFocus += (s, e) =>
            {
                if (cboCustomerName.SelectedValue == null && cboCustomerName.Text.Length > 0)
                {
                    if (MessageBox.Show("there is not any customer in system.", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Views.Customers.CustomerCreateFrm form = new Views.Customers.CustomerCreateFrm();
                        form.NAME = cboCustomerName.Text;
                        if (this.CustomerCreate(form, out var id))
                        {
                            this.FillCustomerCmb(cboCustomerName);
                            this.cboCustomerName.SelectedValue = id;
                        }
                        else
                        {
                            this.FillCustomerCmb(cboCustomerName);
                        }
                    }
                }
            };
            this.cboSite.LostFocus += (s, e) =>
            {
                if (cboSite.SelectedValue == null && cboSite.Text.Length > 0)
                {
                    if (MessageBox.Show("there is not any Site in system.", "Bill Of Qauntity", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Sites.AddSiteFrm form = new Sites.AddSiteFrm();
                        if (cboCustomerName.SelectedValue != null)
                        {
                            form.SITENAME = cboSite.Text;
                            form.CUSTOMERID = cboCustomerName.AsNumber<long>(true);
                            if (this.SiteCreateNewOrUpdate(form, out var id))
                            {
                                this.FillSitesCmbByCustomer(cboCustomerName.AsNumber<long>(true), cboSite);
                                this.cboSite.SelectedValue = id;
                            }
                        }

                    }
                    else return;
                }
            };
        }
        public CreateBoQ_Step2_Frm(long id)
        {
            InitializeComponent();
            this.FillCustomerCmb(cboCustomerName);
            this.FillSitesCmb(cboSite);
            this.BoqGetById(id, this);
            this.cboCustomerName.LostFocus += (s, e) =>
            {
                if (cboCustomerName.SelectedValue == null && cboCustomerName.Text.Length > 0)
                {
                    if (MessageBox.Show("there is not any customer in system.", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Views.Customers.CustomerCreateFrm form = new Views.Customers.CustomerCreateFrm();
                        form.NAME = cboCustomerName.Text;
                        if (this.CustomerCreate(form, out var id))
                        {
                            this.FillCustomerCmb(cboCustomerName);
                            this.cboCustomerName.SelectedValue = id;
                        }
                        else
                        {
                            this.FillCustomerCmb(cboCustomerName);
                        }
                    }
                }
            };
        }
        /// <summary>
        /// Key Press event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        private void txtBOQDesc_Enter(object sender, EventArgs e)
        {
            txtBOQDesc.BringToFront();
            txtBOQDesc.Height = 97;
        }

        private void txtBOQDesc_Leave(object sender, EventArgs e)
        {
            txtBOQDesc.Height = 23;
        }

        private void txtTermsCondition_Leave(object sender, EventArgs e)
        {
            txtTermsCondition.Height = 23;
            txtTermsCondition.Top = this.Height - 49;
        }

        private void txtTermsCondition_Enter(object sender, EventArgs e)
        {
            txtTermsCondition.BringToFront();
            txtTermsCondition.Height = 127;
            txtTermsCondition.Top = this.Height - 153;
        }

        private void CreateBoQ_Step2_Frm_Activated(object sender, EventArgs e)
        {
            //this.txtTermsCondition.Top = this.Height - 50;
        }

        private void cboCustomerName_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvBoqList.Rows[e.RowIndex].Cells["uom"].Value == null 
                && dgvBoqList.Rows[e.RowIndex].Cells["BOQITEMQTY"].Value == null)
            {
                dgvBoqList.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.DarkSeaGreen;
                dgvBoqList.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Red;
                dgvBoqList.Rows[e.RowIndex].DefaultCellStyle.Font=new Font("Segoe UI", 12,FontStyle.Bold);
            }
        }

    

        private void txtItemBoqSearch_KeyUp(object sender, KeyEventArgs e)
        {
            var searchText = ((TextBox)sender).Text.Trim();
            this.GetBoqItems(dgvItem, searchText, "ID", "ItemName", "Description", "ItemType", "Uom", "UomID");
        }


        /// <summary>
        /// DataGridView Events
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvItem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvItem.SelectedRows.Count > 0)
            {
                var selectedRow = dgvItem.SelectedRows[0];
                var _itemName = selectedRow.GetValue<string>("ItemNameColumn1");
                var _description = selectedRow.GetValue<string>("DescriptionColumn1");
                var _uom = selectedRow.GetValue<string>("UomColumn1");
                var _uomId = selectedRow.GetValue<long>("UomIDColumn1");
                var _id = selectedRow.GetValue<long>("ItemID");
                var _boqId = lblID.AsNumber<long>();
                if (dgvBoqList.SelectedRows.Count == 0)
                {
                    dgvBoqList.Rows.Add(null,_boqId, _id, _itemName, _description, Utility.NumberString(1, "N2"), _uom, _uomId);
                }
                else
                {
                    var index = dgvBoqList.SelectedRows[0].Index;
                    dgvBoqList.Rows.Insert(index, null,_boqId, _id, _itemName, _description, Utility.NumberString(1, "N2"), _uom, _uomId);
                }
            }
            if (toggle)
            {
                pnlSearch.SendToBack();
                pnlSearch.Hide();
                toggle = false;
                materialButton3.IconChar = FontAwesome.Sharp.MaterialIcons.ChevronUpBox;
            }
            dgvBoqList.ClearSelection();
        }
        private void dataGridView1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dgvBoqList.SelectedRows.Count <= 0) return;
            if (e.Button == MouseButtons.Left && dragLabel != null)
            {
                dragLabel.Location = e.Location;
            }
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                // If the mouse moves outside the rectangle, start the drag.
                if (dragBoxFromMouseDown != Rectangle.Empty &&
                !dragBoxFromMouseDown.Contains(e.X, e.Y))
                {
                    // Proceed with the drag and drop, passing in the list item.                    
                    DragDropEffects dropEffect = dgvBoqList.DoDragDrop(
                          dgvBoqList.Rows[rowIndexFromMouseDown],
                          DragDropEffects.Move);
                }
            }
        }
        private void dataGridView1_MouseDown(object sender, MouseEventArgs e)
        {
            if (dgvBoqList.SelectedRows.Count <= 0) return;
            // Get the index of the item the mouse is below.
            this.dgvBoqList.Cursor = Cursors.SizeAll;
            rowIndexFromMouseDown = dgvBoqList.HitTest(e.X, e.Y).RowIndex;
            if (rowIndexFromMouseDown != -1)
            {
                Size dragSize = SystemInformation.DragSize;
                dragBoxFromMouseDown = new Rectangle(
                          new Point(
                            e.X - (dragSize.Width / 2),
                            e.Y - (dragSize.Height / 2)),
                      dragSize);
            }
            else
                // Reset the rectangle if the mouse is not over an item in the ListBox.
                dragBoxFromMouseDown = Rectangle.Empty;
        }

        private void dataGridView1_DragOver(object sender, DragEventArgs e)
        {
            if (dgvBoqList.SelectedRows.Count > 0)
            {
                e.Effect = DragDropEffects.Move;
            }
        }
        private void dataGridView1_DragDrop(object sender, DragEventArgs e)
        {
            Point clientPoint = dgvBoqList.PointToClient(new Point(e.X, e.Y));
            // Get the row index of the item the mouse is below. 
            rowIndexOfItemUnderMouseToDrop = dgvBoqList.HitTest(clientPoint.X, clientPoint.Y).RowIndex;

            if (rowIndexOfItemUnderMouseToDrop ==- 1 
                || rowIndexOfItemUnderMouseToDrop >= dgvBoqList.Rows.Count-1)
            {
                return;
            }
                // If the drag operation was a move then remove and insert the row.

                if (e.Effect == DragDropEffects.Move)
            {
                try
                {
                        DataGridViewRow rowToMove = e.Data.GetData(typeof(DataGridViewRow)) as DataGridViewRow;
                        dgvBoqList.Rows.RemoveAt(rowIndexFromMouseDown);
                        dgvBoqList.Rows.Insert(rowIndexOfItemUnderMouseToDrop, rowToMove);
                        dgvBoqList.Rows[rowIndexOfItemUnderMouseToDrop].Selected = true;
                        if (dragLabel != null)
                        {
                            dragLabel.Dispose();
                            dragLabel = null;
                        }
                }
                catch
                {

                }

            }
        }
        private void dgvBoqList_MouseUp(object sender, MouseEventArgs e)
        {
            if (dgvBoqList.SelectedRows.Count <= 0) return;
           
            if (dragLabel != null)
            {
                dragLabel.Dispose();
                dragLabel = null;
            }
        }

      

        private void dgvBoqList_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex < 0 || e.RowIndex < 0) return;
            dragRow = e.RowIndex;
            if (dragLabel == null)
                dragLabel = new Label();
                dragLabel.Width = dgvBoqList.Width /2;
                dragLabel.Text = dgvBoqList.Rows[e.RowIndex].Cells["BOQITEMDESC"].Value.ToString();
                dragLabel.Parent = dgvBoqList;
                dragLabel.Location = e.Location;
        }



        private void dgvBoqList_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            for (int i = 0; i < dgvBoqList.RowCount; i++)
            {
                dgvBoqList.SetText(i, "Column2", i+1);
            }
            
        }
        private void dgvBoqList_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvBoqList.Columns[e.ColumnIndex].Name == "BOQITEMQTY")
            {
                if (dgvBoqList.Rows[e.RowIndex].Cells["BOQITEMQTY"].Value == null)
                {
                    dgvBoqList.SetText(e.RowIndex, "BOQITEMQTY", Utility.NumberString(0, "N2"));
                }
                else
                {
                    var value = dgvBoqList.GetValue<decimal>(e.RowIndex, "BOQITEMQTY");
                    dgvBoqList.NumberFormat(e.RowIndex, "BOQITEMQTY", value, "N2");
                }
            }
        }
        private void dgvBoqList_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dgvBoqList.Columns["BOQITEMQTY"].Name== "BOQITEMQTY"
                && dgvBoqList.Columns["BOQITEMQTY"] is DataGridViewTextBoxColumn)
            {
                TextBox qauntityTextBox = e.Control as TextBox;
                qauntityTextBox.KeyPress += TextBoxKeyPress;
            }
        }

        /// <summary>
        /// Button Events
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mbtAddSite_Click(object sender, EventArgs e)
        {
            if (cboCustomerName.SelectedValue == null)
            {
                MessageBox.Show("Please select customer.", "BOQ", MessageBoxButtons.OK);
                return;
            }
            var customerId = cboCustomerName.SelectedValue;
            Views.Sites.AddSiteFrm form = new Sites.AddSiteFrm(customerId);
            if (form.ShowDialog() == DialogResult.OK)
            {
                this.SiteCreateNewOrUpdate(form, form, Enums.ActionType.CREATE);
                this.FillSitesCmbByCustomer(cboCustomerName.AsNumber<long>(true), cboSite);
            }
        }
        private void mbtAddCustomer_Click(object sender, EventArgs e)
        {
            Views.Customers.CustomerCreateFrm form = new Customers.CustomerCreateFrm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                this.CustomerCreate(form, out var id);
                this.FillCustomerCmb(cboCustomerName);
                this.cboCustomerName.SelectedValue = id;
            }
        }
        private void materialButton1_Click(object sender, EventArgs e)
        {
            this.BoqLineCreate(dgvBoqList);
            this.BoqUpdate(this);
            this.ClearForm();
        }

        private void materialButton3_MouseClick(object sender, MouseEventArgs e)
        {
            if (!toggle)
            {
                pnlSearch.BackColor = Color.Transparent;
                pnlSearch.BorderStyle = BorderStyle.None;
                pnlSearch.Height = 200;
                pnlSearch.Location = new Point(materialButton3.Location.X - (pnlSearch.Width - materialButton3.Width), materialButton3.Location.Y + materialButton3.Height);
                pnlSearch.BringToFront();
                pnlSearch.Show();
                toggle = true;
                this.GetBoqItems(dgvItem, null, "ID", "ItemName", "Description", "ItemType", "Uom", "UomID");
                materialButton3.IconChar = FontAwesome.Sharp.MaterialIcons.ChevronDownBox;
            }
            else
            {
                pnlSearch.SendToBack();
                pnlSearch.Hide();
                toggle = false;
                materialButton3.IconChar = FontAwesome.Sharp.MaterialIcons.ChevronUpBox;
            }
        }

        private void mbtCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddSection_Click(object sender, EventArgs e)
        {
            if (toggle)
            {
                pnlSearch.SendToBack();
                pnlSearch.Hide();
                toggle = false;
                materialButton3.IconChar = FontAwesome.Sharp.MaterialIcons.ChevronUpBox;
            }
            var _boqId = lblID.AsNumber<long>();
            SectionFrm form = new SectionFrm();
            if (form.ShowDialog(this) == DialogResult.OK)
            {
                if (dgvBoqList.SelectedRows.Count == 0)
                {
                    dgvBoqList.Rows.Add(null, _boqId, 1, null, form.SectionText);
                }
                else
                {
                    var index = dgvBoqList.SelectedRows[0].Index;
                    dgvBoqList.Rows.Insert(index + 1, null, _boqId, index, null, form.SectionText);
                }

                dgvBoqList.ClearSelection();
            }
        }

    }
}

//int dragRow = -1;
//Label dragLabel = null;
//private void dataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
//{
//    if (e.ColumnIndex < 0 || e.RowIndex < 0) return;
//    dragRow = e.RowIndex;
//    if (dragLabel == null) dragLabel = new Label();
//    dragLabel.Text = dataGridView1[e.ColumnIndex, e.RowIndex].Value.ToString();
//    dragLabel.Parent = dataGridView1;
//    dragLabel.Location = e.Location;
//}

//private void dataGridView1_MouseMove(object sender, MouseEventArgs e)
//{
//    if (e.Button == MouseButtons.Left && dragLabel != null)
//    {
//        dragLabel.Location = e.Location;
//        dataGridView1.ClearSelection();
//    }
//}
//private void dataGridView1_MouseUp(object sender, MouseEventArgs e)
//{
//    var hit = dataGridView1.HitTest(e.X, e.Y);
//    int dropRow = -1;
//    if (hit.Type != DataGridViewHitTestType.None)
//    {
//        dropRow = hit.RowIndex;
//        if (dragRow >= 0)
//        {
//            int tgtRow = dropRow + (dragRow > dropRow ? 1 : 0);
//            if (tgtRow != dragRow)
//            {
//                DataGridViewRow row = dataGridView1.Rows[dragRow];
//                dataGridView1.Rows.Remove(row);
//                dataGridView1.Rows.Insert(tgtRow, row);

//                dataGridView1.ClearSelection();
//                row.Selected = true;
//            }
//        }
//    }
//    else { dataGridView1.Rows[dragRow].Selected = true; }

//    if (dragLabel != null)
//    {
//        dragLabel.Dispose();
//        dragLabel = null;
//    }
//}

//if (tgtRow != dragRow)
//{
//    DataRow dtRow = DT.Rows[dragRow];
//    DataRow newRow = DT.NewRow();
//    newRow.ItemArray = DT.Rows[dragRow].ItemArray; // we need to clone the values

//    DT.Rows.Remove(dtRow);
//    DT.Rows.InsertAt(newRow, tgtRow);
//    dataGridView1.Refresh();
//    dataGridView1.Rows[tgtRow].Selected = true;
//}


//this.dgvBoqList.Cursor = Cursors.Default;
//var hit = dgvBoqList.HitTest(e.X, e.Y);
//int dropRow = -1;
//if (hit.Type != DataGridViewHitTestType.None)
//{
//    //dropRow = hit.RowIndex;
//    //if (dragRow >= 0)
//    //{
//    //    int tgtRow = dropRow + (dragRow > dropRow ? 1 : 0);
//    //    if (tgtRow != dragRow)
//    //    {
//    //        DataGridViewRow row = dgvBoqList.Rows[dragRow];
//    //        dgvBoqList.Rows.Remove(row);
//    //        dgvBoqList.Rows.Insert(tgtRow, row);
//    //        dgvBoqList.ClearSelection();
//    //        row.Selected = true;
//    //    }
//    //}
//}
//else { 
//    //dgvBoqList.Rows[dragRow].Selected = true; 
//}
