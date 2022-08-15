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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtOperation = new System.Windows.Forms.TextBox();
            this.txtLoseEffecency = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvLabor = new System.Windows.Forms.DataGridView();
            this.laborBOQItemLineRefID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewComboBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.laborUomRefID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.laborBOQItemLineQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ButtonColumn1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvMachinary = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewComboBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn28 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ButtonColumn2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dgvMaterial = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn29 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewComboBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn31 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn34 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn30 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ButtonColumn3 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.txtInflation = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMargin = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.txtTransportation = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.txtSafty = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.txtOverhead = new System.Windows.Forms.TextBox();
            this.mbtNext = new FontAwesome.Sharp.Material.MaterialButton();
            this.mbtCancel = new FontAwesome.Sharp.Material.MaterialButton();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLabor)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMachinary)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterial)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtOperation
            // 
            this.txtOperation.Location = new System.Drawing.Point(158, 75);
            this.txtOperation.Name = "txtOperation";
            this.txtOperation.Size = new System.Drawing.Size(109, 23);
            this.txtOperation.TabIndex = 34;
            // 
            // txtLoseEffecency
            // 
            this.txtLoseEffecency.Location = new System.Drawing.Point(158, 46);
            this.txtLoseEffecency.Name = "txtLoseEffecency";
            this.txtLoseEffecency.Size = new System.Drawing.Size(109, 23);
            this.txtLoseEffecency.TabIndex = 31;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tabControl1);
            this.groupBox2.Location = new System.Drawing.Point(374, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(646, 430);
            this.groupBox2.TabIndex = 41;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "BOQ ITEM LINE";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(18, 22);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(621, 390);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 33;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvLabor);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage1.Size = new System.Drawing.Size(613, 362);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Labor";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvLabor
            // 
            this.dgvLabor.AllowUserToAddRows = false;
            this.dgvLabor.AllowUserToDeleteRows = false;
            this.dgvLabor.AllowUserToResizeColumns = false;
            this.dgvLabor.AllowUserToResizeRows = false;
            this.dgvLabor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvLabor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.laborBOQItemLineRefID,
            this.dataGridViewComboBoxColumn1,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.laborUomRefID,
            this.laborBOQItemLineQty,
            this.dataGridViewTextBoxColumn3,
            this.ButtonColumn1});
            this.dgvLabor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLabor.Location = new System.Drawing.Point(4, 3);
            this.dgvLabor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvLabor.MultiSelect = false;
            this.dgvLabor.Name = "dgvLabor";
            this.dgvLabor.RowHeadersVisible = false;
            this.dgvLabor.RowTemplate.Height = 25;
            this.dgvLabor.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLabor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLabor.Size = new System.Drawing.Size(605, 356);
            this.dgvLabor.TabIndex = 0;
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
            this.dataGridViewComboBoxColumn1.DataPropertyName = "BOQITEMITEMLINENAME";
            this.dataGridViewComboBoxColumn1.HeaderText = "Item Name";
            this.dataGridViewComboBoxColumn1.Name = "dataGridViewComboBoxColumn1";
            this.dataGridViewComboBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewComboBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewComboBoxColumn1.Width = 200;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "BOQITEMITEMLINETYPE";
            this.dataGridViewTextBoxColumn1.HeaderText = "ItemType";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "UOM";
            this.dataGridViewTextBoxColumn2.HeaderText = "UOM";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
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
            // laborBOQItemLineQty
            // 
            this.laborBOQItemLineQty.DataPropertyName = "BOQITEMLINEQTY";
            this.laborBOQItemLineQty.HeaderText = "Quantity";
            this.laborBOQItemLineQty.Name = "laborBOQItemLineQty";
            this.laborBOQItemLineQty.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.laborBOQItemLineQty.Width = 80;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "BOQITEMLINESEQ";
            this.dataGridViewTextBoxColumn3.HeaderText = "Order";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 60;
            // 
            // ButtonColumn1
            // 
            this.ButtonColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.IndianRed;
            this.ButtonColumn1.DefaultCellStyle = dataGridViewCellStyle1;
            this.ButtonColumn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonColumn1.HeaderText = "Delete";
            this.ButtonColumn1.Name = "ButtonColumn1";
            this.ButtonColumn1.ReadOnly = true;
            this.ButtonColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ButtonColumn1.Text = "X";
            this.ButtonColumn1.UseColumnTextForButtonValue = true;
            this.ButtonColumn1.Width = 50;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvMachinary);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage2.Size = new System.Drawing.Size(613, 362);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Machinary";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvMachinary
            // 
            this.dgvMachinary.AllowUserToAddRows = false;
            this.dgvMachinary.AllowUserToDeleteRows = false;
            this.dgvMachinary.AllowUserToResizeColumns = false;
            this.dgvMachinary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMachinary.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn23,
            this.dataGridViewComboBoxColumn2,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn25,
            this.dataGridViewTextBoxColumn28,
            this.dataGridViewTextBoxColumn24,
            this.Column10,
            this.ButtonColumn2});
            this.dgvMachinary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMachinary.Location = new System.Drawing.Point(4, 3);
            this.dgvMachinary.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvMachinary.MultiSelect = false;
            this.dgvMachinary.Name = "dgvMachinary";
            this.dgvMachinary.RowHeadersVisible = false;
            this.dgvMachinary.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMachinary.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMachinary.Size = new System.Drawing.Size(605, 356);
            this.dgvMachinary.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn23
            // 
            this.dataGridViewTextBoxColumn23.DataPropertyName = "BOQITEMLINEID";
            this.dataGridViewTextBoxColumn23.HeaderText = "ID";
            this.dataGridViewTextBoxColumn23.MinimumWidth = 2;
            this.dataGridViewTextBoxColumn23.Name = "dataGridViewTextBoxColumn23";
            this.dataGridViewTextBoxColumn23.Width = 2;
            // 
            // dataGridViewComboBoxColumn2
            // 
            this.dataGridViewComboBoxColumn2.DataPropertyName = "BOQITEMITEMLINENAME";
            this.dataGridViewComboBoxColumn2.HeaderText = "Item Name";
            this.dataGridViewComboBoxColumn2.MinimumWidth = 2;
            this.dataGridViewComboBoxColumn2.Name = "dataGridViewComboBoxColumn2";
            this.dataGridViewComboBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewComboBoxColumn2.Width = 200;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "BOQITEMITEMLINETYPE";
            this.dataGridViewTextBoxColumn4.HeaderText = "ItemType";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn25
            // 
            this.dataGridViewTextBoxColumn25.DataPropertyName = "UOM";
            this.dataGridViewTextBoxColumn25.HeaderText = "UOM";
            this.dataGridViewTextBoxColumn25.Name = "dataGridViewTextBoxColumn25";
            this.dataGridViewTextBoxColumn25.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn28
            // 
            this.dataGridViewTextBoxColumn28.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn28.DataPropertyName = "BOQITEMLINEUOMID";
            this.dataGridViewTextBoxColumn28.HeaderText = "mnrUomID";
            this.dataGridViewTextBoxColumn28.MinimumWidth = 2;
            this.dataGridViewTextBoxColumn28.Name = "dataGridViewTextBoxColumn28";
            this.dataGridViewTextBoxColumn28.ReadOnly = true;
            this.dataGridViewTextBoxColumn28.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn28.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn28.Width = 2;
            // 
            // dataGridViewTextBoxColumn24
            // 
            this.dataGridViewTextBoxColumn24.DataPropertyName = "BOQITEMLINEQTY";
            this.dataGridViewTextBoxColumn24.HeaderText = "Quantity";
            this.dataGridViewTextBoxColumn24.Name = "dataGridViewTextBoxColumn24";
            this.dataGridViewTextBoxColumn24.Width = 80;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "BOQITEMLINESEQ";
            this.Column10.HeaderText = "Order";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Width = 50;
            // 
            // ButtonColumn2
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.IndianRed;
            this.ButtonColumn2.DefaultCellStyle = dataGridViewCellStyle2;
            this.ButtonColumn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonColumn2.HeaderText = "Delete";
            this.ButtonColumn2.Name = "ButtonColumn2";
            this.ButtonColumn2.ReadOnly = true;
            this.ButtonColumn2.Text = "X";
            this.ButtonColumn2.UseColumnTextForButtonValue = true;
            this.ButtonColumn2.Width = 60;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dgvMaterial);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage3.Size = new System.Drawing.Size(613, 362);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Material";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dgvMaterial
            // 
            this.dgvMaterial.AllowUserToAddRows = false;
            this.dgvMaterial.AllowUserToDeleteRows = false;
            this.dgvMaterial.AllowUserToResizeColumns = false;
            this.dgvMaterial.AllowUserToResizeRows = false;
            this.dgvMaterial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaterial.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn29,
            this.dataGridViewComboBoxColumn3,
            this.Column11,
            this.dataGridViewTextBoxColumn31,
            this.dataGridViewTextBoxColumn34,
            this.dataGridViewTextBoxColumn30,
            this.Column9,
            this.ButtonColumn3});
            this.dgvMaterial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMaterial.Location = new System.Drawing.Point(4, 3);
            this.dgvMaterial.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvMaterial.Name = "dgvMaterial";
            this.dgvMaterial.RowHeadersVisible = false;
            this.dgvMaterial.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMaterial.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMaterial.Size = new System.Drawing.Size(605, 356);
            this.dgvMaterial.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn29
            // 
            this.dataGridViewTextBoxColumn29.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn29.DataPropertyName = "BOQITEMLINEID";
            this.dataGridViewTextBoxColumn29.HeaderText = "Item ID";
            this.dataGridViewTextBoxColumn29.MinimumWidth = 2;
            this.dataGridViewTextBoxColumn29.Name = "dataGridViewTextBoxColumn29";
            this.dataGridViewTextBoxColumn29.Width = 2;
            // 
            // dataGridViewComboBoxColumn3
            // 
            this.dataGridViewComboBoxColumn3.DataPropertyName = "BOQITEMITEMLINENAME";
            this.dataGridViewComboBoxColumn3.HeaderText = "Item Name";
            this.dataGridViewComboBoxColumn3.MinimumWidth = 2;
            this.dataGridViewComboBoxColumn3.Name = "dataGridViewComboBoxColumn3";
            this.dataGridViewComboBoxColumn3.ReadOnly = true;
            this.dataGridViewComboBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewComboBoxColumn3.Width = 200;
            // 
            // Column11
            // 
            this.Column11.DataPropertyName = "BOQITEMITEMLINETYPE";
            this.Column11.HeaderText = "ItemType";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            this.Column11.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column11.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn31
            // 
            this.dataGridViewTextBoxColumn31.DataPropertyName = "UOM";
            this.dataGridViewTextBoxColumn31.HeaderText = "UOM";
            this.dataGridViewTextBoxColumn31.Name = "dataGridViewTextBoxColumn31";
            this.dataGridViewTextBoxColumn31.ReadOnly = true;
            this.dataGridViewTextBoxColumn31.Width = 80;
            // 
            // dataGridViewTextBoxColumn34
            // 
            this.dataGridViewTextBoxColumn34.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn34.DataPropertyName = "BOQITEMLINEUOMID";
            this.dataGridViewTextBoxColumn34.HeaderText = "mtrUomID";
            this.dataGridViewTextBoxColumn34.MinimumWidth = 2;
            this.dataGridViewTextBoxColumn34.Name = "dataGridViewTextBoxColumn34";
            this.dataGridViewTextBoxColumn34.ReadOnly = true;
            this.dataGridViewTextBoxColumn34.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn34.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn34.Width = 2;
            // 
            // dataGridViewTextBoxColumn30
            // 
            this.dataGridViewTextBoxColumn30.DataPropertyName = "BOQITEMLINEQTY";
            this.dataGridViewTextBoxColumn30.HeaderText = "Quantity";
            this.dataGridViewTextBoxColumn30.Name = "dataGridViewTextBoxColumn30";
            this.dataGridViewTextBoxColumn30.Width = 90;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "BOQITEMLINESEQ";
            this.Column9.HeaderText = "Order";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column9.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column9.Width = 50;
            // 
            // ButtonColumn3
            // 
            this.ButtonColumn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonColumn3.HeaderText = "Delete";
            this.ButtonColumn3.Name = "ButtonColumn3";
            this.ButtonColumn3.ReadOnly = true;
            this.ButtonColumn3.Text = "X";
            this.ButtonColumn3.UseColumnTextForButtonValue = true;
            this.ButtonColumn3.Width = 60;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox12);
            this.groupBox1.Controls.Add(this.textBox11);
            this.groupBox1.Controls.Add(this.txtLoseEffecency);
            this.groupBox1.Controls.Add(this.txtInflation);
            this.groupBox1.Controls.Add(this.textBox10);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtMargin);
            this.groupBox1.Controls.Add(this.textBox9);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox8);
            this.groupBox1.Controls.Add(this.txtTransportation);
            this.groupBox1.Controls.Add(this.textBox7);
            this.groupBox1.Controls.Add(this.txtSafty);
            this.groupBox1.Controls.Add(this.textBox6);
            this.groupBox1.Controls.Add(this.txtOverhead);
            this.groupBox1.Controls.Add(this.txtOperation);
            this.groupBox1.Location = new System.Drawing.Point(32, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(327, 284);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "BOQ ADDITIONAL COST DEFAULT SETTINGS";
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(273, 46);
            this.textBox12.Name = "textBox12";
            this.textBox12.ReadOnly = true;
            this.textBox12.Size = new System.Drawing.Size(48, 23);
            this.textBox12.TabIndex = 31;
            this.textBox12.Text = "%";
            this.textBox12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(273, 220);
            this.textBox11.Name = "textBox11";
            this.textBox11.ReadOnly = true;
            this.textBox11.Size = new System.Drawing.Size(48, 23);
            this.textBox11.TabIndex = 34;
            this.textBox11.Text = "%";
            this.textBox11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtInflation
            // 
            this.txtInflation.Location = new System.Drawing.Point(158, 220);
            this.txtInflation.Name = "txtInflation";
            this.txtInflation.Size = new System.Drawing.Size(109, 23);
            this.txtInflation.TabIndex = 34;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(273, 191);
            this.textBox10.Name = "textBox10";
            this.textBox10.ReadOnly = true;
            this.textBox10.Size = new System.Drawing.Size(48, 23);
            this.textBox10.TabIndex = 34;
            this.textBox10.Text = "%";
            this.textBox10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 223);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 15);
            this.label7.TabIndex = 38;
            this.label7.Text = "INFLATION";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 15);
            this.label6.TabIndex = 38;
            this.label6.Text = "MARGIN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 15);
            this.label4.TabIndex = 38;
            this.label4.Text = "TRANSPORTATION";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 15);
            this.label2.TabIndex = 38;
            this.label2.Text = "SAFTY";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 38;
            this.label1.Text = "OVERHEAD";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 15);
            this.label5.TabIndex = 38;
            this.label5.Text = "OPERATION";
            // 
            // txtMargin
            // 
            this.txtMargin.Location = new System.Drawing.Point(158, 191);
            this.txtMargin.Name = "txtMargin";
            this.txtMargin.Size = new System.Drawing.Size(109, 23);
            this.txtMargin.TabIndex = 34;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(273, 162);
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
            this.label3.Location = new System.Drawing.Point(6, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 15);
            this.label3.TabIndex = 39;
            this.label3.Text = "LOSEEFFICENCY";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(273, 133);
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(48, 23);
            this.textBox8.TabIndex = 34;
            this.textBox8.Text = "%";
            this.textBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTransportation
            // 
            this.txtTransportation.Location = new System.Drawing.Point(158, 162);
            this.txtTransportation.Name = "txtTransportation";
            this.txtTransportation.Size = new System.Drawing.Size(109, 23);
            this.txtTransportation.TabIndex = 34;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(273, 104);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(48, 23);
            this.textBox7.TabIndex = 34;
            this.textBox7.Text = "%";
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSafty
            // 
            this.txtSafty.Location = new System.Drawing.Point(158, 133);
            this.txtSafty.Name = "txtSafty";
            this.txtSafty.Size = new System.Drawing.Size(109, 23);
            this.txtSafty.TabIndex = 34;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(273, 75);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(48, 23);
            this.textBox6.TabIndex = 34;
            this.textBox6.Text = "%";
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtOverhead
            // 
            this.txtOverhead.Location = new System.Drawing.Point(158, 104);
            this.txtOverhead.Name = "txtOverhead";
            this.txtOverhead.Size = new System.Drawing.Size(109, 23);
            this.txtOverhead.TabIndex = 34;
            // 
            // mbtNext
            // 
            this.mbtNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(130)))), ((int)(((byte)(200)))));
            this.mbtNext.FlatAppearance.BorderColor = System.Drawing.Color.MediumOrchid;
            this.mbtNext.FlatAppearance.BorderSize = 2;
            this.mbtNext.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.mbtNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mbtNext.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.mbtNext.IconChar = FontAwesome.Sharp.MaterialIcons.None;
            this.mbtNext.IconColor = System.Drawing.Color.White;
            this.mbtNext.IconSize = 1;
            this.mbtNext.Location = new System.Drawing.Point(759, 448);
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
            this.mbtCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mbtCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mbtCancel.ForeColor = System.Drawing.Color.White;
            this.mbtCancel.IconChar = FontAwesome.Sharp.MaterialIcons.None;
            this.mbtCancel.IconColor = System.Drawing.Color.White;
            this.mbtCancel.IconSize = 1;
            this.mbtCancel.Location = new System.Drawing.Point(893, 448);
            this.mbtCancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.mbtCancel.Name = "mbtCancel";
            this.mbtCancel.Size = new System.Drawing.Size(126, 30);
            this.mbtCancel.TabIndex = 36;
            this.mbtCancel.Text = "Cancel";
            this.mbtCancel.UseVisualStyleBackColor = false;
            this.mbtCancel.Click += new System.EventHandler(this.mbtCancel_Click);
            // 
            // BOQLINEFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 490);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.mbtNext);
            this.Controls.Add(this.mbtCancel);
            this.Name = "BOQLINEFrm";
            this.Text = "BOQLINE DETAILS";
            this.groupBox2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLabor)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMachinary)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterial)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtOperation;
        private System.Windows.Forms.TextBox txtLoseEffecency;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.Material.MaterialButton mbtNext;
        private FontAwesome.Sharp.Material.MaterialButton mbtCancel;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgvLabor;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvMachinary;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dgvMaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn laborBOQItemLineRefID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewComboBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn laborUomRefID;
        private System.Windows.Forms.DataGridViewTextBoxColumn laborBOQItemLineQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewButtonColumn ButtonColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewComboBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn25;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn28;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewButtonColumn ButtonColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn29;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewComboBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn31;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn34;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn30;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewButtonColumn ButtonColumn3;
        private System.Windows.Forms.TextBox txtInflation;
        private System.Windows.Forms.TextBox txtMargin;
        private System.Windows.Forms.TextBox txtTransportation;
        private System.Windows.Forms.TextBox txtSafty;
        private System.Windows.Forms.TextBox txtOverhead;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}