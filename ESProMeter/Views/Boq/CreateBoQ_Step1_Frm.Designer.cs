
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.mbtAddSite = new FontAwesome.Sharp.Material.MaterialButton();
            this.mbtAddCustomer = new FontAwesome.Sharp.Material.MaterialButton();
            this.cboSite = new System.Windows.Forms.ComboBox();
            this.cboCustomerName = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mbtNext = new FontAwesome.Sharp.Material.MaterialButton();
            this.mbtCancel = new FontAwesome.Sharp.Material.MaterialButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtgBOQCostSetting = new System.Windows.Forms.DataGridView();
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
            this.panel1.Controls.Add(this.mbtAddSite);
            this.panel1.Controls.Add(this.mbtAddCustomer);
            this.panel1.Controls.Add(this.cboSite);
            this.panel1.Controls.Add(this.cboCustomerName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(910, 37);
            this.panel1.TabIndex = 0;
            // 
            // mbtAddSite
            // 
            this.mbtAddSite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(130)))), ((int)(((byte)(200)))));
            this.mbtAddSite.FlatAppearance.BorderColor = System.Drawing.Color.MediumOrchid;
            this.mbtAddSite.FlatAppearance.BorderSize = 2;
            this.mbtAddSite.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.mbtAddSite.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mbtAddSite.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.mbtAddSite.IconChar = FontAwesome.Sharp.MaterialIcons.None;
            this.mbtAddSite.IconColor = System.Drawing.Color.White;
            this.mbtAddSite.IconSize = 1;
            this.mbtAddSite.Location = new System.Drawing.Point(822, 6);
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
            this.mbtAddCustomer.FlatAppearance.BorderSize = 2;
            this.mbtAddCustomer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.mbtAddCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mbtAddCustomer.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.mbtAddCustomer.IconChar = FontAwesome.Sharp.MaterialIcons.None;
            this.mbtAddCustomer.IconColor = System.Drawing.Color.White;
            this.mbtAddCustomer.IconSize = 1;
            this.mbtAddCustomer.Location = new System.Drawing.Point(477, 5);
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
            this.cboCustomerName.SelectionChangeCommitted += new System.EventHandler(this.cboCustomerName_SelectionChangeCommitted);
            this.cboCustomerName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cboCustomerName_KeyUp);
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
            this.mbtNext.Location = new System.Drawing.Point(589, 386);
            this.mbtNext.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.mbtNext.Name = "mbtNext";
            this.mbtNext.Size = new System.Drawing.Size(126, 30);
            this.mbtNext.TabIndex = 10;
            this.mbtNext.Text = "Next";
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
            this.mbtCancel.Location = new System.Drawing.Point(723, 386);
            this.mbtCancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.mbtCancel.Name = "mbtCancel";
            this.mbtCancel.Size = new System.Drawing.Size(126, 30);
            this.mbtCancel.TabIndex = 11;
            this.mbtCancel.Text = "Cancel";
            this.mbtCancel.UseVisualStyleBackColor = false;
            this.mbtCancel.Click += new System.EventHandler(this.mbtCancel_Click);
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
            this.groupBox1.Size = new System.Drawing.Size(501, 242);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "BOQ ADDITIONAL COST DEFAULT SETTINGS";
            // 
            // dtgBOQCostSetting
            // 
            this.dtgBOQCostSetting.BackgroundColor = System.Drawing.Color.White;
            this.dtgBOQCostSetting.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgBOQCostSetting.Location = new System.Drawing.Point(9, 22);
            this.dtgBOQCostSetting.Name = "dtgBOQCostSetting";
            this.dtgBOQCostSetting.RowTemplate.Height = 25;
            this.dtgBOQCostSetting.Size = new System.Drawing.Size(483, 214);
            this.dtgBOQCostSetting.TabIndex = 8;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtTermsCondition);
            this.groupBox2.Location = new System.Drawing.Point(511, 140);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(344, 242);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "TERMS && CONDITION";
            // 
            // txtTermsCondition
            // 
            this.txtTermsCondition.Location = new System.Drawing.Point(6, 22);
            this.txtTermsCondition.Multiline = true;
            this.txtTermsCondition.Name = "txtTermsCondition";
            this.txtTermsCondition.Size = new System.Drawing.Size(329, 214);
            this.txtTermsCondition.TabIndex = 9;
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
            this.Controls.Add(this.mbtNext);
            this.Controls.Add(this.mbtCancel);
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
	}
}