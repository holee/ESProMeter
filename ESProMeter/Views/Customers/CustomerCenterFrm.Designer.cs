namespace ESProMeter.Views.Customers
{
    partial class CustomerCenterFrm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerCenterFrm));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.tlsNew = new System.Windows.Forms.ToolStripButton();
			this.tlsCustomerEdit = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
			this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
			this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.iconButton1 = new FontAwesome.Sharp.IconButton();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.textSearch = new System.Windows.Forms.TextBox();
			this.dgvCustomer = new System.Windows.Forms.DataGridView();
			this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.panel2 = new System.Windows.Forms.Panel();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.dtgBOQList = new System.Windows.Forms.DataGridView();
			this.chkIncludeClosedBOQ = new System.Windows.Forms.CheckBox();
			this.dtpToDate = new System.Windows.Forms.DateTimePicker();
			this.label10 = new System.Windows.Forms.Label();
			this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
			this.label9 = new System.Windows.Forms.Label();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.dtgContactList = new System.Windows.Forms.DataGridView();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.manageContactsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.addNewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.editeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.pnlDetails = new System.Windows.Forms.Panel();
			this.toolStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).BeginInit();
			this.panel2.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dtgBOQList)).BeginInit();
			this.tabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dtgContactList)).BeginInit();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// toolStrip1
			// 
			this.toolStrip1.AutoSize = false;
			this.toolStrip1.BackColor = System.Drawing.Color.WhiteSmoke;
			this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlsNew,
            this.tlsCustomerEdit,
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripButton1,
            this.toolStripDropDownButton1});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(1323, 39);
			this.toolStrip1.TabIndex = 0;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// tlsNew
			// 
			this.tlsNew.ForeColor = System.Drawing.Color.Black;
			this.tlsNew.Image = ((System.Drawing.Image)(resources.GetObject("tlsNew.Image")));
			this.tlsNew.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tlsNew.Name = "tlsNew";
			this.tlsNew.Size = new System.Drawing.Size(106, 36);
			this.tlsNew.Text = "New Customer";
			this.tlsNew.Click += new System.EventHandler(this.tlsNew_Click);
			// 
			// tlsCustomerEdit
			// 
			this.tlsCustomerEdit.Image = ((System.Drawing.Image)(resources.GetObject("tlsCustomerEdit.Image")));
			this.tlsCustomerEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tlsCustomerEdit.Name = "tlsCustomerEdit";
			this.tlsCustomerEdit.Size = new System.Drawing.Size(102, 36);
			this.tlsCustomerEdit.Text = "Edit Customer";
			this.tlsCustomerEdit.Click += new System.EventHandler(this.tlsCustomerEdit_Click);
			// 
			// toolStripButton3
			// 
			this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
			this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton3.Name = "toolStripButton3";
			this.toolStripButton3.Size = new System.Drawing.Size(115, 36);
			this.toolStripButton3.Text = "Delete Customer";
			this.toolStripButton3.Click += new System.EventHandler(this.tlsDeleteClick);
			// 
			// toolStripButton4
			// 
			this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
			this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton4.Name = "toolStripButton4";
			this.toolStripButton4.Size = new System.Drawing.Size(66, 36);
			this.toolStripButton4.Text = "Refresh";
			this.toolStripButton4.Click += new System.EventHandler(this.tlsRefreshClick);
			// 
			// toolStripButton1
			// 
			this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
			this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton1.Name = "toolStripButton1";
			this.toolStripButton1.Size = new System.Drawing.Size(129, 36);
			this.toolStripButton1.Text = "New Bill of Quanity";
			this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
			// 
			// toolStripDropDownButton1
			// 
			this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportToolStripMenuItem});
			this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
			this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
			this.toolStripDropDownButton1.Size = new System.Drawing.Size(47, 36);
			this.toolStripDropDownButton1.Text = "Excel";
			// 
			// exportToolStripMenuItem
			// 
			this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
			this.exportToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
			this.exportToolStripMenuItem.Text = "Export";
			this.exportToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(0, 39);
			this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.iconButton1);
			this.splitContainer1.Panel1.Controls.Add(this.comboBox1);
			this.splitContainer1.Panel1.Controls.Add(this.textSearch);
			this.splitContainer1.Panel1.Controls.Add(this.dgvCustomer);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.panel2);
			this.splitContainer1.Panel2.Controls.Add(this.pnlDetails);
			this.splitContainer1.Size = new System.Drawing.Size(1323, 631);
			this.splitContainer1.SplitterDistance = 381;
			this.splitContainer1.SplitterWidth = 5;
			this.splitContainer1.TabIndex = 1;
			// 
			// iconButton1
			// 
			this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlassPlus;
			this.iconButton1.IconColor = System.Drawing.Color.Black;
			this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.iconButton1.IconSize = 16;
			this.iconButton1.Location = new System.Drawing.Point(227, 43);
			this.iconButton1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.iconButton1.Name = "iconButton1";
			this.iconButton1.Size = new System.Drawing.Size(41, 24);
			this.iconButton1.TabIndex = 0;
			this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.iconButton1.UseVisualStyleBackColor = true;
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(4, 13);
			this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(374, 23);
			this.comboBox1.TabIndex = 2;
			// 
			// textSearch
			// 
			this.textSearch.Location = new System.Drawing.Point(4, 44);
			this.textSearch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.textSearch.Name = "textSearch";
			this.textSearch.Size = new System.Drawing.Size(219, 23);
			this.textSearch.TabIndex = 1;
			this.textSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textSearch_KeyUp);
			// 
			// dgvCustomer
			// 
			this.dgvCustomer.AllowUserToAddRows = false;
			this.dgvCustomer.AllowUserToDeleteRows = false;
			this.dgvCustomer.AllowUserToResizeRows = false;
			this.dgvCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvCustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvCustomer.BackgroundColor = System.Drawing.SystemColors.Menu;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Transparent;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Transparent;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvCustomer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.dgvCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Column2,
            this.Column3});
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvCustomer.DefaultCellStyle = dataGridViewCellStyle2;
			this.dgvCustomer.EnableHeadersVisualStyles = false;
			this.dgvCustomer.GridColor = System.Drawing.Color.Red;
			this.dgvCustomer.Location = new System.Drawing.Point(4, 74);
			this.dgvCustomer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.dgvCustomer.Name = "dgvCustomer";
			this.dgvCustomer.ReadOnly = true;
			this.dgvCustomer.RowHeadersVisible = false;
			this.dgvCustomer.RowHeadersWidth = 4;
			this.dgvCustomer.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.dgvCustomer.RowTemplate.Height = 30;
			this.dgvCustomer.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.dgvCustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvCustomer.Size = new System.Drawing.Size(373, 554);
			this.dgvCustomer.TabIndex = 0;
			this.dgvCustomer.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvCustomer_DataBindingComplete);
			// 
			// ID
			// 
			this.ID.DataPropertyName = "ID";
			this.ID.HeaderText = "ID";
			this.ID.MinimumWidth = 2;
			this.ID.Name = "ID";
			this.ID.ReadOnly = true;
			this.ID.Visible = false;
			// 
			// Column2
			// 
			this.Column2.DataPropertyName = "Name";
			this.Column2.HeaderText = "Name";
			this.Column2.Name = "Column2";
			this.Column2.ReadOnly = true;
			// 
			// Column3
			// 
			this.Column3.DataPropertyName = "CreditLimit";
			this.Column3.HeaderText = "Total Balance";
			this.Column3.Name = "Column3";
			this.Column3.ReadOnly = true;
			// 
			// panel2
			// 
			this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel2.AutoScroll = true;
			this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
			this.panel2.Controls.Add(this.tabControl1);
			this.panel2.Location = new System.Drawing.Point(8, 284);
			this.panel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(915, 301);
			this.panel2.TabIndex = 1;
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Location = new System.Drawing.Point(5, 25);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(908, 244);
			this.tabControl1.TabIndex = 0;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.dtgBOQList);
			this.tabPage1.Controls.Add(this.chkIncludeClosedBOQ);
			this.tabPage1.Controls.Add(this.dtpToDate);
			this.tabPage1.Controls.Add(this.label10);
			this.tabPage1.Controls.Add(this.dtpFromDate);
			this.tabPage1.Controls.Add(this.label9);
			this.tabPage1.Location = new System.Drawing.Point(4, 24);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(900, 216);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "BOQs";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// dtgBOQList
			// 
			this.dtgBOQList.AllowUserToAddRows = false;
			this.dtgBOQList.AllowUserToDeleteRows = false;
			this.dtgBOQList.AllowUserToResizeColumns = false;
			this.dtgBOQList.AllowUserToResizeRows = false;
			this.dtgBOQList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dtgBOQList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Desktop;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dtgBOQList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.dtgBOQList.ColumnHeadersHeight = 30;
			this.dtgBOQList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.Desktop;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dtgBOQList.DefaultCellStyle = dataGridViewCellStyle4;
			this.dtgBOQList.EnableHeadersVisualStyles = false;
			this.dtgBOQList.Location = new System.Drawing.Point(1, 35);
			this.dtgBOQList.Name = "dtgBOQList";
			this.dtgBOQList.RowHeadersVisible = false;
			this.dtgBOQList.RowTemplate.Height = 30;
			this.dtgBOQList.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.dtgBOQList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dtgBOQList.Size = new System.Drawing.Size(869, 152);
			this.dtgBOQList.TabIndex = 4;
			// 
			// chkIncludeClosedBOQ
			// 
			this.chkIncludeClosedBOQ.AutoSize = true;
			this.chkIncludeClosedBOQ.Location = new System.Drawing.Point(392, 8);
			this.chkIncludeClosedBOQ.Name = "chkIncludeClosedBOQ";
			this.chkIncludeClosedBOQ.Size = new System.Drawing.Size(184, 19);
			this.chkIncludeClosedBOQ.TabIndex = 3;
			this.chkIncludeClosedBOQ.Text = "Include closed Bill of Quantity";
			this.chkIncludeClosedBOQ.UseVisualStyleBackColor = true;
			// 
			// dtpToDate
			// 
			this.dtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpToDate.Location = new System.Drawing.Point(262, 6);
			this.dtpToDate.Name = "dtpToDate";
			this.dtpToDate.Size = new System.Drawing.Size(104, 23);
			this.dtpToDate.TabIndex = 1;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(205, 12);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(51, 15);
			this.label10.TabIndex = 0;
			this.label10.Text = "TO DATE";
			// 
			// dtpFromDate
			// 
			this.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpFromDate.Location = new System.Drawing.Point(87, 6);
			this.dtpFromDate.Name = "dtpFromDate";
			this.dtpFromDate.Size = new System.Drawing.Size(104, 23);
			this.dtpFromDate.TabIndex = 1;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(11, 12);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(70, 15);
			this.label9.TabIndex = 0;
			this.label9.Text = "FROM DATE";
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.dtgContactList);
			this.tabPage2.Controls.Add(this.menuStrip1);
			this.tabPage2.Location = new System.Drawing.Point(4, 24);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(900, 216);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Contacts";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// dtgContactList
			// 
			this.dtgContactList.AllowUserToAddRows = false;
			this.dtgContactList.AllowUserToDeleteRows = false;
			this.dtgContactList.BackgroundColor = System.Drawing.Color.White;
			this.dtgContactList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dtgContactList.Location = new System.Drawing.Point(1, 1);
			this.dtgContactList.Name = "dtgContactList";
			this.dtgContactList.ReadOnly = true;
			this.dtgContactList.RowTemplate.Height = 25;
			this.dtgContactList.Size = new System.Drawing.Size(887, 185);
			this.dtgContactList.TabIndex = 1;
			// 
			// menuStrip1
			// 
			this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageContactsToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(3, 189);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(894, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// manageContactsToolStripMenuItem
			// 
			this.manageContactsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewToolStripMenuItem,
            this.editeToolStripMenuItem,
            this.deleteToolStripMenuItem});
			this.manageContactsToolStripMenuItem.Name = "manageContactsToolStripMenuItem";
			this.manageContactsToolStripMenuItem.Size = new System.Drawing.Size(112, 20);
			this.manageContactsToolStripMenuItem.Text = "Manage Contacts";
			// 
			// addNewToolStripMenuItem
			// 
			this.addNewToolStripMenuItem.Name = "addNewToolStripMenuItem";
			this.addNewToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
			this.addNewToolStripMenuItem.Text = "Add New";
			// 
			// editeToolStripMenuItem
			// 
			this.editeToolStripMenuItem.Name = "editeToolStripMenuItem";
			this.editeToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
			this.editeToolStripMenuItem.Text = "Edit";
			// 
			// deleteToolStripMenuItem
			// 
			this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
			this.deleteToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
			this.deleteToolStripMenuItem.Text = "Delete";
			// 
			// pnlDetails
			// 
			this.pnlDetails.AutoScroll = true;
			this.pnlDetails.BackColor = System.Drawing.Color.WhiteSmoke;
			this.pnlDetails.Location = new System.Drawing.Point(4, 0);
			this.pnlDetails.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.pnlDetails.Name = "pnlDetails";
			this.pnlDetails.Size = new System.Drawing.Size(933, 278);
			this.pnlDetails.TabIndex = 0;
			// 
			// CustomerCenterFrm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
			this.ClientSize = new System.Drawing.Size(1323, 670);
			this.Controls.Add(this.splitContainer1);
			this.Controls.Add(this.toolStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.Name = "CustomerCenterFrm";
			this.Text = "CustomerCenter";
			this.Load += new System.EventHandler(this.CustomerCenterFrm_Load);
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel1.PerformLayout();
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).EndInit();
			this.panel2.ResumeLayout(false);
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dtgBOQList)).EndInit();
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dtgContactList)).EndInit();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tlsNew;
        private System.Windows.Forms.ToolStripButton tlsCustomerEdit;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dgvCustomer;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textSearch;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton iconButton1;
		private System.Windows.Forms.ToolStripButton toolStripButton1;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.DateTimePicker dtpToDate;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.DateTimePicker dtpFromDate;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.DataGridView dtgContactList;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem manageContactsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem addNewToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem editeToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
		private System.Windows.Forms.DataGridView dtgBOQList;
		private System.Windows.Forms.CheckBox chkIncludeClosedBOQ;
        private System.Windows.Forms.Panel pnlDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
		private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
	}
}