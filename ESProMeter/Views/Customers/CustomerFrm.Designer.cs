
namespace ESProMeter.Views.Customers
{
	partial class CustomerFrm
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
			this.label1 = new System.Windows.Forms.Label();
			this.txtCustomerName = new System.Windows.Forms.TextBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.chkInActive = new System.Windows.Forms.CheckBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label13 = new System.Windows.Forms.Label();
			this.txtCountry = new System.Windows.Forms.TextBox();
			this.txtProvince = new System.Windows.Forms.TextBox();
			this.txtAddress = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtSalutation = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtFirstName = new System.Windows.Forms.TextBox();
			this.txtLastName = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtJobTitle = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txtPhonePhone = new System.Windows.Forms.TextBox();
			this.txtAltPhone = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.txtFax = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.txtEamil = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.txtWebSite = new System.Windows.Forms.TextBox();
			this.mbtSaveNew = new FontAwesome.Sharp.Material.MaterialButton();
			this.mbtCancel = new FontAwesome.Sharp.Material.MaterialButton();
			this.mbtSaveClose = new FontAwesome.Sharp.Material.MaterialButton();
			this.lblCustID = new System.Windows.Forms.Label();
			this.lblEdSeq = new System.Windows.Forms.Label();
			this.lblAddressID = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(14, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(107, 15);
			this.label1.TabIndex = 0;
			this.label1.Text = "CUSTOMER NAME:";
			// 
			// txtCustomerName
			// 
			this.txtCustomerName.Location = new System.Drawing.Point(124, 5);
			this.txtCustomerName.Name = "txtCustomerName";
			this.txtCustomerName.Size = new System.Drawing.Size(415, 23);
			this.txtCustomerName.TabIndex = 0;
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.panel1.Controls.Add(this.chkInActive);
			this.panel1.Controls.Add(this.txtCustomerName);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(707, 37);
			this.panel1.TabIndex = 2;
			// 
			// chkInActive
			// 
			this.chkInActive.AutoSize = true;
			this.chkInActive.Enabled = false;
			this.chkInActive.Location = new System.Drawing.Point(565, 9);
			this.chkInActive.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.chkInActive.Name = "chkInActive";
			this.chkInActive.Size = new System.Drawing.Size(133, 19);
			this.chkInActive.TabIndex = 13;
			this.chkInActive.Text = "Customer is inactive";
			this.chkInActive.UseVisualStyleBackColor = true;
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.lblEdSeq);
			this.groupBox1.Controls.Add(this.lblCustID);
			this.groupBox1.Controls.Add(this.txtLastName);
			this.groupBox1.Controls.Add(this.txtFirstName);
			this.groupBox1.Controls.Add(this.txtAltPhone);
			this.groupBox1.Controls.Add(this.txtWebSite);
			this.groupBox1.Controls.Add(this.label9);
			this.groupBox1.Controls.Add(this.txtEamil);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.txtFax);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.txtPhonePhone);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.txtJobTitle);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.txtSalutation);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Location = new System.Drawing.Point(1, 50);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(704, 207);
			this.groupBox1.TabIndex = 3;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "CONTACT INFORMATION";
			// 
			// groupBox2
			// 
			this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox2.Controls.Add(this.lblAddressID);
			this.groupBox2.Controls.Add(this.label13);
			this.groupBox2.Controls.Add(this.txtCountry);
			this.groupBox2.Controls.Add(this.txtProvince);
			this.groupBox2.Controls.Add(this.txtAddress);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Location = new System.Drawing.Point(3, 275);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(704, 142);
			this.groupBox2.TabIndex = 3;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "ADDRESS INFORMATION";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(11, 109);
			this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(92, 15);
			this.label13.TabIndex = 20;
			this.label13.Text = "PROVINCE/CITY";
			// 
			// txtCountry
			// 
			this.txtCountry.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txtCountry.Location = new System.Drawing.Point(111, 77);
			this.txtCountry.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.txtCountry.Name = "txtCountry";
			this.txtCountry.Size = new System.Drawing.Size(360, 23);
			this.txtCountry.TabIndex = 11;
			// 
			// txtProvince
			// 
			this.txtProvince.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txtProvince.Location = new System.Drawing.Point(111, 106);
			this.txtProvince.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.txtProvince.Name = "txtProvince";
			this.txtProvince.Size = new System.Drawing.Size(360, 23);
			this.txtProvince.TabIndex = 12;
			// 
			// txtAddress
			// 
			this.txtAddress.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txtAddress.Location = new System.Drawing.Point(111, 24);
			this.txtAddress.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.txtAddress.Multiline = true;
			this.txtAddress.Name = "txtAddress";
			this.txtAddress.PlaceholderText = "Street, Village, Commune, Distric,...";
			this.txtAddress.Size = new System.Drawing.Size(586, 47);
			this.txtAddress.TabIndex = 10;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(42, 80);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(61, 15);
			this.label5.TabIndex = 19;
			this.label5.Text = "COUNTRY";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(47, 24);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(56, 15);
			this.label2.TabIndex = 17;
			this.label2.Text = "ADDRESS";
			// 
			// txtSalutation
			// 
			this.txtSalutation.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txtSalutation.Location = new System.Drawing.Point(113, 22);
			this.txtSalutation.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.txtSalutation.Name = "txtSalutation";
			this.txtSalutation.PlaceholderText = "Salutation";
			this.txtSalutation.Size = new System.Drawing.Size(79, 23);
			this.txtSalutation.TabIndex = 1;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(7, 25);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(97, 15);
			this.label3.TabIndex = 21;
			this.label3.Text = "CONTACT NAME";
			// 
			// txtFirstName
			// 
			this.txtFirstName.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txtFirstName.Location = new System.Drawing.Point(200, 22);
			this.txtFirstName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.txtFirstName.Name = "txtFirstName";
			this.txtFirstName.PlaceholderText = "First Name";
			this.txtFirstName.Size = new System.Drawing.Size(221, 23);
			this.txtFirstName.TabIndex = 2;
			// 
			// txtLastName
			// 
			this.txtLastName.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txtLastName.Location = new System.Drawing.Point(429, 22);
			this.txtLastName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.txtLastName.Name = "txtLastName";
			this.txtLastName.PlaceholderText = "Last Name";
			this.txtLastName.Size = new System.Drawing.Size(221, 23);
			this.txtLastName.TabIndex = 3;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(49, 62);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(57, 15);
			this.label4.TabIndex = 21;
			this.label4.Text = "JOB TITLE";
			// 
			// txtJobTitle
			// 
			this.txtJobTitle.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txtJobTitle.Location = new System.Drawing.Point(113, 59);
			this.txtJobTitle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.txtJobTitle.Name = "txtJobTitle";
			this.txtJobTitle.Size = new System.Drawing.Size(308, 23);
			this.txtJobTitle.TabIndex = 4;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(36, 91);
			this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(68, 15);
			this.label6.TabIndex = 21;
			this.label6.Text = "PHONE NO";
			// 
			// txtPhonePhone
			// 
			this.txtPhonePhone.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txtPhonePhone.Location = new System.Drawing.Point(113, 88);
			this.txtPhonePhone.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.txtPhonePhone.Name = "txtPhonePhone";
			this.txtPhonePhone.PlaceholderText = "Main phone";
			this.txtPhonePhone.Size = new System.Drawing.Size(195, 23);
			this.txtPhonePhone.TabIndex = 5;
			// 
			// txtAltPhone
			// 
			this.txtAltPhone.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txtAltPhone.Location = new System.Drawing.Point(316, 88);
			this.txtAltPhone.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.txtAltPhone.Name = "txtAltPhone";
			this.txtAltPhone.PlaceholderText = "Alternative phone";
			this.txtAltPhone.Size = new System.Drawing.Size(195, 23);
			this.txtAltPhone.TabIndex = 6;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(78, 120);
			this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(27, 15);
			this.label7.TabIndex = 21;
			this.label7.Text = "FAX";
			// 
			// txtFax
			// 
			this.txtFax.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txtFax.Location = new System.Drawing.Point(113, 117);
			this.txtFax.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.txtFax.Name = "txtFax";
			this.txtFax.Size = new System.Drawing.Size(195, 23);
			this.txtFax.TabIndex = 7;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(65, 149);
			this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(41, 15);
			this.label8.TabIndex = 21;
			this.label8.Text = "EMAIL";
			// 
			// txtEamil
			// 
			this.txtEamil.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txtEamil.Location = new System.Drawing.Point(113, 146);
			this.txtEamil.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.txtEamil.Name = "txtEamil";
			this.txtEamil.Size = new System.Drawing.Size(584, 23);
			this.txtEamil.TabIndex = 8;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(54, 178);
			this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(52, 15);
			this.label9.TabIndex = 21;
			this.label9.Text = "WEBSITE";
			// 
			// txtWebSite
			// 
			this.txtWebSite.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txtWebSite.Location = new System.Drawing.Point(113, 175);
			this.txtWebSite.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.txtWebSite.Name = "txtWebSite";
			this.txtWebSite.Size = new System.Drawing.Size(586, 23);
			this.txtWebSite.TabIndex = 9;
			// 
			// mbtSaveNew
			// 
			this.mbtSaveNew.BackColor = System.Drawing.Color.Transparent;
			this.mbtSaveNew.FlatAppearance.BorderColor = System.Drawing.Color.MediumOrchid;
			this.mbtSaveNew.FlatAppearance.BorderSize = 2;
			this.mbtSaveNew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
			this.mbtSaveNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.mbtSaveNew.ForeColor = System.Drawing.Color.Black;
			this.mbtSaveNew.IconChar = FontAwesome.Sharp.MaterialIcons.None;
			this.mbtSaveNew.IconColor = System.Drawing.Color.White;
			this.mbtSaveNew.IconSize = 1;
			this.mbtSaveNew.Location = new System.Drawing.Point(440, 423);
			this.mbtSaveNew.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.mbtSaveNew.Name = "mbtSaveNew";
			this.mbtSaveNew.Size = new System.Drawing.Size(126, 30);
			this.mbtSaveNew.TabIndex = 15;
			this.mbtSaveNew.Text = "Save && New";
			this.mbtSaveNew.UseVisualStyleBackColor = false;
			this.mbtSaveNew.Click += new System.EventHandler(this.mbtSaveNew_Click);
			// 
			// mbtCancel
			// 
			this.mbtCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.mbtCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.mbtCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.mbtCancel.ForeColor = System.Drawing.Color.White;
			this.mbtCancel.IconChar = FontAwesome.Sharp.MaterialIcons.None;
			this.mbtCancel.IconColor = System.Drawing.Color.White;
			this.mbtCancel.IconSize = 1;
			this.mbtCancel.Location = new System.Drawing.Point(574, 423);
			this.mbtCancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.mbtCancel.Name = "mbtCancel";
			this.mbtCancel.Size = new System.Drawing.Size(126, 30);
			this.mbtCancel.TabIndex = 16;
			this.mbtCancel.Text = "Cancel";
			this.mbtCancel.UseVisualStyleBackColor = false;
			this.mbtCancel.Click += new System.EventHandler(this.mbtCancel_Click);
			// 
			// mbtSaveClose
			// 
			this.mbtSaveClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(130)))), ((int)(((byte)(200)))));
			this.mbtSaveClose.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.mbtSaveClose.FlatAppearance.BorderColor = System.Drawing.Color.MediumOrchid;
			this.mbtSaveClose.FlatAppearance.BorderSize = 2;
			this.mbtSaveClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
			this.mbtSaveClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.mbtSaveClose.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.mbtSaveClose.IconChar = FontAwesome.Sharp.MaterialIcons.None;
			this.mbtSaveClose.IconColor = System.Drawing.Color.White;
			this.mbtSaveClose.IconSize = 1;
			this.mbtSaveClose.Location = new System.Drawing.Point(306, 423);
			this.mbtSaveClose.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.mbtSaveClose.Name = "mbtSaveClose";
			this.mbtSaveClose.Size = new System.Drawing.Size(126, 30);
			this.mbtSaveClose.TabIndex = 14;
			this.mbtSaveClose.Text = "Save && Close";
			this.mbtSaveClose.UseVisualStyleBackColor = false;
			this.mbtSaveClose.Click += new System.EventHandler(this.mbtSaveClose_Click);
			// 
			// lblCustID
			// 
			this.lblCustID.AutoSize = true;
			this.lblCustID.Location = new System.Drawing.Point(598, 62);
			this.lblCustID.Name = "lblCustID";
			this.lblCustID.Size = new System.Drawing.Size(84, 15);
			this.lblCustID.TabIndex = 23;
			this.lblCustID.Text = "<customerID>";
			// 
			// lblEdSeq
			// 
			this.lblEdSeq.AutoSize = true;
			this.lblEdSeq.Location = new System.Drawing.Point(598, 91);
			this.lblEdSeq.Name = "lblEdSeq";
			this.lblEdSeq.Size = new System.Drawing.Size(93, 15);
			this.lblEdSeq.TabIndex = 23;
			this.lblEdSeq.Text = "<EditSequense>";
			// 
			// lblAddressID
			// 
			this.lblAddressID.AutoSize = true;
			this.lblAddressID.Location = new System.Drawing.Point(571, 85);
			this.lblAddressID.Name = "lblAddressID";
			this.lblAddressID.Size = new System.Drawing.Size(76, 15);
			this.lblAddressID.TabIndex = 24;
			this.lblAddressID.Text = "<AddressID>";
			// 
			// CustomerFrm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
			this.ClientSize = new System.Drawing.Size(708, 457);
			this.Controls.Add(this.mbtSaveClose);
			this.Controls.Add(this.mbtSaveNew);
			this.Controls.Add(this.mbtCancel);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "CustomerFrm";
			this.Text = "CustomerFrm";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtCustomerName;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.CheckBox chkInActive;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.TextBox txtCountry;
		private System.Windows.Forms.TextBox txtProvince;
		private System.Windows.Forms.TextBox txtAddress;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtLastName;
		private System.Windows.Forms.TextBox txtFirstName;
		private System.Windows.Forms.TextBox txtSalutation;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtJobTitle;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtAltPhone;
		private System.Windows.Forms.TextBox txtFax;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtPhonePhone;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtWebSite;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox txtEamil;
		private System.Windows.Forms.Label label8;
		private FontAwesome.Sharp.Material.MaterialButton mbtCancel;
		private FontAwesome.Sharp.Material.MaterialButton mbtSaveClose;
		private System.Windows.Forms.Label lblEdSeq;
		private System.Windows.Forms.Label lblCustID;
		private System.Windows.Forms.Label lblAddressID;
		public FontAwesome.Sharp.Material.MaterialButton mbtSaveNew;
	}
}