
namespace ESProMeter.Views.Items
{
	partial class ItemListFrm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemListFrm));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			this.tlDelete = new System.Windows.Forms.ToolStrip();
			this.tlsNew = new System.Windows.Forms.ToolStripDropDownButton();
			this.tlsEdit = new System.Windows.Forms.ToolStripButton();
			this.tlsdelete = new System.Windows.Forms.ToolStripButton();
			this.tlCreateACopy = new System.Windows.Forms.ToolStripButton();
			this.tlsRefresh = new System.Windows.Forms.ToolStripButton();
			this.tlsActive = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
			this.excelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.textSearch = new System.Windows.Forms.TextBox();
			this.cmbFieldName = new System.Windows.Forms.ComboBox();
			this.dataItemList = new System.Windows.Forms.DataGridView();
			this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Active = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.cmbPage = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cbmSortType = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.tlDelete.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataItemList)).BeginInit();
			this.SuspendLayout();
			// 
			// tlDelete
			// 
			this.tlDelete.AutoSize = false;
			this.tlDelete.BackColor = System.Drawing.Color.Silver;
			this.tlDelete.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.tlDelete.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlsNew,
            this.tlsEdit,
            this.tlsdelete,
            this.tlCreateACopy,
            this.tlsRefresh,
            this.tlsActive,
            this.toolStripSeparator1,
            this.toolStripDropDownButton1});
			this.tlDelete.Location = new System.Drawing.Point(0, 0);
			this.tlDelete.Name = "tlDelete";
			this.tlDelete.Size = new System.Drawing.Size(949, 34);
			this.tlDelete.TabIndex = 0;
			this.tlDelete.Text = "toolStrip1";
			// 
			// tlsNew
			// 
			this.tlsNew.Image = ((System.Drawing.Image)(resources.GetObject("tlsNew.Image")));
			this.tlsNew.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tlsNew.Name = "tlsNew";
			this.tlsNew.Size = new System.Drawing.Size(60, 31);
			this.tlsNew.Text = "New";
			this.tlsNew.Click += new System.EventHandler(this.tslNewClick);
			// 
			// tlsEdit
			// 
			this.tlsEdit.Image = ((System.Drawing.Image)(resources.GetObject("tlsEdit.Image")));
			this.tlsEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tlsEdit.Name = "tlsEdit";
			this.tlsEdit.Size = new System.Drawing.Size(47, 31);
			this.tlsEdit.Text = "Edit";
			this.tlsEdit.Click += new System.EventHandler(this.tlsEdit_Click);
			// 
			// tlsdelete
			// 
			this.tlsdelete.Image = ((System.Drawing.Image)(resources.GetObject("tlsdelete.Image")));
			this.tlsdelete.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tlsdelete.Name = "tlsdelete";
			this.tlsdelete.Size = new System.Drawing.Size(60, 31);
			this.tlsdelete.Text = "Delete";
			this.tlsdelete.Click += new System.EventHandler(this.tlsdelete_Click);
			// 
			// tlCreateACopy
			// 
			this.tlCreateACopy.Image = ((System.Drawing.Image)(resources.GetObject("tlCreateACopy.Image")));
			this.tlCreateACopy.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tlCreateACopy.Name = "tlCreateACopy";
			this.tlCreateACopy.Size = new System.Drawing.Size(92, 31);
			this.tlCreateACopy.Text = "Create Copy";
			this.tlCreateACopy.Click += new System.EventHandler(this.tlCreateACopy_Click);
			// 
			// tlsRefresh
			// 
			this.tlsRefresh.Image = ((System.Drawing.Image)(resources.GetObject("tlsRefresh.Image")));
			this.tlsRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tlsRefresh.Name = "tlsRefresh";
			this.tlsRefresh.Size = new System.Drawing.Size(66, 31);
			this.tlsRefresh.Text = "Refresh";
			this.tlsRefresh.Click += new System.EventHandler(this.tlsRefresh_Click);
			// 
			// tlsActive
			// 
			this.tlsActive.Image = ((System.Drawing.Image)(resources.GetObject("tlsActive.Image")));
			this.tlsActive.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tlsActive.Name = "tlsActive";
			this.tlsActive.Size = new System.Drawing.Size(100, 31);
			this.tlsActive.Text = "Make Inactive";
			this.tlsActive.Click += new System.EventHandler(this.tlMakeInActiveClick);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 34);
			// 
			// toolStripDropDownButton1
			// 
			this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.excelToolStripMenuItem});
			this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
			this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
			this.toolStripDropDownButton1.Size = new System.Drawing.Size(70, 31);
			this.toolStripDropDownButton1.Text = "Export";
			// 
			// excelToolStripMenuItem
			// 
			this.excelToolStripMenuItem.Name = "excelToolStripMenuItem";
			this.excelToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
			this.excelToolStripMenuItem.Text = "Excel";
			// 
			// textSearch
			// 
			this.textSearch.Location = new System.Drawing.Point(64, 36);
			this.textSearch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.textSearch.Name = "textSearch";
			this.textSearch.Size = new System.Drawing.Size(205, 23);
			this.textSearch.TabIndex = 1;
			this.textSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textSearch_KeyUp);
			// 
			// cmbFieldName
			// 
			this.cmbFieldName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbFieldName.FormattingEnabled = true;
			this.cmbFieldName.Items.AddRange(new object[] {
            "ItemName",
            "Uom",
            "Cost"});
			this.cmbFieldName.Location = new System.Drawing.Point(321, 37);
			this.cmbFieldName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.cmbFieldName.Name = "cmbFieldName";
			this.cmbFieldName.Size = new System.Drawing.Size(140, 23);
			this.cmbFieldName.TabIndex = 2;
			// 
			// dataItemList
			// 
			this.dataItemList.AllowUserToAddRows = false;
			this.dataItemList.AllowUserToDeleteRows = false;
			this.dataItemList.AllowUserToResizeColumns = false;
			this.dataItemList.AllowUserToResizeRows = false;
			this.dataItemList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataItemList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Transparent;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataItemList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dataItemList.ColumnHeadersHeight = 25;
			this.dataItemList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.dataItemList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Column2,
            this.Column3,
            this.Column7,
            this.Column4,
            this.Column5,
            this.Active,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column13});
			this.dataItemList.EnableHeadersVisualStyles = false;
			this.dataItemList.GridColor = System.Drawing.Color.IndianRed;
			this.dataItemList.Location = new System.Drawing.Point(14, 67);
			this.dataItemList.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.dataItemList.MultiSelect = false;
			this.dataItemList.Name = "dataItemList";
			this.dataItemList.ReadOnly = true;
			this.dataItemList.RowHeadersVisible = false;
			this.dataItemList.RowTemplate.Height = 25;
			this.dataItemList.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.dataItemList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataItemList.Size = new System.Drawing.Size(921, 439);
			this.dataItemList.TabIndex = 3;
			this.dataItemList.SelectionChanged += new System.EventHandler(this.dataItemList_SelectionChanged);
			// 
			// ID
			// 
			this.ID.DataPropertyName = "ID";
			this.ID.HeaderText = "ID";
			this.ID.MinimumWidth = 2;
			this.ID.Name = "ID";
			this.ID.ReadOnly = true;
			this.ID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.ID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.ID.Width = 2;
			// 
			// Column2
			// 
			this.Column2.DataPropertyName = "ItemName";
			this.Column2.FillWeight = 138.1693F;
			this.Column2.HeaderText = "Item Name";
			this.Column2.Name = "Column2";
			this.Column2.ReadOnly = true;
			this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.Column2.Width = 200;
			// 
			// Column3
			// 
			this.Column3.DataPropertyName = "ItemType";
			this.Column3.FillWeight = 65.11635F;
			this.Column3.HeaderText = "Type";
			this.Column3.Name = "Column3";
			this.Column3.ReadOnly = true;
			this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.Column3.Width = 94;
			// 
			// Column7
			// 
			this.Column7.DataPropertyName = "UomName";
			this.Column7.FillWeight = 62.71698F;
			this.Column7.HeaderText = "Uom Type";
			this.Column7.Name = "Column7";
			this.Column7.ReadOnly = true;
			this.Column7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.Column7.Width = 91;
			// 
			// Column4
			// 
			this.Column4.DataPropertyName = "Uom";
			this.Column4.FillWeight = 68.39866F;
			this.Column4.HeaderText = "Sub Uom Type";
			this.Column4.Name = "Column4";
			this.Column4.ReadOnly = true;
			this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.Column4.Width = 99;
			// 
			// Column5
			// 
			this.Column5.DataPropertyName = "Cost";
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			this.Column5.DefaultCellStyle = dataGridViewCellStyle2;
			this.Column5.FillWeight = 142.993F;
			this.Column5.HeaderText = "Cost";
			this.Column5.Name = "Column5";
			this.Column5.ReadOnly = true;
			this.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// Active
			// 
			this.Active.DataPropertyName = "IsActive";
			this.Active.FillWeight = 59.83959F;
			this.Active.HeaderText = "Active";
			this.Active.Name = "Active";
			this.Active.ReadOnly = true;
			this.Active.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.Active.Width = 87;
			// 
			// Column8
			// 
			this.Column8.DataPropertyName = "Description";
			this.Column8.FillWeight = 108.7606F;
			this.Column8.HeaderText = "Description";
			this.Column8.Name = "Column8";
			this.Column8.ReadOnly = true;
			this.Column8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.Column8.Width = 350;
			// 
			// Column9
			// 
			this.Column9.DataPropertyName = "EditSequense";
			this.Column9.HeaderText = "EditSequense";
			this.Column9.Name = "Column9";
			this.Column9.ReadOnly = true;
			this.Column9.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.Column9.Visible = false;
			// 
			// Column10
			// 
			this.Column10.DataPropertyName = "CreatedTime";
			this.Column10.HeaderText = "Create Time";
			this.Column10.Name = "Column10";
			this.Column10.ReadOnly = true;
			this.Column10.Visible = false;
			// 
			// Column11
			// 
			this.Column11.DataPropertyName = "ModifiedTime";
			this.Column11.HeaderText = "Modified Time";
			this.Column11.Name = "Column11";
			this.Column11.ReadOnly = true;
			this.Column11.Visible = false;
			// 
			// Column13
			// 
			this.Column13.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			this.Column13.DataPropertyName = "UOMID";
			this.Column13.HeaderText = "Column13";
			this.Column13.Name = "Column13";
			this.Column13.ReadOnly = true;
			this.Column13.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.Column13.Visible = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(14, 39);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(42, 15);
			this.label1.TabIndex = 4;
			this.label1.Text = "Search";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(280, 41);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(32, 15);
			this.label2.TabIndex = 6;
			this.label2.Text = "Field";
			// 
			// cmbPage
			// 
			this.cmbPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cmbPage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbPage.FormattingEnabled = true;
			this.cmbPage.Items.AddRange(new object[] {
            "50",
            "100",
            "200",
            "500",
            "1000"});
			this.cmbPage.Location = new System.Drawing.Point(884, 38);
			this.cmbPage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.cmbPage.Name = "cmbPage";
			this.cmbPage.Size = new System.Drawing.Size(51, 23);
			this.cmbPage.TabIndex = 2;
			this.cmbPage.SelectedIndexChanged += new System.EventHandler(this.cmbPage_SelectedIndexChanged);
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label3.Location = new System.Drawing.Point(785, 41);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(97, 15);
			this.label3.TabIndex = 6;
			this.label3.Text = "Number Of Row";
			this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.DataPropertyName = "ItemID";
			this.dataGridViewTextBoxColumn1.HeaderText = "ID";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn1.ReadOnly = true;
			this.dataGridViewTextBoxColumn1.Visible = false;
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
			this.dataGridViewTextBoxColumn2.FillWeight = 56.09832F;
			this.dataGridViewTextBoxColumn2.HeaderText = "Item Name";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn2.ReadOnly = true;
			this.dataGridViewTextBoxColumn2.Width = 200;
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.DataPropertyName = "Type";
			this.dataGridViewTextBoxColumn3.FillWeight = 62.73446F;
			this.dataGridViewTextBoxColumn3.HeaderText = "Type";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			this.dataGridViewTextBoxColumn3.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn4
			// 
			this.dataGridViewTextBoxColumn4.DataPropertyName = "Abbreviation";
			this.dataGridViewTextBoxColumn4.FillWeight = 1.584698F;
			this.dataGridViewTextBoxColumn4.HeaderText = "Abbreviation";
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			this.dataGridViewTextBoxColumn4.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn5
			// 
			this.dataGridViewTextBoxColumn5.DataPropertyName = "UomType";
			this.dataGridViewTextBoxColumn5.FillWeight = 125.7754F;
			this.dataGridViewTextBoxColumn5.HeaderText = "Cost";
			this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
			this.dataGridViewTextBoxColumn5.ReadOnly = true;
			this.dataGridViewTextBoxColumn5.Width = 200;
			// 
			// dataGridViewTextBoxColumn6
			// 
			this.dataGridViewTextBoxColumn6.DataPropertyName = "Cost";
			this.dataGridViewTextBoxColumn6.FillWeight = 253.8071F;
			this.dataGridViewTextBoxColumn6.HeaderText = "Price";
			this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
			this.dataGridViewTextBoxColumn6.ReadOnly = true;
			this.dataGridViewTextBoxColumn6.Width = 200;
			// 
			// dataGridViewTextBoxColumn7
			// 
			this.dataGridViewTextBoxColumn7.DataPropertyName = "price";
			this.dataGridViewTextBoxColumn7.FillWeight = 253.8071F;
			this.dataGridViewTextBoxColumn7.HeaderText = "Price";
			this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
			this.dataGridViewTextBoxColumn7.ReadOnly = true;
			this.dataGridViewTextBoxColumn7.Width = 200;
			// 
			// dataGridViewTextBoxColumn8
			// 
			this.dataGridViewTextBoxColumn8.DataPropertyName = "Description";
			this.dataGridViewTextBoxColumn8.HeaderText = "Description";
			this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
			this.dataGridViewTextBoxColumn8.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn9
			// 
			this.dataGridViewTextBoxColumn9.DataPropertyName = "EditSequense";
			this.dataGridViewTextBoxColumn9.HeaderText = "EditSequense";
			this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
			this.dataGridViewTextBoxColumn9.ReadOnly = true;
			this.dataGridViewTextBoxColumn9.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridViewTextBoxColumn9.Visible = false;
			// 
			// dataGridViewTextBoxColumn10
			// 
			this.dataGridViewTextBoxColumn10.DataPropertyName = "CreatedTime";
			this.dataGridViewTextBoxColumn10.HeaderText = "Create Time";
			this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
			this.dataGridViewTextBoxColumn10.ReadOnly = true;
			this.dataGridViewTextBoxColumn10.Visible = false;
			// 
			// dataGridViewTextBoxColumn11
			// 
			this.dataGridViewTextBoxColumn11.DataPropertyName = "ModifiedTime";
			this.dataGridViewTextBoxColumn11.HeaderText = "Modified Time";
			this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
			this.dataGridViewTextBoxColumn11.ReadOnly = true;
			this.dataGridViewTextBoxColumn11.Visible = false;
			// 
			// dataGridViewTextBoxColumn12
			// 
			this.dataGridViewTextBoxColumn12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			this.dataGridViewTextBoxColumn12.DataPropertyName = "UOMID";
			this.dataGridViewTextBoxColumn12.HeaderText = "Column13";
			this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
			this.dataGridViewTextBoxColumn12.ReadOnly = true;
			this.dataGridViewTextBoxColumn12.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridViewTextBoxColumn12.Visible = false;
			// 
			// cbmSortType
			// 
			this.cbmSortType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbmSortType.FormattingEnabled = true;
			this.cbmSortType.Items.AddRange(new object[] {
            "ASC",
            "DESC"});
			this.cbmSortType.Location = new System.Drawing.Point(662, 38);
			this.cbmSortType.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.cbmSortType.Name = "cbmSortType";
			this.cbmSortType.Size = new System.Drawing.Size(72, 23);
			this.cbmSortType.TabIndex = 2;
			this.cbmSortType.SelectedIndexChanged += new System.EventHandler(this.cmbSortBySelectedIndexChanged);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(601, 42);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(44, 15);
			this.label5.TabIndex = 6;
			this.label5.Text = "Sort By";
			// 
			// checkBox1
			// 
			this.checkBox1.AutoSize = true;
			this.checkBox1.Location = new System.Drawing.Point(483, 38);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(109, 19);
			this.checkBox1.TabIndex = 7;
			this.checkBox1.Text = "Include Inactive";
			this.checkBox1.UseVisualStyleBackColor = true;
			this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// ItemListFrm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(949, 519);
			this.Controls.Add(this.checkBox1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dataItemList);
			this.Controls.Add(this.cmbPage);
			this.Controls.Add(this.cbmSortType);
			this.Controls.Add(this.cmbFieldName);
			this.Controls.Add(this.textSearch);
			this.Controls.Add(this.tlDelete);
			this.DoubleBuffered = true;
			this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.Name = "ItemListFrm";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "Item List";
			this.Load += new System.EventHandler(this.ItemListFrm_Load);
			this.SizeChanged += new System.EventHandler(this.ItemListFrm_SizeChanged);
			this.tlDelete.ResumeLayout(false);
			this.tlDelete.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataItemList)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ToolStrip tlDelete;
		private System.Windows.Forms.ToolStripButton tlsEdit;
		private System.Windows.Forms.ToolStripButton tlsdelete;
		private System.Windows.Forms.ToolStripButton tlCreateACopy;
		private System.Windows.Forms.ToolStripButton tlsActive;
		private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
		private System.Windows.Forms.ToolStripMenuItem excelToolStripMenuItem;
		private System.Windows.Forms.TextBox textSearch;
		private System.Windows.Forms.ComboBox cmbFieldName;
		private System.Windows.Forms.DataGridView dataItemList;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.ComboBox cmbPage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripButton tlsRefresh;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.ToolStripDropDownButton tlsNew;
        private System.Windows.Forms.ComboBox cbmSortType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Active;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
    }
}