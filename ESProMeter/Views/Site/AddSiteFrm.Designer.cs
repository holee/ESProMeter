
namespace ESProMeter.Views.Sites
{
	partial class AddSiteFrm
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.intEditSequense = new System.Windows.Forms.Label();
			this.textDescription = new System.Windows.Forms.TextBox();
			this.longSiteID = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.textCustomerID = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.textName = new System.Windows.Forms.TextBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.longAddrRefId = new System.Windows.Forms.Label();
			this.textCountry = new System.Windows.Forms.TextBox();
			this.textCity = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.textAddress = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.checkInactive = new System.Windows.Forms.CheckBox();
			this.materialButton2 = new FontAwesome.Sharp.Material.MaterialButton();
			this.btnSave = new FontAwesome.Sharp.Material.MaterialButton();
			this.label8 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.intEditSequense);
			this.groupBox1.Controls.Add(this.checkInactive);
			this.groupBox1.Controls.Add(this.textDescription);
			this.groupBox1.Controls.Add(this.longSiteID);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.textCustomerID);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.textName);
			this.groupBox1.Location = new System.Drawing.Point(14, 14);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.groupBox1.Size = new System.Drawing.Size(656, 195);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "SITE NAME";
			// 
			// intEditSequense
			// 
			this.intEditSequense.AutoSize = true;
			this.intEditSequense.Location = new System.Drawing.Point(7, 157);
			this.intEditSequense.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.intEditSequense.Name = "intEditSequense";
			this.intEditSequense.Size = new System.Drawing.Size(13, 15);
			this.intEditSequense.TabIndex = 6;
			this.intEditSequense.Text = "0";
			this.intEditSequense.Visible = false;
			// 
			// textDescription
			// 
			this.textDescription.Location = new System.Drawing.Point(102, 104);
			this.textDescription.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.textDescription.Multiline = true;
			this.textDescription.Name = "textDescription";
			this.textDescription.Size = new System.Drawing.Size(543, 53);
			this.textDescription.TabIndex = 2;
			// 
			// longSiteID
			// 
			this.longSiteID.AutoSize = true;
			this.longSiteID.Location = new System.Drawing.Point(7, 73);
			this.longSiteID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.longSiteID.Name = "longSiteID";
			this.longSiteID.Size = new System.Drawing.Size(13, 15);
			this.longSiteID.TabIndex = 5;
			this.longSiteID.Text = "0";
			this.longSiteID.Visible = false;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.ForeColor = System.Drawing.Color.DimGray;
			this.label5.Location = new System.Drawing.Point(408, 76);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(226, 15);
			this.label5.TabIndex = 4;
			this.label5.Text = "Select the customer who own the project.";
			// 
			// textCustomerID
			// 
			this.textCustomerID.FormattingEnabled = true;
			this.textCustomerID.Location = new System.Drawing.Point(102, 73);
			this.textCustomerID.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.textCustomerID.Name = "textCustomerID";
			this.textCustomerID.Size = new System.Drawing.Size(299, 23);
			this.textCustomerID.TabIndex = 1;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(15, 104);
			this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(79, 15);
			this.label6.TabIndex = 2;
			this.label6.Text = "DESCRIPTION";
			// 
			// label7
			// 
			this.label7.ForeColor = System.Drawing.Color.DimGray;
			this.label7.Location = new System.Drawing.Point(8, 47);
			this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(637, 23);
			this.label7.TabIndex = 2;
			this.label7.Text = "Name the construction site where you whis to issue quotes and implement your proj" +
    "ect";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(22, 76);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(72, 15);
			this.label4.TabIndex = 2;
			this.label4.Text = "PROJECT OF";
			// 
			// textName
			// 
			this.textName.Location = new System.Drawing.Point(7, 23);
			this.textName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.textName.Name = "textName";
			this.textName.Size = new System.Drawing.Size(308, 23);
			this.textName.TabIndex = 0;
			this.textName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textName_KeyUp);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.longAddrRefId);
			this.groupBox2.Controls.Add(this.textCountry);
			this.groupBox2.Controls.Add(this.textCity);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Controls.Add(this.textAddress);
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Location = new System.Drawing.Point(14, 215);
			this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.groupBox2.Size = new System.Drawing.Size(518, 189);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "ADDRESS INFORMATION";
			// 
			// longAddrRefId
			// 
			this.longAddrRefId.AutoSize = true;
			this.longAddrRefId.Location = new System.Drawing.Point(23, 66);
			this.longAddrRefId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.longAddrRefId.Name = "longAddrRefId";
			this.longAddrRefId.Size = new System.Drawing.Size(13, 15);
			this.longAddrRefId.TabIndex = 5;
			this.longAddrRefId.Text = "0";
			this.longAddrRefId.Visible = false;
			// 
			// textCountry
			// 
			this.textCountry.Location = new System.Drawing.Point(148, 159);
			this.textCountry.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.textCountry.Name = "textCountry";
			this.textCountry.Size = new System.Drawing.Size(361, 23);
			this.textCountry.TabIndex = 5;
			// 
			// textCity
			// 
			this.textCity.Location = new System.Drawing.Point(148, 126);
			this.textCity.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.textCity.Name = "textCity";
			this.textCity.Size = new System.Drawing.Size(361, 23);
			this.textCity.TabIndex = 4;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(23, 167);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(61, 15);
			this.label3.TabIndex = 3;
			this.label3.Text = "COUNTRY";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(23, 129);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(92, 15);
			this.label2.TabIndex = 2;
			this.label2.Text = "PROVINCE/CITY";
			// 
			// textAddress
			// 
			this.textAddress.Location = new System.Drawing.Point(148, 29);
			this.textAddress.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.textAddress.Multiline = true;
			this.textAddress.Name = "textAddress";
			this.textAddress.Size = new System.Drawing.Size(361, 84);
			this.textAddress.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(23, 32);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 15);
			this.label1.TabIndex = 0;
			this.label1.Text = "ADDRESS";
			// 
			// checkInactive
			// 
			this.checkInactive.AutoSize = true;
			this.checkInactive.Location = new System.Drawing.Point(545, 25);
			this.checkInactive.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.checkInactive.Name = "checkInactive";
			this.checkInactive.Size = new System.Drawing.Size(100, 19);
			this.checkInactive.TabIndex = 6;
			this.checkInactive.Text = "Site is inactive";
			this.checkInactive.UseVisualStyleBackColor = true;
			// 
			// materialButton2
			// 
			this.materialButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.materialButton2.ForeColor = System.Drawing.Color.White;
			this.materialButton2.IconChar = FontAwesome.Sharp.MaterialIcons.CloseCircle;
			this.materialButton2.IconColor = System.Drawing.Color.White;
			this.materialButton2.IconSize = 32;
			this.materialButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.materialButton2.Location = new System.Drawing.Point(544, 410);
			this.materialButton2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.materialButton2.Name = "materialButton2";
			this.materialButton2.Size = new System.Drawing.Size(126, 33);
			this.materialButton2.TabIndex = 8;
			this.materialButton2.Text = "Close";
			this.materialButton2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.materialButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.materialButton2.UseVisualStyleBackColor = false;
			this.materialButton2.Click += new System.EventHandler(this.btnCloseClick);
			// 
			// btnSave
			// 
			this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(70)))), ((int)(((byte)(118)))));
			this.btnSave.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.btnSave.ForeColor = System.Drawing.Color.White;
			this.btnSave.IconChar = FontAwesome.Sharp.MaterialIcons.PenPlus;
			this.btnSave.IconColor = System.Drawing.Color.White;
			this.btnSave.IconSize = 27;
			this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnSave.Location = new System.Drawing.Point(410, 410);
			this.btnSave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(126, 33);
			this.btnSave.TabIndex = 7;
			this.btnSave.Text = "Save";
			this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnSave.UseVisualStyleBackColor = false;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// label8
			// 
			this.label8.ForeColor = System.Drawing.Color.DimGray;
			this.label8.Location = new System.Drawing.Point(102, 160);
			this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(543, 31);
			this.label8.TabIndex = 7;
			this.label8.Text = "Give more decription on the site if necessary. You can keep it blank if you think" +
    " that other information is enough for you.";
			// 
			// AddSiteFrm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(676, 446);
			this.Controls.Add(this.materialButton2);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.MaximizeBox = false;
			this.Name = "AddSiteFrm";
			this.Text = "Add New Site";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox textName;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TextBox textCountry;
		private System.Windows.Forms.TextBox textCity;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textAddress;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.CheckBox checkInactive;
		private FontAwesome.Sharp.Material.MaterialButton materialButton2;
		private FontAwesome.Sharp.Material.MaterialButton btnSave;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox textCustomerID;
		private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label longSiteID;
        private System.Windows.Forms.Label longAddrRefId;
        private System.Windows.Forms.TextBox textDescription;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label intEditSequense;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
	}
}