namespace ESProMeter.Views.Item
{
    partial class ListImportFrm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListImportFrm));
            this.label1 = new System.Windows.Forms.Label();
            this.dataItemList = new System.Windows.Forms.DataGridView();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UOMID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UomName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Active = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.textSearch = new System.Windows.Forms.TextBox();
            this.btnSave = new FontAwesome.Sharp.Material.MaterialButton();
            this.btnClose = new FontAwesome.Sharp.Material.MaterialButton();
            this.btnOpen = new FontAwesome.Sharp.Material.MaterialButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataItemList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Search";
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
            this.ItemName,
            this.ItemType,
            this.UOMID,
            this.UomName,
            this.Cost,
            this.itemDesc,
            this.Active});
            this.dataItemList.EnableHeadersVisualStyles = false;
            this.dataItemList.GridColor = System.Drawing.Color.IndianRed;
            this.dataItemList.Location = new System.Drawing.Point(2, 52);
            this.dataItemList.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataItemList.MultiSelect = false;
            this.dataItemList.Name = "dataItemList";
            this.dataItemList.ReadOnly = true;
            this.dataItemList.RowHeadersVisible = false;
            this.dataItemList.RowTemplate.Height = 25;
            this.dataItemList.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataItemList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataItemList.Size = new System.Drawing.Size(997, 426);
            this.dataItemList.TabIndex = 6;
            this.dataItemList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataItemList_CellContentClick);
            this.dataItemList.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataItemList_CellFormatting);
            // 
            // ItemName
            // 
            this.ItemName.DataPropertyName = "ItemName";
            this.ItemName.FillWeight = 138.1693F;
            this.ItemName.HeaderText = "Item Name";
            this.ItemName.Name = "ItemName";
            this.ItemName.ReadOnly = true;
            this.ItemName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ItemName.Width = 200;
            // 
            // ItemType
            // 
            this.ItemType.DataPropertyName = "ItemType";
            this.ItemType.FillWeight = 65.11635F;
            this.ItemType.HeaderText = "Type";
            this.ItemType.Name = "ItemType";
            this.ItemType.ReadOnly = true;
            this.ItemType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ItemType.Width = 94;
            // 
            // UOMID
            // 
            this.UOMID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.UOMID.DataPropertyName = "UOMID";
            this.UOMID.HeaderText = "UOMID";
            this.UOMID.Name = "UOMID";
            this.UOMID.ReadOnly = true;
            this.UOMID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // UomName
            // 
            this.UomName.DataPropertyName = "UomName";
            this.UomName.FillWeight = 68.39866F;
            this.UomName.HeaderText = "Uom";
            this.UomName.Name = "UomName";
            this.UomName.ReadOnly = true;
            this.UomName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.UomName.Width = 99;
            // 
            // Cost
            // 
            this.Cost.DataPropertyName = "Cost";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Cost.DefaultCellStyle = dataGridViewCellStyle2;
            this.Cost.FillWeight = 142.993F;
            this.Cost.HeaderText = "Cost";
            this.Cost.Name = "Cost";
            this.Cost.ReadOnly = true;
            this.Cost.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // itemDesc
            // 
            this.itemDesc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.itemDesc.DataPropertyName = "Description";
            this.itemDesc.FillWeight = 108.7606F;
            this.itemDesc.HeaderText = "Description";
            this.itemDesc.Name = "itemDesc";
            this.itemDesc.ReadOnly = true;
            this.itemDesc.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
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
            // textSearch
            // 
            this.textSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textSearch.Location = new System.Drawing.Point(52, 22);
            this.textSearch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textSearch.Name = "textSearch";
            this.textSearch.ReadOnly = true;
            this.textSearch.Size = new System.Drawing.Size(904, 23);
            this.textSearch.TabIndex = 5;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(130)))), ((int)(((byte)(200)))));
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.IconChar = FontAwesome.Sharp.MaterialIcons.None;
            this.btnSave.IconColor = System.Drawing.Color.White;
            this.btnSave.IconSize = 20;
            this.btnSave.Location = new System.Drawing.Point(781, 484);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(98, 30);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Import";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.IconChar = FontAwesome.Sharp.MaterialIcons.None;
            this.btnClose.IconColor = System.Drawing.Color.White;
            this.btnClose.IconSize = 22;
            this.btnClose.Location = new System.Drawing.Point(896, 484);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(103, 30);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Close";
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.ButtonCloseClick);
            // 
            // btnOpen
            // 
            this.btnOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpen.IconChar = FontAwesome.Sharp.MaterialIcons.DotsHorizontal;
            this.btnOpen.IconColor = System.Drawing.Color.Black;
            this.btnOpen.IconSize = 22;
            this.btnOpen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpen.Location = new System.Drawing.Point(963, 22);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(36, 23);
            this.btnOpen.TabIndex = 10;
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(430, 215);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(94, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            this.pictureBox1.WaitOnLoad = true;
            // 
            // ListImportFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 517);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textSearch);
            this.Controls.Add(this.dataItemList);
            this.Name = "ListImportFrm";
            this.Text = "ListImportFrm";
            ((System.ComponentModel.ISupportInitialize)(this.dataItemList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataItemList;
        private System.Windows.Forms.TextBox textSearch;
        private FontAwesome.Sharp.Material.MaterialButton btnSave;
        private FontAwesome.Sharp.Material.MaterialButton btnClose;
        private FontAwesome.Sharp.Material.MaterialButton btnOpen;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemType;
        private System.Windows.Forms.DataGridViewTextBoxColumn UOMID;
        private System.Windows.Forms.DataGridViewTextBoxColumn UomName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemDesc;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Active;
    }
}