
using System;
using System.Windows.Forms;

namespace ESProMeter.Views.Boq
{
	partial class CreateBoQ_Step2_Frm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateBoQ_Step2_Frm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.mbtAddSite = new FontAwesome.Sharp.Material.MaterialButton();
            this.mbtAddCustomer = new FontAwesome.Sharp.Material.MaterialButton();
            this.cboSite = new System.Windows.Forms.ComboBox();
            this.cboCustomerName = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpValidDate = new System.Windows.Forms.DateTimePicker();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.txtBOQDesc = new System.Windows.Forms.TextBox();
            this.txtBOQTitle = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvBoqList = new System.Windows.Forms.DataGridView();
            this.NO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BOQID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BOQITEMID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BOQITEMDESC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BOQITEMQTY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BOQITEMUOMID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.REMARKS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BOQCOST = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LineSeq = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LOSSEFFECENCYRATE1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OPERATIONRATE1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OVERHEADRATE1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SAFETYRATE1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TRANSPORTATIONRATE1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MARGINRATE1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.INFlATIONRATE1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COMPLETED = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ACTION = new System.Windows.Forms.DataGridViewImageColumn();
            this.REMOVE = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnSaveAndNew = new FontAwesome.Sharp.Material.MaterialButton();
            this.mbtCancel = new FontAwesome.Sharp.Material.MaterialButton();
            this.btnSaveAndClose = new FontAwesome.Sharp.Material.MaterialButton();
            this.lblID = new System.Windows.Forms.Label();
            this.btnAddSection = new FontAwesome.Sharp.Material.MaterialButton();
            this.materialButton3 = new FontAwesome.Sharp.Material.MaterialButton();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtItemBoqSearch = new System.Windows.Forms.TextBox();
            this.dgvItem = new System.Windows.Forms.DataGridView();
            this.ItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemNameColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescriptionColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UomColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UomIDColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lblEDSEQ = new System.Windows.Forms.Label();
            this.txtTermsCondition = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBoqList)).BeginInit();
            this.pnlSearch.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItem)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.mbtAddSite);
            this.panel1.Controls.Add(this.mbtAddCustomer);
            this.panel1.Controls.Add(this.cboSite);
            this.panel1.Controls.Add(this.cboCustomerName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1068, 37);
            this.panel1.TabIndex = 1;
            // 
            // mbtAddSite
            // 
            this.mbtAddSite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(130)))), ((int)(((byte)(200)))));
            this.mbtAddSite.FlatAppearance.BorderColor = System.Drawing.Color.MediumOrchid;
            this.mbtAddSite.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.mbtAddSite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mbtAddSite.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mbtAddSite.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.mbtAddSite.IconChar = FontAwesome.Sharp.MaterialIcons.None;
            this.mbtAddSite.IconColor = System.Drawing.Color.White;
            this.mbtAddSite.IconSize = 1;
            this.mbtAddSite.Location = new System.Drawing.Point(873, 6);
            this.mbtAddSite.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.mbtAddSite.Name = "mbtAddSite";
            this.mbtAddSite.Size = new System.Drawing.Size(26, 27);
            this.mbtAddSite.TabIndex = 3;
            this.mbtAddSite.Text = "+";
            this.mbtAddSite.UseVisualStyleBackColor = false;
            this.mbtAddSite.Click += new System.EventHandler(this.mbtAddSite_Click);
            // 
            // mbtAddCustomer
            // 
            this.mbtAddCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(130)))), ((int)(((byte)(200)))));
            this.mbtAddCustomer.FlatAppearance.BorderColor = System.Drawing.Color.MediumOrchid;
            this.mbtAddCustomer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.mbtAddCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mbtAddCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mbtAddCustomer.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.mbtAddCustomer.IconChar = FontAwesome.Sharp.MaterialIcons.None;
            this.mbtAddCustomer.IconColor = System.Drawing.Color.White;
            this.mbtAddCustomer.IconSize = 1;
            this.mbtAddCustomer.Location = new System.Drawing.Point(486, 5);
            this.mbtAddCustomer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.mbtAddCustomer.Name = "mbtAddCustomer";
            this.mbtAddCustomer.Size = new System.Drawing.Size(26, 27);
            this.mbtAddCustomer.TabIndex = 1;
            this.mbtAddCustomer.Text = "+";
            this.mbtAddCustomer.UseVisualStyleBackColor = false;
            this.mbtAddCustomer.Click += new System.EventHandler(this.mbtAddCustomer_Click);
            // 
            // cboSite
            // 
            this.cboSite.FormattingEnabled = true;
            this.cboSite.Location = new System.Drawing.Point(589, 8);
            this.cboSite.Name = "cboSite";
            this.cboSite.Size = new System.Drawing.Size(285, 23);
            this.cboSite.TabIndex = 2;
            // 
            // cboCustomerName
            // 
            this.cboCustomerName.FormattingEnabled = true;
            this.cboCustomerName.Location = new System.Drawing.Point(124, 7);
            this.cboCustomerName.Name = "cboCustomerName";
            this.cboCustomerName.Size = new System.Drawing.Size(363, 23);
            this.cboCustomerName.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(552, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "SITE:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "CUSTOMER NAME:";
            // 
            // dtpValidDate
            // 
            this.dtpValidDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpValidDate.Location = new System.Drawing.Point(791, 44);
            this.dtpValidDate.Name = "dtpValidDate";
            this.dtpValidDate.Size = new System.Drawing.Size(109, 23);
            this.dtpValidDate.TabIndex = 6;
            // 
            // dtpDate
            // 
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(590, 44);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(109, 23);
            this.dtpDate.TabIndex = 5;
            // 
            // txtBOQDesc
            // 
            this.txtBOQDesc.Location = new System.Drawing.Point(125, 73);
            this.txtBOQDesc.Multiline = true;
            this.txtBOQDesc.Name = "txtBOQDesc";
            this.txtBOQDesc.Size = new System.Drawing.Size(469, 23);
            this.txtBOQDesc.TabIndex = 7;
            this.txtBOQDesc.Enter += new System.EventHandler(this.txtBOQDesc_Enter);
            this.txtBOQDesc.Leave += new System.EventHandler(this.txtBOQDesc_Leave);
            // 
            // txtBOQTitle
            // 
            this.txtBOQTitle.Location = new System.Drawing.Point(125, 44);
            this.txtBOQTitle.Name = "txtBOQTitle";
            this.txtBOQTitle.Size = new System.Drawing.Size(363, 23);
            this.txtBOQTitle.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(714, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 15);
            this.label7.TabIndex = 33;
            this.label7.Text = "VALID DATE:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(547, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 15);
            this.label6.TabIndex = 34;
            this.label6.Text = "DATE:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 15);
            this.label5.TabIndex = 35;
            this.label5.Text = "BOQ DESCRIPTION:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 15);
            this.label3.TabIndex = 36;
            this.label3.Text = "BOQ TITLE:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 418);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 15);
            this.label4.TabIndex = 35;
            this.label4.Text = "TERMS && CONDITION";
            // 
            // dgvBoqList
            // 
            this.dgvBoqList.AllowDrop = true;
            this.dgvBoqList.AllowUserToAddRows = false;
            this.dgvBoqList.AllowUserToDeleteRows = false;
            this.dgvBoqList.AllowUserToResizeColumns = false;
            this.dgvBoqList.AllowUserToResizeRows = false;
            this.dgvBoqList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBoqList.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBoqList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBoqList.ColumnHeadersHeight = 30;
            this.dgvBoqList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvBoqList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NO,
            this.BOQID,
            this.BOQITEMID,
            this.itemname,
            this.BOQITEMDESC,
            this.BOQITEMQTY,
            this.uom,
            this.BOQITEMUOMID,
            this.REMARKS,
            this.BOQCOST,
            this.LineSeq,
            this.LOSSEFFECENCYRATE1,
            this.OPERATIONRATE1,
            this.OVERHEADRATE1,
            this.SAFETYRATE1,
            this.TRANSPORTATIONRATE1,
            this.MARGINRATE1,
            this.INFlATIONRATE1,
            this.COMPLETED,
            this.ACTION,
            this.REMOVE});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBoqList.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvBoqList.EnableHeadersVisualStyles = false;
            this.dgvBoqList.Location = new System.Drawing.Point(12, 112);
            this.dgvBoqList.MultiSelect = false;
            this.dgvBoqList.Name = "dgvBoqList";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBoqList.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvBoqList.RowHeadersVisible = false;
            this.dgvBoqList.RowTemplate.Height = 32;
            this.dgvBoqList.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBoqList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBoqList.Size = new System.Drawing.Size(1051, 298);
            this.dgvBoqList.TabIndex = 37;
            this.dgvBoqList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBoqListCellContentClick);
            this.dgvBoqList.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBoqList_CellEndEdit);
            this.dgvBoqList.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBoqListCellEnter);
            this.dgvBoqList.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvBoqListCellFormatting);
            this.dgvBoqList.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvBoqListCellMouseDown);
            this.dgvBoqList.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvBoqListEditingControlShowing);
            this.dgvBoqList.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBoqList_RowEnter);
            this.dgvBoqList.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvBoqListRowsAdded);
            this.dgvBoqList.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgvBoqListRowsRemoved);
            this.dgvBoqList.SelectionChanged += new System.EventHandler(this.dgvBoqListSelectionChanged);
            this.dgvBoqList.DragDrop += new System.Windows.Forms.DragEventHandler(this.dataGridViewDragDrop);
            this.dgvBoqList.DragOver += new System.Windows.Forms.DragEventHandler(this.dataGridViewDragOver);
            this.dgvBoqList.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dataGridViewMouseDown);
            this.dgvBoqList.MouseMove += new System.Windows.Forms.MouseEventHandler(this.dataGridViewMouseMove);
            this.dgvBoqList.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dgvBoqListMouseUp);
            // 
            // NO
            // 
            this.NO.DataPropertyName = "NO";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.NO.DefaultCellStyle = dataGridViewCellStyle2;
            this.NO.FillWeight = 5F;
            this.NO.HeaderText = "NO";
            this.NO.Name = "NO";
            this.NO.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.NO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.NO.Width = 70;
            // 
            // BOQID
            // 
            this.BOQID.DataPropertyName = "BOQID";
            this.BOQID.HeaderText = "BOQID";
            this.BOQID.MinimumWidth = 2;
            this.BOQID.Name = "BOQID";
            this.BOQID.ReadOnly = true;
            this.BOQID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.BOQID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.BOQID.Visible = false;
            this.BOQID.Width = 50;
            // 
            // BOQITEMID
            // 
            this.BOQITEMID.DataPropertyName = "BOQITEMID";
            this.BOQITEMID.HeaderText = "BOQITEMID";
            this.BOQITEMID.MinimumWidth = 2;
            this.BOQITEMID.Name = "BOQITEMID";
            this.BOQITEMID.ReadOnly = true;
            this.BOQITEMID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.BOQITEMID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.BOQITEMID.Visible = false;
            this.BOQITEMID.Width = 50;
            // 
            // itemname
            // 
            this.itemname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.itemname.DataPropertyName = "itemname";
            this.itemname.FillWeight = 20F;
            this.itemname.HeaderText = "ITEM NAME";
            this.itemname.Name = "itemname";
            this.itemname.ReadOnly = true;
            this.itemname.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.itemname.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.itemname.Visible = false;
            // 
            // BOQITEMDESC
            // 
            this.BOQITEMDESC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BOQITEMDESC.DataPropertyName = "BOQITEMDESC";
            this.BOQITEMDESC.FillWeight = 25F;
            this.BOQITEMDESC.HeaderText = "DESCRIPTION";
            this.BOQITEMDESC.Name = "BOQITEMDESC";
            this.BOQITEMDESC.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // BOQITEMQTY
            // 
            this.BOQITEMQTY.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.BOQITEMQTY.DataPropertyName = "BOQITEMQTY";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N3";
            this.BOQITEMQTY.DefaultCellStyle = dataGridViewCellStyle3;
            this.BOQITEMQTY.FillWeight = 8F;
            this.BOQITEMQTY.HeaderText = "QUANTITY";
            this.BOQITEMQTY.Name = "BOQITEMQTY";
            this.BOQITEMQTY.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.BOQITEMQTY.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // uom
            // 
            this.uom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.uom.DataPropertyName = "uom";
            this.uom.FillWeight = 7F;
            this.uom.HeaderText = "UOM";
            this.uom.Name = "uom";
            this.uom.ReadOnly = true;
            this.uom.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.uom.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.uom.Width = 60;
            // 
            // BOQITEMUOMID
            // 
            this.BOQITEMUOMID.DataPropertyName = "UOMID";
            this.BOQITEMUOMID.HeaderText = "UOMID";
            this.BOQITEMUOMID.Name = "BOQITEMUOMID";
            this.BOQITEMUOMID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.BOQITEMUOMID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.BOQITEMUOMID.Visible = false;
            // 
            // REMARKS
            // 
            this.REMARKS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.REMARKS.DataPropertyName = "REMARKS";
            this.REMARKS.FillWeight = 27F;
            this.REMARKS.HeaderText = "REMARKS";
            this.REMARKS.Name = "REMARKS";
            this.REMARKS.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.REMARKS.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // BOQCOST
            // 
            this.BOQCOST.DataPropertyName = "BOQCOST";
            this.BOQCOST.HeaderText = "COST";
            this.BOQCOST.Name = "BOQCOST";
            this.BOQCOST.ReadOnly = true;
            this.BOQCOST.Visible = false;
            // 
            // LineSeq
            // 
            this.LineSeq.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.LineSeq.DataPropertyName = "LineSeq";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.LineSeq.DefaultCellStyle = dataGridViewCellStyle4;
            this.LineSeq.HeaderText = "ORDER";
            this.LineSeq.Name = "LineSeq";
            this.LineSeq.ReadOnly = true;
            this.LineSeq.Visible = false;
            this.LineSeq.Width = 50;
            // 
            // LOSSEFFECENCYRATE1
            // 
            this.LOSSEFFECENCYRATE1.DataPropertyName = "LOSSOFEFFECIENCYRATE";
            this.LOSSEFFECENCYRATE1.HeaderText = "LOE";
            this.LOSSEFFECENCYRATE1.Name = "LOSSEFFECENCYRATE1";
            this.LOSSEFFECENCYRATE1.ReadOnly = true;
            this.LOSSEFFECENCYRATE1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.LOSSEFFECENCYRATE1.Visible = false;
            this.LOSSEFFECENCYRATE1.Width = 50;
            // 
            // OPERATIONRATE1
            // 
            this.OPERATIONRATE1.DataPropertyName = "OPERATIONRATE";
            this.OPERATIONRATE1.HeaderText = "OP";
            this.OPERATIONRATE1.Name = "OPERATIONRATE1";
            this.OPERATIONRATE1.ReadOnly = true;
            this.OPERATIONRATE1.Visible = false;
            this.OPERATIONRATE1.Width = 50;
            // 
            // OVERHEADRATE1
            // 
            this.OVERHEADRATE1.DataPropertyName = "OVERHEADRATE";
            this.OVERHEADRATE1.HeaderText = "OVER";
            this.OVERHEADRATE1.Name = "OVERHEADRATE1";
            this.OVERHEADRATE1.ReadOnly = true;
            this.OVERHEADRATE1.Visible = false;
            this.OVERHEADRATE1.Width = 50;
            // 
            // SAFETYRATE1
            // 
            this.SAFETYRATE1.DataPropertyName = "SAFETYRATE";
            this.SAFETYRATE1.HeaderText = "SAFTY";
            this.SAFETYRATE1.Name = "SAFETYRATE1";
            this.SAFETYRATE1.ReadOnly = true;
            this.SAFETYRATE1.Visible = false;
            this.SAFETYRATE1.Width = 50;
            // 
            // TRANSPORTATIONRATE1
            // 
            this.TRANSPORTATIONRATE1.DataPropertyName = "TRANSPORTATIONRATE";
            this.TRANSPORTATIONRATE1.HeaderText = "TRANSPORT";
            this.TRANSPORTATIONRATE1.Name = "TRANSPORTATIONRATE1";
            this.TRANSPORTATIONRATE1.ReadOnly = true;
            this.TRANSPORTATIONRATE1.Visible = false;
            this.TRANSPORTATIONRATE1.Width = 50;
            // 
            // MARGINRATE1
            // 
            this.MARGINRATE1.DataPropertyName = "MARGINRATE";
            this.MARGINRATE1.HeaderText = "MARGIN";
            this.MARGINRATE1.Name = "MARGINRATE1";
            this.MARGINRATE1.ReadOnly = true;
            this.MARGINRATE1.Visible = false;
            this.MARGINRATE1.Width = 50;
            // 
            // INFlATIONRATE1
            // 
            this.INFlATIONRATE1.DataPropertyName = "INFlATIONRATE";
            this.INFlATIONRATE1.HeaderText = "INFLA";
            this.INFlATIONRATE1.Name = "INFlATIONRATE1";
            this.INFlATIONRATE1.ReadOnly = true;
            this.INFlATIONRATE1.Visible = false;
            this.INFlATIONRATE1.Width = 50;
            // 
            // COMPLETED
            // 
            this.COMPLETED.HeaderText = "COMPLETED";
            this.COMPLETED.Name = "COMPLETED";
            this.COMPLETED.Visible = false;
            this.COMPLETED.Width = 40;
            // 
            // ACTION
            // 
            this.ACTION.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle5.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle5.NullValue")));
            this.ACTION.DefaultCellStyle = dataGridViewCellStyle5;
            this.ACTION.FillWeight = 8F;
            this.ACTION.HeaderText = "ACTION";
            this.ACTION.Image = ((System.Drawing.Image)(resources.GetObject("ACTION.Image")));
            this.ACTION.Name = "ACTION";
            this.ACTION.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ACTION.Width = 80;
            // 
            // REMOVE
            // 
            this.REMOVE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Red;
            this.REMOVE.DefaultCellStyle = dataGridViewCellStyle6;
            this.REMOVE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.REMOVE.HeaderText = "REMOVE";
            this.REMOVE.Name = "REMOVE";
            this.REMOVE.ReadOnly = true;
            this.REMOVE.Text = "X";
            this.REMOVE.UseColumnTextForButtonValue = true;
            this.REMOVE.Width = 80;
            // 
            // btnSaveAndNew
            // 
            this.btnSaveAndNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveAndNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(130)))), ((int)(((byte)(200)))));
            this.btnSaveAndNew.FlatAppearance.BorderColor = System.Drawing.Color.MediumOrchid;
            this.btnSaveAndNew.FlatAppearance.BorderSize = 2;
            this.btnSaveAndNew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.btnSaveAndNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSaveAndNew.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSaveAndNew.IconChar = FontAwesome.Sharp.MaterialIcons.None;
            this.btnSaveAndNew.IconColor = System.Drawing.Color.White;
            this.btnSaveAndNew.IconSize = 1;
            this.btnSaveAndNew.Location = new System.Drawing.Point(669, 415);
            this.btnSaveAndNew.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSaveAndNew.Name = "btnSaveAndNew";
            this.btnSaveAndNew.Size = new System.Drawing.Size(126, 30);
            this.btnSaveAndNew.TabIndex = 38;
            this.btnSaveAndNew.Text = "Save && New";
            this.btnSaveAndNew.UseVisualStyleBackColor = false;
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
            this.mbtCancel.Location = new System.Drawing.Point(937, 415);
            this.mbtCancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.mbtCancel.Name = "mbtCancel";
            this.mbtCancel.Size = new System.Drawing.Size(126, 30);
            this.mbtCancel.TabIndex = 39;
            this.mbtCancel.Text = "Cancel";
            this.mbtCancel.UseVisualStyleBackColor = false;
            this.mbtCancel.Click += new System.EventHandler(this.mbtCancel_Click);
            // 
            // btnSaveAndClose
            // 
            this.btnSaveAndClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveAndClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(130)))), ((int)(((byte)(200)))));
            this.btnSaveAndClose.FlatAppearance.BorderColor = System.Drawing.Color.MediumOrchid;
            this.btnSaveAndClose.FlatAppearance.BorderSize = 2;
            this.btnSaveAndClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.btnSaveAndClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSaveAndClose.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSaveAndClose.IconChar = FontAwesome.Sharp.MaterialIcons.None;
            this.btnSaveAndClose.IconColor = System.Drawing.Color.White;
            this.btnSaveAndClose.IconSize = 1;
            this.btnSaveAndClose.Location = new System.Drawing.Point(803, 415);
            this.btnSaveAndClose.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSaveAndClose.Name = "btnSaveAndClose";
            this.btnSaveAndClose.Size = new System.Drawing.Size(126, 30);
            this.btnSaveAndClose.TabIndex = 38;
            this.btnSaveAndClose.Text = "Save && Close";
            this.btnSaveAndClose.UseVisualStyleBackColor = false;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(211, 240);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(13, 15);
            this.lblID.TabIndex = 40;
            this.lblID.Text = "0";
            // 
            // btnAddSection
            // 
            this.btnAddSection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddSection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(130)))), ((int)(((byte)(200)))));
            this.btnAddSection.FlatAppearance.BorderColor = System.Drawing.Color.MediumOrchid;
            this.btnAddSection.FlatAppearance.BorderSize = 2;
            this.btnAddSection.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.btnAddSection.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddSection.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAddSection.IconChar = FontAwesome.Sharp.MaterialIcons.None;
            this.btnAddSection.IconColor = System.Drawing.Color.White;
            this.btnAddSection.IconSize = 1;
            this.btnAddSection.Location = new System.Drawing.Point(803, 78);
            this.btnAddSection.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAddSection.Name = "btnAddSection";
            this.btnAddSection.Size = new System.Drawing.Size(126, 30);
            this.btnAddSection.TabIndex = 38;
            this.btnAddSection.Text = "Add Section";
            this.btnAddSection.UseVisualStyleBackColor = false;
            this.btnAddSection.Click += new System.EventHandler(this.btnAddSection_Click);
            // 
            // materialButton3
            // 
            this.materialButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(130)))), ((int)(((byte)(200)))));
            this.materialButton3.FlatAppearance.BorderColor = System.Drawing.Color.MediumOrchid;
            this.materialButton3.FlatAppearance.BorderSize = 2;
            this.materialButton3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.materialButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.materialButton3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.materialButton3.IconChar = FontAwesome.Sharp.MaterialIcons.ChevronDownBox;
            this.materialButton3.IconColor = System.Drawing.Color.White;
            this.materialButton3.IconSize = 22;
            this.materialButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.materialButton3.Location = new System.Drawing.Point(937, 79);
            this.materialButton3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.materialButton3.Name = "materialButton3";
            this.materialButton3.Size = new System.Drawing.Size(126, 30);
            this.materialButton3.TabIndex = 38;
            this.materialButton3.Text = "Add Boq Item";
            this.materialButton3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.materialButton3.UseVisualStyleBackColor = false;
            this.materialButton3.Click += new System.EventHandler(this.materialButton3_Click);
            this.materialButton3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.materialButton3_MouseClick);
            // 
            // pnlSearch
            // 
            this.pnlSearch.BackColor = System.Drawing.SystemColors.Control;
            this.pnlSearch.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlSearch.Controls.Add(this.linkLabel1);
            this.pnlSearch.Controls.Add(this.panel2);
            this.pnlSearch.Controls.Add(this.dgvItem);
            this.pnlSearch.Location = new System.Drawing.Point(542, 106);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(587, 253);
            this.pnlSearch.TabIndex = 41;
            this.pnlSearch.Visible = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(4, 29);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(125, 15);
            this.linkLabel1.TabIndex = 33;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Create New BOQ ITEM";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.txtItemBoqSearch);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(583, 25);
            this.panel2.TabIndex = 32;
            // 
            // txtItemBoqSearch
            // 
            this.txtItemBoqSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtItemBoqSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtItemBoqSearch.Location = new System.Drawing.Point(0, 0);
            this.txtItemBoqSearch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtItemBoqSearch.Name = "txtItemBoqSearch";
            this.txtItemBoqSearch.PlaceholderText = "type your item here";
            this.txtItemBoqSearch.Size = new System.Drawing.Size(583, 23);
            this.txtItemBoqSearch.TabIndex = 30;
            this.txtItemBoqSearch.Tag = "Name";
            this.txtItemBoqSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtItemBoqSearch_KeyUp);
            // 
            // dgvItem
            // 
            this.dgvItem.AllowUserToAddRows = false;
            this.dgvItem.AllowUserToDeleteRows = false;
            this.dgvItem.AllowUserToResizeColumns = false;
            this.dgvItem.AllowUserToResizeRows = false;
            this.dgvItem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvItem.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvItem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvItem.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvItem.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvItem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemID,
            this.ItemNameColumn1,
            this.DescriptionColumn1,
            this.ItemType,
            this.UomColumn1,
            this.UomIDColumn1,
            this.Column2,
            this.Column1});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvItem.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvItem.EnableHeadersVisualStyles = false;
            this.dgvItem.Location = new System.Drawing.Point(0, 51);
            this.dgvItem.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvItem.MultiSelect = false;
            this.dgvItem.Name = "dgvItem";
            this.dgvItem.ReadOnly = true;
            this.dgvItem.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvItem.RowHeadersVisible = false;
            this.dgvItem.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvItem.RowTemplate.Height = 25;
            this.dgvItem.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvItem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItem.Size = new System.Drawing.Size(585, 198);
            this.dgvItem.TabIndex = 31;
            this.dgvItem.VirtualMode = true;
            this.dgvItem.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItemCellClick);
            // 
            // ItemID
            // 
            this.ItemID.DataPropertyName = "ID";
            this.ItemID.HeaderText = "ItemID";
            this.ItemID.MinimumWidth = 2;
            this.ItemID.Name = "ItemID";
            this.ItemID.ReadOnly = true;
            this.ItemID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ItemID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ItemID.Width = 2;
            // 
            // ItemNameColumn1
            // 
            this.ItemNameColumn1.DataPropertyName = "ItemName";
            this.ItemNameColumn1.HeaderText = "Item Name";
            this.ItemNameColumn1.Name = "ItemNameColumn1";
            this.ItemNameColumn1.ReadOnly = true;
            this.ItemNameColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ItemNameColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ItemNameColumn1.Width = 150;
            // 
            // DescriptionColumn1
            // 
            this.DescriptionColumn1.DataPropertyName = "Description";
            this.DescriptionColumn1.HeaderText = "Description";
            this.DescriptionColumn1.Name = "DescriptionColumn1";
            this.DescriptionColumn1.ReadOnly = true;
            this.DescriptionColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DescriptionColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.DescriptionColumn1.Width = 150;
            // 
            // ItemType
            // 
            this.ItemType.DataPropertyName = "ItemType";
            this.ItemType.HeaderText = "ItemType";
            this.ItemType.Name = "ItemType";
            this.ItemType.ReadOnly = true;
            this.ItemType.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ItemType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // UomColumn1
            // 
            this.UomColumn1.DataPropertyName = "Uom";
            this.UomColumn1.HeaderText = "Uom";
            this.UomColumn1.Name = "UomColumn1";
            this.UomColumn1.ReadOnly = true;
            this.UomColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.UomColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // UomIDColumn1
            // 
            this.UomIDColumn1.DataPropertyName = "UomID";
            this.UomIDColumn1.HeaderText = "UomID";
            this.UomIDColumn1.Name = "UomIDColumn1";
            this.UomIDColumn1.ReadOnly = true;
            this.UomIDColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.UomIDColumn1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "BOQCOST";
            this.Column2.HeaderText = "COST";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle10;
            this.Column1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Column1.HeaderText = "Action";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column1.Text = "Select";
            this.Column1.UseColumnTextForButtonValue = true;
            this.Column1.Visible = false;
            this.Column1.Width = 80;
            // 
            // lblEDSEQ
            // 
            this.lblEDSEQ.AutoSize = true;
            this.lblEDSEQ.Location = new System.Drawing.Point(297, 243);
            this.lblEDSEQ.Name = "lblEDSEQ";
            this.lblEDSEQ.Size = new System.Drawing.Size(13, 15);
            this.lblEDSEQ.TabIndex = 43;
            this.lblEDSEQ.Text = "0";
            // 
            // txtTermsCondition
            // 
            this.txtTermsCondition.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtTermsCondition.Location = new System.Drawing.Point(140, 415);
            this.txtTermsCondition.Name = "txtTermsCondition";
            this.txtTermsCondition.Size = new System.Drawing.Size(508, 23);
            this.txtTermsCondition.TabIndex = 44;
            this.txtTermsCondition.Enter += new System.EventHandler(this.txtTermsCondition_Enter);
            this.txtTermsCondition.Leave += new System.EventHandler(this.txtTermsCondition_Leave);
            // 
            // CreateBoQ_Step2_Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 464);
            this.Controls.Add(this.dgvBoqList);
            this.Controls.Add(this.txtTermsCondition);
            this.Controls.Add(this.lblEDSEQ);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.materialButton3);
            this.Controls.Add(this.btnAddSection);
            this.Controls.Add(this.btnSaveAndClose);
            this.Controls.Add(this.btnSaveAndNew);
            this.Controls.Add(this.mbtCancel);
            this.Controls.Add(this.dtpValidDate);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.txtBOQDesc);
            this.Controls.Add(this.txtBOQTitle);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlSearch);
            this.Name = "CreateBoQ_Step2_Frm";
            this.Text = "Create New Bill of Quantity";
            this.Load += new System.EventHandler(this.CreateBoQ_Step2_Frm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBoqList)).EndInit();
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

	

		#endregion

		private System.Windows.Forms.Panel panel1;
		private FontAwesome.Sharp.Material.MaterialButton mbtAddSite;
		private FontAwesome.Sharp.Material.MaterialButton mbtAddCustomer;
		private System.Windows.Forms.ComboBox cboSite;
		private System.Windows.Forms.ComboBox cboCustomerName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DateTimePicker dtpValidDate;
		private System.Windows.Forms.DateTimePicker dtpDate;
		private System.Windows.Forms.TextBox txtBOQDesc;
		private System.Windows.Forms.TextBox txtBOQTitle;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.DataGridView dgvBoqList;
		private FontAwesome.Sharp.Material.MaterialButton btnSaveAndNew;
		private FontAwesome.Sharp.Material.MaterialButton mbtCancel;
		private FontAwesome.Sharp.Material.MaterialButton btnSaveAndClose;
        private System.Windows.Forms.Label lblID;
        private FontAwesome.Sharp.Material.MaterialButton btnAddSection;
        private FontAwesome.Sharp.Material.MaterialButton materialButton3;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.TextBox txtItemBoqSearch;
        private System.Windows.Forms.DataGridView dgvItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemNameColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescriptionColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemType;
        private System.Windows.Forms.DataGridViewTextBoxColumn UomColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn UomIDColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblEDSEQ;
        private TextBox txtTermsCondition;
        private LinkLabel linkLabel1;
        private DataGridViewTextBoxColumn NO;
        private DataGridViewTextBoxColumn BOQID;
        private DataGridViewTextBoxColumn BOQITEMID;
        private DataGridViewTextBoxColumn itemname;
        private DataGridViewTextBoxColumn BOQITEMDESC;
        private DataGridViewTextBoxColumn BOQITEMQTY;
        private DataGridViewTextBoxColumn uom;
        private DataGridViewTextBoxColumn BOQITEMUOMID;
        private DataGridViewTextBoxColumn REMARKS;
        private DataGridViewTextBoxColumn BOQCOST;
        private DataGridViewTextBoxColumn LineSeq;
        private DataGridViewTextBoxColumn LOSSEFFECENCYRATE1;
        private DataGridViewTextBoxColumn OPERATIONRATE1;
        private DataGridViewTextBoxColumn OVERHEADRATE1;
        private DataGridViewTextBoxColumn SAFETYRATE1;
        private DataGridViewTextBoxColumn TRANSPORTATIONRATE1;
        private DataGridViewTextBoxColumn MARGINRATE1;
        private DataGridViewTextBoxColumn INFlATIONRATE1;
        private DataGridViewTextBoxColumn COMPLETED;
        private DataGridViewImageColumn ACTION;
        private DataGridViewButtonColumn REMOVE;
    }
}