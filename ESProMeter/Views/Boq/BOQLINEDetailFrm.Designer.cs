namespace ESProMeter.Views.Boq
{
    partial class BOQLINEDetailFrm 
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvBoqItemLine = new System.Windows.Forms.DataGridView();
            this.laborBOQItemLineRefID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewComboBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.laborBOQItemLineQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ButtonColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labourSubtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.laborUomRefID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mbtCancel = new FontAwesome.Sharp.Material.MaterialButton();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBoqItemLine)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dgvBoqItemLine);
            this.groupBox2.Location = new System.Drawing.Point(12, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(717, 383);
            this.groupBox2.TabIndex = 41;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "BOQ ITEM LINE";
            // 
            // dgvBoqItemLine
            // 
            this.dgvBoqItemLine.AllowUserToAddRows = false;
            this.dgvBoqItemLine.AllowUserToDeleteRows = false;
            this.dgvBoqItemLine.AllowUserToResizeColumns = false;
            this.dgvBoqItemLine.AllowUserToResizeRows = false;
            this.dgvBoqItemLine.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBoqItemLine.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBoqItemLine.ColumnHeadersHeight = 25;
            this.dgvBoqItemLine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvBoqItemLine.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.laborBOQItemLineRefID,
            this.dataGridViewComboBoxColumn1,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.laborBOQItemLineQty,
            this.ButtonColumn1,
            this.labourSubtotal,
            this.laborUomRefID,
            this.Column1,
            this.dataGridViewTextBoxColumn3});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBoqItemLine.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvBoqItemLine.EnableHeadersVisualStyles = false;
            this.dgvBoqItemLine.Location = new System.Drawing.Point(13, 26);
            this.dgvBoqItemLine.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvBoqItemLine.MultiSelect = false;
            this.dgvBoqItemLine.Name = "dgvBoqItemLine";
            this.dgvBoqItemLine.RowHeadersVisible = false;
            this.dgvBoqItemLine.RowTemplate.Height = 25;
            this.dgvBoqItemLine.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBoqItemLine.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvBoqItemLine.Size = new System.Drawing.Size(697, 339);
            this.dgvBoqItemLine.TabIndex = 1;
            // 
            // laborBOQItemLineRefID
            // 
            this.laborBOQItemLineRefID.DataPropertyName = "BOQITEMITEMLINEID";
            this.laborBOQItemLineRefID.HeaderText = "ItemID";
            this.laborBOQItemLineRefID.MinimumWidth = 2;
            this.laborBOQItemLineRefID.Name = "laborBOQItemLineRefID";
            this.laborBOQItemLineRefID.ReadOnly = true;
            this.laborBOQItemLineRefID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.laborBOQItemLineRefID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.laborBOQItemLineRefID.Width = 2;
            // 
            // dataGridViewComboBoxColumn1
            // 
            this.dataGridViewComboBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewComboBoxColumn1.DataPropertyName = "BOQITEMITEMLINENAME";
            this.dataGridViewComboBoxColumn1.HeaderText = "Item Name";
            this.dataGridViewComboBoxColumn1.MinimumWidth = 100;
            this.dataGridViewComboBoxColumn1.Name = "dataGridViewComboBoxColumn1";
            this.dataGridViewComboBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewComboBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "BOQITEMITEMLINETYPE";
            this.dataGridViewTextBoxColumn1.HeaderText = "ItemType";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "UOM";
            this.dataGridViewTextBoxColumn2.HeaderText = "UOM";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // laborBOQItemLineQty
            // 
            this.laborBOQItemLineQty.DataPropertyName = "BOQITEMLINEQTY";
            this.laborBOQItemLineQty.HeaderText = "Quantity";
            this.laborBOQItemLineQty.Name = "laborBOQItemLineQty";
            this.laborBOQItemLineQty.ReadOnly = true;
            this.laborBOQItemLineQty.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.laborBOQItemLineQty.Width = 80;
            // 
            // ButtonColumn1
            // 
            this.ButtonColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ButtonColumn1.DataPropertyName = "COST";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            this.ButtonColumn1.DefaultCellStyle = dataGridViewCellStyle2;
            this.ButtonColumn1.HeaderText = "Cost";
            this.ButtonColumn1.Name = "ButtonColumn1";
            this.ButtonColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ButtonColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // labourSubtotal
            // 
            this.labourSubtotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.labourSubtotal.DataPropertyName = "SUBCOST";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.labourSubtotal.DefaultCellStyle = dataGridViewCellStyle3;
            this.labourSubtotal.HeaderText = "Sub Total";
            this.labourSubtotal.Name = "labourSubtotal";
            this.labourSubtotal.ReadOnly = true;
            this.labourSubtotal.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.labourSubtotal.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // laborUomRefID
            // 
            this.laborUomRefID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.laborUomRefID.DataPropertyName = "BOQITEMLINEUOMID";
            this.laborUomRefID.HeaderText = "UomID";
            this.laborUomRefID.MinimumWidth = 2;
            this.laborUomRefID.Name = "laborUomRefID";
            this.laborUomRefID.ReadOnly = true;
            this.laborUomRefID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.laborUomRefID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.laborUomRefID.Width = 2;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "DESCRIPTION";
            this.Column1.HeaderText = "DESCRIPTION";
            this.Column1.MinimumWidth = 100;
            this.Column1.Name = "Column1";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "BOQITEMLINESEQ";
            this.dataGridViewTextBoxColumn3.HeaderText = "Order";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn3.Visible = false;
            this.dataGridViewTextBoxColumn3.Width = 60;
            // 
            // mbtCancel
            // 
            this.mbtCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.mbtCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mbtCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mbtCancel.ForeColor = System.Drawing.Color.White;
            this.mbtCancel.IconChar = FontAwesome.Sharp.MaterialIcons.None;
            this.mbtCancel.IconColor = System.Drawing.Color.White;
            this.mbtCancel.IconSize = 1;
            this.mbtCancel.Location = new System.Drawing.Point(603, 408);
            this.mbtCancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.mbtCancel.Name = "mbtCancel";
            this.mbtCancel.Size = new System.Drawing.Size(126, 30);
            this.mbtCancel.TabIndex = 36;
            this.mbtCancel.Text = "Close";
            this.mbtCancel.UseVisualStyleBackColor = false;
            this.mbtCancel.Click += new System.EventHandler(this.mbtCancel_Click);
            // 
            // BOQLINEDetailFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 445);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.mbtCancel);
            this.Name = "BOQLINEDetailFrm";
            this.Text = "BOQLINE DETAILS";
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBoqItemLine)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private FontAwesome.Sharp.Material.MaterialButton mbtCancel;
        private System.Windows.Forms.DataGridView dgvBoqItemLine;
        private System.Windows.Forms.DataGridViewTextBoxColumn laborBOQItemLineRefID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewComboBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn laborBOQItemLineQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn ButtonColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn labourSubtotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn laborUomRefID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}