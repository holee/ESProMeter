using ESProMeter.Controllers;
using ESProMeter.Extensions;
using ESProMeter.IViews;
using ESProMeter.Services;
using ESProMeter.Sessions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using static ESProMeter.Extensions.FormExtension;
namespace ESProMeter.Views.Boq
{
    public partial class CreateBoQ_Step2_Frm : Form, ITBOQ
    {
        #region private
        int order = 1;
        int sectionIndex = 1;
        bool isNewRowAdded = false;
        bool isRowMoved = false;
        private DateTime _createdAt = DateTime.UtcNow;
        private DateTime _updatedAt = DateTime.UtcNow;
        private byte _isActive = 1;
        private long _divId = 0;
        private string _refnumber = string.Empty;
        private int _status = 1;
        private long _uid = 0;
        private bool toggle = false;
        DataGridView dragGrid = null;
        private Rectangle dragBoxFromMouseDown;
        private int rowIndexFromMouseDown;
        private int rowIndexOfItemUnderMouseToDrop;
        private decimal _loe;
        private decimal _op;
        private decimal _over;
        private decimal _safty;
        private decimal _tran;
        private decimal _margin;
        private decimal _inflation;
        private DataTable TempTable;
        private List<object> _obj=new List<object>();
        private bool isCompleted=false;
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
            get => lblEDSEQ.AsNumber<int>();
            set => lblEDSEQ.SetText(value);
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
            get => cboSite.AsNumber<long>(true);
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
        public decimal LOSSOFEFFECIENCYRATE
        {
            get
            {
                return _loe;
            }
            set => _loe = value;
        }
        public decimal OPERATIONRATE
        {
            get
            {
                return _op;
            }
            set => _op = value;
        }
        public decimal OVERHEADRATE
        {
            get
            {
                return _over;
            }
            set => _over = value;
        }
        public decimal SAFETYRATE
        {
            get
            {
                return _safty;
            }
            set => _safty = value;
        }
        public decimal TRANSPORTATIONRATE
        {
            get
            {
                return _tran;
            }
            set => _tran = value;
        }
        public decimal MARGINRATE
        {
            get
            {
                return _margin;
            }
            set => _margin = value;
        }
        public decimal INFlATIONRATE
        {
            get
            {
                return _inflation;
            }
            set => _inflation = value;
        }
        #endregion

        public CreateBoQ_Step2_Frm()
        {
            InitializeComponent();
        }
        public CreateBoQ_Step2_Frm(long id, Enums.ActionType type)
        {
            InitializeComponent();
            SetDoubleBuffer(dgvBoqList, true);
            this.FillCustomerCmb(cboCustomerName);
            if (this.BoqGetById(id, out var boq))
            {
                this.ID = id;
                this.BOQDESC = boq.BOQDESC;
                this.BOQTITLE = boq.BOQTITLE;
                this.BOQDATE = boq.BOQDATE;
                this.VALIDDATE = boq.VALIDDATE;
                this.EDSEQ = boq.EDSEQ;
                this.UID = boq.UID;
                this.STATUS = boq.STATUS;
                this.SITEID = boq.SITEID;
                this.CUSTOMERID = boq.CUSTOMERID;
                this.BOQDESC = boq.BOQDESC;
                this.MDT = boq.MDT;
                this.CDT = boq.CDT;
                this.TERMSCONDITION = boq.TERMSCONDITION;
                this.REFNUMBER = boq.REFNUMBER;
                this.ISACTIVE = boq.ISACTIVE;
                this.LOSSOFEFFECIENCYRATE = boq.LOSSOFEFFECIENCYRATE;
                this.OPERATIONRATE = boq.OPERATIONRATE;
                this.OVERHEADRATE = boq.OVERHEADRATE;
                this.SAFETYRATE = boq.SAFETYRATE;
                this.MARGINRATE = boq.MARGINRATE;
                this.INFlATIONRATE = boq.INFlATIONRATE;
                this.TRANSPORTATIONRATE = boq.TRANSPORTATIONRATE;
                this.FillSitesCmbByCustomer(boq.CUSTOMERID, cboSite);
                this.cboSite.SelectedValue = boq.SITEID;
            }
            switch (type)
            {
                case Enums.ActionType.EDIT:
                    this.BoqLineGetById(id, this.dgvBoqList);
                    order = this.dgvBoqList.RowCount == 0 ? 1 : this.dgvBoqList.Rows.Count+1;
                    btnSaveAndClose.Text = "Update && Close";
                    btnSaveAndNew.Visible = false;
                    break;
                default:
                    break;
            }
            this.cboCustomerName.LostFocus += (s, e) =>
            {
                if (cboCustomerName.SelectedValue == null && cboCustomerName.Text.Length > 0)
                {
                    if (MessageBox.Show("there is not any customer in system, Do you want to add new one?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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
                    if (MessageBox.Show(@"there is not any Site in system,\n Do you want to add new.", "Bill Of Qauntity", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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
            switch (type)
            {
                case Enums.ActionType.CREATE:
                    btnSaveAndClose.Click += (s, e) =>
                    {
                        BoqLineCreateOrUpdateThenClose(s, e, type);
                    };
                    btnSaveAndNew.Click += (s, e) =>
                    {
                        BoqLineCreateOrUpdateThenNew(s, e, type);
                    };
                    break;
                case Enums.ActionType.EDIT:
                    btnSaveAndClose.Click += (s, e) =>
                    {
                        BoqLineCreateOrUpdateThenClose(s, e, type);
                    };
                    btnSaveAndNew.Click += (s, e) =>
                    {
                        BoqLineCreateOrUpdateThenNew(s, e, type);
                    };
                    break;
                default:
                    break;
            }



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
            txtTermsCondition.Location = new Point(label4.Location.X + label4.Width + 10, label4.Location.Y - 3);
        }
        private void txtTermsCondition_Enter(object sender, EventArgs e)
        {
            txtTermsCondition.BringToFront();
            txtTermsCondition.Multiline = true;
            txtTermsCondition.Height = 200;
            txtTermsCondition.Top = label4.Top - 180;
        }
        private void txtItemBoqSearch_KeyUp(object sender, KeyEventArgs e)
        {
            var searchText = ((TextBox)sender).Text.Trim();
            this.GetBoqItems(dgvItem, searchText, "ID", "ItemName", "Description", "ItemType", "Uom", "UomID", "BOQCOST");
        }
        /// <summary>
        /// DataGridView Events
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        private void dgvBoqListCellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach (DataGridViewRow item in dgvBoqList.Rows)
            {
                if (item.GetText("uom").Equals(string.Empty))
                {
                    item.DefaultCellStyle.BackColor = Color.Yellow;
                    item.DefaultCellStyle.ForeColor = Color.Black;
                }
            }

            if (dgvBoqList.Columns[e.ColumnIndex].Name == "BOQITEMQTY")
            {
                if(e.Value != null)
                {
                    e.CellStyle.Format = "N3";
                }
            }

        }
        private void dgvBoqListCellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvBoqList?.SelectedRows.Count > 0)
            {
                var selectedRow = dgvBoqList.SelectedRows[0];
                var selectedText = selectedRow.GetText("ITEMNAME");
                if (selectedText.Equals("Section") || selectedText == string.Empty)
                {
                    dgvBoqList.Rows[e.RowIndex].Cells["BOQITEMQTY"].ReadOnly = true;
                    dgvBoqList.Rows[e.RowIndex].Cells["UOM"].ReadOnly = true;
                }
            }

        }
        private void dgvItemCellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvItem.SelectedRows.Count == 0) return;
            var selectedRow = dgvItem.SelectedRows[0];
            var _itemName = selectedRow.GetValue<string>("ItemNameColumn1");
            var _description = selectedRow.GetValue<string>("DescriptionColumn1");
            var _uom = selectedRow.GetValue<string>("UomColumn1");
            var _uomId = selectedRow.GetValue<long>("UomIDColumn1");
            var _id = selectedRow.GetValue<long>("ItemID");
            var _boqId = lblID.AsNumber<long>();
            var _boqcost = selectedRow.GetValue<decimal>("Column2");
            var userId = Properties.Settings.Default.curLoggedUID;
            if (dgvBoqList.SelectedRows.Count == 0)
            {
                CreateTempValues(ref _obj, "", _boqId, _id, _description, _uomId, 1, null, userId,
             _boqcost, this.LOSSOFEFFECIENCYRATE, this.OPERATIONRATE,
             this.OVERHEADRATE, this.SAFETYRATE, this.TRANSPORTATIONRATE,
             this.MARGINRATE, this.INFlATIONRATE, order);
                ///Add
                ///
                isNewRowAdded = true;
                dgvBoqList.Rows.Add(null, _boqId, _id, _itemName, _description, Utility.NumberString(1, "N2"), _uom, _uomId,
                    null, _boqcost, order, this.LOSSOFEFFECIENCYRATE, this.OPERATIONRATE,
                       this.OVERHEADRATE, this.SAFETYRATE, this.TRANSPORTATIONRATE, this.MARGINRATE, this.INFlATIONRATE, 0);
                CreateTempTable(ref TempTable, _obj.ToArray());
                this.BoqLineTempCreateOrUpdate(TempTable, Enums.ActionType.CREATE);
                order++;
                
            }else
            {
                var index = dgvBoqList.SelectedRows[0].Index + 1;
                CreateTempValues(ref _obj, "", _boqId, _id, _description, _uomId, 1, null, userId,
                                _boqcost, this.LOSSOFEFFECIENCYRATE, this.OPERATIONRATE,
                                this.OVERHEADRATE, this.SAFETYRATE, this.TRANSPORTATIONRATE,
                                this.MARGINRATE, this.INFlATIONRATE, order);
                CreateTempTable(ref TempTable, _obj.ToArray());
                this.BoqLineTempCreateOrUpdate(TempTable, Enums.ActionType.CREATE);
                ///Add
                ///
                isNewRowAdded = true;
                dgvBoqList.Rows.Insert(index, null, _boqId, _id, _itemName, _description, Utility.NumberString(1, "N2"), _uom, _uomId,
                    null, _boqcost, order, this.LOSSOFEFFECIENCYRATE, this.OPERATIONRATE,
                    this.OVERHEADRATE, this.SAFETYRATE, this.TRANSPORTATIONRATE,
                    this.MARGINRATE, this.INFlATIONRATE, 0);
                order++;
                dgvBoqList.Rows[index].Selected = true;
                
            }
            if (toggle)
            {
                pnlSearch.SendToBack();
                pnlSearch.Hide();
                toggle = false;
                materialButton3.IconChar = FontAwesome.Sharp.MaterialIcons.ChevronUpBox;
            }
            //dgvBoqList.ClearSelection();
        }
        private void CreateTempTable(ref DataTable table,params object[] values)
        {
            table = new System.Data.DataTable();
            table.Columns.Add("NO", typeof(string));
            table.Columns.Add("BOQID", typeof(long));
            table.Columns.Add("BOQITEMID", typeof(long));
            table.Columns.Add("BOQITEMDESC", typeof(string));
            table.Columns.Add("BOQITEMUOMID", typeof(long));
            table.Columns.Add("BOQITEMQTY", typeof(decimal));
            table.Columns.Add("REMARKS", typeof(string));
            table.Columns.Add("UID", typeof(long));
            table.Columns.Add("BOQCOST", typeof(decimal));
            table.Columns.Add("LOSSEFFECENCYRATE", typeof(decimal));
            table.Columns.Add("OPERATIONRATE", typeof(decimal));
            table.Columns.Add("OVERHEADRATE", typeof(decimal));
            table.Columns.Add("SAFETYRATE", typeof(decimal));
            table.Columns.Add("TRANSPORTATIONRATE", typeof(decimal));
            table.Columns.Add("MARGINRATE", typeof(decimal));
            table.Columns.Add("INFlATIONRATE", typeof(decimal));
            table.Columns.Add("LineSeq", typeof(int));
            DataRow row = table.NewRow();
            if (values.Length == table.Columns.Count)
            {
                for (int i = 0; i < values.Length; i++)
                {
                    row[i] = values[i];
                }
                table.Rows.Add(row);
            }
        }
        private void CreateTempValues(ref List<object> obj,params object[] values)
        {
            obj = new();
            obj.AddRange(values);
        }
        private void dataGridViewMouseMove(object sender, MouseEventArgs e)
        {
            if (dgvBoqList.SelectedRows.Count <= 0) return;
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                //dataGridView1.Parent = dgvBoqList;
                //dataGridView1.Location =new Point(e.Location.X +50,e.Location.Y);
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
        private void dataGridViewMouseDown(object sender, MouseEventArgs e)
        {
            if (dgvBoqList.SelectedRows.Count <= 0) return;

            // Get the index of the item the mouse is below.
            //this.dgvBoqList.Cursor = Cursors.SizeAll;
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
        private void dataGridViewDragOver(object sender, DragEventArgs e)
        {
            if (dgvBoqList.SelectedRows.Count > 0)
            {
                e.Effect = DragDropEffects.Move;
            }
        }
        private void dataGridViewDragDrop(object sender, DragEventArgs e)
        {
            Point clientPoint = dgvBoqList.PointToClient(new Point(e.X, e.Y));
            // Get the row index of the item the mouse is below. 
            rowIndexOfItemUnderMouseToDrop = dgvBoqList.HitTest(clientPoint.X, clientPoint.Y).RowIndex;

            if (rowIndexOfItemUnderMouseToDrop == -1
                || rowIndexOfItemUnderMouseToDrop > dgvBoqList.Rows.Count - 1)
            {
                return;
            }
            // If the drag operation was a move then remove and insert the row.

            if (e.Effect == DragDropEffects.Move)
            {
                try
                {
                    isRowMoved = true;
                    DataGridViewRow rowToMove = e.Data.GetData(typeof(DataGridViewRow)) as DataGridViewRow;
                    dgvBoqList.Rows.RemoveAt(rowIndexFromMouseDown);
                    dgvBoqList.Rows.Insert(rowIndexOfItemUnderMouseToDrop, rowToMove);
                    dgvBoqList.Rows[rowIndexOfItemUnderMouseToDrop].Selected = true;
                    
                    if (dragGrid != null)
                    {
                        dragGrid.Dispose();
                        dragGrid = null;
                    }
                }
                catch
                {

                }
                finally
                {
                    if (dragGrid != null)
                    {
                        dragGrid.Dispose();
                        dragGrid = null;
                    }
                }
            }
        }
        private void dgvBoqListMouseUp(object sender, MouseEventArgs e)
        {
            if (dgvBoqList.SelectedRows.Count <= 0) return;
            if (dragGrid != null)
            {
                dragGrid.Dispose();
                dragGrid = null;
            }
        }
        private void dgvBoqListCellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            //if (e.ColumnIndex < 0 || e.RowIndex < 0) return;
            //dragRow = e.RowIndex;
            //if (dragGrid == null)
            //    dragGrid = new DataGridView();
            //    dragGrid.AllowUserToAddRows = false;
            //    dragGrid.Width = dgvBoqList.Width;
            //    dragGrid.ColumnHeadersVisible = false;
            //    dragGrid.RowHeadersVisible = false;
            //    dragGrid.ScrollBars = ScrollBars.None;
            //    dragGrid.Height = 30;
            //    dragGrid.Columns.Add("A", null);
            //    dragGrid.Columns.Add("C", null);
            //    dragGrid.Columns.Add("B", null);
            //    dragGrid.Columns.Add("A1", null);
            //    dragGrid.Columns.Add("C1", null);
            //    dragGrid.Columns.Add("B1", null);
            //    dragGrid.Columns.Add("A2", null);
            //    dragGrid.Columns.Add("C3", null);
            //    dragGrid.Columns.Add("B4", null);
            //    dragGrid.Columns.Add("A5", null);
            //    dragGrid.Columns.Add("C6", null);
            //    dragGrid.Columns.Add("B7", null);
            //    DataGridViewRow drag = (DataGridViewRow)dgvBoqList.Rows[e.RowIndex].Clone();
            //    dragGrid.Rows?.Clear();
            //    dragGrid.Rows.Add(drag);
            //    dragGrid.Parent = dgvBoqList;
            ////dragGrid.Location = e.Location;
            //    dragGrid.Location =new Point(dgvBoqList.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex,true).Location.X+100, dgvBoqList.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true).Location.Y);

        }
        private void dgvBoqListRowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (isRowMoved || isNewRowAdded)
            {
                for (int i = 0; i < dgvBoqList.RowCount; i++)
                {
                    var boqId = lblID.AsNumber<long>();
                    var boqItemId = dgvBoqList.GetValue<long>(i, "BOQITEMID");
                    var oldOrder = dgvBoqList.GetValue<int>(i, "LineSeq");
                    dgvBoqList.SetText(i, "LineSeq", i + 1);
                    var newOrder = i + 1;
                    AppService.GetBoqInstance.BoqLineChangedOrder(boqId, boqItemId, oldOrder, newOrder);
                }
            }
            
        }
        private void dgvBoqListRowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            if (!isRowMoved)
            {
                for (int i = 0; i < dgvBoqList.Rows.Count; i++)
                {
                    var boqId = lblID.AsNumber<long>();
                    var boqItemId = dgvBoqList.GetValue<long>(i, "BOQITEMID");
                    var oldOrder = dgvBoqList.GetValue<int>(i, "LineSeq");
                    dgvBoqList.SetText(i, "LineSeq", i + 1);
                    var newOrder = i + 1;
                    AppService.GetBoqInstance.BoqLineChangedOrder(boqId, boqItemId, oldOrder, newOrder);
                }
            }
        }
        private void dgvBoqListCellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvBoqList.SelectedRows.Count <= 0) return;
            if (dgvBoqList.Columns[e.ColumnIndex].Name == "ACTION"
                && dgvBoqList.Columns[e.ColumnIndex] is DataGridViewImageColumn)
            {
                var selectedRow = dgvBoqList.SelectedRows[0];
                var selectedText = selectedRow.GetText("UOM");
                if (selectedText != string.Empty)
                {
                    var boq_id = selectedRow.GetValue<long>("BOQID");
                    var boq_itemId = selectedRow.GetValue<long>("BOQITEMID");
                    var iscompleted = selectedRow.GetValue<int>("COMPLETED");
                    var seq = selectedRow.GetValue<int>("LineSeq");
                    AppService.GetBoqInstance.AdditinalCostGet(boq_id, boq_itemId, out var additionalCost);
                    BOQLINEFrm form = new BOQLINEFrm(boq_id, boq_itemId,iscompleted,seq, additionalCost);
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        dgvBoqList.SetText(e.RowIndex, "LOSSEFFECENCYRATE1", form.LOSSOFEFFECIENCYRATE);
                        dgvBoqList.SetText(e.RowIndex, "OPERATIONRATE1", form.OPERATIONRATE);
                        dgvBoqList.SetText(e.RowIndex, "OVERHEADRATE1", form.OVERHEADRATE);
                        dgvBoqList.SetText(e.RowIndex, "TRANSPORTATIONRATE1", form.TRANSPORTATIONRATE);
                        dgvBoqList.SetText(e.RowIndex, "MARGINRATE1", form.MARGINRATE);
                        dgvBoqList.SetText(e.RowIndex, "INFlATIONRATE1", form.INFlATIONRATE);
                        dgvBoqList.SetText(e.RowIndex, "SAFETYRATE1", form.SAFETYRATE);
                    }
                }
                else
                {
                    var sectionName = selectedRow.GetText("ITEMNAME");
                    var description = selectedRow.GetText("BOQITEMDESC");
                    var index = selectedRow.Index;
                    SectionFrm form = new SectionFrm();
                    form.NameText = sectionName;
                    form.DescriptionText = description.Split(":").Length > 1 ? description.Split(":")[1] : description;
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        if (dgvBoqList.SelectedRows.Count > 0)
                        {
                            dgvBoqList.SetText(index, "ITEMNAME", form.NameText);
                            dgvBoqList.SetText(index, "BOQITEMDESC", form.ToString());
                        }
                    }
                }
            }
            if (dgvBoqList.Columns[e.ColumnIndex].Name == "REMOVE"
                && dgvBoqList.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
            {
                if (dgvBoqList.SelectedRows.Count == 0) return;
                var selectedRow = dgvBoqList.SelectedRows[0];
                var boqId = lblID.AsNumber<long>();
                var boqItemId = dgvBoqList.GetValue<long>(e.RowIndex, "BOQITEMID");
                var seq = dgvBoqList.GetValue<int>(e.RowIndex, "LineSeq");
                //var iscomplete = dgvBoqList.GetValue<int>(e.RowIndex, "COMPLETED");
                if (AppService.GetBoqInstance.BoqLineTempDelete(boqId, boqItemId, seq))
                {
                    dgvBoqList.Rows.Remove(selectedRow);
                    order = this.dgvBoqList.RowCount == 0 ? 1 : this.dgvBoqList.Rows.Count + 1;
                    //do something here
                    return;
                }

                if(AppService.GetBoqInstance
                                .DeleteSection(boqId, seq)){
                    dgvBoqList.Rows.Remove(selectedRow);
                    order = this.dgvBoqList.RowCount == 0 ? 1 : this.dgvBoqList.Rows.Count + 1;
                    return;
                }

                
            }
        }
        private void dgvBoqList_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvBoqList.Columns[e.ColumnIndex].Name == "BOQITEMQTY")
            {
                if (dgvBoqList.Rows[e.RowIndex].Cells["BOQITEMQTY"].Value == null)
                {
                    dgvBoqList.SetText(e.RowIndex, "BOQITEMQTY", Utility.NumberString(0, "N3"));
                }
                else
                {
                    var value = dgvBoqList.GetValue<decimal>(e.RowIndex, "BOQITEMQTY");
                    dgvBoqList.NumberFormat(e.RowIndex, "BOQITEMQTY", value, "N3");
                }
            }

            if (dgvBoqList.Columns[e.ColumnIndex].Name == "NO")
            {
                var textNo = dgvBoqList.GetValue<string>(e.RowIndex, "NO");
                var txtDesc = dgvBoqList.GetValue<string>(e.RowIndex, "BOQITEMDESC");
                var txtRemark = dgvBoqList.GetValue<string>(e.RowIndex, "REMARKS");
                var txtBoqID = lblID.AsNumber<long>();
                var BoqItemRefId = dgvBoqList.GetValue<long>(e.RowIndex, "BOQITEMID");
                var qty = dgvBoqList.GetValue<decimal>(e.RowIndex, "BOQITEMQTY");
                var iscomplete = dgvBoqList.GetValue<int>(e.RowIndex, "COMPLETED");
                var order = dgvBoqList.GetValue<int>(e.RowIndex, "LineSeq");
                AppService.GetBoqInstance
                            .BoqLineTempChanged(txtBoqID, BoqItemRefId, textNo, txtDesc, txtRemark,qty,order,iscomplete);
            
            }

            if (dgvBoqList.Columns[e.ColumnIndex].Name == "BOQITEMDESC")
            {
                var textNo = dgvBoqList.GetValue<string>(e.RowIndex, "NO");
                var txtDesc = dgvBoqList.GetValue<string>(e.RowIndex, "BOQITEMDESC");
                var txtRemark = dgvBoqList.GetValue<string>(e.RowIndex, "REMARKS");
                var txtBoqID = lblID.AsNumber<long>();
                var BoqItemRefId = dgvBoqList.GetValue<long>(e.RowIndex, "BOQITEMID");
                var qty = dgvBoqList.GetValue<decimal>(e.RowIndex, "BOQITEMQTY");
                var iscomplete = dgvBoqList.GetValue<int>(e.RowIndex, "COMPLETED");
                var order = dgvBoqList.GetValue<int>(e.RowIndex, "LineSeq");
                AppService.GetBoqInstance
                            .BoqLineTempChanged(txtBoqID, BoqItemRefId, textNo, txtDesc, txtRemark,qty,order, iscomplete);
            }
            if (dgvBoqList.Columns[e.ColumnIndex].Name == "REMARKS")
            {
                var textNo = dgvBoqList.GetValue<string>(e.RowIndex, "NO");
                var txtDesc = dgvBoqList.GetValue<string>(e.RowIndex, "BOQITEMDESC");
                var txtRemark = dgvBoqList.GetValue<string>(e.RowIndex, "REMARKS");
                var txtBoqID = lblID.AsNumber<long>();
                var BoqItemRefId = dgvBoqList.GetValue<long>(e.RowIndex, "BOQITEMID");
                var qty= dgvBoqList.GetValue<decimal>(e.RowIndex, "BOQITEMQTY");
                var iscomplete = dgvBoqList.GetValue<int>(e.RowIndex, "COMPLETED");
                var order = dgvBoqList.GetValue<int>(e.RowIndex, "LineSeq");
                AppService.GetBoqInstance
                            .BoqLineTempChanged(txtBoqID, BoqItemRefId, textNo, txtDesc, txtRemark,qty,order, iscomplete);
            }
            if (dgvBoqList.Columns[e.ColumnIndex].Name == "BOQITEMQTY")
            {
                var textNo = dgvBoqList.GetValue<string>(e.RowIndex, "NO");
                var txtDesc = dgvBoqList.GetValue<string>(e.RowIndex, "BOQITEMDESC");
                var txtRemark = dgvBoqList.GetValue<string>(e.RowIndex, "REMARKS");
                var txtBoqID = lblID.AsNumber<long>();
                var BoqItemRefId = dgvBoqList.GetValue<long>(e.RowIndex, "BOQITEMID");
                var qty = dgvBoqList.GetValue<decimal>(e.RowIndex, "BOQITEMQTY");
                var iscomplete = dgvBoqList.GetValue<int>(e.RowIndex, "COMPLETED");
                var order = dgvBoqList.GetValue<int>(e.RowIndex, "LineSeq");
                AppService.GetBoqInstance
                            .BoqLineTempChanged(txtBoqID, BoqItemRefId, textNo, txtDesc, txtRemark,qty,order, iscomplete);
            }


        }
        private void dgvBoqListEditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= TextBoxKeyPress;
            if (dgvBoqList.Columns[dgvBoqList.CurrentCell.ColumnIndex].Name == "BOQITEMQTY"
                && dgvBoqList.Columns[dgvBoqList.CurrentCell.ColumnIndex] is DataGridViewTextBoxColumn)
            {
                var qauntityTextBox = e.Control as TextBox;
                if (qauntityTextBox == null) return;
                qauntityTextBox.KeyPress += TextBoxKeyPress;
            }
        }
        private void dgvBoqListSelectionChanged(object sender, EventArgs e)
        {
            
        }

        private void dgvBoqList_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvBoqList.SelectedRows.Count > 0)
            {
                var selectedRow = dgvBoqList.SelectedRows[0];
                if (selectedRow.GetValue<int>("BOQITEMID") == 0)
                {
                    dgvBoqList.Rows[e.RowIndex].DefaultCellStyle.SelectionBackColor = Color.Yellow;
                }
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
                cboCustomerName.DroppedDown = true;
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
        private void BoqLineCreateOrUpdateThenClose(object sender, EventArgs e, Enums.ActionType type)
        {
            try
            {
                Form openForm = Application.OpenForms[nameof(BOQListFrm)];
                this.BoqUpdate(this);
                //this.BoqLineCreateOrUpdate(dgvBoqList, type);
                if (this.Migrate(lblID.AsNumber<long>()) && isNewRowAdded)
                {
                    this.Close();
                    if (openForm != null)
                    {
                        openForm.Refresh();
                    }
                    return;
                }
                if (isRowMoved)
                {
                    this.Close();
                    if (openForm != null)
                    {
                        openForm.Refresh();
                    }
                    return;
                }
                if (!isNewRowAdded && !isRowMoved)
                {
                    if(MessageBox.Show("There is no any changed in BOQ LIST.Do you want to close it?", "BOQ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        this.Close();
                    }
                    return;
                }

                


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Bill Of Qauntity");
            }

        }
        private void BoqLineCreateOrUpdateThenNew(object sender, EventArgs e, Enums.ActionType type)
        {
            try
            {
                this.BoqUpdate(this);
                //this.BoqLineCreateOrUpdate(dgvBoqList, type);
                this.Migrate(lblID.AsNumber<long>());
                dgvBoqList.Rows?.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Bill Of Qauntity");
            }

        }
        private void materialButton3_MouseClick(object sender, MouseEventArgs e)
        {
            txtItemBoqSearch.Clear();
            if (!toggle)
            {
                pnlSearch.BackColor = Color.Transparent;
                pnlSearch.BorderStyle = BorderStyle.None;
                pnlSearch.Height = 200;
                pnlSearch.Location = new Point(materialButton3.Location.X - (pnlSearch.Width - materialButton3.Width), materialButton3.Location.Y + materialButton3.Height);
                pnlSearch.BringToFront();
                pnlSearch.Show();
                txtItemBoqSearch.Focus();
                toggle = true;
                this.GetBoqItems(dgvItem, null, "ID", "ItemName", "Description", "ItemType", "Uom", "UomID", "BOQCOST");
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
            if (isNewRowAdded)
            {
                if (MessageBox.Show("There are any changed in BOQ LIST.Do you want to close it?", "BOQ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    this.Unmigrate(lblID.AsNumber<long>());
                    this.Close();
                }
            }
            if (!isNewRowAdded)
            {
                this.Close();
            }
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
            var userId = Properties.Settings.Default.curLoggedUID;
            SectionFrm form = new SectionFrm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                if (dgvBoqList.SelectedRows.Count == 0)
                {

                    dgvBoqList.Rows.Add(sectionIndex, _boqId,0, form.NameText, form.ToString(),"","","","","",order);

                    //Add Section
                    AppService.GetBoqInstance.CreateSection($"{sectionIndex}", _boqId, order, form.ToString());
                    sectionIndex++;
                    order++;
                }
                else
                {
                    var index = dgvBoqList.SelectedRows[0].Index;
                    dgvBoqList.Rows.Insert(index + 1, sectionIndex, _boqId, 0, form.NameText, form.ToString(), "", "", "", "", "", order);

                    //Add section

                    AppService.GetBoqInstance.CreateSection($"{sectionIndex}", _boqId, order, form.ToString());
                    sectionIndex++;
                    order++;
                }

                dgvBoqList.ClearSelection();
            }
        }
        private void materialButton3_Click(object sender, EventArgs e)
        {

        }
        private void CreateBoQ_Step2_Frm_Load(object sender, EventArgs e)
        {
            this.dgvBoqList.ClearSelection();
            this.dgvBoqList.CurrentCell = null;

        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Views.Items.AddItemFrm form = new Views.Items.AddItemFrm(0, Enums.ItemsType.Boq, Enums.ActionType.CREATE);
            //form.cmbType.text = 'Bill of Quantity';
            var userId = Properties.Settings.Default.curLoggedUID;
            if (form.ShowDialog() != DialogResult.OK) return;
            var item = this.BoqItemCreate(form);
            if (item == null) return;
            var _boqId = lblID.AsNumber<long>();
            if (dgvBoqList.SelectedRows.Count == 0)
            {
                dgvBoqList.Rows.Add(null, _boqId, item.ID, item.ITEMNAME, item.DESCRIPTION, Utility.NumberString(1, "N2"),
                    item.UOM, item.UOMID, null, item.BOGCOST, order, this.LOSSOFEFFECIENCYRATE, this.OPERATIONRATE,
                       this.OVERHEADRATE, this.SAFETYRATE, this.TRANSPORTATIONRATE, this.MARGINRATE, this.INFlATIONRATE);
                //Add
                CreateTempValues(ref _obj, "", _boqId, item.ID, item.DESCRIPTION, item.UOMID, 1, null, userId,
                           item.BOGCOST, this.LOSSOFEFFECIENCYRATE, this.OPERATIONRATE,
                           this.OVERHEADRATE, this.SAFETYRATE, this.TRANSPORTATIONRATE,
                           this.MARGINRATE, this.INFlATIONRATE, order);
                CreateTempTable(ref TempTable, _obj.ToArray());
                this.BoqLineTempCreateOrUpdate(TempTable, Enums.ActionType.CREATE);
                order++;
                isNewRowAdded = true;
            }else
            {
                var index = dgvBoqList.SelectedRows[0].Index + 1;
                dgvBoqList.Rows.Insert(index, null, _boqId, item.ID, item.ITEMNAME, item.DESCRIPTION, Utility.NumberString(1, "N2"), item.UOM, item.UOMID,
                    null, item.BOGCOST, order, this.LOSSOFEFFECIENCYRATE, this.OPERATIONRATE,
                       this.OVERHEADRATE, this.SAFETYRATE, this.TRANSPORTATIONRATE, this.MARGINRATE, this.INFlATIONRATE);
                //

                CreateTempValues(ref _obj, "", _boqId, item.ID, item.DESCRIPTION, item.UOMID, 1, null, userId,
                           item.BOGCOST, this.LOSSOFEFFECIENCYRATE, this.OPERATIONRATE,
                           this.OVERHEADRATE, this.SAFETYRATE, this.TRANSPORTATIONRATE,
                           this.MARGINRATE, this.INFlATIONRATE, order);
                CreateTempTable(ref TempTable, _obj.ToArray());
                this.BoqLineTempCreateOrUpdate(TempTable, Enums.ActionType.CREATE);
                order++;
                dgvBoqList.Rows[index].Selected = true;
                isNewRowAdded = true;
            }
            if (toggle)
            {
                pnlSearch.SendToBack();
                pnlSearch.Hide();
                toggle = false;
                materialButton3.IconChar = FontAwesome.Sharp.MaterialIcons.ChevronUpBox;
            }
        }

        
    }
}

