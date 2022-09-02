namespace ESProMeter.Views.Boq
{
    partial class BOQLINEFrm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dgvBoqItemLine = new System.Windows.Forms.DataGridView();
            this.laborBOQItemLineRefID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewComboBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.laborBOQItemLineQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ButtonColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labourSubtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.laborUomRefID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSubtotalBoqItem = new System.Windows.Forms.TextBox();
            this.mbtNext = new FontAwesome.Sharp.Material.MaterialButton();
            this.mbtCancel = new FontAwesome.Sharp.Material.MaterialButton();
            this.lblBoqID = new System.Windows.Forms.Label();
            this.lblBoqItemID = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.txtsalePrice = new System.Windows.Forms.TextBox();
            this.txtBoqCOST = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtMarginValue = new System.Windows.Forms.TextBox();
            this.txtMargin = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSubtotalMagrinAndInflation = new System.Windows.Forms.TextBox();
            this.txtInflationValue = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtInflation = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.txtLoseEfficencyValue = new System.Windows.Forms.TextBox();
            this.txtLoseEffecency = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.txtAdditionalSubTotal = new System.Windows.Forms.TextBox();
            this.txtTransportationValue = new System.Windows.Forms.TextBox();
            this.txtTransportation = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.txtSaftyValue = new System.Windows.Forms.TextBox();
            this.txtSafty = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.txtOverheadValue = new System.Windows.Forms.TextBox();
            this.txtOperationValue = new System.Windows.Forms.TextBox();
            this.txtOverhead = new System.Windows.Forms.TextBox();
            this.txtOperation = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBoqItemLine)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.dgvBoqItemLine);
            this.groupBox2.Controls.Add(this.txtSubtotalBoqItem);
            this.groupBox2.Location = new System.Drawing.Point(12, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(718, 383);
            this.groupBox2.TabIndex = 41;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "BOQ ITEM LINE";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(431, 358);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 15);
            this.label12.TabIndex = 39;
            this.label12.Text = "Sub Total";
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
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBoqItemLine.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
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
            this.dataGridViewTextBoxColumn3});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBoqItemLine.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvBoqItemLine.EnableHeadersVisualStyles = false;
            this.dgvBoqItemLine.Location = new System.Drawing.Point(13, 26);
            this.dgvBoqItemLine.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvBoqItemLine.MultiSelect = false;
            this.dgvBoqItemLine.Name = "dgvBoqItemLine";
            this.dgvBoqItemLine.RowHeadersVisible = false;
            this.dgvBoqItemLine.RowTemplate.Height = 25;
            this.dgvBoqItemLine.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBoqItemLine.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBoqItemLine.Size = new System.Drawing.Size(698, 322);
            this.dgvBoqItemLine.TabIndex = 1;
            this.dgvBoqItemLine.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvBoqItemLine_CellFormatting);
            // 
            // laborBOQItemLineRefID
            // 
            this.laborBOQItemLineRefID.DataPropertyName = "BOQITEMLINEID";
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
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            this.ButtonColumn1.DefaultCellStyle = dataGridViewCellStyle6;
            this.ButtonColumn1.HeaderText = "Unit Cost";
            this.ButtonColumn1.Name = "ButtonColumn1";
            this.ButtonColumn1.ReadOnly = true;
            this.ButtonColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ButtonColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // labourSubtotal
            // 
            this.labourSubtotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.labourSubtotal.DataPropertyName = "SUBCOST";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.labourSubtotal.DefaultCellStyle = dataGridViewCellStyle7;
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
            // txtSubtotalBoqItem
            // 
            this.txtSubtotalBoqItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSubtotalBoqItem.Location = new System.Drawing.Point(492, 354);
            this.txtSubtotalBoqItem.Name = "txtSubtotalBoqItem";
            this.txtSubtotalBoqItem.ReadOnly = true;
            this.txtSubtotalBoqItem.Size = new System.Drawing.Size(220, 23);
            this.txtSubtotalBoqItem.TabIndex = 35;
            this.txtSubtotalBoqItem.Text = "0";
            this.txtSubtotalBoqItem.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // mbtNext
            // 
            this.mbtNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.mbtNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(130)))), ((int)(((byte)(200)))));
            this.mbtNext.FlatAppearance.BorderColor = System.Drawing.Color.MediumOrchid;
            this.mbtNext.FlatAppearance.BorderSize = 2;
            this.mbtNext.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.mbtNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mbtNext.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.mbtNext.IconChar = FontAwesome.Sharp.MaterialIcons.None;
            this.mbtNext.IconColor = System.Drawing.Color.White;
            this.mbtNext.IconSize = 1;
            this.mbtNext.Location = new System.Drawing.Point(896, 408);
            this.mbtNext.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.mbtNext.Name = "mbtNext";
            this.mbtNext.Size = new System.Drawing.Size(126, 30);
            this.mbtNext.TabIndex = 35;
            this.mbtNext.Text = "Change";
            this.mbtNext.UseVisualStyleBackColor = false;
            this.mbtNext.Click += new System.EventHandler(this.mbtNext_Click);
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
            this.mbtCancel.Location = new System.Drawing.Point(1030, 408);
            this.mbtCancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.mbtCancel.Name = "mbtCancel";
            this.mbtCancel.Size = new System.Drawing.Size(126, 30);
            this.mbtCancel.TabIndex = 36;
            this.mbtCancel.Text = "Cancel";
            this.mbtCancel.UseVisualStyleBackColor = false;
            this.mbtCancel.Click += new System.EventHandler(this.mbtCancel_Click);
            // 
            // lblBoqID
            // 
            this.lblBoqID.AutoSize = true;
            this.lblBoqID.Location = new System.Drawing.Point(433, 401);
            this.lblBoqID.Name = "lblBoqID";
            this.lblBoqID.Size = new System.Drawing.Size(13, 15);
            this.lblBoqID.TabIndex = 38;
            this.lblBoqID.Text = "0";
            // 
            // lblBoqItemID
            // 
            this.lblBoqItemID.AutoSize = true;
            this.lblBoqItemID.Location = new System.Drawing.Point(452, 399);
            this.lblBoqItemID.Name = "lblBoqItemID";
            this.lblBoqItemID.Size = new System.Drawing.Size(13, 15);
            this.lblBoqItemID.TabIndex = 38;
            this.lblBoqItemID.Text = "0";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.textBox4);
            this.groupBox4.Controls.Add(this.txtsalePrice);
            this.groupBox4.Controls.Add(this.txtBoqCOST);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox4.Location = new System.Drawing.Point(736, 328);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(420, 68);
            this.groupBox4.TabIndex = 43;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "OTHERS";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(184, 84);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(55, 15);
            this.label15.TabIndex = 38;
            this.label15.Text = "Sub Total";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(242, 80);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(172, 23);
            this.textBox4.TabIndex = 34;
            this.textBox4.Text = "0";
            // 
            // txtsalePrice
            // 
            this.txtsalePrice.Location = new System.Drawing.Point(119, 39);
            this.txtsalePrice.Name = "txtsalePrice";
            this.txtsalePrice.ReadOnly = true;
            this.txtsalePrice.Size = new System.Drawing.Size(296, 23);
            this.txtsalePrice.TabIndex = 31;
            this.txtsalePrice.Text = "0";
            this.txtsalePrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtBoqCOST
            // 
            this.txtBoqCOST.Location = new System.Drawing.Point(120, 13);
            this.txtBoqCOST.Name = "txtBoqCOST";
            this.txtBoqCOST.ReadOnly = true;
            this.txtBoqCOST.Size = new System.Drawing.Size(295, 23);
            this.txtBoqCOST.TabIndex = 31;
            this.txtBoqCOST.Text = "0";
            this.txtBoqCOST.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(9, 42);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(67, 15);
            this.label14.TabIndex = 38;
            this.label14.Text = "SALE PRICE";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(9, 19);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(93, 15);
            this.label13.TabIndex = 38;
            this.label13.Text = "BOQ ITEM COST";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.txtMarginValue);
            this.groupBox3.Controls.Add(this.txtMargin);
            this.groupBox3.Controls.Add(this.textBox11);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txtSubtotalMagrinAndInflation);
            this.groupBox3.Controls.Add(this.txtInflationValue);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtInflation);
            this.groupBox3.Controls.Add(this.textBox10);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox3.Location = new System.Drawing.Point(737, 209);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(420, 113);
            this.groupBox3.TabIndex = 44;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "MARGIN AND INFLATION";
            // 
            // txtMarginValue
            // 
            this.txtMarginValue.Location = new System.Drawing.Point(296, 22);
            this.txtMarginValue.Name = "txtMarginValue";
            this.txtMarginValue.ReadOnly = true;
            this.txtMarginValue.Size = new System.Drawing.Size(118, 23);
            this.txtMarginValue.TabIndex = 34;
            this.txtMarginValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtMargin
            // 
            this.txtMargin.Location = new System.Drawing.Point(125, 22);
            this.txtMargin.Name = "txtMargin";
            this.txtMargin.Size = new System.Drawing.Size(111, 23);
            this.txtMargin.TabIndex = 34;
            this.txtMargin.Text = "0";
            this.txtMargin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(242, 51);
            this.textBox11.Name = "textBox11";
            this.textBox11.ReadOnly = true;
            this.textBox11.Size = new System.Drawing.Size(48, 23);
            this.textBox11.TabIndex = 34;
            this.textBox11.Text = "%";
            this.textBox11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(184, 84);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 15);
            this.label9.TabIndex = 38;
            this.label9.Text = "Sub Total";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 15);
            this.label6.TabIndex = 38;
            this.label6.Text = "MARGIN";
            // 
            // txtSubtotalMagrinAndInflation
            // 
            this.txtSubtotalMagrinAndInflation.Location = new System.Drawing.Point(242, 80);
            this.txtSubtotalMagrinAndInflation.Name = "txtSubtotalMagrinAndInflation";
            this.txtSubtotalMagrinAndInflation.ReadOnly = true;
            this.txtSubtotalMagrinAndInflation.Size = new System.Drawing.Size(172, 23);
            this.txtSubtotalMagrinAndInflation.TabIndex = 34;
            this.txtSubtotalMagrinAndInflation.Text = "0";
            this.txtSubtotalMagrinAndInflation.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtInflationValue
            // 
            this.txtInflationValue.Location = new System.Drawing.Point(296, 51);
            this.txtInflationValue.Name = "txtInflationValue";
            this.txtInflationValue.ReadOnly = true;
            this.txtInflationValue.Size = new System.Drawing.Size(118, 23);
            this.txtInflationValue.TabIndex = 34;
            this.txtInflationValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 15);
            this.label7.TabIndex = 38;
            this.label7.Text = "INFLATION";
            // 
            // txtInflation
            // 
            this.txtInflation.Location = new System.Drawing.Point(125, 51);
            this.txtInflation.Name = "txtInflation";
            this.txtInflation.Size = new System.Drawing.Size(111, 23);
            this.txtInflation.TabIndex = 34;
            this.txtInflation.Text = "0";
            this.txtInflation.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(242, 22);
            this.textBox10.Name = "textBox10";
            this.textBox10.ReadOnly = true;
            this.textBox10.Size = new System.Drawing.Size(48, 23);
            this.textBox10.TabIndex = 34;
            this.textBox10.Text = "%";
            this.textBox10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.textBox12);
            this.groupBox1.Controls.Add(this.txtLoseEfficencyValue);
            this.groupBox1.Controls.Add(this.txtLoseEffecency);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBox9);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox8);
            this.groupBox1.Controls.Add(this.txtAdditionalSubTotal);
            this.groupBox1.Controls.Add(this.txtTransportationValue);
            this.groupBox1.Controls.Add(this.txtTransportation);
            this.groupBox1.Controls.Add(this.textBox7);
            this.groupBox1.Controls.Add(this.txtSaftyValue);
            this.groupBox1.Controls.Add(this.txtSafty);
            this.groupBox1.Controls.Add(this.textBox6);
            this.groupBox1.Controls.Add(this.txtOverheadValue);
            this.groupBox1.Controls.Add(this.txtOperationValue);
            this.groupBox1.Controls.Add(this.txtOverhead);
            this.groupBox1.Controls.Add(this.txtOperation);
            this.groupBox1.Location = new System.Drawing.Point(736, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(420, 195);
            this.groupBox1.TabIndex = 45;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "BOQ ADDITIONAL COST SETTINGS";
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(242, 21);
            this.textBox12.Name = "textBox12";
            this.textBox12.ReadOnly = true;
            this.textBox12.Size = new System.Drawing.Size(48, 23);
            this.textBox12.TabIndex = 31;
            this.textBox12.Text = "%";
            this.textBox12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtLoseEfficencyValue
            // 
            this.txtLoseEfficencyValue.Location = new System.Drawing.Point(296, 21);
            this.txtLoseEfficencyValue.Name = "txtLoseEfficencyValue";
            this.txtLoseEfficencyValue.ReadOnly = true;
            this.txtLoseEfficencyValue.Size = new System.Drawing.Size(118, 23);
            this.txtLoseEfficencyValue.TabIndex = 31;
            this.txtLoseEfficencyValue.Text = "0";
            this.txtLoseEfficencyValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtLoseEffecency
            // 
            this.txtLoseEffecency.Location = new System.Drawing.Point(125, 21);
            this.txtLoseEffecency.Name = "txtLoseEffecency";
            this.txtLoseEffecency.Size = new System.Drawing.Size(111, 23);
            this.txtLoseEffecency.TabIndex = 31;
            this.txtLoseEffecency.Text = "0";
            this.txtLoseEffecency.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(179, 170);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 15);
            this.label8.TabIndex = 38;
            this.label8.Text = "Sub Total";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 15);
            this.label4.TabIndex = 38;
            this.label4.Text = "TRANSPORTATION";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 15);
            this.label2.TabIndex = 38;
            this.label2.Text = "SAFTY";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 38;
            this.label1.Text = "OVERHEAD";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 15);
            this.label5.TabIndex = 38;
            this.label5.Text = "OPERATION";
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(242, 137);
            this.textBox9.Name = "textBox9";
            this.textBox9.ReadOnly = true;
            this.textBox9.Size = new System.Drawing.Size(48, 23);
            this.textBox9.TabIndex = 34;
            this.textBox9.Text = "%";
            this.textBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 15);
            this.label3.TabIndex = 39;
            this.label3.Text = "LOSEEFFICENCY";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(242, 108);
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(48, 23);
            this.textBox8.TabIndex = 34;
            this.textBox8.Text = "%";
            this.textBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAdditionalSubTotal
            // 
            this.txtAdditionalSubTotal.Location = new System.Drawing.Point(236, 166);
            this.txtAdditionalSubTotal.Name = "txtAdditionalSubTotal";
            this.txtAdditionalSubTotal.ReadOnly = true;
            this.txtAdditionalSubTotal.Size = new System.Drawing.Size(178, 23);
            this.txtAdditionalSubTotal.TabIndex = 34;
            this.txtAdditionalSubTotal.Text = "0";
            this.txtAdditionalSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTransportationValue
            // 
            this.txtTransportationValue.Location = new System.Drawing.Point(296, 137);
            this.txtTransportationValue.Name = "txtTransportationValue";
            this.txtTransportationValue.ReadOnly = true;
            this.txtTransportationValue.Size = new System.Drawing.Size(118, 23);
            this.txtTransportationValue.TabIndex = 34;
            this.txtTransportationValue.Text = "0";
            this.txtTransportationValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTransportation
            // 
            this.txtTransportation.Location = new System.Drawing.Point(125, 137);
            this.txtTransportation.Name = "txtTransportation";
            this.txtTransportation.Size = new System.Drawing.Size(111, 23);
            this.txtTransportation.TabIndex = 34;
            this.txtTransportation.Text = "0";
            this.txtTransportation.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(242, 79);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(48, 23);
            this.textBox7.TabIndex = 34;
            this.textBox7.Text = "%";
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSaftyValue
            // 
            this.txtSaftyValue.Location = new System.Drawing.Point(296, 108);
            this.txtSaftyValue.Name = "txtSaftyValue";
            this.txtSaftyValue.ReadOnly = true;
            this.txtSaftyValue.Size = new System.Drawing.Size(118, 23);
            this.txtSaftyValue.TabIndex = 34;
            this.txtSaftyValue.Text = "0";
            this.txtSaftyValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtSafty
            // 
            this.txtSafty.Location = new System.Drawing.Point(125, 108);
            this.txtSafty.Name = "txtSafty";
            this.txtSafty.Size = new System.Drawing.Size(111, 23);
            this.txtSafty.TabIndex = 34;
            this.txtSafty.Text = "0";
            this.txtSafty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(242, 50);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(48, 23);
            this.textBox6.TabIndex = 34;
            this.textBox6.Text = "%";
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtOverheadValue
            // 
            this.txtOverheadValue.Location = new System.Drawing.Point(296, 79);
            this.txtOverheadValue.Name = "txtOverheadValue";
            this.txtOverheadValue.ReadOnly = true;
            this.txtOverheadValue.Size = new System.Drawing.Size(118, 23);
            this.txtOverheadValue.TabIndex = 34;
            this.txtOverheadValue.Text = "0";
            this.txtOverheadValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtOperationValue
            // 
            this.txtOperationValue.Location = new System.Drawing.Point(296, 50);
            this.txtOperationValue.Name = "txtOperationValue";
            this.txtOperationValue.ReadOnly = true;
            this.txtOperationValue.Size = new System.Drawing.Size(118, 23);
            this.txtOperationValue.TabIndex = 34;
            this.txtOperationValue.Text = "0";
            this.txtOperationValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtOverhead
            // 
            this.txtOverhead.Location = new System.Drawing.Point(125, 79);
            this.txtOverhead.Name = "txtOverhead";
            this.txtOverhead.Size = new System.Drawing.Size(111, 23);
            this.txtOverhead.TabIndex = 34;
            this.txtOverhead.Text = "0";
            this.txtOverhead.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtOperation
            // 
            this.txtOperation.Location = new System.Drawing.Point(125, 50);
            this.txtOperation.Name = "txtOperation";
            this.txtOperation.Size = new System.Drawing.Size(111, 23);
            this.txtOperation.TabIndex = 34;
            this.txtOperation.Text = "0";
            this.txtOperation.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // BOQLINEFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 445);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblBoqID);
            this.Controls.Add(this.lblBoqItemID);
            this.Controls.Add(this.mbtNext);
            this.Controls.Add(this.mbtCancel);
            this.Name = "BOQLINEFrm";
            this.Text = "BOQLINE DETAILS";
            this.Load += new System.EventHandler(this.BOQLINEFrm_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBoqItemLine)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private FontAwesome.Sharp.Material.MaterialButton mbtNext;
        private FontAwesome.Sharp.Material.MaterialButton mbtCancel;
        private System.Windows.Forms.Label lblBoqID;
        private System.Windows.Forms.Label lblBoqItemID;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dgvBoqItemLine;
        private System.Windows.Forms.TextBox txtSubtotalBoqItem;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox txtsalePrice;
        private System.Windows.Forms.TextBox txtBoqCOST;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtMarginValue;
        private System.Windows.Forms.TextBox txtMargin;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSubtotalMagrinAndInflation;
        private System.Windows.Forms.TextBox txtInflationValue;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtInflation;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox txtLoseEfficencyValue;
        private System.Windows.Forms.TextBox txtLoseEffecency;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox txtAdditionalSubTotal;
        private System.Windows.Forms.TextBox txtTransportationValue;
        private System.Windows.Forms.TextBox txtTransportation;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox txtSaftyValue;
        private System.Windows.Forms.TextBox txtSafty;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox txtOverheadValue;
        private System.Windows.Forms.TextBox txtOperationValue;
        private System.Windows.Forms.TextBox txtOverhead;
        private System.Windows.Forms.TextBox txtOperation;
        private System.Windows.Forms.DataGridViewTextBoxColumn laborBOQItemLineRefID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewComboBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn laborBOQItemLineQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn ButtonColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn labourSubtotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn laborUomRefID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}