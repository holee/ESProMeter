
namespace ESProMeter.Views.Boq
{
	partial class BOQListFrm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.newBoQToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.billOfQuantityListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quoteListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.cboFieldName = new System.Windows.Forms.ComboBox();
            this.dtgBOQList = new System.Windows.Forms.DataGridView();
            this.chkIncludeClosedBOQ = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.txtSite = new System.Windows.Forms.TextBox();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtValidDate = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.txtReferenceNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgBOQLine = new System.Windows.Forms.DataGridView();
            this.menuStrip5 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.detailsBOQToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ecoMaterialToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ecoLabourToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ecoMachineryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.projectCostToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.economicToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.finalQuoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dtgQuotes = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dtgActivities = new System.Windows.Forms.DataGridView();
            this.menuStrip4 = new System.Windows.Forms.MenuStrip();
            this.activitiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgBOQList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgBOQLine)).BeginInit();
            this.menuStrip5.SuspendLayout();
            this.tab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgQuotes)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgActivities)).BeginInit();
            this.menuStrip4.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newBoQToolStripMenuItem,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.toolStripMenuItem1,
            this.refreshToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1136, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // newBoQToolStripMenuItem
            // 
            this.newBoQToolStripMenuItem.Name = "newBoQToolStripMenuItem";
            this.newBoQToolStripMenuItem.Size = new System.Drawing.Size(125, 20);
            this.newBoQToolStripMenuItem.Text = "New Bill of Quantity";
            this.newBoQToolStripMenuItem.Click += new System.EventHandler(this.newBoQToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.deleteToolStripMenuItem.Text = "Delete";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.billOfQuantityListToolStripMenuItem,
            this.quoteListToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(59, 20);
            this.toolStripMenuItem1.Text = "Reports";
            // 
            // billOfQuantityListToolStripMenuItem
            // 
            this.billOfQuantityListToolStripMenuItem.Name = "billOfQuantityListToolStripMenuItem";
            this.billOfQuantityListToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.billOfQuantityListToolStripMenuItem.Text = "Bill of Quantity List";
            // 
            // quoteListToolStripMenuItem
            // 
            this.quoteListToolStripMenuItem.Name = "quoteListToolStripMenuItem";
            this.quoteListToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.quoteListToolStripMenuItem.Text = "Quote List";
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.refreshToolStripMenuItem.Text = "Refresh";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel1.Controls.Add(this.cboFieldName);
            this.splitContainer1.Panel1.Controls.Add(this.dtgBOQList);
            this.splitContainer1.Panel1.Controls.Add(this.chkIncludeClosedBOQ);
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            this.splitContainer1.Panel1.Controls.Add(this.txtSearch);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1136, 426);
            this.splitContainer1.SplitterDistance = 377;
            this.splitContainer1.TabIndex = 2;
            // 
            // cboFieldName
            // 
            this.cboFieldName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFieldName.FormattingEnabled = true;
            this.cboFieldName.Location = new System.Drawing.Point(6, 12);
            this.cboFieldName.Name = "cboFieldName";
            this.cboFieldName.Size = new System.Drawing.Size(127, 23);
            this.cboFieldName.TabIndex = 1;
            // 
            // dtgBOQList
            // 
            this.dtgBOQList.AllowUserToAddRows = false;
            this.dtgBOQList.AllowUserToDeleteRows = false;
            this.dtgBOQList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgBOQList.BackgroundColor = System.Drawing.Color.White;
            this.dtgBOQList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgBOQList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Column2,
            this.Column3});
            this.dtgBOQList.Location = new System.Drawing.Point(6, 70);
            this.dtgBOQList.Name = "dtgBOQList";
            this.dtgBOQList.ReadOnly = true;
            this.dtgBOQList.RowHeadersVisible = false;
            this.dtgBOQList.RowTemplate.Height = 25;
            this.dtgBOQList.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgBOQList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtgBOQList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgBOQList.Size = new System.Drawing.Size(368, 353);
            this.dtgBOQList.TabIndex = 0;
            this.dtgBOQList.SelectionChanged += new System.EventHandler(this.dtgBOQList_SelectionChanged);
            // 
            // chkIncludeClosedBOQ
            // 
            this.chkIncludeClosedBOQ.AutoSize = true;
            this.chkIncludeClosedBOQ.Location = new System.Drawing.Point(6, 44);
            this.chkIncludeClosedBOQ.Name = "chkIncludeClosedBOQ";
            this.chkIncludeClosedBOQ.Size = new System.Drawing.Size(184, 19);
            this.chkIncludeClosedBOQ.TabIndex = 0;
            this.chkIncludeClosedBOQ.Text = "Include closed Bill of Quantity";
            this.chkIncludeClosedBOQ.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(351, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(24, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "S";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Location = new System.Drawing.Point(136, 12);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(215, 23);
            this.txtSearch.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Cursor = System.Windows.Forms.Cursors.HSplit;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.BackColor = System.Drawing.Color.White;
            this.splitContainer2.Panel1.Controls.Add(this.txtSite);
            this.splitContainer2.Panel1.Controls.Add(this.txtCustomerName);
            this.splitContainer2.Panel1.Controls.Add(this.txtTitle);
            this.splitContainer2.Panel1.Controls.Add(this.txtValidDate);
            this.splitContainer2.Panel1.Controls.Add(this.txtDate);
            this.splitContainer2.Panel1.Controls.Add(this.txtReferenceNo);
            this.splitContainer2.Panel1.Controls.Add(this.label3);
            this.splitContainer2.Panel1.Controls.Add(this.label6);
            this.splitContainer2.Panel1.Controls.Add(this.label5);
            this.splitContainer2.Panel1.Controls.Add(this.label4);
            this.splitContainer2.Panel1.Controls.Add(this.label2);
            this.splitContainer2.Panel1.Controls.Add(this.label1);
            this.splitContainer2.Panel1.Controls.Add(this.dtgBOQLine);
            this.splitContainer2.Panel1.Controls.Add(this.menuStrip5);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.tab);
            this.splitContainer2.Size = new System.Drawing.Size(755, 426);
            this.splitContainer2.SplitterDistance = 280;
            this.splitContainer2.TabIndex = 0;
            // 
            // txtSite
            // 
            this.txtSite.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtSite.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSite.Location = new System.Drawing.Point(614, 12);
            this.txtSite.Name = "txtSite";
            this.txtSite.Size = new System.Drawing.Size(137, 16);
            this.txtSite.TabIndex = 2;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtCustomerName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCustomerName.Location = new System.Drawing.Point(354, 12);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(207, 16);
            this.txtCustomerName.TabIndex = 2;
            // 
            // txtTitle
            // 
            this.txtTitle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTitle.Location = new System.Drawing.Point(50, 41);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(276, 16);
            this.txtTitle.TabIndex = 2;
            // 
            // txtValidDate
            // 
            this.txtValidDate.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtValidDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtValidDate.Location = new System.Drawing.Point(614, 41);
            this.txtValidDate.Name = "txtValidDate";
            this.txtValidDate.Size = new System.Drawing.Size(119, 16);
            this.txtValidDate.TabIndex = 2;
            // 
            // txtDate
            // 
            this.txtDate.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDate.Location = new System.Drawing.Point(397, 41);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(119, 16);
            this.txtDate.TabIndex = 2;
            // 
            // txtReferenceNo
            // 
            this.txtReferenceNo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtReferenceNo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtReferenceNo.Location = new System.Drawing.Point(105, 12);
            this.txtReferenceNo.Name = "txtReferenceNo";
            this.txtReferenceNo.Size = new System.Drawing.Size(119, 16);
            this.txtReferenceNo.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(577, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "SITE:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(537, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "VALID DATE:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(354, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "DATE:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(7, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "TITLE:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(241, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "CUSTOMER NAME:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(7, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "REFERENCE NO:";
            // 
            // dtgBOQLine
            // 
            this.dtgBOQLine.AllowUserToAddRows = false;
            this.dtgBOQLine.AllowUserToDeleteRows = false;
            this.dtgBOQLine.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgBOQLine.BackgroundColor = System.Drawing.Color.White;
            this.dtgBOQLine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgBOQLine.Location = new System.Drawing.Point(7, 70);
            this.dtgBOQLine.Name = "dtgBOQLine";
            this.dtgBOQLine.RowTemplate.Height = 25;
            this.dtgBOQLine.Size = new System.Drawing.Size(745, 170);
            this.dtgBOQLine.TabIndex = 0;
            // 
            // menuStrip5
            // 
            this.menuStrip5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.menuStrip5.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip5.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem3,
            this.exportToExcelToolStripMenuItem});
            this.menuStrip5.Location = new System.Drawing.Point(7, 248);
            this.menuStrip5.Name = "menuStrip5";
            this.menuStrip5.Size = new System.Drawing.Size(203, 24);
            this.menuStrip5.TabIndex = 3;
            this.menuStrip5.Text = "menuStrip5";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem4,
            this.detailsBOQToolStripMenuItem,
            this.toolStripSeparator1,
            this.ecoMaterialToolStripMenuItem1,
            this.ecoLabourToolStripMenuItem1,
            this.ecoMachineryToolStripMenuItem,
            this.toolStripMenuItem2,
            this.projectCostToolStripMenuItem1,
            this.economicToolStripMenuItem1,
            this.toolStripMenuItem5,
            this.finalQuoteToolStripMenuItem});
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(98, 20);
            this.toolStripMenuItem3.Text = "Bill of Quantity";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem4.Text = "BOQ";
            // 
            // detailsBOQToolStripMenuItem
            // 
            this.detailsBOQToolStripMenuItem.Name = "detailsBOQToolStripMenuItem";
            this.detailsBOQToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.detailsBOQToolStripMenuItem.Text = "Details BOQ";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // ecoMaterialToolStripMenuItem1
            // 
            this.ecoMaterialToolStripMenuItem1.Name = "ecoMaterialToolStripMenuItem1";
            this.ecoMaterialToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.ecoMaterialToolStripMenuItem1.Text = "Eco Material";
            // 
            // ecoLabourToolStripMenuItem1
            // 
            this.ecoLabourToolStripMenuItem1.Name = "ecoLabourToolStripMenuItem1";
            this.ecoLabourToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.ecoLabourToolStripMenuItem1.Text = "Eco Labour";
            // 
            // ecoMachineryToolStripMenuItem
            // 
            this.ecoMachineryToolStripMenuItem.Name = "ecoMachineryToolStripMenuItem";
            this.ecoMachineryToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ecoMachineryToolStripMenuItem.Text = "Eco Machinery";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(149, 6);
            // 
            // projectCostToolStripMenuItem1
            // 
            this.projectCostToolStripMenuItem1.Name = "projectCostToolStripMenuItem1";
            this.projectCostToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.projectCostToolStripMenuItem1.Text = "Project Cost";
            // 
            // economicToolStripMenuItem1
            // 
            this.economicToolStripMenuItem1.Name = "economicToolStripMenuItem1";
            this.economicToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.economicToolStripMenuItem1.Text = "Economic";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(149, 6);
            // 
            // finalQuoteToolStripMenuItem
            // 
            this.finalQuoteToolStripMenuItem.Name = "finalQuoteToolStripMenuItem";
            this.finalQuoteToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.finalQuoteToolStripMenuItem.Text = "Final Quote";
            // 
            // exportToExcelToolStripMenuItem
            // 
            this.exportToExcelToolStripMenuItem.Name = "exportToExcelToolStripMenuItem";
            this.exportToExcelToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.exportToExcelToolStripMenuItem.Text = "Export to Excel";
            // 
            // tab
            // 
            this.tab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tab.Controls.Add(this.tabPage1);
            this.tab.Controls.Add(this.tabPage2);
            this.tab.Location = new System.Drawing.Point(0, 0);
            this.tab.Name = "tab";
            this.tab.SelectedIndex = 0;
            this.tab.Size = new System.Drawing.Size(755, 142);
            this.tab.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dtgQuotes);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(747, 114);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "QUOTES";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dtgQuotes
            // 
            this.dtgQuotes.AllowUserToAddRows = false;
            this.dtgQuotes.AllowUserToDeleteRows = false;
            this.dtgQuotes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgQuotes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgQuotes.BackgroundColor = System.Drawing.Color.White;
            this.dtgQuotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgQuotes.Location = new System.Drawing.Point(1, 0);
            this.dtgQuotes.MultiSelect = false;
            this.dtgQuotes.Name = "dtgQuotes";
            this.dtgQuotes.ReadOnly = true;
            this.dtgQuotes.RowHeadersVisible = false;
            this.dtgQuotes.RowTemplate.Height = 25;
            this.dtgQuotes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgQuotes.Size = new System.Drawing.Size(747, 111);
            this.dtgQuotes.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dtgActivities);
            this.tabPage2.Controls.Add(this.menuStrip4);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(747, 114);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "ACTIVITIES";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dtgActivities
            // 
            this.dtgActivities.AllowUserToAddRows = false;
            this.dtgActivities.AllowUserToDeleteRows = false;
            this.dtgActivities.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgActivities.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgActivities.BackgroundColor = System.Drawing.Color.White;
            this.dtgActivities.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgActivities.Location = new System.Drawing.Point(0, 2);
            this.dtgActivities.MultiSelect = false;
            this.dtgActivities.Name = "dtgActivities";
            this.dtgActivities.ReadOnly = true;
            this.dtgActivities.RowHeadersVisible = false;
            this.dtgActivities.RowTemplate.Height = 25;
            this.dtgActivities.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgActivities.Size = new System.Drawing.Size(747, 73);
            this.dtgActivities.TabIndex = 1;
            // 
            // menuStrip4
            // 
            this.menuStrip4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.menuStrip4.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip4.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.activitiesToolStripMenuItem,
            this.editToolStripMenuItem3,
            this.deleteToolStripMenuItem3});
            this.menuStrip4.Location = new System.Drawing.Point(3, 78);
            this.menuStrip4.Name = "menuStrip4";
            this.menuStrip4.Size = new System.Drawing.Size(185, 24);
            this.menuStrip4.TabIndex = 2;
            this.menuStrip4.Text = "menuStrip4";
            // 
            // activitiesToolStripMenuItem
            // 
            this.activitiesToolStripMenuItem.Name = "activitiesToolStripMenuItem";
            this.activitiesToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.activitiesToolStripMenuItem.Text = "New Activity";
            // 
            // editToolStripMenuItem3
            // 
            this.editToolStripMenuItem3.Name = "editToolStripMenuItem3";
            this.editToolStripMenuItem3.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem3.Text = "Edit";
            // 
            // deleteToolStripMenuItem3
            // 
            this.deleteToolStripMenuItem3.Name = "deleteToolStripMenuItem3";
            this.deleteToolStripMenuItem3.Size = new System.Drawing.Size(52, 20);
            this.deleteToolStripMenuItem3.Text = "Delete";
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "CUSTOMERNAME";
            this.Column2.HeaderText = "CUSTOMER";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "BOQDATE";
            this.Column3.HeaderText = "DATE";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // BOQListFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 450);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "BOQListFrm";
            this.Text = "Bill of Quantity List";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgBOQList)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgBOQLine)).EndInit();
            this.menuStrip5.ResumeLayout(false);
            this.menuStrip5.PerformLayout();
            this.tab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgQuotes)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgActivities)).EndInit();
            this.menuStrip4.ResumeLayout(false);
            this.menuStrip4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem newBoQToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.DataGridView dtgBOQList;
		private System.Windows.Forms.CheckBox chkIncludeClosedBOQ;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox txtSearch;
		private System.Windows.Forms.SplitContainer splitContainer2;
		private System.Windows.Forms.DataGridView dtgBOQLine;
		private System.Windows.Forms.TabControl tab;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.TextBox txtSite;
		private System.Windows.Forms.TextBox txtCustomerName;
		private System.Windows.Forms.TextBox txtTitle;
		private System.Windows.Forms.TextBox txtReferenceNo;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtValidDate;
		private System.Windows.Forms.TextBox txtDate;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox cboFieldName;
		private System.Windows.Forms.DataGridView dtgQuotes;
		private System.Windows.Forms.DataGridView dtgActivities;
		private System.Windows.Forms.MenuStrip menuStrip4;
		private System.Windows.Forms.ToolStripMenuItem activitiesToolStripMenuItem;
		private System.Windows.Forms.MenuStrip menuStrip5;
		private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem3;
		private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem3;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem billOfQuantityListToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem quoteListToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
		private System.Windows.Forms.ToolStripMenuItem detailsBOQToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem ecoMaterialToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem ecoLabourToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem ecoMachineryToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem projectCostToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem economicToolStripMenuItem1;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
		private System.Windows.Forms.ToolStripMenuItem finalQuoteToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exportToExcelToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}