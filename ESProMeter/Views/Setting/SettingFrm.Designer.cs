namespace ESProMeter.Views.Setting
{
    partial class SettingFrm
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabBOQQuote = new System.Windows.Forms.TabPage();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.txtSampleFormat = new System.Windows.Forms.TextBox();
			this.txtRunningNumberFormat = new System.Windows.Forms.TextBox();
			this.txtDateFormat = new System.Windows.Forms.TextBox();
			this.txtPrefix = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtValidDay = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.dtgBOQCostSetting = new System.Windows.Forms.DataGridView();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.label4 = new System.Windows.Forms.Label();
			this.txtTermsCondition = new System.Windows.Forms.TextBox();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.mbtSave = new FontAwesome.Sharp.Material.MaterialButton();
			this.mbtClose = new FontAwesome.Sharp.Material.MaterialButton();
			this.mbtHelp = new FontAwesome.Sharp.Material.MaterialButton();
			this.tabControl1.SuspendLayout();
			this.tabBOQQuote.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dtgBOQCostSetting)).BeginInit();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabBOQQuote);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Location = new System.Drawing.Point(3, 1);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(846, 458);
			this.tabControl1.TabIndex = 0;
			// 
			// tabBOQQuote
			// 
			this.tabBOQQuote.Controls.Add(this.groupBox2);
			this.tabBOQQuote.Controls.Add(this.groupBox1);
			this.tabBOQQuote.Location = new System.Drawing.Point(4, 24);
			this.tabBOQQuote.Name = "tabBOQQuote";
			this.tabBOQQuote.Padding = new System.Windows.Forms.Padding(3);
			this.tabBOQQuote.Size = new System.Drawing.Size(838, 430);
			this.tabBOQQuote.TabIndex = 0;
			this.tabBOQQuote.Text = "BOQ&&QUOTE";
			this.tabBOQQuote.UseVisualStyleBackColor = true;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.groupBox3);
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Controls.Add(this.txtValidDay);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Location = new System.Drawing.Point(4, 234);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(827, 190);
			this.groupBox2.TabIndex = 4;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "QUOTE Settings";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.checkBox1);
			this.groupBox3.Controls.Add(this.txtSampleFormat);
			this.groupBox3.Controls.Add(this.txtRunningNumberFormat);
			this.groupBox3.Controls.Add(this.txtDateFormat);
			this.groupBox3.Controls.Add(this.txtPrefix);
			this.groupBox3.Controls.Add(this.label7);
			this.groupBox3.Controls.Add(this.label8);
			this.groupBox3.Controls.Add(this.label6);
			this.groupBox3.Controls.Add(this.label5);
			this.groupBox3.Location = new System.Drawing.Point(11, 62);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(436, 118);
			this.groupBox3.TabIndex = 5;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Quote number format";
			// 
			// checkBox1
			// 
			this.checkBox1.AutoSize = true;
			this.checkBox1.Location = new System.Drawing.Point(14, 81);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(322, 19);
			this.checkBox1.TabIndex = 13;
			this.checkBox1.Text = "Running number will restart when date format changed.";
			this.checkBox1.UseVisualStyleBackColor = true;
			// 
			// txtSampleFormat
			// 
			this.txtSampleFormat.Location = new System.Drawing.Point(230, 43);
			this.txtSampleFormat.MaxLength = 20;
			this.txtSampleFormat.Name = "txtSampleFormat";
			this.txtSampleFormat.ReadOnly = true;
			this.txtSampleFormat.Size = new System.Drawing.Size(195, 23);
			this.txtSampleFormat.TabIndex = 9;
			// 
			// txtRunningNumberFormat
			// 
			this.txtRunningNumberFormat.Location = new System.Drawing.Point(148, 43);
			this.txtRunningNumberFormat.MaxLength = 5;
			this.txtRunningNumberFormat.Name = "txtRunningNumberFormat";
			this.txtRunningNumberFormat.Size = new System.Drawing.Size(59, 23);
			this.txtRunningNumberFormat.TabIndex = 10;
			this.txtRunningNumberFormat.Text = "000";
			this.txtRunningNumberFormat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.txtRunningNumberFormat.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtRunningNumberFormat_KeyUp);
			// 
			// txtDateFormat
			// 
			this.txtDateFormat.Location = new System.Drawing.Point(70, 43);
			this.txtDateFormat.MaxLength = 7;
			this.txtDateFormat.Name = "txtDateFormat";
			this.txtDateFormat.Size = new System.Drawing.Size(70, 23);
			this.txtDateFormat.TabIndex = 11;
			this.txtDateFormat.Text = "yyyy";
			this.txtDateFormat.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtDateFormat_KeyUp);
			// 
			// txtPrefix
			// 
			this.txtPrefix.Location = new System.Drawing.Point(14, 43);
			this.txtPrefix.MaxLength = 6;
			this.txtPrefix.Name = "txtPrefix";
			this.txtPrefix.Size = new System.Drawing.Size(50, 23);
			this.txtPrefix.TabIndex = 12;
			this.txtPrefix.Text = "ES-Pro";
			this.txtPrefix.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPrefix_KeyUp);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(230, 25);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(54, 15);
			this.label7.TabIndex = 5;
			this.label7.Text = "(Sample)";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(148, 25);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(59, 15);
			this.label8.TabIndex = 6;
			this.label8.Text = "Running#";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(70, 25);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(70, 15);
			this.label6.TabIndex = 7;
			this.label6.Text = "Date format";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(14, 25);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(37, 15);
			this.label5.TabIndex = 8;
			this.label5.Text = "Prefix";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(11, 31);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(86, 15);
			this.label1.TabIndex = 1;
			this.label1.Text = "Quote valid for";
			// 
			// txtValidDay
			// 
			this.txtValidDay.Location = new System.Drawing.Point(97, 28);
			this.txtValidDay.MaxLength = 2;
			this.txtValidDay.Name = "txtValidDay";
			this.txtValidDay.Size = new System.Drawing.Size(37, 23);
			this.txtValidDay.TabIndex = 2;
			this.txtValidDay.Text = "30";
			this.txtValidDay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(133, 31);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(129, 15);
			this.label2.TabIndex = 1;
			this.label2.Text = "day(s) after quote date.";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.dtgBOQCostSetting);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.txtTermsCondition);
			this.groupBox1.Location = new System.Drawing.Point(6, 21);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(826, 197);
			this.groupBox1.TabIndex = 3;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "BOQ Settings";
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
			this.dtgBOQCostSetting.Location = new System.Drawing.Point(9, 21);
			this.dtgBOQCostSetting.Name = "dtgBOQCostSetting";
			this.dtgBOQCostSetting.RowHeadersVisible = false;
			this.dtgBOQCostSetting.RowTemplate.DividerHeight = 1;
			this.dtgBOQCostSetting.RowTemplate.Height = 25;
			this.dtgBOQCostSetting.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.dtgBOQCostSetting.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
			this.dtgBOQCostSetting.Size = new System.Drawing.Size(425, 170);
			this.dtgBOQCostSetting.TabIndex = 9;
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
			this.Column2.FillWeight = 70F;
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
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.Format = "0.00";
			this.Column4.DefaultCellStyle = dataGridViewCellStyle2;
			this.Column4.FillWeight = 20F;
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
			this.Column6.FillWeight = 10F;
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
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(440, 21);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(123, 15);
			this.label4.TabIndex = 2;
			this.label4.Text = "TERMS && CONDITION";
			// 
			// txtTermsCondition
			// 
			this.txtTermsCondition.Location = new System.Drawing.Point(440, 39);
			this.txtTermsCondition.Multiline = true;
			this.txtTermsCondition.Name = "txtTermsCondition";
			this.txtTermsCondition.Size = new System.Drawing.Size(380, 152);
			this.txtTermsCondition.TabIndex = 1;
			// 
			// tabPage2
			// 
			this.tabPage2.Location = new System.Drawing.Point(4, 24);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(838, 430);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "tabPage2";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// mbtSave
			// 
			this.mbtSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(130)))), ((int)(((byte)(200)))));
			this.mbtSave.FlatAppearance.BorderColor = System.Drawing.Color.MediumOrchid;
			this.mbtSave.FlatAppearance.BorderSize = 2;
			this.mbtSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
			this.mbtSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.mbtSave.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.mbtSave.IconChar = FontAwesome.Sharp.MaterialIcons.None;
			this.mbtSave.IconColor = System.Drawing.Color.White;
			this.mbtSave.IconSize = 1;
			this.mbtSave.Location = new System.Drawing.Point(452, 462);
			this.mbtSave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.mbtSave.Name = "mbtSave";
			this.mbtSave.Size = new System.Drawing.Size(126, 30);
			this.mbtSave.TabIndex = 26;
			this.mbtSave.Text = "Save";
			this.mbtSave.UseVisualStyleBackColor = false;
			this.mbtSave.Click += new System.EventHandler(this.mbtSave_Click);
			// 
			// mbtClose
			// 
			this.mbtClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.mbtClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.mbtClose.ForeColor = System.Drawing.Color.White;
			this.mbtClose.IconChar = FontAwesome.Sharp.MaterialIcons.None;
			this.mbtClose.IconColor = System.Drawing.Color.White;
			this.mbtClose.IconSize = 1;
			this.mbtClose.Location = new System.Drawing.Point(586, 462);
			this.mbtClose.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.mbtClose.Name = "mbtClose";
			this.mbtClose.Size = new System.Drawing.Size(126, 30);
			this.mbtClose.TabIndex = 27;
			this.mbtClose.Text = "Close";
			this.mbtClose.UseVisualStyleBackColor = false;
			this.mbtClose.Click += new System.EventHandler(this.mbtClose_Click);
			// 
			// mbtHelp
			// 
			this.mbtHelp.BackColor = System.Drawing.Color.Transparent;
			this.mbtHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.mbtHelp.ForeColor = System.Drawing.Color.Black;
			this.mbtHelp.IconChar = FontAwesome.Sharp.MaterialIcons.None;
			this.mbtHelp.IconColor = System.Drawing.Color.White;
			this.mbtHelp.IconSize = 1;
			this.mbtHelp.Location = new System.Drawing.Point(720, 462);
			this.mbtHelp.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.mbtHelp.Name = "mbtHelp";
			this.mbtHelp.Size = new System.Drawing.Size(126, 30);
			this.mbtHelp.TabIndex = 28;
			this.mbtHelp.Text = "Help";
			this.mbtHelp.UseVisualStyleBackColor = false;
			// 
			// SettingFrm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(853, 500);
			this.Controls.Add(this.mbtHelp);
			this.Controls.Add(this.mbtClose);
			this.Controls.Add(this.mbtSave);
			this.Controls.Add(this.tabControl1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "SettingFrm";
			this.Text = "Settings";
			this.tabControl1.ResumeLayout(false);
			this.tabBOQQuote.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dtgBOQCostSetting)).EndInit();
			this.ResumeLayout(false);

        }

		#endregion

		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabBOQQuote;
		private System.Windows.Forms.TabPage tabPage2;
		private FontAwesome.Sharp.Material.MaterialButton mbtSave;
		private FontAwesome.Sharp.Material.MaterialButton mbtClose;
		private FontAwesome.Sharp.Material.MaterialButton mbtHelp;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.TextBox txtSampleFormat;
		private System.Windows.Forms.TextBox txtRunningNumberFormat;
		private System.Windows.Forms.TextBox txtDateFormat;
		private System.Windows.Forms.TextBox txtPrefix;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtValidDay;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtTermsCondition;
		private System.Windows.Forms.DataGridView dtgBOQCostSetting;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
	}
}