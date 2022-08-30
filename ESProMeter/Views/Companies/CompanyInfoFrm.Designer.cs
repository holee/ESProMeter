namespace ESProMeter.Views.Companies
{
    partial class CompanyInfoFrm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompanyInfoFrm));
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.rbtLegalInformation = new System.Windows.Forms.RadioButton();
			this.rbtContactInformation = new System.Windows.Forms.RadioButton();
			this.panel2 = new System.Windows.Forms.Panel();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.lblCompanyID = new System.Windows.Forms.Label();
			this.txtProvince = new System.Windows.Forms.TextBox();
			this.txtCompanyName = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtFax = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.txtCountry = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtWebSite = new System.Windows.Forms.TextBox();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtMainPhone = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtAddress = new System.Windows.Forms.TextBox();
			this.txtAltPhone = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.lblcomEditSequese = new System.Windows.Forms.Label();
			this.lblContactAddressId = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.txtLoginPath = new System.Windows.Forms.TextBox();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.txtAltLegalCompanyName = new System.Windows.Forms.TextBox();
			this.label14 = new System.Windows.Forms.Label();
			this.txtLegalProvince = new System.Windows.Forms.TextBox();
			this.txtLegalCompanyName = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.txtLegalCountry = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.legalEditSequense = new System.Windows.Forms.Label();
			this.lblLegalAddressId = new System.Windows.Forms.Label();
			this.txtLegalAddress = new System.Windows.Forms.TextBox();
			this.btnClose = new FontAwesome.Sharp.Material.MaterialButton();
			this.btnSave = new FontAwesome.Sharp.Material.MaterialButton();
			this.panel4 = new System.Windows.Forms.Panel();
			this.panel1.SuspendLayout();
			this.panel3.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.tabPage2.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
			this.panel1.Controls.Add(this.panel3);
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Controls.Add(this.tabControl1);
			this.panel1.Controls.Add(this.btnClose);
			this.panel1.Controls.Add(this.btnSave);
			this.panel1.Controls.Add(this.panel4);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Margin = new System.Windows.Forms.Padding(4);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(789, 477);
			this.panel1.TabIndex = 0;
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
			this.panel3.Controls.Add(this.rbtLegalInformation);
			this.panel3.Controls.Add(this.rbtContactInformation);
			this.panel3.Location = new System.Drawing.Point(11, 10);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(161, 417);
			this.panel3.TabIndex = 6;
			// 
			// rbtLegalInformation
			// 
			this.rbtLegalInformation.Appearance = System.Windows.Forms.Appearance.Button;
			this.rbtLegalInformation.FlatAppearance.BorderSize = 0;
			this.rbtLegalInformation.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.rbtLegalInformation.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Info;
			this.rbtLegalInformation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.rbtLegalInformation.Location = new System.Drawing.Point(3, 33);
			this.rbtLegalInformation.Name = "rbtLegalInformation";
			this.rbtLegalInformation.Size = new System.Drawing.Size(155, 28);
			this.rbtLegalInformation.TabIndex = 10;
			this.rbtLegalInformation.Text = "Legal Information";
			this.rbtLegalInformation.UseVisualStyleBackColor = true;
			this.rbtLegalInformation.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
			// 
			// rbtContactInformation
			// 
			this.rbtContactInformation.Appearance = System.Windows.Forms.Appearance.Button;
			this.rbtContactInformation.FlatAppearance.BorderSize = 0;
			this.rbtContactInformation.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.rbtContactInformation.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Info;
			this.rbtContactInformation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.rbtContactInformation.Location = new System.Drawing.Point(3, 2);
			this.rbtContactInformation.Name = "rbtContactInformation";
			this.rbtContactInformation.Size = new System.Drawing.Size(155, 28);
			this.rbtContactInformation.TabIndex = 0;
			this.rbtContactInformation.Text = "Contact Information";
			this.rbtContactInformation.UseVisualStyleBackColor = true;
			this.rbtContactInformation.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.DarkGray;
			this.panel2.Location = new System.Drawing.Point(13, 12);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(161, 417);
			this.panel2.TabIndex = 5;
			// 
			// tabControl1
			// 
			this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Location = new System.Drawing.Point(180, 10);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(595, 417);
			this.tabControl1.TabIndex = 4;
			// 
			// tabPage1
			// 
			this.tabPage1.BackColor = System.Drawing.Color.White;
			this.tabPage1.Controls.Add(this.lblCompanyID);
			this.tabPage1.Controls.Add(this.txtProvince);
			this.tabPage1.Controls.Add(this.txtCompanyName);
			this.tabPage1.Controls.Add(this.label1);
			this.tabPage1.Controls.Add(this.txtFax);
			this.tabPage1.Controls.Add(this.label10);
			this.tabPage1.Controls.Add(this.txtCountry);
			this.tabPage1.Controls.Add(this.label5);
			this.tabPage1.Controls.Add(this.txtWebSite);
			this.tabPage1.Controls.Add(this.txtEmail);
			this.tabPage1.Controls.Add(this.label9);
			this.tabPage1.Controls.Add(this.label6);
			this.tabPage1.Controls.Add(this.label2);
			this.tabPage1.Controls.Add(this.txtMainPhone);
			this.tabPage1.Controls.Add(this.label8);
			this.tabPage1.Controls.Add(this.label3);
			this.tabPage1.Controls.Add(this.txtAddress);
			this.tabPage1.Controls.Add(this.txtAltPhone);
			this.tabPage1.Controls.Add(this.label4);
			this.tabPage1.Controls.Add(this.lblcomEditSequese);
			this.tabPage1.Controls.Add(this.lblContactAddressId);
			this.tabPage1.Controls.Add(this.pictureBox1);
			this.tabPage1.Controls.Add(this.txtLoginPath);
			this.tabPage1.Location = new System.Drawing.Point(4, 28);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(587, 385);
			this.tabPage1.TabIndex = 0;
			// 
			// lblCompanyID
			// 
			this.lblCompanyID.AutoSize = true;
			this.lblCompanyID.Location = new System.Drawing.Point(43, 75);
			this.lblCompanyID.Name = "lblCompanyID";
			this.lblCompanyID.Size = new System.Drawing.Size(16, 17);
			this.lblCompanyID.TabIndex = 19;
			this.lblCompanyID.Text = "0";
			// 
			// txtProvince
			// 
			this.txtProvince.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txtProvince.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtProvince.Location = new System.Drawing.Point(142, 129);
			this.txtProvince.Name = "txtProvince";
			this.txtProvince.Size = new System.Drawing.Size(261, 23);
			this.txtProvince.TabIndex = 3;
			// 
			// txtCompanyName
			// 
			this.txtCompanyName.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txtCompanyName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtCompanyName.Location = new System.Drawing.Point(142, 9);
			this.txtCompanyName.Name = "txtCompanyName";
			this.txtCompanyName.Size = new System.Drawing.Size(439, 23);
			this.txtCompanyName.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
			this.label1.Location = new System.Drawing.Point(17, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(108, 17);
			this.label1.TabIndex = 3;
			this.label1.Text = "Company Name";
			// 
			// txtFax
			// 
			this.txtFax.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txtFax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtFax.Location = new System.Drawing.Point(142, 250);
			this.txtFax.Name = "txtFax";
			this.txtFax.Size = new System.Drawing.Size(261, 23);
			this.txtFax.TabIndex = 7;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
			this.label10.Location = new System.Drawing.Point(17, 256);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(30, 17);
			this.label10.TabIndex = 0;
			this.label10.Text = "Fax";
			// 
			// txtCountry
			// 
			this.txtCountry.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txtCountry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtCountry.Location = new System.Drawing.Point(142, 162);
			this.txtCountry.Name = "txtCountry";
			this.txtCountry.Size = new System.Drawing.Size(261, 23);
			this.txtCountry.TabIndex = 4;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
			this.label5.Location = new System.Drawing.Point(17, 162);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(57, 17);
			this.label5.TabIndex = 0;
			this.label5.Text = "Country";
			// 
			// txtWebSite
			// 
			this.txtWebSite.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txtWebSite.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtWebSite.Location = new System.Drawing.Point(142, 319);
			this.txtWebSite.Name = "txtWebSite";
			this.txtWebSite.Size = new System.Drawing.Size(439, 23);
			this.txtWebSite.TabIndex = 9;
			// 
			// txtEmail
			// 
			this.txtEmail.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtEmail.Location = new System.Drawing.Point(142, 286);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(439, 23);
			this.txtEmail.TabIndex = 8;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
			this.label9.Location = new System.Drawing.Point(17, 198);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(83, 17);
			this.label9.TabIndex = 0;
			this.label9.Text = "Main Phone";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
			this.label6.Location = new System.Drawing.Point(17, 322);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(61, 17);
			this.label6.TabIndex = 0;
			this.label6.Text = "WebSite";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
			this.label2.Location = new System.Drawing.Point(18, 37);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(60, 17);
			this.label2.TabIndex = 0;
			this.label2.Text = "Address";
			// 
			// txtMainPhone
			// 
			this.txtMainPhone.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txtMainPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtMainPhone.Location = new System.Drawing.Point(142, 192);
			this.txtMainPhone.Name = "txtMainPhone";
			this.txtMainPhone.Size = new System.Drawing.Size(261, 23);
			this.txtMainPhone.TabIndex = 5;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
			this.label8.Location = new System.Drawing.Point(17, 289);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(42, 17);
			this.label8.TabIndex = 0;
			this.label8.Text = "Email";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
			this.label3.Location = new System.Drawing.Point(17, 224);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(110, 17);
			this.label3.TabIndex = 0;
			this.label3.Text = "Alternate Phone";
			// 
			// txtAddress
			// 
			this.txtAddress.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtAddress.Location = new System.Drawing.Point(142, 38);
			this.txtAddress.Multiline = true;
			this.txtAddress.Name = "txtAddress";
			this.txtAddress.Size = new System.Drawing.Size(261, 85);
			this.txtAddress.TabIndex = 2;
			// 
			// txtAltPhone
			// 
			this.txtAltPhone.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txtAltPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtAltPhone.Location = new System.Drawing.Point(142, 221);
			this.txtAltPhone.Name = "txtAltPhone";
			this.txtAltPhone.Size = new System.Drawing.Size(261, 23);
			this.txtAltPhone.TabIndex = 6;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
			this.label4.Location = new System.Drawing.Point(17, 129);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(90, 17);
			this.label4.TabIndex = 0;
			this.label4.Text = "Province/City";
			// 
			// lblcomEditSequese
			// 
			this.lblcomEditSequese.AutoSize = true;
			this.lblcomEditSequese.Location = new System.Drawing.Point(27, 353);
			this.lblcomEditSequese.Name = "lblcomEditSequese";
			this.lblcomEditSequese.Size = new System.Drawing.Size(16, 17);
			this.lblcomEditSequese.TabIndex = 7;
			this.lblcomEditSequese.Text = "0";
			// 
			// lblContactAddressId
			// 
			this.lblContactAddressId.AutoSize = true;
			this.lblContactAddressId.Location = new System.Drawing.Point(139, 353);
			this.lblContactAddressId.Name = "lblContactAddressId";
			this.lblContactAddressId.Size = new System.Drawing.Size(16, 17);
			this.lblContactAddressId.TabIndex = 7;
			this.lblContactAddressId.Text = "0";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(424, 37);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(158, 178);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 5;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.DoubleClick += new System.EventHandler(this.pictureBox1_DoubleClick);
			// 
			// txtLoginPath
			// 
			this.txtLoginPath.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txtLoginPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtLoginPath.Location = new System.Drawing.Point(444, 47);
			this.txtLoginPath.Name = "txtLoginPath";
			this.txtLoginPath.Size = new System.Drawing.Size(118, 23);
			this.txtLoginPath.TabIndex = 20;
			// 
			// tabPage2
			// 
			this.tabPage2.BackColor = System.Drawing.Color.White;
			this.tabPage2.Controls.Add(this.txtAltLegalCompanyName);
			this.tabPage2.Controls.Add(this.label14);
			this.tabPage2.Controls.Add(this.txtLegalProvince);
			this.tabPage2.Controls.Add(this.txtLegalCompanyName);
			this.tabPage2.Controls.Add(this.label7);
			this.tabPage2.Controls.Add(this.txtLegalCountry);
			this.tabPage2.Controls.Add(this.label11);
			this.tabPage2.Controls.Add(this.label12);
			this.tabPage2.Controls.Add(this.label13);
			this.tabPage2.Controls.Add(this.legalEditSequense);
			this.tabPage2.Controls.Add(this.lblLegalAddressId);
			this.tabPage2.Controls.Add(this.txtLegalAddress);
			this.tabPage2.Location = new System.Drawing.Point(4, 28);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(587, 385);
			this.tabPage2.TabIndex = 1;
			// 
			// txtAltLegalCompanyName
			// 
			this.txtAltLegalCompanyName.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txtAltLegalCompanyName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtAltLegalCompanyName.Location = new System.Drawing.Point(142, 38);
			this.txtAltLegalCompanyName.Name = "txtAltLegalCompanyName";
			this.txtAltLegalCompanyName.Size = new System.Drawing.Size(439, 23);
			this.txtAltLegalCompanyName.TabIndex = 12;
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(17, 42);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(108, 17);
			this.label14.TabIndex = 15;
			this.label14.Text = "Alt. Legal Name";
			// 
			// txtLegalProvince
			// 
			this.txtLegalProvince.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txtLegalProvince.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtLegalProvince.Location = new System.Drawing.Point(142, 175);
			this.txtLegalProvince.Name = "txtLegalProvince";
			this.txtLegalProvince.Size = new System.Drawing.Size(261, 23);
			this.txtLegalProvince.TabIndex = 14;
			// 
			// txtLegalCompanyName
			// 
			this.txtLegalCompanyName.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txtLegalCompanyName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtLegalCompanyName.Location = new System.Drawing.Point(142, 9);
			this.txtLegalCompanyName.Name = "txtLegalCompanyName";
			this.txtLegalCompanyName.Size = new System.Drawing.Size(439, 23);
			this.txtLegalCompanyName.TabIndex = 11;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(17, 13);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(84, 17);
			this.label7.TabIndex = 12;
			this.label7.Text = "Legal Name";
			// 
			// txtLegalCountry
			// 
			this.txtLegalCountry.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txtLegalCountry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtLegalCountry.Location = new System.Drawing.Point(142, 208);
			this.txtLegalCountry.Name = "txtLegalCountry";
			this.txtLegalCountry.Size = new System.Drawing.Size(261, 23);
			this.txtLegalCountry.TabIndex = 15;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(17, 208);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(57, 17);
			this.label11.TabIndex = 7;
			this.label11.Text = "Country";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(17, 81);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(99, 17);
			this.label12.TabIndex = 8;
			this.label12.Text = "Legal Address";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(17, 175);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(90, 17);
			this.label13.TabIndex = 9;
			this.label13.Text = "Province/City";
			// 
			// legalEditSequense
			// 
			this.legalEditSequense.AutoSize = true;
			this.legalEditSequense.Location = new System.Drawing.Point(37, 304);
			this.legalEditSequense.Name = "legalEditSequense";
			this.legalEditSequense.Size = new System.Drawing.Size(16, 17);
			this.legalEditSequense.TabIndex = 17;
			this.legalEditSequense.Text = "0";
			// 
			// lblLegalAddressId
			// 
			this.lblLegalAddressId.AutoSize = true;
			this.lblLegalAddressId.Location = new System.Drawing.Point(37, 272);
			this.lblLegalAddressId.Name = "lblLegalAddressId";
			this.lblLegalAddressId.Size = new System.Drawing.Size(16, 17);
			this.lblLegalAddressId.TabIndex = 17;
			this.lblLegalAddressId.Text = "0";
			// 
			// txtLegalAddress
			// 
			this.txtLegalAddress.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txtLegalAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtLegalAddress.Location = new System.Drawing.Point(142, 78);
			this.txtLegalAddress.Multiline = true;
			this.txtLegalAddress.Name = "txtLegalAddress";
			this.txtLegalAddress.Size = new System.Drawing.Size(261, 85);
			this.txtLegalAddress.TabIndex = 13;
			// 
			// btnClose
			// 
			this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.btnClose.ForeColor = System.Drawing.Color.White;
			this.btnClose.IconChar = FontAwesome.Sharp.MaterialIcons.CloseCircle;
			this.btnClose.IconColor = System.Drawing.Color.White;
			this.btnClose.IconSize = 32;
			this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnClose.Location = new System.Drawing.Point(653, 435);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(126, 30);
			this.btnClose.TabIndex = 17;
			this.btnClose.Text = "Close";
			this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnClose.UseVisualStyleBackColor = false;
			this.btnClose.Click += new System.EventHandler(this.materialButton2_Click);
			// 
			// btnSave
			// 
			this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(130)))), ((int)(((byte)(200)))));
			this.btnSave.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.btnSave.ForeColor = System.Drawing.Color.White;
			this.btnSave.IconChar = FontAwesome.Sharp.MaterialIcons.PenPlus;
			this.btnSave.IconColor = System.Drawing.Color.White;
			this.btnSave.IconSize = 27;
			this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnSave.Location = new System.Drawing.Point(521, 435);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(126, 30);
			this.btnSave.TabIndex = 16;
			this.btnSave.Text = "Save";
			this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnSave.UseVisualStyleBackColor = false;
			this.btnSave.Click += new System.EventHandler(this.materialButton1_Click);
			// 
			// panel4
			// 
			this.panel4.BackColor = System.Drawing.Color.DarkGray;
			this.panel4.Location = new System.Drawing.Point(187, 13);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(591, 417);
			this.panel4.TabIndex = 7;
			// 
			// CompanyInfoFrm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(789, 477);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MaximizeBox = false;
			this.Name = "CompanyInfoFrm";
			this.Text = "Company Information";
			this.panel1.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtWebSite;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private FontAwesome.Sharp.Material.MaterialButton btnSave;
        private FontAwesome.Sharp.Material.MaterialButton btnClose;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.RadioButton rbtLegalInformation;
		private System.Windows.Forms.RadioButton rbtContactInformation;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.TextBox txtCompanyName;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtFax;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox txtMainPhone;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtAltPhone;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.TextBox txtProvince;
		private System.Windows.Forms.TextBox txtAltLegalCompanyName;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.TextBox txtLegalProvince;
		private System.Windows.Forms.TextBox txtLegalCompanyName;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtLegalCountry;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.TextBox txtLegalAddress;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label lblContactAddressId;
		private System.Windows.Forms.Label lblLegalAddressId;
        private System.Windows.Forms.Label lblcomEditSequese;
        private System.Windows.Forms.Label legalEditSequense;
        private System.Windows.Forms.Label lblCompanyID;
        private System.Windows.Forms.TextBox txtLoginPath;
    }
}