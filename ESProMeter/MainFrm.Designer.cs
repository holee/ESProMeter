namespace ESProMeter
{
    partial class MainFrm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrm));
			this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
			this.openCompanyFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.connectToExistingCompanyFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.closeCompanyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
			this.backupCompanyFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.listToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.itemListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.siteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.uomItemList = new System.Windows.Forms.ToolStripMenuItem();
			this.companyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.myCompanyInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.userRoleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.changeMyPasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.userManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.roleManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.customerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.customerListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.boqToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.billOfQuantityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.billOfQuantityListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
			this.bToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.boQItemListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.siteListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripSeparator();
			this.quoteListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.billOfQuanityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openBillOfQuantityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openBOQDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.quotesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openQuotesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.closedQuotesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.panelMenu = new System.Windows.Forms.Panel();
			this.buttonSetting = new FontAwesome.Sharp.IconButton();
			this.buttonBOQ = new FontAwesome.Sharp.IconButton();
			this.buttonItems = new FontAwesome.Sharp.IconButton();
			this.buttonClose = new FontAwesome.Sharp.IconButton();
			this.buttonCustomer = new FontAwesome.Sharp.IconButton();
			this.btnHome = new FontAwesome.Sharp.IconButton();
			this.panel3 = new System.Windows.Forms.Panel();
			this.btnMenu = new FontAwesome.Sharp.IconButton();
			this.tmrAlive = new System.Windows.Forms.Timer(this.components);
			this.menuStrip1.SuspendLayout();
			this.panelMenu.SuspendLayout();
			this.panel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// reportViewer1
			// 
			this.reportViewer1.Location = new System.Drawing.Point(0, 0);
			this.reportViewer1.Name = "ReportViewer";
			this.reportViewer1.ServerReport.BearerToken = null;
			this.reportViewer1.Size = new System.Drawing.Size(396, 246);
			this.reportViewer1.TabIndex = 0;
			// 
			// menuStrip1
			// 
			this.menuStrip1.AutoSize = false;
			this.menuStrip1.BackColor = System.Drawing.Color.WhiteSmoke;
			this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.listToolStripMenuItem,
            this.companyToolStripMenuItem,
            this.customerToolStripMenuItem,
            this.billOfQuantityToolStripMenuItem,
            this.reportToolStripMenuItem,
            this.helpToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
			this.menuStrip1.Size = new System.Drawing.Size(1061, 36);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem7,
            this.openCompanyFileToolStripMenuItem,
            this.connectToExistingCompanyFileToolStripMenuItem,
            this.closeCompanyToolStripMenuItem,
            this.toolStripMenuItem1,
            this.backupCompanyFileToolStripMenuItem,
            this.toolStripMenuItem8,
            this.toolStripMenuItem2,
            this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(41, 32);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// toolStripMenuItem7
			// 
			this.toolStripMenuItem7.Name = "toolStripMenuItem7";
			this.toolStripMenuItem7.Size = new System.Drawing.Size(283, 24);
			this.toolStripMenuItem7.Text = "Create New Company File";
			// 
			// openCompanyFileToolStripMenuItem
			// 
			this.openCompanyFileToolStripMenuItem.Name = "openCompanyFileToolStripMenuItem";
			this.openCompanyFileToolStripMenuItem.Size = new System.Drawing.Size(283, 24);
			this.openCompanyFileToolStripMenuItem.Text = "Open Company File";
			this.openCompanyFileToolStripMenuItem.Click += new System.EventHandler(this.openCompanyFileToolStripMenuItem_Click);
			// 
			// connectToExistingCompanyFileToolStripMenuItem
			// 
			this.connectToExistingCompanyFileToolStripMenuItem.Name = "connectToExistingCompanyFileToolStripMenuItem";
			this.connectToExistingCompanyFileToolStripMenuItem.Size = new System.Drawing.Size(283, 24);
			this.connectToExistingCompanyFileToolStripMenuItem.Text = "Connect to Existing Company File";
			// 
			// closeCompanyToolStripMenuItem
			// 
			this.closeCompanyToolStripMenuItem.Enabled = false;
			this.closeCompanyToolStripMenuItem.Name = "closeCompanyToolStripMenuItem";
			this.closeCompanyToolStripMenuItem.Size = new System.Drawing.Size(283, 24);
			this.closeCompanyToolStripMenuItem.Text = "Close Company File";
			this.closeCompanyToolStripMenuItem.Click += new System.EventHandler(this.closeCompanyToolStripMenuItem_Click);
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(280, 6);
			// 
			// backupCompanyFileToolStripMenuItem
			// 
			this.backupCompanyFileToolStripMenuItem.Enabled = false;
			this.backupCompanyFileToolStripMenuItem.Name = "backupCompanyFileToolStripMenuItem";
			this.backupCompanyFileToolStripMenuItem.Size = new System.Drawing.Size(283, 24);
			this.backupCompanyFileToolStripMenuItem.Text = "Backup Company File";
			this.backupCompanyFileToolStripMenuItem.Click += new System.EventHandler(this.backupCompanyFileToolStripMenuItem_Click);
			// 
			// toolStripMenuItem8
			// 
			this.toolStripMenuItem8.Name = "toolStripMenuItem8";
			this.toolStripMenuItem8.Size = new System.Drawing.Size(283, 24);
			this.toolStripMenuItem8.Text = "Restore Company File";
			this.toolStripMenuItem8.Click += new System.EventHandler(this.toolStripMenuItem8_Click);
			// 
			// toolStripMenuItem2
			// 
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			this.toolStripMenuItem2.Size = new System.Drawing.Size(280, 6);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(283, 24);
			this.exitToolStripMenuItem.Text = "Exit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// listToolStripMenuItem
			// 
			this.listToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemListToolStripMenuItem,
            this.siteToolStripMenuItem,
            this.uomItemList});
			this.listToolStripMenuItem.Enabled = false;
			this.listToolStripMenuItem.Name = "listToolStripMenuItem";
			this.listToolStripMenuItem.Size = new System.Drawing.Size(42, 32);
			this.listToolStripMenuItem.Text = "List";
			// 
			// itemListToolStripMenuItem
			// 
			this.itemListToolStripMenuItem.Name = "itemListToolStripMenuItem";
			this.itemListToolStripMenuItem.Size = new System.Drawing.Size(137, 24);
			this.itemListToolStripMenuItem.Text = "Item List";
			this.itemListToolStripMenuItem.Click += new System.EventHandler(this.itemListToolStripMenuItem_Click);
			// 
			// siteToolStripMenuItem
			// 
			this.siteToolStripMenuItem.Name = "siteToolStripMenuItem";
			this.siteToolStripMenuItem.Size = new System.Drawing.Size(137, 24);
			this.siteToolStripMenuItem.Text = "Site List";
			this.siteToolStripMenuItem.Click += new System.EventHandler(this.siteToolStripMenuItem_Click);
			// 
			// uomItemList
			// 
			this.uomItemList.Name = "uomItemList";
			this.uomItemList.Size = new System.Drawing.Size(137, 24);
			this.uomItemList.Text = "UOM List";
			this.uomItemList.Click += new System.EventHandler(this.uomItemList_Click);
			// 
			// companyToolStripMenuItem
			// 
			this.companyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.myCompanyInformationToolStripMenuItem,
            this.userRoleToolStripMenuItem});
			this.companyToolStripMenuItem.Enabled = false;
			this.companyToolStripMenuItem.Name = "companyToolStripMenuItem";
			this.companyToolStripMenuItem.Size = new System.Drawing.Size(80, 32);
			this.companyToolStripMenuItem.Text = "Company";
			// 
			// myCompanyInformationToolStripMenuItem
			// 
			this.myCompanyInformationToolStripMenuItem.Name = "myCompanyInformationToolStripMenuItem";
			this.myCompanyInformationToolStripMenuItem.Size = new System.Drawing.Size(237, 24);
			this.myCompanyInformationToolStripMenuItem.Text = "My Company Information";
			this.myCompanyInformationToolStripMenuItem.Click += new System.EventHandler(this.myCompanyInformationToolStripMenuItem_Click);
			// 
			// userRoleToolStripMenuItem
			// 
			this.userRoleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeMyPasswordToolStripMenuItem,
            this.userManagementToolStripMenuItem,
            this.roleManagementToolStripMenuItem});
			this.userRoleToolStripMenuItem.Name = "userRoleToolStripMenuItem";
			this.userRoleToolStripMenuItem.Size = new System.Drawing.Size(237, 24);
			this.userRoleToolStripMenuItem.Text = "User && Role";
			// 
			// changeMyPasswordToolStripMenuItem
			// 
			this.changeMyPasswordToolStripMenuItem.Name = "changeMyPasswordToolStripMenuItem";
			this.changeMyPasswordToolStripMenuItem.Size = new System.Drawing.Size(211, 24);
			this.changeMyPasswordToolStripMenuItem.Text = "Change My Password";
			this.changeMyPasswordToolStripMenuItem.Click += new System.EventHandler(this.changeMyPasswordToolStripMenuItem_Click);
			// 
			// userManagementToolStripMenuItem
			// 
			this.userManagementToolStripMenuItem.Name = "userManagementToolStripMenuItem";
			this.userManagementToolStripMenuItem.Size = new System.Drawing.Size(211, 24);
			this.userManagementToolStripMenuItem.Text = "User Management";
			this.userManagementToolStripMenuItem.Click += new System.EventHandler(this.userManagementToolStripMenuItem_Click);
			// 
			// roleManagementToolStripMenuItem
			// 
			this.roleManagementToolStripMenuItem.Enabled = false;
			this.roleManagementToolStripMenuItem.Name = "roleManagementToolStripMenuItem";
			this.roleManagementToolStripMenuItem.Size = new System.Drawing.Size(211, 24);
			this.roleManagementToolStripMenuItem.Text = "Role Management";
			// 
			// customerToolStripMenuItem
			// 
			this.customerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customerListToolStripMenuItem,
            this.toolStripSeparator1,
            this.boqToolStripMenuItem});
			this.customerToolStripMenuItem.Enabled = false;
			this.customerToolStripMenuItem.Name = "customerToolStripMenuItem";
			this.customerToolStripMenuItem.Size = new System.Drawing.Size(81, 32);
			this.customerToolStripMenuItem.Text = "Customer";
			// 
			// customerListToolStripMenuItem
			// 
			this.customerListToolStripMenuItem.Name = "customerListToolStripMenuItem";
			this.customerListToolStripMenuItem.Size = new System.Drawing.Size(200, 24);
			this.customerListToolStripMenuItem.Text = "Customer List";
			this.customerListToolStripMenuItem.Click += new System.EventHandler(this.customerListToolStripMenuItem_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(197, 6);
			// 
			// boqToolStripMenuItem
			// 
			this.boqToolStripMenuItem.Name = "boqToolStripMenuItem";
			this.boqToolStripMenuItem.Size = new System.Drawing.Size(200, 24);
			this.boqToolStripMenuItem.Text = "New Bill of Quantity";
			this.boqToolStripMenuItem.Click += new System.EventHandler(this.boqToolStripMenuItem_Click);
			// 
			// billOfQuantityToolStripMenuItem
			// 
			this.billOfQuantityToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.billOfQuantityListToolStripMenuItem,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5,
            this.toolStripMenuItem3,
            this.bToolStripMenuItem,
            this.boQItemListToolStripMenuItem,
            this.siteListToolStripMenuItem,
            this.toolStripMenuItem6,
            this.quoteListToolStripMenuItem});
			this.billOfQuantityToolStripMenuItem.Enabled = false;
			this.billOfQuantityToolStripMenuItem.Name = "billOfQuantityToolStripMenuItem";
			this.billOfQuantityToolStripMenuItem.Size = new System.Drawing.Size(112, 32);
			this.billOfQuantityToolStripMenuItem.Text = "Bill of Quantity";
			// 
			// billOfQuantityListToolStripMenuItem
			// 
			this.billOfQuantityListToolStripMenuItem.Name = "billOfQuantityListToolStripMenuItem";
			this.billOfQuantityListToolStripMenuItem.Size = new System.Drawing.Size(200, 24);
			this.billOfQuantityListToolStripMenuItem.Text = "New Bill of Quantity";
			this.billOfQuantityListToolStripMenuItem.Click += new System.EventHandler(this.billOfQuantityListToolStripMenuItem_Click);
			// 
			// toolStripMenuItem4
			// 
			this.toolStripMenuItem4.Name = "toolStripMenuItem4";
			this.toolStripMenuItem4.Size = new System.Drawing.Size(200, 24);
			this.toolStripMenuItem4.Text = "New BoQ Item";
			this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
			// 
			// toolStripMenuItem5
			// 
			this.toolStripMenuItem5.Name = "toolStripMenuItem5";
			this.toolStripMenuItem5.Size = new System.Drawing.Size(200, 24);
			this.toolStripMenuItem5.Text = "New Site";
			this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
			// 
			// toolStripMenuItem3
			// 
			this.toolStripMenuItem3.Name = "toolStripMenuItem3";
			this.toolStripMenuItem3.Size = new System.Drawing.Size(197, 6);
			// 
			// bToolStripMenuItem
			// 
			this.bToolStripMenuItem.Name = "bToolStripMenuItem";
			this.bToolStripMenuItem.Size = new System.Drawing.Size(200, 24);
			this.bToolStripMenuItem.Text = "Bill of Quantity List";
			this.bToolStripMenuItem.Click += new System.EventHandler(this.bToolStripMenuItem_Click);
			// 
			// boQItemListToolStripMenuItem
			// 
			this.boQItemListToolStripMenuItem.Name = "boQItemListToolStripMenuItem";
			this.boQItemListToolStripMenuItem.Size = new System.Drawing.Size(200, 24);
			this.boQItemListToolStripMenuItem.Text = "BoQ Item List";
			// 
			// siteListToolStripMenuItem
			// 
			this.siteListToolStripMenuItem.Name = "siteListToolStripMenuItem";
			this.siteListToolStripMenuItem.Size = new System.Drawing.Size(200, 24);
			this.siteListToolStripMenuItem.Text = "Site List";
			this.siteListToolStripMenuItem.Click += new System.EventHandler(this.siteListToolStripMenuItem_Click);
			// 
			// toolStripMenuItem6
			// 
			this.toolStripMenuItem6.Name = "toolStripMenuItem6";
			this.toolStripMenuItem6.Size = new System.Drawing.Size(197, 6);
			// 
			// quoteListToolStripMenuItem
			// 
			this.quoteListToolStripMenuItem.Name = "quoteListToolStripMenuItem";
			this.quoteListToolStripMenuItem.Size = new System.Drawing.Size(200, 24);
			this.quoteListToolStripMenuItem.Text = "Quote List";
			// 
			// reportToolStripMenuItem
			// 
			this.reportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.billOfQuanityToolStripMenuItem,
            this.quotesToolStripMenuItem});
			this.reportToolStripMenuItem.Enabled = false;
			this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
			this.reportToolStripMenuItem.Size = new System.Drawing.Size(62, 32);
			this.reportToolStripMenuItem.Text = "Report";
			// 
			// billOfQuanityToolStripMenuItem
			// 
			this.billOfQuanityToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openBillOfQuantityToolStripMenuItem,
            this.openBOQDetailsToolStripMenuItem});
			this.billOfQuanityToolStripMenuItem.Name = "billOfQuanityToolStripMenuItem";
			this.billOfQuanityToolStripMenuItem.Size = new System.Drawing.Size(164, 24);
			this.billOfQuanityToolStripMenuItem.Text = "Bill of Quanity";
			// 
			// openBillOfQuantityToolStripMenuItem
			// 
			this.openBillOfQuantityToolStripMenuItem.Name = "openBillOfQuantityToolStripMenuItem";
			this.openBillOfQuantityToolStripMenuItem.Size = new System.Drawing.Size(208, 24);
			this.openBillOfQuantityToolStripMenuItem.Text = "Open BOQ Summary";
			this.openBillOfQuantityToolStripMenuItem.Click += new System.EventHandler(this.openBillOfQuantityToolStripMenuItem_Click);
			// 
			// openBOQDetailsToolStripMenuItem
			// 
			this.openBOQDetailsToolStripMenuItem.Name = "openBOQDetailsToolStripMenuItem";
			this.openBOQDetailsToolStripMenuItem.Size = new System.Drawing.Size(208, 24);
			this.openBOQDetailsToolStripMenuItem.Text = "Open BOQ Details";
			this.openBOQDetailsToolStripMenuItem.Click += new System.EventHandler(this.openBOQDetailsToolStripMenuItem_Click);
			// 
			// quotesToolStripMenuItem
			// 
			this.quotesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openQuotesToolStripMenuItem,
            this.closedQuotesToolStripMenuItem});
			this.quotesToolStripMenuItem.Name = "quotesToolStripMenuItem";
			this.quotesToolStripMenuItem.Size = new System.Drawing.Size(164, 24);
			this.quotesToolStripMenuItem.Text = "Quotes";
			// 
			// openQuotesToolStripMenuItem
			// 
			this.openQuotesToolStripMenuItem.Name = "openQuotesToolStripMenuItem";
			this.openQuotesToolStripMenuItem.Size = new System.Drawing.Size(168, 24);
			this.openQuotesToolStripMenuItem.Text = "Open Quotes";
			// 
			// closedQuotesToolStripMenuItem
			// 
			this.closedQuotesToolStripMenuItem.Name = "closedQuotesToolStripMenuItem";
			this.closedQuotesToolStripMenuItem.Size = new System.Drawing.Size(168, 24);
			this.closedQuotesToolStripMenuItem.Text = "Closed Quotes";
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(49, 32);
			this.helpToolStripMenuItem.Text = "Help";
			// 
			// panelMenu
			// 
			this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(46)))), ((int)(((byte)(100)))));
			this.panelMenu.Controls.Add(this.buttonSetting);
			this.panelMenu.Controls.Add(this.buttonBOQ);
			this.panelMenu.Controls.Add(this.buttonItems);
			this.panelMenu.Controls.Add(this.buttonClose);
			this.panelMenu.Controls.Add(this.buttonCustomer);
			this.panelMenu.Controls.Add(this.btnHome);
			this.panelMenu.Controls.Add(this.panel3);
			this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
			this.panelMenu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.panelMenu.Location = new System.Drawing.Point(0, 36);
			this.panelMenu.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.panelMenu.Name = "panelMenu";
			this.panelMenu.Size = new System.Drawing.Size(169, 573);
			this.panelMenu.TabIndex = 12;
			this.panelMenu.Visible = false;
			// 
			// buttonSetting
			// 
			this.buttonSetting.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.buttonSetting.FlatAppearance.BorderSize = 0;
			this.buttonSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonSetting.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.buttonSetting.ForeColor = System.Drawing.Color.White;
			this.buttonSetting.IconChar = FontAwesome.Sharp.IconChar.Cog;
			this.buttonSetting.IconColor = System.Drawing.Color.White;
			this.buttonSetting.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.buttonSetting.IconSize = 32;
			this.buttonSetting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.buttonSetting.Location = new System.Drawing.Point(0, 487);
			this.buttonSetting.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.buttonSetting.Name = "buttonSetting";
			this.buttonSetting.Size = new System.Drawing.Size(169, 43);
			this.buttonSetting.TabIndex = 7;
			this.buttonSetting.Tag = "Setting";
			this.buttonSetting.Text = "Setting";
			this.buttonSetting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.buttonSetting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.buttonSetting.UseVisualStyleBackColor = true;
			// 
			// buttonBOQ
			// 
			this.buttonBOQ.Dock = System.Windows.Forms.DockStyle.Top;
			this.buttonBOQ.FlatAppearance.BorderSize = 0;
			this.buttonBOQ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonBOQ.ForeColor = System.Drawing.Color.White;
			this.buttonBOQ.IconChar = FontAwesome.Sharp.IconChar.Cogs;
			this.buttonBOQ.IconColor = System.Drawing.Color.White;
			this.buttonBOQ.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.buttonBOQ.IconSize = 32;
			this.buttonBOQ.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.buttonBOQ.Location = new System.Drawing.Point(0, 169);
			this.buttonBOQ.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.buttonBOQ.Name = "buttonBOQ";
			this.buttonBOQ.Size = new System.Drawing.Size(169, 43);
			this.buttonBOQ.TabIndex = 6;
			this.buttonBOQ.Tag = "Bill of Quantity";
			this.buttonBOQ.Text = "Bill of Quantity";
			this.buttonBOQ.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.buttonBOQ.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.buttonBOQ.UseVisualStyleBackColor = true;
			this.buttonBOQ.Click += new System.EventHandler(this.buttonBOQ_Click);
			// 
			// buttonItems
			// 
			this.buttonItems.Dock = System.Windows.Forms.DockStyle.Top;
			this.buttonItems.FlatAppearance.BorderSize = 0;
			this.buttonItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonItems.ForeColor = System.Drawing.Color.White;
			this.buttonItems.IconChar = FontAwesome.Sharp.IconChar.Tractor;
			this.buttonItems.IconColor = System.Drawing.Color.White;
			this.buttonItems.IconFont = FontAwesome.Sharp.IconFont.Solid;
			this.buttonItems.IconSize = 32;
			this.buttonItems.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.buttonItems.Location = new System.Drawing.Point(0, 126);
			this.buttonItems.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.buttonItems.Name = "buttonItems";
			this.buttonItems.Size = new System.Drawing.Size(169, 43);
			this.buttonItems.TabIndex = 5;
			this.buttonItems.Tag = "Items";
			this.buttonItems.Text = "Items";
			this.buttonItems.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.buttonItems.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.buttonItems.UseVisualStyleBackColor = true;
			this.buttonItems.Click += new System.EventHandler(this.buttonItems_Click);
			// 
			// buttonClose
			// 
			this.buttonClose.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.buttonClose.FlatAppearance.BorderSize = 0;
			this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.buttonClose.ForeColor = System.Drawing.Color.White;
			this.buttonClose.IconChar = FontAwesome.Sharp.IconChar.PowerOff;
			this.buttonClose.IconColor = System.Drawing.Color.White;
			this.buttonClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.buttonClose.IconSize = 32;
			this.buttonClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.buttonClose.Location = new System.Drawing.Point(0, 530);
			this.buttonClose.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.buttonClose.Name = "buttonClose";
			this.buttonClose.Size = new System.Drawing.Size(169, 43);
			this.buttonClose.TabIndex = 3;
			this.buttonClose.Tag = "Exit";
			this.buttonClose.Text = "Exit";
			this.buttonClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.buttonClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.buttonClose.UseVisualStyleBackColor = true;
			this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
			// 
			// buttonCustomer
			// 
			this.buttonCustomer.Dock = System.Windows.Forms.DockStyle.Top;
			this.buttonCustomer.FlatAppearance.BorderSize = 0;
			this.buttonCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonCustomer.ForeColor = System.Drawing.Color.White;
			this.buttonCustomer.IconChar = FontAwesome.Sharp.IconChar.Users;
			this.buttonCustomer.IconColor = System.Drawing.Color.White;
			this.buttonCustomer.IconFont = FontAwesome.Sharp.IconFont.Solid;
			this.buttonCustomer.IconSize = 32;
			this.buttonCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.buttonCustomer.Location = new System.Drawing.Point(0, 83);
			this.buttonCustomer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.buttonCustomer.Name = "buttonCustomer";
			this.buttonCustomer.Size = new System.Drawing.Size(169, 43);
			this.buttonCustomer.TabIndex = 2;
			this.buttonCustomer.Tag = "Customer";
			this.buttonCustomer.Text = "Customer";
			this.buttonCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.buttonCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.buttonCustomer.UseVisualStyleBackColor = true;
			this.buttonCustomer.Click += new System.EventHandler(this.buttonCustomer_Click);
			// 
			// btnHome
			// 
			this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(46)))), ((int)(((byte)(96)))));
			this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnHome.FlatAppearance.BorderSize = 0;
			this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnHome.ForeColor = System.Drawing.Color.White;
			this.btnHome.IconChar = FontAwesome.Sharp.IconChar.Home;
			this.btnHome.IconColor = System.Drawing.Color.White;
			this.btnHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnHome.IconSize = 32;
			this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnHome.Location = new System.Drawing.Point(0, 40);
			this.btnHome.Margin = new System.Windows.Forms.Padding(4, 3, 4, 12);
			this.btnHome.Name = "btnHome";
			this.btnHome.Size = new System.Drawing.Size(169, 43);
			this.btnHome.TabIndex = 1;
			this.btnHome.Tag = "Home";
			this.btnHome.Text = "Home";
			this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnHome.UseVisualStyleBackColor = false;
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(46)))), ((int)(((byte)(96)))));
			this.panel3.Controls.Add(this.btnMenu);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel3.Location = new System.Drawing.Point(0, 0);
			this.panel3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(169, 40);
			this.panel3.TabIndex = 0;
			// 
			// btnMenu
			// 
			this.btnMenu.Dock = System.Windows.Forms.DockStyle.Right;
			this.btnMenu.FlatAppearance.BorderSize = 0;
			this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnMenu.IconChar = FontAwesome.Sharp.IconChar.AngleLeft;
			this.btnMenu.IconColor = System.Drawing.Color.White;
			this.btnMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnMenu.IconSize = 30;
			this.btnMenu.Location = new System.Drawing.Point(128, 0);
			this.btnMenu.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.btnMenu.Name = "btnMenu";
			this.btnMenu.Size = new System.Drawing.Size(41, 40);
			this.btnMenu.TabIndex = 0;
			this.btnMenu.UseVisualStyleBackColor = true;
			this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
			// 
			// tmrAlive
			// 
			this.tmrAlive.Interval = 60000;
			this.tmrAlive.Tick += new System.EventHandler(this.tmrAlive_Tick);
			// 
			// MainFrm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1061, 609);
			this.Controls.Add(this.panelMenu);
			this.Controls.Add(this.menuStrip1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.IsMdiContainer = true;
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MainFrm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ES-Pro Metré";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFrm_FormClosing);
			this.Load += new System.EventHandler(this.Form1_Load);
			this.Resize += new System.EventHandler(this.Form1_Resize);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.panelMenu.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem siteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uomItemList;
        private System.Windows.Forms.ToolStripMenuItem boqToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem myCompanyInformationToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem userRoleToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem changeMyPasswordToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem userManagementToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem roleManagementToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem billOfQuanityToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem billOfQuantityListToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem customerListToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
		private System.Windows.Forms.ToolStripMenuItem bToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem boQItemListToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem siteListToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem6;
		private System.Windows.Forms.ToolStripMenuItem quoteListToolStripMenuItem;
		public System.Windows.Forms.ToolStripMenuItem listToolStripMenuItem;
		public System.Windows.Forms.ToolStripMenuItem customerToolStripMenuItem;
		public System.Windows.Forms.ToolStripMenuItem companyToolStripMenuItem;
		public System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
		public System.Windows.Forms.ToolStripMenuItem billOfQuantityToolStripMenuItem;
		public System.Windows.Forms.ToolStripMenuItem openCompanyFileToolStripMenuItem;
		public System.Windows.Forms.ToolStripMenuItem connectToExistingCompanyFileToolStripMenuItem;
		public System.Windows.Forms.ToolStripMenuItem closeCompanyToolStripMenuItem;
		public System.Windows.Forms.ToolStripMenuItem backupCompanyFileToolStripMenuItem;
		public System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
		public System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;
		private System.Windows.Forms.ToolStripMenuItem openBillOfQuantityToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem quotesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem openQuotesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem closedQuotesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem openBOQDetailsToolStripMenuItem;
        private FontAwesome.Sharp.IconButton buttonSetting;
        private FontAwesome.Sharp.IconButton buttonBOQ;
        private FontAwesome.Sharp.IconButton buttonItems;
        private FontAwesome.Sharp.IconButton buttonClose;
        private FontAwesome.Sharp.IconButton buttonCustomer;
        private FontAwesome.Sharp.IconButton btnHome;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconButton btnMenu;
		public System.Windows.Forms.Panel panelMenu;
		public System.Windows.Forms.Timer tmrAlive;
	}
}