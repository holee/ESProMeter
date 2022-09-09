﻿
using System;
using System.Windows.Forms;

namespace ESProMeter.Views.Boq
{
	partial class BoqDetailsFrm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.mbtCancel = new FontAwesome.Sharp.Material.MaterialButton();
            this.lblID = new System.Windows.Forms.Label();
            this.lblEDSEQ = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBoqList)).BeginInit();
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
            // 
            // cboSite
            // 
            this.cboSite.Enabled = false;
            this.cboSite.FormattingEnabled = true;
            this.cboSite.Location = new System.Drawing.Point(589, 8);
            this.cboSite.Name = "cboSite";
            this.cboSite.Size = new System.Drawing.Size(285, 23);
            this.cboSite.TabIndex = 2;
            // 
            // cboCustomerName
            // 
            this.cboCustomerName.Enabled = false;
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
            this.txtBOQDesc.ReadOnly = true;
            this.txtBOQDesc.Size = new System.Drawing.Size(918, 73);
            this.txtBOQDesc.TabIndex = 7;
            // 
            // txtBOQTitle
            // 
            this.txtBOQTitle.Location = new System.Drawing.Point(125, 44);
            this.txtBOQTitle.Name = "txtBOQTitle";
            this.txtBOQTitle.ReadOnly = true;
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
            this.COMPLETED});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBoqList.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvBoqList.EnableHeadersVisualStyles = false;
            this.dgvBoqList.Location = new System.Drawing.Point(12, 163);
            this.dgvBoqList.MultiSelect = false;
            this.dgvBoqList.Name = "dgvBoqList";
            this.dgvBoqList.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBoqList.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvBoqList.RowHeadersVisible = false;
            this.dgvBoqList.RowTemplate.Height = 32;
            this.dgvBoqList.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBoqList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBoqList.Size = new System.Drawing.Size(1051, 257);
            this.dgvBoqList.TabIndex = 37;
            // 
            // NO
            // 
            this.NO.DataPropertyName = "NO";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.NO.DefaultCellStyle = dataGridViewCellStyle2;
            this.NO.FillWeight = 5F;
            this.NO.HeaderText = "NO";
            this.NO.Name = "NO";
            this.NO.ReadOnly = true;
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
            this.BOQITEMDESC.ReadOnly = true;
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
            this.BOQITEMQTY.ReadOnly = true;
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
            this.BOQITEMUOMID.ReadOnly = true;
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
            this.REMARKS.ReadOnly = true;
            this.REMARKS.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.REMARKS.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // BOQCOST
            // 
            this.BOQCOST.DataPropertyName = "BOQCOST";
            this.BOQCOST.HeaderText = "BOQCOST";
            this.BOQCOST.Name = "BOQCOST";
            this.BOQCOST.ReadOnly = true;
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
            this.COMPLETED.ReadOnly = true;
            this.COMPLETED.Visible = false;
            this.COMPLETED.Width = 40;
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
            this.mbtCancel.Location = new System.Drawing.Point(967, 426);
            this.mbtCancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.mbtCancel.Name = "mbtCancel";
            this.mbtCancel.Size = new System.Drawing.Size(96, 30);
            this.mbtCancel.TabIndex = 39;
            this.mbtCancel.Text = "Close";
            this.mbtCancel.UseVisualStyleBackColor = false;
            this.mbtCancel.Click += new System.EventHandler(this.mbtCancel_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(600, 78);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(13, 15);
            this.lblID.TabIndex = 40;
            this.lblID.Text = "0";
            // 
            // lblEDSEQ
            // 
            this.lblEDSEQ.AutoSize = true;
            this.lblEDSEQ.Location = new System.Drawing.Point(686, 81);
            this.lblEDSEQ.Name = "lblEDSEQ";
            this.lblEDSEQ.Size = new System.Drawing.Size(13, 15);
            this.lblEDSEQ.TabIndex = 43;
            this.lblEDSEQ.Text = "0";
            // 
            // BoqDetailsFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 464);
            this.Controls.Add(this.dgvBoqList);
            this.Controls.Add(this.lblEDSEQ);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.mbtCancel);
            this.Controls.Add(this.dtpValidDate);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.txtBOQDesc);
            this.Controls.Add(this.txtBOQTitle);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Name = "BoqDetailsFrm";
            this.Text = "Create New Bill of Quantity";
            this.Load += new System.EventHandler(this.BoqDetailsFrm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBoqList)).EndInit();
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
		private System.Windows.Forms.DataGridView dgvBoqList;
		private FontAwesome.Sharp.Material.MaterialButton mbtCancel;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblEDSEQ;
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
    }
}