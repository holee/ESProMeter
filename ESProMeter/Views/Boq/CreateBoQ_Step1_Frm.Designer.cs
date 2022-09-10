
namespace ESProMeter.Views.Boq
{
	partial class CreateBoQ_Step1_Frm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cboSite = new System.Windows.Forms.ComboBox();
            this.cboCustomerName = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtgBOQCostSetting = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtTermsCondition = new System.Windows.Forms.TextBox();
            this.txtBOQTitle = new System.Windows.Forms.TextBox();
            this.txtBOQDesc = new System.Windows.Forms.TextBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.dtpValidDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgBOQCostSetting)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.cboSite);
            this.panel1.Controls.Add(this.cboCustomerName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(910, 37);
            this.panel1.TabIndex = 0;
            // 
            // cboSite
            // 
            this.cboSite.FormattingEnabled = true;
            this.cboSite.Location = new System.Drawing.Point(589, 8);
            this.cboSite.Name = "cboSite";
            this.cboSite.Size = new System.Drawing.Size(234, 23);
            this.cboSite.TabIndex = 2;
            // 
            // cboCustomerName
            // 
            this.cboCustomerName.FormattingEnabled = true;
            this.cboCustomerName.Location = new System.Drawing.Point(114, 8);
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
            this.label1.Location = new System.Drawing.Point(3, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "CUSTOMER NAME:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 15);
            this.label3.TabIndex = 28;
            this.label3.Text = "BOQ TITLE:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 15);
            this.label5.TabIndex = 28;
            this.label5.Text = "BOQ DESCRIPTION:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtgBOQCostSetting);
            this.groupBox1.Location = new System.Drawing.Point(4, 140);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(327, 242);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "BOQ ADDITIONAL COST DEFAULT SETTINGS";
            // 
            // dtgBOQCostSetting
            // 
            this.dtgBOQCostSetting.AllowUserToAddRows = false;
            this.dtgBOQCostSetting.AllowUserToDeleteRows = false;
            this.dtgBOQCostSetting.BackgroundColor = System.Drawing.Color.White;
            this.dtgBOQCostSetting.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgBOQCostSetting.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dtgBOQCostSetting.Location = new System.Drawing.Point(9, 22);
            this.dtgBOQCostSetting.Name = "dtgBOQCostSetting";
            this.dtgBOQCostSetting.RowHeadersVisible = false;
            this.dtgBOQCostSetting.RowTemplate.DividerHeight = 1;
            this.dtgBOQCostSetting.RowTemplate.Height = 25;
            this.dtgBOQCostSetting.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgBOQCostSetting.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dtgBOQCostSetting.Size = new System.Drawing.Size(303, 214);
            this.dtgBOQCostSetting.TabIndex = 8;
            this.dtgBOQCostSetting.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dtgBOQCostSettingEditingControlShowing);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "CODE";
            this.Column1.HeaderText = "CODE";
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "DESCRIPTION";
            this.Column2.HeaderText = "DESCRIPTION";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "TYPE";
            this.Column3.HeaderText = "TYPE";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column3.Visible = false;
            this.Column3.Width = 70;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "VALUE";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Format = "0.00";
            this.Column4.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column4.HeaderText = "VALUE";
            this.Column4.Name = "Column4";
            this.Column4.Width = 60;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "CATEGORY";
            this.Column5.HeaderText = "CATEGORY";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Visible = false;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "VALUEAS";
            this.Column6.HeaderText = "VALUEAS";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 80;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "IsACT";
            this.Column7.HeaderText = "ACTIVE";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtTermsCondition);
            this.groupBox2.Location = new System.Drawing.Point(337, 140);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(518, 242);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "TERMS && CONDITION";
            // 
            // txtTermsCondition
            // 
            this.txtTermsCondition.Location = new System.Drawing.Point(42, 22);
            this.txtTermsCondition.Multiline = true;
            this.txtTermsCondition.Name = "txtTermsCondition";
            this.txtTermsCondition.Size = new System.Drawing.Size(467, 214);
            this.txtTermsCondition.TabIndex = 9;
            this.txtTermsCondition.Text = "Validity of offer: 2 Weeks    \r\nStage Payment:    \r\n  1- Down Payment, signature " +
    "of contract  \r\n  2- 6 months after completion Completion  \r\n  3- Discount  \r\n\r\nP" +
    "harith SAR    \r\nDirector";
            // 
            // txtBOQTitle
            // 
            this.txtBOQTitle.Location = new System.Drawing.Point(115, 53);
            this.txtBOQTitle.Name = "txtBOQTitle";
            this.txtBOQTitle.Size = new System.Drawing.Size(363, 23);
            this.txtBOQTitle.TabIndex = 4;
            // 
            // txtBOQDesc
            // 
            this.txtBOQDesc.Location = new System.Drawing.Point(115, 82);
            this.txtBOQDesc.Multiline = true;
            this.txtBOQDesc.Name = "txtBOQDesc";
            this.txtBOQDesc.Size = new System.Drawing.Size(734, 38);
            this.txtBOQDesc.TabIndex = 7;
            // 
            // dtpDate
            // 
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(539, 53);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(109, 23);
            this.dtpDate.TabIndex = 5;
            // 
            // dtpValidDate
            // 
            this.dtpValidDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpValidDate.Location = new System.Drawing.Point(740, 53);
            this.dtpValidDate.Name = "dtpValidDate";
            this.dtpValidDate.Size = new System.Drawing.Size(109, 23);
            this.dtpValidDate.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(496, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 15);
            this.label6.TabIndex = 28;
            this.label6.Text = "DATE:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(663, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 15);
            this.label7.TabIndex = 28;
            this.label7.Text = "VALID DATE:";
            // 
            // CreateBoQ_Step1_Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 420);
            this.Controls.Add(this.dtpValidDate);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.txtBOQDesc);
            this.Controls.Add(this.txtBOQTitle);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CreateBoQ_Step1_Frm";
            this.Text = "Create New Bill of Quantity";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgBOQCostSetting)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.ComboBox cboCustomerName;
		private System.Windows.Forms.Label label1;
		private FontAwesome.Sharp.Material.MaterialButton mbtAddSite;
		private FontAwesome.Sharp.Material.MaterialButton mbtAddCustomer;
		private System.Windows.Forms.ComboBox cboSite;
		private System.Windows.Forms.Label label2;
		private FontAwesome.Sharp.Material.MaterialButton mbtNext;
		private FontAwesome.Sharp.Material.MaterialButton mbtCancel;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.DataGridView dtgBOQCostSetting;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TextBox txtTermsCondition;
		private System.Windows.Forms.TextBox txtBOQTitle;
		private System.Windows.Forms.TextBox txtBOQDesc;
		private System.Windows.Forms.DateTimePicker dtpDate;
		private System.Windows.Forms.DateTimePicker dtpValidDate;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}