
namespace ESProMeter.Views.UnitOfMeasures 
{
	partial class UoMFrm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbNewUoM = new System.Windows.Forms.ToolStripButton();
            this.stbEditUoM = new System.Windows.Forms.ToolStripButton();
            this.stbDeleteUoM = new System.Windows.Forms.ToolStripButton();
            this.stbMakInactive = new System.Windows.Forms.ToolStripButton();
            this.tltRefresh = new System.Windows.Forms.ToolStripButton();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.excelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tlsSelectedRow = new System.Windows.Forms.ToolStripComboBox();
            this.dataUom = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsActive = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addNewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.makeInActiveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reloadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chkInactive = new System.Windows.Forms.CheckBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataUom)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNewUoM,
            this.stbEditUoM,
            this.stbDeleteUoM,
            this.stbMakInactive,
            this.tltRefresh,
            this.toolStripDropDownButton1,
            this.toolStripLabel1,
            this.tlsSelectedRow});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(644, 25);
            this.toolStrip1.TabIndex = 13;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbNewUoM
            // 
            this.tsbNewUoM.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNewUoM.Name = "tsbNewUoM";
            this.tsbNewUoM.Size = new System.Drawing.Size(35, 22);
            this.tsbNewUoM.Text = "New";
            this.tsbNewUoM.Click += new System.EventHandler(this.tsbNewUoM_Click);
            // 
            // stbEditUoM
            // 
            this.stbEditUoM.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.stbEditUoM.Name = "stbEditUoM";
            this.stbEditUoM.Size = new System.Drawing.Size(31, 22);
            this.stbEditUoM.Text = "Edit";
            this.stbEditUoM.Click += new System.EventHandler(this.stbEditUoM_Click);
            // 
            // stbDeleteUoM
            // 
            this.stbDeleteUoM.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.stbDeleteUoM.Name = "stbDeleteUoM";
            this.stbDeleteUoM.Size = new System.Drawing.Size(44, 22);
            this.stbDeleteUoM.Text = "Delete";
            this.stbDeleteUoM.Click += new System.EventHandler(this.stbDeleteUoM_Click);
            // 
            // stbMakInactive
            // 
            this.stbMakInactive.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.stbMakInactive.Name = "stbMakInactive";
            this.stbMakInactive.Size = new System.Drawing.Size(84, 22);
            this.stbMakInactive.Text = "Make Inactive";
            this.stbMakInactive.Click += new System.EventHandler(this.stbMakInactive_Click);
            // 
            // tltRefresh
            // 
            this.tltRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tltRefresh.Name = "tltRefresh";
            this.tltRefresh.Size = new System.Drawing.Size(50, 22);
            this.tltRefresh.Text = "Refresh";
            this.tltRefresh.Click += new System.EventHandler(this.tltRefresh_Click);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.excelToolStripMenuItem});
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(54, 22);
            this.toolStripDropDownButton1.Text = "Export";
            // 
            // excelToolStripMenuItem
            // 
            this.excelToolStripMenuItem.Name = "excelToolStripMenuItem";
            this.excelToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.excelToolStripMenuItem.Text = "Excel";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(35, 22);
            this.toolStripLabel1.Text = "Rows";
            // 
            // tlsSelectedRow
            // 
            this.tlsSelectedRow.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tlsSelectedRow.Items.AddRange(new object[] {
            "50",
            "100",
            "1000",
            "10000"});
            this.tlsSelectedRow.Name = "tlsSelectedRow";
            this.tlsSelectedRow.Size = new System.Drawing.Size(121, 25);
            this.tlsSelectedRow.SelectedIndexChanged += new System.EventHandler(this.tlsSelectedRow_SelectedIndexChanged);
            // 
            // dataUom
            // 
            this.dataUom.AllowUserToAddRows = false;
            this.dataUom.AllowUserToDeleteRows = false;
            this.dataUom.AllowUserToResizeColumns = false;
            this.dataUom.AllowUserToResizeRows = false;
            this.dataUom.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataUom.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataUom.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataUom.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataUom.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataUom.ColumnHeadersHeight = 25;
            this.dataUom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataUom.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.ColName,
            this.Type,
            this.Description,
            this.IsActive,
            this.Column5});
            this.dataUom.EnableHeadersVisualStyles = false;
            this.dataUom.Location = new System.Drawing.Point(0, 53);
            this.dataUom.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataUom.Name = "dataUom";
            this.dataUom.ReadOnly = true;
            this.dataUom.RowHeadersVisible = false;
            this.dataUom.RowHeadersWidth = 4;
            this.dataUom.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataUom.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataUom.Size = new System.Drawing.Size(644, 408);
            this.dataUom.TabIndex = 14;
            this.dataUom.VirtualMode = true;
            this.dataUom.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
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
            // 
            // ColName
            // 
            this.ColName.DataPropertyName = "UOMNAME";
            this.ColName.HeaderText = "Name";
            this.ColName.Name = "ColName";
            this.ColName.ReadOnly = true;
            this.ColName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Type
            // 
            this.Type.DataPropertyName = "Type";
            this.Type.HeaderText = "Type";
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            this.Type.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Type.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Description
            // 
            this.Description.DataPropertyName = "Abbreviation";
            this.Description.HeaderText = "Abbreviation";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            this.Description.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Description.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // IsActive
            // 
            this.IsActive.DataPropertyName = "IsActive";
            this.IsActive.HeaderText = "Active";
            this.IsActive.Name = "IsActive";
            this.IsActive.ReadOnly = true;
            this.IsActive.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "IsDelete";
            this.Column5.HeaderText = "Deleted";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column5.Visible = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewToolStripMenuItem,
            this.editToolStripMenuItem,
            this.makeInActiveToolStripMenuItem,
            this.reloadToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 114);
            // 
            // addNewToolStripMenuItem
            // 
            this.addNewToolStripMenuItem.Name = "addNewToolStripMenuItem";
            this.addNewToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.addNewToolStripMenuItem.Text = "Add New";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // makeInActiveToolStripMenuItem
            // 
            this.makeInActiveToolStripMenuItem.Name = "makeInActiveToolStripMenuItem";
            this.makeInActiveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.makeInActiveToolStripMenuItem.Text = "Make In Active";
            // 
            // reloadToolStripMenuItem
            // 
            this.reloadToolStripMenuItem.Name = "reloadToolStripMenuItem";
            this.reloadToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.reloadToolStripMenuItem.Text = "Refresh";
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // chkInactive
            // 
            this.chkInactive.AutoSize = true;
            this.chkInactive.Location = new System.Drawing.Point(12, 28);
            this.chkInactive.Name = "chkInactive";
            this.chkInactive.Size = new System.Drawing.Size(111, 19);
            this.chkInactive.TabIndex = 15;
            this.chkInactive.Text = "Include InActive";
            this.chkInactive.UseVisualStyleBackColor = true;
            this.chkInactive.CheckedChanged += new System.EventHandler(this.chkInactive_CheckedChanged);
            // 
            // UoMFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 460);
            this.Controls.Add(this.chkInactive);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dataUom);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "UoMFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Unit Of Measure";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataUom)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton tsbNewUoM;
		private System.Windows.Forms.ToolStripButton stbEditUoM;
		private System.Windows.Forms.ToolStripButton stbDeleteUoM;
		private System.Windows.Forms.ToolStripButton stbMakInactive;
		private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
		private System.Windows.Forms.ToolStripMenuItem excelToolStripMenuItem;
		private System.Windows.Forms.DataGridView dataUom;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addNewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem makeInActiveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reloadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton tltRefresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsActive;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox tlsSelectedRow;
        private System.Windows.Forms.CheckBox chkInactive;
    }
}