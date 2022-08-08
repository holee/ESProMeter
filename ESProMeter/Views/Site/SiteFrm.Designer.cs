
namespace ESProMeter.Views.Sites
{
	partial class SiteFrm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SiteFrm));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.tsbNewSite = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
			this.tlsDelete = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
			this.stbMakInactive = new System.Windows.Forms.ToolStripButton();
			this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
			this.excelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
			this.tlsRows = new System.Windows.Forms.ToolStripComboBox();
			this.siteDataGrid = new System.Windows.Forms.DataGridView();
			this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.IsActive = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.chkInlcudeInActive = new System.Windows.Forms.CheckBox();
			this.toolStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.siteDataGrid)).BeginInit();
			this.SuspendLayout();
			// 
			// toolStrip1
			// 
			this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNewSite,
            this.toolStripButton2,
            this.tlsDelete,
            this.toolStripButton4,
            this.stbMakInactive,
            this.toolStripDropDownButton1,
            this.toolStripLabel1,
            this.tlsRows});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
			this.toolStrip1.Size = new System.Drawing.Size(1342, 25);
			this.toolStrip1.TabIndex = 11;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// tsbNewSite
			// 
			this.tsbNewSite.Image = ((System.Drawing.Image)(resources.GetObject("tsbNewSite.Image")));
			this.tsbNewSite.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbNewSite.Name = "tsbNewSite";
			this.tsbNewSite.Size = new System.Drawing.Size(51, 22);
			this.tsbNewSite.Text = "New";
			this.tsbNewSite.Click += new System.EventHandler(this.tsbNewSite_Click);
			// 
			// toolStripButton2
			// 
			this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
			this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton2.Name = "toolStripButton2";
			this.toolStripButton2.Size = new System.Drawing.Size(47, 22);
			this.toolStripButton2.Text = "Edit";
			this.toolStripButton2.Click += new System.EventHandler(this.tslSiteEditClick);
			// 
			// tlsDelete
			// 
			this.tlsDelete.Image = ((System.Drawing.Image)(resources.GetObject("tlsDelete.Image")));
			this.tlsDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tlsDelete.Name = "tlsDelete";
			this.tlsDelete.Size = new System.Drawing.Size(60, 22);
			this.tlsDelete.Text = "Delete";
			this.tlsDelete.Click += new System.EventHandler(this.tlsDelete_Click);
			// 
			// toolStripButton4
			// 
			this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
			this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton4.Name = "toolStripButton4";
			this.toolStripButton4.Size = new System.Drawing.Size(66, 22);
			this.toolStripButton4.Text = "Refresh";
			this.toolStripButton4.Click += new System.EventHandler(this.tlsRefreshClick);
			// 
			// stbMakInactive
			// 
			this.stbMakInactive.Image = ((System.Drawing.Image)(resources.GetObject("stbMakInactive.Image")));
			this.stbMakInactive.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.stbMakInactive.Name = "stbMakInactive";
			this.stbMakInactive.Size = new System.Drawing.Size(100, 22);
			this.stbMakInactive.Text = "Make Inactive";
			this.stbMakInactive.Click += new System.EventHandler(this.stbMakInactive_Click);
			// 
			// toolStripDropDownButton1
			// 
			this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.excelToolStripMenuItem});
			this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
			this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
			this.toolStripDropDownButton1.Size = new System.Drawing.Size(70, 22);
			this.toolStripDropDownButton1.Text = "Export";
			// 
			// excelToolStripMenuItem
			// 
			this.excelToolStripMenuItem.Name = "excelToolStripMenuItem";
			this.excelToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
			this.excelToolStripMenuItem.Text = "Excel";
			this.excelToolStripMenuItem.Click += new System.EventHandler(this.excelToolStripMenuItem_Click);
			// 
			// toolStripLabel1
			// 
			this.toolStripLabel1.Name = "toolStripLabel1";
			this.toolStripLabel1.Size = new System.Drawing.Size(35, 22);
			this.toolStripLabel1.Text = "Rows";
			// 
			// tlsRows
			// 
			this.tlsRows.AutoSize = false;
			this.tlsRows.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.tlsRows.Items.AddRange(new object[] {
            "50",
            "100",
            "1000",
            "10000"});
			this.tlsRows.Name = "tlsRows";
			this.tlsRows.Size = new System.Drawing.Size(100, 23);
			this.tlsRows.SelectedIndexChanged += new System.EventHandler(this.tlsRows_SelectedIndexChanged);
			// 
			// siteDataGrid
			// 
			this.siteDataGrid.AllowUserToAddRows = false;
			this.siteDataGrid.AllowUserToDeleteRows = false;
			this.siteDataGrid.AllowUserToResizeRows = false;
			this.siteDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.siteDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.siteDataGrid.BackgroundColor = System.Drawing.Color.White;
			this.siteDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.siteDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.siteDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.siteDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.IsActive,
            this.Column8,
            this.Column9,
            this.Column10});
			this.siteDataGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.siteDataGrid.Location = new System.Drawing.Point(0, 32);
			this.siteDataGrid.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.siteDataGrid.Name = "siteDataGrid";
			this.siteDataGrid.ReadOnly = true;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.siteDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.siteDataGrid.RowHeadersVisible = false;
			this.siteDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.siteDataGrid.Size = new System.Drawing.Size(1342, 684);
			this.siteDataGrid.TabIndex = 12;
			this.siteDataGrid.SelectionChanged += new System.EventHandler(this.SiteGridSelectionChanged);
			// 
			// ID
			// 
			this.ID.DataPropertyName = "ID";
			this.ID.HeaderText = "Column1";
			this.ID.MinimumWidth = 2;
			this.ID.Name = "ID";
			this.ID.ReadOnly = true;
			this.ID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.ID.Visible = false;
			// 
			// Column2
			// 
			this.Column2.DataPropertyName = "SITENAME";
			this.Column2.HeaderText = "Site Name";
			this.Column2.Name = "Column2";
			this.Column2.ReadOnly = true;
			// 
			// Column3
			// 
			this.Column3.DataPropertyName = "CUSTOMERNAME";
			this.Column3.HeaderText = "Customer";
			this.Column3.Name = "Column3";
			this.Column3.ReadOnly = true;
			// 
			// Column4
			// 
			this.Column4.DataPropertyName = "ADDRESS";
			this.Column4.HeaderText = "Address";
			this.Column4.Name = "Column4";
			this.Column4.ReadOnly = true;
			// 
			// Column5
			// 
			this.Column5.DataPropertyName = "PROVINCE";
			this.Column5.HeaderText = "Province/City";
			this.Column5.Name = "Column5";
			this.Column5.ReadOnly = true;
			// 
			// Column6
			// 
			this.Column6.DataPropertyName = "COUNTRY";
			this.Column6.HeaderText = "Country";
			this.Column6.Name = "Column6";
			this.Column6.ReadOnly = true;
			// 
			// IsActive
			// 
			this.IsActive.DataPropertyName = "IsActive";
			this.IsActive.HeaderText = "Active";
			this.IsActive.Name = "IsActive";
			this.IsActive.ReadOnly = true;
			this.IsActive.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.IsActive.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			// 
			// Column8
			// 
			this.Column8.DataPropertyName = "AddrRefId";
			this.Column8.HeaderText = "Column8";
			this.Column8.Name = "Column8";
			this.Column8.ReadOnly = true;
			this.Column8.Visible = false;
			// 
			// Column9
			// 
			this.Column9.DataPropertyName = "CustRefId";
			this.Column9.HeaderText = "Column9";
			this.Column9.Name = "Column9";
			this.Column9.ReadOnly = true;
			this.Column9.Visible = false;
			// 
			// Column10
			// 
			this.Column10.DataPropertyName = "IsDelete";
			this.Column10.HeaderText = "Column10";
			this.Column10.Name = "Column10";
			this.Column10.ReadOnly = true;
			this.Column10.Visible = false;
			// 
			// chkInlcudeInActive
			// 
			this.chkInlcudeInActive.AutoSize = true;
			this.chkInlcudeInActive.Location = new System.Drawing.Point(624, 6);
			this.chkInlcudeInActive.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.chkInlcudeInActive.Name = "chkInlcudeInActive";
			this.chkInlcudeInActive.Size = new System.Drawing.Size(109, 19);
			this.chkInlcudeInActive.TabIndex = 13;
			this.chkInlcudeInActive.Text = "Include Inactive";
			this.chkInlcudeInActive.UseVisualStyleBackColor = true;
			this.chkInlcudeInActive.CheckedChanged += new System.EventHandler(this.chkInlcudeInActive_CheckedChanged);
			// 
			// SiteFrm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1342, 715);
			this.Controls.Add(this.chkInlcudeInActive);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.siteDataGrid);
			this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.Name = "SiteFrm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "SiteFrm";
			this.Load += new System.EventHandler(this.SiteFrm_Load);
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.siteDataGrid)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton tsbNewSite;
		private System.Windows.Forms.ToolStripButton toolStripButton2;
		private System.Windows.Forms.ToolStripButton tlsDelete;
		private System.Windows.Forms.ToolStripButton toolStripButton4;
		private System.Windows.Forms.ToolStripButton stbMakInactive;
		private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
		private System.Windows.Forms.ToolStripMenuItem excelToolStripMenuItem;
		private System.Windows.Forms.DataGridView siteDataGrid;
		private System.Windows.Forms.CheckBox chkInlcudeInActive;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox tlsRows;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsActive;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
    }
}