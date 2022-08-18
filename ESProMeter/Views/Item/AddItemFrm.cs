using ESProMeter.Controllers;
using ESProMeter.Enums;
using ESProMeter.Extensions;
using ESProMeter.IVews;
using ESProMeter.Views.UnitOfMeasures;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace ESProMeter.Views.Items
{
    public partial class AddItemFrm : Form, ITItem
    {
        #region fields
        private bool toggle = false;
        private DateTime _createdAt = DateTime.Now;
        private DateTime _updatedAt = DateTime.Now;
        private byte _isRate = 0;
        internal DataTable boqTable;
        private DataTable labourTable;
        private DataTable machinaryTable;
        private DataTable materialTable;
        private int sesquence = 1;
        public ItemsType ItemTypes { get; set; }
        public ActionStatus ActionStatus { get; set; }
        #endregion
        #region Properties
        public string ITEMNAME
        {
            get => textName.Text.Trim();
            set => textName.SetText(value);
        }
        public string ITEMTYPE
        {
            get => cmbType.Text;
            set => cmbType.Text = value;
        }
        public long UOMID
        {
            get => (long)cmbUom.SelectedValue;
            set => cmbUom.SelectedValue = value;
        }
        public decimal COST
        {
            get => textCost.AsNumber<decimal>();
            set => textCost.SetText(value);
        }
        public string DESCRIPTION
        {
            get => textDescription.Text.Trim();
            set => textDescription.SetText(value);
        }
        public byte ISACTIVE
        {
            get => chkIsInActive.Checked ? (byte)0 : (byte)1;
            set => chkIsInActive.Checked = value == 0 ? true : false;
        }
        public long ID
        {
            get => lblItemID.AsNumber<long>();
            set => lblItemID.SetText(value);
        }

        public byte ISRATE
        {
            get => _isRate;
            set => _isRate = value;
        }
        public int EDSEQ
        {
            get => lblEditSequence.AsNumber<int>();
            set => lblEditSequence.SetText(value);
        }
        public DateTime? CDT
        {
            get => _createdAt;
            set => _createdAt = value.Value;
        }
        public DateTime? MDT
        {
            get => _updatedAt;
            set => _updatedAt = value.Value;
        }
        #endregion
        public AddItemFrm()
        {
            InitializeComponent();
            this.ShowItemType(this.cmbType);
            this.ShowUom(this.cmbUom);
            CreateTable(ref labourTable);
            CreateTable(ref materialTable);
            CreateTable(ref machinaryTable);
            CreateTable(ref boqTable);
            btnSave.Text = "Save";
            pnlSearch.SendToBack();
            pnlSearch.Hide();

            groupBoq.MouseDown += GroupBoq_MouseDown;
            GENERAL.MouseDown += GroupBoq_MouseDown;
            groupBox2.MouseDown += GroupBoq_MouseDown;
        }

        private void GroupBoq_MouseDown(object sender, MouseEventArgs e)
        {
            if (toggle)
            {
                pnlSearch.Hide();
                pnlSearch.SendToBack();
                textBox1.Text = "";
                toggle = false;
                btndropDown.IconChar = FontAwesome.Sharp.MaterialIcons.ChevronUpBox;
                this.tabControl1.Enabled = true;
            }
        }
        public AddItemFrm(long Id, ItemsType itemType, ActionType action)
        {
            InitializeComponent();
            groupBoq.MouseDown += GroupBoq_MouseDown;
            GENERAL.MouseDown += GroupBoq_MouseDown;
            groupBox2.MouseDown += GroupBoq_MouseDown;
            this.ShowItemType(this.cmbType);
            this.ShowUom(this.cmbUom);
            if (Id == 0)
            {
                CreateTable(ref labourTable);
                CreateTable(ref materialTable);
                CreateTable(ref machinaryTable);
                CreateTable(ref boqTable);
                cmbType.SelectedIndex = 3;
                cmbType.Enabled = false;
                btnSave.Text = "Save";
                cmbType.Enabled = false;
                pnlSearch.SendToBack();
                pnlSearch.Hide();
            }
            else
            {
                this.GetItemForUpdate(itemType, Id, this);
                switch (action)
                {
                    case ActionType.EDIT:
                        CreateTempTable();
                        cmbType.Enabled = false;
                        btnSave.Text = "Update";
                        break;
                    case ActionType.CreateACopy:
                        CreateTempTable();
                        cmbType.Enabled = false;
                        btnSave.Text = "Save";
                        break;
                    default:
                        break;
                }
            }
            if (this.ActionStatus == ActionStatus.Edit)
            {
                cmbType.Enabled = false;
            }

            pnlSearch.SendToBack();
            pnlSearch.Hide();
        }
      
        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            var searchText = ((TextBox)sender).Text.Trim();
            if (tabControl1.SelectedIndex == 0)
            {
                this.SearchByItemType(searchText, "Labour");

            }else if (tabControl1.SelectedIndex == 1)
            {
                this.SearchByItemType(searchText, "Machinery");
            }
            else if (tabControl1.SelectedIndex == 2)
            {
                this.SearchByItemType(searchText, "Material");
            }
        }
        void SearchByItemType(string itemName,string itemType="Labour")
        {
            ((DataTable)dgvItem.DataSource)?.Clear();
            if (itemName.Length > 0)
            {
                this.GetItemsWithoutBoqByName(itemName, itemType, dgvItem, "ID", "ItemName", "ItemType", "Uom", "UomID", "Cost");
            }
            else
            {
                this.GetItemsWithoutBoqByName(null, itemType, dgvItem, "ID", "ItemName", "ItemType", "Uom", "UomID", "Cost");
            }
        }
        private void ShowItemForm()
        {
            this.groupBoq.Visible = false;
            this.Controls.RemoveByKey(groupBoq.Name);
            this.Height = 300;
            this.textCost.Enabled = true;
            this.btnSave.Location = new Point(479, 224);
            this.materialButton2.Location = new Point(559, 224);
        }
        private void ShowBoqForm()
        {
            this.groupBoq.Visible = true;
            this.Controls.Add(this.groupBoq);
            this.Height = 594;
            this.textCost.Enabled = false;
            this.btnSave.Location = new Point(475, 511);
            this.materialButton2.Location = new Point(555, 511);
        }
        private void AddItemFrm_Load(object sender, EventArgs e)
        {
            switch (ItemTypes)
            {
                case Enums.ItemsType.Boq:
                    ShowBoqForm();
                    break;
                case Enums.ItemsType.Item:
                    ShowItemForm();
                    break;
                default:
                    break;
            }
        }
        private void materialButton2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.None;
            this.Close();
        }
        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbType.SelectedIndex == 3)
            {
                ShowBoqForm();
                this.ItemTypes = ItemsType.Boq;
            }
            else
            {
                this.ItemTypes = ItemsType.Item;
                ShowItemForm();
            }
        }
        private void dgvBoq_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }
        private bool CheckItemExist(ref DataTable table,object value)
        {
            if (table.Rows.Count == 0) return false;
            foreach (DataRow item in table.Rows)
            {
                if (item["BOQITEMLINEID"] == null) continue;
                if (item["BOQITEMLINEID"].Equals(value))
                {
                    return true;
                }

            }
            return false;
        }
        private void materialButton1_Click(object sender, EventArgs e)
        {

            if (cmbType.Text=="BillOfQuantity")
            {
                if (this.IsValid(textName, textDescription))
                {
                    labourTable.Merge(machinaryTable);
                    materialTable.Merge(labourTable);
                    boqTable.Merge(materialTable);
                    dgvBoq.DataSource = boqTable;
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Please fill(*) all required fields.", "Add New Item", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.None;
                }
            }
            else
            {
                if (this.IsValid(textName, textDescription, textCost))
                {
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Please fill required fields.", "Add New Item", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.None;
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
        private void btndropDown_MouseClick(object sender, MouseEventArgs e)
        {
            if (!toggle)
            {
                pnlSearch.BackColor = Color.Transparent;
                pnlSearch.BorderStyle = BorderStyle.None;
                //pnlSearch.PointToClient
                pnlSearch.Height = 200;
                pnlSearch.PointToClient(new Point(btndropDown.Location.X + btndropDown.Width - pnlSearch.Width, btndropDown.Location.Y + 100));
                pnlSearch.BringToFront();
                pnlSearch.Show();
                toggle = true;
                btndropDown.IconChar = FontAwesome.Sharp.MaterialIcons.ChevronDownBox;
                ((DataTable)dgvItem.DataSource)?.Clear();
                if(tabControl1.SelectedIndex == -0)
                {
                    this.GetItemsWithoutBoq(dgvItem,"Labour", "ID", "ItemName", "ItemType", "Uom", "UomID", "Cost");
                }
                else if (tabControl1.SelectedIndex == 1)
                {
                    this.GetItemsWithoutBoq(dgvItem, "Machinery", "ID", "ItemName", "ItemType", "Uom", "UomID", "Cost");
                }
                else if (tabControl1.SelectedIndex == 2)
                {
                    this.GetItemsWithoutBoq(dgvItem,"Material", "ID", "ItemName", "ItemType", "Uom", "UomID", "Cost");
                }
                
                dgvBoq.SendToBack();
            }
            else
            {
                pnlSearch.SendToBack();
                pnlSearch.Hide();
                toggle = false;
                btndropDown.IconChar = FontAwesome.Sharp.MaterialIcons.ChevronUpBox;
            }
        }
        private void AddItemFrm_MouseClick(object sender, MouseEventArgs e)
        {
            if (toggle)
            {
                pnlSearch.Hide();
                pnlSearch.SendToBack();
                textBox1.Text = "";
                toggle = false;
                btndropDown.IconChar = FontAwesome.Sharp.MaterialIcons.ChevronUpBox;
                this.tabControl1.Enabled = true;
            }
        }
        private void btnUomCreate_Click(object sender, EventArgs e)
        {
            AddUoMFrm form = new AddUoMFrm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    this.AddOrUpdate(ActionType.CREATE, form);
                    this.ShowUom(this.cmbUom);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                    return;
                }

            }
        }
        private void dgvItem_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvItem.SelectedRows.Count > 0)
            {
                var selectedRow = dgvItem.SelectedRows[0];
                var itemRow = ((DataRowView)dgvItem.SelectedRows[0].DataBoundItem).Row;
                var id = selectedRow.GetValue<long>("ItemID");
                if (tabControl1.SelectedIndex == 0)
                {
                    if (CheckItemExist(ref labourTable,id))
                    {
                        textBox1.Text = "";
                        MessageBox.Show("Item Already exist in the list", "ESPRO-METER", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    this.Add(labourTable, itemRow[0], 
                            itemRow[1], itemRow[2], 
                            itemRow[3], itemRow[4],
                            Utility.NumberString(1, "N2"), sesquence);

                    dgvLabor.DataSource = labourTable;
                }
                else if (tabControl1.SelectedIndex == 1)
                {
                    if (CheckItemExist(ref machinaryTable,id))
                    {
                        textBox1.Text = "";
                        MessageBox.Show("Item Already exist in the list", "ESPRO-METER", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    this.Add(machinaryTable, itemRow[0],
                           itemRow[1], itemRow[2],
                           itemRow[3], itemRow[4],
                           Utility.NumberString(1, "N2"), sesquence);
                    dgvMachinary.DataSource = machinaryTable;
                }
                else if (tabControl1.SelectedIndex == 2)
                {
                    if (CheckItemExist(ref materialTable,id))
                    {
                        textBox1.Text = "";
                        MessageBox.Show("Item Already exist in the list", "ESPRO-METER", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    this.Add(materialTable, itemRow[0],
                            itemRow[1], itemRow[2],
                            itemRow[3], itemRow[4],
                            Utility.NumberString(1, "N2"), sesquence);
                    dgvMaterial.DataSource = materialTable;
                }
                tabControl1.Enabled = true;
                sesquence++;
            }
            //------------------------------------
            toggle = false;
            pnlSearch.Hide();
            pnlSearch.SendToBack();
            textBox1.Text = "";
            btndropDown.IconChar = FontAwesome.Sharp.MaterialIcons.ChevronUpBox;
            
        }
        private void dgvMaterial_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvMaterial.Rows.Count> 0)
            {
                if (dgvMaterial.SelectedRows.Count == 0) return;
                if (dgvMaterial.Columns[e.ColumnIndex].Name== "ButtonColumn3"
                    && dgvMaterial.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
                {
                    var selectedRow = dgvMaterial.SelectedRows[0];
                    dgvMaterial.Rows.Remove(selectedRow);
                }
            }
        }
        private void dgvLabor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvLabor.Rows.Count > 0)
            {
                if (dgvLabor.SelectedRows.Count == 0) return;
                if (dgvLabor.Columns[e.ColumnIndex].Name == "ButtonColumn1"
                    && dgvLabor.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
                {
                    var selectedRow = dgvLabor.SelectedRows[0];
                    dgvLabor.Rows.Remove(selectedRow);
                }
            }
        }
        private void dgvMachinary_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvMachinary.Rows.Count > 0)
            {
                if (dgvMachinary.SelectedRows.Count == 0) return;
                if (dgvMachinary.Columns[e.ColumnIndex].Name == "ButtonColumn2"
                    && dgvMachinary.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
                {
                    var selectedRow = dgvMachinary.SelectedRows[0];
                    dgvMachinary.Rows.Remove(selectedRow);
                }
            }
        }
        private void textName_Leave(object sender, EventArgs e)
        {
            if (this.IsItemExist(textName.Text.Trim()))
            {
                MessageBox.Show("Item already exist", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textName.SelectAll();
                textName.Focus();
                return;
            }
        }
        private void Add(DataTable table, params object[] values)
        {
            if (values != null || values.Length > 0)
            {
                table.Rows.Add(values);
            }
        }
        private void CreateTable(ref DataTable table)
        {
            table = new DataTable();
            table.Columns.Add("BOQITEMLINEID", typeof(long));
            table.Columns.Add("BOQITEMITEMLINENAME", typeof(string));
            table.Columns.Add("BOQITEMITEMLINETYPE", typeof(string));
            table.Columns.Add("UOM", typeof(string));
            table.Columns.Add("BOQITEMLINEUOMID", typeof(long));
            table.Columns.Add("BOQITEMLINEQTY", typeof(decimal));
            table.Columns.Add("BOQITEMLINESEQ", typeof(int));
        }
        private void CreateTempTable()
        {
            if ((DataTable)dgvLabor?.DataSource == null)
            {
                CreateTable(ref labourTable);
            }
            else
            {
                labourTable = (DataTable)dgvLabor?.DataSource;
            }
            if ((DataTable)dgvMachinary.DataSource != null)
            {
                machinaryTable = (DataTable)dgvMachinary.DataSource;
            }
            else
            {
                CreateTable(ref machinaryTable);
            }
            if ((DataTable)dgvMaterial.DataSource != null)
            {
                materialTable = (DataTable)dgvMaterial.DataSource;
            }
            else
            {
                CreateTable(ref materialTable);
            }

            CreateTable(ref boqTable);
        }

        private void btndropDown_Click(object sender, EventArgs e)
        {
            this.tabControl1.Enabled = false;
        }

    }
}
















