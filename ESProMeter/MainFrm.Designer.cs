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
			this.listToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.itemListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.siteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.uomItemList = new System.Windows.Forms.ToolStripMenuItem();
			this.divisionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.customerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.customerListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.boqToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.createBoqToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.boqListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.panel1 = new System.Windows.Forms.Panel();
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
            this.customerToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
			this.menuStrip1.Size = new System.Drawing.Size(1040, 36);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(41, 32);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// listToolStripMenuItem
			// 
			this.listToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemListToolStripMenuItem,
            this.siteToolStripMenuItem,
            this.uomItemList,
            this.divisionToolStripMenuItem});
			this.listToolStripMenuItem.Name = "listToolStripMenuItem";
			this.listToolStripMenuItem.Size = new System.Drawing.Size(42, 32);
			this.listToolStripMenuItem.Text = "List";
			// 
			// itemListToolStripMenuItem
			// 
			this.itemListToolStripMenuItem.Name = "itemListToolStripMenuItem";
			this.itemListToolStripMenuItem.Size = new System.Drawing.Size(131, 24);
			this.itemListToolStripMenuItem.Text = "Item List";
			this.itemListToolStripMenuItem.Click += new System.EventHandler(this.itemListToolStripMenuItem_Click);
			// 
			// siteToolStripMenuItem
			// 
			this.siteToolStripMenuItem.Name = "siteToolStripMenuItem";
			this.siteToolStripMenuItem.Size = new System.Drawing.Size(131, 24);
			this.siteToolStripMenuItem.Text = "Site";
			// 
			// uomItemList
			// 
			this.uomItemList.Name = "uomItemList";
			this.uomItemList.Size = new System.Drawing.Size(131, 24);
			this.uomItemList.Text = "Uom";
			this.uomItemList.Click += new System.EventHandler(this.uomItemList_Click);
			// 
			// divisionToolStripMenuItem
			// 
			this.divisionToolStripMenuItem.Name = "divisionToolStripMenuItem";
			this.divisionToolStripMenuItem.Size = new System.Drawing.Size(131, 24);
			this.divisionToolStripMenuItem.Text = "Division";
			// 
			// customerToolStripMenuItem
			// 
			this.customerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customerListToolStripMenuItem,
            this.boqToolStripMenuItem});
			this.customerToolStripMenuItem.Name = "customerToolStripMenuItem";
			this.customerToolStripMenuItem.Size = new System.Drawing.Size(81, 32);
			this.customerToolStripMenuItem.Text = "Customer";
			// 
			// customerListToolStripMenuItem
			// 
			this.customerListToolStripMenuItem.Name = "customerListToolStripMenuItem";
			this.customerListToolStripMenuItem.Size = new System.Drawing.Size(163, 24);
			this.customerListToolStripMenuItem.Text = "Customer List";
			// 
			// boqToolStripMenuItem
			// 
			this.boqToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createBoqToolStripMenuItem,
            this.boqListToolStripMenuItem});
			this.boqToolStripMenuItem.Name = "boqToolStripMenuItem";
			this.boqToolStripMenuItem.Size = new System.Drawing.Size(163, 24);
			this.boqToolStripMenuItem.Text = "Boq";
			// 
			// createBoqToolStripMenuItem
			// 
			this.createBoqToolStripMenuItem.Name = "createBoqToolStripMenuItem";
			this.createBoqToolStripMenuItem.Size = new System.Drawing.Size(146, 24);
			this.createBoqToolStripMenuItem.Text = "Create Boq";
			this.createBoqToolStripMenuItem.Click += new System.EventHandler(this.createBoqToolStripMenuItem_Click);
			// 
			// boqListToolStripMenuItem
			// 
			this.boqListToolStripMenuItem.Name = "boqListToolStripMenuItem";
			this.boqListToolStripMenuItem.Size = new System.Drawing.Size(146, 24);
			this.boqListToolStripMenuItem.Text = "Boq List";
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
			this.splitContainer1.Size = new System.Drawing.Size(1040, 573);
			this.splitContainer1.SplitterDistance = 180;
			this.splitContainer1.SplitterWidth = 1;
			this.splitContainer1.TabIndex = 1;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Transparent;
			this.panel1.Controls.Add(this.materialButton1);
			this.panel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.panel1.Location = new System.Drawing.Point(0, 21);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(180, 552);
			this.panel1.TabIndex = 0;
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
			this.btnCloseForm.Location = new System.Drawing.Point(833, 3);
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
			this.panel2.Size = new System.Drawing.Size(869, 554);
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
			this.iconButton1.Location = new System.Drawing.Point(-1, 2);
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
			this.ClientSize = new System.Drawing.Size(1040, 609);
			this.Controls.Add(this.splitContainer1);
			this.Controls.Add(this.menuStrip1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem siteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uomItemList;
        private System.Windows.Forms.ToolStripMenuItem divisionToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.Material.MaterialButton materialButton1;
        private System.Windows.Forms.ToolStripMenuItem customerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem boqToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createBoqToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem boqListToolStripMenuItem;
        internal System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton btnCloseForm;
    }
}