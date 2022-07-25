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
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.panel1 = new System.Windows.Forms.Panel();
			this.materialButton7 = new FontAwesome.Sharp.Material.MaterialButton();
			this.materialButton6 = new FontAwesome.Sharp.Material.MaterialButton();
			this.materialButton5 = new FontAwesome.Sharp.Material.MaterialButton();
			this.materialButton4 = new FontAwesome.Sharp.Material.MaterialButton();
			this.materialButton3 = new FontAwesome.Sharp.Material.MaterialButton();
			this.materialButton2 = new FontAwesome.Sharp.Material.MaterialButton();
			this.materialButton1 = new FontAwesome.Sharp.Material.MaterialButton();
			this.btnCloseForm = new FontAwesome.Sharp.IconButton();
			this.panel2 = new System.Windows.Forms.Panel();
			this.iconButton1 = new FontAwesome.Sharp.IconButton();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.panel1.SuspendLayout();
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
			// 
			// toolStripMenuItem8
			// 
			this.toolStripMenuItem8.Name = "toolStripMenuItem8";
			this.toolStripMenuItem8.Size = new System.Drawing.Size(283, 24);
			this.toolStripMenuItem8.Text = "Restore Company File";
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
<<<<<<< HEAD
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
=======
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
>>>>>>> 0cf5c6fdb39fcef30acc765432768250800695bd
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
<<<<<<< HEAD
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
=======
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
>>>>>>> 0cf5c6fdb39fcef30acc765432768250800695bd
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
            this.billOfQuanityToolStripMenuItem});
<<<<<<< HEAD
			this.reportToolStripMenuItem.Enabled = false;
			this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
			this.reportToolStripMenuItem.Size = new System.Drawing.Size(62, 32);
			this.reportToolStripMenuItem.Text = "Report";
			// 
			// billOfQuanityToolStripMenuItem
			// 
			this.billOfQuanityToolStripMenuItem.Name = "billOfQuanityToolStripMenuItem";
			this.billOfQuanityToolStripMenuItem.Size = new System.Drawing.Size(164, 24);
			this.billOfQuanityToolStripMenuItem.Text = "Bill of Quanity";
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(49, 32);
			this.helpToolStripMenuItem.Text = "Help";
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(0, 36);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(46)))), ((int)(((byte)(100)))));
			this.splitContainer1.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.splitContainer1.Panel1.Controls.Add(this.panel1);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.splitContainer1.Panel2.Controls.Add(this.btnCloseForm);
			this.splitContainer1.Panel2.Controls.Add(this.panel2);
			this.splitContainer1.Panel2.Controls.Add(this.iconButton1);
			this.splitContainer1.Size = new System.Drawing.Size(1061, 573);
			this.splitContainer1.SplitterDistance = 183;
			this.splitContainer1.SplitterWidth = 1;
			this.splitContainer1.TabIndex = 1;
			this.splitContainer1.Visible = false;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Transparent;
			this.panel1.Controls.Add(this.materialButton7);
			this.panel1.Controls.Add(this.materialButton6);
			this.panel1.Controls.Add(this.materialButton5);
			this.panel1.Controls.Add(this.materialButton4);
			this.panel1.Controls.Add(this.materialButton3);
			this.panel1.Controls.Add(this.materialButton2);
			this.panel1.Controls.Add(this.materialButton1);
			this.panel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.panel1.Location = new System.Drawing.Point(0, 21);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(180, 552);
			this.panel1.TabIndex = 0;
			// 
			// materialButton7
			// 
			this.materialButton7.BackColor = System.Drawing.Color.Transparent;
			this.materialButton7.FlatAppearance.BorderSize = 0;
			this.materialButton7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.materialButton7.IconChar = FontAwesome.Sharp.MaterialIcons.Abacus;
			this.materialButton7.IconColor = System.Drawing.Color.White;
			this.materialButton7.IconSize = 20;
			this.materialButton7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.materialButton7.Location = new System.Drawing.Point(3, 193);
			this.materialButton7.Name = "materialButton7";
			this.materialButton7.Size = new System.Drawing.Size(171, 32);
			this.materialButton7.TabIndex = 0;
			this.materialButton7.Text = "materialButton1";
			this.materialButton7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.materialButton7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.materialButton7.UseVisualStyleBackColor = false;
			// 
			// materialButton6
			// 
			this.materialButton6.BackColor = System.Drawing.Color.Transparent;
			this.materialButton6.FlatAppearance.BorderSize = 0;
			this.materialButton6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.materialButton6.IconChar = FontAwesome.Sharp.MaterialIcons.Abacus;
			this.materialButton6.IconColor = System.Drawing.Color.White;
			this.materialButton6.IconSize = 20;
			this.materialButton6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.materialButton6.Location = new System.Drawing.Point(3, 155);
			this.materialButton6.Name = "materialButton6";
			this.materialButton6.Size = new System.Drawing.Size(171, 32);
			this.materialButton6.TabIndex = 0;
			this.materialButton6.Text = "materialButton1";
			this.materialButton6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.materialButton6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.materialButton6.UseVisualStyleBackColor = false;
			// 
			// materialButton5
			// 
			this.materialButton5.BackColor = System.Drawing.Color.Transparent;
			this.materialButton5.FlatAppearance.BorderSize = 0;
			this.materialButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.materialButton5.IconChar = FontAwesome.Sharp.MaterialIcons.Abacus;
			this.materialButton5.IconColor = System.Drawing.Color.White;
			this.materialButton5.IconSize = 20;
			this.materialButton5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.materialButton5.Location = new System.Drawing.Point(0, 164);
			this.materialButton5.Name = "materialButton5";
			this.materialButton5.Size = new System.Drawing.Size(171, 32);
			this.materialButton5.TabIndex = 0;
			this.materialButton5.Text = "materialButton1";
			this.materialButton5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.materialButton5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.materialButton5.UseVisualStyleBackColor = false;
			// 
			// materialButton4
			// 
			this.materialButton4.BackColor = System.Drawing.Color.Transparent;
			this.materialButton4.FlatAppearance.BorderSize = 0;
			this.materialButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.materialButton4.IconChar = FontAwesome.Sharp.MaterialIcons.Abacus;
			this.materialButton4.IconColor = System.Drawing.Color.White;
			this.materialButton4.IconSize = 20;
			this.materialButton4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.materialButton4.Location = new System.Drawing.Point(0, 117);
			this.materialButton4.Name = "materialButton4";
			this.materialButton4.Size = new System.Drawing.Size(171, 32);
			this.materialButton4.TabIndex = 0;
			this.materialButton4.Text = "materialButton1";
			this.materialButton4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.materialButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.materialButton4.UseVisualStyleBackColor = false;
			// 
			// materialButton3
			// 
			this.materialButton3.BackColor = System.Drawing.Color.Transparent;
			this.materialButton3.FlatAppearance.BorderSize = 0;
			this.materialButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.materialButton3.IconChar = FontAwesome.Sharp.MaterialIcons.Abacus;
			this.materialButton3.IconColor = System.Drawing.Color.White;
			this.materialButton3.IconSize = 20;
			this.materialButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.materialButton3.Location = new System.Drawing.Point(0, 79);
			this.materialButton3.Name = "materialButton3";
			this.materialButton3.Size = new System.Drawing.Size(171, 32);
			this.materialButton3.TabIndex = 0;
			this.materialButton3.Text = "materialButton1";
			this.materialButton3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.materialButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.materialButton3.UseVisualStyleBackColor = false;
			// 
			// materialButton2
			// 
			this.materialButton2.BackColor = System.Drawing.Color.Transparent;
			this.materialButton2.FlatAppearance.BorderSize = 0;
			this.materialButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.materialButton2.IconChar = FontAwesome.Sharp.MaterialIcons.Abacus;
			this.materialButton2.IconColor = System.Drawing.Color.White;
			this.materialButton2.IconSize = 20;
			this.materialButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.materialButton2.Location = new System.Drawing.Point(0, 41);
			this.materialButton2.Name = "materialButton2";
			this.materialButton2.Size = new System.Drawing.Size(171, 32);
			this.materialButton2.TabIndex = 0;
			this.materialButton2.Text = "materialButton1";
			this.materialButton2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.materialButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.materialButton2.UseVisualStyleBackColor = false;
			// 
			// materialButton1
			// 
			this.materialButton1.BackColor = System.Drawing.Color.Transparent;
			this.materialButton1.FlatAppearance.BorderSize = 0;
			this.materialButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.materialButton1.IconChar = FontAwesome.Sharp.MaterialIcons.Abacus;
			this.materialButton1.IconColor = System.Drawing.Color.White;
			this.materialButton1.IconSize = 20;
			this.materialButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.materialButton1.Location = new System.Drawing.Point(3, 3);
			this.materialButton1.Name = "materialButton1";
			this.materialButton1.Size = new System.Drawing.Size(171, 32);
			this.materialButton1.TabIndex = 0;
			this.materialButton1.Text = "materialButton1";
			this.materialButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.materialButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.materialButton1.UseVisualStyleBackColor = false;
			// 
			// btnCloseForm
			// 
			this.btnCloseForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCloseForm.FlatAppearance.BorderSize = 0;
			this.btnCloseForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCloseForm.IconChar = FontAwesome.Sharp.IconChar.X;
			this.btnCloseForm.IconColor = System.Drawing.Color.Red;
			this.btnCloseForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnCloseForm.IconSize = 16;
			this.btnCloseForm.Location = new System.Drawing.Point(900, 3);
			this.btnCloseForm.Name = "btnCloseForm";
			this.btnCloseForm.Size = new System.Drawing.Size(29, 23);
			this.btnCloseForm.TabIndex = 2;
			this.btnCloseForm.UseVisualStyleBackColor = true;
			this.btnCloseForm.Click += new System.EventHandler(this.btnCloseForm_Click);
			// 
			// panel2
			// 
			this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel2.BackColor = System.Drawing.Color.Silver;
			this.panel2.Location = new System.Drawing.Point(-1, 28);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(905, 554);
			this.panel2.TabIndex = 1;
			this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
			// 
			// iconButton1
			// 
			this.iconButton1.FlatAppearance.BorderSize = 0;
			this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.AngleDoubleLeft;
			this.iconButton1.IconColor = System.Drawing.Color.Black;
			this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.iconButton1.IconSize = 20;
			this.iconButton1.Location = new System.Drawing.Point(-1, 3);
			this.iconButton1.Name = "iconButton1";
			this.iconButton1.Size = new System.Drawing.Size(29, 23);
			this.iconButton1.TabIndex = 0;
			this.iconButton1.UseVisualStyleBackColor = true;
			this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
			// 
			// MainFrm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1061, 609);
			this.Controls.Add(this.splitContainer1);
			this.Controls.Add(this.menuStrip1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.IsMdiContainer = true;
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MainFrm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ES-Pro Metré";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.Form1_Load);
			this.Resize += new System.EventHandler(this.Form1_Resize);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);
=======
            this.reportToolStripMenuItem.Enabled = false;
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(62, 32);
            this.reportToolStripMenuItem.Text = "Report";
            // 
            // billOfQuanityToolStripMenuItem
            // 
            this.billOfQuanityToolStripMenuItem.Name = "billOfQuanityToolStripMenuItem";
            this.billOfQuanityToolStripMenuItem.Size = new System.Drawing.Size(164, 24);
            this.billOfQuanityToolStripMenuItem.Text = "Bill of Quanity";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(49, 32);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 36);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(46)))), ((int)(((byte)(100)))));
            this.splitContainer1.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.splitContainer1.Panel2.Controls.Add(this.btnCloseForm);
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Panel2.Controls.Add(this.iconButton1);
            this.splitContainer1.Size = new System.Drawing.Size(1061, 573);
            this.splitContainer1.SplitterDistance = 183;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 1;
            this.splitContainer1.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.materialButton7);
            this.panel1.Controls.Add(this.materialButton6);
            this.panel1.Controls.Add(this.materialButton5);
            this.panel1.Controls.Add(this.materialButton4);
            this.panel1.Controls.Add(this.materialButton3);
            this.panel1.Controls.Add(this.materialButton2);
            this.panel1.Controls.Add(this.materialButton1);
            this.panel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Location = new System.Drawing.Point(0, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(180, 552);
            this.panel1.TabIndex = 0;
            // 
            // materialButton7
            // 
            this.materialButton7.BackColor = System.Drawing.Color.Transparent;
            this.materialButton7.FlatAppearance.BorderSize = 0;
            this.materialButton7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialButton7.IconChar = FontAwesome.Sharp.MaterialIcons.Abacus;
            this.materialButton7.IconColor = System.Drawing.Color.White;
            this.materialButton7.IconSize = 20;
            this.materialButton7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.materialButton7.Location = new System.Drawing.Point(3, 193);
            this.materialButton7.Name = "materialButton7";
            this.materialButton7.Size = new System.Drawing.Size(171, 32);
            this.materialButton7.TabIndex = 0;
            this.materialButton7.Text = "materialButton1";
            this.materialButton7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.materialButton7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.materialButton7.UseVisualStyleBackColor = false;
            // 
            // materialButton6
            // 
            this.materialButton6.BackColor = System.Drawing.Color.Transparent;
            this.materialButton6.FlatAppearance.BorderSize = 0;
            this.materialButton6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialButton6.IconChar = FontAwesome.Sharp.MaterialIcons.Abacus;
            this.materialButton6.IconColor = System.Drawing.Color.White;
            this.materialButton6.IconSize = 20;
            this.materialButton6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.materialButton6.Location = new System.Drawing.Point(3, 155);
            this.materialButton6.Name = "materialButton6";
            this.materialButton6.Size = new System.Drawing.Size(171, 32);
            this.materialButton6.TabIndex = 0;
            this.materialButton6.Text = "materialButton1";
            this.materialButton6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.materialButton6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.materialButton6.UseVisualStyleBackColor = false;
            // 
            // materialButton5
            // 
            this.materialButton5.BackColor = System.Drawing.Color.Transparent;
            this.materialButton5.FlatAppearance.BorderSize = 0;
            this.materialButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialButton5.IconChar = FontAwesome.Sharp.MaterialIcons.Abacus;
            this.materialButton5.IconColor = System.Drawing.Color.White;
            this.materialButton5.IconSize = 20;
            this.materialButton5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.materialButton5.Location = new System.Drawing.Point(0, 164);
            this.materialButton5.Name = "materialButton5";
            this.materialButton5.Size = new System.Drawing.Size(171, 32);
            this.materialButton5.TabIndex = 0;
            this.materialButton5.Text = "materialButton1";
            this.materialButton5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.materialButton5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.materialButton5.UseVisualStyleBackColor = false;
            // 
            // materialButton4
            // 
            this.materialButton4.BackColor = System.Drawing.Color.Transparent;
            this.materialButton4.FlatAppearance.BorderSize = 0;
            this.materialButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialButton4.IconChar = FontAwesome.Sharp.MaterialIcons.Abacus;
            this.materialButton4.IconColor = System.Drawing.Color.White;
            this.materialButton4.IconSize = 20;
            this.materialButton4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.materialButton4.Location = new System.Drawing.Point(0, 117);
            this.materialButton4.Name = "materialButton4";
            this.materialButton4.Size = new System.Drawing.Size(171, 32);
            this.materialButton4.TabIndex = 0;
            this.materialButton4.Text = "materialButton1";
            this.materialButton4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.materialButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.materialButton4.UseVisualStyleBackColor = false;
            // 
            // materialButton3
            // 
            this.materialButton3.BackColor = System.Drawing.Color.Transparent;
            this.materialButton3.FlatAppearance.BorderSize = 0;
            this.materialButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialButton3.IconChar = FontAwesome.Sharp.MaterialIcons.Abacus;
            this.materialButton3.IconColor = System.Drawing.Color.White;
            this.materialButton3.IconSize = 20;
            this.materialButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.materialButton3.Location = new System.Drawing.Point(0, 79);
            this.materialButton3.Name = "materialButton3";
            this.materialButton3.Size = new System.Drawing.Size(171, 32);
            this.materialButton3.TabIndex = 0;
            this.materialButton3.Text = "materialButton1";
            this.materialButton3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.materialButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.materialButton3.UseVisualStyleBackColor = false;
            // 
            // materialButton2
            // 
            this.materialButton2.BackColor = System.Drawing.Color.Transparent;
            this.materialButton2.FlatAppearance.BorderSize = 0;
            this.materialButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialButton2.IconChar = FontAwesome.Sharp.MaterialIcons.Abacus;
            this.materialButton2.IconColor = System.Drawing.Color.White;
            this.materialButton2.IconSize = 20;
            this.materialButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.materialButton2.Location = new System.Drawing.Point(0, 41);
            this.materialButton2.Name = "materialButton2";
            this.materialButton2.Size = new System.Drawing.Size(171, 32);
            this.materialButton2.TabIndex = 0;
            this.materialButton2.Text = "materialButton1";
            this.materialButton2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.materialButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.materialButton2.UseVisualStyleBackColor = false;
            // 
            // materialButton1
            // 
            this.materialButton1.BackColor = System.Drawing.Color.Transparent;
            this.materialButton1.FlatAppearance.BorderSize = 0;
            this.materialButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialButton1.IconChar = FontAwesome.Sharp.MaterialIcons.Abacus;
            this.materialButton1.IconColor = System.Drawing.Color.White;
            this.materialButton1.IconSize = 20;
            this.materialButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.materialButton1.Location = new System.Drawing.Point(3, 3);
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.Size = new System.Drawing.Size(171, 32);
            this.materialButton1.TabIndex = 0;
            this.materialButton1.Text = "materialButton1";
            this.materialButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.materialButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.materialButton1.UseVisualStyleBackColor = false;
            // 
            // btnCloseForm
            // 
            this.btnCloseForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCloseForm.FlatAppearance.BorderSize = 0;
            this.btnCloseForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseForm.IconChar = FontAwesome.Sharp.IconChar.X;
            this.btnCloseForm.IconColor = System.Drawing.Color.Red;
            this.btnCloseForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCloseForm.IconSize = 16;
            this.btnCloseForm.Location = new System.Drawing.Point(900, 3);
            this.btnCloseForm.Name = "btnCloseForm";
            this.btnCloseForm.Size = new System.Drawing.Size(29, 23);
            this.btnCloseForm.TabIndex = 2;
            this.btnCloseForm.UseVisualStyleBackColor = true;
            this.btnCloseForm.Click += new System.EventHandler(this.btnCloseForm_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Location = new System.Drawing.Point(-1, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(905, 554);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // iconButton1
            // 
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.AngleDoubleLeft;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 20;
            this.iconButton1.Location = new System.Drawing.Point(-1, 3);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(29, 23);
            this.iconButton1.TabIndex = 0;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 609);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ES-Pro Metré";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
>>>>>>> 0cf5c6fdb39fcef30acc765432768250800695bd

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem siteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uomItemList;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.Material.MaterialButton materialButton1;
        private System.Windows.Forms.ToolStripMenuItem boqToolStripMenuItem;
        internal System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton btnCloseForm;
		public System.Windows.Forms.SplitContainer splitContainer1;
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
        private FontAwesome.Sharp.Material.MaterialButton materialButton7;
        private FontAwesome.Sharp.Material.MaterialButton materialButton6;
        private FontAwesome.Sharp.Material.MaterialButton materialButton5;
        private FontAwesome.Sharp.Material.MaterialButton materialButton4;
        private FontAwesome.Sharp.Material.MaterialButton materialButton3;
        private FontAwesome.Sharp.Material.MaterialButton materialButton2;
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
	}
}